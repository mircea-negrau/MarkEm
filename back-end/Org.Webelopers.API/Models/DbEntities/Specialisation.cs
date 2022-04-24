using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class Specialisation
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        
        [Required]
        public short Semesters { get; set; }
        
        [ForeignKey(("Id"))]
        public Guid FacultyId { get; set; }

        [ForeignKey("Id")]
        public Guid StudyDegreeId { get; set; }
        
        [ForeignKey("Id")]
        public Guid StudyLineId { get; set; }

        #region References

        public virtual StudyDegree StudyDegree { get; set; }
        public virtual List<StudyYear> StudyYears { get; set; }

        #endregion
    }
}
