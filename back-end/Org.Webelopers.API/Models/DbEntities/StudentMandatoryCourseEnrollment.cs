using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class StudentMandatoryCourseEnrollment
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(("id"))]
        public Guid StudentContractSemesterId { get; set; }

        [ForeignKey("Id")]
        public Guid MandatoryCourseId { get; set; }

        [ForeignKey("Id")]
        public Guid? GroupId { get; set; }

        #region References

        public virtual MandatoryCourse MandatoryCourse { get; set; }

        public virtual StudentContractSemester StudentContractSemester { get; set; }

        public virtual FacultyGroup Group { get; set; }

        #endregion
    }
}