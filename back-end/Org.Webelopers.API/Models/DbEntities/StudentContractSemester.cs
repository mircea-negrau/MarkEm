using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class StudentContractSemester
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [ForeignKey("Id")]
        public Guid StudentContractId { get; set; }

        [ForeignKey("Id")]
        public Guid StudySemesterId { get; set; }

        [ForeignKey("Id")]
        public Guid? OptionalCourseId { get; set; }

        #region References

        public virtual StudentContract StudentContract { get; set; }

        public virtual StudySemester StudySemester { get; set; }

        public virtual OptionalCourse OptionalCourse { get; set; }

        public virtual List<OptionalCoursePreference> OptionalCoursePreferences { get; set; }

        public virtual List<StudentMandatoryCourseEnrollment> StudentEnrolledCourses { get; set; }

        #endregion
    }
}