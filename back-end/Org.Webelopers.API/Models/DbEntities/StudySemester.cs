using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class StudySemester
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public short Semester { get; set; }

        [ForeignKey("Id")]
        public Guid StudyYearId { get; set; }

        #region References

        public virtual StudyYear StudyYear { get; set; }

        public virtual List<Course> Courses { get; set; }

        public virtual List<OptionalCourse> OptionalCourses { get; set; }

        #endregion
    }
}
