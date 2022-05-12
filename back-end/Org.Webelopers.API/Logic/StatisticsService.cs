using Microsoft.EntityFrameworkCore;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.Persistence.Groups;
using Org.Webelopers.Api.Models.Persistence.Semesters;
using Org.Webelopers.Api.Models.Persistence.Students;
using Org.Webelopers.Api.Models.Persistence.StudyYears;
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

        public List<GroupStudentsAverageGradeDto> GetStudentsRankingByGroup()
        {
            var groups = _context.Groups.ToList();
            var studentsByGroup = new List<GroupStudentsAverageGradeDto>();
            foreach (var group in groups)
            {
                var contractsByGroup = _context.Students
                    .Include(x => x.Contracts)
                    .Where(x => x.Contracts.FirstOrDefault(y => y.GroupId == group.Id) != null)
                    .Select(x => x.Contracts.FirstOrDefault(y => y.GroupId == group.Id))
                    .ToList();
                var groupStudentsAverageGrades = new List<StudentAverageGradeDto>();
                foreach (var contract in contractsByGroup)
                {
                    var courses = _context.Grades.Include(x => x.Course).Where(x => x.StudentId == contract.StudentId);
                    int gradesWeight = courses.Sum(x => x.Grade * x.Course.Credits);
                    int creditsWeight = courses.Sum(x => x.Course.Credits);
                    decimal averageGrade = gradesWeight / creditsWeight;
                    groupStudentsAverageGrades.Add(new StudentAverageGradeDto()
                    {
                        StudentId = contract.StudentId,
                        AverageGrade = averageGrade
                    });
                }
                studentsByGroup.Add(
                    new GroupStudentsAverageGradeDto()
                    {
                        GroupId = group.Id,
                        StudentAverageGrades = groupStudentsAverageGrades
                    });
            }
            return studentsByGroup;
        }

        public List<SemesterStudentsAverageGradeDto> GetStudentsRankingBySemester()
        {
            var semesters = _context.StudySemesters.ToList();
            var studentsBySemester = new List<SemesterStudentsAverageGradeDto>();
            foreach (var semester in semesters)
            {
                var contractsBySemester = _context.Students
                    .Include(x => x.Contracts)
                    .Where(x => x.Contracts.FirstOrDefault(y => y.StudyYearId == semester.StudyYearId) != null)
                    .Select(x => x.Contracts.FirstOrDefault(y => y.StudyYearId == semester.StudyYearId))
                    .ToList();
                var semesterStudentsAverageGrades = new List<StudentAverageGradeDto>();
                foreach (var contract in contractsBySemester)
                {
                    var courses = _context.Grades.Include(x => x.Course).Where(x => x.StudentId == contract.StudentId);
                    int gradesWeight = courses.Sum(x => x.Grade * x.Course.Credits);
                    int creditsWeight = courses.Sum(x => x.Course.Credits);
                    decimal averageGrade = gradesWeight / creditsWeight;
                    semesterStudentsAverageGrades.Add(
                        new StudentAverageGradeDto()
                        {
                            StudentId = contract.StudentId,
                            AverageGrade = averageGrade
                        });
                }
                studentsBySemester.Add(
                    new SemesterStudentsAverageGradeDto()
                    {
                        SemesterId = semester.Id,
                        StudentAverageGrades = semesterStudentsAverageGrades
                    });
            }
            return studentsBySemester;
        }
        
        public List<StudyYearStudentsAverageGradeDto> GetStudentsRankingByStudyYear()
        {
            var years = _context.StudyYears.ToList();
            var studentsByYear = new List<StudyYearStudentsAverageGradeDto>();
            foreach (var year in years)
            {
                var contractsByYear = _context.Students
                    .Include(x => x.Contracts)
                    .Where(x => x.Contracts.FirstOrDefault(y => y.StudyYearId == year.Id) != null)
                    .Select(x => x.Contracts.FirstOrDefault(y => y.StudyYearId == year.Id))
                    .ToList();
                var yearStudentsAverageGrades = new List<StudentAverageGradeDto>();
                foreach (var contract in contractsByYear)
                {
                    var courses = _context.Grades.Include(x => x.Course).Where(x => x.StudentId == contract.StudentId);
                    int gradesWeight = courses.Sum(x => x.Grade * x.Course.Credits);
                    int creditsWeight = courses.Sum(x => x.Course.Credits);
                    decimal averageGrade = gradesWeight / creditsWeight;
                    yearStudentsAverageGrades.Add(new StudentAverageGradeDto()
                    {
                        StudentId = contract.StudentId,
                        AverageGrade = averageGrade
                    });
                }
                studentsByYear.Add(
                    new StudyYearStudentsAverageGradeDto()
                    {
                        StudyYearId = year.Id,
                        StudentAverageGrades = yearStudentsAverageGrades
                    });
            }
            return studentsByYear;
        }
    }
}
