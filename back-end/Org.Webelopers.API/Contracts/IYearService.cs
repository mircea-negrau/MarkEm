using Org.Webelopers.Api.Models.Persistence.StudyYears;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Contracts
{
    public interface IYearService
    {
        public List<StudyYearDto> GetAllYears();
    }
}