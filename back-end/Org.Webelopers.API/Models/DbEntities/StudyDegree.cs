using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class StudyDegree
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        #region References

        public virtual List<Specialisation> Specialisations { get; set; }

        #endregion
    }
}
