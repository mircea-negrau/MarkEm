using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class FacultyGroup
    {
        [Key]
        public Guid Id { get; set; }

        public string Number { get; set; }

        [ForeignKey("Id")]
        public Guid? TutorTeacherId { get; set; }

        [ForeignKey("Id")]
        public Guid? LeaderStudentId { get; set; }
        
        [ForeignKey("Id")]
        public Guid? StudyYearId { get; set; }

        #region References

        public virtual Teacher TutorTeacher { get; set; }
        public virtual Student LeaderStudent { get; set; }
        public virtual List<StudentContract> Contracts { get; set; }
        public virtual List<StudentMandatoryCourseEnrollment> StudentEnrolledCourses { get; set; }
        public virtual StudyYear StudyYear { get; set; }

        #endregion
    }
}
