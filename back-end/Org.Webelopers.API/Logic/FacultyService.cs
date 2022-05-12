using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;
using Org.Webelopers.Api.Models.Persistence.Faculties;
using Org.Webelopers.Api.Models.Persistence.Specialization;
using Org.Webelopers.Api.Models.Persistence.StudyDegree;
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
                Id = faculty.Id
            }).ToList();
        }


        public FacultyDetailDto GetAllFacultiesDetails()
        {

            var faculties = _context.Faculties
                .Select(faculty => new FacultyDto()
                {
                    Name = faculty.Name,
                    Id = faculty.Id
                }).ToList();


            var degrees = _context.StudyDegrees.Select(degree => new StudyDegreeDto()
            {
                Name = degree.Name,
                Id = degree.Id
            }).ToList();

            var response = new FacultyDetailDto
            {
                Faculties = faculties,
                Degrees = degrees
            };

            return response;
        }
        public List<SpecialisationDto> GetFacultySpecialisations(Guid facultyId, Guid degreeId)
        {
            return _context.Specialisations.Where(specialisation => specialisation.FacultyId == facultyId &&
            specialisation.StudyDegreeId == degreeId)
               .Select(specialisation => new SpecialisationDto()
               {
                   Id = specialisation.Id,
                   Name = specialisation.Name
               }).ToList();
        }

        public StudentContract GetFacultyById(Guid facultyId) => throw new NotImplementedException(); public void RemoveFaculty(Guid facultyId) => throw new NotImplementedException();
        public void SetChiefOfDepartmentId(Guid chiefId) => throw new NotImplementedException();
        public void SetGroupId(Guid contractId, Guid groupId) => throw new NotImplementedException();
        List<FacultyDetailDto> IFacultyService.GetAllFaculties() => throw new NotImplementedException();
    }

}
