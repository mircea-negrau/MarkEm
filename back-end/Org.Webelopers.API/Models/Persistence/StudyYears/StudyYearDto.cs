using System;

namespace Org.Webelopers.Api.Models.Persistence.StudyYears
{
    public class StudyYearDto
    {
        public Guid Id { get; set; }

        public long StartDate { get; set; }

        public long EndDate { get; set; }

        public string SpecialisationName { get; set; }

    }
}
