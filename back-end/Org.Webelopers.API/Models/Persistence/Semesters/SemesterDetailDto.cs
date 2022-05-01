using Org.Webelopers.Api.Models.Persistence.StudyYears;
using System;

namespace Org.Webelopers.Api.Models.Persistence.Semester
{
    public class SemesterDetailDto
    {
        public Guid Id { get; set; }
        public short Value { get; set; }
        public StudyYearDetailDto StudyYear { get; set; }
    }
}
