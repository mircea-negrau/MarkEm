using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class StudentContractSemester
    {
        [Key]
        public Guid Id { get; set; }
        
        [ForeignKey("Id")]
        public Guid StudentContractId { get; set; }
        
        [ForeignKey("Id")]
        public Guid StudySemesterId { get; set; }
        
        [ForeignKey("Id")]
        public Guid OptionalCourseId { get; set; }
        
        [ForeignKey("Id")]
        public Guid OptionalCoursePreferenceId { get; set; }
    }
}