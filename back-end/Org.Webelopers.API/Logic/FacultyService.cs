using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;
using Org.Webelopers.Api.Models.Persistence.Faculties;
using Org.Webelopers.Api.Models.Persistence.Specialization;
using Org.Webelopers.Api.Models.Persistence.StudyDegree;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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

        public HashSet<Faculty> GetFaculties() => _context.Faculties.ToHashSet();

        public Guid GetChiefId(Guid facultyId) =>
            _context.FindEntityAndThrowIfNullReference<Faculty>(faculty => faculty.Id == facultyId, 
                $"faculty {facultyId} doesn't exists").ChiefOfDepartmentId.GetValueOrDefault();

        public Guid GetFacultyIdBy(Guid chiefId)
        {   // TODO: IDEA create a IdDoesNotExistException on DatabaseContext and use it in FindEntityAndThrowIfNullReference
            _context.FindEntityAndThrowIfNullReference<Teacher>(teacher => teacher.AccountId == chiefId, 
                $"teacher {chiefId} doesn't exists");

            return _context.FindEntityAndThrowIfNullReference<Faculty>(faculty => faculty.ChiefOfDepartmentId == chiefId, 
                $"teacher {chiefId} is not a chief of department").Id;
        }

        public HashSet<Teacher> GetFacultyTeachers(Guid facultyId)
        {
            _context.FindEntityAndThrowIfNullReference<Faculty>(faculty => faculty.Id == facultyId,
                $"faculty {facultyId} does not exist");

            return _context.Faculties
                .AsNoTracking()
                .Where(faculty => faculty.Id == facultyId)
                .Include(faculty => faculty.Specialisations)
                    .ThenInclude(specialization => specialization.StudyYears)
                    .ThenInclude(year => year.Semesters)
                    .ThenInclude(semester => semester.Courses)
                    .ThenInclude(course => course.Teacher)
                    .ThenInclude(teacher => teacher.Account)
                .SelectMany(faculty => faculty.Specialisations)
                .SelectMany(specialization => specialization.StudyYears)
                .SelectMany(year => year.Semesters)
                .SelectMany(semester => semester.Courses)
                .Select(course => course.Teacher)
                .Distinct()
                .ToHashSet();
        }
    }

}
