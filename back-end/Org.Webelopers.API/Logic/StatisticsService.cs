using Microsoft.EntityFrameworkCore;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.Dto;
using Org.Webelopers.Api.Models.Persistence.Performance;
using Org.Webelopers.Api.Models.Persistence.Students;
using Org.Webelopers.Api.Models.Persistence.StudyYears;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Org.Webelopers.Api.Logic
{
    public class StatisticsService : IStatisticsService
    {
        private readonly DatabaseContext _context;

        public StatisticsService(DatabaseContext context)
        {
            _context = context;
        }

        public List<StudentPerformanceDto> GetStudentsPerformance(Filter filter, int minimumAverage) => throw new NotImplementedException();

        public List<StudentAverageGradeDto> GetStudentsRankingByGroup(Guid groupId)
        {
            var contractsByGroup = _context.Students
                .Include(x => x.Contracts)
                .Where(x => x.Contracts.FirstOrDefault(y => y.GroupId == groupId) != null)
                .Select(x => x.Contracts.FirstOrDefault(y => y.GroupId == groupId))
                .ToList();
            var groupStudentsAverageGrades = new List<StudentAverageGradeDto>();
            foreach (var contract in contractsByGroup)
            {
                var courses = _context.Grades.Include(x => x.Course).Where(x => x.StudentId == contract.StudentId);
                int gradesWeight = courses.Sum(x => Convert.ToInt32(x.Grade) * Convert.ToInt32(x.Course.Credits));
                int creditsWeight = courses.Sum(x => Convert.ToInt32(x.Course.Credits));
                if (creditsWeight != 0)
                {
                    decimal averageGrade = gradesWeight / creditsWeight;
                    var student = _context.Accounts.FirstOrDefault(student => student.Id == contract.StudentId);
                    var name = student.FirstName + " " + student.LastName;
                    var username = student.Username;

                    groupStudentsAverageGrades.Add(
                        new StudentAverageGradeDto()
                        {
                            StudentId = contract.StudentId,
                            AverageGrade = averageGrade,
                            StudentName = name,
                            StudentUser = username
                        });
                }

            }
            return groupStudentsAverageGrades.OrderBy(x => x.AverageGrade).ToList();
        }

        public List<StudentAverageGradeDto> GetStudentsRankingBySemester(Guid semesterId)
        {
            var semester = _context.StudySemesters.FirstOrDefault(semester => semester.Id == semesterId);
            var semesterStudentsAverageGrades = new List<StudentAverageGradeDto>();
            if (semester != null)
            {

                var contractsBySemester = _context.Students
                     .Include(x => x.Contracts)
                     .Where(x => x.Contracts.FirstOrDefault(y => y.StudyYearId == semester.StudyYearId) != null)
                     .Select(x => x.Contracts.FirstOrDefault(y => y.StudyYearId == semester.StudyYearId))
                     .ToList();
                var averages = new List<double>();
                foreach (var contract in contractsBySemester)
                {
                    var courses = _context.Grades.Include(x => x.Course).Where(x => x.StudentId == contract.StudentId);
                    int gradesWeight = courses.Sum(x => Convert.ToInt32(x.Grade) * Convert.ToInt32(x.Course.Credits));
                    int creditsWeight = courses.Sum(x => Convert.ToInt32(x.Course.Credits));
                    if (creditsWeight != 0)
                    {
                        decimal averageGrade = gradesWeight / creditsWeight;
                        var student = _context.Accounts.FirstOrDefault(student => student.Id == contract.StudentId);
                        var name = student.FirstName + " " + student.LastName;
                        var username = student.Username;

                        semesterStudentsAverageGrades.Add(
                            new StudentAverageGradeDto()
                            {
                                StudentId = contract.StudentId,
                                AverageGrade = averageGrade,
                                StudentName = name,
                                StudentUser = username
                            });
                    }

                }
            }
            return semesterStudentsAverageGrades.OrderBy(x => x.AverageGrade).ToList();
        }

        public List<StudentAverageGradeDto> GetStudentsRankingByStudyYearByCriteria(Guid yearId, int minimumAverage)
        {

            var studentsByYear = new List<StudyYearStudentsAverageGradeDto>();

            var contractsBySemester = _context.Students
                 .Include(x => x.Contracts)
                 .Where(x => x.Contracts.FirstOrDefault(y => y.StudyYearId == yearId) != null)
                 .Select(x => x.Contracts.FirstOrDefault(y => y.StudyYearId == yearId))
                 .ToList();
            var averages = new List<double>();
            var semesterStudentsAverageGrades = new List<StudentAverageGradeDto>();
            foreach (var contract in contractsBySemester)
            {
                var courses = _context.Grades.Include(x => x.Course).Where(x => x.StudentId == contract.StudentId);
                int gradesWeight = courses.Sum(x => Convert.ToInt32(x.Grade) * Convert.ToInt32(x.Course.Credits));
                int creditsWeight = courses.Sum(x => Convert.ToInt32(x.Course.Credits));
                if (creditsWeight != 0)
                {
                    decimal averageGrade = gradesWeight / creditsWeight;
                    var student = _context.Accounts.FirstOrDefault(student => student.Id == contract.StudentId);
                    var name = student.FirstName + " " + student.LastName;
                    var username = student.Username;

                    semesterStudentsAverageGrades.Add(
                        new StudentAverageGradeDto()
                        {
                            StudentId = contract.StudentId,
                            AverageGrade = averageGrade,
                            StudentName = name,
                            StudentUser = username
                        });
                }

            }
            return semesterStudentsAverageGrades.Where(x => x.AverageGrade > minimumAverage).OrderBy(x => x.AverageGrade).ToList();

        }

        public List<TeacherPerformanceDto> GetTeachersPerformanceRanking(Guid chiefId)
        {
            var facultyId = _context.Faculties.FirstOrDefault(x => x.ChiefOfDepartmentId == chiefId)?.Id;
            if (facultyId == null)
            {
                throw new Exception("Given chief id is invalid!");
            }
            var courseGrades = _context.Courses.Include(x => x.Grades).ToList();
            var specialisations = _context.Specialisations.Where(x => x.FacultyId == facultyId).Select(x => x.Id).ToList();
            var studyYears = _context.StudyYears.Where(x => specialisations.Contains(x.SpecializationId)).Select(x => x.Id).ToList();
            var semesters = _context.StudySemesters.Where(x => studyYears.Contains(x.StudyYearId)).Select(x => x.Id).ToList();
            var courses = _context.Courses.Include(x => x.Grades).Include(x => x.Teacher).Where(x => semesters.Contains(x.SemesterId)).ToList();
            var coursesGroupedByTeacher = courses.GroupBy(x => x.Teacher).ToList();
            return coursesGroupedByTeacher
                .Select(group =>
                {
                    var grades = group.SelectMany(course => course.Grades).Select(x => Convert.ToInt32(x.Grade)).ToList();
                    double? performance = null;
                    if (grades.Count > 0)
                    {
                        performance = group.SelectMany(course => course.Grades).Select(x => Convert.ToInt32(x.Grade)).Average();
                    }
                    return new TeacherPerformanceDto
                    {
                        TeacherId = group.Key.AccountId,
                        TeacherFirstName = _context.Accounts.FirstOrDefault(x => x.Id == group.Key.AccountId).FirstName,
                        TeacherLastName = _context.Accounts.FirstOrDefault(x => x.Id == group.Key.AccountId).LastName,
                        TeacherPerformance = performance
                    };
                })
                .ToList();
        }

        public List<CoursePerformanceDto> GetCoursesPerformanceRanking(Guid chiefId)
        {
            var facultyId = _context.Faculties.FirstOrDefault(x => x.ChiefOfDepartmentId == chiefId)?.Id;
            if (facultyId == null)
            {
                throw new Exception("Given chief id is invalid!");
            }
            var courseGrades = _context.Courses.Include(x => x.Grades).ToList();
            var specialisations = _context.Specialisations.Where(x => x.FacultyId == facultyId).Select(x => x.Id).ToList();
            var studyYears = _context.StudyYears.Where(x => specialisations.Contains(x.SpecializationId)).Select(x => x.Id).ToList();
            var semesters = _context.StudySemesters.Where(x => studyYears.Contains(x.StudyYearId)).Select(x => x.Id).ToList();
            var courses = _context.Courses.Include(x => x.Grades).Where(x => semesters.Contains(x.SemesterId)).ToList();
            return courses
                .Select(course =>
                {
                    var grades = course.Grades.Select(x => Convert.ToInt32(x.Grade)).ToList();
                    double? performance = null;
                    if (grades.Count > 0)
                    {
                        performance = grades.Average();
                    }
                    return new CoursePerformanceDto
                    {
                        CourseId = course.Id,
                        CourseName = course.Name,
                        CoursePerformance = performance
                    };
                })
                .ToList();
        }

    }



}
