using Org.Webelopers.Api.Models.Persistence.Students;
using System;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Models.Persistence.Performance
{
    public class StudentPerformanceDto
    {
        public Guid filterId { get; set; }
        public string filter { get; set; }
        public List<StudentAverageGradeDto> grades { get; set; }
    }
}
