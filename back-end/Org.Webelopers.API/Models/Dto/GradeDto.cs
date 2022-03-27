using System;

namespace Org.Webelopers.Api.Models.Dto
{
    public class GradeDto
    {
        public short Grade { get; set; }
        public Guid CourseId { get; set; }
    }
}
