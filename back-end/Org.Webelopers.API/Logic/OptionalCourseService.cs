using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;
using Org.Webelopers.Api.Models.Persistence.Courses;
using Org.Webelopers.Api.Models.Persistence.Groups;
using Org.Webelopers.Api.Models.Persistence.OptionalCourses;



namespace Org.Webelopers.Api.Logic
{
    public class OptionalCourseService : IOptionalCourseService
    {
        private readonly DatabaseContext _context;
        private readonly OptionalCourseAssigner _optionalCourseAssigner;

        public OptionalCourseService(DatabaseContext context)
        {
            _context = context;
            _optionalCourseAssigner = new OptionalCourseAssigner(_context);
        }

        #region PrivateFindMethods
        
        private OptionalCourse FindOptionalCourseAndThrowIfNullReference(Predicate<OptionalCourse> predicate, String exceptionMessage) => 
            Utils.ThrowIfNullReference(_context.FindEntity(predicate), exceptionMessage);

        private OptionalCourse FindOptionalCourseByIdAndThrowIfNullReference(Guid courseId) => FindOptionalCourseAndThrowIfNullReference(
            course => course.Id == courseId, 
            $"OptionalCourse with id: {courseId} was not found\n");

        #endregion

        public List<OptionalCourse> FilterCourses(Predicate<OptionalCourse> filterPredicate) =>
            _context.OptionalCourses.Where(course => filterPredicate(course)).ToList();

        #region PrivateSetCoursePreferenceMethods
        
        private void UpdateCoursePreferenceValue(Guid studentContractSemesterId, Guid courseId, short preferenceValue,
            OptionalCoursePreference optionalCoursePreference)
        {
            if (optionalCoursePreference == null) // create OptionalCoursePreference if doesn't exist
            {
                _context.Add(new OptionalCoursePreference()
                {
                    Id = Guid.NewGuid(),
                    Preference = preferenceValue,
                    StudentContractSemesterId = studentContractSemesterId,
                    OptionalCourseId = courseId
                });
            }
            else // update OptionalCoursePreference if exists
            {
                optionalCoursePreference.Preference = preferenceValue;
            }
        }

        private OptionalCoursePreference GetCourseInContractAndThrowIfNullReference(Guid studentContractSemesterId,
            Guid courseId)
        {
            CheckIfCourseInContractAndThrowIfNullReference(studentContractSemesterId, courseId);

            return _context.FindEntity<OptionalCoursePreference>(
                coursePreference => coursePreference.StudentContractSemesterId == studentContractSemesterId &&
                                    coursePreference.OptionalCourseId == courseId
            );
        }

        private void CheckIfCourseInContractAndThrowIfNullReference(Guid studentContractSemesterId, Guid courseId)
        {
            var studentContractSemester = _context.FindEntityAndThrowIfNullReference<StudentContractSemester>(
                semester => semester.Id == studentContractSemesterId,
                $"StudentContractSemester with id: {studentContractSemesterId} was not found\n"
            );

            _context.FindEntityAndThrowIfNullReference<OptionalCourse>(
                course => course.Id == courseId && course.SemesterId == studentContractSemester.StudySemesterId,
                $"OptionalCourse with id: {courseId}, in semester with id: {studentContractSemesterId} was not found\n"
            );
        }

        #endregion

        public void SetCoursePreference(Guid studentContractSemesterId, Guid courseId, short preferenceValue)
        {
            Utils.ThrowIf<InvalidEnumArgumentException>(preferenceValue < 0, $"Expected preference value >= 0. Got {preferenceValue}");
            OptionalCoursePreference optionalCoursePreference = GetCourseInContractAndThrowIfNullReference(studentContractSemesterId, courseId);

            UpdateCoursePreferenceValue(studentContractSemesterId, courseId, preferenceValue, optionalCoursePreference);

            _context.SaveChanges();
        }

        public void ProposeCourse(Guid courseId)
        {
            var optionalCourse = FindOptionalCourseByIdAndThrowIfNullReference(courseId);
            
            optionalCourse.IsProposed = true;
            
            _context.SaveChanges();
        }

