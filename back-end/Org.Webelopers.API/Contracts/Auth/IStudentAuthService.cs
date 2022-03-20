using Org.Webelopers.Api.Models.DbEntities;
using System;

namespace Org.Webelopers.Api.Contracts.Auth
{
    public interface IStudentAuthService
    {
        Student Register(Student student);
        Student GetStudentByUsername(string username);
        Student GetStudentById(Guid id);
    }
}
