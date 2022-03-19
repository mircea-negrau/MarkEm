using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class Teacher
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Username { get; set; }

        [Required]
        public string EmailHash { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public string Salt { get; set; }

        [Required]
        [StringLength(128)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(128)]
        public string LastName { get; set; }

        public long? DateOfBirth { get; set; }

        [ForeignKey("Id")]
        public Guid? TeacherDegreeId { get; set; }

        #region References

        public virtual TeacherDegree TeacherDegree { get; set; }

        public virtual List<Course> Courses { get; set; }

        public virtual List<OptionalCourse> OptionalCourses { get; set; }

        #endregion
    }
}
