using System;
using System.Collections.Generic;
using System.Linq;
using Org.Webelopers.Api.Contracts;
using Org.Webelopers.Api.Extensions;
using Org.Webelopers.Api.Models.DbEntities;

namespace Org.Webelopers.Api.Logic
{
    public class TestingService : ITestingService
    {
        #region FieldsAndConstructor

        private readonly DatabaseContext _context;

        public TestingService(DatabaseContext context)
        {
            _context = context;
        }

        #endregion

        public FacultySpecialization CreateRandomSpecialization(string name) =>
            new()
            {
                Id = Guid.NewGuid(),
                Name = name,
                // Semesters = (short) (2 * RandomGetter.Get().Next(3, 5)),
                Semesters = (short) (2 * Enumerable.Range(3, 3).Random()),
                FacultyId = _context.Faculties.Random().Id,
                StudyDegreeId = _context.StudyDegrees.Random().Id,
                StudyLineId = _context.StudyLines.Random().Id
            };

        public HashSet<FacultySpecialization> AddRandomSpecializations(int noOfSpecializations)
        {
            var specializations = new HashSet<FacultySpecialization>();
            string currentTime = $"{DateTimeOffset.Now:yyyy-MM-dd HH:mm:ss}";
            
            Console.WriteLine($"currentTime: {currentTime}");
            for (int i = 0; i < noOfSpecializations; i++)
            {
                var specialization = CreateRandomSpecialization($"{currentTime} Spec{i:00}");
                specializations.Add(specialization);
                Console.WriteLine($"added specialization {specialization.Name}");
            }
            
            _context.Specialisations.AddRange(specializations);
            _context.SaveChanges();
            return specializations;
        }
    
        /// <summary>
        /// assumes there are semester contracts
        /// </summary>
        public void AddEnrollmentsToCourse(Guid courseId)
        {
            const int numberOfGroups = 5;
            const int studentsPerGroup = 10;
            var groups = _context.Groups.Take(numberOfGroups).ToList();
            var semesterContracts = _context.SemesterContracts
                .Take(numberOfGroups * studentsPerGroup).ToList();
            int skip = 0;
            var enrollments = new List<StudentMandatoryCourseEnrollment>();
            
            Console.WriteLine($"Found {groups.Count} groups");
            Console.WriteLine($"Found {semesterContracts.Count} semester contracts");
            
            foreach (var group in groups)
            {
                enrollments.AddRange(semesterContracts
                    .Skip(skip)
                    .Take(studentsPerGroup)
                    .Select(semesterContract => new StudentMandatoryCourseEnrollment
                    {
                        Id = Guid.NewGuid(), 
                        StudentContractSemesterId = semesterContract.Id, 
                        MandatoryCourseId = courseId, 
                        GroupId = group.Id,
                    }));

                skip += studentsPerGroup;
            }
            
            Console.WriteLine($"Added {enrollments.Count} enrollments");
            _context.StudentEnrolledCourse.AddRange(enrollments);
            _context.SaveChanges();
        }
    }
}