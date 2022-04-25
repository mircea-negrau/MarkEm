using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class StudentContract
    {
        [Key]
        public Guid Id { get; set; }

        public long? SignedAt { get; set; }

        [ForeignKey("Id")]
        public Guid StudentId { get; set; }

        [ForeignKey("Id")]
        public Guid StudyYearId { get; set; }

        [ForeignKey("Id")]
        public Guid GroupId { get; set; }

        #region References

        public virtual Student Student { get; set; }

        public virtual StudyYear StudyYear { get; set; }
        public virtual Group Group { get; set; }

        public virtual List<StudentContractSemester> SemesterContracts { get; set; }

        #endregion
    }
}
