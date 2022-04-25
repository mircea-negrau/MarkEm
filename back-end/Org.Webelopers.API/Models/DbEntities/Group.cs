using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class Group
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Id")]
        public Guid? TutorTeacherId { get; set; }

        [ForeignKey("Id")]
        public Guid? LeaderStudentId { get; set; }

        #region References

        public virtual Teacher TutorTeacher { get; set; }
        public virtual Student LeaderStudent { get; set; }
        public virtual List<StudentContract> Contracts { get; set; }
        
        public virtual List<SemesterContractCourse> SemesterContractCourses { get; set; }

        #endregion
    }
}
