

using Org.Webelopers.Api.Models.Persistence.Contracts;
using System;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Models.Persistence.Grades
{
    public class ContractSemesterGrades
    {
        public Guid Id { get; set; }
        public long? SignedAt { get; set; }
        public string? Specialisation { get; set; }
        public string? Faculty { get; set; }
        public List<SemesterCourseGrades> Semesters { get; set; }

    }
}
