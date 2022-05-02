using Microsoft.EntityFrameworkCore;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.Persistence.Groups;
using Org.Webelopers.Api.Models.Persistence.Students;
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

        public List<StudentAverageGradeDto> GetStudentsRankingBySemester() => throw new NotImplementedException();
        
        public List<StudentAverageGradeDto> GetStudentsRankingByStudyYear() => throw new NotImplementedException();
    }
}
