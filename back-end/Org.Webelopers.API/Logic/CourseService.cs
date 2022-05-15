using Microsoft.EntityFrameworkCore;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;
using Org.Webelopers.Api.Models.Persistence.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Org.Webelopers.Api.Models.Persistence.Groups;

namespace Org.Webelopers.Api.Logic
{
    public class CourseService : ICourseService
    {
        private readonly DatabaseContext _context;

        public CourseService(DatabaseContext context)
        {
            _context = context;
        }

        public void AddCourse(string name, short credits, Guid semesterId, Guid teacherId)
        {
            _context.Add(new MandatoryCourse()
            {
                Id = Guid.NewGuid(),
                Name = name,
                Credits = credits,
                SemesterId = semesterId,
                TeacherId = teacherId
            });
            _context.SaveChanges();
        }

        public void DeleteCourse(Guid courseId)
        {
            var course = _context.Courses.FirstOrDefault(x => x.Id == courseId);
            if (course != null)
            {
                _context.Courses.Remove(course);
                _context.SaveChanges();
            }
        }

        public void UpdateCourse(Guid courseId, string name, short? credits, Guid? semesterId, Guid? teacherId)
        {
            var course = _context.Courses.FirstOrDefault(x => x.Id == courseId);
            if (course != null)
            {
                course.Name = name == "" ? course.Name : name;
                course.Credits = credits ?? course.Credits;
                course.SemesterId = semesterId ?? course.SemesterId;
                course.TeacherId = teacherId ?? course.TeacherId;
                _context.Courses.Update(course);
                _context.SaveChanges();
            }
        }

        public async Task<TeacherCoursesResponse> GetEnrichedCoursesByTeacher(Guid teacherId)
        {
            var courses = _context.Courses.AsNoTracking()
                .Where(x => x.TeacherId == teacherId);
            var enrichedCourses = await courses
            .Include(x => x.Semester)
                .ThenInclude(y => y.StudyYear)
                .ThenInclude(y => y.Specialization)
                .ThenInclude(y => y.StudyLine)
            .Include(x => x.Semester)
                .ThenInclude(y => y.StudyYear)
                .ThenInclude(y => y.Specialization)
                .ThenInclude(y => y.StudyDegree)
            .Include(x => x.Semester)
                .ThenInclude(y => y.StudyYear)
                .ThenInclude(y => y.Specialization)
                .ThenInclude(y => y.Faculty)
            .Select(x => new TeacherCourseDetailDto()
            {
                Id = x.Id,
                Name = x.Name,
                Credits = x.Credits,
                Semester = x.Semester.Semester,
                StartDate = x.Semester.StudyYear.StartDate,
                EndDate = x.Semester.StudyYear.EndDate,
                IsOptional = false,
                FacultyDetails = new TeacherCourseFacultyDetailDto()
                {
                    Faculty = x.Semester.StudyYear.Specialization.Faculty.Name,
                    Specialization = x.Semester.StudyYear.Specialization.Name,
                    SpecializationSemesters = x.Semester.StudyYear.Specialization.Semesters,
                    StudyDegree = x.Semester.StudyYear.Specialization.StudyDegree.Name,
                    StudyLine = x.Semester.StudyYear.Specialization.StudyLine.Name,
                    StudyLineShort = x.Semester.StudyYear.Specialization.StudyLine.ShortName,
                }
            })
            .ToListAsync();
            return new TeacherCoursesResponse() { Courses = enrichedCourses };
        }


