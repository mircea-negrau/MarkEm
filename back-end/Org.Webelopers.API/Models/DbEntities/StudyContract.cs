using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class StudyContract
    {
        [Key]
        public Guid Id { get; set; }

        public long? SignedAt { get; set; }

        [ForeignKey("Id")]
        public Guid StudentId { get; set; }

        [ForeignKey("Id")]
        public Guid GroupId { get; set; }

        [ForeignKey("Id")]
        public Guid? OptionalCourseId { get; set; }

        #region References

        public virtual Student Student { get; set; }

        public virtual Group Group { get; set; }

        public virtual OptionalCourse OptionalCourse { get; set; }

        public virtual List<OptionalCoursePreference> OptionalPreferences { get; set; }

        #endregion
    }
}
