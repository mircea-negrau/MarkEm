using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;
using Org.Webelopers.Api.Models.Persistence.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Org.Webelopers.Api.Logic
{
    public class ContractService : IContractService
    {
        private readonly DatabaseContext _context;

        public ContractService(DatabaseContext context)
        {
            _context = context;
        }

        public StudentContract GetContractById(Guid contractId) =>
            _context.Contracts.FirstOrDefault(contract => contract.Id == contractId);

        public Guid? AddContract(Guid studentId)
        {
            int numberOfContracts = _context.Contracts.Where(contract => contract.StudentId == studentId).Count();
            if (numberOfContracts >= 2)
            {
                return null;
            }

            var contract = new StudentContract()
            {
                StudentId = studentId,
                Id = Guid.NewGuid()
            };
            _context.Contracts.Add(contract);
            _context.SaveChanges();
            return contract.Id;
        }

        public void RemoveContract(Guid contractId)
        {
            var contract = _context.Contracts.FirstOrDefault(contr => contr.Id == contractId);
            if (contract != null)
            {
                _context.Contracts.Remove(contract);
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("There is no contract with this id");
            }
        }

        public void SetGroupId(Guid contractId, Guid groupId)
        {
            var contract = _context.Contracts.FirstOrDefault(contr => contr.Id == contractId);
            if (contract.SignedAt != null)
                if (contract != null)
                {
                    contract.GroupId = groupId;
                    _context.SaveChanges();
                }
        }

        public void EnrollStudent(Guid studentId, Guid yearId)
        {
            var contract = _context.Contracts.FirstOrDefault(contr => contr.StudentId == studentId && contr.StudyYearId == yearId);
            if (contract != null)
            {
                throw new ArgumentException("This student already has a contract for this year");
            }

            var contractId = AddContract(studentId);
            if (contractId == null)
            {
                throw new ArgumentException("This student has the max allowed number of contracts");
            }
            SetYearId((Guid)contractId, yearId);
        }

        public void SetYearId(Guid contractId, Guid yearId)
        {
            var contract = _context.Contracts.FirstOrDefault(contr => contr.Id == contractId);
            if (contract != null)
            {
                contract.StudyYearId = yearId;
                _context.SaveChanges();
            }
        }

        public List<MandatoryCourse> GetContractCourses(Guid contractid)
        {
            var contract = _context.Contracts.FirstOrDefault(contr => contr.Id == contractid);
            _context.SaveChanges();
            if (contract == null)
            {
                return null;
            }

            var yearId = contract.StudyYearId;
            var semesters = _context.StudySemesters.Where(semester => semester.StudyYearId == yearId).Select(sem => sem.Id).ToList();
            if (semesters.Count == 0)
            {
                return null;
            }

            List<MandatoryCourse> curriculum = new List<MandatoryCourse>();
            foreach (var semester in semesters)
            {
                List<MandatoryCourse> list = _context.Courses.Where(course => course.SemesterId == semester).ToList();

                if (list.Count != 0)
                {
                    curriculum = curriculum.Concat(list).ToList();
                }
            }

            return curriculum;

        }

        public int GetNumberOfContracts(Guid studentid) =>
            _context.Contracts.Where(contract => contract.StudentId == studentid).ToList().Count;

        public void SignContract(Guid contractId)
        {
            var contract = _context.Contracts.FirstOrDefault(contr => contr.Id == contractId);

            if (contract != null)
            {
                contract.SignedAt = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Contract doesn't exist");
            }
        }

        public void SetOptionalCourseId(Guid contractId, Guid optionalCourseId) => throw new NotImplementedException();
        public OptionalCourse GetOptionalCourse(Guid contractId) => throw new NotImplementedException();
        public List<ContractEnriched> GetStudentContractsEnriched(Guid studentId) => throw new NotImplementedException();
    }
}
