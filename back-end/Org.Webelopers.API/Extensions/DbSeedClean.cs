//using Microsoft.EntityFrameworkCore;
//using Org.Webelopers.Api.Models.DbEntities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography;
//using static BCrypt.Net.BCrypt;

//namespace Org.Webelopers.Api.Extensions
//{
//    public static class DbSeedClean
//    {
//        public static void Seed(this ModelBuilder modelBuilder)
//        {
//            var teacherDegrees = new List<TeacherDegree>();
//            var lecturerDegree = new TeacherDegree
//            {
//                Id = Guid.NewGuid(),
//                Name = "Lecturer"
//            };
//            var assistantDegree = new TeacherDegree
//            {
//                Id = Guid.NewGuid(),
//                Name = "Assistant"
//            };
//            teacherDegrees.Add(lecturerDegree);
//            teacherDegrees.Add(lecturerDegree);
//            modelBuilder.Entity<TeacherDegree>().HasData(teacherDegrees);

//            var accounts = new List<Account>();
//            var teacherAccount1 = new Account()
//            {
//                Id = Guid.NewGuid(),
//                Username = "GabrielNeacșu",
//                Email = $"teacher1@teacher.com",
//                PasswordHash = HashPassword("teacherpassword"),
//                FirstName = $"Gabriel",
//                LastName = $"Neacșu",
//                About = "Salut, eu sunt profesorul Gabriel Neacșu!",
//                Role = "Teacher"
//            };
//            var teacherAccount2 = new Account()
//            {
//                Id = Guid.NewGuid(),
//                Username = "AndreiChirilă",
//                Email = "teacher2@teacher.com",
//                PasswordHash = HashPassword("teacherpassword"),
//                FirstName = "Andrei",
//                LastName = "Chirilă",
//                About = "Salut, eu sunt profesorul Andrei Chirilă!",
//                Role = "Teacher"
//            };
//            var studentAccount1 = new Account()
//            {
//                Id = Guid.NewGuid(),
//                Username = "MirceaNegrău",
//                Email = $"student1@teacher.com",
//                PasswordHash = HashPassword("studentpassword"),
//                FirstName = $"Mircea",
//                LastName = "Negrău",
//                About = "Salut, eu sunt studentul Mircea Negrău!",
//                Role = "Student"
//            };
//            var studentAccount2 = new Account()
//            {
//                Id = Guid.NewGuid(),
//                Username = "EmanuelPop",
//                Email = $"student2@teacher.com",
//                PasswordHash = HashPassword("studentpassword"),
//                FirstName = "Emanuel",
//                LastName = "Pop",
//                About = "Salut, eu sunt studentul Emanuel Pop!",
//                Role = "Student"
//            };
//            var adminAccount = new Account()
//            {
//                Id = Guid.NewGuid(),
//                Username = "Admin",
//                Email = $"admin1@admin.com",
//                PasswordHash = HashPassword("adminpassword"),
//                FirstName = "Admin",
//                LastName = "Admin",
//                About = "Salut, eu sunt un admin!",
//                Role = "Admin"
//            };
//            accounts.Add(teacherAccount1);
//            accounts.Add(teacherAccount2);
//            accounts.Add(studentAccount1);
//            accounts.Add(studentAccount2);
//            accounts.Add(adminAccount);
//            modelBuilder.Entity<Account>().HasData(accounts);

//            var teachers = new List<Teacher>();
//            var lecturerTeacher = new Teacher()
//            {
//                AccountId = teacherAccount1.Id,
//                TeacherDegreeId = lecturerDegree.Id
//            };
//            var assistantTeacher = new Teacher()
//            {
//                AccountId = teacherAccount1.Id,
//                TeacherDegreeId = assistantDegree.Id
//            };
//            teachers.Add(lecturerTeacher);
//            teachers.Add(assistantTeacher);
//            var admins = new List<Admin>();
//            var admin1 = new Admin() { AccountId = adminAccount.Id };
//            admins.Add(admin1);

//            var students = new List<Student>();
//            var student1 = new Student() { AccountId = studentAccount1.Id };
//            var student2 = new Student() { AccountId = studentAccount2.Id };
//            students.Add(student1);
//            students.Add(student2);

