using Org.Webelopers.Api.Models.DbEntities;
using Org.Webelopers.Api.Models.Dto;
using Org.Webelopers.Api.Models.Persistence.Contracts;
using Org.Webelopers.Api.Models.Persistence.Faculties;
using System;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Contracts
{
    public interface IFacultyService
    {
        public Guid? AddFaculty(String name);
        public StudentContract GetFacultyById(Guid facultyId);
        public void RemoveFaculty(Guid facultyId);
        public void SetGroupId(Guid contractId, Guid groupId);
        public void SetChiefOfDepartmentId(Guid chiefId);
        public List<FacultyDetailDto> GetAllFaculties();
        public FacultyDetailDto GetAllFacultiesDetails();

    }
}