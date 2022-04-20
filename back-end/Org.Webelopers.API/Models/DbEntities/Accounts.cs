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

        [StringLength(128)]
        public string FirstName { get; set; }

        [StringLength(128)]
        public string LastName { get; set; }

        public long? DateOfBirth { get; set; }
    }

    public class Admin : Account
    {
        public Admin(string username, string emailHash, string passwordHash, string firstName, string lastName)
        {
            Id = Guid.NewGuid();
            Username = username;
            EmailHash = emailHash;
            PasswordHash = passwordHash;
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public class Student : Account
    {
        public Student(string username, string emailHash, string passwordHash, string firstName, string lastName, long? dateOfBirth = null)
        {
            Id = Guid.NewGuid();
            Username = username;
            EmailHash = emailHash;
            PasswordHash = passwordHash;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        #region References

        public virtual List<CourseGrade> Grades { get; set; }

        public virtual List<OptionalCourseGrade> OptionalGrades { get; set; }

        public virtual List<StudyContract> Contracts { get; set; }

        #endregion
    }

    public class Teacher : Account
    {
        public Teacher(string username, string emailHash, string passwordHash, string firstName, string lastName, long? dateOfBirth = null, Guid? teacherDegreeId = null)
        {
            Id = Guid.NewGuid();
            Username = username;
            EmailHash = emailHash;
            PasswordHash = passwordHash;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            TeacherDegreeId = teacherDegreeId;
        }

        [ForeignKey("Id")]
        public Guid? TeacherDegreeId { get; set; }

        #region References

        public virtual TeacherDegree TeacherDegree { get; set; }

        public virtual List<Course> Courses { get; set; }

        public virtual List<OptionalCourse> OptionalCourses { get; set; }

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
