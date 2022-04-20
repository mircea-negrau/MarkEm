
using System;
using Org.Webelopers.Api.Models.DbEntities;
using System.Collections.Generic;
using Org.Webelopers.Api.Models.OptionalCoursesService;

namespace Org.Webelopers.Api.Contracts
{
    public interface IOptionalCourseService
    {
        /// Returns all the Optional Courses
        public List<OptionalCourse> GetOptionalCourses();
        
        /// <summary>
        /// Sets or updates a preference for an optional course (only if the parameters conditions are met).
        /// </summary>
        /// <param name="preference">A non-negative number. The lower the value, the higher the preference. </param>
        /// <param name="contractId">the id of an existing contract</param>
        /// <param name="optionalCourseId">the id of an existing optional course</param>
        /// <returns>
        /// True, if the preference was set. False, if the preference is below 0 or the contract doesn't exist or the optional course
        /// doesn't exist.
        /// </returns>
        public bool SetStudentOptionalCoursesPreference(short preference, Guid contractId, Guid optionalCourseId); // TODO: contractId vs. studentId
                
        /// <summary>
        /// Gets the optional courses proposed by a teacher.
        /// </summary>
        /// <param name="teacherId">the id of the teacher of the courses</param>
        /// <returns>
        /// A list that contains the optional courses that were proposed by a given teacher.
        /// Empty, if teacherId doesn't belong to any existing teacher.
        /// </returns>
        public List<OptionalCourse> GetProposedOptionalCourses(Guid teacherId);
        
        /// <summary>
        /// Adds a new optional course.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="credits">Non-zero natural number</param>
        /// <param name="semesterId">the id of an existing semester</param>
        /// <param name="teacherId">the id of an existing teacher</param>
        /// <returns>True, if the optional was added. False, if the parameters conditions weren't met or the teacher already has
        /// a course with the given name.</returns>
        public bool AddOptionalCourse(string name, short credits, Guid semesterId, Guid teacherId);
        
        /// <summary>
        /// Propose an optional course
        /// </summary>
        /// <param name="optionalCourseId">the id of an existing optional course</param>
        /// <param name="teacherId">the id of an existing teacher</param>
        /// <returns>True, if the optional course was proposed. False, if the optional course doesn't exist or the teacher already
        /// proposed the given optional course or they already proposed 2 optional courses.</returns>
        public bool ProposeOptionalCourse(Guid optionalCourseId, Guid teacherId); // TODO: maybe remove the teacherId and do the checking in the TeacherController
       
        /// <summary>
        /// Approve an optional course 
        /// </summary>
        /// <param name="optionalCourseId">the id of an existing optional course to be approved</param>
        /// <returns>True, if the optional course was approved or is already approved.
        /// False, if no optional course with the given id exists.</returns>
        public bool SetOptionalCourseApproval(Guid optionalCourseId);
        
        /// <summary>
        /// Sets the maximum number of students for an optional course.
        /// </summary>
        /// <param name="optionalCourseId">the id of an existing optional course</param>
        /// <param name="maxNumberOfStudents">Non-negative value. The maximum number of students for the optional course given by the id</param>
        /// <returns>True, if the maximum number of students for the optional course was set. False, if the given maximum number is negative
        /// or the optional course doesn't exist</returns>
        public bool SetOptionalCourseMaxStudent(Guid optionalCourseId, int maxNumberOfStudents);
        
        /// <summary>
        /// Assigns to students their first approved optional course preference which has at least 20 followers. If 2 or more optional courses have
        /// the same preference, then, the order in which they are chosen is undeterministic, making it the student's responsibility to
        /// decide upon the preference order.
        /// If no student's preference matched an approved optional course with at least 20 followers and with available seats, the student
        /// will be assigned to a random one that is available.
        /// </summary>
        /// <returns>The results of the assignment: The list of approved optional courses that have at least 20 followers, the number of
        /// random optional courses assigned and the number of students with no optional course assigned.</returns>
        public OptionalCoursesAssignmentResults StartOptionalCoursesAssignment();
    }
}