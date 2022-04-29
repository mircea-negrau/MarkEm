using Org.Webelopers.Api.Models.DbEntities;
using System.Collections.Generic;
using System;

namespace Org.Webelopers.Api.Contracts
{
    public interface ICourseService
    {
        public void AddCourse(string name, short credits, Guid semesterId, Guid teacherId);
        public void UpdateCourse(Guid courseId, string name, short? credits, Guid? semesterId, Guid? teacherId);
        public void DeleteCourse(Guid courseId);
        public List<MandatoryCourse> GetCoursesByTeacher(Guid teacherId);
    }
}
