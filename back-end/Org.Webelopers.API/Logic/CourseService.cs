using Microsoft.EntityFrameworkCore;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;
using Org.Webelopers.Api.Models.Persistence.Courses;
using System;
using System.Linq;
using System.Threading.Tasks;

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

        public async Task<TeacherCoursesResponse> GetEnrichedCoursesByTeacher(Guid teacherId)
        {
            var courses = _context.Courses.AsNoTracking()
                .Where(x => x.TeacherId == teacherId);
            var enrichedCourses = await courses
            .Include(x => x.Semester)
                .ThenInclude(y => y.StudyYear)
                .ThenInclude(y => y.Specialization)
                .ThenInclude(y => y.StudyLine)
            .Include(x => x.Semester)
                .ThenInclude(y => y.StudyYear)
                .ThenInclude(y => y.Specialization)
                .ThenInclude(y => y.StudyDegree)
            .Include(x => x.Semester)
                .ThenInclude(y => y.StudyYear)
                .ThenInclude(y => y.Specialization)
                .ThenInclude(y => y.Faculty)
            .Select(x => new TeacherCourseDetailDto()
            {
                Id = x.Id,
                Name = x.Name,
                Credits = x.Credits,
                Semester = x.Semester.Semester,
                StartDate = x.Semester.StudyYear.StartDate,
                EndDate = x.Semester.StudyYear.EndDate,
                IsOptional = false,
                FacultyDetails = new TeacherCourseFacultyDetailDto()
                {
                    Faculty = x.Semester.StudyYear.Specialization.Faculty.Name,
                    Specialization = x.Semester.StudyYear.Specialization.Name,
                    SpecializationSemesters = x.Semester.StudyYear.Specialization.Semesters,
                    StudyDegree = x.Semester.StudyYear.Specialization.StudyDegree.Name,
                    StudyLine = x.Semester.StudyYear.Specialization.StudyLine.Name,
                    StudyLineShort = x.Semester.StudyYear.Specialization.StudyLine.ShortName,
                }
            })
            .ToListAsync();
            return new TeacherCoursesResponse() { Courses = enrichedCourses };
        }

    }
}
