using Org.Webelopers.Api.Models.Persistence.Students;
using System;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Models.Persistence.Groups
{
    public class GroupStudentsAverageGradeDto
    {
        public Guid GroupId { get; set; }

        public List<StudentAverageGradeDto> StudentAverageGrades { get; set; }
    }
}
