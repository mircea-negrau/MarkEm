using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Org.Webelopers.Api.Models.DbEntities.BaseClasses;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class Teacher : BaseAccount
    {
        [ForeignKey("Id")]
        public Guid TeacherDegreeId { get; set; }

        #region References

        public virtual List<MandatoryCourse> Courses { get; set; }

        public virtual List<OptionalCourse> OptionalCourses { get; set; }

        public virtual TeacherDegree TeacherDegree { get; set; }

        #endregion
    }
}
