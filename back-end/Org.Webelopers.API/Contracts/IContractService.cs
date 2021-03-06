using Org.Webelopers.Api.Models.DbEntities;
using Org.Webelopers.Api.Models.Persistence.Contracts;
using Org.Webelopers.Api.Models.Persistence.Courses;
using System;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Contracts
{
    public interface IContractService
    {
        public Guid? AddContract(Guid studentId, StudyYear year);
        public StudentContract GetContractById(Guid contractId);
        public void RemoveContract(Guid contractId);
        public void EnrollStudent(Guid studentId, Guid specialisationId);
        public void SetGroupId(Guid contractId, Guid groupId);
        public void SetYearId(Guid contractId, Guid yearId);
        public void SetOptionalCourseId(Guid contractId, Guid optionalCourseId);
        public int GetNumberOfContracts(Guid studentId);
        public List<ContractCourseResponse> GetContractMandatoryCourses(Guid contractId);
        public void SignContract(Guid contractId);
        public OptionalCourse GetOptionalCourse(Guid contractId);
        public List<ContractEnriched> GetStudentContractsEnriched(Guid studentId);
        public List<SemesterContractDto> GetYearlyContractAllSemesterContracts(Guid contractId);

    }
}