        public void ApproveCourse(Guid courseId)
        {
            var optionalCourse = FindOptionalCourseByIdAndThrowIfNullReference(courseId);

            optionalCourse.IsApproved = true;
            
            _context.SaveChanges();
        }

        public void SetCourseCapacity(Guid courseId, int capacity)
        {
            Utils.ThrowIf<InvalidEnumArgumentException>(capacity <= 0, $"Expected capacity > 0. Got {capacity}");
            var optionalCourse = FindOptionalCourseByIdAndThrowIfNullReference(courseId);

            optionalCourse.MaxNumberOfStudent = capacity;

            _context.SaveChanges();
        }


        /// <summary>
        /// Get the number of preferences of an optional course.
        /// </summary>
        /// <param name="optionalCourseId">the id of the optional course</param>
        /// <returns>The number of preferences for the given optional course. -1, if there's no optional course with the given id.</returns>
        private int GetNumberOfFollowers(Guid optionalCourseId) =>
            _context.OptionalCourses.FirstOrDefault(course => course.Id == optionalCourseId) == null
                ? -1
                : _context.OptionalCoursePreferences.Count(preference => preference.OptionalCourseId == optionalCourseId);

        /// <summary>
        /// Gets the number of students enrolled in an optional course.
        /// </summary>
        /// <param name="optionalCourseId">the id of the optional course</param>
        /// <returns>The number of students enrolled in the given optional course. -1, if there's no optional course with the given id</returns>
        //private int GetNumberOfEnrollments(Guid optionalCourseId) =>
        //    _context.OptionalCourses.FirstOrDefault(course => course.Id == optionalCourseId) == null
        //        ? -1
        //    : 0;
        //Todo: Update to fit database rebuilt version
        //: _context.Contracts.Count(contract => contract.OptionalCourse.Id == optionalCourseId);

        public OptionalCoursesAssignmentResults StartOptionalCoursesAssignment()
        {
            // 1. get all approved optional courses with at least 20 followers
            var selectedOptionalCourses = _context.OptionalCourses.Where(course => course.IsApproved && GetNumberOfFollowers(course.Id) >= 20);
            int numberOfStudentsWithRandomOptionalCourseAssigned = 0;
            int numberOfStudentsWithNoOptionalCourseAssigned = 0;

            // 2. for each student, assign the the optional course with the highest priority that is selected

            // Todo: Update to fit database rebuilt version
            //foreach (StudyContract studyContract in _context.StudyContracts)
            //{
            //    var selectedPreferenceOptionalCourseId = _context.OptionalCoursePreferences
            //        .Where(preference => preference.StudyContract == studyContract)
            //        .OrderBy(preference => preference.Preference)
            //        .Select(preference => preference.OptionalCourseId) // the OptionalCourseIds of the preference of studyContract, sorted by preference value
            //        .FirstOrDefault(courseId =>
            //            courseId == selectedOptionalCourses
            //                .Where(course => GetNumberOfEnrollments(course.Id) < course.MaxNumberOfStudent)
            //                .Select(course => course.Id)
            //                .FirstOrDefault(id => id == courseId));

            //    if (selectedPreferenceOptionalCourseId == Guid.Empty)
            //    {
            //        selectedPreferenceOptionalCourseId = selectedOptionalCourses
            //            .Where(course => GetNumberOfEnrollments(course.Id) < course.MaxNumberOfStudent)
            //            .Select(course => course.Id).FirstOrDefault();
            //    }

            //    if (selectedPreferenceOptionalCourseId == Guid.Empty)
            //        numberOfStudentsWithNoOptionalCourseAssigned++;
            //    else
            //    {
            //        numberOfStudentsWithRandomOptionalCourseAssigned++;
            //        studyContract.OptionalCourseId = selectedPreferenceOptionalCourseId;
            //    }
            //}
            //_context.SaveChanges();
            return new OptionalCoursesAssignmentResults(){
               selectedOptionalCourses= selectedOptionalCourses.ToList(),
                numberOfStudentsWithRandomOptionalCourseAssigned = numberOfStudentsWithRandomOptionalCourseAssigned,
                numberOfStudentsWithNoOptionalCourseAssigned = numberOfStudentsWithNoOptionalCourseAssigned
            };
        }

