using Org.Webelopers.Api.Models.DbEntities.BaseClasses;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class MandatoryCourse : BaseCourse
    {
        #region References

        public virtual List<MandatoryCourseGrade> Grades { get; set; }

        public virtual List<StudentMandatoryCourseEnrollment> SemesterContractCourses { get; set; }

        #endregion
    }
}
