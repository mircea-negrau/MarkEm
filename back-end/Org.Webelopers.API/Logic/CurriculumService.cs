using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Org.Webelopers.Api.Logic
{
    public class CurriculumService : ICurriculumService
    {
        private readonly DatabaseContext _context;

        public CurriculumService(DatabaseContext context)
        {
            _context = context;
        }

        public List<MandatoryCourse> GetSemesterCurriculum(Guid semesterId) =>
            _context.Courses.Where(x => x.SemesterId == semesterId).ToList();

        public Tuple<List<MandatoryCourse>, List<OptionalCourse>> GetStudentEnrolledCourses(Guid studentId)
        {
            return Tuple.Create(new List<MandatoryCourse>(), new List<OptionalCourse>());
        }

        public List<MandatoryCourse> GetYearCurriculum(Guid yearId)
        {
            var semesters = _context.StudySemesters.Where(semester => semester.StudyYearId == yearId).Select(sem => sem.Id).ToList();

            List<MandatoryCourse> curriculum = new List<MandatoryCourse>();

            foreach (var semester in semesters)
            {
                List<MandatoryCourse> list = _context.Courses.Where(course => course.SemesterId == semester).ToList();

                if (list.Count != 0)
                {
                    curriculum = curriculum.Concat(list).ToList();
                }
            }
            return curriculum;
        }
    }
}
