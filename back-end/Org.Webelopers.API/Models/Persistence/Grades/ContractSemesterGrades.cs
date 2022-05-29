

using Org.Webelopers.Api.Models.Persistence.Contracts;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Models.Persistence.Grades
{
    public class ContractSemesterGrades
    {
        public ContractEnriched Contract { get; set; }
        public List<SemesterCourseGrades> Semesters { get; set; }

    }
}