//            modelBuilder.Entity<Teacher>().HasData(teachers);
//            modelBuilder.Entity<Admin>().HasData(admins);
//            modelBuilder.Entity<Student>().HasData(students);

//            var faculties = new List<Faculty>();
//            var mathsAndCsFaculty = new Faculty
//            {
//                Id = Guid.NewGuid(),
//                Name = "Mathematics and Computer Science",
//                ChiefOfDepartmentId = lecturerTeacher.AccountId
//            };
//            faculties.Add(mathsAndCsFaculty);
//            modelBuilder.Entity<Faculty>().HasData(faculties);

//            var studyDegrees = new List<FacultyStudyDegree>();
//            var bachelorDegree = new FacultyStudyDegree()
//            {
//                Id = Guid.NewGuid(),
//                Name = "Bachelor"
//            };
//            studyDegrees.Add(bachelorDegree);
//            modelBuilder.Entity<FacultyStudyDegree>().HasData(studyDegrees);

//            var studyLines = new List<FacultyStudyLine>();
//            var enStudyLine = new FacultyStudyLine()
//            {
//                Id = Guid.NewGuid(),
//                Name = "English",
//                ShortName = "EN"
//            };
//            studyLines.Add(enStudyLine);
//            modelBuilder.Entity<FacultyStudyLine>().HasData(studyLines);

//            var specializations = new List<FacultySpecialization>();
//            var computerScienceSpecialization = new FacultySpecialization
//            {
//                Id = Guid.NewGuid(),
//                Name = "Computer Science",
//                Semesters = 2,
//                FacultyId = mathsAndCsFaculty.Id,
//                StudyDegreeId = bachelorDegree.Id,
//                StudyLineId = enStudyLine.Id
//            };
//            specializations.Add(computerScienceSpecialization);
//            modelBuilder.Entity<FacultySpecialization>().HasData(specializations);

//            var studyYears = new List<StudyYear>();
//            var currentStudyYear = new StudyYear
//            {
//                Id = Guid.NewGuid(),
//                StartDate = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
//                EndDate = DateTimeOffset.UtcNow.AddYears(1).ToUnixTimeSeconds(),
//                SpecializationId = computerScienceSpecialization.Id,
//            };
//            studyYears.Add(currentStudyYear);

//            modelBuilder.Entity<StudyYear>().HasData(studyYears);

//            var semesters = new List<StudySemester>();
//            var firstSemester = new StudySemester
//            {
//                Id = Guid.NewGuid(),
//                Semester = 1,
//                StudyYearId = currentStudyYear.Id,
//            };
//            var secondSemester = new StudySemester
//            {
//                Id = Guid.NewGuid(),
//                Semester = 2,
//                StudyYearId = currentStudyYear.Id,
//            };
//            semesters.Add(firstSemester);
//            semesters.Add(secondSemester);
//            modelBuilder.Entity<StudySemester>().HasData(semesters);

//            var courses = new List<MandatoryCourse>();
//            var course1 = new MandatoryCourse
//            {
//                Id = Guid.NewGuid(),
//                Name = "Object-Oriented Programming",
//                Credits = 6,
//                SemesterId = firstSemester.Id,
//                TeacherId = lecturerTeacher.AccountId,
//            };
//            var course2 = new MandatoryCourse
//            {
//                Id = Guid.NewGuid(),
//                Name = "Graph Theory",
//                Credits = 5,
//                SemesterId = firstSemester.Id,
//                TeacherId = assistantTeacher.AccountId,
//            };
//            var course3 = new MandatoryCourse
//            {
//                Id = Guid.NewGuid(),
//                Name = "Methods of Advanced Programming",
//                Credits = 5,
//                SemesterId = secondSemester.Id,
//                TeacherId = assistantTeacher.AccountId,
//            };
//            var course4 = new MandatoryCourse
//            {
//                Id = Guid.NewGuid(),
//                Name = "Artificial Intelligence",
//                Credits = 6,
//                SemesterId = secondSemester.Id,
//                TeacherId = lecturerTeacher.AccountId,
//            };
//            courses.Add(course1);
//            courses.Add(course2);
//            courses.Add(course3);
//            courses.Add(course4);
//            modelBuilder.Entity<MandatoryCourse>().HasData(courses);

