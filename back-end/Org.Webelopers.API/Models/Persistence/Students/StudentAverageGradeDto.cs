using System;

namespace Org.Webelopers.Api.Models.Persistence.Students
{
    public class StudentAverageGradeDto
    {
        public Guid StudentId { get; set; }
        public decimal AverageGrade { get; set; }
        public string StudentUser { get; set; }
        public string StudentName { get; set; }
    }
}
