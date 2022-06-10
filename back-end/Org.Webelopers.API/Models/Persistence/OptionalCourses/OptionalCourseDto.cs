using System;

namespace Org.Webelopers.Api.Models.Persistence.OptionalCourses
{
    public class OptionalCourseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int? MaxNumberOfStudent { get; set; }
        public int Credits { get; set; }
        public string TeacherName { get; set; }
    }
}
