using System;

namespace Org.Webelopers.Api.Models.Persistence.OptionalCourses
{
    public class TeacherOptional
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public int Semester { get; set; }
    }
}