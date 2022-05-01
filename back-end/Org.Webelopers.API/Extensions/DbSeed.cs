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
            var random = new Random();
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

            var accounts = new List<Account>();
            for (int i = 0; i < 100; i++)
            {
                accounts.Add(new Account()
                {
                    Id = Guid.NewGuid(),
                    Username = $"TestAccount{i}",
                    Email = "dummyEmail@email.com",
                    PasswordHash = "dummyPasswordHash",
                    FirstName = $"firstName{i}",
                    LastName = $"firstName{i}",
                    About = "",
                    Role = i < 20
                        ? "Teacher"
                        : i < 30
                            ? "Admin"
                            : "Student"
                });
            }
            modelBuilder.Entity<Account>().HasData(accounts);

            var teachers = new List<Teacher>();
            teachers = accounts.Take(20).Select(x => new Teacher() { AccountId = x.Id, TeacherDegreeId = teacherDegrees[random.Next(teacherDegrees.Count)].Id }).ToList();
            var admins = new List<Admin>();
            admins = accounts.Skip(20).Take(10).Select(x => new Admin() { AccountId = x.Id }).ToList();
            var students = new List<Student>();
            students = accounts.Skip(30).Select(x => new Student() { AccountId = x.Id }).ToList();

            modelBuilder.Entity<Teacher>().HasData(teachers);
            modelBuilder.Entity<Admin>().HasData(admins);
            modelBuilder.Entity<Student>().HasData(students);

            var faculties = new List<Faculty>();
            for (int i = 0; i < 3; i++)
            {
                faculties.Add(new Faculty
                {
                    Id = Guid.NewGuid(),
                    Name = $"Faculty-{i}",
                    ChiefOfDepartmentId = teachers[i].AccountId
                });
            }
            modelBuilder.Entity<Faculty>().HasData(faculties);

            var studyDegrees = new List<FacultyStudyDegree>
            {
                new FacultyStudyDegree()
                {
                    Id = Guid.NewGuid(),
                    Name = "Master"
                },
                new FacultyStudyDegree()
                {
                    Id = Guid.NewGuid(),
                    Name = "Bachelor"
                }
            };
            modelBuilder.Entity<FacultyStudyDegree>().HasData(studyDegrees);

            var studyLines = new List<FacultyStudyLine>
            {
                new FacultyStudyLine()
                {
                    Id = Guid.NewGuid(),
                    Name = "English",
                    ShortName = "EN"
                },
                new FacultyStudyLine()
                {
                    Id = Guid.NewGuid(),
                    Name = "Romanian",
                    ShortName = "RO"
                },
                new FacultyStudyLine()
                {
                    Id = Guid.NewGuid(),
                    Name = "German",
                    ShortName = "DE"
                }
            };
            modelBuilder.Entity<FacultyStudyLine>().HasData(studyLines);

            var specializations = new List<FacultySpecialization>();
            for (int i = 0; i < studyDegrees.Count; i++)
            {
                specializations.Add(new FacultySpecialization
                {
                    Id = Guid.NewGuid(),
                    Name = $"Specialisation-{i * 3}",
                    Semesters = 2,
                    FacultyId = faculties[random.Next(faculties.Count)].Id,
                    StudyDegreeId = studyDegrees[random.Next(studyDegrees.Count)].Id,
                    StudyLineId = studyLines[random.Next(studyLines.Count)].Id
                });
                specializations.Add(new FacultySpecialization
                {
                    Id = Guid.NewGuid(),
                    Name = $"Specialisation-{i * 3 + 1}",
                    Semesters = 2,
                    FacultyId = faculties[random.Next(faculties.Count)].Id,
                    StudyDegreeId = studyDegrees[random.Next(studyDegrees.Count)].Id,
                    StudyLineId = studyLines[random.Next(studyLines.Count)].Id
                });
                specializations.Add(new FacultySpecialization
                {
                    Id = Guid.NewGuid(),
                    Name = $"Specialisation-{i * 3 + 2}",
                    Semesters = 2,
                    FacultyId = faculties[random.Next(faculties.Count)].Id,
                    StudyDegreeId = studyDegrees[random.Next(studyDegrees.Count)].Id,
                    StudyLineId = studyLines[random.Next(studyLines.Count)].Id
                });
            }
            modelBuilder.Entity<FacultySpecialization>().HasData(specializations);

            var studyYears = new List<StudyYear>();

            for (int i = 0; i < specializations.Count; i++)
            {
                studyYears.Add(new StudyYear
                {
                    Id = Guid.NewGuid(),
                    StartDate = DateTimeOffset.UtcNow.AddYears(-1).ToUnixTimeSeconds(),
                    EndDate = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
                    SpecializationId = specializations[i].Id,
                    StudentLeaderId = students[random.Next(students.Count)].AccountId
                });
                studyYears.Add(new StudyYear
                {
                    Id = Guid.NewGuid(),
                    StartDate = DateTimeOffset.UtcNow.AddYears(-2).ToUnixTimeSeconds(),
                    EndDate = DateTimeOffset.UtcNow.AddYears(-1).ToUnixTimeSeconds(),
                    SpecializationId = specializations[i].Id,
                });
                studyYears.Add(new StudyYear
                {
                    Id = Guid.NewGuid(),
                    StartDate = DateTimeOffset.UtcNow.AddYears(-3).ToUnixTimeSeconds(),
                    EndDate = DateTimeOffset.UtcNow.AddYears(-2).ToUnixTimeSeconds(),
                    SpecializationId = specializations[i].Id,
                });
            }
            modelBuilder.Entity<StudyYear>().HasData(studyYears);

            var studentLeaders = new List<Guid>();
            var tutorTeachers = new List<Guid>();
            var groups = new List<FacultyGroup>();
            for (int i = 0; i < studyYears.Count; i++)
            {
                Guid? leaderId = null;
                while (leaderId is null || studentLeaders.Contains((Guid)leaderId))
                {
                    leaderId = students[random.Next(students.Count)].AccountId;
                }
                Guid? tutorId = null;
                while (tutorId is null || tutorTeachers.Contains((Guid)tutorId))
                {
                    tutorId = teachers[random.Next(teachers.Count)].AccountId;
                }
                studentLeaders.Add((Guid)leaderId);
                tutorTeachers.Add((Guid)tutorId);
                groups.Add(new FacultyGroup
                {
                    Id = Guid.NewGuid(),
                    TutorTeacherId = (Guid)tutorId,
                    LeaderStudentId = (Guid)leaderId
                });
                groups.Add(new FacultyGroup
                {
                    Id = Guid.NewGuid(),
                });
                groups.Add(new FacultyGroup
                {
                    Id = Guid.NewGuid(),
                });
            }
            modelBuilder.Entity<FacultyGroup>().HasData(groups);

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

            var courses = new List<MandatoryCourse>();
            for (int i = 0; i < semesters.Count; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    courses.Add(new MandatoryCourse
                    {
                        Id = Guid.NewGuid(),
                        Name = $"Course{i * j}",
                        Credits = (short)RandomNumberGenerator.GetInt32(6),
                        SemesterId = semesters[i].Id,
                        TeacherId = teachers[random.Next(teachers.Count)].AccountId,
                    });
                }
            }
            modelBuilder.Entity<MandatoryCourse>().HasData(courses);

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
                        TeacherId = teachers[random.Next(teachers.Count)].AccountId,
                        MaxNumberOfStudent = 20
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

            var studyContracts = new List<StudentContract>();
            for (int i = 0; i < students.Count; i++)
            {
                var group = groups[i % groups.Count];
                studyContracts.Add(new StudentContract
                {
                    Id = Guid.NewGuid(),
                    SignedAt = 1647781930,
                    StudentId = students[i].AccountId,
                    StudyYearId = studyYears[random.Next(studyYears.Count)].Id,
                    GroupId = group.Id,
                });
                if (i % 50 == 0)
                {
                    group = groups[(i + RandomNumberGenerator.GetInt32(50)) % groups.Count];
                    studyContracts.Add(new StudentContract
                    {
                        Id = Guid.NewGuid(),
                        SignedAt = 1647781930,
                        StudentId = students[i].AccountId,
                        StudyYearId = studyYears[random.Next(studyYears.Count)].Id,
                        GroupId = group.Id,
                    });
                }
            }
            modelBuilder.Entity<StudentContract>().HasData(studyContracts);
        }
    }
}