        public List<OptionalCourseDto> GetOptionalCoursesByContractId(Guid contractId)
        {
            var yearId = _context.Contracts.FirstOrDefault(contract => contract.Id == contractId).StudyYearId;

            var semesters = _context.StudySemesters.Where(semester => semester.StudyYearId == yearId).ToList();


            List<OptionalCourse> result = new List<OptionalCourse>();

            semesters.ForEach(semester => result.AddRange(_context.OptionalCourses.Where(course => course.SemesterId == semester.Id).ToList()));
            /*return _context.OptionalCourses.Where(course => course.SemesterId == semesters[0].Id).Select(course => new OptionalCourseDto()
            {
                Id = course.Id,
                Name = course.Name,
                TeacherId = course.TeacherId,
                Credits = course.Credits,
                MaxNumberOfStudent = course.MaxNumberOfStudent

            }).ToList();*/
            return result.Select(course => new OptionalCourseDto()
            {
                Id = course.Id,
                Name = course.Name,
                Credits = course.Credits,
                MaxNumberOfStudent = course.MaxNumberOfStudent

            }).ToList();

        }
        public int AssignCoursesToStudents(bool assignToContractsWithNoPreference) => 
            _optionalCourseAssigner.AssignCoursesToStudents(assignToContractsWithNoPreference);

        public void SetCoursesPreferences(Guid studentContractSemesterId, List<Guid> coursesIds)
        {
            Func<Guid, Predicate<OptionalCoursePreference>> getPredicate = courseId =>
                preference =>
                    preference.StudentContractSemesterId == studentContractSemesterId &&
                    preference.OptionalCourseId == courseId;
                
            for (int i = 0; i < coursesIds.Count; i++)
            {
                // Predicate<OptionalCoursePreference> predicate = preference => 
                //     preference.StudentContractSemesterId == studentContractSemesterId && 
                //     preference.OptionalCourseId == coursesIds[i];
                
                // var preference =  _context.OptionalCoursePreferences.FirstOrDefault(preference => predicate(preference));

                var preference = _context.OptionalCoursePreferences.FirstOrDefault(preference => getPredicate(coursesIds[i])(preference));
                
                if (preference != null)
                {
                    preference.Preference = (short) i;
                }
            }
        }

        public async Task<TeacherCoursesResponse> GetEnrichedCoursesByTeacher(Guid teacherId)
        {
            var courses = _context.OptionalCourses.AsNoTracking()
                .Where(x => x.TeacherId == teacherId);
            var enrichedCourses = await courses
                .Include(x => x.Semester)
                .ThenInclude(y => y.StudyYear)
                .ThenInclude(y => y.Specialization)
                .ThenInclude(y => y.StudyLine)
                .Include(x => x.Semester)
                .ThenInclude(y => y.StudyYear)
                .ThenInclude(y => y.Specialization)
                .ThenInclude(y => y.StudyDegree)
                .Include(x => x.Semester)
                .ThenInclude(y => y.StudyYear)
                .ThenInclude(y => y.Specialization)
                .ThenInclude(y => y.Faculty)
                .Select(x => new TeacherCourseDetailDto()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Credits = x.Credits,
                    Semester = x.Semester.Semester,
                    StartDate = x.Semester.StudyYear.StartDate,
                    EndDate = x.Semester.StudyYear.EndDate,
                    IsOptional = true,
                    FacultyDetails = new TeacherCourseFacultyDetailDto()
                    {
                        Faculty = x.Semester.StudyYear.Specialization.Faculty.Name,
                        Specialization = x.Semester.StudyYear.Specialization.Name,
                        SpecializationSemesters = x.Semester.StudyYear.Specialization.Semesters,
                        StudyDegree = x.Semester.StudyYear.Specialization.StudyDegree.Name,
                        StudyLine = x.Semester.StudyYear.Specialization.StudyLine.Name,
                        StudyLineShort = x.Semester.StudyYear.Specialization.StudyLine.ShortName,
                    }
                })
                .ToListAsync();
            return new TeacherCoursesResponse { Courses = enrichedCourses };
        }

