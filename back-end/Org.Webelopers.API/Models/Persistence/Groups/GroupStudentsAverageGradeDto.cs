using Org.Webelopers.Api.Models.Persistence.Students;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Models.Persistence.Groups
{
    public class GroupStudentsAverageGradeDto
    {
        public List<StudentAverageGradeDto> StudentAverageGrades { get; set; }
    }
}
