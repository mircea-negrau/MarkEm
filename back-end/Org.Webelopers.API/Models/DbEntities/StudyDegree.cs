using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class StudyDegree
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [ForeignKey("Id")]
        public Guid FacultyId { get; set; }

        #region References

        public virtual Faculty Faculty { get; set; }
        public virtual List<Specialisation> Specialisations { get; set; }

        #endregion
    }
}
