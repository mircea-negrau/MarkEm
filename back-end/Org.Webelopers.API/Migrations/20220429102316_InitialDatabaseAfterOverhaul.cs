using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Org.Webelopers.Api.Migrations
{
    public partial class InitialDatabaseAfterOverhaul : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    EmailHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Picture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    About = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudyDegrees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyDegrees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudyLines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyLines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeacherDegrees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherDegrees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_Admins_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_Students_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeacherDegreeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_Teachers_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Teachers_TeacherDegrees_TeacherDegreeId",
                        column: x => x.TeacherDegreeId,
                        principalTable: "TeacherDegrees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ChiefOfDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Faculties_Teachers_ChiefOfDepartmentId",
                        column: x => x.ChiefOfDepartmentId,
                        principalTable: "Teachers",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<long>(type: "bigint", nullable: false),
                    TutorTeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LeaderStudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Students_LeaderStudentId",
                        column: x => x.LeaderStudentId,
                        principalTable: "Students",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Groups_Teachers_TutorTeacherId",
                        column: x => x.TutorTeacherId,
                        principalTable: "Teachers",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Specialisations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Semesters = table.Column<short>(type: "smallint", nullable: false),
                    FacultyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudyDegreeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudyLineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialisations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specialisations_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Specialisations_StudyDegrees_StudyDegreeId",
                        column: x => x.StudyDegreeId,
                        principalTable: "StudyDegrees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Specialisations_StudyLines_StudyLineId",
                        column: x => x.StudyLineId,
                        principalTable: "StudyLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudyYears",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<long>(type: "bigint", nullable: false),
                    EndDate = table.Column<long>(type: "bigint", nullable: false),
                    SpecializationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentLeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyYears", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudyYears_Specialisations_SpecializationId",
                        column: x => x.SpecializationId,
                        principalTable: "Specialisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudyYears_Students_StudentLeaderId",
                        column: x => x.StudentLeaderId,
                        principalTable: "Students",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SignedAt = table.Column<long>(type: "bigint", nullable: true),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudyYearId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contracts_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Contracts_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contracts_StudyYears_StudyYearId",
                        column: x => x.StudyYearId,
                        principalTable: "StudyYears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudySemesters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Semester = table.Column<short>(type: "smallint", nullable: false),
                    StudyYearId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudySemesters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudySemesters_StudyYears_StudyYearId",
                        column: x => x.StudyYearId,
                        principalTable: "StudyYears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Credits = table.Column<short>(type: "smallint", nullable: false),
                    SemesterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_StudySemesters_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "StudySemesters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OptionalCourses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsProposed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    MaxNumberOfStudent = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Credits = table.Column<short>(type: "smallint", nullable: false),
                    SemesterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionalCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OptionalCourses_StudySemesters_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "StudySemesters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OptionalCourses_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Grade = table.Column<short>(type: "smallint", nullable: false),
                    CreatedAt = table.Column<long>(type: "bigint", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grades_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Grades_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OptionalGrades",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Grade = table.Column<short>(type: "smallint", nullable: false),
                    CreatedAt = table.Column<long>(type: "bigint", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionalGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OptionalGrades_OptionalCourses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "OptionalCourses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OptionalGrades_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SemesterContracts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentContractId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudySemesterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OptionalCourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SemesterContracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SemesterContracts_Contracts_StudentContractId",
                        column: x => x.StudentContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SemesterContracts_OptionalCourses_OptionalCourseId",
                        column: x => x.OptionalCourseId,
                        principalTable: "OptionalCourses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SemesterContracts_StudySemesters_StudySemesterId",
                        column: x => x.StudySemesterId,
                        principalTable: "StudySemesters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OptionalCoursePreferences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Preference = table.Column<short>(type: "smallint", nullable: false),
                    StudentContractSemesterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OptionalCourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionalCoursePreferences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OptionalCoursePreferences_OptionalCourses_OptionalCourseId",
                        column: x => x.OptionalCourseId,
                        principalTable: "OptionalCourses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OptionalCoursePreferences_SemesterContracts_StudentContractSemesterId",
                        column: x => x.StudentContractSemesterId,
                        principalTable: "SemesterContracts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StudentEnrolledCourse",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentContractSemesterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MandatoryCourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentEnrolledCourse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentEnrolledCourse_Courses_MandatoryCourseId",
                        column: x => x.MandatoryCourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentEnrolledCourse_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_StudentEnrolledCourse_SemesterContracts_StudentContractSemesterId",
                        column: x => x.StudentContractSemesterId,
                        principalTable: "SemesterContracts",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "About", "EmailHash", "FirstName", "LastName", "PasswordHash", "Picture", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357"), "", "dummyEmailHash", "firstName0", "firstName0", "dummyPasswordHash", null, "Teacher", "TestAccount0" },
                    { new Guid("70d4e53a-53a2-4923-b89c-fff5257f8a3f"), "", "dummyEmailHash", "firstName73", "firstName73", "dummyPasswordHash", null, "Student", "TestAccount73" },
                    { new Guid("bbee4cf1-ad13-4c7a-a371-9818a8247118"), "", "dummyEmailHash", "firstName71", "firstName71", "dummyPasswordHash", null, "Student", "TestAccount71" },
                    { new Guid("41f342f3-6a25-40c0-b53b-135de297566b"), "", "dummyEmailHash", "firstName70", "firstName70", "dummyPasswordHash", null, "Student", "TestAccount70" },
                    { new Guid("648691b9-8bde-47b7-87b2-09ced338434f"), "", "dummyEmailHash", "firstName69", "firstName69", "dummyPasswordHash", null, "Student", "TestAccount69" },
                    { new Guid("4bed0bcc-b521-4d3a-9830-2818c7802f64"), "", "dummyEmailHash", "firstName68", "firstName68", "dummyPasswordHash", null, "Student", "TestAccount68" },
                    { new Guid("ff4b105e-12ff-4534-be50-6235f5db6ed5"), "", "dummyEmailHash", "firstName67", "firstName67", "dummyPasswordHash", null, "Student", "TestAccount67" },
                    { new Guid("a7eec97f-7557-43cb-a304-a4be66956324"), "", "dummyEmailHash", "firstName66", "firstName66", "dummyPasswordHash", null, "Student", "TestAccount66" },
                    { new Guid("38c05713-2be5-44fe-8289-126d0ec5b370"), "", "dummyEmailHash", "firstName65", "firstName65", "dummyPasswordHash", null, "Student", "TestAccount65" },
                    { new Guid("77bd5000-522a-4df5-8e34-b3b01a8e8606"), "", "dummyEmailHash", "firstName64", "firstName64", "dummyPasswordHash", null, "Student", "TestAccount64" },
                    { new Guid("03e1701e-7a16-4181-a90e-eefdf54791d1"), "", "dummyEmailHash", "firstName63", "firstName63", "dummyPasswordHash", null, "Student", "TestAccount63" },
                    { new Guid("7b772708-355b-4a84-8bac-b59464644496"), "", "dummyEmailHash", "firstName62", "firstName62", "dummyPasswordHash", null, "Student", "TestAccount62" },
                    { new Guid("9ab7410e-9a8b-45da-8e21-4560d3f8d7b9"), "", "dummyEmailHash", "firstName61", "firstName61", "dummyPasswordHash", null, "Student", "TestAccount61" },
                    { new Guid("69258905-df3c-4dd6-8ecd-7b8f22cec975"), "", "dummyEmailHash", "firstName60", "firstName60", "dummyPasswordHash", null, "Student", "TestAccount60" },
                    { new Guid("b069af86-5dab-4ac0-bf4d-bdfbc27394d4"), "", "dummyEmailHash", "firstName59", "firstName59", "dummyPasswordHash", null, "Student", "TestAccount59" },
                    { new Guid("82394424-d858-4fdd-b7d2-82450c5c99a7"), "", "dummyEmailHash", "firstName58", "firstName58", "dummyPasswordHash", null, "Student", "TestAccount58" },
                    { new Guid("bf8ed046-fe91-4946-993c-98ca2f62543f"), "", "dummyEmailHash", "firstName57", "firstName57", "dummyPasswordHash", null, "Student", "TestAccount57" },
                    { new Guid("abebc8c4-9a10-4cb4-aea0-f14b77e7c4a2"), "", "dummyEmailHash", "firstName56", "firstName56", "dummyPasswordHash", null, "Student", "TestAccount56" },
                    { new Guid("3d4e3033-6bcc-4c2b-bf11-4cda82a9f716"), "", "dummyEmailHash", "firstName55", "firstName55", "dummyPasswordHash", null, "Student", "TestAccount55" },
                    { new Guid("86108a96-dd24-445b-b8cf-40855961fa35"), "", "dummyEmailHash", "firstName54", "firstName54", "dummyPasswordHash", null, "Student", "TestAccount54" },
                    { new Guid("2dd36ed5-09bf-4031-872e-8ec8bba5d45d"), "", "dummyEmailHash", "firstName53", "firstName53", "dummyPasswordHash", null, "Student", "TestAccount53" },
                    { new Guid("60eed688-3b4a-4ae3-b5de-919a042824cb"), "", "dummyEmailHash", "firstName52", "firstName52", "dummyPasswordHash", null, "Student", "TestAccount52" },
                    { new Guid("e4689a19-6bb7-4269-9ba5-dbc69638ab0e"), "", "dummyEmailHash", "firstName74", "firstName74", "dummyPasswordHash", null, "Student", "TestAccount74" },
                    { new Guid("1f90fa33-df8f-4004-86fa-8e0276622cbd"), "", "dummyEmailHash", "firstName75", "firstName75", "dummyPasswordHash", null, "Student", "TestAccount75" },
                    { new Guid("c131bfdd-28d3-4715-9c3c-4c508ec49e58"), "", "dummyEmailHash", "firstName76", "firstName76", "dummyPasswordHash", null, "Student", "TestAccount76" },
                    { new Guid("0d0133c1-35d5-4411-ac6f-ca4c0c719563"), "", "dummyEmailHash", "firstName77", "firstName77", "dummyPasswordHash", null, "Student", "TestAccount77" },
                    { new Guid("6ea3531d-d4ce-4c61-9c39-7846e05a0c8e"), "", "dummyEmailHash", "firstName99", "firstName99", "dummyPasswordHash", null, "Student", "TestAccount99" },
                    { new Guid("191a9fe9-c700-48e0-aae2-9b77131a8a60"), "", "dummyEmailHash", "firstName98", "firstName98", "dummyPasswordHash", null, "Student", "TestAccount98" },
                    { new Guid("63195d9e-0811-490b-86f6-17855b2c7417"), "", "dummyEmailHash", "firstName97", "firstName97", "dummyPasswordHash", null, "Student", "TestAccount97" },
                    { new Guid("5c45cd1a-7bc1-45f0-bbab-7765cb441306"), "", "dummyEmailHash", "firstName96", "firstName96", "dummyPasswordHash", null, "Student", "TestAccount96" },
                    { new Guid("c0b0de66-2624-40a0-b347-32dc01bfb4b7"), "", "dummyEmailHash", "firstName95", "firstName95", "dummyPasswordHash", null, "Student", "TestAccount95" },
                    { new Guid("04e7fc75-cb2f-463d-ad54-ea76f951d701"), "", "dummyEmailHash", "firstName94", "firstName94", "dummyPasswordHash", null, "Student", "TestAccount94" },
                    { new Guid("9b537235-1905-4a5c-bcfd-e703fbe8e7b2"), "", "dummyEmailHash", "firstName93", "firstName93", "dummyPasswordHash", null, "Student", "TestAccount93" },
                    { new Guid("04d9ede2-1148-4d2b-9dfd-8fb9b05be3c6"), "", "dummyEmailHash", "firstName92", "firstName92", "dummyPasswordHash", null, "Student", "TestAccount92" },
                    { new Guid("7fa25911-52d6-411d-98a4-a6d55ca5957f"), "", "dummyEmailHash", "firstName91", "firstName91", "dummyPasswordHash", null, "Student", "TestAccount91" },
                    { new Guid("9a89021d-a8c6-4d3b-b149-8e52dfcffd26"), "", "dummyEmailHash", "firstName90", "firstName90", "dummyPasswordHash", null, "Student", "TestAccount90" },
                    { new Guid("f4d4c7dc-7bc5-41e1-b492-c585e06b02db"), "", "dummyEmailHash", "firstName51", "firstName51", "dummyPasswordHash", null, "Student", "TestAccount51" },
                    { new Guid("2d6fe9ec-7534-4c01-9864-9bdfc0bf002f"), "", "dummyEmailHash", "firstName89", "firstName89", "dummyPasswordHash", null, "Student", "TestAccount89" },
                    { new Guid("3971344d-2bc9-4742-95a4-ab1fa245381c"), "", "dummyEmailHash", "firstName87", "firstName87", "dummyPasswordHash", null, "Student", "TestAccount87" },
                    { new Guid("d3b1b476-c90b-49b1-9333-ac558a7ac26f"), "", "dummyEmailHash", "firstName86", "firstName86", "dummyPasswordHash", null, "Student", "TestAccount86" },
                    { new Guid("86f7bd2c-cb6b-40bc-9585-d548f996b2e4"), "", "dummyEmailHash", "firstName85", "firstName85", "dummyPasswordHash", null, "Student", "TestAccount85" },
                    { new Guid("5266b7b5-e0dc-4779-b909-b407ea636b5c"), "", "dummyEmailHash", "firstName84", "firstName84", "dummyPasswordHash", null, "Student", "TestAccount84" }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "About", "EmailHash", "FirstName", "LastName", "PasswordHash", "Picture", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("b43a76ce-57d1-4dbc-ab5b-59841836da67"), "", "dummyEmailHash", "firstName83", "firstName83", "dummyPasswordHash", null, "Student", "TestAccount83" },
                    { new Guid("dccde5a9-b87f-4465-87d1-dc2a95427e5e"), "", "dummyEmailHash", "firstName82", "firstName82", "dummyPasswordHash", null, "Student", "TestAccount82" },
                    { new Guid("ab1eed90-ade2-4983-8a37-48884fe2726d"), "", "dummyEmailHash", "firstName81", "firstName81", "dummyPasswordHash", null, "Student", "TestAccount81" },
                    { new Guid("1a6a5b85-fc8c-4d35-8b8c-a5e0a04c7bbb"), "", "dummyEmailHash", "firstName80", "firstName80", "dummyPasswordHash", null, "Student", "TestAccount80" },
                    { new Guid("65ceac3b-d4bb-4516-9247-8a03d9e33b7c"), "", "dummyEmailHash", "firstName79", "firstName79", "dummyPasswordHash", null, "Student", "TestAccount79" },
                    { new Guid("a24a853a-b0af-4d05-be95-2514f4a9647a"), "", "dummyEmailHash", "firstName78", "firstName78", "dummyPasswordHash", null, "Student", "TestAccount78" },
                    { new Guid("d219d7fc-db65-4df3-8144-0dab0e4d0658"), "", "dummyEmailHash", "firstName88", "firstName88", "dummyPasswordHash", null, "Student", "TestAccount88" },
                    { new Guid("cd252b2c-4295-4b04-91ac-cd73ad319ff1"), "", "dummyEmailHash", "firstName50", "firstName50", "dummyPasswordHash", null, "Student", "TestAccount50" },
                    { new Guid("edd63be1-dfe6-480a-8c38-f42ea138c398"), "", "dummyEmailHash", "firstName72", "firstName72", "dummyPasswordHash", null, "Student", "TestAccount72" },
                    { new Guid("89d379dc-dc16-4ae3-bcd7-129a3e305a51"), "", "dummyEmailHash", "firstName48", "firstName48", "dummyPasswordHash", null, "Student", "TestAccount48" },
                    { new Guid("d8ff455c-8990-4c05-8a7c-ae97c33986e6"), "", "dummyEmailHash", "firstName22", "firstName22", "dummyPasswordHash", null, "Admin", "TestAccount22" },
                    { new Guid("07cfd812-047f-498d-916d-7e847b84140f"), "", "dummyEmailHash", "firstName21", "firstName21", "dummyPasswordHash", null, "Admin", "TestAccount21" },
                    { new Guid("e50fc422-3f2a-4918-94a8-7a7569bfe432"), "", "dummyEmailHash", "firstName20", "firstName20", "dummyPasswordHash", null, "Admin", "TestAccount20" },
                    { new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f"), "", "dummyEmailHash", "firstName19", "firstName19", "dummyPasswordHash", null, "Teacher", "TestAccount19" },
                    { new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8"), "", "dummyEmailHash", "firstName18", "firstName18", "dummyPasswordHash", null, "Teacher", "TestAccount18" },
                    { new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e"), "", "dummyEmailHash", "firstName17", "firstName17", "dummyPasswordHash", null, "Teacher", "TestAccount17" },
                    { new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b"), "", "dummyEmailHash", "firstName16", "firstName16", "dummyPasswordHash", null, "Teacher", "TestAccount16" },
                    { new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456"), "", "dummyEmailHash", "firstName15", "firstName15", "dummyPasswordHash", null, "Teacher", "TestAccount15" },
                    { new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5"), "", "dummyEmailHash", "firstName14", "firstName14", "dummyPasswordHash", null, "Teacher", "TestAccount14" },
                    { new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337"), "", "dummyEmailHash", "firstName13", "firstName13", "dummyPasswordHash", null, "Teacher", "TestAccount13" },
                    { new Guid("ff1ed850-71d1-4df2-8ae3-de057d4c2a4e"), "", "dummyEmailHash", "firstName23", "firstName23", "dummyPasswordHash", null, "Admin", "TestAccount23" },
                    { new Guid("40772272-1210-4378-98bd-e829841f6b0c"), "", "dummyEmailHash", "firstName12", "firstName12", "dummyPasswordHash", null, "Teacher", "TestAccount12" },
                    { new Guid("25ebd382-4646-40d7-8d67-a40c2779511d"), "", "dummyEmailHash", "firstName10", "firstName10", "dummyPasswordHash", null, "Teacher", "TestAccount10" },
                    { new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6"), "", "dummyEmailHash", "firstName9", "firstName9", "dummyPasswordHash", null, "Teacher", "TestAccount9" },
                    { new Guid("1212bca1-8f68-45e4-8a91-572adec7b855"), "", "dummyEmailHash", "firstName8", "firstName8", "dummyPasswordHash", null, "Teacher", "TestAccount8" },
                    { new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f"), "", "dummyEmailHash", "firstName7", "firstName7", "dummyPasswordHash", null, "Teacher", "TestAccount7" },
                    { new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295"), "", "dummyEmailHash", "firstName6", "firstName6", "dummyPasswordHash", null, "Teacher", "TestAccount6" },
                    { new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52"), "", "dummyEmailHash", "firstName5", "firstName5", "dummyPasswordHash", null, "Teacher", "TestAccount5" },
                    { new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf"), "", "dummyEmailHash", "firstName4", "firstName4", "dummyPasswordHash", null, "Teacher", "TestAccount4" },
                    { new Guid("f052ae94-ba5a-4197-b978-520328996d6a"), "", "dummyEmailHash", "firstName3", "firstName3", "dummyPasswordHash", null, "Teacher", "TestAccount3" },
                    { new Guid("ed791c14-e08e-4ec9-b17c-7f918f8a09c3"), "", "dummyEmailHash", "firstName49", "firstName49", "dummyPasswordHash", null, "Student", "TestAccount49" },
                    { new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458"), "", "dummyEmailHash", "firstName1", "firstName1", "dummyPasswordHash", null, "Teacher", "TestAccount1" },
                    { new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747"), "", "dummyEmailHash", "firstName11", "firstName11", "dummyPasswordHash", null, "Teacher", "TestAccount11" },
                    { new Guid("b20c3b04-858e-4736-9d93-9cc1ea525bc5"), "", "dummyEmailHash", "firstName24", "firstName24", "dummyPasswordHash", null, "Admin", "TestAccount24" },
                    { new Guid("22bce128-1398-4d69-82c1-227bbd4a2439"), "", "dummyEmailHash", "firstName2", "firstName2", "dummyPasswordHash", null, "Teacher", "TestAccount2" },
                    { new Guid("f76af4bb-a841-486d-bb9b-9cde1e835c02"), "", "dummyEmailHash", "firstName26", "firstName26", "dummyPasswordHash", null, "Admin", "TestAccount26" },
                    { new Guid("443f8bee-6105-4ab4-b4ca-ba7142209445"), "", "dummyEmailHash", "firstName25", "firstName25", "dummyPasswordHash", null, "Admin", "TestAccount25" },
                    { new Guid("8a5fc843-fbce-407a-b886-2b52427c7588"), "", "dummyEmailHash", "firstName47", "firstName47", "dummyPasswordHash", null, "Student", "TestAccount47" },
                    { new Guid("22d03711-eb9b-479f-8543-fcc39be24b3a"), "", "dummyEmailHash", "firstName46", "firstName46", "dummyPasswordHash", null, "Student", "TestAccount46" },
                    { new Guid("22b99d65-238e-4414-9830-b8d56edda8d3"), "", "dummyEmailHash", "firstName44", "firstName44", "dummyPasswordHash", null, "Student", "TestAccount44" },
                    { new Guid("c3024a6b-c61c-4437-8c9a-dc0546b37765"), "", "dummyEmailHash", "firstName43", "firstName43", "dummyPasswordHash", null, "Student", "TestAccount43" },
                    { new Guid("e768134a-118a-4555-bb9d-060a2b041a85"), "", "dummyEmailHash", "firstName42", "firstName42", "dummyPasswordHash", null, "Student", "TestAccount42" }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "About", "EmailHash", "FirstName", "LastName", "PasswordHash", "Picture", "Role", "Username" },
                values: new object[,]
                {
                    { new Guid("ab81330e-4203-4bce-9a79-2a9e95808418"), "", "dummyEmailHash", "firstName41", "firstName41", "dummyPasswordHash", null, "Student", "TestAccount41" },
                    { new Guid("fc47b96d-6b02-4242-9ec2-e78e9b76db8e"), "", "dummyEmailHash", "firstName40", "firstName40", "dummyPasswordHash", null, "Student", "TestAccount40" },
                    { new Guid("db0e4da8-0a95-409a-9e9e-2b11e4c30260"), "", "dummyEmailHash", "firstName39", "firstName39", "dummyPasswordHash", null, "Student", "TestAccount39" },
                    { new Guid("f5355ac7-e343-40e0-8fb7-8bfb867224d6"), "", "dummyEmailHash", "firstName38", "firstName38", "dummyPasswordHash", null, "Student", "TestAccount38" },
                    { new Guid("de49dd29-30ae-4f77-9172-f892860e2b88"), "", "dummyEmailHash", "firstName37", "firstName37", "dummyPasswordHash", null, "Student", "TestAccount37" },
                    { new Guid("d03ec302-9032-4220-ad51-2da905881098"), "", "dummyEmailHash", "firstName45", "firstName45", "dummyPasswordHash", null, "Student", "TestAccount45" },
                    { new Guid("f90db5bd-a8ca-4efe-8d5c-5873fc25fdc7"), "", "dummyEmailHash", "firstName35", "firstName35", "dummyPasswordHash", null, "Student", "TestAccount35" },
                    { new Guid("2d19797d-7788-496a-bf7e-b26dff677bd5"), "", "dummyEmailHash", "firstName36", "firstName36", "dummyPasswordHash", null, "Student", "TestAccount36" },
                    { new Guid("7f543d5a-4856-4f8f-8d44-8e5182d19625"), "", "dummyEmailHash", "firstName27", "firstName27", "dummyPasswordHash", null, "Admin", "TestAccount27" },
                    { new Guid("f2e10499-e612-44d1-acfc-e167f7ae30b7"), "", "dummyEmailHash", "firstName29", "firstName29", "dummyPasswordHash", null, "Admin", "TestAccount29" },
                    { new Guid("fa5d9497-b645-4442-9789-62bccbe06d34"), "", "dummyEmailHash", "firstName30", "firstName30", "dummyPasswordHash", null, "Student", "TestAccount30" },
                    { new Guid("62eb309e-16d0-4e26-92a5-5a7d9ef2cc6e"), "", "dummyEmailHash", "firstName28", "firstName28", "dummyPasswordHash", null, "Admin", "TestAccount28" },
                    { new Guid("4094df26-53da-4e51-aa69-28406bf0e198"), "", "dummyEmailHash", "firstName32", "firstName32", "dummyPasswordHash", null, "Student", "TestAccount32" },
                    { new Guid("14e41443-fb3b-4aa0-88c2-75a89f22faf4"), "", "dummyEmailHash", "firstName33", "firstName33", "dummyPasswordHash", null, "Student", "TestAccount33" },
                    { new Guid("3b82aac6-8bd4-407f-9022-8eb2f5f150aa"), "", "dummyEmailHash", "firstName34", "firstName34", "dummyPasswordHash", null, "Student", "TestAccount34" },
                    { new Guid("fa66fe10-74b4-4b87-9410-d68ed52c2258"), "", "dummyEmailHash", "firstName31", "firstName31", "dummyPasswordHash", null, "Student", "TestAccount31" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "LeaderStudentId", "Number", "TutorTeacherId" },
                values: new object[,]
                {
                    { new Guid("f9b9b9d2-45cf-4aeb-9e41-9777c150c0a3"), null, 0L, null },
                    { new Guid("047d5f61-314b-4ce8-b631-64a3a12fb239"), null, 0L, null },
                    { new Guid("c9edf964-f23e-4af9-9182-d91895212bb0"), null, 0L, null },
                    { new Guid("e319e079-aa3a-499a-b7e8-cf6eae5e86cf"), null, 0L, null },
                    { new Guid("3bcebc11-cf9c-45a8-9284-7dea6502f3e3"), null, 0L, null },
                    { new Guid("ba0f286c-3a4e-4068-b18f-72d7a6a628fc"), null, 0L, null },
                    { new Guid("80319172-f1ea-4749-9d24-34867e1f9a37"), null, 0L, null },
                    { new Guid("48cfc7d0-01c2-4610-9f10-ac05c5b27a55"), null, 0L, null },
                    { new Guid("20f78dff-abc9-4f25-8f98-7df665ca8cd5"), null, 0L, null },
                    { new Guid("408d2ca0-ef00-40ab-8ca5-4713ca59bacc"), null, 0L, null },
                    { new Guid("29f7414c-afb7-455e-bf4b-6fd5af67ece8"), null, 0L, null },
                    { new Guid("17e755b1-67d3-456b-ab08-9bace8bf1499"), null, 0L, null },
                    { new Guid("f717afa8-85fb-45ca-92ba-3b830a2d90cf"), null, 0L, null },
                    { new Guid("9702f4a0-fe9b-4aae-a9c8-76b84e89559d"), null, 0L, null },
                    { new Guid("a01bb2b0-884a-4a83-af22-ca3a98dcdb3b"), null, 0L, null },
                    { new Guid("70b92c51-d74e-421c-84ad-0490736bcac6"), null, 0L, null },
                    { new Guid("9864d11a-27f4-4ec1-b99e-6b7fcb660ea0"), null, 0L, null },
                    { new Guid("778eb6cf-a35a-40de-9bf0-09a9a8643176"), null, 0L, null },
                    { new Guid("2e135cc3-a5f4-4c8c-bcfe-2a31a04238a2"), null, 0L, null },
                    { new Guid("0e3945a9-3a01-4fd8-86cf-c4c223ebca79"), null, 0L, null },
                    { new Guid("62744cc4-e1e5-4b3c-a821-89753d301d1c"), null, 0L, null },
                    { new Guid("01d1a913-d237-47b3-8265-eba1c3e5248c"), null, 0L, null },
                    { new Guid("be1fb0b0-b64b-4962-be0f-b2688db42d35"), null, 0L, null },
                    { new Guid("445f55df-b8e2-4a91-90e5-dc1fca86f427"), null, 0L, null },
                    { new Guid("43a6db13-bc2b-4080-9897-92c9a481963b"), null, 0L, null },
                    { new Guid("5cc7cdfb-3145-4c5e-8b90-bf813bd18b14"), null, 0L, null }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "LeaderStudentId", "Number", "TutorTeacherId" },
                values: new object[,]
                {
                    { new Guid("2f5c0a1c-9149-4d44-ab30-f089b7320b00"), null, 0L, null },
                    { new Guid("15a718db-1d58-4f2e-85c9-b72513b58c19"), null, 0L, null },
                    { new Guid("1c78cca3-1758-4db3-95b1-8a608a0ec5a0"), null, 0L, null },
                    { new Guid("85630ba6-dd96-4d6f-9cf7-71dfc75a7831"), null, 0L, null },
                    { new Guid("25fecc55-5fdb-462e-80df-52ee2c11e707"), null, 0L, null },
                    { new Guid("fbef0fc7-eec0-4359-bb33-a1481d1598dc"), null, 0L, null },
                    { new Guid("3557ddb8-7418-4693-bf5c-f00552f9eca3"), null, 0L, null },
                    { new Guid("d7d5ee41-0749-47e6-888b-b7745d13fc33"), null, 0L, null },
                    { new Guid("e18e5e04-3fa9-4d5f-a0ff-b46d721a5603"), null, 0L, null },
                    { new Guid("68e37478-569a-43f3-8eaa-d34b499ae01e"), null, 0L, null }
                });

            migrationBuilder.InsertData(
                table: "StudyDegrees",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4f9683c5-bd7a-4bfe-8c77-a85fbfa0927e"), "Bachelor" },
                    { new Guid("411098c2-2c1c-4912-987a-1cb49f828156"), "Master" }
                });

            migrationBuilder.InsertData(
                table: "StudyLines",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[,]
                {
                    { new Guid("d0d34ecc-8702-4cca-9e83-22a5b9516cf8"), "English", "EN" },
                    { new Guid("84409672-4042-4ea4-b3d4-4087195b0285"), "Romanian", "RO" },
                    { new Guid("4decf4a7-a414-4896-ad31-c4091dc4e3c2"), "German", "DE" }
                });

            migrationBuilder.InsertData(
                table: "TeacherDegrees",
                columns: new[] { "Id", "Name", "Rank" },
                values: new object[,]
                {
                    { new Guid("49aa5ee9-482a-415e-be2b-b037e114f394"), "TeacherDegree0", 0 },
                    { new Guid("6e1d2723-921a-46ba-b865-a1216005ee14"), "TeacherDegree1", 0 },
                    { new Guid("74f8a42e-bbd1-4b03-bd78-329da0290ecf"), "TeacherDegree2", 0 },
                    { new Guid("d819a0ca-3be4-449c-a23e-310e6f871598"), "TeacherDegree3", 0 },
                    { new Guid("edaece06-4188-4df1-aac2-978f30777f6b"), "TeacherDegree4", 0 }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                column: "AccountId",
                values: new object[]
                {
                    new Guid("e50fc422-3f2a-4918-94a8-7a7569bfe432"),
                    new Guid("f2e10499-e612-44d1-acfc-e167f7ae30b7"),
                    new Guid("7f543d5a-4856-4f8f-8d44-8e5182d19625"),
                    new Guid("f76af4bb-a841-486d-bb9b-9cde1e835c02"),
                    new Guid("443f8bee-6105-4ab4-b4ca-ba7142209445"),
                    new Guid("62eb309e-16d0-4e26-92a5-5a7d9ef2cc6e"),
                    new Guid("ff1ed850-71d1-4df2-8ae3-de057d4c2a4e"),
                    new Guid("d8ff455c-8990-4c05-8a7c-ae97c33986e6"),
                    new Guid("07cfd812-047f-498d-916d-7e847b84140f"),
                    new Guid("b20c3b04-858e-4736-9d93-9cc1ea525bc5")
                });

            migrationBuilder.InsertData(
                table: "Students",
                column: "AccountId",
                values: new object[]
                {
                    new Guid("c131bfdd-28d3-4715-9c3c-4c508ec49e58"),
                    new Guid("ab1eed90-ade2-4983-8a37-48884fe2726d"),
                    new Guid("1a6a5b85-fc8c-4d35-8b8c-a5e0a04c7bbb"),
                    new Guid("65ceac3b-d4bb-4516-9247-8a03d9e33b7c"),
                    new Guid("a24a853a-b0af-4d05-be95-2514f4a9647a"),
                    new Guid("0d0133c1-35d5-4411-ac6f-ca4c0c719563"),
                    new Guid("1f90fa33-df8f-4004-86fa-8e0276622cbd"),
                    new Guid("41f342f3-6a25-40c0-b53b-135de297566b"),
                    new Guid("70d4e53a-53a2-4923-b89c-fff5257f8a3f"),
                    new Guid("edd63be1-dfe6-480a-8c38-f42ea138c398"),
                    new Guid("bbee4cf1-ad13-4c7a-a371-9818a8247118"),
                    new Guid("dccde5a9-b87f-4465-87d1-dc2a95427e5e"),
                    new Guid("4bed0bcc-b521-4d3a-9830-2818c7802f64"),
                    new Guid("ff4b105e-12ff-4534-be50-6235f5db6ed5"),
                    new Guid("e4689a19-6bb7-4269-9ba5-dbc69638ab0e"),
                    new Guid("b43a76ce-57d1-4dbc-ab5b-59841836da67"),
                    new Guid("d219d7fc-db65-4df3-8144-0dab0e4d0658"),
                    new Guid("86f7bd2c-cb6b-40bc-9585-d548f996b2e4"),
                    new Guid("6ea3531d-d4ce-4c61-9c39-7846e05a0c8e"),
                    new Guid("191a9fe9-c700-48e0-aae2-9b77131a8a60"),
                    new Guid("63195d9e-0811-490b-86f6-17855b2c7417"),
                    new Guid("5c45cd1a-7bc1-45f0-bbab-7765cb441306"),
                    new Guid("c0b0de66-2624-40a0-b347-32dc01bfb4b7"),
                    new Guid("04e7fc75-cb2f-463d-ad54-ea76f951d701"),
                    new Guid("5266b7b5-e0dc-4779-b909-b407ea636b5c"),
                    new Guid("9b537235-1905-4a5c-bcfd-e703fbe8e7b2"),
                    new Guid("7fa25911-52d6-411d-98a4-a6d55ca5957f"),
                    new Guid("9a89021d-a8c6-4d3b-b149-8e52dfcffd26"),
                    new Guid("2d6fe9ec-7534-4c01-9864-9bdfc0bf002f"),
                    new Guid("a7eec97f-7557-43cb-a304-a4be66956324"),
                    new Guid("3971344d-2bc9-4742-95a4-ab1fa245381c"),
                    new Guid("d3b1b476-c90b-49b1-9333-ac558a7ac26f")
                });

            migrationBuilder.InsertData(
                table: "Students",
                column: "AccountId",
                values: new object[]
                {
                    new Guid("04d9ede2-1148-4d2b-9dfd-8fb9b05be3c6"),
                    new Guid("38c05713-2be5-44fe-8289-126d0ec5b370"),
                    new Guid("648691b9-8bde-47b7-87b2-09ced338434f"),
                    new Guid("03e1701e-7a16-4181-a90e-eefdf54791d1"),
                    new Guid("22b99d65-238e-4414-9830-b8d56edda8d3"),
                    new Guid("c3024a6b-c61c-4437-8c9a-dc0546b37765"),
                    new Guid("e768134a-118a-4555-bb9d-060a2b041a85"),
                    new Guid("ab81330e-4203-4bce-9a79-2a9e95808418"),
                    new Guid("fc47b96d-6b02-4242-9ec2-e78e9b76db8e"),
                    new Guid("db0e4da8-0a95-409a-9e9e-2b11e4c30260"),
                    new Guid("f5355ac7-e343-40e0-8fb7-8bfb867224d6"),
                    new Guid("77bd5000-522a-4df5-8e34-b3b01a8e8606"),
                    new Guid("2d19797d-7788-496a-bf7e-b26dff677bd5"),
                    new Guid("f90db5bd-a8ca-4efe-8d5c-5873fc25fdc7"),
                    new Guid("3b82aac6-8bd4-407f-9022-8eb2f5f150aa"),
                    new Guid("14e41443-fb3b-4aa0-88c2-75a89f22faf4"),
                    new Guid("4094df26-53da-4e51-aa69-28406bf0e198"),
                    new Guid("fa66fe10-74b4-4b87-9410-d68ed52c2258"),
                    new Guid("fa5d9497-b645-4442-9789-62bccbe06d34"),
                    new Guid("d03ec302-9032-4220-ad51-2da905881098"),
                    new Guid("22d03711-eb9b-479f-8543-fcc39be24b3a"),
                    new Guid("de49dd29-30ae-4f77-9172-f892860e2b88"),
                    new Guid("89d379dc-dc16-4ae3-bcd7-129a3e305a51"),
                    new Guid("7b772708-355b-4a84-8bac-b59464644496"),
                    new Guid("9ab7410e-9a8b-45da-8e21-4560d3f8d7b9"),
                    new Guid("69258905-df3c-4dd6-8ecd-7b8f22cec975"),
                    new Guid("b069af86-5dab-4ac0-bf4d-bdfbc27394d4"),
                    new Guid("82394424-d858-4fdd-b7d2-82450c5c99a7"),
                    new Guid("8a5fc843-fbce-407a-b886-2b52427c7588"),
                    new Guid("abebc8c4-9a10-4cb4-aea0-f14b77e7c4a2"),
                    new Guid("bf8ed046-fe91-4946-993c-98ca2f62543f"),
                    new Guid("86108a96-dd24-445b-b8cf-40855961fa35"),
                    new Guid("2dd36ed5-09bf-4031-872e-8ec8bba5d45d"),
                    new Guid("60eed688-3b4a-4ae3-b5de-919a042824cb"),
                    new Guid("f4d4c7dc-7bc5-41e1-b492-c585e06b02db"),
                    new Guid("cd252b2c-4295-4b04-91ac-cd73ad319ff1"),
                    new Guid("ed791c14-e08e-4ec9-b17c-7f918f8a09c3"),
                    new Guid("3d4e3033-6bcc-4c2b-bf11-4cda82a9f716")
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "AccountId", "TeacherDegreeId" },
                values: new object[,]
                {
                    { new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f"), new Guid("74f8a42e-bbd1-4b03-bd78-329da0290ecf") },
                    { new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6"), new Guid("74f8a42e-bbd1-4b03-bd78-329da0290ecf") },
                    { new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747"), new Guid("74f8a42e-bbd1-4b03-bd78-329da0290ecf") },
                    { new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456"), new Guid("edaece06-4188-4df1-aac2-978f30777f6b") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "AccountId", "TeacherDegreeId" },
                values: new object[,]
                {
                    { new Guid("f052ae94-ba5a-4197-b978-520328996d6a"), new Guid("edaece06-4188-4df1-aac2-978f30777f6b") },
                    { new Guid("1212bca1-8f68-45e4-8a91-572adec7b855"), new Guid("edaece06-4188-4df1-aac2-978f30777f6b") },
                    { new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52"), new Guid("74f8a42e-bbd1-4b03-bd78-329da0290ecf") },
                    { new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f"), new Guid("74f8a42e-bbd1-4b03-bd78-329da0290ecf") },
                    { new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf"), new Guid("74f8a42e-bbd1-4b03-bd78-329da0290ecf") },
                    { new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295"), new Guid("49aa5ee9-482a-415e-be2b-b037e114f394") },
                    { new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5"), new Guid("6e1d2723-921a-46ba-b865-a1216005ee14") },
                    { new Guid("40772272-1210-4378-98bd-e829841f6b0c"), new Guid("6e1d2723-921a-46ba-b865-a1216005ee14") },
                    { new Guid("25ebd382-4646-40d7-8d67-a40c2779511d"), new Guid("6e1d2723-921a-46ba-b865-a1216005ee14") },
                    { new Guid("22bce128-1398-4d69-82c1-227bbd4a2439"), new Guid("6e1d2723-921a-46ba-b865-a1216005ee14") },
                    { new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357"), new Guid("6e1d2723-921a-46ba-b865-a1216005ee14") },
                    { new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337"), new Guid("49aa5ee9-482a-415e-be2b-b037e114f394") },
                    { new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458"), new Guid("49aa5ee9-482a-415e-be2b-b037e114f394") },
                    { new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b"), new Guid("edaece06-4188-4df1-aac2-978f30777f6b") },
                    { new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e"), new Guid("6e1d2723-921a-46ba-b865-a1216005ee14") },
                    { new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8"), new Guid("edaece06-4188-4df1-aac2-978f30777f6b") }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "ChiefOfDepartmentId", "Name" },
                values: new object[,]
                {
                    { new Guid("7600bb28-ceae-4cba-bbf0-8c535e20120b"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458"), "Faculty-1" },
                    { new Guid("8447b48e-a096-41cf-97fc-96ea2de422f2"), new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357"), "Faculty-0" },
                    { new Guid("8b30d1d8-e44b-4039-943f-1f9204fbee8a"), new Guid("22bce128-1398-4d69-82c1-227bbd4a2439"), "Faculty-2" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "LeaderStudentId", "Number", "TutorTeacherId" },
                values: new object[,]
                {
                    { new Guid("c4ab0b70-3408-4fb5-836f-d063f9f2cc6c"), new Guid("fa5d9497-b645-4442-9789-62bccbe06d34"), 0L, new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("59d210b1-da72-479c-8e75-13019e66a19f"), new Guid("9a89021d-a8c6-4d3b-b149-8e52dfcffd26"), 0L, new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("b390b62c-e3f5-4201-9675-29dc9e4aea7c"), new Guid("dccde5a9-b87f-4465-87d1-dc2a95427e5e"), 0L, new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f") },
                    { new Guid("67c0d79d-0929-4bdc-b990-853a5b0b4fb9"), new Guid("5c45cd1a-7bc1-45f0-bbab-7765cb441306"), 0L, new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("3a888b6f-d997-41c3-b78c-22bc81609a14"), new Guid("fa66fe10-74b4-4b87-9410-d68ed52c2258"), 0L, new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6") },
                    { new Guid("cb5efdeb-6ffc-4c19-8cca-6ed94ba7c867"), new Guid("2d6fe9ec-7534-4c01-9864-9bdfc0bf002f"), 0L, new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") },
                    { new Guid("81417114-72f5-4a79-85ee-183e3f15a7ab"), new Guid("6ea3531d-d4ce-4c61-9c39-7846e05a0c8e"), 0L, new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") },
                    { new Guid("548554f6-a9d6-4955-aa27-33966a978f9f"), new Guid("2dd36ed5-09bf-4031-872e-8ec8bba5d45d"), 0L, new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("2c79988f-6246-4256-bd67-8e11d932a663"), new Guid("86108a96-dd24-445b-b8cf-40855961fa35"), 0L, new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("593b8697-93cf-4382-9071-e912d8162813"), new Guid("89d379dc-dc16-4ae3-bcd7-129a3e305a51"), 0L, new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("832777ad-d9c8-4505-b218-6395e4c3ed58"), new Guid("648691b9-8bde-47b7-87b2-09ced338434f"), 0L, new Guid("25ebd382-4646-40d7-8d67-a40c2779511d") },
                    { new Guid("80e64474-0e4f-4b0f-bbfd-53e74b7e70cd"), new Guid("22b99d65-238e-4414-9830-b8d56edda8d3"), 0L, new Guid("22bce128-1398-4d69-82c1-227bbd4a2439") },
                    { new Guid("f4661024-d372-4b26-a528-92971d4026e9"), new Guid("d03ec302-9032-4220-ad51-2da905881098"), 0L, new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357") },
                    { new Guid("eed65e09-d154-4c59-b3a2-2e79a83eb4e5"), new Guid("b069af86-5dab-4ac0-bf4d-bdfbc27394d4"), 0L, new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("7183038d-3c40-43de-b0c7-aaffd0371527"), new Guid("edd63be1-dfe6-480a-8c38-f42ea138c398"), 0L, new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("ef83a549-29f2-4986-8e3f-5364843a6df2"), new Guid("03e1701e-7a16-4181-a90e-eefdf54791d1"), 0L, new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("61638f23-9d32-427d-a0ee-5ecefcb0671e"), new Guid("fc47b96d-6b02-4242-9ec2-e78e9b76db8e"), 0L, new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("e076e4c0-be4e-4529-8804-a095b3153949"), new Guid("4bed0bcc-b521-4d3a-9830-2818c7802f64"), 0L, new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") }
                });

            migrationBuilder.InsertData(
                table: "Specialisations",
                columns: new[] { "Id", "FacultyId", "Name", "Semesters", "StudyDegreeId", "StudyLineId" },
                values: new object[,]
                {
                    { new Guid("a0b7eea6-ab4e-47ec-b6e2-45c3a2fc853f"), new Guid("7600bb28-ceae-4cba-bbf0-8c535e20120b"), "Specialisation-2", (short)2, new Guid("4f9683c5-bd7a-4bfe-8c77-a85fbfa0927e"), new Guid("84409672-4042-4ea4-b3d4-4087195b0285") },
                    { new Guid("f8028b4b-e25d-4d2d-ad8a-7dab8785e5fd"), new Guid("7600bb28-ceae-4cba-bbf0-8c535e20120b"), "Specialisation-3", (short)2, new Guid("4f9683c5-bd7a-4bfe-8c77-a85fbfa0927e"), new Guid("84409672-4042-4ea4-b3d4-4087195b0285") },
                    { new Guid("de9ef3d2-cca9-4fae-8e34-d836a2bbc973"), new Guid("7600bb28-ceae-4cba-bbf0-8c535e20120b"), "Specialisation-5", (short)2, new Guid("411098c2-2c1c-4912-987a-1cb49f828156"), new Guid("84409672-4042-4ea4-b3d4-4087195b0285") },
                    { new Guid("e524a071-eaee-4e57-8f26-f97430d5ed13"), new Guid("8447b48e-a096-41cf-97fc-96ea2de422f2"), "Specialisation-4", (short)2, new Guid("411098c2-2c1c-4912-987a-1cb49f828156"), new Guid("84409672-4042-4ea4-b3d4-4087195b0285") },
                    { new Guid("70c6efd9-c5d1-40b4-9d0b-83312e866575"), new Guid("8b30d1d8-e44b-4039-943f-1f9204fbee8a"), "Specialisation-0", (short)2, new Guid("411098c2-2c1c-4912-987a-1cb49f828156"), new Guid("d0d34ecc-8702-4cca-9e83-22a5b9516cf8") },
                    { new Guid("2bb47c99-d085-4ab8-a4ba-73d09b46871a"), new Guid("8b30d1d8-e44b-4039-943f-1f9204fbee8a"), "Specialisation-1", (short)2, new Guid("4f9683c5-bd7a-4bfe-8c77-a85fbfa0927e"), new Guid("4decf4a7-a414-4896-ad31-c4091dc4e3c2") }
                });

            migrationBuilder.InsertData(
                table: "StudyYears",
                columns: new[] { "Id", "EndDate", "SpecializationId", "StartDate", "StudentLeaderId" },
                values: new object[,]
                {
                    { new Guid("5e101ae0-8a92-4825-adbe-f1a581ea1b77"), 1651227795L, new Guid("a0b7eea6-ab4e-47ec-b6e2-45c3a2fc853f"), 1619691795L, new Guid("7fa25911-52d6-411d-98a4-a6d55ca5957f") },
                    { new Guid("7c37e31d-4f45-4491-81b0-34a92a43d1f1"), 1651227795L, new Guid("2bb47c99-d085-4ab8-a4ba-73d09b46871a"), 1619691795L, new Guid("7b772708-355b-4a84-8bac-b59464644496") },
                    { new Guid("0b231890-5bfe-4325-834a-38484b483f08"), 1588155795L, new Guid("70c6efd9-c5d1-40b4-9d0b-83312e866575"), 1556533395L, null },
                    { new Guid("8673cdd5-e71a-4c15-b3d2-dd53fce3605a"), 1619691795L, new Guid("70c6efd9-c5d1-40b4-9d0b-83312e866575"), 1588155795L, null },
                    { new Guid("ed4f24ce-cfad-489d-b725-6eb559449fa3"), 1651227795L, new Guid("70c6efd9-c5d1-40b4-9d0b-83312e866575"), 1619691795L, new Guid("86108a96-dd24-445b-b8cf-40855961fa35") },
                    { new Guid("b67a502c-9da5-4e48-9e05-1064b2bf0764"), 1588155795L, new Guid("e524a071-eaee-4e57-8f26-f97430d5ed13"), 1556533395L, null },
                    { new Guid("b4c0f99c-77e9-49bd-ad36-474c51fcfc59"), 1619691795L, new Guid("e524a071-eaee-4e57-8f26-f97430d5ed13"), 1588155795L, null },
                    { new Guid("39659841-222b-4029-8bb0-f5922c4b94a4"), 1651227795L, new Guid("e524a071-eaee-4e57-8f26-f97430d5ed13"), 1619691795L, new Guid("ff4b105e-12ff-4534-be50-6235f5db6ed5") },
                    { new Guid("3088a272-82f1-4091-aa76-9f46999917e9"), 1588155795L, new Guid("de9ef3d2-cca9-4fae-8e34-d836a2bbc973"), 1556533395L, null },
                    { new Guid("d3c592b4-135c-4e51-b842-30ff352475a3"), 1619691795L, new Guid("de9ef3d2-cca9-4fae-8e34-d836a2bbc973"), 1588155795L, null },
                    { new Guid("ebc64c61-b323-4bed-b776-14813ad9b255"), 1651227795L, new Guid("de9ef3d2-cca9-4fae-8e34-d836a2bbc973"), 1619691795L, new Guid("edd63be1-dfe6-480a-8c38-f42ea138c398") },
                    { new Guid("957ec602-b51c-4950-bda8-8f96a489a69c"), 1588155795L, new Guid("f8028b4b-e25d-4d2d-ad8a-7dab8785e5fd"), 1556533395L, null },
                    { new Guid("2333eab3-edb2-4395-ae81-25b9d80a5973"), 1619691795L, new Guid("f8028b4b-e25d-4d2d-ad8a-7dab8785e5fd"), 1588155795L, null },
                    { new Guid("fb52b666-d8b4-4fa3-9d81-2d61127c66f8"), 1651227795L, new Guid("f8028b4b-e25d-4d2d-ad8a-7dab8785e5fd"), 1619691795L, new Guid("ab1eed90-ade2-4983-8a37-48884fe2726d") },
                    { new Guid("d1740164-96ad-43b1-aaab-1ff5f0c39999"), 1588155795L, new Guid("a0b7eea6-ab4e-47ec-b6e2-45c3a2fc853f"), 1556533395L, null },
                    { new Guid("b892eff4-27e7-403e-99da-1b0f516dc05d"), 1619691795L, new Guid("a0b7eea6-ab4e-47ec-b6e2-45c3a2fc853f"), 1588155795L, null },
                    { new Guid("57389afc-ef32-4d78-b72c-63aeb9800b09"), 1619691795L, new Guid("2bb47c99-d085-4ab8-a4ba-73d09b46871a"), 1588155795L, null },
                    { new Guid("06314359-c6fa-497e-aa82-b0085d8f4aeb"), 1588155795L, new Guid("2bb47c99-d085-4ab8-a4ba-73d09b46871a"), 1556533395L, null }
                });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "GroupId", "SignedAt", "StudentId", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("aaf7dac2-2f86-48ff-b01d-e4a686407468"), new Guid("43a6db13-bc2b-4080-9897-92c9a481963b"), 1647781930L, new Guid("de49dd29-30ae-4f77-9172-f892860e2b88"), new Guid("5e101ae0-8a92-4825-adbe-f1a581ea1b77") },
                    { new Guid("e6cecb5d-934b-4d05-8489-2c00318bce1d"), new Guid("48cfc7d0-01c2-4610-9f10-ac05c5b27a55"), 1647781930L, new Guid("0d0133c1-35d5-4411-ac6f-ca4c0c719563"), new Guid("b67a502c-9da5-4e48-9e05-1064b2bf0764") },
                    { new Guid("3d66ef22-dfde-41a0-8f8f-8cf1364ad04e"), new Guid("3a888b6f-d997-41c3-b78c-22bc81609a14"), 1647781930L, new Guid("86108a96-dd24-445b-b8cf-40855961fa35"), new Guid("b67a502c-9da5-4e48-9e05-1064b2bf0764") },
                    { new Guid("37faf795-9e3d-4e7e-a86f-813008dcd4e7"), new Guid("59d210b1-da72-479c-8e75-13019e66a19f"), 1647781930L, new Guid("d03ec302-9032-4220-ad51-2da905881098"), new Guid("b67a502c-9da5-4e48-9e05-1064b2bf0764") },
                    { new Guid("dd352b57-7766-49c9-b001-368415df6dd1"), new Guid("445f55df-b8e2-4a91-90e5-dc1fca86f427"), 1647781930L, new Guid("f90db5bd-a8ca-4efe-8d5c-5873fc25fdc7"), new Guid("b67a502c-9da5-4e48-9e05-1064b2bf0764") },
                    { new Guid("b12884d0-e266-4ce0-bc61-c65276e49c43"), new Guid("81417114-72f5-4a79-85ee-183e3f15a7ab"), 1647781930L, new Guid("14e41443-fb3b-4aa0-88c2-75a89f22faf4"), new Guid("b67a502c-9da5-4e48-9e05-1064b2bf0764") },
                    { new Guid("b0595e3b-ca8d-400f-a574-d0ea91d0c5e5"), new Guid("01d1a913-d237-47b3-8265-eba1c3e5248c"), 1647781930L, new Guid("4094df26-53da-4e51-aa69-28406bf0e198"), new Guid("b67a502c-9da5-4e48-9e05-1064b2bf0764") },
                    { new Guid("9c77760e-39a5-432b-a750-20863e29afd1"), new Guid("29f7414c-afb7-455e-bf4b-6fd5af67ece8"), 1647781930L, new Guid("fa5d9497-b645-4442-9789-62bccbe06d34"), new Guid("b67a502c-9da5-4e48-9e05-1064b2bf0764") },
                    { new Guid("af6d5c23-cc01-4712-b88f-aea3ce884347"), new Guid("b390b62c-e3f5-4201-9675-29dc9e4aea7c"), 1647781930L, new Guid("03e1701e-7a16-4181-a90e-eefdf54791d1"), new Guid("b4c0f99c-77e9-49bd-ad36-474c51fcfc59") },
                    { new Guid("c2dd13ae-a82d-4f08-a3be-ce053e7bae72"), new Guid("e076e4c0-be4e-4529-8804-a095b3153949"), 1647781930L, new Guid("5266b7b5-e0dc-4779-b909-b407ea636b5c"), new Guid("b67a502c-9da5-4e48-9e05-1064b2bf0764") },
                    { new Guid("c049ff9b-800d-4553-a8b6-ecc25fd8ad31"), new Guid("70b92c51-d74e-421c-84ad-0490736bcac6"), 1647781930L, new Guid("b069af86-5dab-4ac0-bf4d-bdfbc27394d4"), new Guid("b4c0f99c-77e9-49bd-ad36-474c51fcfc59") },
                    { new Guid("67b0c287-8404-44a1-a135-e6d91ac1e41d"), new Guid("832777ad-d9c8-4505-b218-6395e4c3ed58"), 1647781930L, new Guid("db0e4da8-0a95-409a-9e9e-2b11e4c30260"), new Guid("b4c0f99c-77e9-49bd-ad36-474c51fcfc59") },
                    { new Guid("ea8ae582-d1c8-4cf8-ae4f-1dffd7908af5"), new Guid("43a6db13-bc2b-4080-9897-92c9a481963b"), 1647781930L, new Guid("7fa25911-52d6-411d-98a4-a6d55ca5957f"), new Guid("39659841-222b-4029-8bb0-f5922c4b94a4") },
                    { new Guid("9d8852b5-0a17-4e6d-af84-7763b6fa6ae5"), new Guid("3bcebc11-cf9c-45a8-9284-7dea6502f3e3"), 1647781930L, new Guid("38c05713-2be5-44fe-8289-126d0ec5b370"), new Guid("39659841-222b-4029-8bb0-f5922c4b94a4") },
                    { new Guid("c4aad5b1-11e4-421f-98cd-bf02c457aebf"), new Guid("778eb6cf-a35a-40de-9bf0-09a9a8643176"), 1647781930L, new Guid("82394424-d858-4fdd-b7d2-82450c5c99a7"), new Guid("39659841-222b-4029-8bb0-f5922c4b94a4") },
                    { new Guid("671fc258-ae33-4336-b98d-6a8fc037c6a6"), new Guid("1c78cca3-1758-4db3-95b1-8a608a0ec5a0"), 1647781930L, new Guid("63195d9e-0811-490b-86f6-17855b2c7417"), new Guid("3088a272-82f1-4091-aa76-9f46999917e9") },
                    { new Guid("09c6a7a8-67fc-4fbb-994f-8afbfd8ef743"), new Guid("81417114-72f5-4a79-85ee-183e3f15a7ab"), 1647781930L, new Guid("3971344d-2bc9-4742-95a4-ab1fa245381c"), new Guid("3088a272-82f1-4091-aa76-9f46999917e9") },
                    { new Guid("d5d67367-53cd-42a8-8aa0-8b8af28ddfe7"), new Guid("9702f4a0-fe9b-4aae-a9c8-76b84e89559d"), 1647781930L, new Guid("dccde5a9-b87f-4465-87d1-dc2a95427e5e"), new Guid("3088a272-82f1-4091-aa76-9f46999917e9") },
                    { new Guid("b4759aa8-7602-4f65-a2c0-37720da32d30"), new Guid("3557ddb8-7418-4693-bf5c-f00552f9eca3"), 1647781930L, new Guid("1a6a5b85-fc8c-4d35-8b8c-a5e0a04c7bbb"), new Guid("3088a272-82f1-4091-aa76-9f46999917e9") },
                    { new Guid("d266b1fe-17ba-4ba3-97d2-9eae480ed6ea"), new Guid("2e135cc3-a5f4-4c8c-bcfe-2a31a04238a2"), 1647781930L, new Guid("8a5fc843-fbce-407a-b886-2b52427c7588"), new Guid("b4c0f99c-77e9-49bd-ad36-474c51fcfc59") },
                    { new Guid("a7d32706-059e-4441-b28b-48ee8fc51665"), new Guid("2f5c0a1c-9149-4d44-ab30-f089b7320b00"), 1647781930L, new Guid("fc47b96d-6b02-4242-9ec2-e78e9b76db8e"), new Guid("ed4f24ce-cfad-489d-b725-6eb559449fa3") },
                    { new Guid("0d1773ec-0244-4c09-8b24-b6f34a275ab1"), new Guid("548554f6-a9d6-4955-aa27-33966a978f9f"), 1647781930L, new Guid("f4d4c7dc-7bc5-41e1-b492-c585e06b02db"), new Guid("ed4f24ce-cfad-489d-b725-6eb559449fa3") },
                    { new Guid("564571ab-193f-4378-90c9-672903298184"), new Guid("e319e079-aa3a-499a-b7e8-cf6eae5e86cf"), 1647781930L, new Guid("77bd5000-522a-4df5-8e34-b3b01a8e8606"), new Guid("ed4f24ce-cfad-489d-b725-6eb559449fa3") },
                    { new Guid("806b0bb5-1532-4505-a6c1-e594b37cf25f"), new Guid("80319172-f1ea-4749-9d24-34867e1f9a37"), 1647781930L, new Guid("41f342f3-6a25-40c0-b53b-135de297566b"), new Guid("06314359-c6fa-497e-aa82-b0085d8f4aeb") },
                    { new Guid("7b053d1c-38e8-4ab5-9b43-f7792306c45b"), new Guid("2c79988f-6246-4256-bd67-8e11d932a663"), 1647781930L, new Guid("a7eec97f-7557-43cb-a304-a4be66956324"), new Guid("06314359-c6fa-497e-aa82-b0085d8f4aeb") },
                    { new Guid("9f612ffe-e2b6-46d6-9bb9-366eaf457c31"), new Guid("be1fb0b0-b64b-4962-be0f-b2688db42d35"), 1647781930L, new Guid("abebc8c4-9a10-4cb4-aea0-f14b77e7c4a2"), new Guid("06314359-c6fa-497e-aa82-b0085d8f4aeb") },
                    { new Guid("c3b8b274-e846-46f7-83da-b0459eca06a3"), new Guid("e076e4c0-be4e-4529-8804-a095b3153949"), 1647781930L, new Guid("fa5d9497-b645-4442-9789-62bccbe06d34"), new Guid("06314359-c6fa-497e-aa82-b0085d8f4aeb") },
                    { new Guid("e1199575-353f-4bf2-9876-dfb2f21897f9"), new Guid("61638f23-9d32-427d-a0ee-5ecefcb0671e"), 1647781930L, new Guid("69258905-df3c-4dd6-8ecd-7b8f22cec975"), new Guid("57389afc-ef32-4d78-b72c-63aeb9800b09") },
                    { new Guid("26b3ba54-1e49-4807-ac04-3db4651c0b84"), new Guid("d7d5ee41-0749-47e6-888b-b7745d13fc33"), 1647781930L, new Guid("60eed688-3b4a-4ae3-b5de-919a042824cb"), new Guid("57389afc-ef32-4d78-b72c-63aeb9800b09") },
                    { new Guid("15c970c3-b25c-4c5c-9836-69ace70bc0ea"), new Guid("c4ab0b70-3408-4fb5-836f-d063f9f2cc6c"), 1647781930L, new Guid("89d379dc-dc16-4ae3-bcd7-129a3e305a51"), new Guid("57389afc-ef32-4d78-b72c-63aeb9800b09") },
                    { new Guid("63094e16-0d70-43ef-b1cb-3237d3c021c8"), new Guid("5cc7cdfb-3145-4c5e-8b90-bf813bd18b14"), 1647781930L, new Guid("04d9ede2-1148-4d2b-9dfd-8fb9b05be3c6"), new Guid("7c37e31d-4f45-4491-81b0-34a92a43d1f1") },
                    { new Guid("1ec752c6-ebd2-4055-97b5-c0a187970e85"), new Guid("62744cc4-e1e5-4b3c-a821-89753d301d1c"), 1647781930L, new Guid("86f7bd2c-cb6b-40bc-9585-d548f996b2e4"), new Guid("7c37e31d-4f45-4491-81b0-34a92a43d1f1") },
                    { new Guid("90cb5bfb-3beb-4665-8353-a34d7a489a28"), new Guid("a01bb2b0-884a-4a83-af22-ca3a98dcdb3b"), 1647781930L, new Guid("b43a76ce-57d1-4dbc-ab5b-59841836da67"), new Guid("7c37e31d-4f45-4491-81b0-34a92a43d1f1") },
                    { new Guid("35e4e51c-503f-4f79-96c6-beb201966917"), new Guid("593b8697-93cf-4382-9071-e912d8162813"), 1647781930L, new Guid("e768134a-118a-4555-bb9d-060a2b041a85"), new Guid("7c37e31d-4f45-4491-81b0-34a92a43d1f1") },
                    { new Guid("2fa6b3b1-ec49-46ed-8b4e-7f670ce94c57"), new Guid("2f5c0a1c-9149-4d44-ab30-f089b7320b00"), 1647781930L, new Guid("04e7fc75-cb2f-463d-ad54-ea76f951d701"), new Guid("0b231890-5bfe-4325-834a-38484b483f08") },
                    { new Guid("0ef4d181-436b-453c-b2a0-8754880dc64a"), new Guid("ef83a549-29f2-4986-8e3f-5364843a6df2"), 1647781930L, new Guid("9a89021d-a8c6-4d3b-b149-8e52dfcffd26"), new Guid("0b231890-5bfe-4325-834a-38484b483f08") },
                    { new Guid("df5c6383-763a-4547-babc-c79ff2bb4339"), new Guid("15a718db-1d58-4f2e-85c9-b72513b58c19"), 1647781930L, new Guid("3b82aac6-8bd4-407f-9022-8eb2f5f150aa"), new Guid("0b231890-5bfe-4325-834a-38484b483f08") },
                    { new Guid("f3375d29-fc29-4af4-aebf-37739f53b91e"), new Guid("408d2ca0-ef00-40ab-8ca5-4713ca59bacc"), 1647781930L, new Guid("e4689a19-6bb7-4269-9ba5-dbc69638ab0e"), new Guid("8673cdd5-e71a-4c15-b3d2-dd53fce3605a") },
                    { new Guid("5b56c634-9fb1-466d-8d88-21aa37c9014c"), new Guid("3557ddb8-7418-4693-bf5c-f00552f9eca3"), 1647781930L, new Guid("cd252b2c-4295-4b04-91ac-cd73ad319ff1"), new Guid("8673cdd5-e71a-4c15-b3d2-dd53fce3605a") },
                    { new Guid("3dd4b36d-d662-4b56-8414-1839ae50d322"), new Guid("25fecc55-5fdb-462e-80df-52ee2c11e707"), 1647781930L, new Guid("22d03711-eb9b-479f-8543-fcc39be24b3a"), new Guid("8673cdd5-e71a-4c15-b3d2-dd53fce3605a") },
                    { new Guid("b06bc045-696e-439b-a3a6-f1bd84486438"), new Guid("85630ba6-dd96-4d6f-9cf7-71dfc75a7831"), 1647781930L, new Guid("22b99d65-238e-4414-9830-b8d56edda8d3"), new Guid("8673cdd5-e71a-4c15-b3d2-dd53fce3605a") },
                    { new Guid("243497cd-f91e-4a24-ba6d-cca28bb863ac"), new Guid("68e37478-569a-43f3-8eaa-d34b499ae01e"), 1647781930L, new Guid("ab81330e-4203-4bce-9a79-2a9e95808418"), new Guid("8673cdd5-e71a-4c15-b3d2-dd53fce3605a") }
                });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "GroupId", "SignedAt", "StudentId", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("1d95401d-d844-4cd5-b347-f4502af65bd4"), new Guid("20f78dff-abc9-4f25-8f98-7df665ca8cd5"), 1647781930L, new Guid("70d4e53a-53a2-4923-b89c-fff5257f8a3f"), new Guid("3088a272-82f1-4091-aa76-9f46999917e9") },
                    { new Guid("164a13d6-1ab0-42fb-ba23-a83e8e00a74c"), new Guid("e18e5e04-3fa9-4d5f-a0ff-b46d721a5603"), 1647781930L, new Guid("2dd36ed5-09bf-4031-872e-8ec8bba5d45d"), new Guid("3088a272-82f1-4091-aa76-9f46999917e9") },
                    { new Guid("97aeadf0-e163-4377-9546-17ccd74f8b1d"), new Guid("c9edf964-f23e-4af9-9182-d91895212bb0"), 1647781930L, new Guid("7b772708-355b-4a84-8bac-b59464644496"), new Guid("39659841-222b-4029-8bb0-f5922c4b94a4") },
                    { new Guid("b8996bc3-6078-4952-bf32-a500d62359dd"), new Guid("5cc7cdfb-3145-4c5e-8b90-bf813bd18b14"), 1647781930L, new Guid("f5355ac7-e343-40e0-8fb7-8bfb867224d6"), new Guid("3088a272-82f1-4091-aa76-9f46999917e9") },
                    { new Guid("106445cc-e7da-4036-98b3-08b35fb302d6"), new Guid("59d210b1-da72-479c-8e75-13019e66a19f"), 1647781930L, new Guid("6ea3531d-d4ce-4c61-9c39-7846e05a0c8e"), new Guid("fb52b666-d8b4-4fa3-9d81-2d61127c66f8") },
                    { new Guid("c5e62b9c-3cad-4135-bb8e-334d3759385e"), new Guid("832777ad-d9c8-4505-b218-6395e4c3ed58"), 1647781930L, new Guid("9b537235-1905-4a5c-bcfd-e703fbe8e7b2"), new Guid("fb52b666-d8b4-4fa3-9d81-2d61127c66f8") },
                    { new Guid("7e5eaf80-dc98-4b7f-9051-e2d8a2e06675"), new Guid("445f55df-b8e2-4a91-90e5-dc1fca86f427"), 1647781930L, new Guid("2d6fe9ec-7534-4c01-9864-9bdfc0bf002f"), new Guid("fb52b666-d8b4-4fa3-9d81-2d61127c66f8") },
                    { new Guid("4d77ba5e-ac5e-4ea9-93dc-4e8a2652cccb"), new Guid("1c78cca3-1758-4db3-95b1-8a608a0ec5a0"), 1647781930L, new Guid("c3024a6b-c61c-4437-8c9a-dc0546b37765"), new Guid("3088a272-82f1-4091-aa76-9f46999917e9") },
                    { new Guid("b8a0c246-76b3-408d-a80f-aabd51b9ab7f"), new Guid("67c0d79d-0929-4bdc-b990-853a5b0b4fb9"), 1647781930L, new Guid("a24a853a-b0af-4d05-be95-2514f4a9647a"), new Guid("fb52b666-d8b4-4fa3-9d81-2d61127c66f8") },
                    { new Guid("3dd8e9f0-1f01-4db9-97d3-a0d5d9de1d9c"), new Guid("29f7414c-afb7-455e-bf4b-6fd5af67ece8"), 1647781930L, new Guid("c131bfdd-28d3-4715-9c3c-4c508ec49e58"), new Guid("fb52b666-d8b4-4fa3-9d81-2d61127c66f8") },
                    { new Guid("1025ff84-b64f-46ae-8fa4-41fec6d6f171"), new Guid("80e64474-0e4f-4b0f-bbfd-53e74b7e70cd"), 1647781930L, new Guid("1f90fa33-df8f-4004-86fa-8e0276622cbd"), new Guid("fb52b666-d8b4-4fa3-9d81-2d61127c66f8") },
                    { new Guid("727238df-9940-4cd5-8602-9dcb7ad6d198"), new Guid("0e3945a9-3a01-4fd8-86cf-c4c223ebca79"), 1647781930L, new Guid("3d4e3033-6bcc-4c2b-bf11-4cda82a9f716"), new Guid("fb52b666-d8b4-4fa3-9d81-2d61127c66f8") },
                    { new Guid("826f93e5-3cdb-407b-a4d9-79f220dce519"), new Guid("ef83a549-29f2-4986-8e3f-5364843a6df2"), 1647781930L, new Guid("2d19797d-7788-496a-bf7e-b26dff677bd5"), new Guid("d1740164-96ad-43b1-aaab-1ff5f0c39999") },
                    { new Guid("9d6e111f-c05a-4cf3-97b5-17419684539b"), new Guid("593b8697-93cf-4382-9071-e912d8162813"), 1647781930L, new Guid("5c45cd1a-7bc1-45f0-bbab-7765cb441306"), new Guid("b892eff4-27e7-403e-99da-1b0f516dc05d") },
                    { new Guid("3a0cb163-5dff-4a4c-a84c-37ec5a5e551f"), new Guid("62744cc4-e1e5-4b3c-a821-89753d301d1c"), 1647781930L, new Guid("fa66fe10-74b4-4b87-9410-d68ed52c2258"), new Guid("b892eff4-27e7-403e-99da-1b0f516dc05d") },
                    { new Guid("b2009ddc-83ea-493f-b9a0-597c3cce4f06"), new Guid("85630ba6-dd96-4d6f-9cf7-71dfc75a7831"), 1647781930L, new Guid("191a9fe9-c700-48e0-aae2-9b77131a8a60"), new Guid("5e101ae0-8a92-4825-adbe-f1a581ea1b77") },
                    { new Guid("afebc5f8-a94a-413c-b8ca-2ccb9acae24c"), new Guid("68e37478-569a-43f3-8eaa-d34b499ae01e"), 1647781930L, new Guid("c0b0de66-2624-40a0-b347-32dc01bfb4b7"), new Guid("5e101ae0-8a92-4825-adbe-f1a581ea1b77") },
                    { new Guid("73578850-5c75-475b-a4b0-80d8b9d5f7c3"), new Guid("cb5efdeb-6ffc-4c19-8cca-6ed94ba7c867"), 1647781930L, new Guid("ab1eed90-ade2-4983-8a37-48884fe2726d"), new Guid("5e101ae0-8a92-4825-adbe-f1a581ea1b77") },
                    { new Guid("a7a4a539-47b6-469d-9fb1-09ab2b6c0b2f"), new Guid("9864d11a-27f4-4ec1-b99e-6b7fcb660ea0"), 1647781930L, new Guid("bbee4cf1-ad13-4c7a-a371-9818a8247118"), new Guid("5e101ae0-8a92-4825-adbe-f1a581ea1b77") },
                    { new Guid("0c0fad3c-7f67-483c-ba2c-2e27137cb54d"), new Guid("047d5f61-314b-4ce8-b631-64a3a12fb239"), 1647781930L, new Guid("4bed0bcc-b521-4d3a-9830-2818c7802f64"), new Guid("5e101ae0-8a92-4825-adbe-f1a581ea1b77") },
                    { new Guid("0ce7c9a3-e212-4996-872b-79d97f150010"), new Guid("eed65e09-d154-4c59-b3a2-2e79a83eb4e5"), 1647781930L, new Guid("bf8ed046-fe91-4946-993c-98ca2f62543f"), new Guid("5e101ae0-8a92-4825-adbe-f1a581ea1b77") },
                    { new Guid("70d8e9fa-fea1-4e94-8a8c-b69f2b1fa1d2"), new Guid("7183038d-3c40-43de-b0c7-aaffd0371527"), 1647781930L, new Guid("648691b9-8bde-47b7-87b2-09ced338434f"), new Guid("2333eab3-edb2-4395-ae81-25b9d80a5973") },
                    { new Guid("d7cbdd5c-ad78-4cb6-9983-4253a09fdd53"), new Guid("15a718db-1d58-4f2e-85c9-b72513b58c19"), 1647781930L, new Guid("d219d7fc-db65-4df3-8144-0dab0e4d0658"), new Guid("2333eab3-edb2-4395-ae81-25b9d80a5973") },
                    { new Guid("fbc3c21b-9566-4921-b79e-e8355d8489a4"), new Guid("f717afa8-85fb-45ca-92ba-3b830a2d90cf"), 1647781930L, new Guid("1a6a5b85-fc8c-4d35-8b8c-a5e0a04c7bbb"), new Guid("fb52b666-d8b4-4fa3-9d81-2d61127c66f8") },
                    { new Guid("4ea51a45-d354-485d-aca7-696993b47ea7"), new Guid("01d1a913-d237-47b3-8265-eba1c3e5248c"), 1647781930L, new Guid("d3b1b476-c90b-49b1-9333-ac558a7ac26f"), new Guid("ebc64c61-b323-4bed-b776-14813ad9b255") },
                    { new Guid("5c37b51d-a1c9-4441-8245-78d16a149b89"), new Guid("f9b9b9d2-45cf-4aeb-9e41-9777c150c0a3"), 1647781930L, new Guid("9ab7410e-9a8b-45da-8e21-4560d3f8d7b9"), new Guid("d3c592b4-135c-4e51-b842-30ff352475a3") },
                    { new Guid("1e16dc4a-08bf-48d1-ae9d-9e6e9436bbf4"), new Guid("17e755b1-67d3-456b-ab08-9bace8bf1499"), 1647781930L, new Guid("65ceac3b-d4bb-4516-9247-8a03d9e33b7c"), new Guid("ebc64c61-b323-4bed-b776-14813ad9b255") },
                    { new Guid("23c227b7-08b2-40f7-904a-ed5d7b994cbf"), new Guid("ba0f286c-3a4e-4068-b18f-72d7a6a628fc"), 1647781930L, new Guid("ff4b105e-12ff-4534-be50-6235f5db6ed5"), new Guid("d3c592b4-135c-4e51-b842-30ff352475a3") },
                    { new Guid("664fe71c-7d81-45c4-98da-c7213e6f919b"), new Guid("fbef0fc7-eec0-4359-bb33-a1481d1598dc"), 1647781930L, new Guid("ed791c14-e08e-4ec9-b17c-7f918f8a09c3"), new Guid("d3c592b4-135c-4e51-b842-30ff352475a3") },
                    { new Guid("7429d0f1-1c3f-4ff6-999e-48f46225ad56"), new Guid("f4661024-d372-4b26-a528-92971d4026e9"), 1647781930L, new Guid("edd63be1-dfe6-480a-8c38-f42ea138c398"), new Guid("d3c592b4-135c-4e51-b842-30ff352475a3") }
                });

            migrationBuilder.InsertData(
                table: "StudySemesters",
                columns: new[] { "Id", "Semester", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("aa0bfda2-b72d-4fff-b25d-de42c1458839"), (short)2, new Guid("57389afc-ef32-4d78-b72c-63aeb9800b09") },
                    { new Guid("15673aa4-8126-43c1-b047-855314b81bc0"), (short)1, new Guid("0b231890-5bfe-4325-834a-38484b483f08") },
                    { new Guid("c4f8f93c-40ce-41b1-b99f-3d2ff1749ec3"), (short)2, new Guid("0b231890-5bfe-4325-834a-38484b483f08") },
                    { new Guid("28166599-9455-408b-a091-0cf8f68b9793"), (short)1, new Guid("b892eff4-27e7-403e-99da-1b0f516dc05d") },
                    { new Guid("61eb3cbe-5ee6-4691-9c2e-e2cb525dca24"), (short)1, new Guid("06314359-c6fa-497e-aa82-b0085d8f4aeb") },
                    { new Guid("9cbd3a95-8630-4b50-8e01-ac1bbd7d76f9"), (short)2, new Guid("d3c592b4-135c-4e51-b842-30ff352475a3") },
                    { new Guid("c9b5df91-23b1-4d72-8392-5af38ca94806"), (short)2, new Guid("5e101ae0-8a92-4825-adbe-f1a581ea1b77") },
                    { new Guid("b4758dc7-bdb9-4fac-89c3-29f7f2c39911"), (short)1, new Guid("7c37e31d-4f45-4491-81b0-34a92a43d1f1") },
                    { new Guid("2a48f4f1-2f4b-4ab3-8cb2-110759744719"), (short)1, new Guid("5e101ae0-8a92-4825-adbe-f1a581ea1b77") },
                    { new Guid("e65b7433-ae92-4097-8663-b65fef19eb0a"), (short)2, new Guid("b892eff4-27e7-403e-99da-1b0f516dc05d") },
                    { new Guid("7580bfe5-dcc3-405a-8c08-0ad9cc21012d"), (short)1, new Guid("d3c592b4-135c-4e51-b842-30ff352475a3") },
                    { new Guid("ed26f923-8c38-4134-849d-a6140e4de09b"), (short)2, new Guid("3088a272-82f1-4091-aa76-9f46999917e9") }
                });

            migrationBuilder.InsertData(
                table: "StudySemesters",
                columns: new[] { "Id", "Semester", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("eca13127-0263-4d8d-b759-94f7a7e88d05"), (short)1, new Guid("3088a272-82f1-4091-aa76-9f46999917e9") },
                    { new Guid("9af328c3-aac9-4bd0-8568-015c31a8c609"), (short)1, new Guid("57389afc-ef32-4d78-b72c-63aeb9800b09") },
                    { new Guid("1603d021-f364-4d73-babe-5e856ac675d5"), (short)2, new Guid("7c37e31d-4f45-4491-81b0-34a92a43d1f1") },
                    { new Guid("07d9d4d4-5185-45bf-b283-dc190e1826b3"), (short)1, new Guid("2333eab3-edb2-4395-ae81-25b9d80a5973") },
                    { new Guid("03569ac8-58a2-4ad3-bcd4-ba9644e937ab"), (short)1, new Guid("d1740164-96ad-43b1-aaab-1ff5f0c39999") },
                    { new Guid("6e2b0444-3d1e-46f1-a0ad-3a4cfbe95be7"), (short)2, new Guid("8673cdd5-e71a-4c15-b3d2-dd53fce3605a") },
                    { new Guid("87b77344-a316-4c77-99f9-41250addcd61"), (short)1, new Guid("957ec602-b51c-4950-bda8-8f96a489a69c") },
                    { new Guid("83cf7fd6-cd82-4cb6-9628-3419e94ec34b"), (short)2, new Guid("b4c0f99c-77e9-49bd-ad36-474c51fcfc59") },
                    { new Guid("2072f780-9c6b-4862-b7af-95168bc778ef"), (short)2, new Guid("fb52b666-d8b4-4fa3-9d81-2d61127c66f8") },
                    { new Guid("5388f2c5-1fab-4389-a985-3677f94daead"), (short)1, new Guid("fb52b666-d8b4-4fa3-9d81-2d61127c66f8") },
                    { new Guid("f30cef0e-41fc-448b-a71f-05c111b8b242"), (short)1, new Guid("b4c0f99c-77e9-49bd-ad36-474c51fcfc59") },
                    { new Guid("80dae2db-7317-43e7-907c-a7857a3c0e75"), (short)1, new Guid("b67a502c-9da5-4e48-9e05-1064b2bf0764") },
                    { new Guid("6be7b7fd-7105-4644-8c87-b9d03d90da25"), (short)2, new Guid("b67a502c-9da5-4e48-9e05-1064b2bf0764") },
                    { new Guid("f0abf4b8-3745-4dd0-a284-36381c596ffa"), (short)2, new Guid("2333eab3-edb2-4395-ae81-25b9d80a5973") },
                    { new Guid("d337379f-541f-4903-9b61-a8b322a1019c"), (short)2, new Guid("957ec602-b51c-4950-bda8-8f96a489a69c") },
                    { new Guid("7552256a-27e6-4fb4-b917-ddb217f70b19"), (short)2, new Guid("ed4f24ce-cfad-489d-b725-6eb559449fa3") },
                    { new Guid("6ad24955-f9c8-4c82-82c4-eaecaf2d2923"), (short)1, new Guid("ebc64c61-b323-4bed-b776-14813ad9b255") },
                    { new Guid("48202fa1-64f2-426b-9ff3-ccdf4fd8a646"), (short)2, new Guid("39659841-222b-4029-8bb0-f5922c4b94a4") },
                    { new Guid("e9bd2432-807c-4760-92d1-b2f92b46ccde"), (short)1, new Guid("39659841-222b-4029-8bb0-f5922c4b94a4") },
                    { new Guid("60b9a783-2356-4763-8521-c2fc25855dcd"), (short)2, new Guid("ebc64c61-b323-4bed-b776-14813ad9b255") },
                    { new Guid("04797667-22c8-4a6b-bc3a-d8c64ad67cf9"), (short)2, new Guid("d1740164-96ad-43b1-aaab-1ff5f0c39999") },
                    { new Guid("3b6479bb-6042-47ed-baee-f644697ae02f"), (short)1, new Guid("8673cdd5-e71a-4c15-b3d2-dd53fce3605a") },
                    { new Guid("70e7dd31-beea-40a3-bb2e-a86cf0157423"), (short)1, new Guid("ed4f24ce-cfad-489d-b725-6eb559449fa3") },
                    { new Guid("acaf4765-f31a-411b-b91c-4a472f37baf9"), (short)2, new Guid("06314359-c6fa-497e-aa82-b0085d8f4aeb") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("0def7447-32ab-481d-9cf1-905d6c413961"), (short)4, "Course0", new Guid("2a48f4f1-2f4b-4ab3-8cb2-110759744719"), new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f") },
                    { new Guid("65765cd5-1582-492a-b53f-49349b9218e8"), (short)0, "Course14", new Guid("1603d021-f364-4d73-babe-5e856ac675d5"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("a8e0b5c4-090f-4aab-9951-cff898f7575e"), (short)4, "Course0", new Guid("e9bd2432-807c-4760-92d1-b2f92b46ccde"), new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("b63c575e-484f-427b-b7e3-6ba84485d18a"), (short)5, "Course24", new Guid("e9bd2432-807c-4760-92d1-b2f92b46ccde"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("4214734c-053b-4952-ab0d-1cc19cb5725c"), (short)5, "Course48", new Guid("e9bd2432-807c-4760-92d1-b2f92b46ccde"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("b1345efc-68ca-49a9-89ea-593ccc55aa07"), (short)2, "Course72", new Guid("e9bd2432-807c-4760-92d1-b2f92b46ccde"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("d597dd18-4f63-4305-920f-c2bda5c91987"), (short)0, "Course96", new Guid("e9bd2432-807c-4760-92d1-b2f92b46ccde"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("31ec2bf3-5ea2-48ca-bda6-00df1752c459"), (short)2, "Course120", new Guid("e9bd2432-807c-4760-92d1-b2f92b46ccde"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("b4327c3e-e556-4e4a-85b0-399717ecd13c"), (short)5, "Course7", new Guid("1603d021-f364-4d73-babe-5e856ac675d5"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("d1ef545e-9359-4a51-985d-beb69155394d"), (short)3, "Course0", new Guid("1603d021-f364-4d73-babe-5e856ac675d5"), new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") },
                    { new Guid("0fd73b51-ea34-4293-ae09-5bd769d75db1"), (short)3, "Course0", new Guid("48202fa1-64f2-426b-9ff3-ccdf4fd8a646"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("ae91d3c0-be86-4fb9-912d-1b2d4be55fa1"), (short)1, "Course25", new Guid("48202fa1-64f2-426b-9ff3-ccdf4fd8a646"), new Guid("22bce128-1398-4d69-82c1-227bbd4a2439") },
                    { new Guid("eaf26294-24f7-47fb-ba3a-17cfd471fb41"), (short)0, "Course50", new Guid("48202fa1-64f2-426b-9ff3-ccdf4fd8a646"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("0b8f860c-09f2-456b-8d10-3b9c535968f2"), (short)5, "Course75", new Guid("48202fa1-64f2-426b-9ff3-ccdf4fd8a646"), new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f") },
                    { new Guid("54a2b5f0-b301-46fc-9d94-2d595631046b"), (short)2, "Course100", new Guid("48202fa1-64f2-426b-9ff3-ccdf4fd8a646"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("33d528b2-1f9f-4fd2-a475-43a9e19553ea"), (short)3, "Course125", new Guid("48202fa1-64f2-426b-9ff3-ccdf4fd8a646"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("05a72e88-13d0-44f5-a02a-6ceae6d360b0"), (short)1, "Course0", new Guid("f30cef0e-41fc-448b-a71f-05c111b8b242"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("453c38c1-b666-4042-8b7f-4fcbbf2897d2"), (short)3, "Course26", new Guid("f30cef0e-41fc-448b-a71f-05c111b8b242"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("a7239024-00e6-4316-bed6-b61dd82f3abe"), (short)2, "Course52", new Guid("f30cef0e-41fc-448b-a71f-05c111b8b242"), new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("4dc0f244-f847-4d76-ba87-88d77bbb8ad5"), (short)0, "Course78", new Guid("f30cef0e-41fc-448b-a71f-05c111b8b242"), new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") },
                    { new Guid("b476a873-175b-4b8f-9601-b4cbd56a3ef5"), (short)5, "Course104", new Guid("f30cef0e-41fc-448b-a71f-05c111b8b242"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("ee5ed2c5-829d-408e-8202-cf5d00f707b3"), (short)1, "Course130", new Guid("f30cef0e-41fc-448b-a71f-05c111b8b242"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("4754999d-928e-4674-942e-fe5eae131715"), (short)1, "Course30", new Guid("b4758dc7-bdb9-4fac-89c3-29f7f2c39911"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("6443dc44-96d0-4e81-9521-839c0dd04dc3"), (short)4, "Course24", new Guid("b4758dc7-bdb9-4fac-89c3-29f7f2c39911"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("7c87761f-40fa-4e4f-9fa2-4bfa499f558e"), (short)1, "Course21", new Guid("1603d021-f364-4d73-babe-5e856ac675d5"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("d92e4ba2-8f81-487d-ad6f-42596f338c63"), (short)5, "Course175", new Guid("ed26f923-8c38-4134-849d-a6140e4de09b"), new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357") },
                    { new Guid("bcb64f7b-2cc3-4262-b5e6-76cf92fcd077"), (short)2, "Course140", new Guid("ed26f923-8c38-4134-849d-a6140e4de09b"), new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6") },
                    { new Guid("0b65dcb2-d615-4011-a9ad-e8ba62f677f5"), (short)2, "Course105", new Guid("ed26f923-8c38-4134-849d-a6140e4de09b"), new Guid("25ebd382-4646-40d7-8d67-a40c2779511d") },
                    { new Guid("548bef49-da4a-4a4e-9f06-4d9f2bde5292"), (short)4, "Course32", new Guid("7580bfe5-dcc3-405a-8c08-0ad9cc21012d"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("aebc75a8-3d65-4a69-b6a6-ff3eb0756184"), (short)1, "Course16", new Guid("15673aa4-8126-43c1-b047-855314b81bc0"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("51b49d9e-a556-4ff8-9b3f-1dad07146617"), (short)5, "Course96", new Guid("7580bfe5-dcc3-405a-8c08-0ad9cc21012d"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("5c53dc4a-b4a3-4469-a19a-4238a1cab25b"), (short)3, "Course128", new Guid("7580bfe5-dcc3-405a-8c08-0ad9cc21012d"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("8f9efc74-828c-4d0a-a187-850498c5475a"), (short)3, "Course160", new Guid("7580bfe5-dcc3-405a-8c08-0ad9cc21012d"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("0ab456d9-32e5-46a0-b082-aca1f6423406"), (short)1, "Course8", new Guid("9af328c3-aac9-4bd0-8568-015c31a8c609"), new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("0fc679c6-bb5a-4522-976d-6b2552a47e45"), (short)2, "Course0", new Guid("9af328c3-aac9-4bd0-8568-015c31a8c609"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("1e19c66e-4f3b-47fb-8c03-01d060c79a29"), (short)2, "Course0", new Guid("9cbd3a95-8630-4b50-8e01-ac1bbd7d76f9"), new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f") },
                    { new Guid("09a89b6a-8911-4972-bf2f-3c108694b318"), (short)4, "Course33", new Guid("9cbd3a95-8630-4b50-8e01-ac1bbd7d76f9"), new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") },
                    { new Guid("089f8bb8-6cd8-4317-b21b-421676fade89"), (short)5, "Course66", new Guid("9cbd3a95-8630-4b50-8e01-ac1bbd7d76f9"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("8fc85435-545e-4bef-adee-3cbe60ab3f8c"), (short)1, "Course99", new Guid("9cbd3a95-8630-4b50-8e01-ac1bbd7d76f9"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("c74503f2-dd2c-47b3-b403-0810836ca7c5"), (short)1, "Course0", new Guid("83cf7fd6-cd82-4cb6-9628-3419e94ec34b"), new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6") },
                    { new Guid("3ba59efa-f9b3-4234-b916-1c4bf446d695"), (short)3, "Course132", new Guid("9cbd3a95-8630-4b50-8e01-ac1bbd7d76f9"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("d158eef7-afd3-40d2-8390-7974d05d22e4"), (short)5, "Course0", new Guid("eca13127-0263-4d8d-b759-94f7a7e88d05"), new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("e178705c-b7cc-477b-aedb-2cfc2080f968"), (short)5, "Course34", new Guid("eca13127-0263-4d8d-b759-94f7a7e88d05"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("c16dcd0d-05ab-4547-bc41-1d804d41127c"), (short)5, "Course68", new Guid("eca13127-0263-4d8d-b759-94f7a7e88d05"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("d81b35b2-171e-4c54-89e9-3ca22557cc97"), (short)1, "Course102", new Guid("eca13127-0263-4d8d-b759-94f7a7e88d05"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") },
                    { new Guid("c3a79417-95eb-4129-88ba-80cc77f80fc3"), (short)5, "Course136", new Guid("eca13127-0263-4d8d-b759-94f7a7e88d05"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("065edf2f-6413-4176-bcaf-f9ce7440928b"), (short)0, "Course170", new Guid("eca13127-0263-4d8d-b759-94f7a7e88d05"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("424326da-4c8c-4da0-b6aa-413f24b1a99e"), (short)3, "Course35", new Guid("1603d021-f364-4d73-babe-5e856ac675d5"), new Guid("25ebd382-4646-40d7-8d67-a40c2779511d") },
                    { new Guid("34ae4e00-42fc-4315-946f-30f63f2f140e"), (short)0, "Course28", new Guid("1603d021-f364-4d73-babe-5e856ac675d5"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("c9b4b379-8414-4cfe-ae75-37b8ad43792a"), (short)4, "Course0", new Guid("ed26f923-8c38-4134-849d-a6140e4de09b"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("df309229-7cf8-4d4b-bb58-cc02d9b1594e"), (short)3, "Course35", new Guid("ed26f923-8c38-4134-849d-a6140e4de09b"), new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") },
                    { new Guid("3c6eadc8-27d5-40cf-9091-fc0e6bb58831"), (short)1, "Course70", new Guid("ed26f923-8c38-4134-849d-a6140e4de09b"), new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") },
                    { new Guid("7b0e6109-0877-4963-8140-9de2f1fed68e"), (short)1, "Course165", new Guid("9cbd3a95-8630-4b50-8e01-ac1bbd7d76f9"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("f72ab8d4-6fd7-48de-bfae-70d2de058289"), (short)5, "Course27", new Guid("83cf7fd6-cd82-4cb6-9628-3419e94ec34b"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") },
                    { new Guid("90fff920-f735-4a48-8c3d-3a956e2c093a"), (short)3, "Course54", new Guid("83cf7fd6-cd82-4cb6-9628-3419e94ec34b"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("d8fdc01a-1dcf-4436-9789-2bfa7a7147be"), (short)2, "Course81", new Guid("83cf7fd6-cd82-4cb6-9628-3419e94ec34b"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("2bff610d-7698-4e6f-85c8-780d6c2bdb6e"), (short)5, "Course2", new Guid("7552256a-27e6-4fb4-b917-ddb217f70b19"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("d80c0883-05e1-4620-8025-ddc0ad9e458d"), (short)1, "Course3", new Guid("7552256a-27e6-4fb4-b917-ddb217f70b19"), new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357") },
                    { new Guid("e1a562d5-a9aa-4cdd-962c-b2c9132c500d"), (short)0, "Course4", new Guid("7552256a-27e6-4fb4-b917-ddb217f70b19"), new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b") },
                    { new Guid("528a1696-2147-4739-9749-52625e4a20e9"), (short)0, "Course5", new Guid("7552256a-27e6-4fb4-b917-ddb217f70b19"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("a5c2031b-f6e7-4820-9c29-00985df9fc9b"), (short)0, "Course15", new Guid("c4f8f93c-40ce-41b1-b99f-3d2ff1749ec3"), new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6") },
                    { new Guid("0bb57faf-198d-40f4-959c-ce5f5ea7d4a6"), (short)1, "Course10", new Guid("c4f8f93c-40ce-41b1-b99f-3d2ff1749ec3"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") },
                    { new Guid("5e855979-45dc-4ee2-b65e-470d2c754573"), (short)4, "Course0", new Guid("3b6479bb-6042-47ed-baee-f644697ae02f"), new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6") },
                    { new Guid("e7575089-9108-4aa0-9645-4a100df0d180"), (short)5, "Course2", new Guid("3b6479bb-6042-47ed-baee-f644697ae02f"), new Guid("22bce128-1398-4d69-82c1-227bbd4a2439") },
                    { new Guid("7eaf0e66-aa29-4054-a6f3-c86470920fec"), (short)4, "Course4", new Guid("3b6479bb-6042-47ed-baee-f644697ae02f"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("a39fa61b-0280-408e-b7ed-aa8022125908"), (short)1, "Course6", new Guid("3b6479bb-6042-47ed-baee-f644697ae02f"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("b433fc46-a0b1-4734-9316-5b0f18103c56"), (short)4, "Course8", new Guid("3b6479bb-6042-47ed-baee-f644697ae02f"), new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") },
                    { new Guid("717f38ac-8611-43ef-b38b-4c930c334913"), (short)4, "Course1", new Guid("7552256a-27e6-4fb4-b917-ddb217f70b19"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("422d7d77-cc1e-4748-8a11-22953b8ee104"), (short)5, "Course10", new Guid("3b6479bb-6042-47ed-baee-f644697ae02f"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("4b1dcb4d-28d6-4a18-903c-3352361c8c84"), (short)4, "Course0", new Guid("c4f8f93c-40ce-41b1-b99f-3d2ff1749ec3"), new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b") },
                    { new Guid("1afbf401-7aad-4f01-ae35-ed9b077c5759"), (short)2, "Course0", new Guid("6e2b0444-3d1e-46f1-a0ad-3a4cfbe95be7"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("81b4e5b8-0edb-4fa9-aff0-8cb5999d03e5"), (short)5, "Course3", new Guid("6e2b0444-3d1e-46f1-a0ad-3a4cfbe95be7"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("3ebae0fd-3df7-4f7f-80eb-5a77d16666f0"), (short)0, "Course6", new Guid("6e2b0444-3d1e-46f1-a0ad-3a4cfbe95be7"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("e30d25f4-c1dd-484d-8710-01adc54f8b46"), (short)4, "Course9", new Guid("6e2b0444-3d1e-46f1-a0ad-3a4cfbe95be7"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("1ea77f73-81de-472b-9504-0077dc4959b1"), (short)4, "Course12", new Guid("6e2b0444-3d1e-46f1-a0ad-3a4cfbe95be7"), new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("a5ed0983-ac56-4159-ab33-c32c1de47135"), (short)2, "Course15", new Guid("6e2b0444-3d1e-46f1-a0ad-3a4cfbe95be7"), new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") },
                    { new Guid("35f18927-31b2-4935-ab60-61f8b07a6f44"), (short)4, "Course0", new Guid("15673aa4-8126-43c1-b047-855314b81bc0"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("e5fbbed4-b099-480b-aaa6-142475eba9ec"), (short)4, "Course4", new Guid("15673aa4-8126-43c1-b047-855314b81bc0"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("c7e7f8e0-3e0a-4983-95b2-2fd554224cda"), (short)0, "Course8", new Guid("15673aa4-8126-43c1-b047-855314b81bc0"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("5389ff5e-c63c-4c1e-ad17-856e9e409b44"), (short)5, "Course12", new Guid("15673aa4-8126-43c1-b047-855314b81bc0"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("66bb1f46-f3e4-4734-83ed-05e3438c4af9"), (short)5, "Course5", new Guid("c4f8f93c-40ce-41b1-b99f-3d2ff1749ec3"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") },
                    { new Guid("3040d948-3aa7-47c0-bd73-65eeb32187cf"), (short)4, "Course0", new Guid("7580bfe5-dcc3-405a-8c08-0ad9cc21012d"), new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("2937aa60-a1b7-453a-ad92-c2a66035d031"), (short)2, "Course0", new Guid("7552256a-27e6-4fb4-b917-ddb217f70b19"), new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6") },
                    { new Guid("7d421257-7152-4378-affa-ef1121075c3b"), (short)4, "Course25", new Guid("c4f8f93c-40ce-41b1-b99f-3d2ff1749ec3"), new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("c4c64407-c5b8-4e96-9520-813699fe5d69"), (short)3, "Course108", new Guid("83cf7fd6-cd82-4cb6-9628-3419e94ec34b"), new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("b6f78356-8f44-4d0e-b9c5-6c27a5e40294"), (short)2, "Course135", new Guid("83cf7fd6-cd82-4cb6-9628-3419e94ec34b"), new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f") },
                    { new Guid("35f70554-0234-4cb5-b160-64d8455781f2"), (short)4, "Course18", new Guid("b4758dc7-bdb9-4fac-89c3-29f7f2c39911"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("0cc4a65a-684b-42f9-a050-3379c05f63d5"), (short)2, "Course12", new Guid("b4758dc7-bdb9-4fac-89c3-29f7f2c39911"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("b28041dc-750d-45ab-8f8d-e831c155d282"), (short)5, "Course0", new Guid("80dae2db-7317-43e7-907c-a7857a3c0e75"), new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f") },
                    { new Guid("ec38080e-8ed7-4282-ba63-968c122763fb"), (short)3, "Course28", new Guid("80dae2db-7317-43e7-907c-a7857a3c0e75"), new Guid("22bce128-1398-4d69-82c1-227bbd4a2439") },
                    { new Guid("88bb07fa-cea9-41a8-a95c-9fc8ca790e36"), (short)3, "Course56", new Guid("80dae2db-7317-43e7-907c-a7857a3c0e75"), new Guid("25ebd382-4646-40d7-8d67-a40c2779511d") },
                    { new Guid("8fee1121-1080-4e02-b4b3-bc67b031ffeb"), (short)4, "Course84", new Guid("80dae2db-7317-43e7-907c-a7857a3c0e75"), new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f") },
                    { new Guid("db684a1b-2eef-463e-85b1-17db42347f7f"), (short)3, "Course112", new Guid("80dae2db-7317-43e7-907c-a7857a3c0e75"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("b89e2936-7b9b-44a9-8282-94854c298945"), (short)4, "Course140", new Guid("80dae2db-7317-43e7-907c-a7857a3c0e75"), new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6") },
                    { new Guid("803b0b73-b411-4a08-970d-41d9bc228698"), (short)4, "Course6", new Guid("b4758dc7-bdb9-4fac-89c3-29f7f2c39911"), new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357") },
                    { new Guid("4a5209f5-afc2-48a1-a39a-dd22003a68f6"), (short)2, "Course20", new Guid("c4f8f93c-40ce-41b1-b99f-3d2ff1749ec3"), new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f") },
                    { new Guid("60ee9bd0-d4d5-46ad-a7ac-2c5a20551a8d"), (short)5, "Course0", new Guid("b4758dc7-bdb9-4fac-89c3-29f7f2c39911"), new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357") },
                    { new Guid("b0a97486-71d9-41b2-80b4-d2c53ecf6569"), (short)3, "Course29", new Guid("6be7b7fd-7105-4644-8c87-b9d03d90da25"), new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357") },
                    { new Guid("115a9056-7522-4b55-a51a-bae84e954991"), (short)2, "Course58", new Guid("6be7b7fd-7105-4644-8c87-b9d03d90da25"), new Guid("22bce128-1398-4d69-82c1-227bbd4a2439") },
                    { new Guid("3417176e-cc64-4e64-8f03-3b2a74bf93f7"), (short)2, "Course87", new Guid("6be7b7fd-7105-4644-8c87-b9d03d90da25"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("242bf2e8-a913-4445-85b0-26822a2f51de"), (short)0, "Course116", new Guid("6be7b7fd-7105-4644-8c87-b9d03d90da25"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("68ae9ea0-06bb-44d9-a164-5684d2fb0cc2"), (short)5, "Course145", new Guid("6be7b7fd-7105-4644-8c87-b9d03d90da25"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("1b43296f-6e96-486a-9c7e-983a57a769b1"), (short)0, "Course0", new Guid("70e7dd31-beea-40a3-bb2e-a86cf0157423"), new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") },
                    { new Guid("f292d0a9-bac5-4389-9880-0fcb6fca63f3"), (short)0, "Course0", new Guid("70e7dd31-beea-40a3-bb2e-a86cf0157423"), new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("8c70c666-e382-418c-a8fb-50e221f72f69"), (short)3, "Course0", new Guid("70e7dd31-beea-40a3-bb2e-a86cf0157423"), new Guid("25ebd382-4646-40d7-8d67-a40c2779511d") },
                    { new Guid("4f37e225-4a3b-424b-805f-361967b267bc"), (short)4, "Course0", new Guid("70e7dd31-beea-40a3-bb2e-a86cf0157423"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("cea45bc0-ed63-4cec-b0bc-833f1cdeb955"), (short)4, "Course0", new Guid("70e7dd31-beea-40a3-bb2e-a86cf0157423"), new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("c6c8141b-cddf-4ba5-a3e6-13c2ed1e0607"), (short)4, "Course0", new Guid("70e7dd31-beea-40a3-bb2e-a86cf0157423"), new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") },
                    { new Guid("8977cf09-b01d-4a90-b816-91add9e90d55"), (short)1, "Course0", new Guid("6be7b7fd-7105-4644-8c87-b9d03d90da25"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("2d613563-3022-4684-9471-ce43baacc5a1"), (short)5, "Course16", new Guid("9af328c3-aac9-4bd0-8568-015c31a8c609"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("c2c8651a-67c5-4c5c-a004-ee7af5b5bb99"), (short)4, "Course64", new Guid("7580bfe5-dcc3-405a-8c08-0ad9cc21012d"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") },
                    { new Guid("293249b5-3966-4341-82a6-e90dd651e8c1"), (short)5, "Course155", new Guid("60b9a783-2356-4763-8521-c2fc25855dcd"), new Guid("25ebd382-4646-40d7-8d67-a40c2779511d") },
                    { new Guid("9a97c2fe-d7b0-4d21-af10-eeacd6078f95"), (short)1, "Course0", new Guid("03569ac8-58a2-4ad3-bcd4-ba9644e937ab"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("c8505dff-4f7e-4fb2-b424-9dfc59738289"), (short)2, "Course16", new Guid("03569ac8-58a2-4ad3-bcd4-ba9644e937ab"), new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6") },
                    { new Guid("74d45fd0-4832-4b94-8ac1-6f9e4cf92682"), (short)4, "Course32", new Guid("03569ac8-58a2-4ad3-bcd4-ba9644e937ab"), new Guid("25ebd382-4646-40d7-8d67-a40c2779511d") },
                    { new Guid("191fca39-580a-466f-b5b6-ac103aa0ef64"), (short)2, "Course48", new Guid("03569ac8-58a2-4ad3-bcd4-ba9644e937ab"), new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6") },
                    { new Guid("44e1c1c2-fefe-4180-a475-0e952bbd4935"), (short)3, "Course64", new Guid("03569ac8-58a2-4ad3-bcd4-ba9644e937ab"), new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b") },
                    { new Guid("60ce6b92-62d6-40dc-aa79-21c6fbe29c20"), (short)1, "Course80", new Guid("03569ac8-58a2-4ad3-bcd4-ba9644e937ab"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("d540bf69-f1ea-450b-a8cb-35413bfbea7e"), (short)3, "Course50", new Guid("61eb3cbe-5ee6-4691-9c2e-e2cb525dca24"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") },
                    { new Guid("8d6be354-36e9-4786-aaf5-b4b7ba0b98b5"), (short)3, "Course40", new Guid("61eb3cbe-5ee6-4691-9c2e-e2cb525dca24"), new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") },
                    { new Guid("23419b05-88e4-4273-8792-51e47bf97ee5"), (short)5, "Course0", new Guid("04797667-22c8-4a6b-bc3a-d8c64ad67cf9"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("da5c125f-43e2-4431-a7ce-708eed2aad5e"), (short)0, "Course17", new Guid("04797667-22c8-4a6b-bc3a-d8c64ad67cf9"), new Guid("25ebd382-4646-40d7-8d67-a40c2779511d") },
                    { new Guid("75994679-d556-4daf-b772-f2d34cda4d9d"), (short)0, "Course34", new Guid("04797667-22c8-4a6b-bc3a-d8c64ad67cf9"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("f223cf52-8bc7-4b9f-adea-f66b9fd20f06"), (short)3, "Course75", new Guid("e65b7433-ae92-4097-8663-b65fef19eb0a"), new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") },
                    { new Guid("9a3772b1-0ef2-4e05-93e6-8877ec655810"), (short)5, "Course51", new Guid("04797667-22c8-4a6b-bc3a-d8c64ad67cf9"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("f81b81e2-0be6-4650-b3e6-d27d10f39a5a"), (short)0, "Course85", new Guid("04797667-22c8-4a6b-bc3a-d8c64ad67cf9"), new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("e2bdf5c3-d0e1-448e-af9d-f444631d0f13"), (short)3, "Course30", new Guid("61eb3cbe-5ee6-4691-9c2e-e2cb525dca24"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("27a3d3f2-4849-401c-98fb-dd1723666c86"), (short)5, "Course20", new Guid("61eb3cbe-5ee6-4691-9c2e-e2cb525dca24"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("d16e7e47-ee86-42cb-8ef6-6297c1d545d8"), (short)3, "Course0", new Guid("5388f2c5-1fab-4389-a985-3677f94daead"), new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") },
                    { new Guid("315807bc-3432-4fcd-9149-9d9fe41f5d7c"), (short)3, "Course18", new Guid("5388f2c5-1fab-4389-a985-3677f94daead"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("a4071214-3d7e-48d7-a49a-9dcea44f55ad"), (short)3, "Course36", new Guid("5388f2c5-1fab-4389-a985-3677f94daead"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("024bf998-be1a-4bf9-9b91-0253ed48ad9a"), (short)2, "Course54", new Guid("5388f2c5-1fab-4389-a985-3677f94daead"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("0cc1e0f3-6542-494c-80e8-baefb5c7373b"), (short)5, "Course72", new Guid("5388f2c5-1fab-4389-a985-3677f94daead"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("f6ad26c5-55f4-4ed6-a20f-4ab41134bd92"), (short)3, "Course90", new Guid("5388f2c5-1fab-4389-a985-3677f94daead"), new Guid("22bce128-1398-4d69-82c1-227bbd4a2439") },
                    { new Guid("60bd24ad-daea-4719-ae80-3e25bdd7ca45"), (short)4, "Course24", new Guid("9af328c3-aac9-4bd0-8568-015c31a8c609"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("d165987a-db36-422c-af60-a3091e70df43"), (short)1, "Course0", new Guid("61eb3cbe-5ee6-4691-9c2e-e2cb525dca24"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("17ef7042-9506-4eba-9e26-4d4365ad4d99"), (short)5, "Course68", new Guid("04797667-22c8-4a6b-bc3a-d8c64ad67cf9"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("22bee928-00a4-4e3f-acd7-1379763a225b"), (short)3, "Course60", new Guid("e65b7433-ae92-4097-8663-b65fef19eb0a"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("6701641c-b3ee-47df-b14e-0428d98a9555"), (short)0, "Course45", new Guid("e65b7433-ae92-4097-8663-b65fef19eb0a"), new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6") },
                    { new Guid("f5daee95-034a-46a4-9b3f-f69df388168f"), (short)1, "Course30", new Guid("e65b7433-ae92-4097-8663-b65fef19eb0a"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("bd7239f2-1ce1-4f91-8116-7ff96c04efbc"), (short)1, "Course12", new Guid("2a48f4f1-2f4b-4ab3-8cb2-110759744719"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("15a29671-68dd-4fc5-9b83-75341f269ea1"), (short)3, "Course24", new Guid("2a48f4f1-2f4b-4ab3-8cb2-110759744719"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("2c2c6778-a099-498a-8c84-aa0865e05308"), (short)3, "Course36", new Guid("2a48f4f1-2f4b-4ab3-8cb2-110759744719"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("d6d5abe9-9b2e-43fa-bbf0-7e1d6810bdc5"), (short)3, "Course48", new Guid("2a48f4f1-2f4b-4ab3-8cb2-110759744719"), new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6") },
                    { new Guid("11aa98ed-89f4-45ca-b22f-b48ca68f2cd7"), (short)1, "Course60", new Guid("2a48f4f1-2f4b-4ab3-8cb2-110759744719"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("b62b1cc8-f11a-4e8d-950c-e4ac193abd04"), (short)2, "Course55", new Guid("acaf4765-f31a-411b-b91c-4a472f37baf9"), new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") },
                    { new Guid("0aa934d3-b028-41a8-aa70-e2c67e4c03ae"), (short)3, "Course44", new Guid("acaf4765-f31a-411b-b91c-4a472f37baf9"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("c40c9fa0-fa36-49e3-81b5-56c1f6c79f8e"), (short)1, "Course0", new Guid("c9b5df91-23b1-4d72-8392-5af38ca94806"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("ce538069-a9d7-48c3-ad21-09c1a308a520"), (short)3, "Course13", new Guid("c9b5df91-23b1-4d72-8392-5af38ca94806"), new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f") },
                    { new Guid("4c777b80-aadf-45c1-abb9-aeedd4962dd5"), (short)3, "Course26", new Guid("c9b5df91-23b1-4d72-8392-5af38ca94806"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("d12e37e1-ba4c-48f9-85ad-7b46acee01b4"), (short)2, "Course39", new Guid("c9b5df91-23b1-4d72-8392-5af38ca94806"), new Guid("25ebd382-4646-40d7-8d67-a40c2779511d") },
                    { new Guid("90ed04d8-c821-44a1-9aab-f4383bad0405"), (short)3, "Course52", new Guid("c9b5df91-23b1-4d72-8392-5af38ca94806"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("6da5dc3c-3fbb-4806-9fd2-063e16bc7ddc"), (short)2, "Course65", new Guid("c9b5df91-23b1-4d72-8392-5af38ca94806"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("cc15bf79-018b-401e-95ed-35caa753014a"), (short)2, "Course33", new Guid("acaf4765-f31a-411b-b91c-4a472f37baf9"), new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357") },
                    { new Guid("1ce2306f-7ece-4b2c-b4c6-e3bc7c8cfed3"), (short)4, "Course22", new Guid("acaf4765-f31a-411b-b91c-4a472f37baf9"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("e6fd24fa-7956-4a16-ae0c-f067e9a2c3f0"), (short)1, "Course0", new Guid("28166599-9455-408b-a091-0cf8f68b9793"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("d6e7ddc5-d2aa-4563-a52e-0d8f1bd0cbce"), (short)5, "Course14", new Guid("28166599-9455-408b-a091-0cf8f68b9793"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("40317028-fb37-40fd-90eb-03b1a71eae7a"), (short)2, "Course28", new Guid("28166599-9455-408b-a091-0cf8f68b9793"), new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("1551cb8c-235c-4b26-8e80-67d823c149ed"), (short)0, "Course42", new Guid("28166599-9455-408b-a091-0cf8f68b9793"), new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357") },
                    { new Guid("74c6230c-7dcb-40aa-b3f5-bea32df93899"), (short)4, "Course56", new Guid("28166599-9455-408b-a091-0cf8f68b9793"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("cac47508-4e1f-40da-a5c4-3d64a1ca3e22"), (short)3, "Course70", new Guid("28166599-9455-408b-a091-0cf8f68b9793"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("37efb670-d868-4047-b738-763decf11cb2"), (short)0, "Course11", new Guid("acaf4765-f31a-411b-b91c-4a472f37baf9"), new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357") },
                    { new Guid("e6f97912-82eb-4561-8e10-8ac2d7961f83"), (short)4, "Course0", new Guid("acaf4765-f31a-411b-b91c-4a472f37baf9"), new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f") },
                    { new Guid("97cad48f-99b2-4608-93d4-8cc6baae0a9b"), (short)2, "Course0", new Guid("e65b7433-ae92-4097-8663-b65fef19eb0a"), new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b") },
                    { new Guid("0cbfedca-dd07-40a3-9c0e-56f5ab9c9a51"), (short)4, "Course15", new Guid("e65b7433-ae92-4097-8663-b65fef19eb0a"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("7b948248-f556-4051-86f0-d4bccb42afdf"), (short)3, "Course0", new Guid("2072f780-9c6b-4862-b7af-95168bc778ef"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("da20a8b6-f692-4d50-a9bb-df79a53462a2"), (short)5, "Course19", new Guid("2072f780-9c6b-4862-b7af-95168bc778ef"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("75b8c4da-3045-42e6-a868-6ea7a4028a9f"), (short)3, "Course10", new Guid("61eb3cbe-5ee6-4691-9c2e-e2cb525dca24"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("1881121c-5ec1-4e72-9d15-26006165f151"), (short)1, "Course57", new Guid("2072f780-9c6b-4862-b7af-95168bc778ef"), new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("4e164eae-9520-425c-a6cf-d36102ad8b27"), (short)1, "Course88", new Guid("87b77344-a316-4c77-99f9-41250addcd61"), new Guid("22bce128-1398-4d69-82c1-227bbd4a2439") },
                    { new Guid("de9796d7-bfc3-478a-b205-e32b1514ab7a"), (short)0, "Course110", new Guid("87b77344-a316-4c77-99f9-41250addcd61"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("fd09a277-82b2-44bc-aff3-accb4a275f4e"), (short)1, "Course9", new Guid("aa0bfda2-b72d-4fff-b25d-de42c1458839"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("04f01d38-50e5-4f6c-982c-1a4fba9d6c3d"), (short)0, "Course0", new Guid("aa0bfda2-b72d-4fff-b25d-de42c1458839"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("620c593b-683d-46bd-9505-8168df2abc4e"), (short)5, "Course0", new Guid("d337379f-541f-4903-9b61-a8b322a1019c"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") },
                    { new Guid("c4bf5503-1a25-44ef-9953-e71dae893ff5"), (short)5, "Course23", new Guid("d337379f-541f-4903-9b61-a8b322a1019c"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("0f3d5b5c-db25-4265-987c-d95ad43df64e"), (short)0, "Course46", new Guid("d337379f-541f-4903-9b61-a8b322a1019c"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("85f3e497-270c-4885-b21a-0bf602cd1679"), (short)3, "Course69", new Guid("d337379f-541f-4903-9b61-a8b322a1019c"), new Guid("25ebd382-4646-40d7-8d67-a40c2779511d") },
                    { new Guid("16677d5b-00b9-4de7-ba4e-fe830c37addd"), (short)1, "Course92", new Guid("d337379f-541f-4903-9b61-a8b322a1019c"), new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b") },
                    { new Guid("48bdbf65-a9a8-4328-b925-959c6f1ee077"), (short)2, "Course115", new Guid("d337379f-541f-4903-9b61-a8b322a1019c"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("6440e233-88b7-47bc-be24-2029b56cfae9"), (short)5, "Course0", new Guid("6ad24955-f9c8-4c82-82c4-eaecaf2d2923"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("ad8643e2-4e85-4536-8230-141aa46213a9"), (short)4, "Course30", new Guid("6ad24955-f9c8-4c82-82c4-eaecaf2d2923"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("7262b2c9-396e-43b4-b2ec-6debf147d93c"), (short)1, "Course60", new Guid("6ad24955-f9c8-4c82-82c4-eaecaf2d2923"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("454ece4f-796b-4961-a808-d2e353c4afe4"), (short)0, "Course90", new Guid("6ad24955-f9c8-4c82-82c4-eaecaf2d2923"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("4f23415f-f74b-46bb-bee9-2bd5bec67514"), (short)1, "Course120", new Guid("6ad24955-f9c8-4c82-82c4-eaecaf2d2923"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("57ff5424-0587-4813-a110-6c4c3ea3fc81"), (short)3, "Course150", new Guid("6ad24955-f9c8-4c82-82c4-eaecaf2d2923"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("c0163e6b-e686-4644-8480-61ddc362cf27"), (short)5, "Course40", new Guid("9af328c3-aac9-4bd0-8568-015c31a8c609"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("8863fff2-6388-4711-b919-a6c4d0cb0975"), (short)3, "Course32", new Guid("9af328c3-aac9-4bd0-8568-015c31a8c609"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("c092ad42-57f9-4ac0-86b4-acba4feb6fae"), (short)1, "Course0", new Guid("60b9a783-2356-4763-8521-c2fc25855dcd"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("a4fbd99d-bda4-419a-85a9-8a0068fe6881"), (short)4, "Course31", new Guid("60b9a783-2356-4763-8521-c2fc25855dcd"), new Guid("22bce128-1398-4d69-82c1-227bbd4a2439") },
                    { new Guid("f9e6f9a6-68d7-46af-95b1-0c22fe1e0476"), (short)4, "Course62", new Guid("60b9a783-2356-4763-8521-c2fc25855dcd"), new Guid("25ebd382-4646-40d7-8d67-a40c2779511d") },
                    { new Guid("c359f80a-df41-4a34-ba83-3f35fe5a2a84"), (short)1, "Course93", new Guid("60b9a783-2356-4763-8521-c2fc25855dcd"), new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") },
                    { new Guid("938a64c5-7572-4e61-8cd8-77053377d6b6"), (short)3, "Course124", new Guid("60b9a783-2356-4763-8521-c2fc25855dcd"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("cdcbab77-269e-471f-b914-8a6280bdcdcf"), (short)0, "Course38", new Guid("2072f780-9c6b-4862-b7af-95168bc778ef"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("e1304a75-83d6-4430-8d04-f67fa28d5599"), (short)0, "Course44", new Guid("87b77344-a316-4c77-99f9-41250addcd61"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("a35d4345-3d4e-441c-b461-bb70dbb81c2a"), (short)4, "Course66", new Guid("87b77344-a316-4c77-99f9-41250addcd61"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("1b9d976f-6b48-4711-b32f-b31deb152a5d"), (short)0, "Course20", new Guid("15673aa4-8126-43c1-b047-855314b81bc0"), new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357") },
                    { new Guid("15fb3f6c-c025-4531-bdea-40b803e6560a"), (short)1, "Course40", new Guid("07d9d4d4-5185-45bf-b283-dc190e1826b3"), new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f") },
                    { new Guid("2a49f6ca-9448-4a17-bb51-6f78f0cf8bc9"), (short)1, "Course60", new Guid("07d9d4d4-5185-45bf-b283-dc190e1826b3"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("de6d058d-3320-456c-b766-4dd30ebeb4af"), (short)4, "Course80", new Guid("07d9d4d4-5185-45bf-b283-dc190e1826b3"), new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") },
                    { new Guid("6d4a36ac-6c7b-4fcb-9fc9-491f83ec4ff8"), (short)2, "Course100", new Guid("07d9d4d4-5185-45bf-b283-dc190e1826b3"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("197b4d87-1a6e-4381-a848-e5323ae47869"), (short)2, "Course45", new Guid("aa0bfda2-b72d-4fff-b25d-de42c1458839"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("e5dd9947-42a7-446a-965c-34dd966f6361"), (short)4, "Course22", new Guid("87b77344-a316-4c77-99f9-41250addcd61"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("fe45f3b9-e566-4b37-9fce-7943e4345d16"), (short)1, "Course36", new Guid("aa0bfda2-b72d-4fff-b25d-de42c1458839"), new Guid("22bce128-1398-4d69-82c1-227bbd4a2439") },
                    { new Guid("cc235b05-a11f-4b95-9865-f9f2a9dc60c3"), (short)5, "Course20", new Guid("07d9d4d4-5185-45bf-b283-dc190e1826b3"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") },
                    { new Guid("fc314fed-2892-4230-9d1b-ebedae42284e"), (short)2, "Course21", new Guid("f0abf4b8-3745-4dd0-a284-36381c596ffa"), new Guid("25ebd382-4646-40d7-8d67-a40c2779511d") },
                    { new Guid("7d6446fa-457d-40b0-beaf-149028b03227"), (short)5, "Course0", new Guid("f0abf4b8-3745-4dd0-a284-36381c596ffa"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("2380a6a9-91f6-42e4-b062-06cc2753dcb6"), (short)0, "Course63", new Guid("f0abf4b8-3745-4dd0-a284-36381c596ffa"), new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("c9c4ed44-1ad1-4216-9f00-9e85522e1d70"), (short)3, "Course84", new Guid("f0abf4b8-3745-4dd0-a284-36381c596ffa"), new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") },
                    { new Guid("3cb31a5c-fc0d-43b6-beab-40b5e73d7dd2"), (short)3, "Course105", new Guid("f0abf4b8-3745-4dd0-a284-36381c596ffa"), new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357") },
                    { new Guid("a83d7f35-54ff-4683-8931-d3a30596a72d"), (short)4, "Course27", new Guid("aa0bfda2-b72d-4fff-b25d-de42c1458839"), new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("99fa7775-b6fe-41f6-bd2b-650e8d1f3f42"), (short)3, "Course95", new Guid("2072f780-9c6b-4862-b7af-95168bc778ef"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("227ef423-560c-436e-b6ef-c56e1a3bdaa0"), (short)1, "Course18", new Guid("aa0bfda2-b72d-4fff-b25d-de42c1458839"), new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357") },
                    { new Guid("116cf99f-1472-45b3-9cb6-f7a9bb3575f3"), (short)0, "Course0", new Guid("87b77344-a316-4c77-99f9-41250addcd61"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("9802b0cf-477e-41b1-b8f5-9e25987b2ed0"), (short)2, "Course76", new Guid("2072f780-9c6b-4862-b7af-95168bc778ef"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("70a795a1-230c-486d-955a-8fed07758397"), (short)0, "Course42", new Guid("f0abf4b8-3745-4dd0-a284-36381c596ffa"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("62d1a5b0-f3b1-4e52-aefc-d97feaed5533"), (short)5, "Course0", new Guid("07d9d4d4-5185-45bf-b283-dc190e1826b3"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") }
                });

            migrationBuilder.InsertData(
                table: "OptionalCourses",
                columns: new[] { "Id", "Credits", "MaxNumberOfStudent", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("bb407ab4-cb82-416d-9154-2e9b109eeac8"), (short)5, 20, "Course0", new Guid("aa0bfda2-b72d-4fff-b25d-de42c1458839"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("f9467108-a973-4ed5-a0a2-02647dcbd607"), (short)0, 20, "Course0", new Guid("15673aa4-8126-43c1-b047-855314b81bc0"), new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") },
                    { new Guid("b89b5130-0c22-4ca8-aa63-4e2ec3b59413"), (short)5, 20, "Course4", new Guid("15673aa4-8126-43c1-b047-855314b81bc0"), new Guid("3e5465ba-cf94-494d-81cf-dbcb6662e357") },
                    { new Guid("36318065-6873-4e75-a0f8-a8b802536f9e"), (short)4, 20, "Course9", new Guid("aa0bfda2-b72d-4fff-b25d-de42c1458839"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("f2d7ffc1-b4f1-44ec-9ae3-a3bf50bdc7db"), (short)3, 20, "Course0", new Guid("9af328c3-aac9-4bd0-8568-015c31a8c609"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("b91d2ebe-053e-4a37-b288-2208ae367415"), (short)5, 20, "Course6", new Guid("b4758dc7-bdb9-4fac-89c3-29f7f2c39911"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("f808cd74-8b25-4424-a0f8-bd039cfe87f8"), (short)2, 20, "Course7", new Guid("1603d021-f364-4d73-babe-5e856ac675d5"), new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") },
                    { new Guid("70706b38-d838-4e94-be1f-d3e9f93af540"), (short)4, 20, "Course0", new Guid("1603d021-f364-4d73-babe-5e856ac675d5"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") },
                    { new Guid("329c4560-62ee-47af-abb6-7607dd7ae35a"), (short)2, 20, "Course8", new Guid("9af328c3-aac9-4bd0-8568-015c31a8c609"), new Guid("22bce128-1398-4d69-82c1-227bbd4a2439") },
                    { new Guid("a8853243-fbb4-4330-907b-502b1f1dd5f7"), (short)3, 20, "Course5", new Guid("c4f8f93c-40ce-41b1-b99f-3d2ff1749ec3"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("d92e2779-e05d-4ef1-b897-bfb06a84a5e0"), (short)4, 20, "Course0", new Guid("c4f8f93c-40ce-41b1-b99f-3d2ff1749ec3"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("c96bdb7e-82fa-4ae6-8935-734b5d215a01"), (short)2, 20, "Course10", new Guid("61eb3cbe-5ee6-4691-9c2e-e2cb525dca24"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("8be9964f-a67b-4780-9337-60ec615cad11"), (short)3, 20, "Course0", new Guid("b4758dc7-bdb9-4fac-89c3-29f7f2c39911"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("a861da02-f184-44b8-9f46-7953a0ac65cc"), (short)4, 20, "Course0", new Guid("61eb3cbe-5ee6-4691-9c2e-e2cb525dca24"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") },
                    { new Guid("e14de5bf-9f22-476b-a5f3-252a7f92a5db"), (short)2, 20, "Course35", new Guid("ed26f923-8c38-4134-849d-a6140e4de09b"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("c9f53e2a-46b9-46eb-9733-632aa99fdce1"), (short)1, 20, "Course0", new Guid("6e2b0444-3d1e-46f1-a0ad-3a4cfbe95be7"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("a0f1a828-f6f9-4153-baf5-7398ddb2b6e4"), (short)3, 20, "Course0", new Guid("6ad24955-f9c8-4c82-82c4-eaecaf2d2923"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("2515d430-d1e0-4e5f-a43c-eeaa48a0c45a"), (short)0, 20, "Course23", new Guid("d337379f-541f-4903-9b61-a8b322a1019c"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("179faa55-0ef8-47fe-8124-11c476568074"), (short)0, 20, "Course0", new Guid("d337379f-541f-4903-9b61-a8b322a1019c"), new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("664ed1b7-56e4-414d-871c-3146df861285"), (short)5, 20, "Course22", new Guid("87b77344-a316-4c77-99f9-41250addcd61"), new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f") },
                    { new Guid("bc47feb8-897c-48c5-9511-5e9c17634523"), (short)5, 20, "Course0", new Guid("87b77344-a316-4c77-99f9-41250addcd61"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("5c0ec2a8-5b1a-4dbe-a60f-9a9c3b8bf1c7"), (short)4, 20, "Course21", new Guid("f0abf4b8-3745-4dd0-a284-36381c596ffa"), new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") },
                    { new Guid("80fb9c08-f388-4d50-a6cf-c0ff76453384"), (short)5, 20, "Course0", new Guid("f0abf4b8-3745-4dd0-a284-36381c596ffa"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("f283b969-31b6-4538-b23d-4696059bc167"), (short)1, 20, "Course20", new Guid("07d9d4d4-5185-45bf-b283-dc190e1826b3"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("1f6c8d33-06dd-42e0-a446-0b21eb8f084c"), (short)0, 20, "Course0", new Guid("07d9d4d4-5185-45bf-b283-dc190e1826b3"), new Guid("95ca0b24-1df0-4e75-8c30-808bf001313f") },
                    { new Guid("ebd9e833-97de-4518-937c-0ce20e8de5fb"), (short)5, 20, "Course19", new Guid("2072f780-9c6b-4862-b7af-95168bc778ef"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("c4522fec-2a4f-4efc-901f-773ffc45286c"), (short)0, 20, "Course0", new Guid("2072f780-9c6b-4862-b7af-95168bc778ef"), new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b") },
                    { new Guid("a7b5c435-b5fa-4329-b60a-80f423aa0c2f"), (short)5, 20, "Course18", new Guid("5388f2c5-1fab-4389-a985-3677f94daead"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("ba16951d-c886-4adf-9179-e7a027011c4f"), (short)4, 20, "Course0", new Guid("5388f2c5-1fab-4389-a985-3677f94daead"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("84dd3636-2cc7-40d9-877a-024f322b7ec2"), (short)0, 20, "Course17", new Guid("04797667-22c8-4a6b-bc3a-d8c64ad67cf9"), new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") },
                    { new Guid("2eb6f8a9-3c01-4a96-94e4-71f7703c011e"), (short)4, 20, "Course0", new Guid("04797667-22c8-4a6b-bc3a-d8c64ad67cf9"), new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b") },
                    { new Guid("06540d95-2cd7-4321-963a-49241028ee2d"), (short)3, 20, "Course16", new Guid("03569ac8-58a2-4ad3-bcd4-ba9644e937ab"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") },
                    { new Guid("cf744660-3809-428a-865a-21c1a29e481c"), (short)5, 20, "Course0", new Guid("03569ac8-58a2-4ad3-bcd4-ba9644e937ab"), new Guid("f052ae94-ba5a-4197-b978-520328996d6a") },
                    { new Guid("264d085b-53bb-4bb8-bd70-f207c8829b30"), (short)1, 20, "Course15", new Guid("e65b7433-ae92-4097-8663-b65fef19eb0a"), new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b") },
                    { new Guid("d4d4684d-8836-4b11-b0cc-86c979f4b8fc"), (short)3, 20, "Course0", new Guid("e65b7433-ae92-4097-8663-b65fef19eb0a"), new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") },
                    { new Guid("4fd9fcbb-267e-4fbb-99f7-dd18d2aa9786"), (short)4, 20, "Course14", new Guid("28166599-9455-408b-a091-0cf8f68b9793"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") }
                });

            migrationBuilder.InsertData(
                table: "OptionalCourses",
                columns: new[] { "Id", "Credits", "MaxNumberOfStudent", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("54308ae4-64eb-4e66-8436-22e93815c895"), (short)5, 20, "Course0", new Guid("28166599-9455-408b-a091-0cf8f68b9793"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("488bed48-4362-4cd5-98c3-a69f19faf517"), (short)3, 20, "Course13", new Guid("c9b5df91-23b1-4d72-8392-5af38ca94806"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("7a9150b9-1b06-469d-9fc5-70066bec3bbe"), (short)0, 20, "Course0", new Guid("c9b5df91-23b1-4d72-8392-5af38ca94806"), new Guid("88e2c1c6-413f-4b9f-8d65-74a8ad4bd295") },
                    { new Guid("ef25218d-6606-4f4a-89c0-5728995f65ce"), (short)1, 20, "Course12", new Guid("2a48f4f1-2f4b-4ab3-8cb2-110759744719"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("5a008051-73f4-4c96-96a0-cce72d98b0dc"), (short)3, 20, "Course0", new Guid("2a48f4f1-2f4b-4ab3-8cb2-110759744719"), new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6") },
                    { new Guid("1171290a-7d87-4cdc-8fdf-023922986557"), (short)4, 20, "Course30", new Guid("6ad24955-f9c8-4c82-82c4-eaecaf2d2923"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("946abd82-4c56-485a-a2a0-ce79c60691bb"), (short)0, 20, "Course3", new Guid("6e2b0444-3d1e-46f1-a0ad-3a4cfbe95be7"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("6853d5d7-63cc-4d44-947d-b457b30ba469"), (short)2, 20, "Course0", new Guid("60b9a783-2356-4763-8521-c2fc25855dcd"), new Guid("22bce128-1398-4d69-82c1-227bbd4a2439") },
                    { new Guid("aad38d29-7bf5-4d61-b7be-bf048da0d42f"), (short)4, 20, "Course0", new Guid("7580bfe5-dcc3-405a-8c08-0ad9cc21012d"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("bb896fcd-a9c3-4b52-9064-c390e47b51d0"), (short)3, 20, "Course2", new Guid("3b6479bb-6042-47ed-baee-f644697ae02f"), new Guid("867dc420-1bd5-4718-a6b8-ed48dfbe63bf") },
                    { new Guid("0299b5a4-08d1-4d38-8877-ff0aac1d1521"), (short)3, 20, "Course0", new Guid("3b6479bb-6042-47ed-baee-f644697ae02f"), new Guid("1212bca1-8f68-45e4-8a91-572adec7b855") },
                    { new Guid("1b01561d-2848-4f55-b7a4-13fe8f24ed27"), (short)5, 20, "Course1", new Guid("7552256a-27e6-4fb4-b917-ddb217f70b19"), new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") },
                    { new Guid("5e85550e-e19a-4510-b84d-953e8fad4850"), (short)0, 20, "Course0", new Guid("7552256a-27e6-4fb4-b917-ddb217f70b19"), new Guid("d3d1a846-53af-4a97-b06d-c80b85f17a52") },
                    { new Guid("c69e2f5e-55ef-457d-ba06-668b33f63164"), (short)0, 20, "Course0", new Guid("70e7dd31-beea-40a3-bb2e-a86cf0157423"), new Guid("ca491632-d329-4e9a-aec8-76e1a7f3d62e") },
                    { new Guid("3714923f-cf5b-4b87-a682-9bfa3045e16a"), (short)1, 20, "Course0", new Guid("70e7dd31-beea-40a3-bb2e-a86cf0157423"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") },
                    { new Guid("47821439-2ef5-4725-be2c-b9dd7575e163"), (short)3, 20, "Course29", new Guid("6be7b7fd-7105-4644-8c87-b9d03d90da25"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("a8333c09-7c9d-4a39-81c5-2754d5d3048e"), (short)4, 20, "Course0", new Guid("6be7b7fd-7105-4644-8c87-b9d03d90da25"), new Guid("966e203b-a530-4a6a-a8c6-1f260a5cf456") },
                    { new Guid("5447ae2f-9185-4308-bfde-36273a7dd637"), (short)3, 20, "Course28", new Guid("80dae2db-7317-43e7-907c-a7857a3c0e75"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("dbe17214-3bda-4587-8fbc-1926f069d559"), (short)1, 20, "Course0", new Guid("80dae2db-7317-43e7-907c-a7857a3c0e75"), new Guid("78870c95-e041-41c2-84e1-157b6fbcfad6") },
                    { new Guid("b981f528-f3e8-48d6-9bad-db3deb6d777e"), (short)0, 20, "Course27", new Guid("83cf7fd6-cd82-4cb6-9628-3419e94ec34b"), new Guid("201dd550-d0ba-4662-9c63-9a4bc6314df5") },
                    { new Guid("d5fb859b-a927-4286-85d9-27c018471b98"), (short)4, 20, "Course0", new Guid("83cf7fd6-cd82-4cb6-9628-3419e94ec34b"), new Guid("22bce128-1398-4d69-82c1-227bbd4a2439") },
                    { new Guid("c952e1ae-0f88-4625-b7df-58fb5a603b44"), (short)4, 20, "Course26", new Guid("f30cef0e-41fc-448b-a71f-05c111b8b242"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("c703a972-f923-472a-a567-1f4c7b861ee2"), (short)0, 20, "Course0", new Guid("f30cef0e-41fc-448b-a71f-05c111b8b242"), new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b") },
                    { new Guid("e5db6af0-b51e-4ad8-8246-08b2091b3f23"), (short)4, 20, "Course25", new Guid("48202fa1-64f2-426b-9ff3-ccdf4fd8a646"), new Guid("37fa7eae-8cc4-4d8e-ad54-697f58469458") },
                    { new Guid("47489b22-bd13-4672-9d1f-b2419ffb410b"), (short)1, 20, "Course0", new Guid("48202fa1-64f2-426b-9ff3-ccdf4fd8a646"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("b848ccd2-abbf-42f3-aba7-2578bc7299ac"), (short)1, 20, "Course24", new Guid("e9bd2432-807c-4760-92d1-b2f92b46ccde"), new Guid("25ebd382-4646-40d7-8d67-a40c2779511d") },
                    { new Guid("0cb83019-99a3-4b9e-b0db-ee5aa33b885b"), (short)5, 20, "Course0", new Guid("e9bd2432-807c-4760-92d1-b2f92b46ccde"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") },
                    { new Guid("55f8ddc3-242c-4877-a565-acdc6df6f1ec"), (short)4, 20, "Course0", new Guid("acaf4765-f31a-411b-b91c-4a472f37baf9"), new Guid("3b5678da-f213-48ea-8d8d-d4ca86a79e5f") },
                    { new Guid("246bb696-32a4-46af-bfda-e15b320c0dd6"), (short)2, 20, "Course0", new Guid("ed26f923-8c38-4134-849d-a6140e4de09b"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("78c9cc13-1672-44cc-b8a5-7d9d44bf810c"), (short)1, 20, "Course34", new Guid("eca13127-0263-4d8d-b759-94f7a7e88d05"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("04f0e0bc-0b49-44c9-80ca-c7f8ad740069"), (short)3, 20, "Course0", new Guid("eca13127-0263-4d8d-b759-94f7a7e88d05"), new Guid("40772272-1210-4378-98bd-e829841f6b0c") },
                    { new Guid("e3dce969-3138-491f-8c35-d8edb4fe0830"), (short)2, 20, "Course33", new Guid("9cbd3a95-8630-4b50-8e01-ac1bbd7d76f9"), new Guid("ad2ac258-15ef-4d76-9f7f-545861a73337") },
                    { new Guid("4fca6fc0-21e0-4bd8-9b80-5c9714ba0492"), (short)0, 20, "Course0", new Guid("9cbd3a95-8630-4b50-8e01-ac1bbd7d76f9"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("059bf253-2319-4dd1-b165-a4f657f9e701"), (short)4, 20, "Course32", new Guid("7580bfe5-dcc3-405a-8c08-0ad9cc21012d"), new Guid("d50e4bcc-8350-4d6a-9dbf-c303a203f74b") },
                    { new Guid("8481d187-91d9-4867-8e4a-05ea555b8888"), (short)1, 20, "Course31", new Guid("60b9a783-2356-4763-8521-c2fc25855dcd"), new Guid("a5ee91bf-1e0e-4fe3-a01e-2f9fca600747") },
                    { new Guid("ce6ca2e8-9f5a-4031-9ae8-1abb969b3a7f"), (short)3, 20, "Course11", new Guid("acaf4765-f31a-411b-b91c-4a472f37baf9"), new Guid("9e396e80-59d7-49bf-901a-2516e8d42fb8") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_GroupId",
                table: "Contracts",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_StudentId",
                table: "Contracts",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_StudyYearId",
                table: "Contracts",
                column: "StudyYearId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_SemesterId",
                table: "Courses",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Faculties_ChiefOfDepartmentId",
                table: "Faculties",
                column: "ChiefOfDepartmentId",
                unique: true,
                filter: "[ChiefOfDepartmentId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_CourseId",
                table: "Grades",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentId",
                table: "Grades",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_LeaderStudentId",
                table: "Groups",
                column: "LeaderStudentId",
                unique: true,
                filter: "[LeaderStudentId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_TutorTeacherId",
                table: "Groups",
                column: "TutorTeacherId",
                unique: true,
                filter: "[TutorTeacherId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OptionalCoursePreferences_OptionalCourseId",
                table: "OptionalCoursePreferences",
                column: "OptionalCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_OptionalCoursePreferences_StudentContractSemesterId",
                table: "OptionalCoursePreferences",
                column: "StudentContractSemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_OptionalCourses_SemesterId",
                table: "OptionalCourses",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_OptionalCourses_TeacherId",
                table: "OptionalCourses",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_OptionalGrades_CourseId",
                table: "OptionalGrades",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_OptionalGrades_StudentId",
                table: "OptionalGrades",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_SemesterContracts_OptionalCourseId",
                table: "SemesterContracts",
                column: "OptionalCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_SemesterContracts_StudentContractId",
                table: "SemesterContracts",
                column: "StudentContractId");

            migrationBuilder.CreateIndex(
                name: "IX_SemesterContracts_StudySemesterId",
                table: "SemesterContracts",
                column: "StudySemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_Specialisations_FacultyId",
                table: "Specialisations",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Specialisations_StudyDegreeId",
                table: "Specialisations",
                column: "StudyDegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_Specialisations_StudyLineId",
                table: "Specialisations",
                column: "StudyLineId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentEnrolledCourse_GroupId",
                table: "StudentEnrolledCourse",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentEnrolledCourse_MandatoryCourseId",
                table: "StudentEnrolledCourse",
                column: "MandatoryCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentEnrolledCourse_StudentContractSemesterId",
                table: "StudentEnrolledCourse",
                column: "StudentContractSemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_StudySemesters_StudyYearId",
                table: "StudySemesters",
                column: "StudyYearId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyYears_SpecializationId",
                table: "StudyYears",
                column: "SpecializationId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyYears_StudentLeaderId",
                table: "StudyYears",
                column: "StudentLeaderId",
                unique: true,
                filter: "[StudentLeaderId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_TeacherDegreeId",
                table: "Teachers",
                column: "TeacherDegreeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "OptionalCoursePreferences");

            migrationBuilder.DropTable(
                name: "OptionalGrades");

            migrationBuilder.DropTable(
                name: "StudentEnrolledCourse");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "SemesterContracts");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "OptionalCourses");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "StudySemesters");

            migrationBuilder.DropTable(
                name: "StudyYears");

            migrationBuilder.DropTable(
                name: "Specialisations");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Faculties");

            migrationBuilder.DropTable(
                name: "StudyDegrees");

            migrationBuilder.DropTable(
                name: "StudyLines");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "TeacherDegrees");
        }
    }
}
