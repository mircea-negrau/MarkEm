using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Org.Webelopers.Api.Models.DbEntities.BaseClasses
{
    public class BaseCourse
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

        #region References

        public virtual StudySemester Semester { get; set; }

        public virtual Teacher Teacher { get; set; }

        #endregion
    }
}
