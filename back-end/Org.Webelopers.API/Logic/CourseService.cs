using Microsoft.EntityFrameworkCore;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;
using Org.Webelopers.Api.Models.Persistence.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;
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

        public TeacherCourseDetailDto GetEnrichedCourseById(Guid courseId)
        {
            var course = _context.Courses
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
            .FirstOrDefault(x => x.Id == courseId);

            if (course == null)
            {
                throw new Exception("Course ID is invalid!");
            }

            return new TeacherCourseDetailDto()
            {
                Id = course.Id,
                Name = course.Name,
                Credits = course.Credits,
                Semester = course.Semester.Semester,
                StartDate = course.Semester.StudyYear.StartDate,
                EndDate = course.Semester.StudyYear.EndDate,
                IsOptional = false,
                FacultyDetails = new TeacherCourseFacultyDetailDto()
                {
                    Faculty = course.Semester.StudyYear.Specialization.Faculty.Name,
                    Specialization = course.Semester.StudyYear.Specialization.Name,
                    SpecializationSemesters = course.Semester.StudyYear.Specialization.Semesters,
                    StudyDegree = course.Semester.StudyYear.Specialization.StudyDegree.Name,
                    StudyLine = course.Semester.StudyYear.Specialization.StudyLine.Name,
                    StudyLineShort = course.Semester.StudyYear.Specialization.StudyLine.ShortName,
                }
            };
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

        // private short GetGrade(Guid studentId, Guid courseId)
        // {
        //     var grades = _context.Grades.Where(grade => grade.StudentId == studentId && grade.CourseId == courseId).ToList();
        //     return grades.Any() ? grades.First().Grade : (short) -1;
        // }

        private static short GetGrade2(List<short> grades) =>
            (short)(grades.Any() ? grades.First() : -1);

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



        public async Task<ChiefTeachersWithCoursesInfo> GetChiefChiefTeachersWithCoursesInfo(Guid facultyId)
        {
            // 1. get all the teachers with their profile from the facultyId
            var courses = _context.Specialisations
                .Where(specialization => specialization.FacultyId == facultyId)
                .Include(specialization => specialization.StudyYears)
                .SelectMany(specialization => specialization.StudyYears)
                .Include(year => year.Semesters)
                .SelectMany(year => year.Semesters)
                .Include(semester => semester.Courses)
                .SelectMany(semester => semester.Courses)
                .Include(course => course.Teacher)
                .ThenInclude(teacher => teacher.Account);

            // return new ChiefTeachersWithCoursesInfo {ChiefTeachersWithCoursesInfos = new List<ChiefTeachersWithCoursesInfo>()};
            return new ChiefTeachersWithCoursesInfo { ChiefTeachersWithCoursesInfoList = await GetChiefTeachersWithCoursesFromCourses(courses) };
        }

        private static Task<List<ChiefTeacherWithCoursesInfo>> GetChiefTeachersWithCoursesFromCourses(IIncludableQueryable<MandatoryCourse, Account> courses)
        {
            var list = courses
                .Select(course => course.Teacher)
                .Distinct()
                .ToList()
                .Select(teacher => new ChiefTeacherWithCoursesInfo()
                {
                    TeacherName = $"{teacher.Account.LastName} {teacher.Account.FirstName}",
                    ChiefTeacherCoursesInfo = courses.Where(course => course.TeacherId == teacher.AccountId)
                        .Select(course => new ChiefTeacherCourseInfo
                        {
                            Specialization = course.Semester.StudyYear.Specialization.Name,
                            Year = course.Semester.GetYearNumber(),
                            Semester = course.Semester.Semester,
                            Name = course.Name,
                            Credits = course.Credits
                        })
                        .ToList()
                })
                .ToList();

            return Task.FromResult(list);
        }
    }
}
