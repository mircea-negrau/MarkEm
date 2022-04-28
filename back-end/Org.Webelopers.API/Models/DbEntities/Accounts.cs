using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class Account
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Username { get; set; }

        [Required]
        [JsonIgnore]
        public string EmailHash { get; set; }

        [Required]
        [JsonIgnore]
        public string PasswordHash { get; set; }

        [Required]
        [StringLength(128)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(128)]
        public string LastName { get; set; }

        public byte[] Picture { get; set; } // TODO: maybe move to a Profile class and table

        [StringLength(1024)]
        public string About { get; set; } // TODO: maybe move to a Profile class and table

        [ForeignKey("Id")]
        public Guid RoleId { get; set; }

        #region References

        public virtual AccountRole Role { get; set; }

        #endregion
    }

    public class Admin
    {
        [Key]
        [Required]
        [ForeignKey("Id")]
        public Guid AccountId { get; set; }

        #region References

        public virtual Account Account { get; set; }

        #endregion
        }
    }

    public class Student
    {
        [Key]
        [Required]
        [ForeignKey("Id")]
        public Guid AccountId { get; set; }

        #region References

        public virtual Account Account { get; set; }
        
        public virtual List<CourseGrade> Grades { get; set; }

        public virtual List<OptionalCourseGrade> OptionalGrades { get; set; }

        public virtual List<StudentContract> Contracts { get; set; }

        #endregion
    }

    public class Teacher
        {
        [Key]
        [Required]
        [ForeignKey("Id")]
        public Guid AccountId { get; set; }

        [ForeignKey("Id")]
        public Guid TeacherDegreeId { get; set; }

        #region References

        public virtual Account Account { get; set; }

        public virtual List<Course> Courses { get; set; }

        public virtual List<OptionalCourse> OptionalCourses { get; set; }

        public virtual TeacherDegree TeacherDegree { get; set; }

        #endregion
    }

    public class AccountContext : Account
    {
        public AccountContext(Account account, string userRole)
        {
            Id = account.Id;
            Role = userRole;
            Username = account.Username;
            EmailHash = account.EmailHash;
            PasswordHash = account.PasswordHash;
            FirstName = account.FirstName;
            LastName = account.LastName;
            DateOfBirth = account.DateOfBirth;
        }

        public string Role { get; set; }
    }
}
