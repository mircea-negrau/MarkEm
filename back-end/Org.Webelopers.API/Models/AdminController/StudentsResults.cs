using Org.Webelopers.Api.Models.DbEntities;
using System;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Models.Authentication
{
    public class StudentsResults
    {
        public Guid Id { get; set; }
        public List<CourseGrade> Grades { get; set; }

        public double AverageGrade { get; set; }
    }
}
