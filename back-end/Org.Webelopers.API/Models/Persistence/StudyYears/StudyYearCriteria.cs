using System;

namespace Org.Webelopers.Api.Models.Persistence.StudyYears
{
    public class StudyYearCriteriaDto
    {
        public Guid YearId { get; set; }

        public int MinimumAverage { get; set; }
    }
}
