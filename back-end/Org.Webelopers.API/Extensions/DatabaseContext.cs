using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using Org.Webelopers.Api.Models.DbEntities;

namespace Org.Webelopers.Api.Extensions
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TeacherDegree> TeacherDegrees { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<StudyDegree> StudyDegrees { get; set; }
        public virtual DbSet<Specialisation> Specialisations { get; set; }
        public virtual DbSet<StudyYear> StudyYears { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<StudySemester> StudySemesters { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseGrade> Grades { get; set; }
        public virtual DbSet<OptionalCourse> OptionalCourses { get; set; }
        public virtual DbSet<OptionalCourseGrade> OptionalGrades { get; set; }
        public virtual DbSet<StudentContract> StudyContracts { get; set; }
        public virtual DbSet<OptionalCoursePreference> OptionalCoursePreferences { get; set; }

        #region Configuration

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(AdminConfigure);
            modelBuilder.Entity<Student>(StudentConfigure);
            modelBuilder.Entity<Teacher>(TeacherConfigure);
            modelBuilder.Entity<TeacherDegree>(TeacherDegreeConfigure);
            modelBuilder.Entity<Faculty>(FacultyConfigure);
            modelBuilder.Entity<StudyDegree>(StudyDegreeConfigure);
            modelBuilder.Entity<Specialisation>(SpecialisationConfigure);
            modelBuilder.Entity<StudyYear>(StudyYearConfigure);
            modelBuilder.Entity<Group>(GroupConfigure);
            modelBuilder.Entity<StudySemester>(StudySemesterConfigure);
            modelBuilder.Entity<Course>(CourseConfigure);
            modelBuilder.Entity<CourseGrade>(CourseGradeConfigure);
            modelBuilder.Entity<OptionalCourse>(OptionalCourseConfigure);
            modelBuilder.Entity<OptionalCourseGrade>(OptionalCourseGradeConfigure);
            modelBuilder.Entity<StudentContract>(StudyContractConfigure);
            modelBuilder.Entity<OptionalCoursePreference>(OptionalCoursePreferenceConfigure);
            modelBuilder.Seed();
        }
        private static void AdminConfigure(EntityTypeBuilder<Admin> builder)
        {
            builder
                .Property(admin => admin.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
        }

        private static void StudentConfigure(EntityTypeBuilder<Student> builder)
        {
            builder
                .Property(student => student.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
        }

        private static void TeacherConfigure(EntityTypeBuilder<Teacher> builder)
        {
            builder
                .Property(teacher => teacher.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
            builder
                .HasOne(teacher => teacher.TeacherDegree)
                .WithMany()
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
            builder
                .HasOne(studyDegree => studyDegree.Faculty)
                .WithMany(faculty => faculty.StudyDegrees)
                .HasForeignKey(studyDegree => studyDegree.FacultyId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        private static void SpecialisationConfigure(EntityTypeBuilder<Specialisation> builder)
        {
            builder
                .Property(faculty => faculty.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
            builder
                .HasOne(specialisation => specialisation.StudyDegree)
                .WithMany(studyDegree => studyDegree.Specialisations)
                .HasForeignKey(specialisation => specialisation.StudyDegreeId)
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

        private static void GroupConfigure(EntityTypeBuilder<Group> builder)
        {
            builder
                .Property(group => group.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
            builder
                .Property(group => group.LeaderStudentId)
                .HasValueGenerator<SequentialGuidValueGenerator>();
            builder
                .HasOne(group => group.StudyYear)
                .WithMany(studyYear => studyYear.Groups)
                .HasForeignKey(group => group.StudyYearId)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasOne(group => group.LeaderStudent)
                .WithOne()
                .HasForeignKey<Group>(group => group.LeaderStudentId)
                .OnDelete(DeleteBehavior.SetNull);
            builder
                .HasOne(group => group.TutorTeacher)
                .WithOne()
                .HasForeignKey<Group>(group => group.TutorTeacherId)
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

        private static void StudyContractConfigure(EntityTypeBuilder<StudentContract> builder)
        {
            builder
                .Property(studyContract => studyContract.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
            builder
                .HasOne(studyContract => studyContract.Student)
                .WithMany(student => student.Contracts)
                .HasForeignKey(studyContract => studyContract.StudentId)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasOne(studyContract => studyContract.Group)
                .WithMany(group => group.Contracts)
                .HasForeignKey(studyContract => studyContract.GroupId)
                .OnDelete(DeleteBehavior.Cascade);
            builder
                .HasOne(studyContract => studyContract.OptionalCourse)
                .WithMany()
                .HasForeignKey(studyContract => studyContract.OptionalCourseId)
                .OnDelete(DeleteBehavior.SetNull);
        }

        private static void OptionalCoursePreferenceConfigure(EntityTypeBuilder<OptionalCoursePreference> builder)
        {
            builder
                .Property(optionalCoursePreference => optionalCoursePreference.Id)
                .HasValueGenerator<SequentialGuidValueGenerator>();
            builder
                .HasOne(optionalCoursePreference => optionalCoursePreference.StudyContract)
                .WithMany(studyContract => studyContract.OptionalPreferences)
                .HasForeignKey(optionalCoursePreference => optionalCoursePreference.StudyContractId)
                .OnDelete(DeleteBehavior.NoAction);
            builder
                .HasOne(optionalCoursePreference => optionalCoursePreference.OptionalCourse)
                .WithMany()
                .HasForeignKey(optionalCoursePreference => optionalCoursePreference.OptionalCourseId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        #endregion
    }
}

