using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class StudyYear
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public short StartYear { get; set; }

        [Required]
        public short EndYear { get; set; }

        [ForeignKey("Id")]
        public Guid SpecialisationId { get; set; }

        [ForeignKey("Id")]
        public Guid? StudentLeaderUserId { get; set; }

        #region References

        public virtual Specialisation Specialisation { get; set; }
        
        public virtual Student StudentLeader { get; set; }
        
        public virtual List<StudySemester> Semesters { get; set; }
        
        public virtual List<StudentContract> Contracts { get; set; }

        #endregion
    }
}
