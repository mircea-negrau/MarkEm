using Org.Webelopers.Api.Models.Persistence.Students;
using System;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Models.Persistence.StudyYears
{
    public class StudyYearStudentsAverageGradeDto
    {
        public Guid StudyYearId { get; set; }

        public List<StudentAverageGradeDto> StudentAverageGrades { get; set; }
    }
}
