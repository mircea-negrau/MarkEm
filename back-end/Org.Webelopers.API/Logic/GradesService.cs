using Microsoft.EntityFrameworkCore;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;
using Org.Webelopers.Api.Models.Persistence.Grades;
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

        public void UpdateGrade(Guid gradeId, short grade)
        {
            var studentGrade = _context.Grades.FirstOrDefault(x => x.Id == gradeId);

            if (studentGrade != null)
            {
                studentGrade.Grade = grade;
                _context.SaveChanges();
            }
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

        public void SetGrade(Guid studentId, Guid courseId, short value)
        {
            _context.FindEntityAndThrowIfNullReference<Student>(student => student.AccountId == studentId, 
                $"student {studentId} does not exist");
            _context.FindEntityAndThrowIfNullReference<MandatoryCourse>(course => course.Id == courseId, 
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
        private MandatoryCourseGrade GetGrade(Guid studentId, Guid courseId) =>
            _context.Grades
                .FirstOrDefault(grade => grade.StudentId == studentId && grade.CourseId == courseId);


        public List<GradesDetailDto> GetStudentGrades(Guid studentId)
        {
            return _context.Grades.Where(x => x.StudentId == studentId).Include(grade => grade.Course)
                .Select(grade => new GradesDetailDto()
                {
                    GradeId = grade.Id,
                    Grade = grade.Grade,
                    CourseName = grade.Course.Name
                }).ToList();
        }
    }
}