        public void AddSamplesForGetCourseGroups()
        {
            // Group -> SemesterContractCourses -> SemesterContract -> Contract -> Student
            //                                                                  -> StudyYear
            //                                                      -> Semester -> StudyYear
            //                                  -> Course -> Semester -> StudyYear
            //                                            -> Teacher ...
            
            // out of all these dependencies,
            // we have: Course -> {Teacher,Semester -> StudyYear}, Student
            // we need: Group, SemesterContractCourses -> SemesterContract -> Contract
            
            // steps:
            // 1. get some
                // 1.1 random Course with its Semester (in order to access the StudyYearId)
                // 1.2 random Students
            // 2. create groups for those students (like 3 groups or something)
                // 2.1 remove the old groups
                // 2.2 create the new groups
            // 3. create for those students
                // 3.1 Contracts
                // 3.2 SemesterContracts
                // 3.3 SemesterContractCourses
            // 4. remove old grades (if any) AND add random grades (if random() <= 0.5)
            
            const int noOfStudents = 50;
            const int noOfGroups = 3;
            
            // 1
            var course = _context.Courses.Include(mandatoryCourse => mandatoryCourse.Semester).First();
            var studyYearId = course.Semester.StudyYearId;
            var students = _context.Students.Take(noOfStudents).ToList();
            int groupSize = (int)Math.Ceiling(students.Count * 1.0 / noOfGroups);

            var groups = new List<FacultyGroup>();            
            var contracts = new List<StudentContract>();
            var semesterContracts = new List<StudentContractSemester>();

            var currentTime = DateTimeOffset.Now;
            string groupNumberPrefix = $"{currentTime:yyyy-MM-dd HH:mm:ss}";
            
            Console.WriteLine($"course.Id: {course.Id} course.Name: {course.Name}");
            Console.WriteLine($"currentTime: {currentTime}");
            
            for (int i = 1; i <= noOfGroups; i++)
            {
                var group = new FacultyGroup
                {
                    Id = Guid.NewGuid(),
                    Number = $"{groupNumberPrefix}-gr{i}",
                    StudyYearId = studyYearId // TODO: is it really needed
                };
                groups.Add(group);
                Console.WriteLine($"Create group {group.Id} {group.Number}");
            }

            for (int i = 0; i < students.Count; i++)
            {
                var student = students[i];
                // Console.WriteLine($"i={i}, {i / groupSize}, groups.Count = {groups.Count}");
                var groupId = groups[i / groupSize].Id;
                var contract = new StudentContract
                {
                    Id = Guid.NewGuid(),
                    SignedAt = currentTime.ToUnixTimeSeconds(),
                    StudentId = student.AccountId,
                    StudyYearId = studyYearId,
                    GroupId = groupId
                };
                contracts.Add(contract);
                var semesterContract = new StudentContractSemester
                {
                    Id = Guid.NewGuid(),
                    StudentContractId = contract.Id,
                    StudySemesterId = course.SemesterId
                };
                semesterContracts.Add(semesterContract);
                _context.StudentEnrolledCourse.Add(new StudentMandatoryCourseEnrollment
                {
                    Id = Guid.NewGuid(),
                    StudentContractSemesterId = semesterContract.Id,
                    MandatoryCourseId = course.Id,
                    GroupId = groupId
                });
                foreach (MandatoryCourseGrade mandatoryCourseGrade in _context.Grades
                             .Where(grade => grade.CourseId == course.Id && grade.StudentId == student.AccountId))
                {
                    _context.Grades.Remove(mandatoryCourseGrade);
                }
            }
            
            foreach (StudentMandatoryCourseEnrollment studentMandatoryCourseEnrollment in _context.StudentEnrolledCourse.Where(enrollment => enrollment.MandatoryCourseId == course.Id))
            {
                _context.StudentEnrolledCourse.Remove(studentMandatoryCourseEnrollment);
            }
            
            _context.Groups.AddRange(groups);
            _context.Contracts.AddRange(contracts);
            _context.SemesterContracts.AddRange(semesterContracts);
            _context.SaveChanges();

            foreach (var student in students)
            {
                Console.WriteLine($"student {student.AccountId} has {_context.Grades.Count(grade => grade.StudentId == student.AccountId && grade.CourseId == course.Id)} grades in this course");

                if (new Random().NextDouble() <= 0.5)
                {
                    short gradeValue = (short) new Random().Next(0, 11); 
                    _context.Grades.Add(new MandatoryCourseGrade
                    {
                        Id = Guid.NewGuid(),
                        Grade = gradeValue,
                        CreatedAt = currentTime.ToUnixTimeSeconds(),
                        CourseId = course.Id,
                        StudentId = student.AccountId
                    });
                    Console.WriteLine($"student {student.AccountId} has grade {gradeValue}");
                }
                else
                {
                    Console.WriteLine($"student {student.AccountId} has NO grade");
                }
            }      
            _context.SaveChanges();
        }

