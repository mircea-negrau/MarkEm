using System;
using System.ComponentModel.DataAnnotations;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class AccountRole
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public string Role { get; set; }
    }
}
