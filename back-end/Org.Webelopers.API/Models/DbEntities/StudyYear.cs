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

        public long StartDate { get; set; }

        public long EndDate { get; set; }

        [ForeignKey("Id")]
        public Guid SpecializationId { get; set; }

        [ForeignKey("Id")]
        public Guid? StudentLeaderId { get; set; }

        #region References

        public virtual FacultySpecialization Specialization { get; set; }

        public virtual Student StudentLeader { get; set; }

        public virtual List<StudySemester> Semesters { get; set; }

        public virtual List<StudentContract> Contracts { get; set; }
        
        public virtual List<FacultyGroup> Groups { get; set; }

        #endregion
    }
}