//            var optionalCourses = new List<OptionalCourse>();
//            var optionalCourse1 = new OptionalCourse
//            {
//                Id = Guid.NewGuid(),
//                Name = "Algebra 1",
//                Credits = 4,
//                SemesterId = firstSemester.Id,
//                TeacherId = lecturerTeacher.AccountId,
//                MaxNumberOfStudent = 20
//            };
//            var optionalCourse2 = new OptionalCourse
//            {
//                Id = Guid.NewGuid(),
//                Name = "Analysis 1",
//                Credits = 3,
//                SemesterId = firstSemester.Id,
//                TeacherId = assistantTeacher.AccountId,
//                MaxNumberOfStudent = 15
//            };
//            var optionalCourse3 = new OptionalCourse
//            {
//                Id = Guid.NewGuid(),
//                Name = "Algebra 2",
//                Credits = 4,
//                SemesterId = secondSemester.Id,
//                TeacherId = assistantTeacher.AccountId,
//                MaxNumberOfStudent = 35
//            };
//            var optionalCourse4 = new OptionalCourse
//            {
//                Id = Guid.NewGuid(),
//                Name = "Analysis 2",
//                Credits = 3,
//                SemesterId = secondSemester.Id,
//                TeacherId = lecturerTeacher.AccountId,
//                MaxNumberOfStudent = 45
//            };
//            optionalCourses.Add(optionalCourse1);
//            optionalCourses.Add(optionalCourse2);
//            optionalCourses.Add(optionalCourse3);
//            optionalCourses.Add(optionalCourse4);
//            modelBuilder.Entity<OptionalCourse>().HasData(optionalCourses);

//            var studyContracts = new List<StudentContract>();
//            for (int i = 0; i < students.Count; i++)
//            {
//                var group = groups[i % groups.Count];
//                studyContracts.Add(new StudentContract
//                {
//                    Id = Guid.NewGuid(),
//                    SignedAt = 1647781930,
//                    StudentId = students[i].AccountId,
//                    StudyYearId = studyYears[random.Next(studyYears.Count)].Id,
//                    GroupId = group.Id,
//                });
//                if (i % 50 == 0)
//                {
//                    group = groups[(i + RandomNumberGenerator.GetInt32(50)) % groups.Count];
//                    studyContracts.Add(new StudentContract
//                    {
//                        Id = Guid.NewGuid(),
//                        SignedAt = 1647781930,
//                        StudentId = students[i].AccountId,
//                        StudyYearId = studyYears[random.Next(studyYears.Count)].Id,
//                        GroupId = group.Id,
//                    });
//                }
//            }
//            modelBuilder.Entity<StudentContract>().HasData(studyContracts);

//            //#########
//            var yearId = studyYears[random.Next(studyYears.Count)];

//            var grades = new List<MandatoryCourseGrade>();
//            for (int k = 0; k < 10; ++k)
//            {
//                var courseId = courses[random.Next(0, courses.Count)].Id;
//                for (int i = 0; i < students.Count; i++)
//                {
//                    int limit = random.Next(5, 20);
//                    int randomChoice = random.Next(0, 2);

//                    for (int j = 0; j < limit; ++j)
//                    {
//                        if (randomChoice == 0)
//                            grades.Add(new MandatoryCourseGrade
//                            {
//                                Id = Guid.NewGuid(),
//                                Grade = (short)RandomNumberGenerator.GetInt32(9, 10),
//                                CreatedAt = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
//                                StudentId = students[i].AccountId,
//                                CourseId = courseId

//                            });
//                        else
//                            grades.Add(new MandatoryCourseGrade
//                            {
//                                Id = Guid.NewGuid(),
//                                Grade = (short)RandomNumberGenerator.GetInt32(1, 4),
//                                CreatedAt = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
//                                StudentId = students[i].AccountId,
//                                CourseId = courseId

//                            });
//                    }


//                }
//            }

//            modelBuilder.Entity<MandatoryCourseGrade>().HasData(grades);

//        }
//    }
//}
