using System;

namespace Org.Webelopers.Api.Models.Dto
{
    public class TeacherPerformanceDto
    {
        public Guid TeacherId { get; set; }
        public string TeacherFirstName { get; set; }
        public string TeacherLastName { get; set; }
        public double? TeacherPerformance { get; set; }
    }
}
