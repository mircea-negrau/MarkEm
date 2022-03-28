
using Org.Webelopers.Api.Models.DbEntities;
using System;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Contracts
{
    public interface IContractService
    {
        //   public StudyContract EnrollStudent(StudyYear studyyear, Student student);
        //   public void DisenrollStudent(int studentid)
        //   ;
        public void AddContract(Guid studentId);
        public void RemoveContract(Guid contractId);
        public void SetGroupId(Guid contractId, Guid groupId);
        public void SetYearId(Guid contractId, Guid yearId);
        public void SetOptionalCourseId(Guid contractId, Guid optionalCourseId);
        public int GetNumberOfContracts(Guid studentid);
        public List<Course> GetContractCourses(Guid contractid);
        public void SignContract(Guid contractId);
        public OptionalCourse GetOptionalCourse(Guid contractid);

    }
}