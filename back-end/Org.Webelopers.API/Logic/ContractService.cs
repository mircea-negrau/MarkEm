using Microsoft.EntityFrameworkCore;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;
using Org.Webelopers.Api.Models.Persistence.Contracts;
using Org.Webelopers.Api.Models.Persistence.Courses;
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

        public Guid? AddContract(Guid studentId, StudyYear year)
        {
            int numberOfContracts = _context.Contracts.Where(contract => contract.StudentId == studentId).Count();
            if (numberOfContracts >= 2)
            {
                return null;
            }

            var contract = new StudentContract()
            {
                StudentId = studentId,
                StudyYearId = year.Id,
                Id = Guid.NewGuid()
            };

            var contractSemesters = _context.StudySemesters.Where(s => s.StudyYearId == year.Id)
                .Select(semester =>
                    new StudentContractSemester
                    {
                        Id = Guid.NewGuid(),
                        StudentContractId = contract.Id,
                        StudySemesterId = semester.Id
                    })
                .ToList();
            try
            {
                _context.Contracts.Add(contract);
                _context.SemesterContracts.AddRange(contractSemesters);
            }
            catch (Exception)
            {
                throw;
            }
            _context.SaveChanges();
            return contract.Id;
        }

        public void RemoveContract(Guid contractId)
        {
            var contract = _context.Contracts.FirstOrDefault(contr => contr.Id == contractId);
            if (contract != null)
            {
                var semesterContracts = _context.SemesterContracts.Where(x => x.StudentContractId == contractId).ToList();
                var enrolledCourses = _context.StudentEnrolledCourse.Where(x => semesterContracts.Select(y => y.Id).Contains(x.StudentContractSemesterId));
                _context.StudentEnrolledCourse.RemoveRange(enrolledCourses);
                _context.SemesterContracts.RemoveRange(semesterContracts);
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

        public void EnrollStudent(Guid studentId, Guid specialisationID)
        {
            var year = _context.StudyYears.FirstOrDefault(yr => yr.SpecializationId == specialisationID);

            var contract = _context.Contracts.FirstOrDefault(contr => contr.StudentId == studentId && contr.StudyYearId == year.Id);
            if (contract != null)
            {
                throw new ArgumentException("This student already has a contract for this year");
            }

            var contractId = AddContract(studentId, year);
            if (contractId == null)
            {
                throw new ArgumentException("This student has the max allowed number of contracts");
            }
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

        public List<ContractCourseResponse> GetContractMandatoryCourses(Guid contractId)
        {
            var contract = _context.Contracts.FirstOrDefault(contract => contract.Id == contractId);
            if (contract == null)
            {
                return null;
            }

            var yearId = contract.StudyYearId;
            var semesters = _context.StudySemesters.Where(semester => semester.StudyYearId == yearId).ToList();
            if (semesters.Count == 0)
            {
                return null;
            }

            var curriculum = new List<ContractCourseResponse>();
            foreach (var semester in semesters)
            {
                var semesterCourses = _context.Courses.Where(course => course.SemesterId == semester.Id)
                    .Include(x => x.Semester)
                    .Include(x => x.Teacher)
                        .ThenInclude(x => x.Account)
                    .Select(x => new ContractCourseResponse()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Credits = x.Credits,
                        Semester = x.Semester.Semester,
                        TeacherFirstName = x.Teacher.Account.FirstName,
                        TeacherLastName = x.Teacher.Account.LastName
                    }).ToList();

                curriculum.AddRange(semesterCourses);
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
        public List<ContractEnriched> GetStudentContractsEnriched(Guid studentId)
        {
            var contracts = _context.Contracts.Where(contract => contract.StudentId == studentId)
                .Include(contract => contract.StudyYear)
                .ThenInclude(contract => contract.Specialization)
                .ThenInclude(contract => contract.Faculty)
                .Select(contract => new ContractEnriched()
                {
                    Id = contract.Id,
                    SignedAt = contract.SignedAt,
                    Specialisation = contract.StudyYear.Specialization.Name,
                    Faculty = contract.StudyYear.Specialization.Faculty.Name
                }).ToList();

            return contracts;

        }

        public List<SemesterContractDto> GetYearlyContractAllSemesterContracts(Guid contractId)
        {
            var semesterContracts = _context.SemesterContracts.Where(semester => semester.StudentContractId == contractId)
                .Include(x => x.StudySemester)
                .Include(x => x.OptionalCourse)
                .Select(semester => new SemesterContractDto()
                {
                    Id = semester.Id,
                    ContractId = contractId,
                    Semester = semester.StudySemester.Semester,
                    OptionalCourseId = semester.OptionalCourse.Id,
                    OptionalCourseName = semester.OptionalCourse.Name
                }).ToList();
            return semesterContracts;
        }
    }
}
