using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class Faculty
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [ForeignKey("Id")]
        public Guid? ChiefOfDepartmentId { get; set; }

        #region References

        public virtual Teacher ChiefOfDepartment { get; set; }

        public virtual List<StudyDegree> StudyDegrees { get; set; }

        #endregion
    }
}
