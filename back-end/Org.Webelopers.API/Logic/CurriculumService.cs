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

        public List<Course> GetSemesterCurriculum(Guid semesterId)
        {
            return _context.Courses.Where(x => x.SemesterId == semesterId).ToList();
        }
        public Tuple<List<Course>, List<OptionalCourse>> GetStudentEnrolledCourses(Guid studentId)
        {
            var contracts = _context.StudyContracts.Where(x => x.StudentId == studentId).ToList();

            List<Course> resultCourse = new List<Course>();
            List<OptionalCourse> resultOptional = new List<OptionalCourse>();

            foreach (StudyContract contract in contracts)
            {
                var yearId = (Guid)contract.YearId;

                List<Course> yearCourse = GetYearCurriculum(yearId);
                resultCourse = resultCourse.Concat(yearCourse).ToList();

                resultOptional.Add(contract.OptionalCourse);

            }

            return Tuple.Create(resultCourse, resultOptional);
        }

        public List<Course> GetYearCurriculum(Guid yearId)
        {
            var semesters = _context.StudySemesters.Where(semester => semester.StudyYearId == yearId).Select(sem => sem.Id).ToList();

            List<Course> curriculum = new List<Course>();

            foreach (var semester in semesters)
            {
                List<Course> list = _context.Courses.Where(course => course.SemesterId == semester).ToList();

                if (list.Count != 0)
                {
                    curriculum = curriculum.Concat(list).ToList();
                }
            }
            return curriculum;
        }
    }
}
