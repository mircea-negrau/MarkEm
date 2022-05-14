using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using Org.Webelopers.Api.Logic;
using Org.Webelopers.Api.Models.DbEntities;
using Org.Webelopers.Api.Models.DbEntities.BaseClasses;

namespace Org.Webelopers.Api.Extensions
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TeacherDegree> TeacherDegrees { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<FacultyStudyDegree> StudyDegrees { get; set; }
        public virtual DbSet<FacultyStudyLine> StudyLines { get; set; }
        public virtual DbSet<FacultySpecialization> Specialisations { get; set; }
        public virtual DbSet<StudyYear> StudyYears { get; set; }
        public virtual DbSet<StudySemester> StudySemesters { get; set; }
        public virtual DbSet<MandatoryCourse> Courses { get; set; }
        public virtual DbSet<MandatoryCourseGrade> Grades { get; set; }
        public virtual DbSet<OptionalCourse> OptionalCourses { get; set; }
        public virtual DbSet<OptionalCourseGrade> OptionalGrades { get; set; }
        public virtual DbSet<OptionalCoursePreference> OptionalCoursePreferences { get; set; }
        public virtual DbSet<StudentContract> Contracts { get; set; }
        public virtual DbSet<StudentContractSemester> SemesterContracts { get; set; }
        public virtual DbSet<StudentMandatoryCourseEnrollment> StudentEnrolledCourse { get; set; }
        public virtual DbSet<FacultyGroup> Groups { get; set; }

        public DbSet<TCourse> CoursesByType<TCourse>() where TCourse : BaseCourse => Set<TCourse>();

        public TEntity FindEntity<TEntity>(Predicate<TEntity> predicate) where TEntity : class =>
            Set<TEntity>().FirstOrDefault(entity => predicate(entity));

        public TEntity FindEntityAndThrowIfNullReference<TEntity>(Predicate<TEntity> predicate, String exceptionMessage) where TEntity : class =>
            Utils.ThrowIfNullReference(FindEntity(predicate), exceptionMessage);

        #region Configuration

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(AccountConfigure);
            modelBuilder.Entity<Admin>(AdminConfigure);
            modelBuilder.Entity<Student>(StudentConfigure);
            modelBuilder.Entity<Teacher>(TeacherConfigure);
            modelBuilder.Entity<TeacherDegree>(TeacherDegreeConfigure);
            modelBuilder.Entity<Faculty>(FacultyConfigure);
            modelBuilder.Entity<FacultyStudyDegree>(FacultyStudyDegreeConfigure);
            modelBuilder.Entity<FacultyStudyLine>(FacultyStudyLineConfigure);
            modelBuilder.Entity<FacultySpecialization>(FacultySpecializationConfigure);
            modelBuilder.Entity<StudyYear>(StudyYearConfigure);
            modelBuilder.Entity<StudySemester>(StudySemesterConfigure);
            modelBuilder.Entity<MandatoryCourse>(MandatoryCourseConfigure);
            modelBuilder.Entity<MandatoryCourseGrade>(MandatoryCourseGradeConfigure);
            modelBuilder.Entity<OptionalCourse>(OptionalCourseConfigure);
            modelBuilder.Entity<OptionalCourseGrade>(OptionalCourseGradeConfigure);
            modelBuilder.Entity<OptionalCoursePreference>(OptionalCoursePreferenceConfigure);
            modelBuilder.Entity<StudentContract>(StudentContractConfigure);
            modelBuilder.Entity<StudentContractSemester>(StudentContractSemesterConfigure);
            modelBuilder.Entity<StudentMandatoryCourseEnrollment>(StudentEnrolledCourseConfigure);
            modelBuilder.Entity<FacultyGroup>(GroupConfigure);
            modelBuilder.Seed();
        }

        private static void AccountConfigure(EntityTypeBuilder<Account> builder)
        {
            builder
                .Property(account => account.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
            builder
                .HasIndex(account => account.Email)
                .IsUnique();
        }

        private static void AdminConfigure(EntityTypeBuilder<Admin> builder)
        {
            builder
                .HasOne(admin => admin.Account)
                .WithOne()
                .HasForeignKey<Admin>(admin => admin.AccountId)
                .OnDelete(DeleteBehavior.NoAction);
        }

        private static void StudentConfigure(EntityTypeBuilder<Student> builder)
        {
            builder
                .HasOne(student => student.Account)
                .WithOne()
                .HasForeignKey<Student>(student => student.AccountId)
                .OnDelete(DeleteBehavior.NoAction);
        }

        private static void TeacherConfigure(EntityTypeBuilder<Teacher> builder)
        {
            builder
                .HasOne(teacher => teacher.Account)
                .WithOne()
                .HasForeignKey<Teacher>(teacher => teacher.AccountId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasOne(teacher => teacher.TeacherDegree)
                .WithMany(degree => degree.Teachers)
                .HasForeignKey(teacher => teacher.TeacherDegreeId)
                .OnDelete(DeleteBehavior.SetNull);
        }

        private static void TeacherDegreeConfigure(EntityTypeBuilder<TeacherDegree> builder)
        {
            builder
                .Property(teacherDegree => teacherDegree.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
        }

        private static void FacultyConfigure(EntityTypeBuilder<Faculty> builder)
        {
            builder
                .Property(faculty => faculty.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
            builder
                .HasOne(faculty => faculty.ChiefOfDepartment)
                .WithOne()
                .HasForeignKey<Faculty>(faculty => faculty.ChiefOfDepartmentId)
                .OnDelete(DeleteBehavior.SetNull);
        }

        private static void FacultySpecializationConfigure(EntityTypeBuilder<FacultySpecialization> builder)
        {
            builder
                .Property(specialisation => specialisation.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
            builder
                .HasOne(specialisation => specialisation.Faculty)
                .WithMany(faculty => faculty.Specialisations)
                .HasForeignKey(specialisation => specialisation.FacultyId)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasOne(specialisation => specialisation.StudyDegree)
                .WithMany(studyDegree => studyDegree.Specialisations)
                .HasForeignKey(specialisation => specialisation.StudyDegreeId)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasOne(specialisation => specialisation.StudyLine)
                .WithMany(x => x.Specialisations)
                .HasForeignKey(specialisation => specialisation.StudyLineId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        private static void FacultyStudyDegreeConfigure(EntityTypeBuilder<FacultyStudyDegree> builder)
        {
            builder
                .Property(studyDegree => studyDegree.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
        }

        private static void FacultyStudyLineConfigure(EntityTypeBuilder<FacultyStudyLine> builder)
        {
            builder
                .Property(studyLine => studyLine.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
        }

        private static void StudyYearConfigure(EntityTypeBuilder<StudyYear> builder)
        {
            builder
                .Property(faculty => faculty.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
            builder
                .HasOne(studyYear => studyYear.Specialization)
                .WithMany(specialisation => specialisation.StudyYears)
                .HasForeignKey(studyYear => studyYear.SpecializationId)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasOne(studyYear => studyYear.StudentLeader)
                .WithOne()
                .HasForeignKey<StudyYear>(studyYear => studyYear.StudentLeaderId)
                .OnDelete(DeleteBehavior.SetNull);
        }

        private static void StudySemesterConfigure(EntityTypeBuilder<StudySemester> builder)
        {
            builder
                .Property(studySemester => studySemester.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
            builder
                .HasOne(studySemester => studySemester.StudyYear)
                .WithMany(studyYear => studyYear.Semesters)
                .HasForeignKey(group => group.StudyYearId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        private static void MandatoryCourseConfigure(EntityTypeBuilder<MandatoryCourse> builder)
        {
            builder
                .Property(course => course.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
            builder
                .HasOne(course => course.Semester)
                .WithMany(semester => semester.Courses)
                .HasForeignKey(course => course.SemesterId)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasOne(course => course.Teacher)
                .WithMany(teacher => teacher.Courses)
                .HasForeignKey(course => course.TeacherId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        private static void MandatoryCourseGradeConfigure(EntityTypeBuilder<MandatoryCourseGrade> builder)
        {
            builder
                .Property(courseGrade => courseGrade.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
            builder
                .HasOne(courseGrade => courseGrade.Course)
                .WithMany(course => course.Grades)
                .HasForeignKey(courseGrade => courseGrade.CourseId)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasOne(courseGrade => courseGrade.Student)
                .WithMany(student => student.Grades)
                .HasForeignKey(courseGrade => courseGrade.StudentId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        private static void OptionalCourseConfigure(EntityTypeBuilder<OptionalCourse> builder)
        {
            builder
                .Property(course => course.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
            builder
                .HasOne(course => course.Semester)
                .WithMany(semester => semester.OptionalCourses)
                .HasForeignKey(course => course.SemesterId)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasOne(course => course.Teacher)
                .WithMany(teacher => teacher.OptionalCourses)
                .HasForeignKey(course => course.TeacherId)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .Property(course => course.IsProposed)
                .HasDefaultValue(false);
            builder
                .Property(course => course.IsApproved)
                .HasDefaultValue(false);
        }

        private static void OptionalCourseGradeConfigure(EntityTypeBuilder<OptionalCourseGrade> builder)
        {
            builder
                .Property(courseGrade => courseGrade.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
            builder
                .HasOne(courseGrade => courseGrade.Course)
                .WithMany(course => course.Grades)
                .HasForeignKey(courseGrade => courseGrade.CourseId)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasOne(courseGrade => courseGrade.Student)
                .WithMany(student => student.OptionalGrades)
                .HasForeignKey(courseGrade => courseGrade.StudentId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        private static void OptionalCoursePreferenceConfigure(EntityTypeBuilder<OptionalCoursePreference> builder)
        {
            builder
                .Property(optionalCoursePreference => optionalCoursePreference.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
            builder
                .HasOne(optionalCoursePreference => optionalCoursePreference.StudentContractSemester)
                .WithMany(studyContract => studyContract.OptionalCoursePreferences)
                .HasForeignKey(optionalCoursePreference => optionalCoursePreference.StudentContractSemesterId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasOne(optionalCoursePreference => optionalCoursePreference.OptionalCourse)
                .WithMany(course => course.OptionalCoursePreferences)
                .HasForeignKey(optionalCoursePreference => optionalCoursePreference.OptionalCourseId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        private static void StudentContractConfigure(EntityTypeBuilder<StudentContract> builder)
        {
            builder
                .Property(studentContract => studentContract.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
            builder
                .HasOne(studentContract => studentContract.Student)
                .WithMany(student => student.Contracts)
                .HasForeignKey(studentContract => studentContract.StudentId)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasOne(studentContract => studentContract.StudyYear)
                .WithMany(year => year.Contracts)
                .HasForeignKey(studentContract => studentContract.StudyYearId)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasOne(studyContract => studyContract.Group)
                .WithMany(group => group.Contracts)
                .HasForeignKey(studyContract => studyContract.GroupId)
                .OnDelete(DeleteBehavior.SetNull);
        }

        private static void StudentContractSemesterConfigure(EntityTypeBuilder<StudentContractSemester> builder)
        {
            builder
                .Property(contractSemester => contractSemester.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
            builder
                .HasOne(studentContractSemester => studentContractSemester.StudySemester)
                .WithMany(studySemester => studySemester.SemesterContracts)
                .HasForeignKey(semester => semester.StudySemesterId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasOne(contractSemester => contractSemester.StudentContract)
                .WithMany(contract => contract.SemesterContracts)
                .HasForeignKey(contractSemester => contractSemester.StudentContractId)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasOne(contractSemester => contractSemester.OptionalCourse)
                .WithMany(optionalCourse => optionalCourse.Contracts)
                .HasForeignKey(contractSemester => contractSemester.OptionalCourseId)
                .OnDelete(DeleteBehavior.NoAction);
        }

        private static void StudentEnrolledCourseConfigure(EntityTypeBuilder<StudentMandatoryCourseEnrollment> builder)
        {
            builder
                .Property(semesterContractCourse => semesterContractCourse.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
            builder
                .HasOne(semesterContractCourse => semesterContractCourse.MandatoryCourse)
                .WithMany(mandatoryCourse => mandatoryCourse.SemesterContractCourses)
                .HasForeignKey(semesterContractCourse => semesterContractCourse.MandatoryCourseId)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasOne(semesterContractCourse => semesterContractCourse.StudentContractSemester)
                .WithMany(contractSemester => contractSemester.StudentEnrolledCourses)
                .HasForeignKey(semesterContractCourse => semesterContractCourse.StudentContractSemesterId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasOne(semesterContractCourse => semesterContractCourse.Group)
                .WithMany(group => group.StudentEnrolledCourses)
                .HasForeignKey(semesterContractCourse => semesterContractCourse.GroupId)
                .OnDelete(DeleteBehavior.SetNull);
        }

        private static void GroupConfigure(EntityTypeBuilder<FacultyGroup> builder)
        {
            builder
                .Property(group => group.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
            builder
                .HasOne(group => group.TutorTeacher)
                .WithOne(teacher => teacher.TutoredGroup)
                .HasForeignKey<FacultyGroup>(group => group.TutorTeacherId)
                .OnDelete(DeleteBehavior.SetNull);
            builder
                .HasOne(group => group.LeaderStudent)
                .WithOne()
                .HasForeignKey<FacultyGroup>(group => group.LeaderStudentId)
                .OnDelete(DeleteBehavior.SetNull);
            builder
                .HasOne(group => group.StudyYear)
                .WithMany(year => year.Groups)
                .HasForeignKey(group => group.StudyYearId)
                .OnDelete(DeleteBehavior.SetNull);
        }

        #endregion
    }
}

