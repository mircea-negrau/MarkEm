using System.Collections.Generic;
using Org.Webelopers.Api.Models.DbEntities;

namespace Org.Webelopers.Api.Models.OptionalCoursesService
{
    public class OptionalCoursesAssignmentResults
    {
        public OptionalCoursesAssignmentResults(List<OptionalCourse> selectedOptionalCourses, int numberOfStudentsWithRandomOptionalCourseAssigned, int numberOfStudentsWithNoOptionalCourseAssigned)
        {
            SelectedOptionalCourses = selectedOptionalCourses;
            NumberOfStudentsWithRandomOptionalCourseAssigned = numberOfStudentsWithRandomOptionalCourseAssigned;
            NumberOfStudentsWithNoOptionalCourseAssigned = numberOfStudentsWithNoOptionalCourseAssigned;
        }

        public List<OptionalCourse> SelectedOptionalCourses { get; }
        public int NumberOfStudentsWithRandomOptionalCourseAssigned { get; }
        public int NumberOfStudentsWithNoOptionalCourseAssigned { get; }
    }
}