using Org.Webelopers.Api.Models.DbEntities;
using Org.Webelopers.Api.Models.Types;
using System;

namespace Org.Webelopers.Api.Models.Authentication
{
    public class UserContext
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public UserType Role { get; set; }

        public UserContext(Student student)
        {
            Id = student.Id;
            Username = student.Username;
            Role = UserType.Student;
        }

        public UserContext(Teacher teacher)
        {
            Id = teacher.Id;
            Username = teacher.Username;
            Role = UserType.Teacher;
        }

        public UserContext(Admin admin)
        {
            Id = admin.Id;
            Username = admin.Username;
            Role = UserType.Admin;
        }
    }
}
