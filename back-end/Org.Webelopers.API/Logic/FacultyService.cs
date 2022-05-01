using Microsoft.EntityFrameworkCore;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;
using Org.Webelopers.Api.Models.Dto;
using Org.Webelopers.Api.Models.Persistence.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Org.Webelopers.Api.Logic
{
    public class FacultyService : IFacultyService
    {
        private readonly DatabaseContext _context;

        public FacultyService(DatabaseContext context)
        {
            _context = context;
        }

        public Guid? AddFaculty(string name) => throw new NotImplementedException();
        public List<FacultyDto> GetAllFaculties()
        {
            return _context.Faculties.Select(faculty => new FacultyDto()
            {
                Name = faculty.Name,
                FacultyId = faculty.Id
            }).ToList();
        }


        public List<FacultyDto> GetAllFacultySpecialisations(Guid facultyId)
        {
            var specialisations = _context.Faculties.Where(faculty => faculty.Id == facultyId).Include(faculty => faculty.Specialisations);
            return specialisations.Select(specialisation => new FacultyDto() 
            { 
                FacultyId = specialisation.Id, 
                Name = specialisation.Name
            }).ToList();

        }
        public StudentContract GetFacultyById(Guid facultyId) => throw new NotImplementedException();
        public void RemoveFaculty(Guid facultyId) => throw new NotImplementedException();
        public void SetChiefOfDepartmentId(Guid chiefId) => throw new NotImplementedException();
        public void SetGroupId(Guid contractId, Guid groupId) => throw new NotImplementedException();
    }
      
}
