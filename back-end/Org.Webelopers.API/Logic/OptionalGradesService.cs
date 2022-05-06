using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;
using Org.Webelopers.Api.Models.Persistence.Grades;

namespace Org.Webelopers.Api.Logic
{
    public class OptionalGradesService: IOptionalGradesService
    {
        private readonly DatabaseContext _context;
        
        public OptionalGradesService(DatabaseContext context)
        {
            _context = context;
        }

        public void AddGrade(short grade, Guid courseId, Guid studentId)
        {
            _context.Add(new OptionalCourseGrade()
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
            var grade = _context.OptionalGrades.FirstOrDefault(x => x.Id == gradeId);
           
            if (grade == null)
            {
                return;
            }
            
            _context.Remove(grade);
            _context.SaveChanges();
        }
        
        public List<GradesDetailDto> GetStudentGrades(Guid studentId) =>
            _context.OptionalGrades.Where(x => x.StudentId == studentId).Include(grade => grade.Course)
                .Select(grade => new GradesDetailDto()
                {
                    GradeId = grade.Id,
                    Grade = grade.Grade,
                    CourseName = grade.Course.Name
                }).ToList();

        public void UpdateGrade(Guid gradeId, short grade)
        {
            var studentGrade = _context.OptionalGrades.FirstOrDefault(x => x.Id == gradeId);

            if (studentGrade == null)
            {
                return;
            }
            
            studentGrade.Grade = grade;
            _context.SaveChanges();
        }
    }
}