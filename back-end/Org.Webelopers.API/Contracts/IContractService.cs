
using Org.Webelopers.Api.Models.DbEntities;
using System;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Contracts
{
    public interface IContractService
    {
        public Guid AddContract(Guid studentId);
        public StudyContract GetContractById(Guid contractId);
        public void RemoveContract(Guid contractId);
        public void EnrollStudent(Guid studentId, Guid yearId);
        public void SetGroupId(Guid contractId, Guid groupId);
        public void SetYearId(Guid contractId, Guid yearId);
        public void SetOptionalCourseId(Guid contractId, Guid optionalCourseId);
        public int GetNumberOfContracts(Guid studentid);
        public List<Course> GetContractCourses(Guid contractid);
        public void SignContract(Guid contractId);
        public OptionalCourse GetOptionalCourse(Guid contractid);

    }
}