using Org.Webelopers.Api.Models.Persistence.StudyDegree;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Models.Persistence.Faculties
{
    public class FacultyDetailDto
    {
        public List<FacultyDto> Faculties { get; set; }
        public List<StudyDegreeDto> StudyDegrees { get; set; }

    }
}
