using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class OptionalCourse
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        public short Credits { get; set; }

        [ForeignKey("Id")]
        public Guid SemesterId { get; set; }

        [ForeignKey("Id")]
        public Guid TeacherId { get; set; }

        [Required]
        public bool IsApproved { get; set; }
        
        public bool IsProposed { get; set; }

        [Required]
        public int MaxNumberOfStudent { get; set; }

        #region References

        public virtual StudySemester Semester { get; set; }

        public virtual Teacher Teacher { get; set; }

        public virtual List<OptionalCourseGrade> Grades { get; set; }

        #endregion
    }
}
