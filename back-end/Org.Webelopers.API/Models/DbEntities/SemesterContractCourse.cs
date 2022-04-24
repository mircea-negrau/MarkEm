using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class SemesterContractCourse
    {
        [Key]
        public Guid Id { get; set; }
        
        [ForeignKey(("id"))]
        public Guid StudentContractSemesterId { get; set; }
        
        [ForeignKey("Id")]
        public Guid CourseId { get; set; }
        
        [ForeignKey("Id")]
        public Guid GroupId { get; set; }
    }
}