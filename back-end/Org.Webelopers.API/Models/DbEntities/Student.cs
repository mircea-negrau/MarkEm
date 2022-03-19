using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class Student
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


        #region References

        public virtual List<CourseGrade> Grades { get; set; }

        public virtual List<OptionalCourseGrade> OptionalGrades { get; set; }

        public virtual List<StudyContract> Contracts { get; set; }

        #endregion
    }
}