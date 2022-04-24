using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Org.Webelopers.Api.Models.DbEntities.Changed
{
    public class ContractSemester
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [ForeignKey("Id")]
        public Guid ContractId { get; set; }

        [ForeignKey("Id")]
        public Guid SemesterId { get; set; }

        [ForeignKey("Id")]
        public Guid? OptionalCourseId { get; set; }
    }
}
