

using Org.Webelopers.Api.Models.Persistence.Semester;
using System;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Models.Persistence.Grades
{
    public class SemesterCourseGrades
    {
        public Guid Id { get; set; }
        public short Value { get; set; }
        public long YearStartDate { get; set; }
        public long YearEndDate { get; set; }
        public string SpecializationName { get; set; }
        public List<StudentCourseGrades> Courses { get; set; }

    }
}
