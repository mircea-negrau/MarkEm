using System;

namespace Org.Webelopers.Api.Models.Persistence.Courses
{
    public class ContractCourseResponse
    {
        public Guid Id { get; set; }
        public short Semester { get; set; }
        public short Credits { get; set; }
        public string Name { get; set; }
        public string TeacherFirstName { get; set; }
        public string TeacherLastName { get; set; }
    }
}
