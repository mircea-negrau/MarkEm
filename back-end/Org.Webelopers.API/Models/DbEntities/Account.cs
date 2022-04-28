using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class Account
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Role { get; set; }

        [Required]
        [StringLength(256)]
        public string Username { get; set; }

        [Required]
        [JsonIgnore]
        public string EmailHash { get; set; }

        [Required]
        [JsonIgnore]
        public string PasswordHash { get; set; }

        [Required]
        [StringLength(128)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(128)]
        public string LastName { get; set; }

        public byte[] Picture { get; set; } // TODO: maybe move to a Profile class and table

        [StringLength(1024)]
        public string About { get; set; } // TODO: maybe move to a Profile class and table
    }
}
