using System;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Models.Persistence.Courses
{
    public class ChiefTeacherWithCoursesInfo
    {
        public string TeacherName { get; set; }
        public Guid TeacherId { get; set; }

        public List<ChiefTeacherCourseInfo> ChiefTeacherCoursesInfo { get; set; }
    }
}