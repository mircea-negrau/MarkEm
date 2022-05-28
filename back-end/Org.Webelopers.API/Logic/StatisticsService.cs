using Microsoft.EntityFrameworkCore;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
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

    }



}
