using Microsoft.EntityFrameworkCore;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.Authentication;
using Org.Webelopers.Api.Models.DbEntities;
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

        public Teacher GetBestResultsTeacher()
        {
            return _context.Teachers.OrderByDescending(x => x.TeacherDegree).FirstOrDefault();
        }

        public Course GetBestResultsCourses()
        {
            return _context.Courses.OrderByDescending(x => x.Grades).FirstOrDefault();
        }

        public List<StudentsResults> GetStudentsResults()
        {
            return _context.Students.Include(x => x.Grades)
                .Select(x => new StudentsResults() { Id = x.Id, Grades = x.Grades,
                    AverageGrade = x.Grades.Select(y => (long)y.Grade).Average() })
                .ToList();
        }

        public List<StudentsResults> GetStudentsByGroup()
        {
            return _context.Groups
        }

        public List<StudentsResults> GetStudentsByYear()
        {

        }
    }
}
