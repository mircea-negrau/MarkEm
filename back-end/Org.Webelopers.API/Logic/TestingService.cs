using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;

namespace Org.Webelopers.Api.Logic
{
    public class TestingService : ITestingService
    {
        #region FieldsAndConstructor

        private readonly DatabaseContext _context;

        public TestingService(DatabaseContext context)
        {
            _context = context;
        }

        #endregion

        public FacultySpecialization CreateRandomSpecialization(string name) =>
            new()
            {
                Id = Guid.NewGuid(),
                Name = name,
                // Semesters = (short) (2 * RandomGetter.Get().Next(3, 5)),
                Semesters = (short) (2 * Enumerable.Range(3, 3).Random()),
                FacultyId = _context.Faculties.Random().Id,
                StudyDegreeId = _context.StudyDegrees.Random().Id,
                StudyLineId = _context.StudyLines.Random().Id
            };

        public HashSet<FacultySpecialization> AddRandomSpecializations(int noOfSpecializations)
        {
            var specializations = new HashSet<FacultySpecialization>();
            string currentTime = $"{DateTimeOffset.Now:yyyy-MM-dd HH:mm:ss}";
            
            Console.WriteLine($"currentTime: {currentTime}");
            for (int i = 0; i < noOfSpecializations; i++)
            {
                var specialization = CreateRandomSpecialization($"{currentTime} Spec{i:00}");
                specializations.Add(specialization);
                Console.WriteLine($"added specialization {specialization.Name}");
            }
            
            _context.Specialisations.AddRange(specializations);
            _context.SaveChanges();
            return specializations;
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
                    short gradeValue = (short)new Random().Next(0, 11);
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
    
        /// <summary>
        /// assumes there are semester contracts
        /// </summary>
        public void AddEnrollmentsToCourse(Guid courseId)
        {
            const int numberOfGroups = 5;
            const int studentsPerGroup = 10;
            var groups = _context.Groups.Take(numberOfGroups).ToList();
            var semesterContracts = _context.SemesterContracts
                .Take(numberOfGroups * studentsPerGroup).ToList();
            int skip = 0;
            var enrollments = new List<StudentMandatoryCourseEnrollment>();
            
            Console.WriteLine($"Found {groups.Count} groups");
            Console.WriteLine($"Found {semesterContracts.Count} semester contracts");
            
            foreach (var group in groups)
            {
                enrollments.AddRange(semesterContracts
                    .Skip(skip)
                    .Take(studentsPerGroup)
                    .Select(semesterContract => new StudentMandatoryCourseEnrollment
                    {
                        Id = Guid.NewGuid(), 
                        StudentContractSemesterId = semesterContract.Id, 
                        MandatoryCourseId = courseId, 
                        GroupId = group.Id,
                    }));

                skip += studentsPerGroup;
            }
            
            Console.WriteLine($"Added {enrollments.Count} enrollments");
            _context.StudentEnrolledCourse.AddRange(enrollments);
            _context.SaveChanges();
        }

        public void AddStudentsWithGradesToOptional()
        {
            AddStudentsWithGradesToOptional(_context.OptionalCourses.Select(course => course.Id).First());
            // const int noOfStudents = 10;
            //
            // var course = _context.OptionalCourses.Include(optionalCourse => optionalCourse.Semester).First();
            // var studyYearId = course.Semester.StudyYearId;
            // var students = _context.Students.Take(noOfStudents).ToList();
            // var currentTime = DateTimeOffset.Now;
            // var grades = new List<OptionalCourseGrade>();
            // Console.WriteLine($"course.Id = {course.Id}");
            // Console.WriteLine($"currentTime = {currentTime:yyyy-MM-dd HH:mm:ss}");
            // Console.WriteLine($"noOfStudents = {students.Count}");
            //
            // foreach (var student in students)
            // {
            //     var contract = new StudentContract
            //     {
            //         Id = Guid.NewGuid(),
            //         SignedAt = currentTime.ToUnixTimeSeconds(),
            //         StudentId = student.AccountId,
            //         StudyYearId = studyYearId
            //     };
            //     _context.Contracts.Add(contract);
            //     _context.SemesterContracts.Add(new StudentContractSemester
            //     {
            //         Id = Guid.NewGuid(),
            //         StudentContractId = contract.Id,
            //         StudySemesterId = course.SemesterId,
            //         OptionalCourseId = course.Id
            //     });
            // }
            //
            // foreach (var student in students)
            // {
            //     _context.OptionalGrades.RemoveRange(GetStudentGrades(student, course));
            //     if (new Random().NextDouble() <= 0.5)
            //     {
            //         short gradeValue = (short) new Random().Next(0, 11);
            //         grades.Add(new OptionalCourseGrade
            //         {
            //             Id = Guid.NewGuid(),
            //             Grade = gradeValue,
            //             CreatedAt = currentTime.ToUnixTimeSeconds(),
            //             CourseId = course.Id,
            //             StudentId = student.AccountId
            //         });
            //         Console.WriteLine($"student {student.AccountId} has grade {gradeValue}");
            //     }
            //     else
            //     {
            //         Console.WriteLine($"student {student.AccountId} has NO grade");
            //     }
            // }
            //
            // _context.OptionalGrades.AddRange(grades);
            // _context.SaveChanges();
        }

        public void AddStudentsWithGradesToOptional(Guid courseId)
        {
            const int noOfStudents = 10;
            
            var course = _context.OptionalCourses
                .Where(optionalCourse => optionalCourse.Id == courseId)
                .Include(optionalCourse => optionalCourse.Semester)
                .First();
            var studyYearId = course.Semester.StudyYearId;
            var students = _context.Students.Take(noOfStudents).ToList();
            var currentTime = DateTimeOffset.Now;
            var grades = new List<OptionalCourseGrade>();
            Console.WriteLine($"course.Id = {course.Id}");
            Console.WriteLine($"currentTime = {currentTime:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"noOfStudents = {students.Count}");

            foreach (var student in students)
            {
                var contract = new StudentContract
                {
                    Id = Guid.NewGuid(),
                    SignedAt = currentTime.ToUnixTimeSeconds(),
                    StudentId = student.AccountId,
                    StudyYearId = studyYearId
                };
                _context.Contracts.Add(contract);
                _context.SemesterContracts.Add(new StudentContractSemester
                {
                    Id = Guid.NewGuid(),
                    StudentContractId = contract.Id,
                    StudySemesterId = course.SemesterId,
                    OptionalCourseId = course.Id
                });
            }

            foreach (var student in students)
            {
                _context.OptionalGrades.RemoveRange(GetStudentGrades(student, course));
                if (new Random().NextDouble() <= 0.5)
                {
                    short gradeValue = (short) new Random().Next(0, 11);
                    grades.Add(new OptionalCourseGrade
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
            Console.WriteLine($"nrOfAddedGrades = {grades.Count}");
            _context.OptionalGrades.AddRange(grades);
            _context.SaveChanges();
        }

        #region PrivateMethods

        private List<OptionalCourseGrade> GetStudentGrades(Student student, OptionalCourse course) => 
            _context.OptionalGrades.Where(grade => grade.StudentId == student.AccountId && grade.CourseId == course.Id).ToList();

        #endregion
    }
}