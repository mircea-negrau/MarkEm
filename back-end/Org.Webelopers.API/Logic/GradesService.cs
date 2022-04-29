using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Org.Webelopers.Api.Logic
{
    public class GradesService : IGradesService
    {
        private readonly DatabaseContext _context;
        public GradesService(DatabaseContext context)
        {
            _context = context;
        }

        public void AddGrade(short grade, Guid courseId, Guid studentId)
        {
            _context.Add(new MandatoryCourseGrade()
            {
                Id = Guid.NewGuid(),
                Grade = grade,
                CreatedAt = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds(),
                CourseId = courseId,
                StudentId = studentId
            });
            _context.SaveChanges();
        }
        public void DeleteGrade(Guid gradeId)
        {
            var grade = _context.Grades.FirstOrDefault(x => x.Id == gradeId);
            if (grade != null)
            {
                _context.Remove(grade);
                _context.SaveChanges();
            }
        }
        public List<MandatoryCourseGrade> GetStudentGrades(Guid studentId)
        {
            return _context.Grades.Where(x => x.StudentId == studentId).ToList();
        }

        public void UpdateGrade(Guid gradeId, short grade)
        {
            var studentGrade = _context.Grades.FirstOrDefault(x => x.Id == gradeId);

            if (studentGrade != null)
            {
                studentGrade.Grade = grade;
                _context.SaveChanges();
            }

        }
    }
}
