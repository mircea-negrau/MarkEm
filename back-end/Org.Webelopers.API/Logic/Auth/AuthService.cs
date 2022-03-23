using Org.Webelopers.Api.Contracts.Auth;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.Authentication;
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
    }
}
