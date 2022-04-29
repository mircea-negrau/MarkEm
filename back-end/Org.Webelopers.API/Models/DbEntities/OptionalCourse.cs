using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Org.Webelopers.Api.Models.DbEntities.BaseClasses;

namespace Org.Webelopers.Api.Models.DbEntities
{
    public class OptionalCourse : BaseCourse
    {
        [Required]
        public bool IsProposed { get; set; }

        [Required]
        public bool IsApproved { get; set; }

        [Required]
        public int MaxNumberOfStudent { get; set; }

        #region References

        public virtual List<StudentContractSemester> Contracts { get; set; }

        public virtual List<OptionalCourseGrade> Grades { get; set; }

        public virtual List<OptionalCoursePreference> OptionalCoursePreferences { get; set; }

        #endregion
    }
}
