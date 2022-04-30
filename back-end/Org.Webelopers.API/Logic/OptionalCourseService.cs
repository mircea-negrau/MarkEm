using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;

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

        public int AssignCoursesToStudents(bool assignToContractsWithNoPreference) => 
            _optionalCourseAssigner.AssignCoursesToStudents(assignToContractsWithNoPreference); 
    }
}