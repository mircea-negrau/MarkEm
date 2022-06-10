using System;

namespace Org.Webelopers.Api.Models.Persistence.Semester
{
    public class SemesterDto
    {
        public Guid Id { get; set; }
        public short Value { get; set; }
        public long YearStartDate { get; set; }
        public long YearEndDate { get; set; }
        public string SpecializationName { get; set; }
    }
}
