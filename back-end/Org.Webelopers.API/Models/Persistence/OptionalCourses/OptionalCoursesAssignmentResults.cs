using Org.Webelopers.Api.Models.DbEntities;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Models.Persistence.OptionalCourses
{
    public class OptionalCoursesAssignmentResults
    {
        public List<OptionalCourse> selectedOptionalCourses { get; set; }
        public int numberOfStudentsWithRandomOptionalCourseAssigned { get; set; }
        public int numberOfStudentsWithNoOptionalCourseAssigned
        {
            get; set;

        }
    }
}
