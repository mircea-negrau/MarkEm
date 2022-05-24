using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.Persistence.StudyYears;
using System.Collections.Generic;
using System.Linq;

namespace Org.Webelopers.Api.Logic
{
    public class YearService : IYearService
    {
        private readonly DatabaseContext _context;

        public YearService(DatabaseContext context)
        {
            _context = context;
        }
        public List<StudyYearDto> GetAllYears()
        {
            return _context.StudyYears.Select(year => new StudyYearDto()
            {
                Id = year.Id,
                EndDate = year.EndDate,
                StartDate = year.StartDate,
                SpecialisationName = year.Specialization.Name
            }).ToList();
        }
    }
}
