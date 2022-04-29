using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Org.Webelopers.Api.Models.DbEntities.BaseClasses
{
    public class BaseAccount
    {
        [Key]
        [Required]
        [ForeignKey("Id")]
        public Guid AccountId { get; set; }

        #region References

        public virtual Account Account { get; set; }

        #endregion
    }
}
