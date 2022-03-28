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
        public List<Course> GetStudentEnrolledCourses(Guid studentId)
        {
            var contracts = _context.StudyContracts.Where(x => x.StudentId == studentId).ToList();

            List<Course> result = new List<Course>();

            /*foreach(StudyContract contract in contracts)
            {
                var yearId = contract.YearId;

                var list = _context.Courses.Where(course => course.)
            }*/

            //Can't give curriculum because we have optionalcourses and normal courses, different types
            //

            return null;
        }

        public List<Course> GetYearCurriculum(Guid yearId)
        {
            var semesters = _context.StudySemesters.Where(semester => semester.StudyYearId == yearId).ToList();

            if (semesters.Count == 0)
                return null;

            List<Course> curriculum = new List<Course>();

            foreach (var semester in semesters)
            {
                List<Course> list = _context.Courses.Where(course => course.SemesterId == semester.Id).ToList();

                if (list.Count != 0)
                {
                    curriculum = curriculum.Concat(list).ToList();
                }
            }

            return curriculum;

        }
    }
}
