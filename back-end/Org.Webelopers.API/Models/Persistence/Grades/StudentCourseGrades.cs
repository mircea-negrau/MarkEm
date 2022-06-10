using System;

namespace Org.Webelopers.Api.Models.Persistence.Grades
{
    public class StudentCourseGrades
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string TeacherName { get; set; }
        public GradesDetailDto Grade { get; set; }

    }
}
