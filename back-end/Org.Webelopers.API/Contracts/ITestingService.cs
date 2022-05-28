using System;
using System.Collections.Generic;
using Org.Webelopers.Api.Models.DbEntities;

namespace Org.Webelopers.Api.Contracts
{
    public interface ITestingService
    {
        public FacultySpecialization CreateRandomSpecialization(string name);
        public HashSet<FacultySpecialization> AddRandomSpecializations(int noOfSpecializations);

        public void AddEnrollmentsToCourse(Guid courseId);
    }
}