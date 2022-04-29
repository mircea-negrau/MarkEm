using Org.Webelopers.Api.Models.DbEntities;
using System;

namespace Org.Webelopers.Api.Models.Persistence.Profiles
{
    public class PublicProfile
    {
        public PublicProfile(Account account)
        {
            Id = account.Id;
            Role = account.Role;
            Username = account.Username;
            FirstName = account.FirstName;
            LastName = account.LastName;
            Picture = account.Picture;
            About = account.About;
        }

        public Guid Id { get; set; }

        public string Role { get; set; }

        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public byte[] Picture { get; set; }

        public string About { get; set; }
    }
}
