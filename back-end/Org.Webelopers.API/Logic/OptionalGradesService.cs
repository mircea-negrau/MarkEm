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

        public void SetGrade(Guid studentId, Guid courseId, short value)
        {
            _context.FindEntityAndThrowIfNullReference<Student>(student => student.AccountId == studentId, 
                $"student {studentId} does not exist");
            _context.FindEntityAndThrowIfNullReference<OptionalCourse>(course => course.Id == courseId, 
                $"course {courseId} does not exist");
            var grade = GetGrade(studentId, courseId);
            if (grade == default)
            {
                if (value == -1)
                {
                    return;
                }
                AddGrade(value, courseId, studentId);
            }
            else
            {
                if (value == - 1)
                {
                    DeleteGrade(grade.Id);
                }
                else
                {
                    UpdateGrade(grade.Id, value);
                }
            }
        }

        private OptionalCourseGrade GetGrade(Guid studentId, Guid courseId) =>
            _context.OptionalGrades
                .FirstOrDefault(grade => grade.StudentId == studentId && grade.CourseId == courseId);

        public List<GradesDetailDto> GetStudentGrades(Guid studentId) =>
            _context.OptionalGrades.Where(x => x.StudentId == studentId).Include(grade => grade.Course)
                .Select(grade => new GradesDetailDto()
                {
                    GradeId = grade.Id,
                    Grade = grade.Grade,
                    CourseName = grade.Course.Name
                }).ToList();
    }
}