        public List<OptionalCourseDto> GetOptionalCoursesBySemesterContractId(Guid semesterContractId)
        {

            var semesterId = _context.SemesterContracts.FirstOrDefault(contract => contract.Id == semesterContractId).StudySemesterId;
          
            return _context.OptionalCourses.Where(course => course.SemesterId == semesterId).Select(course => new OptionalCourseDto()
            {
                Id = course.Id,
                Name = course.Name,
                Credits = course.Credits,
                MaxNumberOfStudent = course.MaxNumberOfStudent
            }).ToList();
        }

        public void AddSamplesForGetOptionalStudentsWithGrade()
        {
            const int noOfStudents = 10;
            
            var course = _context.OptionalCourses.Include(optionalCourse => optionalCourse.Semester).First();
            var studyYearId = course.Semester.StudyYearId;
            var students = _context.Students.Take(noOfStudents).ToList();
            var currentTime = DateTimeOffset.Now;
            var grades = new List<OptionalCourseGrade>();
            Console.WriteLine($"course.Id = {course.Id}");
            Console.WriteLine($"currentTime = {currentTime:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"noOfStudents = {students.Count}");

            foreach (var student in students)
            {
                var contract = new StudentContract
                {
                    Id = Guid.NewGuid(),
                    SignedAt = currentTime.ToUnixTimeSeconds(),
                    StudentId = student.AccountId,
                    StudyYearId = studyYearId
                };
                _context.Contracts.Add(contract);
                _context.SemesterContracts.Add(new StudentContractSemester
                {
                    Id = Guid.NewGuid(),
                    StudentContractId = contract.Id,
                    StudySemesterId = course.SemesterId,
                    OptionalCourseId = course.Id
                });
            }

            foreach (var student in students)
            {
                _context.OptionalGrades.RemoveRange(GetStudentGrades(student, course));
                if (new Random().NextDouble() <= 0.5)
                {
                    short gradeValue = (short) new Random().Next(0, 11);
                    grades.Add(new OptionalCourseGrade
                    {
                        Id = Guid.NewGuid(),
                        Grade = gradeValue,
                        CreatedAt = currentTime.ToUnixTimeSeconds(),
                        CourseId = course.Id,
                        StudentId = student.AccountId
                    });
                    Console.WriteLine($"student {student.AccountId} has grade {gradeValue}");
                }
                else
                {
                    Console.WriteLine($"student {student.AccountId} has NO grade");
                }
            }
            
            _context.OptionalGrades.AddRange(grades);
            _context.SaveChanges();
        }

        private List<OptionalCourseGrade> GetStudentGrades(Student student, OptionalCourse course) => 
            _context.OptionalGrades.Where(grade => grade.StudentId == student.AccountId && grade.CourseId == course.Id).ToList();


        public async Task<TeacherOptionalStudentsWithGradeResponse> GetStudentsWithGrade(Guid courseId)
        {
            var students = GetEnrolledStudents(courseId);

            var studentsWithGrade = await students
                .Include(student => student.Account)
                .Include(student => student.OptionalGrades)
                .Select(student => new StudentWithGrade
                {
                    Id = student.AccountId,
                    LastName = student.Account.LastName,
                    FirstName = student.Account.FirstName,
                    Grade = GetGrade(student.OptionalGrades.Where(grade => grade.CourseId == courseId).Select(grade => grade.Grade).ToList())
                })
                .ToListAsync();

            return new TeacherOptionalStudentsWithGradeResponse {StudentsWithGrade = studentsWithGrade};
        }

        private IQueryable<Student> GetEnrolledStudents(Guid courseId) =>
            _context.Students
                .AsNoTracking()
                .Include(student => student.Contracts)
                .ThenInclude(contract => contract.SemesterContracts)
                .Where(student => student.Contracts
                    .Any(contract => contract.SemesterContracts
                        .Any(semesterContract => semesterContract.OptionalCourseId == courseId)));

        private static short GetGrade(IReadOnlyCollection<short> grades) =>
            (short) (grades.Any() ? grades.First() : -1);
        
        

        public bool Exists(Guid courseId) => _context.FindEntity<OptionalCourse>(course => course.Id == courseId) != default;
    }
}
