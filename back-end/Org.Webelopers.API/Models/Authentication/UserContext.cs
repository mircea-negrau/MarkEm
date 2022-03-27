using Org.Webelopers.Api.Logic.Constants;
using Org.Webelopers.Api.Models.DbEntities;
using System;

namespace Org.Webelopers.Api.Models.Authentication
{
    public class UserContext
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long? DateOfBirth { get; set; }

        public UserContext(Student student)
        {
            Id = student.Id;
            Username = student.Username;
            Role = UserRoles.Student;
            FirstName = student.FirstName;
            LastName = student.LastName;
            DateOfBirth = student.DateOfBirth;
        }

        public UserContext(Teacher teacher)
        {
            Id = teacher.Id;
            Username = teacher.Username;
            Role = UserRoles.Teacher;
            FirstName = teacher.FirstName;
            LastName = teacher.LastName;
            DateOfBirth = teacher.DateOfBirth;
        }

        public UserContext(Admin admin)
        {
            Id = admin.Id;
            Username = admin.Username;
            Role = UserRoles.Admin;
            FirstName = admin.FirstName;
            LastName = admin.LastName;
        }
    }
}
