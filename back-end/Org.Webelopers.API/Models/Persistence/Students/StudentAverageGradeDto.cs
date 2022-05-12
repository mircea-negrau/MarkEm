using System;

namespace Org.Webelopers.Api.Models.Persistence.Students
{
    public class StudentAverageGradeDto
    {
        public Guid StudentId { get; set; }

        public decimal AverageGrade { get; set; }
    }
}
