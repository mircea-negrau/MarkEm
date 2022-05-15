using System;

namespace Org.Webelopers.Api.Models.Persistence.OptionalCourses
{
    public class OptionalChiefView // will be displayed by Degree, StudyLine, Specialization, Semester, Name, TeacherName, Credits
    {
        // BaseCourse
        public Guid Id { get; set; }
        public string Name { get; set; }
        public short Credits { get; set; }
        
        // BaseCourse references
        public string TeacherLastName { get; set; }
        public string TeacherFirstName { get; set; }
        public int Semester { get; set; }
        
        // OptionalCourse
        public bool IsApproved { get; set; }
        public int Capacity { get; set; }
        
        // specialization details
        public string StudyDegree { get; set; }
        public string StudyLine { get; set; }
        public string StudyLineShort { get; set; }
        public string Specialization { get; set; }
    }
}