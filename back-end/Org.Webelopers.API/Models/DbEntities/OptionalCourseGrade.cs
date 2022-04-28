using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class OptionalCourseGrade
    {
        [Key]
        public Guid Id { get; set; }

        public short Grade { get; set; }

        public long CreatedAt { get; set; }

        [ForeignKey("Id")]
        public Guid CourseId { get; set; }

        [ForeignKey("Id")]
        public Guid StudentId { get; set; }

        #region References

        public virtual Student Student { get; set; }

        public virtual OptionalCourse Course { get; set; }

        #endregion
    }
}
