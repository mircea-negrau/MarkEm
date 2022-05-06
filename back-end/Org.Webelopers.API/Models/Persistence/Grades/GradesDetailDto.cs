using System;

namespace Org.Webelopers.Api.Models.Persistence.Grades
{
    public class GradesDetailDto
    {
        public Guid GradeId { get; set; }

        public short Grade { get; set; }
        public string CourseName { get; set; }

    }
}
