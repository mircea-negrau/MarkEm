using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using Org.Webelopers.Api.Models.DbEntities;

namespace Org.Webelopers.Api.Extensions
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public virtual DbSet<AccountRole> Roles { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TeacherDegree> TeacherDegrees { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<StudyDegree> StudyDegrees { get; set; }
        public virtual DbSet<StudyLine> StudyLines { get; set; }
        public virtual DbSet<Specialisation> Specialisations { get; set; }
        public virtual DbSet<StudyYear> StudyYears { get; set; }
        public virtual DbSet<StudySemester> StudySemesters { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseGrade> Grades { get; set; }
        public virtual DbSet<OptionalCourse> OptionalCourses { get; set; }
        public virtual DbSet<OptionalCourseGrade> OptionalGrades { get; set; }
        public virtual DbSet<OptionalCoursePreference> OptionalCoursePreferences { get; set; }
        public virtual DbSet<StudentContract> Contracts { get; set; }
        public virtual DbSet<StudentContractSemester> SemesterContracts { get; set; }
        public virtual DbSet<SemesterContractCourse> SemesterContractCourses { get; set; }
        public virtual DbSet<Group> Groups { get; set; }

        #region Configuration

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountRole>(RoleConfigure);
            modelBuilder.Entity<Account>(AccountConfigure);
            modelBuilder.Entity<Admin>(AdminConfigure);
            modelBuilder.Entity<Student>(StudentConfigure);
            modelBuilder.Entity<Teacher>(TeacherConfigure);
            modelBuilder.Entity<TeacherDegree>(TeacherDegreeConfigure);
            modelBuilder.Entity<Faculty>(FacultyConfigure);
            modelBuilder.Entity<StudyDegree>(StudyDegreeConfigure);
            modelBuilder.Entity<StudyLine>(StudyLineConfigure);
            modelBuilder.Entity<Specialisation>(SpecialisationConfigure);
            modelBuilder.Entity<StudyYear>(StudyYearConfigure);
            modelBuilder.Entity<StudySemester>(StudySemesterConfigure);
            modelBuilder.Entity<Course>(CourseConfigure);
            modelBuilder.Entity<CourseGrade>(CourseGradeConfigure);
            modelBuilder.Entity<OptionalCourse>(OptionalCourseConfigure);
            modelBuilder.Entity<OptionalCourseGrade>(OptionalCourseGradeConfigure);
            modelBuilder.Entity<OptionalCoursePreference>(OptionalCoursePreferenceConfigure);
            modelBuilder.Entity<StudentContract>(StudentContractConfigure);
            modelBuilder.Entity<StudentContractSemester>(StudentContractSemesterConfigure);
            modelBuilder.Entity<SemesterContractCourse>(SemesterContractCourseConfigure);
            modelBuilder.Entity<Group>(GroupConfigure);
            modelBuilder.Seed();
        }

        private static void RoleConfigure(EntityTypeBuilder<AccountRole> builder)
        {
            builder
                .Property(role => role.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
        }

        private static void AccountConfigure(EntityTypeBuilder<Account> builder)
        {
            builder
                .Property(account => account.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
            builder
                .HasOne(account => account.Role)
                .WithMany(role => role.Accounts)
                .HasForeignKey(account => account.RoleId);
                // .OnDelete(DeleteBehavior.);
        }
        
        private static void AdminConfigure(EntityTypeBuilder<Admin> builder)
        {
            builder
                .HasOne(admin => admin.Account)
                .WithOne()
                .HasForeignKey<Admin>(admin => admin.AccountId);
                // .OnDelete(DeleteBehavior.);
        }

        private static void StudentConfigure(EntityTypeBuilder<Student> builder)
        {
            builder
                .HasOne(student => student.Account)
                .WithOne()
                .HasForeignKey<Student>(student => student.AccountId);
                // .OnDelete(DeleteBehavior.);
        }

        private static void TeacherConfigure(EntityTypeBuilder<Teacher> builder)
        {
            builder
                .HasOne(teacher => teacher.Account)
                .WithOne()
                .HasForeignKey<Teacher>(teacher => teacher.AccountId);
                // .OnDelete(DeleteBehavior.);
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

        private static void StudyDegreeConfigure(EntityTypeBuilder<StudyDegree> builder)
        {
            builder
                .Property(studyDegree => studyDegree.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
        }

        private static void StudyLineConfigure(EntityTypeBuilder<StudyLine> builder)
        {
            builder
                .Property(studyLine => studyLine.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
        }


        private static void SpecialisationConfigure(EntityTypeBuilder<Specialisation> builder)
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

        private static void StudyYearConfigure(EntityTypeBuilder<StudyYear> builder)
        {
            builder
                .Property(faculty => faculty.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
            builder
                .HasOne(studyYear => studyYear.Specialisation)
                .WithMany(specialisation => specialisation.StudyYears)
                .HasForeignKey(studyYear => studyYear.SpecialisationId)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasOne(studyYear => studyYear.StudentLeader)
                .WithOne()
                .HasForeignKey<StudyYear>(studyYear => studyYear.StudentLeaderUserId)
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

        private static void CourseConfigure(EntityTypeBuilder<Course> builder)
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

        private static void CourseGradeConfigure(EntityTypeBuilder<CourseGrade> builder)
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
                .OnDelete(DeleteBehavior.Cascade);
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
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasOne(contractSemester => contractSemester.StudentContract)
                .WithMany(contract => contract.SemesterContracts)
                .HasForeignKey(contractSemester => contractSemester.StudentContractId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        private static void SemesterContractCourseConfigure(EntityTypeBuilder<SemesterContractCourse> builder)
        {
            builder
                .Property(semesterContractCourse => semesterContractCourse.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
            builder
                .HasOne(semesterContractCourse => semesterContractCourse.Course)
                .WithMany(course => course.SemesterContractCourses)
                .HasForeignKey(semesterContractCourse => semesterContractCourse.CourseId)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasOne(semesterContractCourse => semesterContractCourse.StudentContractSemester)
                .WithMany(contractSemester => contractSemester.SemesterContractCourses)
                .HasForeignKey(semesterContractCourse => semesterContractCourse.StudentContractSemesterId)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasOne(semesterContractCourse => semesterContractCourse.Group)
                .WithMany(group => group.SemesterContractCourses)
                .HasForeignKey(semesterContractCourse => semesterContractCourse.CourseId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        private static void GroupConfigure(EntityTypeBuilder<Group> builder)
        {
            builder
                .Property(group => group.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
            builder // TODO: is this required?
                .Property(group => group.LeaderStudentId)
                .HasValueGenerator<SequentialGuidValueGenerator>();
            builder
                .HasOne(group => group.TutorTeacher)
                .WithOne()
                .HasForeignKey<Group>(group => group.TutorTeacherId)
                .OnDelete(DeleteBehavior.SetNull);
            builder
                .HasOne(group => group.LeaderStudent)
                .WithOne()
                .HasForeignKey<Group>(group => group.LeaderStudentId)
                .OnDelete(DeleteBehavior.SetNull);
        }

        #endregion
    }
}

