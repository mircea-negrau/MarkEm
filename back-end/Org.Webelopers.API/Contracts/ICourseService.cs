using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Org.Webelopers.Api.Models.DbEntities;
using Org.Webelopers.Api.Models.Persistence.Courses;
using Org.Webelopers.Api.Models.Persistence.Groups;

namespace Org.Webelopers.Api.Contracts
{
    public interface ICourseService
    {
        public void AddCourse(string name, short credits, Guid semesterId, Guid teacherId);
        public void UpdateCourse(Guid courseId, string name, short? credits, Guid? semesterId, Guid? teacherId);
        public void DeleteCourse(Guid courseId);
        public TeacherCourseDetailDto GetEnrichedCourseById(Guid courseId);
        public Task<TeacherCoursesResponse> GetEnrichedCoursesByTeacher(Guid teacherId);
        public Task<TeacherGroupsResponse> GetCourseGroups(Guid courseId);
        public bool Exists(Guid courseId);
        public bool IsCourseTaughtBy(Guid courseId, Guid teacherId);
        public HashSet<MandatoryCourse> GetFacultyCourses(Guid facultyId);
        public Task<ChiefTeachersWithCoursesInfo> GetChiefChiefTeachersWithCoursesInfo(Guid facultyId);
    }
}
