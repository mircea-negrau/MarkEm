using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Org.Webelopers.Api.Logic
{
    public class CourseService : ICourseService
    {
        private readonly DatabaseContext _context;

        public CourseService(DatabaseContext context)
        {
            _context = context;
        }

        public void AddCourse(string name, short credits, Guid semesterId, Guid teacherId)
        {
            _context.Add(new MandatoryCourse()
            {
                Id = Guid.NewGuid(),
                Name = name,
                Credits = credits,
                SemesterId = semesterId,
                TeacherId = teacherId
            });
            _context.SaveChanges();
        }

        public void DeleteCourse(Guid courseId)
        {
            var course = _context.Courses.FirstOrDefault(x => x.Id == courseId);
            if (course != null)
            {
                _context.Courses.Remove(course);
                _context.SaveChanges();
            }
        }

        public void UpdateCourse(Guid courseId, string name, short? credits, Guid? semesterId, Guid? teacherId)
        {
            var course = _context.Courses.FirstOrDefault(x => x.Id == courseId);
            if (course != null)
            {
                course.Name = name == "" ? course.Name : name;
                course.Credits = credits ?? course.Credits;
                course.SemesterId = semesterId ?? course.SemesterId;
                course.TeacherId = teacherId ?? course.TeacherId;
                _context.Courses.Update(course);
                _context.SaveChanges();
            }
        }

        public List<MandatoryCourse> GetCoursesByTeacher(Guid teacherId) =>
            _context.Courses.Where(x => x.TeacherId == teacherId).ToList();
    }
}
