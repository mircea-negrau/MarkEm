using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.Authentication;
using Org.Webelopers.Api.Models.DbEntities;
using System;
using System.Linq;

namespace Org.Webelopers.Api.Logic.Auth
{
    public class AuthService : IAuthService
    {
        private readonly DatabaseContext _context;
        public AuthService(DatabaseContext context)
        {
            _context = context;
        }

        public UserContext Authenticate(string username, string password)
        {
            var student = _context.Students.FirstOrDefault(x => x.Username == username);
            if (student != null)
            {
                return BCrypt.Net.BCrypt.Verify(password, student.PasswordHash)
                    ? new UserContext(student)
                    : null;
            }
            var teacher = _context.Teachers.FirstOrDefault(x => x.Username == username);
            if (teacher != null)
            {
                return BCrypt.Net.BCrypt.Verify(password, teacher.PasswordHash)
                    ? new UserContext(teacher)
                    : null;
            }
            var admin = _context.Admins.FirstOrDefault(x => x.Username == username);
            if (admin != null)
            {
                return BCrypt.Net.BCrypt.Verify(password, admin.PasswordHash)
                    ? new UserContext(admin)
                    : null;
            }
            return null;
        }

        public UserContext Register(string userType, string username, string password, string email, string firstName, string lastName)
        {
            var student = _context.Students.FirstOrDefault(x => x.Username == username);
            if (student != null)
                return null;
            var teacher = _context.Teachers.FirstOrDefault(x => x.Username == username);
            if (teacher != null)
                return null;
            var admin = _context.Admins.FirstOrDefault(x => x.Username == username);
            if (admin != null)
                return null;

            switch (userType)
            {

                case "Student":
                    student = new Student()
                    {
                        Id = Guid.NewGuid(),
                        Username = username,
                        EmailHash = email,
                        PasswordHash = password,
                        FirstName = firstName,
                        LastName = lastName,
                        DateOfBirth = null
                    };

                    _context.Add(student);
                    _context.SaveChanges();
                    return new UserContext(student);
                case "Teacher":
                    teacher = new Teacher()
                    {
                        Id = Guid.NewGuid(),
                        Username = username,
                        PasswordHash = password,
                        EmailHash = email,
                        FirstName = firstName,
                        LastName = lastName,
                        DateOfBirth = null,
                        TeacherDegreeId = null
                    };

                    _context.Add(teacher);
                    _context.SaveChanges();
                    return new UserContext(teacher);

                case "Admin":
                    admin = new Admin()
                    {
                        Id = Guid.NewGuid(),
                        Username = username,
                        PasswordHash = password,
                        EmailHash = email,
                        FirstName = firstName,
                        LastName = lastName
                    };

                    _context.Add(admin);
                    _context.SaveChanges();
                    return new UserContext(admin);
                default:
                    return null;


            }



            return null;
        }

    }
}
