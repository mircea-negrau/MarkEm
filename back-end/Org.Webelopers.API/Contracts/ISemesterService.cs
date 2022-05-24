using Org.Webelopers.Api.Models.Persistence.Semester;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Contracts
{
    public interface ISemesterService
    {
        public List<SemesterDto> GetAllSemesters();
    }
}