using System;

namespace Org.Webelopers.Api.Models.Persistence.Groups
{
    public class TeacherGroupStudent
    {
        public Guid Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public short Grade { get; set; }
    }
}