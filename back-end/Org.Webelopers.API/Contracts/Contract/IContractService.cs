
using Org.Webelopers.Api.Models.DbEntities;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Contracts.Contract
{
    public interface IContractService
    {
        public StudyContract EnrollStudent(StudyYear studyyear, Student student);
        public void DisenrollStudent(int studentid);
        public int GetNumberOfContracts(int studentid);
        public List<Course> GetContractClasses(int contractid);
        public List<Course> GetAllStudentClasses(int studentid);
        public void SignContract(int studentid, int contractid);
    }
}