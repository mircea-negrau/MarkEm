using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.Persistence.Semester;
using System.Collections.Generic;
using System.Linq;

namespace Org.Webelopers.Api.Logic
{
    public class SemesterService : ISemesterService
    {
        private readonly DatabaseContext _context;

        public SemesterService(DatabaseContext context)
        {
            _context = context;
        }

        public List<SemesterDto> GetAllSemesters()
        {
            return _context.StudySemesters.
                Select(x => new SemesterDto()
            {
                Id = x.Id,
                Value = x.Semester,
                SpecializationName = x.StudyYear.Specialization.Name,
                YearEndDate = x.StudyYear.EndDate,
                YearStartDate = x.StudyYear.StartDate
                }).ToList();
        }
    }
}
