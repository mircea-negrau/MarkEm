using System;
using System.ComponentModel.DataAnnotations;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class TeacherDegree
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }
    }
}