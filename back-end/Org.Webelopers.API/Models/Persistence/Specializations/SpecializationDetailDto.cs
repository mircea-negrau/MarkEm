using Org.Webelopers.Api.Models.Persistence.Faculties;
using Org.Webelopers.Api.Models.Persistence.StudyDegree;
using Org.Webelopers.Api.Models.Persistence.StudyLine;
using System;

namespace Org.Webelopers.Api.Models.Persistence.Specialization
{
    public class SpecializationDetailDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public short Semesters { get; set; }
        public FacultyDto Faculty { get; set; }
        public StudyDegreeDto StudyDegree { get; set; }
        public StudyLineDto StudyLine { get; set; }
    }
}
