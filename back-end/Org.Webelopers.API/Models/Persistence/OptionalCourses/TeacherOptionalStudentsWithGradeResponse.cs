using System.Collections.Generic;
using Org.Webelopers.Api.Models.Persistence.Groups;

namespace Org.Webelopers.Api.Models.Persistence.OptionalCourses
{
    public class TeacherOptionalStudentsWithGradeResponse
    {
        public List<StudentWithGrade> StudentsWithGrade { get; set; }
    }
}