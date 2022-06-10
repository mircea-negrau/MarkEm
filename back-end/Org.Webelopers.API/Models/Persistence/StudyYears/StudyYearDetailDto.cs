using Org.Webelopers.Api.Models.Persistence.Specialization;
using System;

namespace Org.Webelopers.Api.Models.Persistence.StudyYears
{
    public class StudyYearDetailDto
    {
        public Guid Id { get; set; }

        public long StartDate { get; set; }

        public long EndDate { get; set; }

        public SpecializationDetailDto? Specialization { get; set; }
    }
}
