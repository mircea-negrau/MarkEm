
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Org.Webelopers.Api.Contracts.Contract;
using Org.Webelopers.Api.Contracts.Curriculum;
using Org.Webelopers.Api.Contracts.Grades;
using Org.Webelopers.Api.Contracts.OptionalCourse;

using Org.Webelopers.Api.Models.DbEntities;

using System.Collections.Generic;


namespace Org.Webelopers.Api.Controllers
{
    [Route("student")]
    public class StudentController : Controller
    {
        private readonly IContractService _contractService;
        private readonly ICurriculumService _curriculumService;
        private readonly IOptionalCourseService _optionalCourseService;
        private readonly IGradesService _gradeService;
        public StudentController(
            IContractService contractService,
            ICurriculumService curriculumService,
            IOptionalCourseService optionalService,
            IGradesService gradeService)
        {
            _contractService = contractService;
            _curriculumService = curriculumService;
            _optionalCourseService = optionalService;
            _gradeService = gradeService;
        }

        
        [HttpPost("enroll")]
        [Authorize(Roles ="Student")]
        public StudyContract EnrollStudent(StudyYear studyyear, Student student)
        {

            var contract = _contractService.EnrollStudent(studyyear, student);
            return contract;
        }

        [HttpPost("disenroll")]
        public void DisenrollStudent(int studentid)
        {
            _contractService.DisenrollStudent(studentid);
        }

        [HttpGet("getnrcontracts")]
        public int GerNumberOfContracts(int studentid)
        {
            return _contractService.GetNumberOfContracts(studentid);
        }
        [HttpGet("getcontractclasses")]
        public List<Course> GetContractClasses(int contractid)
        {
            return _contractService.GetContractClasses(contractid);
        }
        [HttpGet("getallenroledclasses")]
        public List<Course> GetAllEnrolledClasses(int studentid)
        {
            return _contractService.GetAllStudentClasses(studentid);
        }
        [HttpPost("sign")]
        public void SignContract(int studentid, int contractid)
        {
            _contractService.SignContract(studentid, contractid);
        }
        [HttpGet("getoptionalcourses")]
        public List<Course> GetOptionalCourses()
        {
            return _optionalCourseService.getOptionalCourses();
        }

        /* public void SetOptionalCoursesPreference(int studentid, List<OptionalCoursePreference> preferences)
         {
            //  TODO
         }*/
        [HttpGet("getgrades")]
        public List<CourseGrade> GetGrades(int studentid)
        {
            return _gradeService.GetStudentGrades(studentid);
        }
        [HttpGet("getyearcourses")]
        public List<Course> GetYearCourses(int year)
        {
            return _curriculumService.GetYearCurriculum(year);
        }
    }
}