        // private short GetGrade(Guid studentId, Guid courseId)
        // {
        //     var grades = _context.Grades.Where(grade => grade.StudentId == studentId && grade.CourseId == courseId).ToList();
        //     return grades.Any() ? grades.First().Grade : (short) -1;
        // }

        private static short GetGrade2(List<short> grades) => 
            (short) (grades.Any() ? grades.First() : -1);

        public async Task<TeacherGroupsResponse> GetCourseGroups(Guid courseId)
        {
            // AddSamplesForGetCourseGroups();
            var groups = _context.Groups.AsNoTracking()
                .Include(group => group.StudentEnrolledCourses)
                .Where(group => group.StudentEnrolledCourses.FirstOrDefault(enrollment => enrollment.MandatoryCourseId == courseId) !=
                                default);
            var enrichedGroups = await groups
                .Include(group => group.Contracts)
                    .ThenInclude(contract => contract.Student)
                    .ThenInclude(student => student.Account)
                .Include(group => group.Contracts)
                    .ThenInclude(contract => contract.Student)
                    .ThenInclude(student => student.Grades)
                .Select(group => new TeacherGroup
                {
                    Id = group.Id,
                    Number = group.Number,
                    Students = group.Contracts
                        .Select(contract => contract.Student)
                        .Select(student => new StudentWithGrade
                        {
                            Id = student.AccountId,
                            LastName = student.Account.LastName,
                            FirstName = student.Account.FirstName,
                            // Grade = student.Grades
                            //     .Where(grade => grade.CourseId == courseId)
                            //     .Select(grade => grade.Grade)
                            //     .DefaultIfEmpty<short>(-1)
                            // .First()
                            // Grade = GetGrade(student.AccountId, courseId)
                            Grade = GetGrade2(student.Grades.Where(grade => grade.CourseId == courseId).Select(grade => grade.Grade).ToList())
                        })
                        .OrderBy(student => student.LastName)
                        .ThenBy(student => student.FirstName)
                        .ToList()
                })
                .OrderBy(group => group.Number)
                .ToListAsync();
            
            return new TeacherGroupsResponse
            {
                Groups = enrichedGroups
            };
        }
        
        public bool Exists(Guid courseId) => _context.FindEntity<MandatoryCourse>(course => course.Id == courseId) != default;

        public bool IsCourseTaughtBy(Guid courseId, Guid teacherId) => 
            _context.Courses.FirstOrDefault(course => course.Id == courseId && course.TeacherId == teacherId) != default;

        public HashSet<MandatoryCourse> GetFacultyCourses(Guid facultyId)
        {
            _context.FindEntityAndThrowIfNullReference<Faculty>(faculty => faculty.Id == facultyId,
                $"faculty {facultyId} does not exist");

            return _context.Faculties
                .AsNoTracking()
                .Where(faculty => faculty.Id == facultyId)
                .Include(faculty => faculty.Specialisations)
                .SelectMany(faculty => faculty.Specialisations)
                .Include(specialization => specialization.StudyYears)
                .SelectMany(specialization => specialization.StudyYears)
                .Include(year => year.Semesters)
                .SelectMany(year => year.Semesters)
                .Include(semester => semester.Courses)
                .SelectMany(semester => semester.Courses)
                .Distinct()
                .ToHashSet();
        }
    }
}
