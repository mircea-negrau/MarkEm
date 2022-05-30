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
        #region FieldsAndConstructor

        private readonly DatabaseContext _context;
        private readonly OptionalCourseAssigner _optionalCourseAssigner;

        public OptionalCourseService(DatabaseContext context)
        {
            _context = context;
            _optionalCourseAssigner = new OptionalCourseAssigner(_context);
        }

        #endregion

        #region PrivateFindMethods
        
        private OptionalCourse FindOptionalCourseAndThrowIfNullReference(Predicate<OptionalCourse> predicate, String exceptionMessage) => 
            Utils.ThrowIfNullReference(_context.FindEntity(predicate), exceptionMessage);

        private OptionalCourse FindOptionalCourseByIdAndThrowIfNullReference(Guid courseId) => FindOptionalCourseAndThrowIfNullReference(
            course => course.Id == courseId, 
            $"OptionalCourse with id: {courseId} was not found\n");

        #endregion

        public List<OptionalCourse> FilterCourses(Predicate<OptionalCourse> filterPredicate) =>
            // _context.FindEntity<OptionalCourse>(filterPredicate).ToList();
            _context.OptionalCourses.ToList().Where(course => filterPredicate(course)).ToList();


        #region Student
        
        public void SetCoursePreference(Guid studentContractSemesterId, Guid courseId, short preferenceValue)
        {
            Utils.ThrowIf<InvalidEnumArgumentException>(preferenceValue < 0, $"Expected preference value >= 0. Got {preferenceValue}");
            OptionalCoursePreference optionalCoursePreference = GetCourseInContractAndThrowIfNullReference(studentContractSemesterId, courseId);

            UpdateCoursePreferenceValue(studentContractSemesterId, courseId, preferenceValue, optionalCoursePreference);

            _context.SaveChanges();
        }
        
        public void SetCoursesPreferences(Guid studentContractSemesterId, List<Guid> coursesIds)
        {
            System.Diagnostics.Debug.Write(studentContractSemesterId);
            System.Diagnostics.Debug.Write(coursesIds[0]);
            System.Diagnostics.Debug.Write(coursesIds[1]);
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

                var preference = _context.OptionalCoursePreferences.ToList().
                    FirstOrDefault(preference => getPredicate(coursesIds[i])(preference));
                
                if (preference != null)
                {
                    preference.Preference = (short) i;
                }
            }
            _context.SaveChanges();

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
        
        #endregion

        
        #region Teacher
        
        public ProposedCoursesIds GetProposed(Guid teacherId)
        {
            var coursesIds = GetCourses(teacherId)
                .Where(course => course.IsProposed)
                .Select(course => course.Id)
                .Take(2).ToList();

            return new ProposedCoursesIds
            {
                First = coursesIds.Count >= 1 ? coursesIds[0] : Guid.Empty,
                Second = coursesIds.Count >= 2 ? coursesIds[1] : Guid.Empty,
            };
        }
        
        public void Propose(Guid teacherId, Guid course1Id, Guid course2Id)
        {
            ClearProposedCourses(teacherId);
            if (course1Id != default)
            {
                FindOptionalCourseByIdAndThrowIfNullReference(course1Id).IsProposed = true;
            }
            if (course2Id != default)
            {
                FindOptionalCourseByIdAndThrowIfNullReference(course2Id).IsProposed = true;
            }
            _context.SaveChanges();
        }


        public TeacherCourseDetailDto GetEnrichedCourseById(Guid courseId)
        {
            var course = _context.OptionalCourses
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
                .FirstOrDefault(x => x.Id == courseId);

            if (course == null)
            {
                throw new Exception("Course ID is invalid!");
            }

            return new TeacherCourseDetailDto()
            {
                Id = course.Id,
                Name = course.Name,
                Credits = course.Credits,
                Semester = course.Semester.Semester,
                StartDate = course.Semester.StudyYear.StartDate,
                EndDate = course.Semester.StudyYear.EndDate,
                IsOptional = true,
                FacultyDetails = new TeacherCourseFacultyDetailDto()
                {
                    Faculty = course.Semester.StudyYear.Specialization.Faculty.Name,
                    Specialization = course.Semester.StudyYear.Specialization.Name,
                    SpecializationSemesters = course.Semester.StudyYear.Specialization.Semesters,
                    StudyDegree = course.Semester.StudyYear.Specialization.StudyDegree.Name,
                    StudyLine = course.Semester.StudyYear.Specialization.StudyLine.Name,
                    StudyLineShort = course.Semester.StudyYear.Specialization.StudyLine.ShortName,
                }
            };
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
                .ThenInclude(y => y.StudyLine)
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
        
        public async Task<TeacherOptionals> GetEnrichedCoursesForTeacherOptionalsPage(Guid teacherId)
        {
            var courses = _context.OptionalCourses
                .AsNoTracking()
                .Where(course => course.TeacherId == teacherId);
            var enrichedCourses = await courses
                .Include(course => course.Semester)
                .ThenInclude(semester => semester.StudyYear)
                .ThenInclude(year => year.Specialization)
                .Select(course => new TeacherOptional
                {
                    Id = course.Id,
                    Name = course.Name,
                    Specialization = course.Semester.StudyYear.Specialization.Name,
                    Semester = course.Semester.Semester,
                    IsProposed = course.IsProposed,
                    IsApproved = course.IsApproved
                })
                .OrderBy(optional => optional.Name)
                .ThenBy(optional => optional.Specialization)
                .ThenBy(optional => optional.Semester)
                .ToListAsync();
            return new TeacherOptionals { Optionals = enrichedCourses };
        }
        
        #region PrivateMethods

        private List<OptionalCourse> GetCourses(Guid teacherId) =>
            FilterCourses(course => course.TeacherId == teacherId).ToList();
        private static short GetGrade(IReadOnlyCollection<short> grades) =>
            (short) (grades.Any() ? grades.First() : -1);
        
        private void ClearProposedCourses(Guid teacherId)
        {
            foreach (OptionalCourse optionalCourse in _context.OptionalCourses
                         .Where(course => course.TeacherId == teacherId && course.IsProposed))
            {
                optionalCourse.IsProposed = false;
            }
        }
        
        private IQueryable<Student> GetEnrolledStudents(Guid courseId) =>
            _context.Students
                .AsNoTracking()
                .Include(student => student.Contracts)
                .ThenInclude(contract => contract.SemesterContracts)
                .Where(student => student.Contracts
                    .Any(contract => contract.SemesterContracts
                        .Any(semesterContract => semesterContract.OptionalCourseId == courseId)));

        #endregion
        
        #endregion

        
        #region Chief

        public void ApproveCourse(Guid courseId)
        {
            var optionalCourse = FindOptionalCourseByIdAndThrowIfNullReference(courseId);

            optionalCourse.IsApproved = true;
            
            _context.SaveChanges();
        }

        public void DisapproveCourse(Guid courseId)
        {
            var optionalCourse = FindOptionalCourseByIdAndThrowIfNullReference(courseId);

            optionalCourse.IsApproved = false;
            
            _context.SaveChanges();
        }

        public void SetCourseCapacity(Guid courseId, int capacity)
        {
            Utils.ThrowIf<ArgumentOutOfRangeException>(capacity <= 0, $"Expected capacity > 0. Got {capacity}");
            var optionalCourse = FindOptionalCourseByIdAndThrowIfNullReference(courseId);

            optionalCourse.MaxNumberOfStudent = capacity;

            _context.SaveChanges();
        }
        
        public int AssignCoursesToStudents(bool assignToContractsWithNoPreference) => 
            _optionalCourseAssigner.AssignCoursesToStudents(assignToContractsWithNoPreference);

        public void AddSamplesForAssignCoursesToStudents() // TODO: use it for groups
        {
            // const int noOfStudentsMinIncl = 70 - 28;
            // const int noOfStudentsMaxExcl = 70 + 1;
            //
            // var specializations = _context.Specialisations.AsNoTracking();
            //
            // foreach (var specialization in specializations)
            // {
            //     for (short year = 1; year <= specialization.Semesters / 2; year++)
            //     {
            //         var studyYear = StudyYear.Create(DateTimeOffset.UtcNow, specialization.Id);
            //         var semester1 = StudySemester.Create(2 * year - 1, studyYear.Id);
            //         var semester2 = StudySemester.Create(2 * year, studyYear.Id);
            //
            //     }
            //     
            // }
        }

        public async Task<OptionalsChiefView> GetOptionalsChiefView(Guid chiefId)
        {
            var courses = _context.Faculties
                .AsNoTracking()
                .Where(faculty => faculty.ChiefOfDepartmentId == chiefId);
            var test1 = courses
                .Include(faculty => faculty.Specialisations)
                .ThenInclude(specialization => specialization.StudyYears)
                .ThenInclude(year => year.Semesters)
                .ThenInclude(semester => semester.OptionalCourses);
            var test2 = test1
                .SelectMany(faculty => faculty.Specialisations)
                .SelectMany(specialization => specialization.StudyYears)
                .SelectMany(year => year.Semesters)
                .SelectMany(semester => semester.OptionalCourses)
                .Where(course => course.IsProposed);
            var enrichedCourses = await test2
                .Include(course => course.Semester.StudyYear.Specialization.StudyDegree)
                .Include(course => course.Semester.StudyYear.Specialization.StudyLine)
                .Include(course => course.Teacher)
                .ThenInclude(teacher => teacher.Account)
                .Select(course => new OptionalChiefView
                {
                    Id = course.Id,
                    Name = course.Name,
                    Credits = course.Credits,
                    TeacherLastName = course.Teacher.Account.LastName,
                    TeacherFirstName = course.Teacher.Account.FirstName,
                    Semester = course.Semester.Semester,
                    IsApproved = course.IsApproved,
                    Capacity = course.MaxNumberOfStudent,
                    StudyDegree = course.Semester.StudyYear.Specialization.StudyDegree.Name,
                    StudyLine = course.Semester.StudyYear.Specialization.StudyLine.Name,
                    StudyLineShort = course.Semester.StudyYear.Specialization.StudyLine.ShortName,
                    Specialization = course.Semester.StudyYear.Specialization.Name,
                })
                .ToListAsync();
            return new OptionalsChiefView { Optionals = enrichedCourses };
        }

        #endregion


        public bool Exists(Guid courseId) => _context.FindEntity<OptionalCourse>(course => course.Id == courseId) != default;
        
        public bool IsCourseTaughtBy(Guid courseId, Guid teacherId) => 
            _context.OptionalCourses.FirstOrDefault(course => course.Id == courseId && course.TeacherId == teacherId) != default;
    }
}
