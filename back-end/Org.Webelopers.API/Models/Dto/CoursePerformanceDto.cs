using System;

namespace Org.Webelopers.Api.Models.Dto
{
    public class CoursePerformanceDto
    {
        public Guid CourseId { get; set; }
        public string CourseName { get; set; }
        public double? CoursePerformance { get; set; }
    }
}
