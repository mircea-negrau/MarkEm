using Org.Webelopers.Api.Models.Persistence.Groups;
using Org.Webelopers.Api.Models.Persistence.Semester;
using Org.Webelopers.Api.Models.Persistence.Students;
using Org.Webelopers.Api.Models.Persistence.StudyYears;
using System;
using System.Collections.Generic;

namespace Org.Webelopers.Api.Contracts
{
    public interface IStatisticsService
    {
        public List<StudentAverageGradeDto> GetStudentsRankingByGroup(Guid groupId);

        public List<StudentAverageGradeDto> GetStudentsRankingByStudyYearByCriteria(Guid yearId, int minimumAverage);

        public List<StudentAverageGradeDto> GetStudentsRankingBySemester(Guid semesterId);
        public List<GroupDto> GetAllGroups();
        public List<SemesterDto> GetAllSemesters();
        public List<StudyYearDto> GetAllYears();
    }
}