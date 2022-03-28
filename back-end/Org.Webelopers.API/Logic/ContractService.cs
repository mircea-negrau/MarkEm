using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;
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

        public StudyContract GetContractById(Guid contractId)
        {
            return _context.StudyContracts.FirstOrDefault(contract => contract.Id == contractId);
        }
        public void AddContract(Guid studentId)
        {
            var numberOfContracts = _context.StudyContracts.Where(contract => contract.StudentId == studentId).Count();

            if (numberOfContracts >= 2)
                return;

            _context.StudyContracts.Add(new StudyContract()
            {
                StudentId = studentId,
                Id = Guid.NewGuid()
            });

            _context.SaveChanges();
        }

        public void RemoveContract(Guid contractId)
        {
            var contract = _context.StudyContracts.FirstOrDefault(contr => contr.Id == contractId);
            if (contract != null)
            {
                _context.StudyContracts.Remove(contract);
                _context.SaveChanges();
            }
        }
        public void SetGroupId(Guid contractId, Guid groupId)
        {
            var contract = _context.StudyContracts.FirstOrDefault(contr => contr.Id == contractId);

            if (contract.SignedAt != null)
                if (contract != null)
                {
                    contract.GroupId = groupId;
                    _context.SaveChanges();
                }

        }
        public void SetYearId(Guid contractId, Guid yearId)
        {
            var contract = _context.StudyContracts.FirstOrDefault(contr => contr.Id == contractId);

            if (contract.SignedAt != null)
                if (contract != null)
                {
                    contract.YearId = yearId;
                    _context.SaveChanges();
                }

        }
        public void SetOptionalCourseId(Guid contractId, Guid optionalCourseId)
        {
            var contract = _context.StudyContracts.FirstOrDefault(contr => contr.Id == contractId);

            if (contract.SignedAt != null)
                if (contract != null)
                {
                    contract.OptionalCourseId = optionalCourseId;
                    _context.SaveChanges();
                }

        }

        public List<Course> GetContractCourses(Guid contractid)
        {
            var contract = _context.StudyContracts.FirstOrDefault(contr => contr.Id == contractid);
            if (contract == null)
                return null;

            var yearId = contract.YearId;
            var semesters = _context.StudySemesters.Where(semester => semester.StudyYearId == yearId).Select(sem => sem.Id);

            if (semesters.Count() == 0)
                return null;

            List<Course> curriculum = new List<Course>();

            foreach (var semester in semesters)
            {
                List<Course> list = _context.Courses.Where(course => course.SemesterId == semester).ToList();

                if (list.Count != 0)
                {
                    curriculum = curriculum.Concat(list).ToList();
                }
            }

            return curriculum;

        }
        public int GetNumberOfContracts(Guid studentid)
        {
            return _context.StudyContracts.Where(contract => contract.StudentId == studentid).ToList().Count;
        }
        public void SignContract(Guid contractId)
        {
            var contract = _context.StudyContracts.FirstOrDefault(contr => contr.Id == contractId);

            if (contract != null)
            {
                contract.SignedAt = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
                _context.SaveChanges();
            }
        }

        public OptionalCourse GetOptionalCourse(Guid contractid)
        {
            return _context.StudyContracts.FirstOrDefault(contract => contract.Id == contractid).OptionalCourse;
        }
    }
}
