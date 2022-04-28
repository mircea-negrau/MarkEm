using System.Collections.Generic;
using Org.Webelopers.Api.Models.DbEntities.BaseClasses;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class Student : BaseAccount
    {
        #region References

        public virtual List<MandatoryCourseGrade> Grades { get; set; }

        public virtual List<OptionalCourseGrade> OptionalGrades { get; set; }

        public virtual List<StudentContract> Contracts { get; set; }

        #endregion
    }
}
