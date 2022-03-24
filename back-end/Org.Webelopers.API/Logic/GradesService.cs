using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;
using System;
using System.Collections.Generic;

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
            _context.Add(new CourseGrade()
            {
                Id = Guid.NewGuid(),
                Grade = grade,
                CreatedAt = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds(),
                CourseId = courseId,
                StudentId = studentId
            });
            _context.SaveChanges();
        }

        public void DeleteGrade(int classid, int studentid) => throw new NotImplementedException();
        public List<CourseGrade> GetStudentGrades(int studentid) => throw new NotImplementedException();
        public void UpdateGrade(CourseGrade newgrade) => throw new NotImplementedException();
    }
}
