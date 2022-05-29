using System;

namespace Org.Webelopers.Api.Models.Dto
{
    public class TeacherPerformanceDto
    {
        public Guid Id { get; set; }

        public string LastName { get; set; }
        public string FirstName { get; set; }

        public double TeacherPerformance { get; set; }

    }
}
