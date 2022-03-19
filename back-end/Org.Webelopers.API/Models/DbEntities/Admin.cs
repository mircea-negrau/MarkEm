using System;
using System.ComponentModel.DataAnnotations;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class Admin
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Username { get; set; }

        [Required]
        public string EmailHash { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public string Salt { get; set; }

        [StringLength(128)]
        public string FirstName { get; set; }

        [StringLength(128)]
        public string LastName { get; set; }

        #region References

        #endregion
    }
}
