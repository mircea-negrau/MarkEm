using Microsoft.EntityFrameworkCore;
using Org.Webelopers.Api.Models.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Org.Webelopers.Api.Extensions
{
    public static class DbSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var teacherDegrees = new List<TeacherDegree>();
            for (int i = 0; i < 5; i++)
            {
                teacherDegrees.Add(new TeacherDegree
                {
                    Id = Guid.NewGuid(),
                    Name = $"TeacherDegree{i}"
                });
            }
            modelBuilder.Entity<TeacherDegree>().HasData(teacherDegrees);

            var teachers = new List<Teacher>();
            for (int i = 0; i < 100; i++)
            {
                teachers.Add(new Teacher
                {
                    Id = Guid.NewGuid(),
                    Username = $"TestTeacher{i}",
                    EmailHash = "dummyEmailHash",
                    PasswordHash = "dummyPasswordHash",
                    Salt = "dummySalt",
                    FirstName = $"firstName{i}",
                    LastName = $"firstName{i}",
                    DateOfBirth = 732624581,
                    TeacherDegreeId = teacherDegrees[i % teacherDegrees.Count].Id
                });
            }
            modelBuilder.Entity<Teacher>().HasData(teachers);

            var students = new List<Student>();
            for (int i = 0; i < 324; i++)
            {
                students.Add(new Student
                {
                    Id = Guid.NewGuid(),
                    Username = $"TestStudent{i}",
                    EmailHash = "dummyEmailHash",
                    PasswordHash = "dummyPasswordHash",
                    FirstName = $"firstName{i}",
                    LastName = $"firstName{i}",
                    DateOfBirth = 732624581,
                });
            }
            modelBuilder.Entity<Student>().HasData(students);

            var admins = new List<Admin>();
            for (int i = 0; i < 100; i++)
            {
                admins.Add(new Admin
                {
                    Id = Guid.NewGuid(),
                    Username = $"TestAdmin{i}",
                    EmailHash = "dummyEmailHash",
                    PasswordHash = "dummyPasswordHash",
                    Salt = "dummySalt",
                    FirstName = $"firstName{i}",
                    LastName = $"firstName{i}",
                });
            }
            modelBuilder.Entity<Admin>().HasData(admins);

            var faculties = new List<Faculty>();
            for (int i = 0; i < 3; i++)
            {
                faculties.Add(new Faculty
                {
                    Id = Guid.NewGuid(),
                    Name = $"Faculty-{i}",
                    ChiefOfDepartmentId = teachers[i].Id
                });
            }
            modelBuilder.Entity<Faculty>().HasData(faculties);

            var studyDegrees = new List<StudyDegree>();
            for (int i = 0; i < faculties.Count; i++)
            {
                studyDegrees.Add(new StudyDegree
                {
                    Id = Guid.NewGuid(),
                    Name = $"StudyDegree-{i * 2}",
                    FacultyId = faculties[i].Id
                });
                studyDegrees.Add(new StudyDegree
                {
                    Id = Guid.NewGuid(),
                    Name = $"StudyDegree-{i * 2 + 1}",
                    FacultyId = faculties[i].Id
                });
            }
            modelBuilder.Entity<StudyDegree>().HasData(studyDegrees);

            var specialisations = new List<Specialisation>();
            for (int i = 0; i < studyDegrees.Count; i++)
            {
                specialisations.Add(new Specialisation
                {
                    Id = Guid.NewGuid(),
                    Name = $"Specialisation-{i * 3}",
                    StudyDegreeId = studyDegrees[i].Id
                });
                specialisations.Add(new Specialisation
                {
                    Id = Guid.NewGuid(),
                    Name = $"Specialisation-{i * 3 + 1}",
                    StudyDegreeId = studyDegrees[i].Id
                });
                specialisations.Add(new Specialisation
                {
                    Id = Guid.NewGuid(),
                    Name = $"Specialisation-{i * 3 + 2}",
                    StudyDegreeId = studyDegrees[i].Id
                });
            }
            modelBuilder.Entity<Specialisation>().HasData(specialisations);

            var studyYears = new List<StudyYear>();
            for (int i = 0; i < specialisations.Count; i++)
            {
                studyYears.Add(new StudyYear
                {
                    Id = Guid.NewGuid(),
                    Year = 1,
                    SpecialisationId = specialisations[i].Id
                });
                studyYears.Add(new StudyYear
                {
                    Id = Guid.NewGuid(),
                    Year = 2,
                    SpecialisationId = specialisations[i].Id
                });
                studyYears.Add(new StudyYear
                {
                    Id = Guid.NewGuid(),
                    Year = 3,
                    SpecialisationId = specialisations[i].Id
                });
            }
            modelBuilder.Entity<StudyYear>().HasData(studyYears);

            var groups = new List<Group>();
            for (int i = 0; i < studyYears.Count; i++)
            {
                groups.Add(new Group
                {
                    Id = Guid.NewGuid(),
                    StudyYearId = studyYears[i].Id,
                    TutorTeacherId = i * 3 >= teachers.Count ? null : teachers[i * 3 + 0].Id,
                    LeaderStudentId = students[(i * 3 + 0) % students.Count].Id
                });
                groups.Add(new Group
                {
                    Id = Guid.NewGuid(),
                    StudyYearId = studyYears[i].Id,
                    TutorTeacherId = i * 3 + 1 >= teachers.Count ? null : teachers[i * 3 + 1].Id,
                    LeaderStudentId = students[(i * 3 + 1) % students.Count].Id
                });
                groups.Add(new Group
                {
                    Id = Guid.NewGuid(),
                    StudyYearId = studyYears[i].Id,
                    TutorTeacherId = i * 3 + 2 >= teachers.Count ? null : teachers[i * 3 + 2].Id,
                    LeaderStudentId = students[(i * 3 + 2) % students.Count].Id
                });
            }
            modelBuilder.Entity<Group>().HasData(groups);

            var semesters = new List<StudySemester>();
            for (int i = 0; i < studyYears.Count; i++)
            {
                semesters.Add(new StudySemester
                {
                    Id = Guid.NewGuid(),
                    Semester = 1,
                    StudyYearId = studyYears[i].Id,
                });
                semesters.Add(new StudySemester
                {
                    Id = Guid.NewGuid(),
                    Semester = 2,
                    StudyYearId = studyYears[i].Id,
                });
            }
            modelBuilder.Entity<StudySemester>().HasData(semesters);

            var courses = new List<Course>();
            for (int i = 0; i < semesters.Count; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    courses.Add(new Course
                    {
                        Id = Guid.NewGuid(),
                        Name = $"Course{i * j}",
                        Credits = (short)RandomNumberGenerator.GetInt32(6),
                        SemesterId = semesters[i].Id,
                        TeacherId = teachers[(i * j) % teachers.Count].Id,
                    });
                }
            }
            modelBuilder.Entity<Course>().HasData(courses);

            var optionalCourses = new List<OptionalCourse>();
            var optionals = new Dictionary<Guid, List<OptionalCourse>>();
            for (int i = 0; i < semesters.Count; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    var optionalCourse = new OptionalCourse
                    {
                        Id = Guid.NewGuid(),
                        Name = $"Course{i * j}",
                        Credits = (short)RandomNumberGenerator.GetInt32(6),
                        SemesterId = semesters[i].Id,
                        TeacherId = teachers[(i * j) % teachers.Count].Id,
                    };
                    var targetStudyYear = studyYears.First(x => x.Id == semesters[i].StudyYearId).Id;
                    if (!optionals.ContainsKey(targetStudyYear))
                    {
                        optionals[targetStudyYear] = new List<OptionalCourse>();
                    }
                    optionals[targetStudyYear].Add(optionalCourse);
                    optionalCourses.Add(optionalCourse);
                }
            }
            modelBuilder.Entity<OptionalCourse>().HasData(optionalCourses);

            var studyContracts = new List<StudyContract>();
            for (int i = 0; i < students.Count; i++)
            {
                var group = groups[i % groups.Count];
                var availableOptionals = optionals[group.StudyYearId];
                studyContracts.Add(new StudyContract
                {
                    Id = Guid.NewGuid(),
                    SignedAt = 1647781930,
                    StudentId = students[i].Id,
                    GroupId = group.Id,
                    OptionalCourseId = availableOptionals[i % availableOptionals.Count].Id
                });
                if (i % 50 == 0)
                {
                    availableOptionals = optionals[group.StudyYearId];
                    group = groups[(i + RandomNumberGenerator.GetInt32(50)) % groups.Count];
                    studyContracts.Add(new StudyContract
                    {
                        Id = Guid.NewGuid(),
                        SignedAt = 1647781930,
                        StudentId = students[i].Id,
                        GroupId = group.Id,
                        OptionalCourseId = availableOptionals[i % availableOptionals.Count].Id
                    });
                }
            }
            modelBuilder.Entity<StudyContract>().HasData(studyContracts);
        }
    }
}
