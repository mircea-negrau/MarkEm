using System;

namespace Org.Webelopers.Api.Models.Persistence.Grades
{
    public class SetGradeDto
    {
        public Guid StudentId { get; set; }
        public short Value { get; set; }
    }
}