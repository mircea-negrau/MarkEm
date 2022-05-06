using System;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Models.Persistence.OptionalCourses
{
    public class OptionalCoursePreferenceDto
    {
        public Guid contractId { get; set; }

        public List<Guid> contractIds { get; set; }
}
}
