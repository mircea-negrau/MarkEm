using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;
using Org.Webelopers.Api.Models.Types;
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

        public AccountContext Authenticate(string username, string password)
        {
            var student = _context.Students.FirstOrDefault(x => x.Username == username);
            if (student != null)
            {
                return ValidatePassword(password, student, UserRoles.Student);
            }
            var teacher = _context.Teachers.FirstOrDefault(x => x.Username == username);
            if (teacher != null)
            {
                return ValidatePassword(password, teacher, UserRoles.Teacher);
            }
            var admin = _context.Admins.FirstOrDefault(x => x.Username == username);
            if (admin != null)
            {
                return ValidatePassword(password, admin, UserRoles.Admin);
            }
            return null;
        }

        public AccountContext Register(string userType, string username, string passwordHash, string emailHash, string firstName, string lastName)
        {
            if (IsUsernameTaken(username))
            {
                return null;
            }

            switch (userType)
            {
                case UserRoles.Student:
                    var student = new Student(username, emailHash, passwordHash, firstName, lastName, null);
                    _context.Add(student);
                    _context.SaveChanges();
                    return new AccountContext(student, UserRoles.Student);
                case UserRoles.Teacher:
                    var teacher = new Teacher(username, passwordHash, emailHash, firstName, lastName, null, null);
                    _context.Add(teacher);
                    _context.SaveChanges();
                    return new AccountContext(teacher, UserRoles.Teacher);
                case UserRoles.Admin:
                    var admin = new Admin(username, passwordHash, emailHash, firstName, lastName);
                    _context.Add(admin);
                    _context.SaveChanges();
                    return new AccountContext(admin, UserRoles.Admin);
                default:
                    return null;
            }
        }

        private bool IsUsernameTaken(string username)
        {
            var student = _context.Students.FirstOrDefault(x => x.Username == username);
            if (student != null)
                return true;
            var teacher = _context.Teachers.FirstOrDefault(x => x.Username == username);
            if (teacher != null)
                return true;
            var admin = _context.Admins.FirstOrDefault(x => x.Username == username);
            if (admin != null)
                return true;
            return false;
        }

        private static AccountContext ValidatePassword(string password, Account account, string userRole) =>
            BCrypt.Net.BCrypt.Verify(password, account.PasswordHash)
                ? new AccountContext(account, userRole)
                : null;
    }
}
