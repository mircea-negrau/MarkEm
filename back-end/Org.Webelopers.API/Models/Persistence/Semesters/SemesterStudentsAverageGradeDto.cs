using Org.Webelopers.Api.Models.Persistence.Students;
using System;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Models.Persistence.Semesters
{
    public class SemesterStudentsAverageGradeDto
    {
        public Guid SemesterId { get; set; }

        public List<StudentAverageGradeDto> StudentAverageGrades { get; set; }
    }
}
