using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;
using Org.Webelopers.Api.Models.DbEntities.BaseClasses;
using Org.Webelopers.Api.Models.Types;
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

        public Account Authenticate(string email, string password)
        {
            var account = _context.Accounts.FirstOrDefault(x => x.Email == email);
            return account != null
                ? ValidatePassword(password, account)
                : null;
        }

        public Account Register(string userType, string username, string passwordHash, string email, string firstName, string lastName)
        {
            if (IsUsernameTaken(username) || IsEmailUsed(email))
            {
                return null;
            }

            var account = new Account()
            {
                Id = Guid.NewGuid(),
                Role = userType,
                Username = username,
                Email = email,
                PasswordHash = passwordHash,
                FirstName = firstName,
                LastName = lastName
            };
            return (userType) switch
            {
                UserRoles.Student => CreateAccount<Student>(account),
                UserRoles.Teacher => CreateAccount<Teacher>(account),
                UserRoles.Admin => CreateAccount<Admin>(account),
                _ => null
            };
        }

        private Account CreateAccount<AccountType>(Account account) where AccountType : BaseAccount, new()
        {
            _context.Add(account);
            _context.SaveChanges();
            var newAccount = new AccountType() { AccountId = account.Id };
            _context.Add(newAccount);
            _context.SaveChanges();
            return account;
        }

        private bool IsUsernameTaken(string username) =>
            _context.Accounts.FirstOrDefault(x => x.Username == username) != null;

        private bool IsEmailUsed(string email) =>
            _context.Accounts.FirstOrDefault(x => x.Email == email) != null;

        private static Account ValidatePassword(string password, Account account) =>
            BCrypt.Net.BCrypt.Verify(password, account.PasswordHash)
                ? account
                : null;
    }
}
