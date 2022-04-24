using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class CourseGrade
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public short Grade { get; set; }

        [Required]
        public long CreatedAt { get; set; }

        [ForeignKey("Id")]
        public Guid CourseId { get; set; }

        [ForeignKey("Id")]
        public Guid StudentId { get; set; }

        #region References

        public virtual Student Student { get; set; }

        public virtual Course Course { get; set; }

        #endregion
    }
}
