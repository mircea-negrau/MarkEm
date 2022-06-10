using System;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Models.Persistence.OptionalCourses
{
    public class OptionalCoursePreferenceDto
    {
        public Guid ContractId { get; set; }

        public List<Guid> CoursesIds { get; set; }
}
}
