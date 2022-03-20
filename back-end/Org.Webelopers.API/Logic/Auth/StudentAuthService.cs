using Org.Webelopers.Api.Contracts.Auth;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;
using System;
using System.Linq;

namespace Org.Webelopers.Api.Logic.Auth
{
    public class StudentAuthService : IStudentAuthService
    {
        private readonly DatabaseContext _context;
        public StudentAuthService(DatabaseContext context)
        {
            _context = context;
        }

        public Student Register(Student student)
        {
            var response = _context.Students.Add(student);
            _context.SaveChanges();
            return response.Entity;
        }

        public Student GetStudentByUsername(string username)
        {
            return _context.Students.FirstOrDefault(x => x.Username == username);
        }

        public Student GetStudentById(Guid id)
        {
            return _context.Students.FirstOrDefault(x => x.Id == id);
        }
    }
}
