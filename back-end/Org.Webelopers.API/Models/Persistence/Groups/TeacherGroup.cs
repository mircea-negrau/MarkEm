using System;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Models.Persistence.Groups
{
    public class TeacherGroup
    {
        public Guid Id { get; set; }
        
        public string Number { get; set; }
        
        public List<StudentWithGrade> Students { get; set; }
    }
}