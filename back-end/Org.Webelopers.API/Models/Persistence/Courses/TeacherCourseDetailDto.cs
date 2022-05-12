using System;

namespace Org.Webelopers.Api.Models.Persistence.Courses
{
    public class TeacherCourseDetailDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public short Credits { get; set; }

        public short Semester { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
        
        public bool IsOptional { get; set; }
        public TeacherCourseFacultyDetailDto FacultyDetails { get; set; }
    }
}
