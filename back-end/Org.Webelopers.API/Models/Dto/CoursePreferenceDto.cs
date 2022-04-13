using System;

namespace Org.Webelopers.Api.Models.Dto
{
    public class CoursePreferenceDto
    {
        public short Preference { get; set; }
        public Guid ContractId { get; set; }
        public Guid OptionalCourseId { get; set; }
    }
}
