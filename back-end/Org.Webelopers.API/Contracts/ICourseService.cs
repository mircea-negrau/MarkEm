using System;
using System.Threading.Tasks;
using Org.Webelopers.Api.Models.Persistence.Courses;

namespace Org.Webelopers.Api.Contracts
{
    public interface ICourseService
    {
        public void AddCourse(string name, short credits, Guid semesterId, Guid teacherId);
        public void UpdateCourse(Guid courseId, string name, short? credits, Guid? semesterId, Guid? teacherId);
        public void DeleteCourse(Guid courseId);
        public Task<TeacherCoursesResponse> GetEnrichedCoursesByTeacher(Guid teacherId);
    }
}
