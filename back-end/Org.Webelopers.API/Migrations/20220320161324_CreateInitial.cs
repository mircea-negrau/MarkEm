using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Org.Webelopers.Api.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    EmailHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    EmailHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    DateOfBirth = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeacherDegrees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherDegrees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    EmailHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    DateOfBirth = table.Column<long>(type: "bigint", nullable: true),
                    TeacherDegreeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "StudyDegrees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    FacultyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyDegrees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudyDegrees_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Specialisations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    StudyDegreeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialisations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specialisations_StudyDegrees_StudyDegreeId",
                        column: x => x.StudyDegreeId,
                        principalTable: "StudyDegrees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudyYears",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<short>(type: "smallint", nullable: false),
                    SpecialisationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentLeaderUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyYears", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudyYears_Specialisations_SpecialisationId",
                        column: x => x.SpecialisationId,
                        principalTable: "Specialisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudyYears_Students_StudentLeaderUserId",
                        column: x => x.StudentLeaderUserId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudyYearId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Groups_StudyYears_StudyYearId",
                        column: x => x.StudyYearId,
                        principalTable: "StudyYears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Groups_Teachers_TutorTeacherId",
                        column: x => x.TutorTeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OptionalCourses",
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
                        principalColumn: "Id",
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
                        principalColumn: "Id",
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudyContracts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SignedAt = table.Column<long>(type: "bigint", nullable: true),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OptionalCourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StudyYearId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyContracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudyContracts_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudyContracts_OptionalCourses_OptionalCourseId",
                        column: x => x.OptionalCourseId,
                        principalTable: "OptionalCourses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_StudyContracts_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudyContracts_StudyYears_StudyYearId",
                        column: x => x.StudyYearId,
                        principalTable: "StudyYears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OptionalCoursePreferences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Preference = table.Column<short>(type: "smallint", nullable: false),
                    StudyContractId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_OptionalCoursePreferences_StudyContracts_StudyContractId",
                        column: x => x.StudyContractId,
                        principalTable: "StudyContracts",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "EmailHash", "FirstName", "LastName", "PasswordHash", "Salt", "Username" },
                values: new object[,]
                {
                    { new Guid("f48c0b3d-860a-4f3d-9b60-9f8e07e105a2"), "dummyEmailHash", "firstName0", "firstName0", "dummyPasswordHash", "dummySalt", "TestAdmin0" },
                    { new Guid("b6ff07b9-0823-42bf-972d-ea1d34c9d52d"), "dummyEmailHash", "firstName72", "firstName72", "dummyPasswordHash", "dummySalt", "TestAdmin72" },
                    { new Guid("6ae2f987-e367-4806-b4a9-a572426f287d"), "dummyEmailHash", "firstName71", "firstName71", "dummyPasswordHash", "dummySalt", "TestAdmin71" },
                    { new Guid("b681ce30-18d0-411c-b4b0-ac138c307e2b"), "dummyEmailHash", "firstName70", "firstName70", "dummyPasswordHash", "dummySalt", "TestAdmin70" },
                    { new Guid("dc925312-9271-41f4-9640-67c9e7a4f35a"), "dummyEmailHash", "firstName69", "firstName69", "dummyPasswordHash", "dummySalt", "TestAdmin69" },
                    { new Guid("09f6d72e-82de-42d3-a9f4-db50298e4d07"), "dummyEmailHash", "firstName68", "firstName68", "dummyPasswordHash", "dummySalt", "TestAdmin68" },
                    { new Guid("59caf0b0-3b32-4a5e-9f4c-51a8f7c5579a"), "dummyEmailHash", "firstName67", "firstName67", "dummyPasswordHash", "dummySalt", "TestAdmin67" },
                    { new Guid("129c8662-cd37-4ea7-aa87-520351c09e61"), "dummyEmailHash", "firstName66", "firstName66", "dummyPasswordHash", "dummySalt", "TestAdmin66" },
                    { new Guid("5360f393-9dc3-4269-b380-e99194709929"), "dummyEmailHash", "firstName65", "firstName65", "dummyPasswordHash", "dummySalt", "TestAdmin65" },
                    { new Guid("8e6c8e55-dd02-4066-82ce-e377dbc72ca5"), "dummyEmailHash", "firstName64", "firstName64", "dummyPasswordHash", "dummySalt", "TestAdmin64" },
                    { new Guid("aa7f4edd-4377-46a4-83c1-425d0ca2efe5"), "dummyEmailHash", "firstName63", "firstName63", "dummyPasswordHash", "dummySalt", "TestAdmin63" },
                    { new Guid("7096711e-ceb4-4a4b-8896-e91d626d35bf"), "dummyEmailHash", "firstName62", "firstName62", "dummyPasswordHash", "dummySalt", "TestAdmin62" },
                    { new Guid("1b97e8d7-1001-4a5c-863b-dc414f621f33"), "dummyEmailHash", "firstName61", "firstName61", "dummyPasswordHash", "dummySalt", "TestAdmin61" },
                    { new Guid("48f35936-deb7-46c9-908d-bddf81b5189c"), "dummyEmailHash", "firstName60", "firstName60", "dummyPasswordHash", "dummySalt", "TestAdmin60" },
                    { new Guid("521a0ff2-8193-4c82-b332-af6360bfe2e7"), "dummyEmailHash", "firstName59", "firstName59", "dummyPasswordHash", "dummySalt", "TestAdmin59" },
                    { new Guid("99aa89ca-13b2-42ce-ae3a-c18d97b1a06d"), "dummyEmailHash", "firstName58", "firstName58", "dummyPasswordHash", "dummySalt", "TestAdmin58" },
                    { new Guid("e24d3f07-8bb1-4903-a4ba-5e6f284c5164"), "dummyEmailHash", "firstName57", "firstName57", "dummyPasswordHash", "dummySalt", "TestAdmin57" },
                    { new Guid("4dd8f8b3-5a62-49e8-a51b-c01f7ce405f0"), "dummyEmailHash", "firstName56", "firstName56", "dummyPasswordHash", "dummySalt", "TestAdmin56" },
                    { new Guid("b5cba7ef-e485-4240-ad25-c89bf9bb3ad1"), "dummyEmailHash", "firstName55", "firstName55", "dummyPasswordHash", "dummySalt", "TestAdmin55" },
                    { new Guid("e54d8229-6762-448b-b5a1-fc1db6ee2e19"), "dummyEmailHash", "firstName54", "firstName54", "dummyPasswordHash", "dummySalt", "TestAdmin54" },
                    { new Guid("626ec212-4456-486e-a461-3285dc32a0ef"), "dummyEmailHash", "firstName53", "firstName53", "dummyPasswordHash", "dummySalt", "TestAdmin53" },
                    { new Guid("1d2d6073-beac-450b-9008-9695359af3d5"), "dummyEmailHash", "firstName52", "firstName52", "dummyPasswordHash", "dummySalt", "TestAdmin52" },
                    { new Guid("f72ebbc7-870d-46a8-8437-ca522a69d704"), "dummyEmailHash", "firstName73", "firstName73", "dummyPasswordHash", "dummySalt", "TestAdmin73" },
                    { new Guid("d1e59ff9-a7de-4b26-aa36-c22907d2885c"), "dummyEmailHash", "firstName74", "firstName74", "dummyPasswordHash", "dummySalt", "TestAdmin74" },
                    { new Guid("7d68733f-a6ba-4af0-a966-22a98179b247"), "dummyEmailHash", "firstName75", "firstName75", "dummyPasswordHash", "dummySalt", "TestAdmin75" },
                    { new Guid("a65c4425-180c-4574-8dd5-0e5ce432ded5"), "dummyEmailHash", "firstName76", "firstName76", "dummyPasswordHash", "dummySalt", "TestAdmin76" },
                    { new Guid("64315326-c45b-4467-9e0d-5a741f2f9bac"), "dummyEmailHash", "firstName99", "firstName99", "dummyPasswordHash", "dummySalt", "TestAdmin99" },
                    { new Guid("39524edb-7449-4212-8baf-ac95ca208540"), "dummyEmailHash", "firstName98", "firstName98", "dummyPasswordHash", "dummySalt", "TestAdmin98" },
                    { new Guid("db1c3486-d5d1-4a0f-befd-a4afe50e71f5"), "dummyEmailHash", "firstName97", "firstName97", "dummyPasswordHash", "dummySalt", "TestAdmin97" },
                    { new Guid("65ca921e-24be-4d64-9fba-75710d9e4196"), "dummyEmailHash", "firstName96", "firstName96", "dummyPasswordHash", "dummySalt", "TestAdmin96" },
                    { new Guid("6127ab0c-abee-48e9-bda4-9f2b0b01a697"), "dummyEmailHash", "firstName95", "firstName95", "dummyPasswordHash", "dummySalt", "TestAdmin95" },
                    { new Guid("73e02eae-9f8d-4b0a-87ac-f291b6100132"), "dummyEmailHash", "firstName94", "firstName94", "dummyPasswordHash", "dummySalt", "TestAdmin94" },
                    { new Guid("3b45f152-efbc-487c-a463-9d5285e24a4d"), "dummyEmailHash", "firstName93", "firstName93", "dummyPasswordHash", "dummySalt", "TestAdmin93" },
                    { new Guid("db832cbb-5d3a-4c8f-a05d-28130533e401"), "dummyEmailHash", "firstName92", "firstName92", "dummyPasswordHash", "dummySalt", "TestAdmin92" },
                    { new Guid("bf489c21-75b8-4713-b052-b49c4d973651"), "dummyEmailHash", "firstName91", "firstName91", "dummyPasswordHash", "dummySalt", "TestAdmin91" },
                    { new Guid("92c627d9-f786-4429-8ff6-055f4feff13e"), "dummyEmailHash", "firstName90", "firstName90", "dummyPasswordHash", "dummySalt", "TestAdmin90" },
                    { new Guid("c327a270-70b0-4045-9e28-5dd57eba412c"), "dummyEmailHash", "firstName51", "firstName51", "dummyPasswordHash", "dummySalt", "TestAdmin51" },
                    { new Guid("d3cfcb3b-eebc-4686-9722-35920c030489"), "dummyEmailHash", "firstName88", "firstName88", "dummyPasswordHash", "dummySalt", "TestAdmin88" },
                    { new Guid("77877c7c-381a-411c-8581-ee4ee072c841"), "dummyEmailHash", "firstName86", "firstName86", "dummyPasswordHash", "dummySalt", "TestAdmin86" },
                    { new Guid("91a3e065-50b4-4c2f-b3d7-6a403f9f0b18"), "dummyEmailHash", "firstName85", "firstName85", "dummyPasswordHash", "dummySalt", "TestAdmin85" },
                    { new Guid("1da06135-df90-458e-aead-875acc9bfa3f"), "dummyEmailHash", "firstName84", "firstName84", "dummyPasswordHash", "dummySalt", "TestAdmin84" },
                    { new Guid("825cb536-c665-4e70-b7c8-382dfb54ccc0"), "dummyEmailHash", "firstName83", "firstName83", "dummyPasswordHash", "dummySalt", "TestAdmin83" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "EmailHash", "FirstName", "LastName", "PasswordHash", "Salt", "Username" },
                values: new object[,]
                {
                    { new Guid("d9dce77d-91fa-4910-b09a-615b77a1fac9"), "dummyEmailHash", "firstName82", "firstName82", "dummyPasswordHash", "dummySalt", "TestAdmin82" },
                    { new Guid("9f1f286e-1f3c-4a43-8d5e-bbc42451b34e"), "dummyEmailHash", "firstName81", "firstName81", "dummyPasswordHash", "dummySalt", "TestAdmin81" },
                    { new Guid("33f7f9a7-234e-4586-9676-73f8a0a6cf8c"), "dummyEmailHash", "firstName80", "firstName80", "dummyPasswordHash", "dummySalt", "TestAdmin80" },
                    { new Guid("e4b70f03-bd48-4c5c-bf81-f6d7ce4360dd"), "dummyEmailHash", "firstName79", "firstName79", "dummyPasswordHash", "dummySalt", "TestAdmin79" },
                    { new Guid("bb97f0b6-94b7-4f99-acf8-9ad96e5c1403"), "dummyEmailHash", "firstName78", "firstName78", "dummyPasswordHash", "dummySalt", "TestAdmin78" },
                    { new Guid("7940e347-5d28-4527-97ed-b62c72034bb6"), "dummyEmailHash", "firstName77", "firstName77", "dummyPasswordHash", "dummySalt", "TestAdmin77" },
                    { new Guid("003f33c5-4f58-42ae-beb2-63d627668073"), "dummyEmailHash", "firstName87", "firstName87", "dummyPasswordHash", "dummySalt", "TestAdmin87" },
                    { new Guid("0620aa9b-3136-4bf5-815a-eaf3f22985b4"), "dummyEmailHash", "firstName50", "firstName50", "dummyPasswordHash", "dummySalt", "TestAdmin50" },
                    { new Guid("adf24d4e-5f9e-4346-95af-32447fd2834a"), "dummyEmailHash", "firstName89", "firstName89", "dummyPasswordHash", "dummySalt", "TestAdmin89" },
                    { new Guid("d5d27483-db4b-4885-bee7-d8c901eaba56"), "dummyEmailHash", "firstName48", "firstName48", "dummyPasswordHash", "dummySalt", "TestAdmin48" },
                    { new Guid("5a34a2eb-695a-44ae-9692-ea5bcc18304d"), "dummyEmailHash", "firstName21", "firstName21", "dummyPasswordHash", "dummySalt", "TestAdmin21" },
                    { new Guid("cffdb53b-7ac8-4e16-91d8-681eac857096"), "dummyEmailHash", "firstName20", "firstName20", "dummyPasswordHash", "dummySalt", "TestAdmin20" },
                    { new Guid("e94afb6b-b5c9-4efa-9d88-ec8a28202951"), "dummyEmailHash", "firstName19", "firstName19", "dummyPasswordHash", "dummySalt", "TestAdmin19" },
                    { new Guid("2a3b6f22-c85f-4b5b-8f4d-a016b8a08f69"), "dummyEmailHash", "firstName18", "firstName18", "dummyPasswordHash", "dummySalt", "TestAdmin18" },
                    { new Guid("253dd9f3-5d5c-4c78-8ec2-08a5063bc364"), "dummyEmailHash", "firstName17", "firstName17", "dummyPasswordHash", "dummySalt", "TestAdmin17" },
                    { new Guid("3f34753c-2cea-4a4b-a6d6-434e52d8b6be"), "dummyEmailHash", "firstName16", "firstName16", "dummyPasswordHash", "dummySalt", "TestAdmin16" },
                    { new Guid("73d7d780-97c2-4e5f-b725-c5a712577286"), "dummyEmailHash", "firstName15", "firstName15", "dummyPasswordHash", "dummySalt", "TestAdmin15" },
                    { new Guid("52f15a1b-af01-4115-adf3-2d52f9621dda"), "dummyEmailHash", "firstName14", "firstName14", "dummyPasswordHash", "dummySalt", "TestAdmin14" },
                    { new Guid("604964a2-1439-4289-aa5a-ef31f42a91b2"), "dummyEmailHash", "firstName13", "firstName13", "dummyPasswordHash", "dummySalt", "TestAdmin13" },
                    { new Guid("7b305937-1801-4578-8d7a-da3399c03c0f"), "dummyEmailHash", "firstName12", "firstName12", "dummyPasswordHash", "dummySalt", "TestAdmin12" },
                    { new Guid("82953e7b-c285-49fe-9c69-42a240574950"), "dummyEmailHash", "firstName11", "firstName11", "dummyPasswordHash", "dummySalt", "TestAdmin11" },
                    { new Guid("d39b0b7f-2522-4d8d-98e0-b5db70178b8a"), "dummyEmailHash", "firstName10", "firstName10", "dummyPasswordHash", "dummySalt", "TestAdmin10" },
                    { new Guid("201032c7-f3b9-4a00-b8f0-c028c701ddfc"), "dummyEmailHash", "firstName9", "firstName9", "dummyPasswordHash", "dummySalt", "TestAdmin9" },
                    { new Guid("b9085d66-750c-4348-bddc-43107fb2bbbf"), "dummyEmailHash", "firstName8", "firstName8", "dummyPasswordHash", "dummySalt", "TestAdmin8" },
                    { new Guid("945ef40a-b4ca-4575-ada8-1ccb46e4dd8e"), "dummyEmailHash", "firstName7", "firstName7", "dummyPasswordHash", "dummySalt", "TestAdmin7" },
                    { new Guid("dcd6b5ce-1687-4a9f-ad34-1df98172d3bd"), "dummyEmailHash", "firstName5", "firstName5", "dummyPasswordHash", "dummySalt", "TestAdmin5" },
                    { new Guid("cea105f6-bbb2-430e-ac9d-d87a1450e445"), "dummyEmailHash", "firstName4", "firstName4", "dummyPasswordHash", "dummySalt", "TestAdmin4" },
                    { new Guid("84a1a3b6-de0d-4df4-a704-338cbdddf3e4"), "dummyEmailHash", "firstName3", "firstName3", "dummyPasswordHash", "dummySalt", "TestAdmin3" },
                    { new Guid("0d8120c9-6e3a-4d83-91f2-e52cfd0aeb87"), "dummyEmailHash", "firstName2", "firstName2", "dummyPasswordHash", "dummySalt", "TestAdmin2" },
                    { new Guid("259864f9-06a2-4a72-8826-db2a5982ca85"), "dummyEmailHash", "firstName1", "firstName1", "dummyPasswordHash", "dummySalt", "TestAdmin1" },
                    { new Guid("8ad1b22f-3e6a-47b6-90be-241f6c6d63d9"), "dummyEmailHash", "firstName49", "firstName49", "dummyPasswordHash", "dummySalt", "TestAdmin49" },
                    { new Guid("5aaad70f-da37-42e4-9ff6-5b7a8290e284"), "dummyEmailHash", "firstName22", "firstName22", "dummyPasswordHash", "dummySalt", "TestAdmin22" },
                    { new Guid("e5e2ca9e-8097-4b49-a663-b551d7bf3c01"), "dummyEmailHash", "firstName23", "firstName23", "dummyPasswordHash", "dummySalt", "TestAdmin23" },
                    { new Guid("4edd980b-aa33-42b8-9022-1d710a682f47"), "dummyEmailHash", "firstName6", "firstName6", "dummyPasswordHash", "dummySalt", "TestAdmin6" },
                    { new Guid("8788c73f-363a-4837-b362-0bcc15d124b6"), "dummyEmailHash", "firstName25", "firstName25", "dummyPasswordHash", "dummySalt", "TestAdmin25" },
                    { new Guid("bb02cf18-6ec5-46d3-90d4-03920706b490"), "dummyEmailHash", "firstName47", "firstName47", "dummyPasswordHash", "dummySalt", "TestAdmin47" },
                    { new Guid("9b40fd68-8e1f-4863-bb9f-01d7848fce09"), "dummyEmailHash", "firstName24", "firstName24", "dummyPasswordHash", "dummySalt", "TestAdmin24" },
                    { new Guid("94ea1305-510c-4137-9509-07d91fcbcf01"), "dummyEmailHash", "firstName46", "firstName46", "dummyPasswordHash", "dummySalt", "TestAdmin46" },
                    { new Guid("c2bb73fa-b8f6-453f-87f4-32a02f387775"), "dummyEmailHash", "firstName45", "firstName45", "dummyPasswordHash", "dummySalt", "TestAdmin45" },
                    { new Guid("fbb88fb5-9c98-4a6e-9c9a-53809dee3dfc"), "dummyEmailHash", "firstName44", "firstName44", "dummyPasswordHash", "dummySalt", "TestAdmin44" },
                    { new Guid("5294b1fa-d21f-4e65-aa8f-d4b34c5c20f6"), "dummyEmailHash", "firstName42", "firstName42", "dummyPasswordHash", "dummySalt", "TestAdmin42" },
                    { new Guid("aeebd46f-2ec7-4876-8c89-b009b8a15d57"), "dummyEmailHash", "firstName41", "firstName41", "dummyPasswordHash", "dummySalt", "TestAdmin41" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "EmailHash", "FirstName", "LastName", "PasswordHash", "Salt", "Username" },
                values: new object[,]
                {
                    { new Guid("8f24d2ba-459d-40c0-bb53-982c0329e5fc"), "dummyEmailHash", "firstName40", "firstName40", "dummyPasswordHash", "dummySalt", "TestAdmin40" },
                    { new Guid("baa8988a-82d8-4801-ba21-2c771ae56f96"), "dummyEmailHash", "firstName39", "firstName39", "dummyPasswordHash", "dummySalt", "TestAdmin39" },
                    { new Guid("906a57f4-d9ce-4f61-82ca-3555b112caa8"), "dummyEmailHash", "firstName38", "firstName38", "dummyPasswordHash", "dummySalt", "TestAdmin38" },
                    { new Guid("16e0e117-7962-4733-a088-452cd902add3"), "dummyEmailHash", "firstName37", "firstName37", "dummyPasswordHash", "dummySalt", "TestAdmin37" },
                    { new Guid("7e1d18a0-de02-4017-99bf-26405095d6d0"), "dummyEmailHash", "firstName43", "firstName43", "dummyPasswordHash", "dummySalt", "TestAdmin43" },
                    { new Guid("3db81c5c-d389-4c0f-b6b6-c72b1d4427b7"), "dummyEmailHash", "firstName29", "firstName29", "dummyPasswordHash", "dummySalt", "TestAdmin29" },
                    { new Guid("e1f0b5d9-a836-4dfb-8124-def440b7ec34"), "dummyEmailHash", "firstName36", "firstName36", "dummyPasswordHash", "dummySalt", "TestAdmin36" },
                    { new Guid("7a8f4837-ad61-403d-bfc3-bb39a3d00bc1"), "dummyEmailHash", "firstName28", "firstName28", "dummyPasswordHash", "dummySalt", "TestAdmin28" },
                    { new Guid("b02ce04b-2ba8-41ef-a42b-b190699fa735"), "dummyEmailHash", "firstName30", "firstName30", "dummyPasswordHash", "dummySalt", "TestAdmin30" },
                    { new Guid("0a234e37-4296-462e-af1e-cea776079596"), "dummyEmailHash", "firstName31", "firstName31", "dummyPasswordHash", "dummySalt", "TestAdmin31" },
                    { new Guid("f83da601-24cd-4aff-a70d-2ed826727b4c"), "dummyEmailHash", "firstName27", "firstName27", "dummyPasswordHash", "dummySalt", "TestAdmin27" },
                    { new Guid("d127a8f4-317d-4568-bdd2-437babb434a3"), "dummyEmailHash", "firstName32", "firstName32", "dummyPasswordHash", "dummySalt", "TestAdmin32" },
                    { new Guid("447e902b-77c5-43b5-94e4-d74fef7a2e21"), "dummyEmailHash", "firstName33", "firstName33", "dummyPasswordHash", "dummySalt", "TestAdmin33" },
                    { new Guid("7106d788-f41b-4bf1-9a02-fcd5a55e8afd"), "dummyEmailHash", "firstName34", "firstName34", "dummyPasswordHash", "dummySalt", "TestAdmin34" },
                    { new Guid("fc1964f4-a483-42cb-b2a4-5b9932c85b22"), "dummyEmailHash", "firstName35", "firstName35", "dummyPasswordHash", "dummySalt", "TestAdmin35" },
                    { new Guid("75f046a6-0d10-4fc4-8204-99b8428080af"), "dummyEmailHash", "firstName26", "firstName26", "dummyPasswordHash", "dummySalt", "TestAdmin26" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "EmailHash", "FirstName", "LastName", "PasswordHash", "Username" },
                values: new object[,]
                {
                    { new Guid("fda7fbe1-71fb-4bc7-a626-5a2e8173e5bb"), 732624581L, "dummyEmailHash", "firstName220", "firstName220", "dummyPasswordHash", "TestStudent220" },
                    { new Guid("3e192081-d7ea-4b18-b630-f54a03c98803"), 732624581L, "dummyEmailHash", "firstName214", "firstName214", "dummyPasswordHash", "TestStudent214" },
                    { new Guid("7acce61f-3fe2-4a52-98c5-9d143e44accd"), 732624581L, "dummyEmailHash", "firstName219", "firstName219", "dummyPasswordHash", "TestStudent219" },
                    { new Guid("2b3498c6-10a0-426c-93a3-2622d26b841f"), 732624581L, "dummyEmailHash", "firstName218", "firstName218", "dummyPasswordHash", "TestStudent218" },
                    { new Guid("debc8434-5db8-4a6b-abc4-132837b26f6b"), 732624581L, "dummyEmailHash", "firstName217", "firstName217", "dummyPasswordHash", "TestStudent217" },
                    { new Guid("9dd19ed5-05e0-4aa7-b933-2832a2ca3052"), 732624581L, "dummyEmailHash", "firstName216", "firstName216", "dummyPasswordHash", "TestStudent216" },
                    { new Guid("511b0914-a3f0-4bfd-829d-e20dad19b485"), 732624581L, "dummyEmailHash", "firstName215", "firstName215", "dummyPasswordHash", "TestStudent215" },
                    { new Guid("4b74c468-4b10-429f-af14-57f82c38074e"), 732624581L, "dummyEmailHash", "firstName205", "firstName205", "dummyPasswordHash", "TestStudent205" },
                    { new Guid("f59f1af2-80d2-4c7c-961f-236bccdca5b9"), 732624581L, "dummyEmailHash", "firstName210", "firstName210", "dummyPasswordHash", "TestStudent210" },
                    { new Guid("33d83e89-2847-4d20-bf48-d0f0e1d78a6c"), 732624581L, "dummyEmailHash", "firstName212", "firstName212", "dummyPasswordHash", "TestStudent212" },
                    { new Guid("0b78ab89-9922-4fca-9324-53468e94f42d"), 732624581L, "dummyEmailHash", "firstName211", "firstName211", "dummyPasswordHash", "TestStudent211" },
                    { new Guid("b7aad71e-ce21-49ca-948f-226796882c25"), 732624581L, "dummyEmailHash", "firstName209", "firstName209", "dummyPasswordHash", "TestStudent209" },
                    { new Guid("2d497cd0-bee9-49c0-babd-25e8da2a9a1e"), 732624581L, "dummyEmailHash", "firstName208", "firstName208", "dummyPasswordHash", "TestStudent208" },
                    { new Guid("bbfc8107-929d-4aab-8b28-7616f5814396"), 732624581L, "dummyEmailHash", "firstName207", "firstName207", "dummyPasswordHash", "TestStudent207" },
                    { new Guid("6cc23fe4-411e-4646-9994-7cc46252e727"), 732624581L, "dummyEmailHash", "firstName221", "firstName221", "dummyPasswordHash", "TestStudent221" },
                    { new Guid("b8aa879e-aba4-4bb3-a21e-80986743f329"), 732624581L, "dummyEmailHash", "firstName206", "firstName206", "dummyPasswordHash", "TestStudent206" },
                    { new Guid("2ea179f1-87dc-427a-a259-1152d6877613"), 732624581L, "dummyEmailHash", "firstName213", "firstName213", "dummyPasswordHash", "TestStudent213" },
                    { new Guid("65e9b087-2128-47d2-b1f4-72faeda4be77"), 732624581L, "dummyEmailHash", "firstName222", "firstName222", "dummyPasswordHash", "TestStudent222" },
                    { new Guid("a0054c88-2d59-4e3c-a98e-7f52dc08eaad"), 732624581L, "dummyEmailHash", "firstName233", "firstName233", "dummyPasswordHash", "TestStudent233" },
                    { new Guid("9b17143b-d672-4017-bf8b-a5365d1856ff"), 732624581L, "dummyEmailHash", "firstName224", "firstName224", "dummyPasswordHash", "TestStudent224" },
                    { new Guid("2b472ca3-f141-48c9-ab38-6a195e189141"), 732624581L, "dummyEmailHash", "firstName241", "firstName241", "dummyPasswordHash", "TestStudent241" },
                    { new Guid("96eafb06-3ef5-4d35-a126-cd859ebab54b"), 732624581L, "dummyEmailHash", "firstName204", "firstName204", "dummyPasswordHash", "TestStudent204" },
                    { new Guid("58496d48-fe44-461e-8200-c742545241ab"), 732624581L, "dummyEmailHash", "firstName240", "firstName240", "dummyPasswordHash", "TestStudent240" },
                    { new Guid("9293b6a7-a036-4351-8792-db04aa5af7b3"), 732624581L, "dummyEmailHash", "firstName239", "firstName239", "dummyPasswordHash", "TestStudent239" },
                    { new Guid("d9d6ed4f-a798-403a-a63c-8f792771cb95"), 732624581L, "dummyEmailHash", "firstName238", "firstName238", "dummyPasswordHash", "TestStudent238" },
                    { new Guid("3ce1fd54-2160-433e-898b-e68c99beb58b"), 732624581L, "dummyEmailHash", "firstName237", "firstName237", "dummyPasswordHash", "TestStudent237" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "EmailHash", "FirstName", "LastName", "PasswordHash", "Username" },
                values: new object[,]
                {
                    { new Guid("b83b0979-6a2a-4f6a-839f-bd3800b5bbde"), 732624581L, "dummyEmailHash", "firstName236", "firstName236", "dummyPasswordHash", "TestStudent236" },
                    { new Guid("609c1c51-cbdc-41cb-96cd-df974ec96f66"), 732624581L, "dummyEmailHash", "firstName235", "firstName235", "dummyPasswordHash", "TestStudent235" },
                    { new Guid("4497e812-b06e-42a6-b1f1-bb8943367274"), 732624581L, "dummyEmailHash", "firstName234", "firstName234", "dummyPasswordHash", "TestStudent234" },
                    { new Guid("58cf84e0-73f5-4c1b-961e-29665e86da87"), 732624581L, "dummyEmailHash", "firstName232", "firstName232", "dummyPasswordHash", "TestStudent232" },
                    { new Guid("22c95cc3-864f-4d3c-a724-f8c99ca66554"), 732624581L, "dummyEmailHash", "firstName231", "firstName231", "dummyPasswordHash", "TestStudent231" },
                    { new Guid("6774b573-7200-4d5d-88c0-cef6a816f01f"), 732624581L, "dummyEmailHash", "firstName230", "firstName230", "dummyPasswordHash", "TestStudent230" },
                    { new Guid("d0897d78-3ffc-4624-a205-15aa2700139f"), 732624581L, "dummyEmailHash", "firstName229", "firstName229", "dummyPasswordHash", "TestStudent229" },
                    { new Guid("1fa772cb-9259-465d-b97a-ae2265ca6210"), 732624581L, "dummyEmailHash", "firstName228", "firstName228", "dummyPasswordHash", "TestStudent228" },
                    { new Guid("e0559ad2-d756-4eab-8021-c0afc81c238a"), 732624581L, "dummyEmailHash", "firstName227", "firstName227", "dummyPasswordHash", "TestStudent227" },
                    { new Guid("2714b08d-7f60-44ad-9fae-c07d44490839"), 732624581L, "dummyEmailHash", "firstName226", "firstName226", "dummyPasswordHash", "TestStudent226" },
                    { new Guid("daad96b5-c534-4e42-83eb-7d6bdc5bfb62"), 732624581L, "dummyEmailHash", "firstName225", "firstName225", "dummyPasswordHash", "TestStudent225" },
                    { new Guid("187b99f1-dc75-4724-acee-0688e37c285e"), 732624581L, "dummyEmailHash", "firstName223", "firstName223", "dummyPasswordHash", "TestStudent223" },
                    { new Guid("6640d55c-1fec-4f4b-b20c-090874155d04"), 732624581L, "dummyEmailHash", "firstName203", "firstName203", "dummyPasswordHash", "TestStudent203" },
                    { new Guid("41d233cb-3722-419c-aad6-5b7a501869ce"), 732624581L, "dummyEmailHash", "firstName179", "firstName179", "dummyPasswordHash", "TestStudent179" },
                    { new Guid("00cfaf2e-77ab-419b-85e1-9eb50bcab65b"), 732624581L, "dummyEmailHash", "firstName201", "firstName201", "dummyPasswordHash", "TestStudent201" },
                    { new Guid("3aaac02f-d7ca-4353-9bae-963860cd45bb"), 732624581L, "dummyEmailHash", "firstName178", "firstName178", "dummyPasswordHash", "TestStudent178" },
                    { new Guid("81207023-d172-4ea8-b484-38d6edc3639d"), 732624581L, "dummyEmailHash", "firstName177", "firstName177", "dummyPasswordHash", "TestStudent177" },
                    { new Guid("7d6a60dc-e3ba-41b5-8431-e6b8051ce24b"), 732624581L, "dummyEmailHash", "firstName176", "firstName176", "dummyPasswordHash", "TestStudent176" },
                    { new Guid("0fb317ef-fef9-495b-999e-ce868c915bf3"), 732624581L, "dummyEmailHash", "firstName175", "firstName175", "dummyPasswordHash", "TestStudent175" },
                    { new Guid("9e90e22e-ab55-4562-88cf-99dd907f971d"), 732624581L, "dummyEmailHash", "firstName174", "firstName174", "dummyPasswordHash", "TestStudent174" },
                    { new Guid("cceb338c-3b15-42c3-bea6-c1858c4f97de"), 732624581L, "dummyEmailHash", "firstName173", "firstName173", "dummyPasswordHash", "TestStudent173" },
                    { new Guid("7d2df82a-da60-435f-92f3-00b9a08a83a7"), 732624581L, "dummyEmailHash", "firstName172", "firstName172", "dummyPasswordHash", "TestStudent172" },
                    { new Guid("504758c1-1de9-4ac0-975f-e5aa3792eab9"), 732624581L, "dummyEmailHash", "firstName180", "firstName180", "dummyPasswordHash", "TestStudent180" },
                    { new Guid("798888f4-378a-4b06-9966-c2f5b8a9e9e9"), 732624581L, "dummyEmailHash", "firstName171", "firstName171", "dummyPasswordHash", "TestStudent171" },
                    { new Guid("f2135e60-f330-4ed1-8742-1a848f1c524c"), 732624581L, "dummyEmailHash", "firstName169", "firstName169", "dummyPasswordHash", "TestStudent169" },
                    { new Guid("e7dbd668-f65e-4a4f-a219-7df85426eb7d"), 732624581L, "dummyEmailHash", "firstName168", "firstName168", "dummyPasswordHash", "TestStudent168" },
                    { new Guid("cb4553fe-491c-4ae1-a9ec-728e0e23aa41"), 732624581L, "dummyEmailHash", "firstName167", "firstName167", "dummyPasswordHash", "TestStudent167" },
                    { new Guid("df53a171-3c34-4018-b758-1879fc9d5668"), 732624581L, "dummyEmailHash", "firstName166", "firstName166", "dummyPasswordHash", "TestStudent166" },
                    { new Guid("a2a3b028-b19f-4f32-b37f-559e7faa36ea"), 732624581L, "dummyEmailHash", "firstName165", "firstName165", "dummyPasswordHash", "TestStudent165" },
                    { new Guid("83f0aaff-d4c3-4309-8768-77893c992640"), 732624581L, "dummyEmailHash", "firstName164", "firstName164", "dummyPasswordHash", "TestStudent164" },
                    { new Guid("dbb2e57a-04d6-4da5-9807-e241731ec56c"), 732624581L, "dummyEmailHash", "firstName242", "firstName242", "dummyPasswordHash", "TestStudent242" },
                    { new Guid("26ffa7f4-c957-4630-b05c-02d0c840c97f"), 732624581L, "dummyEmailHash", "firstName170", "firstName170", "dummyPasswordHash", "TestStudent170" },
                    { new Guid("4e52143f-1096-4527-82a4-952946e770ee"), 732624581L, "dummyEmailHash", "firstName181", "firstName181", "dummyPasswordHash", "TestStudent181" },
                    { new Guid("0cc54009-5402-4edf-99c9-a7b99b06a030"), 732624581L, "dummyEmailHash", "firstName182", "firstName182", "dummyPasswordHash", "TestStudent182" },
                    { new Guid("8269ca96-4564-42f3-865a-166c53b70048"), 732624581L, "dummyEmailHash", "firstName183", "firstName183", "dummyPasswordHash", "TestStudent183" },
                    { new Guid("e8cce8c0-a6d7-4df2-aacd-e7b73066b15d"), 732624581L, "dummyEmailHash", "firstName200", "firstName200", "dummyPasswordHash", "TestStudent200" },
                    { new Guid("922f2946-a18a-4498-b3ce-5a48d253f485"), 732624581L, "dummyEmailHash", "firstName199", "firstName199", "dummyPasswordHash", "TestStudent199" },
                    { new Guid("3f926b42-d0ee-40d0-bd0a-16d5b543c41b"), 732624581L, "dummyEmailHash", "firstName198", "firstName198", "dummyPasswordHash", "TestStudent198" },
                    { new Guid("a596de6d-9472-4dcd-bd27-5332a82d3af6"), 732624581L, "dummyEmailHash", "firstName197", "firstName197", "dummyPasswordHash", "TestStudent197" },
                    { new Guid("ca9958e8-1315-4ed6-97cb-ffbf16656321"), 732624581L, "dummyEmailHash", "firstName196", "firstName196", "dummyPasswordHash", "TestStudent196" },
                    { new Guid("5e5ca85e-0a93-4873-9372-b5a5c662b052"), 732624581L, "dummyEmailHash", "firstName195", "firstName195", "dummyPasswordHash", "TestStudent195" },
                    { new Guid("b69f3e09-aa52-4f92-8902-546043865030"), 732624581L, "dummyEmailHash", "firstName194", "firstName194", "dummyPasswordHash", "TestStudent194" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "EmailHash", "FirstName", "LastName", "PasswordHash", "Username" },
                values: new object[,]
                {
                    { new Guid("f86d7461-18a7-45a2-b52f-ba3908594baa"), 732624581L, "dummyEmailHash", "firstName193", "firstName193", "dummyPasswordHash", "TestStudent193" },
                    { new Guid("3f015aff-d63d-4694-aef8-0c2e7b6368cc"), 732624581L, "dummyEmailHash", "firstName192", "firstName192", "dummyPasswordHash", "TestStudent192" },
                    { new Guid("f03af296-40a2-4ef2-9fc3-26ff5c3ab206"), 732624581L, "dummyEmailHash", "firstName191", "firstName191", "dummyPasswordHash", "TestStudent191" },
                    { new Guid("7b7d4e6f-6af7-405a-88b8-e13aba66c309"), 732624581L, "dummyEmailHash", "firstName190", "firstName190", "dummyPasswordHash", "TestStudent190" },
                    { new Guid("9b3d4def-357a-47ef-be7b-96fe3a543731"), 732624581L, "dummyEmailHash", "firstName189", "firstName189", "dummyPasswordHash", "TestStudent189" },
                    { new Guid("44d0869b-72ff-4f9b-847e-29916d7a693a"), 732624581L, "dummyEmailHash", "firstName188", "firstName188", "dummyPasswordHash", "TestStudent188" },
                    { new Guid("617766f8-ca42-4352-9c3f-f0467fa11b36"), 732624581L, "dummyEmailHash", "firstName187", "firstName187", "dummyPasswordHash", "TestStudent187" },
                    { new Guid("d7d601ab-76a3-46ae-918f-dcffc52ffea0"), 732624581L, "dummyEmailHash", "firstName186", "firstName186", "dummyPasswordHash", "TestStudent186" },
                    { new Guid("79a3d751-db8d-4495-813d-a6203154549a"), 732624581L, "dummyEmailHash", "firstName185", "firstName185", "dummyPasswordHash", "TestStudent185" },
                    { new Guid("6453708a-2fea-44e4-9de2-d2cf2389915d"), 732624581L, "dummyEmailHash", "firstName184", "firstName184", "dummyPasswordHash", "TestStudent184" },
                    { new Guid("9cc46841-0155-4390-99f3-f7e4d7ac780e"), 732624581L, "dummyEmailHash", "firstName202", "firstName202", "dummyPasswordHash", "TestStudent202" },
                    { new Guid("07a24a57-e399-4bdf-943a-4c6d1167b9c6"), 732624581L, "dummyEmailHash", "firstName243", "firstName243", "dummyPasswordHash", "TestStudent243" },
                    { new Guid("d12cbea7-c1ba-4ae0-9e19-840376567159"), 732624581L, "dummyEmailHash", "firstName293", "firstName293", "dummyPasswordHash", "TestStudent293" },
                    { new Guid("7cb805ee-825e-46cc-bd4c-4cf60718eb11"), 732624581L, "dummyEmailHash", "firstName245", "firstName245", "dummyPasswordHash", "TestStudent245" },
                    { new Guid("1f1fe638-1b54-40f2-96cf-18f962b9a5f9"), 732624581L, "dummyEmailHash", "firstName302", "firstName302", "dummyPasswordHash", "TestStudent302" },
                    { new Guid("53cb595c-526c-42f2-b2aa-fe6542a552cb"), 732624581L, "dummyEmailHash", "firstName301", "firstName301", "dummyPasswordHash", "TestStudent301" },
                    { new Guid("99d9eccb-5100-40de-b3a0-cc91b1f9b9b1"), 732624581L, "dummyEmailHash", "firstName300", "firstName300", "dummyPasswordHash", "TestStudent300" },
                    { new Guid("81d14df4-91b9-4f25-b538-87ef29f51bdf"), 732624581L, "dummyEmailHash", "firstName299", "firstName299", "dummyPasswordHash", "TestStudent299" },
                    { new Guid("bc63fa64-7223-4e03-8d83-3217e3600e22"), 732624581L, "dummyEmailHash", "firstName298", "firstName298", "dummyPasswordHash", "TestStudent298" },
                    { new Guid("d6ff772d-059b-4705-b2a9-86a2a922581b"), 732624581L, "dummyEmailHash", "firstName297", "firstName297", "dummyPasswordHash", "TestStudent297" },
                    { new Guid("4cff8695-f6e3-4066-8114-6d6e5092e8a1"), 732624581L, "dummyEmailHash", "firstName296", "firstName296", "dummyPasswordHash", "TestStudent296" },
                    { new Guid("591870ee-cbed-4c8d-acfb-31311af495c0"), 732624581L, "dummyEmailHash", "firstName303", "firstName303", "dummyPasswordHash", "TestStudent303" },
                    { new Guid("6c8a85f6-6c11-4efd-ad98-d851e6add12c"), 732624581L, "dummyEmailHash", "firstName295", "firstName295", "dummyPasswordHash", "TestStudent295" },
                    { new Guid("b8808a4e-a209-4f3d-bc48-44df7cd85f6f"), 732624581L, "dummyEmailHash", "firstName163", "firstName163", "dummyPasswordHash", "TestStudent163" },
                    { new Guid("c6938e97-d6fa-4b2a-9d5b-a7597474ecb8"), 732624581L, "dummyEmailHash", "firstName292", "firstName292", "dummyPasswordHash", "TestStudent292" },
                    { new Guid("0047c884-94a0-40c3-a6fa-d7a4c54d225d"), 732624581L, "dummyEmailHash", "firstName291", "firstName291", "dummyPasswordHash", "TestStudent291" },
                    { new Guid("9a2ba3c1-1ac3-4848-8437-05aa5798c84a"), 732624581L, "dummyEmailHash", "firstName290", "firstName290", "dummyPasswordHash", "TestStudent290" },
                    { new Guid("13226643-dc98-41f7-acc7-6096bf7aa512"), 732624581L, "dummyEmailHash", "firstName289", "firstName289", "dummyPasswordHash", "TestStudent289" },
                    { new Guid("9bbb43b1-7d42-47c4-9148-1c81a476ffe6"), 732624581L, "dummyEmailHash", "firstName288", "firstName288", "dummyPasswordHash", "TestStudent288" },
                    { new Guid("75ef86b3-6b75-4fa2-9a90-8d8dbe014dbb"), 732624581L, "dummyEmailHash", "firstName287", "firstName287", "dummyPasswordHash", "TestStudent287" },
                    { new Guid("58f39776-9c1e-47aa-9eea-19197e1be932"), 732624581L, "dummyEmailHash", "firstName294", "firstName294", "dummyPasswordHash", "TestStudent294" },
                    { new Guid("68561834-df19-4d14-87a4-0d015c7cc5b4"), 732624581L, "dummyEmailHash", "firstName304", "firstName304", "dummyPasswordHash", "TestStudent304" },
                    { new Guid("4e31d876-41d5-4f98-95ed-24d6f4217948"), 732624581L, "dummyEmailHash", "firstName305", "firstName305", "dummyPasswordHash", "TestStudent305" },
                    { new Guid("dc5e4cc8-2e0c-49ed-a005-6f0618b6e9aa"), 732624581L, "dummyEmailHash", "firstName306", "firstName306", "dummyPasswordHash", "TestStudent306" },
                    { new Guid("02818ffd-0589-4354-9300-85fc7438e701"), 732624581L, "dummyEmailHash", "firstName323", "firstName323", "dummyPasswordHash", "TestStudent323" },
                    { new Guid("172d66d7-51d2-4466-a948-cfd5048f39f0"), 732624581L, "dummyEmailHash", "firstName322", "firstName322", "dummyPasswordHash", "TestStudent322" },
                    { new Guid("5be602af-f69e-4fe9-a831-cdc006c419bd"), 732624581L, "dummyEmailHash", "firstName321", "firstName321", "dummyPasswordHash", "TestStudent321" },
                    { new Guid("5a81dec3-3e42-4eda-a9ef-39f42595fbda"), 732624581L, "dummyEmailHash", "firstName320", "firstName320", "dummyPasswordHash", "TestStudent320" },
                    { new Guid("cda50d53-914e-4fe1-a2e2-353383f278c4"), 732624581L, "dummyEmailHash", "firstName319", "firstName319", "dummyPasswordHash", "TestStudent319" },
                    { new Guid("b30b7ea2-c339-4c6f-8cd8-a7b32ce3314f"), 732624581L, "dummyEmailHash", "firstName318", "firstName318", "dummyPasswordHash", "TestStudent318" },
                    { new Guid("194e9bdc-cfca-4531-b386-6a7fa43b0449"), 732624581L, "dummyEmailHash", "firstName317", "firstName317", "dummyPasswordHash", "TestStudent317" },
                    { new Guid("50154cfa-4043-48f6-854a-fa1c029696ad"), 732624581L, "dummyEmailHash", "firstName316", "firstName316", "dummyPasswordHash", "TestStudent316" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "EmailHash", "FirstName", "LastName", "PasswordHash", "Username" },
                values: new object[,]
                {
                    { new Guid("ea76f81e-3023-40d6-a406-ebc88e6d9db8"), 732624581L, "dummyEmailHash", "firstName315", "firstName315", "dummyPasswordHash", "TestStudent315" },
                    { new Guid("4dfa468b-e025-4229-a276-1e5495b80859"), 732624581L, "dummyEmailHash", "firstName314", "firstName314", "dummyPasswordHash", "TestStudent314" },
                    { new Guid("44594ce6-bf71-4a46-8266-98bfeb1c2970"), 732624581L, "dummyEmailHash", "firstName313", "firstName313", "dummyPasswordHash", "TestStudent313" },
                    { new Guid("68b95b3d-ec70-4d42-a541-fb86fa9d08a5"), 732624581L, "dummyEmailHash", "firstName312", "firstName312", "dummyPasswordHash", "TestStudent312" },
                    { new Guid("8b5d7a5d-c8be-4885-9d3c-e78f5efbc5fa"), 732624581L, "dummyEmailHash", "firstName311", "firstName311", "dummyPasswordHash", "TestStudent311" },
                    { new Guid("ac18481b-0a8f-4a37-9864-906478ffd2df"), 732624581L, "dummyEmailHash", "firstName310", "firstName310", "dummyPasswordHash", "TestStudent310" },
                    { new Guid("d7f63d2b-5ead-4607-a40a-deb582ea5308"), 732624581L, "dummyEmailHash", "firstName309", "firstName309", "dummyPasswordHash", "TestStudent309" },
                    { new Guid("ef20cb96-cb50-468a-a290-60982c4624cf"), 732624581L, "dummyEmailHash", "firstName308", "firstName308", "dummyPasswordHash", "TestStudent308" },
                    { new Guid("0f476780-2609-488f-b0fa-3e6eb9b0b157"), 732624581L, "dummyEmailHash", "firstName307", "firstName307", "dummyPasswordHash", "TestStudent307" },
                    { new Guid("65ac3529-37a4-4d27-879d-40969d658ab3"), 732624581L, "dummyEmailHash", "firstName286", "firstName286", "dummyPasswordHash", "TestStudent286" },
                    { new Guid("900eb128-17c8-4256-93cb-794bde9bbd2e"), 732624581L, "dummyEmailHash", "firstName244", "firstName244", "dummyPasswordHash", "TestStudent244" },
                    { new Guid("e1c742e4-9cfd-4c20-85be-43d3de4544db"), 732624581L, "dummyEmailHash", "firstName285", "firstName285", "dummyPasswordHash", "TestStudent285" },
                    { new Guid("cc3c8718-d3d2-4a23-a181-21f583172446"), 732624581L, "dummyEmailHash", "firstName283", "firstName283", "dummyPasswordHash", "TestStudent283" },
                    { new Guid("ae25e307-db05-481f-aa06-2becaa25783f"), 732624581L, "dummyEmailHash", "firstName261", "firstName261", "dummyPasswordHash", "TestStudent261" },
                    { new Guid("30424b48-0a19-4374-9ee4-85d56710a043"), 732624581L, "dummyEmailHash", "firstName260", "firstName260", "dummyPasswordHash", "TestStudent260" },
                    { new Guid("3972f777-d431-401c-a7d9-5e1acfd05141"), 732624581L, "dummyEmailHash", "firstName259", "firstName259", "dummyPasswordHash", "TestStudent259" },
                    { new Guid("66914d46-a3ff-42e5-9482-9a0cbd02912d"), 732624581L, "dummyEmailHash", "firstName258", "firstName258", "dummyPasswordHash", "TestStudent258" },
                    { new Guid("aef90b6a-bd3a-4486-bec0-1c41d2c7f103"), 732624581L, "dummyEmailHash", "firstName257", "firstName257", "dummyPasswordHash", "TestStudent257" },
                    { new Guid("73d5914f-57d9-4704-aadb-8b9e4df4f80d"), 732624581L, "dummyEmailHash", "firstName256", "firstName256", "dummyPasswordHash", "TestStudent256" },
                    { new Guid("bbdc9601-9917-47cf-bf3b-054ccb3885aa"), 732624581L, "dummyEmailHash", "firstName255", "firstName255", "dummyPasswordHash", "TestStudent255" },
                    { new Guid("01fab89e-aee2-4c68-8b07-69202835eebc"), 732624581L, "dummyEmailHash", "firstName262", "firstName262", "dummyPasswordHash", "TestStudent262" },
                    { new Guid("6540d709-9e28-4f27-afa2-75a3d133035c"), 732624581L, "dummyEmailHash", "firstName254", "firstName254", "dummyPasswordHash", "TestStudent254" },
                    { new Guid("cf6f93fe-b14f-4f6d-9294-d7afb5b60523"), 732624581L, "dummyEmailHash", "firstName252", "firstName252", "dummyPasswordHash", "TestStudent252" },
                    { new Guid("027822bd-e570-480a-8a15-b5a584d02fa4"), 732624581L, "dummyEmailHash", "firstName251", "firstName251", "dummyPasswordHash", "TestStudent251" },
                    { new Guid("18ef1291-93ea-4f80-b78e-99dce5655853"), 732624581L, "dummyEmailHash", "firstName250", "firstName250", "dummyPasswordHash", "TestStudent250" },
                    { new Guid("20f0c76e-50ef-4b6c-9cf6-e78ece3ba113"), 732624581L, "dummyEmailHash", "firstName249", "firstName249", "dummyPasswordHash", "TestStudent249" },
                    { new Guid("8afe67c9-5ea9-4b81-a327-bd3a8576a3dc"), 732624581L, "dummyEmailHash", "firstName248", "firstName248", "dummyPasswordHash", "TestStudent248" },
                    { new Guid("61731a1e-ddae-4771-adec-d1e909316d2d"), 732624581L, "dummyEmailHash", "firstName247", "firstName247", "dummyPasswordHash", "TestStudent247" },
                    { new Guid("7f3003dc-a33f-4d63-b1ce-b356142de5d6"), 732624581L, "dummyEmailHash", "firstName246", "firstName246", "dummyPasswordHash", "TestStudent246" },
                    { new Guid("f118d66a-6f65-49a9-8bba-b6d1805da164"), 732624581L, "dummyEmailHash", "firstName253", "firstName253", "dummyPasswordHash", "TestStudent253" },
                    { new Guid("5dc5b31a-2796-4094-a7d9-575e300b0afe"), 732624581L, "dummyEmailHash", "firstName263", "firstName263", "dummyPasswordHash", "TestStudent263" },
                    { new Guid("d7a78302-2999-4117-8863-905b6d6885ec"), 732624581L, "dummyEmailHash", "firstName264", "firstName264", "dummyPasswordHash", "TestStudent264" },
                    { new Guid("59ba496a-844e-4aa2-82cc-a0f838143dc4"), 732624581L, "dummyEmailHash", "firstName265", "firstName265", "dummyPasswordHash", "TestStudent265" },
                    { new Guid("8fedd17a-d68c-44f3-a2ee-840b9a94663d"), 732624581L, "dummyEmailHash", "firstName282", "firstName282", "dummyPasswordHash", "TestStudent282" },
                    { new Guid("bae39c79-1c1d-4779-bce0-7559ef2b9cb9"), 732624581L, "dummyEmailHash", "firstName281", "firstName281", "dummyPasswordHash", "TestStudent281" },
                    { new Guid("9a595c28-592b-442a-814e-72654cc3e8e9"), 732624581L, "dummyEmailHash", "firstName280", "firstName280", "dummyPasswordHash", "TestStudent280" },
                    { new Guid("487ec70a-b54e-4a31-8b7b-c01ffb606505"), 732624581L, "dummyEmailHash", "firstName279", "firstName279", "dummyPasswordHash", "TestStudent279" },
                    { new Guid("1da7b03b-3e5c-4a26-9b0a-67393f1845cc"), 732624581L, "dummyEmailHash", "firstName278", "firstName278", "dummyPasswordHash", "TestStudent278" },
                    { new Guid("7989cd9d-ba2c-4b09-8ba2-bb38f055d08c"), 732624581L, "dummyEmailHash", "firstName277", "firstName277", "dummyPasswordHash", "TestStudent277" },
                    { new Guid("5b051fdf-aee4-4a0d-874e-5db5b83eff46"), 732624581L, "dummyEmailHash", "firstName276", "firstName276", "dummyPasswordHash", "TestStudent276" },
                    { new Guid("403bd0cb-6c38-496b-a0ab-f2d2c48f91f2"), 732624581L, "dummyEmailHash", "firstName275", "firstName275", "dummyPasswordHash", "TestStudent275" },
                    { new Guid("c49f0fcc-63f5-4ddd-8e39-011e5eea7bb1"), 732624581L, "dummyEmailHash", "firstName274", "firstName274", "dummyPasswordHash", "TestStudent274" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "EmailHash", "FirstName", "LastName", "PasswordHash", "Username" },
                values: new object[,]
                {
                    { new Guid("7535c9e5-8337-440a-9931-2abc739f8d6b"), 732624581L, "dummyEmailHash", "firstName273", "firstName273", "dummyPasswordHash", "TestStudent273" },
                    { new Guid("872a482d-753f-47f5-a7f3-8bc43e2d9fb1"), 732624581L, "dummyEmailHash", "firstName272", "firstName272", "dummyPasswordHash", "TestStudent272" },
                    { new Guid("160d61bb-b4eb-4122-8190-fe1f5dc1a231"), 732624581L, "dummyEmailHash", "firstName271", "firstName271", "dummyPasswordHash", "TestStudent271" },
                    { new Guid("5134e1ce-26b6-4fed-a0c7-bd91daa55b43"), 732624581L, "dummyEmailHash", "firstName270", "firstName270", "dummyPasswordHash", "TestStudent270" },
                    { new Guid("a2a887fe-7e7b-4341-b8dd-19766d16e04c"), 732624581L, "dummyEmailHash", "firstName269", "firstName269", "dummyPasswordHash", "TestStudent269" },
                    { new Guid("6db9fc75-fc1e-4b3e-b4b3-1b4ff0a2f0ed"), 732624581L, "dummyEmailHash", "firstName268", "firstName268", "dummyPasswordHash", "TestStudent268" },
                    { new Guid("783cb4aa-afaa-459f-89de-244701b37a0a"), 732624581L, "dummyEmailHash", "firstName267", "firstName267", "dummyPasswordHash", "TestStudent267" },
                    { new Guid("4d3a1b4b-c984-4aa9-a192-e7fbc113e1c4"), 732624581L, "dummyEmailHash", "firstName266", "firstName266", "dummyPasswordHash", "TestStudent266" },
                    { new Guid("14034147-6a87-4dbf-880e-520ad22bf330"), 732624581L, "dummyEmailHash", "firstName284", "firstName284", "dummyPasswordHash", "TestStudent284" },
                    { new Guid("fb65a8c2-8073-4046-9c10-6b539ac221b9"), 732624581L, "dummyEmailHash", "firstName162", "firstName162", "dummyPasswordHash", "TestStudent162" },
                    { new Guid("5d6d0787-c41c-4074-b4c7-f1a7466cbc80"), 732624581L, "dummyEmailHash", "firstName114", "firstName114", "dummyPasswordHash", "TestStudent114" },
                    { new Guid("40659082-765c-455c-98e9-f338a60fbd3d"), 732624581L, "dummyEmailHash", "firstName160", "firstName160", "dummyPasswordHash", "TestStudent160" },
                    { new Guid("2293caa9-4cb8-4398-b99c-21e35429c8bb"), 732624581L, "dummyEmailHash", "firstName56", "firstName56", "dummyPasswordHash", "TestStudent56" },
                    { new Guid("ec22172b-660c-46e4-a4a6-283e08b96740"), 732624581L, "dummyEmailHash", "firstName55", "firstName55", "dummyPasswordHash", "TestStudent55" },
                    { new Guid("38fbaba1-020b-47cd-b57d-557d02d9f38b"), 732624581L, "dummyEmailHash", "firstName54", "firstName54", "dummyPasswordHash", "TestStudent54" },
                    { new Guid("ab5d06a7-851c-46e7-8f5e-6153419ce8fc"), 732624581L, "dummyEmailHash", "firstName53", "firstName53", "dummyPasswordHash", "TestStudent53" },
                    { new Guid("eceeb4fa-d83e-49dc-98cc-c3b1c3b7ee75"), 732624581L, "dummyEmailHash", "firstName52", "firstName52", "dummyPasswordHash", "TestStudent52" },
                    { new Guid("83649640-cd1c-430e-8978-04c7465128ea"), 732624581L, "dummyEmailHash", "firstName51", "firstName51", "dummyPasswordHash", "TestStudent51" },
                    { new Guid("ba7ba6f5-efce-4ff6-a596-7754338da65d"), 732624581L, "dummyEmailHash", "firstName50", "firstName50", "dummyPasswordHash", "TestStudent50" },
                    { new Guid("ca1c12ca-c9a3-4695-bdfe-a24b5cc068a8"), 732624581L, "dummyEmailHash", "firstName57", "firstName57", "dummyPasswordHash", "TestStudent57" },
                    { new Guid("1c34551e-db99-4e22-a0d3-335ae0365e2e"), 732624581L, "dummyEmailHash", "firstName49", "firstName49", "dummyPasswordHash", "TestStudent49" },
                    { new Guid("e7c67907-2ba5-4cab-acc2-3d074a1b04fd"), 732624581L, "dummyEmailHash", "firstName47", "firstName47", "dummyPasswordHash", "TestStudent47" },
                    { new Guid("f9d9c6ab-9605-4be0-bf73-3138e09485d9"), 732624581L, "dummyEmailHash", "firstName46", "firstName46", "dummyPasswordHash", "TestStudent46" },
                    { new Guid("b8f0a5f6-f95b-4229-b5ac-bcb93cda97c9"), 732624581L, "dummyEmailHash", "firstName45", "firstName45", "dummyPasswordHash", "TestStudent45" },
                    { new Guid("a69b8d47-1187-45d4-814a-ce9257946a4a"), 732624581L, "dummyEmailHash", "firstName44", "firstName44", "dummyPasswordHash", "TestStudent44" },
                    { new Guid("f2737157-9ceb-4e62-8fa1-7ac95b94b535"), 732624581L, "dummyEmailHash", "firstName43", "firstName43", "dummyPasswordHash", "TestStudent43" },
                    { new Guid("9fca6d1c-5d29-422f-b697-13089f084804"), 732624581L, "dummyEmailHash", "firstName42", "firstName42", "dummyPasswordHash", "TestStudent42" },
                    { new Guid("04201684-7bb9-429d-bf97-94614d7fb528"), 732624581L, "dummyEmailHash", "firstName41", "firstName41", "dummyPasswordHash", "TestStudent41" },
                    { new Guid("cae8f338-75fb-43b8-85a0-da555be55727"), 732624581L, "dummyEmailHash", "firstName48", "firstName48", "dummyPasswordHash", "TestStudent48" },
                    { new Guid("2013f71f-3396-4c41-9978-79a219896a6c"), 732624581L, "dummyEmailHash", "firstName58", "firstName58", "dummyPasswordHash", "TestStudent58" },
                    { new Guid("78d042f0-bc66-4142-9ca0-360d532a84de"), 732624581L, "dummyEmailHash", "firstName59", "firstName59", "dummyPasswordHash", "TestStudent59" },
                    { new Guid("51d3c047-04b2-4180-999e-45fc5f34c085"), 732624581L, "dummyEmailHash", "firstName60", "firstName60", "dummyPasswordHash", "TestStudent60" },
                    { new Guid("9be9c274-648c-4e23-869a-2edd4c2a203f"), 732624581L, "dummyEmailHash", "firstName77", "firstName77", "dummyPasswordHash", "TestStudent77" },
                    { new Guid("eb173913-be12-4ec9-823d-a76228d49f25"), 732624581L, "dummyEmailHash", "firstName76", "firstName76", "dummyPasswordHash", "TestStudent76" },
                    { new Guid("ff362916-b504-41a3-805f-fc866fcc9869"), 732624581L, "dummyEmailHash", "firstName75", "firstName75", "dummyPasswordHash", "TestStudent75" },
                    { new Guid("4eb30257-b721-4f03-a24d-4d7aa9f1c081"), 732624581L, "dummyEmailHash", "firstName74", "firstName74", "dummyPasswordHash", "TestStudent74" },
                    { new Guid("6f55bc98-5098-49fe-a642-b160755432cf"), 732624581L, "dummyEmailHash", "firstName73", "firstName73", "dummyPasswordHash", "TestStudent73" },
                    { new Guid("9c652d82-d255-4153-9534-f16d659220ce"), 732624581L, "dummyEmailHash", "firstName72", "firstName72", "dummyPasswordHash", "TestStudent72" },
                    { new Guid("9f8f6a89-2419-4fe3-8a66-fa9966a98ee5"), 732624581L, "dummyEmailHash", "firstName71", "firstName71", "dummyPasswordHash", "TestStudent71" },
                    { new Guid("aa3169d1-bbfd-4933-85c2-4f49f3676855"), 732624581L, "dummyEmailHash", "firstName70", "firstName70", "dummyPasswordHash", "TestStudent70" },
                    { new Guid("c3669e5f-71a0-44ab-8a3c-14b02846bbbb"), 732624581L, "dummyEmailHash", "firstName69", "firstName69", "dummyPasswordHash", "TestStudent69" },
                    { new Guid("ad12e637-d343-4408-84a9-65cfdfe3dc73"), 732624581L, "dummyEmailHash", "firstName68", "firstName68", "dummyPasswordHash", "TestStudent68" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "EmailHash", "FirstName", "LastName", "PasswordHash", "Username" },
                values: new object[,]
                {
                    { new Guid("388b0f4a-ed15-4d7b-8a5c-b99ad1cbdad3"), 732624581L, "dummyEmailHash", "firstName67", "firstName67", "dummyPasswordHash", "TestStudent67" },
                    { new Guid("74a2131e-49ca-42e8-a50a-fa8addb3a3bd"), 732624581L, "dummyEmailHash", "firstName66", "firstName66", "dummyPasswordHash", "TestStudent66" },
                    { new Guid("9987eb5c-dc02-43ab-a1e1-cb2f9eb6e3f9"), 732624581L, "dummyEmailHash", "firstName65", "firstName65", "dummyPasswordHash", "TestStudent65" },
                    { new Guid("55fb4ed3-8a69-450a-b8e9-8256f5492496"), 732624581L, "dummyEmailHash", "firstName64", "firstName64", "dummyPasswordHash", "TestStudent64" },
                    { new Guid("ed47126b-bac0-4ee1-9089-29594f549127"), 732624581L, "dummyEmailHash", "firstName63", "firstName63", "dummyPasswordHash", "TestStudent63" },
                    { new Guid("88cd4327-729b-43d5-8e52-9b4d0b2665e8"), 732624581L, "dummyEmailHash", "firstName62", "firstName62", "dummyPasswordHash", "TestStudent62" },
                    { new Guid("a1c21055-059f-4bbe-91ce-6b5b74b60ce6"), 732624581L, "dummyEmailHash", "firstName61", "firstName61", "dummyPasswordHash", "TestStudent61" },
                    { new Guid("fce2f744-4445-4d77-abd6-483200dbd9a9"), 732624581L, "dummyEmailHash", "firstName40", "firstName40", "dummyPasswordHash", "TestStudent40" },
                    { new Guid("76e619ff-b12b-448b-b12d-bd6cf3a02da6"), 732624581L, "dummyEmailHash", "firstName161", "firstName161", "dummyPasswordHash", "TestStudent161" },
                    { new Guid("88fbf6b1-56bf-4244-adb3-1b9a1986c34f"), 732624581L, "dummyEmailHash", "firstName39", "firstName39", "dummyPasswordHash", "TestStudent39" },
                    { new Guid("6edc5e82-759e-4728-971d-2cab78fef5cf"), 732624581L, "dummyEmailHash", "firstName37", "firstName37", "dummyPasswordHash", "TestStudent37" },
                    { new Guid("69a77913-f8e0-43bc-80cf-55f4bc8b41d3"), 732624581L, "dummyEmailHash", "firstName15", "firstName15", "dummyPasswordHash", "TestStudent15" },
                    { new Guid("8161fc28-57b1-490a-88c5-f303538d27fa"), 732624581L, "dummyEmailHash", "firstName14", "firstName14", "dummyPasswordHash", "TestStudent14" },
                    { new Guid("655f95ab-ffd9-45cb-adb0-2a7315670381"), 732624581L, "dummyEmailHash", "firstName13", "firstName13", "dummyPasswordHash", "TestStudent13" },
                    { new Guid("97f1089f-26bb-47bb-8299-efb8f02e1957"), 732624581L, "dummyEmailHash", "firstName12", "firstName12", "dummyPasswordHash", "TestStudent12" },
                    { new Guid("94966d72-ab9e-4689-9bc4-a9726cba0c1c"), 732624581L, "dummyEmailHash", "firstName11", "firstName11", "dummyPasswordHash", "TestStudent11" },
                    { new Guid("b4c433da-fbf6-4910-91fe-e04a44a3c9b2"), 732624581L, "dummyEmailHash", "firstName10", "firstName10", "dummyPasswordHash", "TestStudent10" },
                    { new Guid("dca63e32-3431-46ca-af05-696964ad8193"), 732624581L, "dummyEmailHash", "firstName9", "firstName9", "dummyPasswordHash", "TestStudent9" },
                    { new Guid("cebbf0a8-18f3-43fb-8063-756e6f1417f0"), 732624581L, "dummyEmailHash", "firstName16", "firstName16", "dummyPasswordHash", "TestStudent16" },
                    { new Guid("b415309e-197e-45fa-a326-ee54e2e51b5c"), 732624581L, "dummyEmailHash", "firstName8", "firstName8", "dummyPasswordHash", "TestStudent8" },
                    { new Guid("6d68095a-4db1-4645-9b89-b646fdca891b"), 732624581L, "dummyEmailHash", "firstName6", "firstName6", "dummyPasswordHash", "TestStudent6" },
                    { new Guid("ec510e3b-016c-42bb-9b5a-32b09d4e3ddb"), 732624581L, "dummyEmailHash", "firstName5", "firstName5", "dummyPasswordHash", "TestStudent5" },
                    { new Guid("a9dfc290-8b48-498a-be8d-7fdceae7d20e"), 732624581L, "dummyEmailHash", "firstName4", "firstName4", "dummyPasswordHash", "TestStudent4" },
                    { new Guid("7118da7d-3026-4168-9aff-ac661e2bb369"), 732624581L, "dummyEmailHash", "firstName3", "firstName3", "dummyPasswordHash", "TestStudent3" },
                    { new Guid("d9cefb51-8a84-4796-9613-67f6d7493cd7"), 732624581L, "dummyEmailHash", "firstName2", "firstName2", "dummyPasswordHash", "TestStudent2" },
                    { new Guid("ea092d03-3c10-4421-9662-10b66b385f11"), 732624581L, "dummyEmailHash", "firstName1", "firstName1", "dummyPasswordHash", "TestStudent1" },
                    { new Guid("8e0e2189-5374-4025-b8f6-51207e345bcb"), 732624581L, "dummyEmailHash", "firstName0", "firstName0", "dummyPasswordHash", "TestStudent0" },
                    { new Guid("db80d9ab-0020-4d56-b5db-e5ac0300504f"), 732624581L, "dummyEmailHash", "firstName7", "firstName7", "dummyPasswordHash", "TestStudent7" },
                    { new Guid("4bc14726-65e3-45a7-be85-fdb13ec2e979"), 732624581L, "dummyEmailHash", "firstName17", "firstName17", "dummyPasswordHash", "TestStudent17" },
                    { new Guid("873bf5e1-3a14-4ed3-9d3e-64c42719c71c"), 732624581L, "dummyEmailHash", "firstName18", "firstName18", "dummyPasswordHash", "TestStudent18" },
                    { new Guid("97f67177-05f3-44e5-9ba7-e5df48640131"), 732624581L, "dummyEmailHash", "firstName19", "firstName19", "dummyPasswordHash", "TestStudent19" },
                    { new Guid("8a18b36c-ceab-42bc-bf81-2070b160dfad"), 732624581L, "dummyEmailHash", "firstName36", "firstName36", "dummyPasswordHash", "TestStudent36" },
                    { new Guid("bef86030-c3dc-4c85-bf9f-c099d3ba22cd"), 732624581L, "dummyEmailHash", "firstName35", "firstName35", "dummyPasswordHash", "TestStudent35" },
                    { new Guid("518e33e2-cb30-43db-bf9b-0e72f8b841e1"), 732624581L, "dummyEmailHash", "firstName34", "firstName34", "dummyPasswordHash", "TestStudent34" },
                    { new Guid("a9acdf1f-282d-4dd4-910c-895b4f1eca25"), 732624581L, "dummyEmailHash", "firstName33", "firstName33", "dummyPasswordHash", "TestStudent33" },
                    { new Guid("9185cbfa-61d3-41bb-a7ad-6d2de2018983"), 732624581L, "dummyEmailHash", "firstName32", "firstName32", "dummyPasswordHash", "TestStudent32" },
                    { new Guid("261d21c8-2163-48ae-9c20-60e1b5a3132e"), 732624581L, "dummyEmailHash", "firstName31", "firstName31", "dummyPasswordHash", "TestStudent31" },
                    { new Guid("dba8fa82-2c7b-4b67-b548-619c324260dd"), 732624581L, "dummyEmailHash", "firstName30", "firstName30", "dummyPasswordHash", "TestStudent30" },
                    { new Guid("53dc3a1d-2aae-4534-a08f-ec97a382fe58"), 732624581L, "dummyEmailHash", "firstName29", "firstName29", "dummyPasswordHash", "TestStudent29" },
                    { new Guid("eb5f8810-fbd1-4dd6-94b3-579625ff346e"), 732624581L, "dummyEmailHash", "firstName28", "firstName28", "dummyPasswordHash", "TestStudent28" },
                    { new Guid("76f6c3c2-187a-4649-8a4c-f7e3cc1b1a4a"), 732624581L, "dummyEmailHash", "firstName27", "firstName27", "dummyPasswordHash", "TestStudent27" },
                    { new Guid("544997e0-2a82-4be5-9011-9f0195da70e4"), 732624581L, "dummyEmailHash", "firstName26", "firstName26", "dummyPasswordHash", "TestStudent26" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "EmailHash", "FirstName", "LastName", "PasswordHash", "Username" },
                values: new object[,]
                {
                    { new Guid("d2b93a5f-548f-46e2-82d2-7b4256ddc7c7"), 732624581L, "dummyEmailHash", "firstName25", "firstName25", "dummyPasswordHash", "TestStudent25" },
                    { new Guid("228de7c0-9100-4173-a73d-82a43496ceba"), 732624581L, "dummyEmailHash", "firstName24", "firstName24", "dummyPasswordHash", "TestStudent24" },
                    { new Guid("d3f255b5-1a24-4fdc-a8c4-8e4230821346"), 732624581L, "dummyEmailHash", "firstName23", "firstName23", "dummyPasswordHash", "TestStudent23" },
                    { new Guid("cd8d4b90-8223-446b-b2ef-9186c311d535"), 732624581L, "dummyEmailHash", "firstName22", "firstName22", "dummyPasswordHash", "TestStudent22" },
                    { new Guid("a0c41db5-510b-41dd-8030-d1c66fb7d09a"), 732624581L, "dummyEmailHash", "firstName21", "firstName21", "dummyPasswordHash", "TestStudent21" },
                    { new Guid("338856a0-41f5-4122-859c-ab548c3268b9"), 732624581L, "dummyEmailHash", "firstName20", "firstName20", "dummyPasswordHash", "TestStudent20" },
                    { new Guid("3560bafc-aea7-46bf-80b2-6d726b0631b6"), 732624581L, "dummyEmailHash", "firstName38", "firstName38", "dummyPasswordHash", "TestStudent38" },
                    { new Guid("d0124d76-39e2-486a-a981-13c8d86a6b3a"), 732624581L, "dummyEmailHash", "firstName79", "firstName79", "dummyPasswordHash", "TestStudent79" },
                    { new Guid("74ff278d-d314-4f09-8845-4fbc0ea1d379"), 732624581L, "dummyEmailHash", "firstName78", "firstName78", "dummyPasswordHash", "TestStudent78" },
                    { new Guid("8b557991-3975-4871-a5c8-252c248ab494"), 732624581L, "dummyEmailHash", "firstName81", "firstName81", "dummyPasswordHash", "TestStudent81" },
                    { new Guid("002a0c96-511b-461e-ac79-5bea5628fe6e"), 732624581L, "dummyEmailHash", "firstName138", "firstName138", "dummyPasswordHash", "TestStudent138" },
                    { new Guid("19c3452d-a94d-4779-94ea-58f6505825a9"), 732624581L, "dummyEmailHash", "firstName137", "firstName137", "dummyPasswordHash", "TestStudent137" },
                    { new Guid("50fb7931-89aa-4f79-ab55-9412f253c4d5"), 732624581L, "dummyEmailHash", "firstName136", "firstName136", "dummyPasswordHash", "TestStudent136" },
                    { new Guid("36c84e5f-efed-46a9-9d91-d1e9e446a0de"), 732624581L, "dummyEmailHash", "firstName135", "firstName135", "dummyPasswordHash", "TestStudent135" },
                    { new Guid("84089d22-33d2-4f02-b3ad-e2f1d566826d"), 732624581L, "dummyEmailHash", "firstName134", "firstName134", "dummyPasswordHash", "TestStudent134" },
                    { new Guid("6f9f853c-fbd8-4bd1-bf90-35c81de11af2"), 732624581L, "dummyEmailHash", "firstName133", "firstName133", "dummyPasswordHash", "TestStudent133" },
                    { new Guid("97999cd8-82ae-4dbb-ad7d-9718ac62cc10"), 732624581L, "dummyEmailHash", "firstName132", "firstName132", "dummyPasswordHash", "TestStudent132" },
                    { new Guid("19f553a5-d493-49b8-aa3f-868d51b9e044"), 732624581L, "dummyEmailHash", "firstName139", "firstName139", "dummyPasswordHash", "TestStudent139" },
                    { new Guid("d7c37fe4-9402-4cb1-9683-8e929155ca02"), 732624581L, "dummyEmailHash", "firstName131", "firstName131", "dummyPasswordHash", "TestStudent131" },
                    { new Guid("cdd47089-5999-4d0c-8517-72682def3943"), 732624581L, "dummyEmailHash", "firstName129", "firstName129", "dummyPasswordHash", "TestStudent129" },
                    { new Guid("59bcacaf-37b5-4ab7-a9d8-3fa7f527b894"), 732624581L, "dummyEmailHash", "firstName128", "firstName128", "dummyPasswordHash", "TestStudent128" },
                    { new Guid("d35b0409-6a42-417c-b81a-84291d3819ea"), 732624581L, "dummyEmailHash", "firstName127", "firstName127", "dummyPasswordHash", "TestStudent127" },
                    { new Guid("359efe2a-afca-4c4e-be6d-cc40be28d0c4"), 732624581L, "dummyEmailHash", "firstName126", "firstName126", "dummyPasswordHash", "TestStudent126" },
                    { new Guid("97bbb4cc-6c1b-4c7a-b3f4-8de07361b810"), 732624581L, "dummyEmailHash", "firstName125", "firstName125", "dummyPasswordHash", "TestStudent125" },
                    { new Guid("eea5ce76-afe3-4daa-a76e-4b163eeb9368"), 732624581L, "dummyEmailHash", "firstName124", "firstName124", "dummyPasswordHash", "TestStudent124" },
                    { new Guid("9d72fe8f-6c84-4d52-a986-90ee9b005d05"), 732624581L, "dummyEmailHash", "firstName123", "firstName123", "dummyPasswordHash", "TestStudent123" },
                    { new Guid("625247ff-426e-428b-8516-0eb1f3bf85a1"), 732624581L, "dummyEmailHash", "firstName130", "firstName130", "dummyPasswordHash", "TestStudent130" },
                    { new Guid("69ef18e5-8b3c-46e6-9fe2-549ab2d0ec82"), 732624581L, "dummyEmailHash", "firstName140", "firstName140", "dummyPasswordHash", "TestStudent140" },
                    { new Guid("e60ab03b-bdcc-4157-8f18-a5469b9148f2"), 732624581L, "dummyEmailHash", "firstName141", "firstName141", "dummyPasswordHash", "TestStudent141" },
                    { new Guid("e5879d89-0151-4665-ab4e-0c5bbf4d989d"), 732624581L, "dummyEmailHash", "firstName142", "firstName142", "dummyPasswordHash", "TestStudent142" },
                    { new Guid("5d47e3ec-3aa5-4829-a899-37981125aaea"), 732624581L, "dummyEmailHash", "firstName159", "firstName159", "dummyPasswordHash", "TestStudent159" },
                    { new Guid("3611bf43-72e0-4091-be75-34dfe31baa6d"), 732624581L, "dummyEmailHash", "firstName158", "firstName158", "dummyPasswordHash", "TestStudent158" },
                    { new Guid("32f863c9-58ae-4229-8a5c-6ce4fffa7864"), 732624581L, "dummyEmailHash", "firstName157", "firstName157", "dummyPasswordHash", "TestStudent157" },
                    { new Guid("ad76fee0-0c33-421b-a277-f02dd4ae6c0d"), 732624581L, "dummyEmailHash", "firstName156", "firstName156", "dummyPasswordHash", "TestStudent156" },
                    { new Guid("58d96033-418d-4dc3-a70d-a7536f044873"), 732624581L, "dummyEmailHash", "firstName155", "firstName155", "dummyPasswordHash", "TestStudent155" },
                    { new Guid("32ff53c3-461d-4dc8-a6ef-d77b7cad6b66"), 732624581L, "dummyEmailHash", "firstName154", "firstName154", "dummyPasswordHash", "TestStudent154" },
                    { new Guid("1eacd3b6-a453-4919-bc4a-3f59ff2b2743"), 732624581L, "dummyEmailHash", "firstName153", "firstName153", "dummyPasswordHash", "TestStudent153" },
                    { new Guid("f4422084-ef6c-4bf7-a412-fcec3dd78ee7"), 732624581L, "dummyEmailHash", "firstName152", "firstName152", "dummyPasswordHash", "TestStudent152" },
                    { new Guid("2c827012-0335-4c2e-bbfc-f80b250e189c"), 732624581L, "dummyEmailHash", "firstName151", "firstName151", "dummyPasswordHash", "TestStudent151" },
                    { new Guid("ff7af21a-daa6-4288-8bc4-31a72f230c93"), 732624581L, "dummyEmailHash", "firstName150", "firstName150", "dummyPasswordHash", "TestStudent150" },
                    { new Guid("196de7ae-4595-4429-bc09-998f63d8436d"), 732624581L, "dummyEmailHash", "firstName149", "firstName149", "dummyPasswordHash", "TestStudent149" },
                    { new Guid("c569615a-67d0-4597-a351-bd3073a0c9d4"), 732624581L, "dummyEmailHash", "firstName148", "firstName148", "dummyPasswordHash", "TestStudent148" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "EmailHash", "FirstName", "LastName", "PasswordHash", "Username" },
                values: new object[,]
                {
                    { new Guid("e8df6e37-707f-4e6b-af64-b8652ee07926"), 732624581L, "dummyEmailHash", "firstName147", "firstName147", "dummyPasswordHash", "TestStudent147" },
                    { new Guid("2e712574-f6b7-41a1-b35e-b80dece3e13c"), 732624581L, "dummyEmailHash", "firstName146", "firstName146", "dummyPasswordHash", "TestStudent146" },
                    { new Guid("292911d0-a38d-4b62-a640-a3d750795509"), 732624581L, "dummyEmailHash", "firstName145", "firstName145", "dummyPasswordHash", "TestStudent145" },
                    { new Guid("36191ab2-a154-4af1-9425-c1656f15de98"), 732624581L, "dummyEmailHash", "firstName144", "firstName144", "dummyPasswordHash", "TestStudent144" },
                    { new Guid("5150df5f-1496-48a1-86ed-a7d48d1ff598"), 732624581L, "dummyEmailHash", "firstName143", "firstName143", "dummyPasswordHash", "TestStudent143" },
                    { new Guid("6bbc0ee6-4921-4439-b34b-72fdc83f9961"), 732624581L, "dummyEmailHash", "firstName80", "firstName80", "dummyPasswordHash", "TestStudent80" },
                    { new Guid("642c916d-a67e-49e6-916e-1217ee9eb077"), 732624581L, "dummyEmailHash", "firstName121", "firstName121", "dummyPasswordHash", "TestStudent121" },
                    { new Guid("29920b9d-cd90-4115-bc6a-1cfcee40ddbd"), 732624581L, "dummyEmailHash", "firstName122", "firstName122", "dummyPasswordHash", "TestStudent122" },
                    { new Guid("dc42ee9a-f036-4860-b625-c2abe67475ab"), 732624581L, "dummyEmailHash", "firstName119", "firstName119", "dummyPasswordHash", "TestStudent119" },
                    { new Guid("36c1f06d-9cc7-47e2-9c3e-7c44a569f1a0"), 732624581L, "dummyEmailHash", "firstName97", "firstName97", "dummyPasswordHash", "TestStudent97" },
                    { new Guid("71256187-2515-46fd-825a-efcbba5066b4"), 732624581L, "dummyEmailHash", "firstName96", "firstName96", "dummyPasswordHash", "TestStudent96" },
                    { new Guid("6c6064f2-6066-42a0-9122-fe6d38ee9332"), 732624581L, "dummyEmailHash", "firstName95", "firstName95", "dummyPasswordHash", "TestStudent95" },
                    { new Guid("8980183f-e781-4fe8-abb8-e5314452fb20"), 732624581L, "dummyEmailHash", "firstName94", "firstName94", "dummyPasswordHash", "TestStudent94" },
                    { new Guid("09d18b54-641b-41c3-a496-2063e0bb4b4e"), 732624581L, "dummyEmailHash", "firstName93", "firstName93", "dummyPasswordHash", "TestStudent93" },
                    { new Guid("b12ba677-c23e-418e-93f2-3e253fd45a88"), 732624581L, "dummyEmailHash", "firstName92", "firstName92", "dummyPasswordHash", "TestStudent92" },
                    { new Guid("392d2f6e-c8c2-435e-9cc7-f2a5db0b0099"), 732624581L, "dummyEmailHash", "firstName91", "firstName91", "dummyPasswordHash", "TestStudent91" },
                    { new Guid("968d81c5-f9d0-4cbb-9d55-928cc83498eb"), 732624581L, "dummyEmailHash", "firstName120", "firstName120", "dummyPasswordHash", "TestStudent120" },
                    { new Guid("72174b2b-530c-4f9d-a934-9085d0694ef9"), 732624581L, "dummyEmailHash", "firstName90", "firstName90", "dummyPasswordHash", "TestStudent90" },
                    { new Guid("bb83e0e2-a245-4253-8ad6-433d65b84031"), 732624581L, "dummyEmailHash", "firstName88", "firstName88", "dummyPasswordHash", "TestStudent88" },
                    { new Guid("1f8d5abe-daa1-476d-98cf-622a9f45c4c4"), 732624581L, "dummyEmailHash", "firstName87", "firstName87", "dummyPasswordHash", "TestStudent87" },
                    { new Guid("efe3adef-fe2c-4659-9796-f66fc524f45f"), 732624581L, "dummyEmailHash", "firstName86", "firstName86", "dummyPasswordHash", "TestStudent86" },
                    { new Guid("4ea85f44-5fcf-4ae5-afba-297b2201cf9a"), 732624581L, "dummyEmailHash", "firstName85", "firstName85", "dummyPasswordHash", "TestStudent85" },
                    { new Guid("a17a90ca-5e60-4b66-845c-74014cec6ee3"), 732624581L, "dummyEmailHash", "firstName84", "firstName84", "dummyPasswordHash", "TestStudent84" },
                    { new Guid("955fa333-9b43-4fa7-9329-01f29609ea7b"), 732624581L, "dummyEmailHash", "firstName83", "firstName83", "dummyPasswordHash", "TestStudent83" },
                    { new Guid("20c81011-191a-4c09-973b-0e2eabbfcf80"), 732624581L, "dummyEmailHash", "firstName82", "firstName82", "dummyPasswordHash", "TestStudent82" },
                    { new Guid("c2bc1dd8-6eb7-460d-8dc4-3fe5eccc24a0"), 732624581L, "dummyEmailHash", "firstName89", "firstName89", "dummyPasswordHash", "TestStudent89" },
                    { new Guid("e0b609ea-aa32-44f3-addd-6cc9cb6c1576"), 732624581L, "dummyEmailHash", "firstName99", "firstName99", "dummyPasswordHash", "TestStudent99" },
                    { new Guid("0eccb1ed-df7f-47bc-874e-f9be50a6e2d1"), 732624581L, "dummyEmailHash", "firstName98", "firstName98", "dummyPasswordHash", "TestStudent98" },
                    { new Guid("3b39b3fd-9031-4b82-979b-b5e2bb597871"), 732624581L, "dummyEmailHash", "firstName101", "firstName101", "dummyPasswordHash", "TestStudent101" },
                    { new Guid("d7d3e120-2400-4fca-ab64-99e754c8039a"), 732624581L, "dummyEmailHash", "firstName118", "firstName118", "dummyPasswordHash", "TestStudent118" },
                    { new Guid("46b827f8-0528-4747-8e42-a82d587cd9db"), 732624581L, "dummyEmailHash", "firstName117", "firstName117", "dummyPasswordHash", "TestStudent117" },
                    { new Guid("4faeaa19-6a39-4988-875e-ab5948b470f0"), 732624581L, "dummyEmailHash", "firstName116", "firstName116", "dummyPasswordHash", "TestStudent116" },
                    { new Guid("a0bee3b3-e030-4f4b-93cd-0b1da3e772b3"), 732624581L, "dummyEmailHash", "firstName115", "firstName115", "dummyPasswordHash", "TestStudent115" },
                    { new Guid("453cd121-87f0-444e-a4c0-10a4beb11f49"), 732624581L, "dummyEmailHash", "firstName113", "firstName113", "dummyPasswordHash", "TestStudent113" },
                    { new Guid("baae8c9f-ed52-4842-ab91-7ef98ac9012d"), 732624581L, "dummyEmailHash", "firstName100", "firstName100", "dummyPasswordHash", "TestStudent100" },
                    { new Guid("8a71b582-13e4-4e0d-a661-e00cb1b7432e"), 732624581L, "dummyEmailHash", "firstName111", "firstName111", "dummyPasswordHash", "TestStudent111" },
                    { new Guid("de89dd7a-ab66-4c01-b33b-51b469b1de87"), 732624581L, "dummyEmailHash", "firstName110", "firstName110", "dummyPasswordHash", "TestStudent110" },
                    { new Guid("d285a66b-b98b-42e5-adac-95e9838a7f6d"), 732624581L, "dummyEmailHash", "firstName112", "firstName112", "dummyPasswordHash", "TestStudent112" },
                    { new Guid("569d1736-12d0-47a0-a7c9-d404c7c25112"), 732624581L, "dummyEmailHash", "firstName108", "firstName108", "dummyPasswordHash", "TestStudent108" },
                    { new Guid("eb981660-a462-4f74-b527-2d6ff4ea3223"), 732624581L, "dummyEmailHash", "firstName107", "firstName107", "dummyPasswordHash", "TestStudent107" },
                    { new Guid("4e25fbfe-0e0d-4ed3-b194-5e3ba951bad9"), 732624581L, "dummyEmailHash", "firstName106", "firstName106", "dummyPasswordHash", "TestStudent106" },
                    { new Guid("327387fd-7b3c-42b9-8d0f-1b350148e96c"), 732624581L, "dummyEmailHash", "firstName105", "firstName105", "dummyPasswordHash", "TestStudent105" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "EmailHash", "FirstName", "LastName", "PasswordHash", "Username" },
                values: new object[,]
                {
                    { new Guid("3f4dff8f-2572-4eb8-89ba-73b9596024d7"), 732624581L, "dummyEmailHash", "firstName104", "firstName104", "dummyPasswordHash", "TestStudent104" },
                    { new Guid("8c0ce950-4e74-44dd-b6a4-f21f74df87f9"), 732624581L, "dummyEmailHash", "firstName103", "firstName103", "dummyPasswordHash", "TestStudent103" },
                    { new Guid("b4c5f4ed-6d5e-4755-b911-43eebcacda5f"), 732624581L, "dummyEmailHash", "firstName102", "firstName102", "dummyPasswordHash", "TestStudent102" },
                    { new Guid("a5a8add7-64aa-4a2c-b735-2f597e575147"), 732624581L, "dummyEmailHash", "firstName109", "firstName109", "dummyPasswordHash", "TestStudent109" }
                });

            migrationBuilder.InsertData(
                table: "TeacherDegrees",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("91cbe875-cba6-4e81-99e2-4ca22a05d9c0"), "TeacherDegree3" },
                    { new Guid("816f0ede-8d86-4950-b07a-2608f8ef7337"), "TeacherDegree0" },
                    { new Guid("f477eee4-f353-4e53-ba72-d3f4b1638528"), "TeacherDegree1" },
                    { new Guid("0eadfc3a-fd1c-451f-993b-4c059335c127"), "TeacherDegree2" },
                    { new Guid("4cf4fc0a-47ad-4640-826d-1ae2982344d2"), "TeacherDegree4" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "DateOfBirth", "EmailHash", "FirstName", "LastName", "PasswordHash", "Salt", "TeacherDegreeId", "Username" },
                values: new object[,]
                {
                    { new Guid("d520389d-d791-479c-a509-27d5bb244858"), 732624581L, "dummyEmailHash", "firstName0", "firstName0", "dummyPasswordHash", "dummySalt", new Guid("816f0ede-8d86-4950-b07a-2608f8ef7337"), "TestTeacher0" },
                    { new Guid("63af8a63-3d9f-4a25-8e2c-db885be41b6e"), 732624581L, "dummyEmailHash", "firstName63", "firstName63", "dummyPasswordHash", "dummySalt", new Guid("91cbe875-cba6-4e81-99e2-4ca22a05d9c0"), "TestTeacher63" },
                    { new Guid("0eafc5e8-bb25-43ce-aa71-fac4ee547b1c"), 732624581L, "dummyEmailHash", "firstName58", "firstName58", "dummyPasswordHash", "dummySalt", new Guid("91cbe875-cba6-4e81-99e2-4ca22a05d9c0"), "TestTeacher58" },
                    { new Guid("fa322a6f-6d03-46c5-a563-fb058063c944"), 732624581L, "dummyEmailHash", "firstName53", "firstName53", "dummyPasswordHash", "dummySalt", new Guid("91cbe875-cba6-4e81-99e2-4ca22a05d9c0"), "TestTeacher53" },
                    { new Guid("0714acfd-7b85-4714-95a4-2693f68cc7fe"), 732624581L, "dummyEmailHash", "firstName48", "firstName48", "dummyPasswordHash", "dummySalt", new Guid("91cbe875-cba6-4e81-99e2-4ca22a05d9c0"), "TestTeacher48" },
                    { new Guid("b6fa213a-f7e3-453c-8d0c-7f4e3fbda256"), 732624581L, "dummyEmailHash", "firstName43", "firstName43", "dummyPasswordHash", "dummySalt", new Guid("91cbe875-cba6-4e81-99e2-4ca22a05d9c0"), "TestTeacher43" },
                    { new Guid("f60e2337-f07e-45d8-9aa3-5e8314156a8d"), 732624581L, "dummyEmailHash", "firstName38", "firstName38", "dummyPasswordHash", "dummySalt", new Guid("91cbe875-cba6-4e81-99e2-4ca22a05d9c0"), "TestTeacher38" },
                    { new Guid("e13a6b5d-7312-488e-9cea-5f449d9b6ed5"), 732624581L, "dummyEmailHash", "firstName33", "firstName33", "dummyPasswordHash", "dummySalt", new Guid("91cbe875-cba6-4e81-99e2-4ca22a05d9c0"), "TestTeacher33" },
                    { new Guid("fd7aa746-fa3d-4b6c-bfc4-180fa0062035"), 732624581L, "dummyEmailHash", "firstName28", "firstName28", "dummyPasswordHash", "dummySalt", new Guid("91cbe875-cba6-4e81-99e2-4ca22a05d9c0"), "TestTeacher28" },
                    { new Guid("dc366896-8c46-4e59-86b1-7be25e6b25cf"), 732624581L, "dummyEmailHash", "firstName23", "firstName23", "dummyPasswordHash", "dummySalt", new Guid("91cbe875-cba6-4e81-99e2-4ca22a05d9c0"), "TestTeacher23" },
                    { new Guid("6489c875-e57b-49e3-b8db-13d8166de086"), 732624581L, "dummyEmailHash", "firstName18", "firstName18", "dummyPasswordHash", "dummySalt", new Guid("91cbe875-cba6-4e81-99e2-4ca22a05d9c0"), "TestTeacher18" },
                    { new Guid("4d6becdd-d8c4-409d-905b-e152c03679f2"), 732624581L, "dummyEmailHash", "firstName13", "firstName13", "dummyPasswordHash", "dummySalt", new Guid("91cbe875-cba6-4e81-99e2-4ca22a05d9c0"), "TestTeacher13" },
                    { new Guid("5b0e27a8-b03b-405e-9d61-be91ffb92942"), 732624581L, "dummyEmailHash", "firstName8", "firstName8", "dummyPasswordHash", "dummySalt", new Guid("91cbe875-cba6-4e81-99e2-4ca22a05d9c0"), "TestTeacher8" },
                    { new Guid("3e2c035a-3595-4ba5-a65c-d7e11fd02240"), 732624581L, "dummyEmailHash", "firstName3", "firstName3", "dummyPasswordHash", "dummySalt", new Guid("91cbe875-cba6-4e81-99e2-4ca22a05d9c0"), "TestTeacher3" },
                    { new Guid("923257c6-f46b-4250-8337-b6ac1f4357ca"), 732624581L, "dummyEmailHash", "firstName97", "firstName97", "dummyPasswordHash", "dummySalt", new Guid("0eadfc3a-fd1c-451f-993b-4c059335c127"), "TestTeacher97" },
                    { new Guid("f0b375b4-3975-4e1e-9ea4-49b33f1fa3c9"), 732624581L, "dummyEmailHash", "firstName92", "firstName92", "dummyPasswordHash", "dummySalt", new Guid("0eadfc3a-fd1c-451f-993b-4c059335c127"), "TestTeacher92" },
                    { new Guid("0db6ac70-8dd3-4da1-bcff-27696faa9338"), 732624581L, "dummyEmailHash", "firstName87", "firstName87", "dummyPasswordHash", "dummySalt", new Guid("0eadfc3a-fd1c-451f-993b-4c059335c127"), "TestTeacher87" },
                    { new Guid("50e805fc-950a-4835-b29b-6cee79b22045"), 732624581L, "dummyEmailHash", "firstName82", "firstName82", "dummyPasswordHash", "dummySalt", new Guid("0eadfc3a-fd1c-451f-993b-4c059335c127"), "TestTeacher82" },
                    { new Guid("ef9025e8-8f9b-49e2-862f-d9f742990e86"), 732624581L, "dummyEmailHash", "firstName77", "firstName77", "dummyPasswordHash", "dummySalt", new Guid("0eadfc3a-fd1c-451f-993b-4c059335c127"), "TestTeacher77" },
                    { new Guid("d889d0ce-23d0-4a95-bd16-51e3a1cf0ce7"), 732624581L, "dummyEmailHash", "firstName72", "firstName72", "dummyPasswordHash", "dummySalt", new Guid("0eadfc3a-fd1c-451f-993b-4c059335c127"), "TestTeacher72" },
                    { new Guid("b26cb6d2-a318-447d-a303-57c481a8df2c"), 732624581L, "dummyEmailHash", "firstName67", "firstName67", "dummyPasswordHash", "dummySalt", new Guid("0eadfc3a-fd1c-451f-993b-4c059335c127"), "TestTeacher67" },
                    { new Guid("63d077b3-c8e6-414f-9036-959e8c825846"), 732624581L, "dummyEmailHash", "firstName62", "firstName62", "dummyPasswordHash", "dummySalt", new Guid("0eadfc3a-fd1c-451f-993b-4c059335c127"), "TestTeacher62" },
                    { new Guid("af0a604d-1fc1-4e3f-b242-2acd97d398f3"), 732624581L, "dummyEmailHash", "firstName68", "firstName68", "dummyPasswordHash", "dummySalt", new Guid("91cbe875-cba6-4e81-99e2-4ca22a05d9c0"), "TestTeacher68" },
                    { new Guid("8762d3cf-d975-4550-b61c-1b891a10d890"), 732624581L, "dummyEmailHash", "firstName57", "firstName57", "dummyPasswordHash", "dummySalt", new Guid("0eadfc3a-fd1c-451f-993b-4c059335c127"), "TestTeacher57" },
                    { new Guid("b8280292-5d91-45f6-9e15-c45f342b22b9"), 732624581L, "dummyEmailHash", "firstName73", "firstName73", "dummyPasswordHash", "dummySalt", new Guid("91cbe875-cba6-4e81-99e2-4ca22a05d9c0"), "TestTeacher73" },
                    { new Guid("55bcdfb7-5436-425f-aa75-67ed0bec3c6d"), 732624581L, "dummyEmailHash", "firstName83", "firstName83", "dummyPasswordHash", "dummySalt", new Guid("91cbe875-cba6-4e81-99e2-4ca22a05d9c0"), "TestTeacher83" },
                    { new Guid("320b7836-0470-4b4a-8ee5-5146e0766166"), 732624581L, "dummyEmailHash", "firstName89", "firstName89", "dummyPasswordHash", "dummySalt", new Guid("4cf4fc0a-47ad-4640-826d-1ae2982344d2"), "TestTeacher89" },
                    { new Guid("ccb7a87a-5a14-4961-8ca6-8063675b2bce"), 732624581L, "dummyEmailHash", "firstName84", "firstName84", "dummyPasswordHash", "dummySalt", new Guid("4cf4fc0a-47ad-4640-826d-1ae2982344d2"), "TestTeacher84" },
                    { new Guid("2aeea0c4-8fec-45f9-a6b0-e00afbf6f983"), 732624581L, "dummyEmailHash", "firstName79", "firstName79", "dummyPasswordHash", "dummySalt", new Guid("4cf4fc0a-47ad-4640-826d-1ae2982344d2"), "TestTeacher79" },
                    { new Guid("6baee663-1d3a-4058-9a14-b4ed26be7e08"), 732624581L, "dummyEmailHash", "firstName74", "firstName74", "dummyPasswordHash", "dummySalt", new Guid("4cf4fc0a-47ad-4640-826d-1ae2982344d2"), "TestTeacher74" },
                    { new Guid("962082e2-14d7-498d-80fb-2427625c671a"), 732624581L, "dummyEmailHash", "firstName69", "firstName69", "dummyPasswordHash", "dummySalt", new Guid("4cf4fc0a-47ad-4640-826d-1ae2982344d2"), "TestTeacher69" },
                    { new Guid("4ec77cc4-e026-4c2c-ab7a-924771e1fb57"), 732624581L, "dummyEmailHash", "firstName64", "firstName64", "dummyPasswordHash", "dummySalt", new Guid("4cf4fc0a-47ad-4640-826d-1ae2982344d2"), "TestTeacher64" },
                    { new Guid("a90c16da-5d98-417b-b25e-97a364bd5cf8"), 732624581L, "dummyEmailHash", "firstName59", "firstName59", "dummyPasswordHash", "dummySalt", new Guid("4cf4fc0a-47ad-4640-826d-1ae2982344d2"), "TestTeacher59" },
                    { new Guid("471b80b9-dd36-4a48-89c2-39b5941f439d"), 732624581L, "dummyEmailHash", "firstName54", "firstName54", "dummyPasswordHash", "dummySalt", new Guid("4cf4fc0a-47ad-4640-826d-1ae2982344d2"), "TestTeacher54" },
                    { new Guid("0be65fce-7327-4fdb-97e8-4638e8061847"), 732624581L, "dummyEmailHash", "firstName49", "firstName49", "dummyPasswordHash", "dummySalt", new Guid("4cf4fc0a-47ad-4640-826d-1ae2982344d2"), "TestTeacher49" },
                    { new Guid("e8405a7e-6809-4ac1-951d-03781410be97"), 732624581L, "dummyEmailHash", "firstName44", "firstName44", "dummyPasswordHash", "dummySalt", new Guid("4cf4fc0a-47ad-4640-826d-1ae2982344d2"), "TestTeacher44" },
                    { new Guid("84ea72b7-9dc5-4c45-a282-0d138774b216"), 732624581L, "dummyEmailHash", "firstName39", "firstName39", "dummyPasswordHash", "dummySalt", new Guid("4cf4fc0a-47ad-4640-826d-1ae2982344d2"), "TestTeacher39" },
                    { new Guid("2a4c66f3-e06e-4d40-830b-2aff460b9aef"), 732624581L, "dummyEmailHash", "firstName34", "firstName34", "dummyPasswordHash", "dummySalt", new Guid("4cf4fc0a-47ad-4640-826d-1ae2982344d2"), "TestTeacher34" },
                    { new Guid("47d9fc1a-717f-4d80-a88a-79195ef4c6b1"), 732624581L, "dummyEmailHash", "firstName29", "firstName29", "dummyPasswordHash", "dummySalt", new Guid("4cf4fc0a-47ad-4640-826d-1ae2982344d2"), "TestTeacher29" },
                    { new Guid("1fd187e5-d7c8-42d2-81e4-fe3dde7b0701"), 732624581L, "dummyEmailHash", "firstName24", "firstName24", "dummyPasswordHash", "dummySalt", new Guid("4cf4fc0a-47ad-4640-826d-1ae2982344d2"), "TestTeacher24" },
                    { new Guid("0ca079c5-33ca-4528-a75a-d9207ff75e6c"), 732624581L, "dummyEmailHash", "firstName19", "firstName19", "dummyPasswordHash", "dummySalt", new Guid("4cf4fc0a-47ad-4640-826d-1ae2982344d2"), "TestTeacher19" },
                    { new Guid("c6c1ba00-b0aa-47df-88f4-33af23ac06cb"), 732624581L, "dummyEmailHash", "firstName14", "firstName14", "dummyPasswordHash", "dummySalt", new Guid("4cf4fc0a-47ad-4640-826d-1ae2982344d2"), "TestTeacher14" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "DateOfBirth", "EmailHash", "FirstName", "LastName", "PasswordHash", "Salt", "TeacherDegreeId", "Username" },
                values: new object[,]
                {
                    { new Guid("56f39da2-627a-4954-8db5-d1b440669300"), 732624581L, "dummyEmailHash", "firstName9", "firstName9", "dummyPasswordHash", "dummySalt", new Guid("4cf4fc0a-47ad-4640-826d-1ae2982344d2"), "TestTeacher9" },
                    { new Guid("e2ba043f-3076-4149-a411-f3ec84d0ac5f"), 732624581L, "dummyEmailHash", "firstName4", "firstName4", "dummyPasswordHash", "dummySalt", new Guid("4cf4fc0a-47ad-4640-826d-1ae2982344d2"), "TestTeacher4" },
                    { new Guid("261fa621-17a3-42c6-a69b-f7116739e82b"), 732624581L, "dummyEmailHash", "firstName98", "firstName98", "dummyPasswordHash", "dummySalt", new Guid("91cbe875-cba6-4e81-99e2-4ca22a05d9c0"), "TestTeacher98" },
                    { new Guid("6354b09f-7243-4fb7-9695-f70ccf026e24"), 732624581L, "dummyEmailHash", "firstName93", "firstName93", "dummyPasswordHash", "dummySalt", new Guid("91cbe875-cba6-4e81-99e2-4ca22a05d9c0"), "TestTeacher93" },
                    { new Guid("04b536cf-d059-43f5-a187-012c25285d74"), 732624581L, "dummyEmailHash", "firstName88", "firstName88", "dummyPasswordHash", "dummySalt", new Guid("91cbe875-cba6-4e81-99e2-4ca22a05d9c0"), "TestTeacher88" },
                    { new Guid("ddd29bd3-3463-4300-aec9-f02ef123b657"), 732624581L, "dummyEmailHash", "firstName78", "firstName78", "dummyPasswordHash", "dummySalt", new Guid("91cbe875-cba6-4e81-99e2-4ca22a05d9c0"), "TestTeacher78" },
                    { new Guid("cd4fcdd9-3743-4d8d-823d-c16e81bf7feb"), 732624581L, "dummyEmailHash", "firstName52", "firstName52", "dummyPasswordHash", "dummySalt", new Guid("0eadfc3a-fd1c-451f-993b-4c059335c127"), "TestTeacher52" },
                    { new Guid("e05af25e-082a-4b80-a28f-832214ce10bc"), 732624581L, "dummyEmailHash", "firstName47", "firstName47", "dummyPasswordHash", "dummySalt", new Guid("0eadfc3a-fd1c-451f-993b-4c059335c127"), "TestTeacher47" },
                    { new Guid("b589b9ab-99a7-42e6-ada6-d1d692d94214"), 732624581L, "dummyEmailHash", "firstName42", "firstName42", "dummyPasswordHash", "dummySalt", new Guid("0eadfc3a-fd1c-451f-993b-4c059335c127"), "TestTeacher42" },
                    { new Guid("a37d6845-9076-475c-9302-4ca8b1f09f0f"), 732624581L, "dummyEmailHash", "firstName6", "firstName6", "dummyPasswordHash", "dummySalt", new Guid("f477eee4-f353-4e53-ba72-d3f4b1638528"), "TestTeacher6" },
                    { new Guid("51e9dc92-d8bc-4914-808a-9e4faaf09da6"), 732624581L, "dummyEmailHash", "firstName1", "firstName1", "dummyPasswordHash", "dummySalt", new Guid("f477eee4-f353-4e53-ba72-d3f4b1638528"), "TestTeacher1" },
                    { new Guid("a49dc22c-16b1-450f-bd05-54627b33a952"), 732624581L, "dummyEmailHash", "firstName95", "firstName95", "dummyPasswordHash", "dummySalt", new Guid("816f0ede-8d86-4950-b07a-2608f8ef7337"), "TestTeacher95" },
                    { new Guid("dc2dccbe-b289-444f-b374-df5eae1ea96a"), 732624581L, "dummyEmailHash", "firstName90", "firstName90", "dummyPasswordHash", "dummySalt", new Guid("816f0ede-8d86-4950-b07a-2608f8ef7337"), "TestTeacher90" },
                    { new Guid("db11804c-38ec-4fc9-8136-dc47b7b789e3"), 732624581L, "dummyEmailHash", "firstName85", "firstName85", "dummyPasswordHash", "dummySalt", new Guid("816f0ede-8d86-4950-b07a-2608f8ef7337"), "TestTeacher85" },
                    { new Guid("2b9f0266-611a-4820-b5c7-8d1bd747f55b"), 732624581L, "dummyEmailHash", "firstName80", "firstName80", "dummyPasswordHash", "dummySalt", new Guid("816f0ede-8d86-4950-b07a-2608f8ef7337"), "TestTeacher80" },
                    { new Guid("4b3c243d-26a2-430b-a779-cf81b39134eb"), 732624581L, "dummyEmailHash", "firstName75", "firstName75", "dummyPasswordHash", "dummySalt", new Guid("816f0ede-8d86-4950-b07a-2608f8ef7337"), "TestTeacher75" },
                    { new Guid("8ef9a447-3f54-4ebc-854d-d176e74601b4"), 732624581L, "dummyEmailHash", "firstName70", "firstName70", "dummyPasswordHash", "dummySalt", new Guid("816f0ede-8d86-4950-b07a-2608f8ef7337"), "TestTeacher70" },
                    { new Guid("be501952-af82-4aa8-813c-ebe8bb64cd67"), 732624581L, "dummyEmailHash", "firstName65", "firstName65", "dummyPasswordHash", "dummySalt", new Guid("816f0ede-8d86-4950-b07a-2608f8ef7337"), "TestTeacher65" },
                    { new Guid("6b5a6b95-6bd0-4340-babb-e56e9ac0171d"), 732624581L, "dummyEmailHash", "firstName60", "firstName60", "dummyPasswordHash", "dummySalt", new Guid("816f0ede-8d86-4950-b07a-2608f8ef7337"), "TestTeacher60" },
                    { new Guid("42be7409-d3d8-4bfd-880e-2d18372f07d6"), 732624581L, "dummyEmailHash", "firstName55", "firstName55", "dummyPasswordHash", "dummySalt", new Guid("816f0ede-8d86-4950-b07a-2608f8ef7337"), "TestTeacher55" },
                    { new Guid("a92a7897-7ed2-4983-a5e7-33d72a168392"), 732624581L, "dummyEmailHash", "firstName50", "firstName50", "dummyPasswordHash", "dummySalt", new Guid("816f0ede-8d86-4950-b07a-2608f8ef7337"), "TestTeacher50" },
                    { new Guid("8ec1697b-d4d9-4c6c-8d7e-a7a369a05831"), 732624581L, "dummyEmailHash", "firstName45", "firstName45", "dummyPasswordHash", "dummySalt", new Guid("816f0ede-8d86-4950-b07a-2608f8ef7337"), "TestTeacher45" },
                    { new Guid("c69543f7-c451-44af-8136-7600bf55903c"), 732624581L, "dummyEmailHash", "firstName40", "firstName40", "dummyPasswordHash", "dummySalt", new Guid("816f0ede-8d86-4950-b07a-2608f8ef7337"), "TestTeacher40" },
                    { new Guid("5166b68f-19c7-4295-8001-acab80e3be59"), 732624581L, "dummyEmailHash", "firstName35", "firstName35", "dummyPasswordHash", "dummySalt", new Guid("816f0ede-8d86-4950-b07a-2608f8ef7337"), "TestTeacher35" },
                    { new Guid("9d0e4158-3440-4bf7-b67d-078faeeddbcb"), 732624581L, "dummyEmailHash", "firstName30", "firstName30", "dummyPasswordHash", "dummySalt", new Guid("816f0ede-8d86-4950-b07a-2608f8ef7337"), "TestTeacher30" },
                    { new Guid("384f6076-f8f2-4e95-b51f-f0883a9a5576"), 732624581L, "dummyEmailHash", "firstName25", "firstName25", "dummyPasswordHash", "dummySalt", new Guid("816f0ede-8d86-4950-b07a-2608f8ef7337"), "TestTeacher25" },
                    { new Guid("a5b92ef6-ec55-4ce7-8fbf-2260b49d0ad7"), 732624581L, "dummyEmailHash", "firstName20", "firstName20", "dummyPasswordHash", "dummySalt", new Guid("816f0ede-8d86-4950-b07a-2608f8ef7337"), "TestTeacher20" },
                    { new Guid("b1b3057c-b83e-4a08-bc6a-9360d5af13bd"), 732624581L, "dummyEmailHash", "firstName15", "firstName15", "dummyPasswordHash", "dummySalt", new Guid("816f0ede-8d86-4950-b07a-2608f8ef7337"), "TestTeacher15" },
                    { new Guid("58f484aa-8ab3-44b3-979a-f5c7b99910f6"), 732624581L, "dummyEmailHash", "firstName10", "firstName10", "dummyPasswordHash", "dummySalt", new Guid("816f0ede-8d86-4950-b07a-2608f8ef7337"), "TestTeacher10" },
                    { new Guid("5b5bebc1-9a18-4276-8f59-032c426a7461"), 732624581L, "dummyEmailHash", "firstName5", "firstName5", "dummyPasswordHash", "dummySalt", new Guid("816f0ede-8d86-4950-b07a-2608f8ef7337"), "TestTeacher5" },
                    { new Guid("0f54ee42-1e4a-403c-89a7-9ed72d8f6725"), 732624581L, "dummyEmailHash", "firstName11", "firstName11", "dummyPasswordHash", "dummySalt", new Guid("f477eee4-f353-4e53-ba72-d3f4b1638528"), "TestTeacher11" },
                    { new Guid("1659619d-a195-40f0-9b32-7ae994c4f7c5"), 732624581L, "dummyEmailHash", "firstName16", "firstName16", "dummyPasswordHash", "dummySalt", new Guid("f477eee4-f353-4e53-ba72-d3f4b1638528"), "TestTeacher16" },
                    { new Guid("5599f6d0-3655-4d17-8ea1-096103c7b1a7"), 732624581L, "dummyEmailHash", "firstName21", "firstName21", "dummyPasswordHash", "dummySalt", new Guid("f477eee4-f353-4e53-ba72-d3f4b1638528"), "TestTeacher21" },
                    { new Guid("9bcbddf1-7697-462d-a409-ac2b527d26b9"), 732624581L, "dummyEmailHash", "firstName26", "firstName26", "dummyPasswordHash", "dummySalt", new Guid("f477eee4-f353-4e53-ba72-d3f4b1638528"), "TestTeacher26" },
                    { new Guid("6980f4f6-226e-4bbd-b4ed-4125c696f4d0"), 732624581L, "dummyEmailHash", "firstName37", "firstName37", "dummyPasswordHash", "dummySalt", new Guid("0eadfc3a-fd1c-451f-993b-4c059335c127"), "TestTeacher37" },
                    { new Guid("1bf88dee-3b4f-48fd-9679-6c90ced03977"), 732624581L, "dummyEmailHash", "firstName32", "firstName32", "dummyPasswordHash", "dummySalt", new Guid("0eadfc3a-fd1c-451f-993b-4c059335c127"), "TestTeacher32" },
                    { new Guid("0e9cfc47-3a8c-481d-ab60-4cbcc7d579e4"), 732624581L, "dummyEmailHash", "firstName27", "firstName27", "dummyPasswordHash", "dummySalt", new Guid("0eadfc3a-fd1c-451f-993b-4c059335c127"), "TestTeacher27" },
                    { new Guid("f271e53b-f316-4f3c-9aca-8469584bb14a"), 732624581L, "dummyEmailHash", "firstName22", "firstName22", "dummyPasswordHash", "dummySalt", new Guid("0eadfc3a-fd1c-451f-993b-4c059335c127"), "TestTeacher22" },
                    { new Guid("2373980d-fec4-403e-82d4-ec6a5bcd66f5"), 732624581L, "dummyEmailHash", "firstName17", "firstName17", "dummyPasswordHash", "dummySalt", new Guid("0eadfc3a-fd1c-451f-993b-4c059335c127"), "TestTeacher17" },
                    { new Guid("47a375c2-c9b6-4013-8239-e327ab21d4ec"), 732624581L, "dummyEmailHash", "firstName12", "firstName12", "dummyPasswordHash", "dummySalt", new Guid("0eadfc3a-fd1c-451f-993b-4c059335c127"), "TestTeacher12" },
                    { new Guid("6276add9-6269-4d1e-a285-a51ada727742"), 732624581L, "dummyEmailHash", "firstName7", "firstName7", "dummyPasswordHash", "dummySalt", new Guid("0eadfc3a-fd1c-451f-993b-4c059335c127"), "TestTeacher7" },
                    { new Guid("ea8f4004-e239-4fe6-aebe-f954474d000f"), 732624581L, "dummyEmailHash", "firstName2", "firstName2", "dummyPasswordHash", "dummySalt", new Guid("0eadfc3a-fd1c-451f-993b-4c059335c127"), "TestTeacher2" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "DateOfBirth", "EmailHash", "FirstName", "LastName", "PasswordHash", "Salt", "TeacherDegreeId", "Username" },
                values: new object[,]
                {
                    { new Guid("af0231e3-54e5-4f62-a16d-7bcbcc3862b5"), 732624581L, "dummyEmailHash", "firstName96", "firstName96", "dummyPasswordHash", "dummySalt", new Guid("f477eee4-f353-4e53-ba72-d3f4b1638528"), "TestTeacher96" },
                    { new Guid("6e99f39c-e2fa-42f8-be2f-7d704a299585"), 732624581L, "dummyEmailHash", "firstName91", "firstName91", "dummyPasswordHash", "dummySalt", new Guid("f477eee4-f353-4e53-ba72-d3f4b1638528"), "TestTeacher91" },
                    { new Guid("f37ac984-18b0-4afa-804c-e73b27c47f8e"), 732624581L, "dummyEmailHash", "firstName94", "firstName94", "dummyPasswordHash", "dummySalt", new Guid("4cf4fc0a-47ad-4640-826d-1ae2982344d2"), "TestTeacher94" },
                    { new Guid("56dd0284-ef65-45c8-9633-7ece06a318f0"), 732624581L, "dummyEmailHash", "firstName86", "firstName86", "dummyPasswordHash", "dummySalt", new Guid("f477eee4-f353-4e53-ba72-d3f4b1638528"), "TestTeacher86" },
                    { new Guid("921e3f7f-7818-4f66-a546-133a47447022"), 732624581L, "dummyEmailHash", "firstName76", "firstName76", "dummyPasswordHash", "dummySalt", new Guid("f477eee4-f353-4e53-ba72-d3f4b1638528"), "TestTeacher76" },
                    { new Guid("92bf0ac3-63b0-4789-811f-24ef059c3653"), 732624581L, "dummyEmailHash", "firstName71", "firstName71", "dummyPasswordHash", "dummySalt", new Guid("f477eee4-f353-4e53-ba72-d3f4b1638528"), "TestTeacher71" },
                    { new Guid("fdb2981f-f449-49ef-bc96-5d7152ea43e0"), 732624581L, "dummyEmailHash", "firstName66", "firstName66", "dummyPasswordHash", "dummySalt", new Guid("f477eee4-f353-4e53-ba72-d3f4b1638528"), "TestTeacher66" },
                    { new Guid("015f56f9-e4b3-41dc-adb6-ee2f90ec89cf"), 732624581L, "dummyEmailHash", "firstName61", "firstName61", "dummyPasswordHash", "dummySalt", new Guid("f477eee4-f353-4e53-ba72-d3f4b1638528"), "TestTeacher61" },
                    { new Guid("ba1fcd39-4e90-42d6-a1f1-d52be00852c8"), 732624581L, "dummyEmailHash", "firstName56", "firstName56", "dummyPasswordHash", "dummySalt", new Guid("f477eee4-f353-4e53-ba72-d3f4b1638528"), "TestTeacher56" },
                    { new Guid("91ed7051-9e55-4279-96b3-f8be2e6efe11"), 732624581L, "dummyEmailHash", "firstName51", "firstName51", "dummyPasswordHash", "dummySalt", new Guid("f477eee4-f353-4e53-ba72-d3f4b1638528"), "TestTeacher51" },
                    { new Guid("07fe7183-eeba-4290-ad4f-98cacee625ea"), 732624581L, "dummyEmailHash", "firstName46", "firstName46", "dummyPasswordHash", "dummySalt", new Guid("f477eee4-f353-4e53-ba72-d3f4b1638528"), "TestTeacher46" },
                    { new Guid("1784f2dc-d5c1-429c-8642-19b865a1afb7"), 732624581L, "dummyEmailHash", "firstName41", "firstName41", "dummyPasswordHash", "dummySalt", new Guid("f477eee4-f353-4e53-ba72-d3f4b1638528"), "TestTeacher41" },
                    { new Guid("c78d7301-bd14-40e7-b41e-b8ab84ad6c78"), 732624581L, "dummyEmailHash", "firstName36", "firstName36", "dummyPasswordHash", "dummySalt", new Guid("f477eee4-f353-4e53-ba72-d3f4b1638528"), "TestTeacher36" },
                    { new Guid("53f2f91f-3252-4cab-af3a-aaabf84f4422"), 732624581L, "dummyEmailHash", "firstName31", "firstName31", "dummyPasswordHash", "dummySalt", new Guid("f477eee4-f353-4e53-ba72-d3f4b1638528"), "TestTeacher31" },
                    { new Guid("64348b66-65ef-4051-a489-855fe874b9c0"), 732624581L, "dummyEmailHash", "firstName81", "firstName81", "dummyPasswordHash", "dummySalt", new Guid("f477eee4-f353-4e53-ba72-d3f4b1638528"), "TestTeacher81" },
                    { new Guid("c00c03a3-29fa-42e0-a672-a5722b674330"), 732624581L, "dummyEmailHash", "firstName99", "firstName99", "dummyPasswordHash", "dummySalt", new Guid("4cf4fc0a-47ad-4640-826d-1ae2982344d2"), "TestTeacher99" }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "ChiefOfDepartmentId", "Name" },
                values: new object[] { new Guid("be617abb-1877-4790-9394-9c15004e7e37"), new Guid("d520389d-d791-479c-a509-27d5bb244858"), "Faculty-0" });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "ChiefOfDepartmentId", "Name" },
                values: new object[] { new Guid("c29310eb-4f13-468f-845d-533c3d96a559"), new Guid("51e9dc92-d8bc-4914-808a-9e4faaf09da6"), "Faculty-1" });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "ChiefOfDepartmentId", "Name" },
                values: new object[] { new Guid("cbc3a0a9-3eef-4191-afbe-db2c96733e64"), new Guid("ea8f4004-e239-4fe6-aebe-f954474d000f"), "Faculty-2" });

            migrationBuilder.InsertData(
                table: "StudyDegrees",
                columns: new[] { "Id", "FacultyId", "Name" },
                values: new object[,]
                {
                    { new Guid("b59a060f-62ae-4927-863d-10a0b5ae5cab"), new Guid("be617abb-1877-4790-9394-9c15004e7e37"), "StudyDegree-0" },
                    { new Guid("cd42f926-5c94-4d1c-82d3-8120276ca6d9"), new Guid("be617abb-1877-4790-9394-9c15004e7e37"), "StudyDegree-1" },
                    { new Guid("181fa63e-7b02-419f-993f-6faf8f14f445"), new Guid("c29310eb-4f13-468f-845d-533c3d96a559"), "StudyDegree-2" },
                    { new Guid("3ff51fa3-4ab4-4e80-a924-7c0f70beefc0"), new Guid("c29310eb-4f13-468f-845d-533c3d96a559"), "StudyDegree-3" },
                    { new Guid("683f21cb-411f-425f-81af-5c802b42a5b3"), new Guid("cbc3a0a9-3eef-4191-afbe-db2c96733e64"), "StudyDegree-4" },
                    { new Guid("c39b2845-07c2-47b7-8134-d935ec154fd3"), new Guid("cbc3a0a9-3eef-4191-afbe-db2c96733e64"), "StudyDegree-5" }
                });

            migrationBuilder.InsertData(
                table: "Specialisations",
                columns: new[] { "Id", "Name", "StudyDegreeId" },
                values: new object[,]
                {
                    { new Guid("192a0c20-afbf-4456-903f-4e85119dacb7"), "Specialisation-0", new Guid("b59a060f-62ae-4927-863d-10a0b5ae5cab") },
                    { new Guid("e71aceb1-621b-43de-90f4-56ddcb6e47d4"), "Specialisation-15", new Guid("c39b2845-07c2-47b7-8134-d935ec154fd3") },
                    { new Guid("9460b016-b416-4c63-864c-4e805792474e"), "Specialisation-14", new Guid("683f21cb-411f-425f-81af-5c802b42a5b3") },
                    { new Guid("2fba88f1-adab-4f9f-a43f-18051f0dd7fa"), "Specialisation-13", new Guid("683f21cb-411f-425f-81af-5c802b42a5b3") },
                    { new Guid("0986065b-b9df-4043-838e-42898bbf9c82"), "Specialisation-12", new Guid("683f21cb-411f-425f-81af-5c802b42a5b3") },
                    { new Guid("77354707-3798-4fc2-8528-76bb35574dc7"), "Specialisation-11", new Guid("3ff51fa3-4ab4-4e80-a924-7c0f70beefc0") },
                    { new Guid("520de4e0-f27c-4f34-8716-2323b5f6a6c2"), "Specialisation-10", new Guid("3ff51fa3-4ab4-4e80-a924-7c0f70beefc0") },
                    { new Guid("d6e40cd5-cad4-430a-87a1-ad41d9fd20aa"), "Specialisation-9", new Guid("3ff51fa3-4ab4-4e80-a924-7c0f70beefc0") },
                    { new Guid("aa4b5a51-c0be-4d1d-a4c4-592a47bad837"), "Specialisation-8", new Guid("181fa63e-7b02-419f-993f-6faf8f14f445") },
                    { new Guid("39ec649d-7c01-4ab7-bacb-82de6581fae3"), "Specialisation-7", new Guid("181fa63e-7b02-419f-993f-6faf8f14f445") },
                    { new Guid("c20c00f8-7cb6-43b6-bfe6-624189ea18fd"), "Specialisation-6", new Guid("181fa63e-7b02-419f-993f-6faf8f14f445") },
                    { new Guid("2553012f-9cec-49be-9ba2-7086a1777e0b"), "Specialisation-5", new Guid("cd42f926-5c94-4d1c-82d3-8120276ca6d9") },
                    { new Guid("ae5e65ae-630f-45cb-9aa1-a3886c6a3aad"), "Specialisation-4", new Guid("cd42f926-5c94-4d1c-82d3-8120276ca6d9") },
                    { new Guid("b7acd74d-470d-4ef2-bea0-bf41ef01b9d9"), "Specialisation-3", new Guid("cd42f926-5c94-4d1c-82d3-8120276ca6d9") },
                    { new Guid("daeeae55-f275-48f7-bd2b-b9bae69527d8"), "Specialisation-2", new Guid("b59a060f-62ae-4927-863d-10a0b5ae5cab") },
                    { new Guid("9eabdcf0-722b-46f9-afa3-8027730bc6a1"), "Specialisation-1", new Guid("b59a060f-62ae-4927-863d-10a0b5ae5cab") },
                    { new Guid("fc3e49fa-4eb4-43e7-8172-f943dc0eef47"), "Specialisation-16", new Guid("c39b2845-07c2-47b7-8134-d935ec154fd3") },
                    { new Guid("d735c8fc-cafb-4b1b-a524-3279bf975315"), "Specialisation-17", new Guid("c39b2845-07c2-47b7-8134-d935ec154fd3") }
                });

            migrationBuilder.InsertData(
                table: "StudyYears",
                columns: new[] { "Id", "SpecialisationId", "StudentLeaderUserId", "Year" },
                values: new object[,]
                {
                    { new Guid("747251cf-9041-4b4a-b59c-3e2922b402ee"), new Guid("192a0c20-afbf-4456-903f-4e85119dacb7"), null, (short)1 },
                    { new Guid("e6dc408c-c4ce-4e05-a990-73a5a1984d8d"), new Guid("d6e40cd5-cad4-430a-87a1-ad41d9fd20aa"), null, (short)3 },
                    { new Guid("7c2f55a3-fc9f-434a-a637-6969eb4ddf66"), new Guid("520de4e0-f27c-4f34-8716-2323b5f6a6c2"), null, (short)1 },
                    { new Guid("04860389-734d-4ad4-8f25-9ff56e8a1453"), new Guid("520de4e0-f27c-4f34-8716-2323b5f6a6c2"), null, (short)2 },
                    { new Guid("ec56666c-9f14-4a9c-be1c-20c3cbe47d23"), new Guid("520de4e0-f27c-4f34-8716-2323b5f6a6c2"), null, (short)3 },
                    { new Guid("1fa54d7d-f576-4063-bd41-43e8e6282890"), new Guid("77354707-3798-4fc2-8528-76bb35574dc7"), null, (short)1 },
                    { new Guid("7cbaceef-331d-4bf0-8f8c-6b38b20a989d"), new Guid("77354707-3798-4fc2-8528-76bb35574dc7"), null, (short)2 },
                    { new Guid("baccba1d-ffbf-41f1-8f27-4435e2794571"), new Guid("77354707-3798-4fc2-8528-76bb35574dc7"), null, (short)3 },
                    { new Guid("e64207d3-eb61-454b-89cd-742e2d8bb273"), new Guid("0986065b-b9df-4043-838e-42898bbf9c82"), null, (short)1 },
                    { new Guid("b8ec675c-6d10-4df1-ab05-a7799860331e"), new Guid("0986065b-b9df-4043-838e-42898bbf9c82"), null, (short)2 },
                    { new Guid("2716b483-e550-44eb-98f1-1def20bb686f"), new Guid("0986065b-b9df-4043-838e-42898bbf9c82"), null, (short)3 },
                    { new Guid("193b5d23-e92b-416e-ba8c-daf31ae9cdb7"), new Guid("2fba88f1-adab-4f9f-a43f-18051f0dd7fa"), null, (short)1 },
                    { new Guid("aa821b99-46e7-42cd-9548-4de32c15f0a3"), new Guid("2fba88f1-adab-4f9f-a43f-18051f0dd7fa"), null, (short)2 },
                    { new Guid("21a6c32d-8d6d-4520-95f3-0fbe8f8d389d"), new Guid("2fba88f1-adab-4f9f-a43f-18051f0dd7fa"), null, (short)3 },
                    { new Guid("c5f60dc8-53b1-4e69-98c0-72083f06cfb1"), new Guid("9460b016-b416-4c63-864c-4e805792474e"), null, (short)1 },
                    { new Guid("a4834b5f-4ee4-413a-95a3-74e74d78cb49"), new Guid("9460b016-b416-4c63-864c-4e805792474e"), null, (short)2 },
                    { new Guid("aac619e7-d50b-4367-991b-e74acadf7337"), new Guid("9460b016-b416-4c63-864c-4e805792474e"), null, (short)3 },
                    { new Guid("915c94f2-6f23-470d-987b-97024d71bc84"), new Guid("e71aceb1-621b-43de-90f4-56ddcb6e47d4"), null, (short)1 },
                    { new Guid("4fbb0709-4bfe-4329-be27-3fd7e437a94a"), new Guid("e71aceb1-621b-43de-90f4-56ddcb6e47d4"), null, (short)2 },
                    { new Guid("2fda8a19-146e-419c-a8c4-aa99e77376bd"), new Guid("e71aceb1-621b-43de-90f4-56ddcb6e47d4"), null, (short)3 },
                    { new Guid("b4bcfcd1-a4c3-44fd-a0fc-4dbd1f9611ea"), new Guid("fc3e49fa-4eb4-43e7-8172-f943dc0eef47"), null, (short)1 },
                    { new Guid("71ac52c5-1d95-4521-839c-370c459c7e85"), new Guid("fc3e49fa-4eb4-43e7-8172-f943dc0eef47"), null, (short)2 },
                    { new Guid("d82c0cb2-d992-43ec-bf2d-22297ac70c47"), new Guid("fc3e49fa-4eb4-43e7-8172-f943dc0eef47"), null, (short)3 },
                    { new Guid("93eb07ca-01eb-4b0e-9448-4f11f5a94b04"), new Guid("d735c8fc-cafb-4b1b-a524-3279bf975315"), null, (short)1 },
                    { new Guid("e6bcaa6d-ecba-4c78-b8ed-6e2263f71c4d"), new Guid("d6e40cd5-cad4-430a-87a1-ad41d9fd20aa"), null, (short)2 },
                    { new Guid("6c645841-25c5-4ded-b6e7-0fc8eb0bd252"), new Guid("d6e40cd5-cad4-430a-87a1-ad41d9fd20aa"), null, (short)1 },
                    { new Guid("37ddbdf9-43e1-443e-a0ab-9766dad0dc7b"), new Guid("aa4b5a51-c0be-4d1d-a4c4-592a47bad837"), null, (short)3 },
                    { new Guid("af22145f-d1e3-4abe-90ed-6e77626ca697"), new Guid("aa4b5a51-c0be-4d1d-a4c4-592a47bad837"), null, (short)2 },
                    { new Guid("4f604d58-d673-4d08-b29d-c0f277ac4a4b"), new Guid("192a0c20-afbf-4456-903f-4e85119dacb7"), null, (short)2 },
                    { new Guid("cab197b7-1800-4ba9-bfc4-bb0d3ac435e9"), new Guid("192a0c20-afbf-4456-903f-4e85119dacb7"), null, (short)3 },
                    { new Guid("676383eb-631f-4d69-8f0d-fe62f8eddef8"), new Guid("9eabdcf0-722b-46f9-afa3-8027730bc6a1"), null, (short)1 },
                    { new Guid("02df93c8-ea46-4758-b759-7443ea2ce1fd"), new Guid("9eabdcf0-722b-46f9-afa3-8027730bc6a1"), null, (short)2 },
                    { new Guid("965ab070-a04a-4733-a261-2d4cb4c15bc5"), new Guid("9eabdcf0-722b-46f9-afa3-8027730bc6a1"), null, (short)3 },
                    { new Guid("33521858-1daf-41eb-92f4-b354a45607c9"), new Guid("daeeae55-f275-48f7-bd2b-b9bae69527d8"), null, (short)1 },
                    { new Guid("125618a6-205d-4674-83b3-90e199c7c53d"), new Guid("daeeae55-f275-48f7-bd2b-b9bae69527d8"), null, (short)2 },
                    { new Guid("20638376-a5ba-4613-a73f-bb630c1c104e"), new Guid("daeeae55-f275-48f7-bd2b-b9bae69527d8"), null, (short)3 },
                    { new Guid("136db5da-532c-43d8-bf31-0994417f8050"), new Guid("b7acd74d-470d-4ef2-bea0-bf41ef01b9d9"), null, (short)1 },
                    { new Guid("3e9e3154-3dbe-4cd5-8f54-c1370474a8dc"), new Guid("b7acd74d-470d-4ef2-bea0-bf41ef01b9d9"), null, (short)2 },
                    { new Guid("b317460d-8ec6-4d88-b9a9-f6d21a1928db"), new Guid("b7acd74d-470d-4ef2-bea0-bf41ef01b9d9"), null, (short)3 },
                    { new Guid("027520bc-c4fc-4196-9ee9-088ffb1c193b"), new Guid("d735c8fc-cafb-4b1b-a524-3279bf975315"), null, (short)2 },
                    { new Guid("d9cb6e31-684e-4662-beb7-80bc297a90a7"), new Guid("ae5e65ae-630f-45cb-9aa1-a3886c6a3aad"), null, (short)1 },
                    { new Guid("a30b9623-13b8-4be2-8564-554ede35100d"), new Guid("ae5e65ae-630f-45cb-9aa1-a3886c6a3aad"), null, (short)3 }
                });

            migrationBuilder.InsertData(
                table: "StudyYears",
                columns: new[] { "Id", "SpecialisationId", "StudentLeaderUserId", "Year" },
                values: new object[,]
                {
                    { new Guid("9084113c-66ba-4d3c-b7cc-75693a82bad8"), new Guid("2553012f-9cec-49be-9ba2-7086a1777e0b"), null, (short)1 },
                    { new Guid("56816939-b856-47c9-835f-5fb18161e286"), new Guid("2553012f-9cec-49be-9ba2-7086a1777e0b"), null, (short)2 },
                    { new Guid("40ee719b-5a39-4b5b-b19e-1e9b9f2eb3b9"), new Guid("2553012f-9cec-49be-9ba2-7086a1777e0b"), null, (short)3 },
                    { new Guid("cb98b69e-f858-4a62-b24f-5c472982fec0"), new Guid("c20c00f8-7cb6-43b6-bfe6-624189ea18fd"), null, (short)1 },
                    { new Guid("e6f5d97a-8c7b-4000-86cc-5c2187ec4bc8"), new Guid("c20c00f8-7cb6-43b6-bfe6-624189ea18fd"), null, (short)2 },
                    { new Guid("bc6ad623-c769-4887-8264-90a5fe153efa"), new Guid("c20c00f8-7cb6-43b6-bfe6-624189ea18fd"), null, (short)3 },
                    { new Guid("8acee112-8c60-4bec-8636-b36540f94aa9"), new Guid("39ec649d-7c01-4ab7-bacb-82de6581fae3"), null, (short)1 },
                    { new Guid("f5ef253d-1857-4f49-8c06-b40539de3148"), new Guid("39ec649d-7c01-4ab7-bacb-82de6581fae3"), null, (short)2 },
                    { new Guid("99f16b36-4b78-4b17-96f8-35d8e2fdfe3d"), new Guid("39ec649d-7c01-4ab7-bacb-82de6581fae3"), null, (short)3 },
                    { new Guid("6705eaad-b3ba-4554-9438-edf45960d5fd"), new Guid("aa4b5a51-c0be-4d1d-a4c4-592a47bad837"), null, (short)1 },
                    { new Guid("c835e65e-383b-4353-95dc-7c0bd4aef5a2"), new Guid("ae5e65ae-630f-45cb-9aa1-a3886c6a3aad"), null, (short)2 },
                    { new Guid("f8e4ef34-70a2-495e-98b2-8be6343cb465"), new Guid("d735c8fc-cafb-4b1b-a524-3279bf975315"), null, (short)3 }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "LeaderStudentId", "StudyYearId", "TutorTeacherId" },
                values: new object[,]
                {
                    { new Guid("62cbcb67-5f17-4f2b-9442-00f25f885c40"), new Guid("8e0e2189-5374-4025-b8f6-51207e345bcb"), new Guid("747251cf-9041-4b4a-b59c-3e2922b402ee"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("c4aa670b-a3ef-4380-98e1-909f0f207103"), new Guid("aa3169d1-bbfd-4933-85c2-4f49f3676855"), new Guid("99f16b36-4b78-4b17-96f8-35d8e2fdfe3d"), new Guid("8ef9a447-3f54-4ebc-854d-d176e74601b4") },
                    { new Guid("4420736c-6ff7-4842-9e12-b32af5a0ae46"), new Guid("9f8f6a89-2419-4fe3-8a66-fa9966a98ee5"), new Guid("99f16b36-4b78-4b17-96f8-35d8e2fdfe3d"), new Guid("92bf0ac3-63b0-4789-811f-24ef059c3653") },
                    { new Guid("5eae801d-c3fe-4753-8a85-c74d1cdaa35f"), new Guid("6f9f853c-fbd8-4bd1-bf90-35c81de11af2"), new Guid("aac619e7-d50b-4367-991b-e74acadf7337"), null },
                    { new Guid("cb61a038-60dd-4bfd-98b0-488b51adb232"), new Guid("97999cd8-82ae-4dbb-ad7d-9718ac62cc10"), new Guid("aac619e7-d50b-4367-991b-e74acadf7337"), null },
                    { new Guid("cafc442d-70ff-41f1-b2af-04094ba8f252"), new Guid("9c652d82-d255-4153-9534-f16d659220ce"), new Guid("6705eaad-b3ba-4554-9438-edf45960d5fd"), new Guid("d889d0ce-23d0-4a95-bd16-51e3a1cf0ce7") },
                    { new Guid("a8b36863-5eb4-4c5e-9068-8709d02cec31"), new Guid("6f55bc98-5098-49fe-a642-b160755432cf"), new Guid("6705eaad-b3ba-4554-9438-edf45960d5fd"), new Guid("b8280292-5d91-45f6-9e15-c45f342b22b9") },
                    { new Guid("c18c1c95-47de-460a-88f9-791f848ce0e5"), new Guid("4eb30257-b721-4f03-a24d-4d7aa9f1c081"), new Guid("6705eaad-b3ba-4554-9438-edf45960d5fd"), new Guid("6baee663-1d3a-4058-9a14-b4ed26be7e08") },
                    { new Guid("32c398e2-1303-46e6-a239-f3d1374711ed"), new Guid("ff362916-b504-41a3-805f-fc866fcc9869"), new Guid("af22145f-d1e3-4abe-90ed-6e77626ca697"), new Guid("4b3c243d-26a2-430b-a779-cf81b39134eb") },
                    { new Guid("bb3872f3-f46d-45e2-91a6-4032c786e0b6"), new Guid("c3669e5f-71a0-44ab-8a3c-14b02846bbbb"), new Guid("99f16b36-4b78-4b17-96f8-35d8e2fdfe3d"), new Guid("962082e2-14d7-498d-80fb-2427625c671a") },
                    { new Guid("ea8f77ae-01e1-427c-a63a-fea391795fe5"), new Guid("eb173913-be12-4ec9-823d-a76228d49f25"), new Guid("af22145f-d1e3-4abe-90ed-6e77626ca697"), new Guid("921e3f7f-7818-4f66-a546-133a47447022") },
                    { new Guid("e8d622c5-99a1-422c-b3b0-891a7e031445"), new Guid("d7c37fe4-9402-4cb1-9683-8e929155ca02"), new Guid("a4834b5f-4ee4-413a-95a3-74e74d78cb49"), null },
                    { new Guid("3b679473-cd87-4835-83f0-5beb7e86e310"), new Guid("625247ff-426e-428b-8516-0eb1f3bf85a1"), new Guid("a4834b5f-4ee4-413a-95a3-74e74d78cb49"), null },
                    { new Guid("e9d91c93-b4d0-4f17-ba8b-4b899d9129c9"), new Guid("74ff278d-d314-4f09-8845-4fbc0ea1d379"), new Guid("37ddbdf9-43e1-443e-a0ab-9766dad0dc7b"), new Guid("ddd29bd3-3463-4300-aec9-f02ef123b657") },
                    { new Guid("51d6d2c4-6705-4baa-b863-dfc51e493c5c"), new Guid("d0124d76-39e2-486a-a981-13c8d86a6b3a"), new Guid("37ddbdf9-43e1-443e-a0ab-9766dad0dc7b"), new Guid("2aeea0c4-8fec-45f9-a6b0-e00afbf6f983") },
                    { new Guid("7846e11d-0257-4c2d-b161-55fb73c3800b"), new Guid("6bbc0ee6-4921-4439-b34b-72fdc83f9961"), new Guid("37ddbdf9-43e1-443e-a0ab-9766dad0dc7b"), new Guid("2b9f0266-611a-4820-b5c7-8d1bd747f55b") },
                    { new Guid("3a1b9a04-07e6-40e6-abaf-2fad5e396dd8"), new Guid("cdd47089-5999-4d0c-8517-72682def3943"), new Guid("a4834b5f-4ee4-413a-95a3-74e74d78cb49"), null },
                    { new Guid("83d4325e-c5e0-4383-8599-f5a37c7a8c50"), new Guid("8b557991-3975-4871-a5c8-252c248ab494"), new Guid("6c645841-25c5-4ded-b6e7-0fc8eb0bd252"), new Guid("64348b66-65ef-4051-a489-855fe874b9c0") },
                    { new Guid("6432bd10-fccd-401a-bef9-bdc2ccda38fb"), new Guid("20c81011-191a-4c09-973b-0e2eabbfcf80"), new Guid("6c645841-25c5-4ded-b6e7-0fc8eb0bd252"), new Guid("50e805fc-950a-4835-b29b-6cee79b22045") },
                    { new Guid("d6e60c34-eafa-46cf-925d-a57cc18f1e89"), new Guid("9be9c274-648c-4e23-869a-2edd4c2a203f"), new Guid("af22145f-d1e3-4abe-90ed-6e77626ca697"), new Guid("ef9025e8-8f9b-49e2-862f-d9f742990e86") },
                    { new Guid("e7ea80e9-a52d-4349-980c-949ef688f788"), new Guid("955fa333-9b43-4fa7-9329-01f29609ea7b"), new Guid("6c645841-25c5-4ded-b6e7-0fc8eb0bd252"), new Guid("55bcdfb7-5436-425f-aa75-67ed0bec3c6d") },
                    { new Guid("2f1bff92-2745-41a2-81e0-1a814d40eba6"), new Guid("84089d22-33d2-4f02-b3ad-e2f1d566826d"), new Guid("aac619e7-d50b-4367-991b-e74acadf7337"), null },
                    { new Guid("0c6ef373-1002-4fe5-90aa-411d217feecd"), new Guid("388b0f4a-ed15-4d7b-8a5c-b99ad1cbdad3"), new Guid("f5ef253d-1857-4f49-8c06-b40539de3148"), new Guid("b26cb6d2-a318-447d-a303-57c481a8df2c") },
                    { new Guid("effa59e4-86f9-4eae-9bd8-fa5be29daa4b"), new Guid("38fbaba1-020b-47cd-b57d-557d02d9f38b"), new Guid("cb98b69e-f858-4a62-b24f-5c472982fec0"), new Guid("471b80b9-dd36-4a48-89c2-39b5941f439d") },
                    { new Guid("75ec85f2-1d60-47e1-81a2-cf239caa5bb2"), new Guid("ec22172b-660c-46e4-a4a6-283e08b96740"), new Guid("cb98b69e-f858-4a62-b24f-5c472982fec0"), new Guid("42be7409-d3d8-4bfd-880e-2d18372f07d6") },
                    { new Guid("40e23e3b-9147-4a3f-83d8-2bfd65a74d6a"), new Guid("2293caa9-4cb8-4398-b99c-21e35429c8bb"), new Guid("cb98b69e-f858-4a62-b24f-5c472982fec0"), new Guid("ba1fcd39-4e90-42d6-a1f1-d52be00852c8") },
                    { new Guid("4b255de1-8a2a-4e7c-bf2b-ad59d7d739bb"), new Guid("19f553a5-d493-49b8-aa3f-868d51b9e044"), new Guid("4fbb0709-4bfe-4329-be27-3fd7e437a94a"), null },
                    { new Guid("ea4c2813-7b5d-47dd-b138-73436b921274"), new Guid("002a0c96-511b-461e-ac79-5bea5628fe6e"), new Guid("4fbb0709-4bfe-4329-be27-3fd7e437a94a"), null },
                    { new Guid("52907d3c-65ba-4fba-91b4-50b8a7f3a4c6"), new Guid("5d6d0787-c41c-4074-b4c7-f1a7466cbc80"), new Guid("2716b483-e550-44eb-98f1-1def20bb686f"), null },
                    { new Guid("5ccc6202-e67e-4956-892f-947ae4bdecb7"), new Guid("2013f71f-3396-4c41-9978-79a219896a6c"), new Guid("e6f5d97a-8c7b-4000-86cc-5c2187ec4bc8"), new Guid("0eafc5e8-bb25-43ce-aa71-fac4ee547b1c") },
                    { new Guid("bfea7927-22d0-4223-9815-618332d7244b"), new Guid("78d042f0-bc66-4142-9ca0-360d532a84de"), new Guid("e6f5d97a-8c7b-4000-86cc-5c2187ec4bc8"), new Guid("a90c16da-5d98-417b-b25e-97a364bd5cf8") },
                    { new Guid("4cbf34cb-f771-4e12-8ec7-4ac38c35fb67"), new Guid("ad12e637-d343-4408-84a9-65cfdfe3dc73"), new Guid("f5ef253d-1857-4f49-8c06-b40539de3148"), new Guid("af0a604d-1fc1-4e3f-b242-2acd97d398f3") },
                    { new Guid("e5d176bd-ac04-45e4-b0b3-0229930bd5db"), new Guid("51d3c047-04b2-4180-999e-45fc5f34c085"), new Guid("bc6ad623-c769-4887-8264-90a5fe153efa"), new Guid("6b5a6b95-6bd0-4340-babb-e56e9ac0171d") },
                    { new Guid("f80c4207-da1a-4bf5-ace5-3fc2efc68ac6"), new Guid("88cd4327-729b-43d5-8e52-9b4d0b2665e8"), new Guid("bc6ad623-c769-4887-8264-90a5fe153efa"), new Guid("63d077b3-c8e6-414f-9036-959e8c825846") },
                    { new Guid("040c1022-a32d-454a-aa40-79d5ecd3309e"), new Guid("19c3452d-a94d-4779-94ea-58f6505825a9"), new Guid("915c94f2-6f23-470d-987b-97024d71bc84"), null },
                    { new Guid("c3da6eb0-ae21-4904-9eaf-1c7b47f4613a"), new Guid("50fb7931-89aa-4f79-ab55-9412f253c4d5"), new Guid("915c94f2-6f23-470d-987b-97024d71bc84"), null },
                    { new Guid("b5ba755d-f476-4917-933c-57190a19ba98"), new Guid("ed47126b-bac0-4ee1-9089-29594f549127"), new Guid("8acee112-8c60-4bec-8636-b36540f94aa9"), new Guid("63af8a63-3d9f-4a25-8e2c-db885be41b6e") },
                    { new Guid("f35fb798-7939-418e-8783-58b245c8bd9d"), new Guid("55fb4ed3-8a69-450a-b8e9-8256f5492496"), new Guid("8acee112-8c60-4bec-8636-b36540f94aa9"), new Guid("4ec77cc4-e026-4c2c-ab7a-924771e1fb57") },
                    { new Guid("6762477c-1436-4089-be8c-2a36eb17bcf2"), new Guid("9987eb5c-dc02-43ab-a1e1-cb2f9eb6e3f9"), new Guid("8acee112-8c60-4bec-8636-b36540f94aa9"), new Guid("be501952-af82-4aa8-813c-ebe8bb64cd67") },
                    { new Guid("1fac0d1e-413c-4492-b4e9-6d1e57139165"), new Guid("36c84e5f-efed-46a9-9d91-d1e9e446a0de"), new Guid("915c94f2-6f23-470d-987b-97024d71bc84"), null },
                    { new Guid("128c466a-2d16-423a-b514-f91d8055a1ba"), new Guid("74a2131e-49ca-42e8-a50a-fa8addb3a3bd"), new Guid("f5ef253d-1857-4f49-8c06-b40539de3148"), new Guid("fdb2981f-f449-49ef-bc96-5d7152ea43e0") },
                    { new Guid("d54eace9-2333-420f-a318-b9c8bf6b4487"), new Guid("a1c21055-059f-4bbe-91ce-6b5b74b60ce6"), new Guid("bc6ad623-c769-4887-8264-90a5fe153efa"), new Guid("015f56f9-e4b3-41dc-adb6-ee2f90ec89cf") }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "LeaderStudentId", "StudyYearId", "TutorTeacherId" },
                values: new object[,]
                {
                    { new Guid("f56e4108-5956-4698-9374-bc8c8f064f9b"), new Guid("69ef18e5-8b3c-46e6-9fe2-549ab2d0ec82"), new Guid("4fbb0709-4bfe-4329-be27-3fd7e437a94a"), null },
                    { new Guid("2a331e7c-3ddb-4a54-ac32-ce296c07beb8"), new Guid("59bcacaf-37b5-4ab7-a9d8-3fa7f527b894"), new Guid("c5f60dc8-53b1-4e69-98c0-72083f06cfb1"), null },
                    { new Guid("d491d7d9-89b3-443b-9a4b-92d6deed94aa"), new Guid("4ea85f44-5fcf-4ae5-afba-297b2201cf9a"), new Guid("e6bcaa6d-ecba-4c78-b8ed-6e2263f71c4d"), new Guid("db11804c-38ec-4fc9-8136-dc47b7b789e3") },
                    { new Guid("456fa297-b340-4f05-b3f7-ef601718a102"), new Guid("642c916d-a67e-49e6-916e-1217ee9eb077"), new Guid("aa821b99-46e7-42cd-9548-4de32c15f0a3"), null },
                    { new Guid("1a8cd514-fb97-446e-9396-a5af59929df6"), new Guid("968d81c5-f9d0-4cbb-9d55-928cc83498eb"), new Guid("aa821b99-46e7-42cd-9548-4de32c15f0a3"), null },
                    { new Guid("d5f1bea8-f1a2-4dc4-952c-86dd5c55062c"), new Guid("b4c5f4ed-6d5e-4755-b911-43eebcacda5f"), new Guid("7cbaceef-331d-4bf0-8f8c-6b38b20a989d"), null },
                    { new Guid("7ac752f1-191b-4834-927c-8d0833e9faea"), new Guid("8c0ce950-4e74-44dd-b6a4-f21f74df87f9"), new Guid("7cbaceef-331d-4bf0-8f8c-6b38b20a989d"), null },
                    { new Guid("4f6608fb-8035-41e0-8731-f442cf062415"), new Guid("3f4dff8f-2572-4eb8-89ba-73b9596024d7"), new Guid("7cbaceef-331d-4bf0-8f8c-6b38b20a989d"), null },
                    { new Guid("b63b1bd2-28fb-4de5-8a07-d73eb3263cb8"), new Guid("327387fd-7b3c-42b9-8d0f-1b350148e96c"), new Guid("baccba1d-ffbf-41f1-8f27-4435e2794571"), null },
                    { new Guid("fbe9bb9a-15b2-40c2-8095-580acfe6e9b4"), new Guid("4e25fbfe-0e0d-4ed3-b194-5e3ba951bad9"), new Guid("baccba1d-ffbf-41f1-8f27-4435e2794571"), null },
                    { new Guid("edd60f8a-5bc6-48d4-ad5c-ff76382a3749"), new Guid("eb981660-a462-4f74-b527-2d6ff4ea3223"), new Guid("baccba1d-ffbf-41f1-8f27-4435e2794571"), null },
                    { new Guid("05035b0e-0c15-48ed-afbc-c1afc5f0cabc"), new Guid("3b39b3fd-9031-4b82-979b-b5e2bb597871"), new Guid("1fa54d7d-f576-4063-bd41-43e8e6282890"), null },
                    { new Guid("79732f55-f50d-4034-91d0-89e7c5985d34"), new Guid("dc42ee9a-f036-4860-b625-c2abe67475ab"), new Guid("193b5d23-e92b-416e-ba8c-daf31ae9cdb7"), null },
                    { new Guid("9e16a3ec-34e2-4748-a79e-61e77774055f"), new Guid("569d1736-12d0-47a0-a7c9-d404c7c25112"), new Guid("e64207d3-eb61-454b-89cd-742e2d8bb273"), null },
                    { new Guid("096f4d5b-2dd0-48d6-a9c1-a82f8fb067a5"), new Guid("a5a8add7-64aa-4a2c-b735-2f597e575147"), new Guid("e64207d3-eb61-454b-89cd-742e2d8bb273"), null },
                    { new Guid("b65ee02f-13fd-406b-ab3d-2f196d23fa53"), new Guid("de89dd7a-ab66-4c01-b33b-51b469b1de87"), new Guid("e64207d3-eb61-454b-89cd-742e2d8bb273"), null },
                    { new Guid("98902e90-eb7a-46f0-9451-586052c216b6"), new Guid("46b827f8-0528-4747-8e42-a82d587cd9db"), new Guid("193b5d23-e92b-416e-ba8c-daf31ae9cdb7"), null },
                    { new Guid("f50126be-a3eb-4225-8bcf-38758c8d9cb1"), new Guid("8a71b582-13e4-4e0d-a661-e00cb1b7432e"), new Guid("b8ec675c-6d10-4df1-ab05-a7799860331e"), null },
                    { new Guid("d770c30c-6912-4640-9de1-0d8cfc87aef9"), new Guid("d285a66b-b98b-42e5-adac-95e9838a7f6d"), new Guid("b8ec675c-6d10-4df1-ab05-a7799860331e"), null },
                    { new Guid("cfedd346-fc6a-4954-9b89-280e4ae476bb"), new Guid("453cd121-87f0-444e-a4c0-10a4beb11f49"), new Guid("b8ec675c-6d10-4df1-ab05-a7799860331e"), null },
                    { new Guid("396d465e-07ac-445e-a021-fa91cb34fb4e"), new Guid("4faeaa19-6a39-4988-875e-ab5948b470f0"), new Guid("2716b483-e550-44eb-98f1-1def20bb686f"), null },
                    { new Guid("718ceab4-03a0-4f68-866f-8861c531fb8a"), new Guid("d7d3e120-2400-4fca-ab64-99e754c8039a"), new Guid("193b5d23-e92b-416e-ba8c-daf31ae9cdb7"), null },
                    { new Guid("71317992-d07e-46bc-b4bd-08015be611e3"), new Guid("a17a90ca-5e60-4b66-845c-74014cec6ee3"), new Guid("e6bcaa6d-ecba-4c78-b8ed-6e2263f71c4d"), new Guid("ccb7a87a-5a14-4961-8ca6-8063675b2bce") },
                    { new Guid("124233e7-080b-42a8-8ec8-77e1a7bbc9c4"), new Guid("baae8c9f-ed52-4842-ab91-7ef98ac9012d"), new Guid("1fa54d7d-f576-4063-bd41-43e8e6282890"), null },
                    { new Guid("1a871327-f40a-48ff-8feb-973e7033ea01"), new Guid("29920b9d-cd90-4115-bc6a-1cfcee40ddbd"), new Guid("aa821b99-46e7-42cd-9548-4de32c15f0a3"), null },
                    { new Guid("37079549-de56-48c6-ba23-852f8dc5dabf"), new Guid("efe3adef-fe2c-4659-9796-f66fc524f45f"), new Guid("e6bcaa6d-ecba-4c78-b8ed-6e2263f71c4d"), new Guid("56dd0284-ef65-45c8-9633-7ece06a318f0") },
                    { new Guid("26a0f818-c243-4345-ba51-a7770af916c8"), new Guid("d35b0409-6a42-417c-b81a-84291d3819ea"), new Guid("c5f60dc8-53b1-4e69-98c0-72083f06cfb1"), null },
                    { new Guid("1ea2740e-d501-4ced-9a27-eb06287c97bd"), new Guid("359efe2a-afca-4c4e-be6d-cc40be28d0c4"), new Guid("c5f60dc8-53b1-4e69-98c0-72083f06cfb1"), null },
                    { new Guid("4470ecff-cc78-4204-9cdd-2c9821328f65"), new Guid("1f8d5abe-daa1-476d-98cf-622a9f45c4c4"), new Guid("e6dc408c-c4ce-4e05-a990-73a5a1984d8d"), new Guid("0db6ac70-8dd3-4da1-bcff-27696faa9338") },
                    { new Guid("41b1c5c1-d2ef-422d-a47b-e1a333bb5546"), new Guid("bb83e0e2-a245-4253-8ad6-433d65b84031"), new Guid("e6dc408c-c4ce-4e05-a990-73a5a1984d8d"), new Guid("04b536cf-d059-43f5-a187-012c25285d74") },
                    { new Guid("e13d694c-56d9-40c1-a71d-3ca81aad9974"), new Guid("c2bc1dd8-6eb7-460d-8dc4-3fe5eccc24a0"), new Guid("e6dc408c-c4ce-4e05-a990-73a5a1984d8d"), new Guid("320b7836-0470-4b4a-8ee5-5146e0766166") },
                    { new Guid("91f98255-fa8d-4a28-9745-decf9c91b928"), new Guid("72174b2b-530c-4f9d-a934-9085d0694ef9"), new Guid("7c2f55a3-fc9f-434a-a637-6969eb4ddf66"), new Guid("dc2dccbe-b289-444f-b374-df5eae1ea96a") },
                    { new Guid("14a449d5-2b7d-4857-b167-f326ec5964e2"), new Guid("392d2f6e-c8c2-435e-9cc7-f2a5db0b0099"), new Guid("7c2f55a3-fc9f-434a-a637-6969eb4ddf66"), new Guid("6e99f39c-e2fa-42f8-be2f-7d704a299585") },
                    { new Guid("9f89c1de-57e7-44d5-a551-98b06bef6109"), new Guid("e0b609ea-aa32-44f3-addd-6cc9cb6c1576"), new Guid("1fa54d7d-f576-4063-bd41-43e8e6282890"), new Guid("c00c03a3-29fa-42e0-a672-a5722b674330") },
                    { new Guid("67ebb07b-3678-44ea-a38c-ec827a8410d6"), new Guid("b12ba677-c23e-418e-93f2-3e253fd45a88"), new Guid("7c2f55a3-fc9f-434a-a637-6969eb4ddf66"), new Guid("f0b375b4-3975-4e1e-9ea4-49b33f1fa3c9") },
                    { new Guid("ff4d5794-3bea-489c-b3cf-da19e953214b"), new Guid("eea5ce76-afe3-4daa-a76e-4b163eeb9368"), new Guid("21a6c32d-8d6d-4520-95f3-0fbe8f8d389d"), null },
                    { new Guid("f5ed8500-c11d-4f0f-8e48-e74b69224c12"), new Guid("09d18b54-641b-41c3-a496-2063e0bb4b4e"), new Guid("04860389-734d-4ad4-8f25-9ff56e8a1453"), new Guid("6354b09f-7243-4fb7-9695-f70ccf026e24") },
                    { new Guid("b1016c6f-24b4-4dce-9a06-cba81c7407f9"), new Guid("8980183f-e781-4fe8-abb8-e5314452fb20"), new Guid("04860389-734d-4ad4-8f25-9ff56e8a1453"), new Guid("f37ac984-18b0-4afa-804c-e73b27c47f8e") },
                    { new Guid("ff7c04a2-5eeb-4fb3-a0ee-cc08d315d567"), new Guid("6c6064f2-6066-42a0-9122-fe6d38ee9332"), new Guid("04860389-734d-4ad4-8f25-9ff56e8a1453"), new Guid("a49dc22c-16b1-450f-bd05-54627b33a952") },
                    { new Guid("93226548-0f7c-48b8-88a5-cac8d985252b"), new Guid("9d72fe8f-6c84-4d52-a986-90ee9b005d05"), new Guid("21a6c32d-8d6d-4520-95f3-0fbe8f8d389d"), null },
                    { new Guid("623cdfc9-d7e8-4f31-8fd3-f9bb1c5d33a9"), new Guid("71256187-2515-46fd-825a-efcbba5066b4"), new Guid("ec56666c-9f14-4a9c-be1c-20c3cbe47d23"), new Guid("af0231e3-54e5-4f62-a16d-7bcbcc3862b5") },
                    { new Guid("f56ce2e1-c474-4cf8-ac0c-45405f71f4d9"), new Guid("36c1f06d-9cc7-47e2-9c3e-7c44a569f1a0"), new Guid("ec56666c-9f14-4a9c-be1c-20c3cbe47d23"), new Guid("923257c6-f46b-4250-8337-b6ac1f4357ca") }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "LeaderStudentId", "StudyYearId", "TutorTeacherId" },
                values: new object[,]
                {
                    { new Guid("c17175ac-0712-4855-a2f7-5b64f8502340"), new Guid("0eccb1ed-df7f-47bc-874e-f9be50a6e2d1"), new Guid("ec56666c-9f14-4a9c-be1c-20c3cbe47d23"), new Guid("261fa621-17a3-42c6-a69b-f7116739e82b") },
                    { new Guid("b2960685-f076-448b-b119-96ca5bac4072"), new Guid("97bbb4cc-6c1b-4c7a-b3f4-8de07361b810"), new Guid("21a6c32d-8d6d-4520-95f3-0fbe8f8d389d"), null },
                    { new Guid("9b89b944-644a-488d-8e0c-e2518f17da3e"), new Guid("ab5d06a7-851c-46e7-8f5e-6153419ce8fc"), new Guid("40ee719b-5a39-4b5b-b19e-1e9b9f2eb3b9"), new Guid("fa322a6f-6d03-46c5-a563-fb058063c944") },
                    { new Guid("84b305bf-fe02-49e7-bb5c-344c140b20c9"), new Guid("ca1c12ca-c9a3-4695-bdfe-a24b5cc068a8"), new Guid("e6f5d97a-8c7b-4000-86cc-5c2187ec4bc8"), new Guid("8762d3cf-d975-4550-b61c-1b891a10d890") },
                    { new Guid("ff644d2b-3e4b-47d6-8adc-3d4b8d1adb90"), new Guid("2c827012-0335-4c2e-bbfc-f80b250e189c"), new Guid("d82c0cb2-d992-43ec-bf2d-22297ac70c47"), null },
                    { new Guid("84acd630-c9ca-4090-94a9-ce5aaf1e0ba3"), new Guid("4bc14726-65e3-45a7-be85-fdb13ec2e979"), new Guid("965ab070-a04a-4733-a261-2d4cb4c15bc5"), new Guid("2373980d-fec4-403e-82d4-ec6a5bcd66f5") },
                    { new Guid("fa667767-de97-49ee-9352-88c0b39935be"), new Guid("58d96033-418d-4dc3-a70d-a7536f044873"), new Guid("93eb07ca-01eb-4b0e-9448-4f11f5a94b04"), null },
                    { new Guid("8eb5d991-7824-4bd4-8b01-9e14364acfd6"), new Guid("32ff53c3-461d-4dc8-a6ef-d77b7cad6b66"), new Guid("93eb07ca-01eb-4b0e-9448-4f11f5a94b04"), null },
                    { new Guid("31cf7b40-0bb6-4211-a7ca-c7b918d1a253"), new Guid("873bf5e1-3a14-4ed3-9d3e-64c42719c71c"), new Guid("33521858-1daf-41eb-92f4-b354a45607c9"), new Guid("6489c875-e57b-49e3-b8db-13d8166de086") },
                    { new Guid("6e57b032-8343-4387-a1e0-dda532adc939"), new Guid("97f67177-05f3-44e5-9ba7-e5df48640131"), new Guid("33521858-1daf-41eb-92f4-b354a45607c9"), new Guid("0ca079c5-33ca-4528-a75a-d9207ff75e6c") },
                    { new Guid("f5d8c706-ee93-4cc2-87be-57e0af7eb798"), new Guid("338856a0-41f5-4122-859c-ab548c3268b9"), new Guid("33521858-1daf-41eb-92f4-b354a45607c9"), new Guid("a5b92ef6-ec55-4ce7-8fbf-2260b49d0ad7") },
                    { new Guid("cbec33c5-ebaf-4c47-9e4b-57621ececcae"), new Guid("1eacd3b6-a453-4919-bc4a-3f59ff2b2743"), new Guid("93eb07ca-01eb-4b0e-9448-4f11f5a94b04"), null },
                    { new Guid("cb4aef2c-4b2a-438e-be4a-0253dc2b8469"), new Guid("a0c41db5-510b-41dd-8030-d1c66fb7d09a"), new Guid("125618a6-205d-4674-83b3-90e199c7c53d"), new Guid("5599f6d0-3655-4d17-8ea1-096103c7b1a7") },
                    { new Guid("c296338a-554a-4d8b-bdd0-35c754fb26ac"), new Guid("cd8d4b90-8223-446b-b2ef-9186c311d535"), new Guid("125618a6-205d-4674-83b3-90e199c7c53d"), new Guid("f271e53b-f316-4f3c-9aca-8469584bb14a") },
                    { new Guid("47193d05-a9fe-46e3-a59e-680d3266abf2"), new Guid("d3f255b5-1a24-4fdc-a8c4-8e4230821346"), new Guid("125618a6-205d-4674-83b3-90e199c7c53d"), new Guid("dc366896-8c46-4e59-86b1-7be25e6b25cf") },
                    { new Guid("b3d0f73e-0d00-4a94-a3ab-bfcf211f1f6a"), new Guid("f4422084-ef6c-4bf7-a412-fcec3dd78ee7"), new Guid("d82c0cb2-d992-43ec-bf2d-22297ac70c47"), null },
                    { new Guid("3e85100c-1136-4bfa-acdd-19deb0260580"), new Guid("228de7c0-9100-4173-a73d-82a43496ceba"), new Guid("20638376-a5ba-4613-a73f-bb630c1c104e"), new Guid("1fd187e5-d7c8-42d2-81e4-fe3dde7b0701") },
                    { new Guid("da0722bd-e76e-45b4-a9de-255fb63e7296"), new Guid("d2b93a5f-548f-46e2-82d2-7b4256ddc7c7"), new Guid("20638376-a5ba-4613-a73f-bb630c1c104e"), new Guid("384f6076-f8f2-4e95-b51f-f0883a9a5576") },
                    { new Guid("ab21092d-aa9e-4d64-bd28-570e5c3270a8"), new Guid("544997e0-2a82-4be5-9011-9f0195da70e4"), new Guid("20638376-a5ba-4613-a73f-bb630c1c104e"), new Guid("9bcbddf1-7697-462d-a409-ac2b527d26b9") },
                    { new Guid("494ea6fd-ff9d-4f31-ae0a-c544d9ad455b"), new Guid("eceeb4fa-d83e-49dc-98cc-c3b1c3b7ee75"), new Guid("40ee719b-5a39-4b5b-b19e-1e9b9f2eb3b9"), new Guid("cd4fcdd9-3743-4d8d-823d-c16e81bf7feb") },
                    { new Guid("b88fe164-14d4-4c3d-9636-654de90ae00e"), new Guid("ff7af21a-daa6-4288-8bc4-31a72f230c93"), new Guid("d82c0cb2-d992-43ec-bf2d-22297ac70c47"), null },
                    { new Guid("1f811026-6fca-4ce6-bc31-443c0bdb265d"), new Guid("76f6c3c2-187a-4649-8a4c-f7e3cc1b1a4a"), new Guid("136db5da-532c-43d8-bf31-0994417f8050"), new Guid("0e9cfc47-3a8c-481d-ab60-4cbcc7d579e4") },
                    { new Guid("7be3598e-a3da-4c32-809b-c7ce27f65d9f"), new Guid("cebbf0a8-18f3-43fb-8063-756e6f1417f0"), new Guid("965ab070-a04a-4733-a261-2d4cb4c15bc5"), new Guid("1659619d-a195-40f0-9b32-7ae994c4f7c5") },
                    { new Guid("b35c6813-10f3-49f6-b5d5-c533a200568e"), new Guid("69a77913-f8e0-43bc-80cf-55f4bc8b41d3"), new Guid("965ab070-a04a-4733-a261-2d4cb4c15bc5"), new Guid("b1b3057c-b83e-4a08-bc6a-9360d5af13bd") },
                    { new Guid("d846ec0d-4ede-4dc9-8594-3f68623d1c41"), new Guid("8161fc28-57b1-490a-88c5-f303538d27fa"), new Guid("02df93c8-ea46-4758-b759-7443ea2ce1fd"), new Guid("c6c1ba00-b0aa-47df-88f4-33af23ac06cb") },
                    { new Guid("96ae3f82-ac27-4a62-8da3-09daad1c1e1a"), new Guid("655f95ab-ffd9-45cb-adb0-2a7315670381"), new Guid("02df93c8-ea46-4758-b759-7443ea2ce1fd"), new Guid("4d6becdd-d8c4-409d-905b-e152c03679f2") },
                    { new Guid("d1b6b5e8-16df-4744-a5e0-34bb7eb51d1e"), new Guid("ea092d03-3c10-4421-9662-10b66b385f11"), new Guid("747251cf-9041-4b4a-b59c-3e2922b402ee"), new Guid("51e9dc92-d8bc-4914-808a-9e4faaf09da6") },
                    { new Guid("dea5a9a8-7c7d-48c1-9f6b-5040becf710a"), new Guid("d9cefb51-8a84-4796-9613-67f6d7493cd7"), new Guid("747251cf-9041-4b4a-b59c-3e2922b402ee"), new Guid("ea8f4004-e239-4fe6-aebe-f954474d000f") },
                    { new Guid("c7f35476-928f-435a-afda-c0022ab40097"), new Guid("76e619ff-b12b-448b-b12d-bd6cf3a02da6"), new Guid("f8e4ef34-70a2-495e-98b2-8be6343cb465"), null },
                    { new Guid("85d46aff-337f-404d-b14d-f0c5189082cb"), new Guid("40659082-765c-455c-98e9-f338a60fbd3d"), new Guid("f8e4ef34-70a2-495e-98b2-8be6343cb465"), null },
                    { new Guid("5d72fca2-3afc-42fd-bbe7-a2106390536a"), new Guid("7118da7d-3026-4168-9aff-ac661e2bb369"), new Guid("4f604d58-d673-4d08-b29d-c0f277ac4a4b"), new Guid("3e2c035a-3595-4ba5-a65c-d7e11fd02240") },
                    { new Guid("92cc8310-af5c-47da-a2d6-d18a22443fa6"), new Guid("a9dfc290-8b48-498a-be8d-7fdceae7d20e"), new Guid("4f604d58-d673-4d08-b29d-c0f277ac4a4b"), new Guid("e2ba043f-3076-4149-a411-f3ec84d0ac5f") },
                    { new Guid("f54d55c1-b7c1-4784-b575-f22a8d038585"), new Guid("ec510e3b-016c-42bb-9b5a-32b09d4e3ddb"), new Guid("4f604d58-d673-4d08-b29d-c0f277ac4a4b"), new Guid("5b5bebc1-9a18-4276-8f59-032c426a7461") },
                    { new Guid("87fb648d-c85b-4c8e-b040-22f2f5715e34"), new Guid("5d47e3ec-3aa5-4829-a899-37981125aaea"), new Guid("f8e4ef34-70a2-495e-98b2-8be6343cb465"), null },
                    { new Guid("b0c86f26-5ad3-49d2-83a1-8a14f6321b27"), new Guid("eb5f8810-fbd1-4dd6-94b3-579625ff346e"), new Guid("136db5da-532c-43d8-bf31-0994417f8050"), new Guid("fd7aa746-fa3d-4b6c-bfc4-180fa0062035") },
                    { new Guid("7f690dc8-22ff-49de-9b11-c2ecff7774d3"), new Guid("6d68095a-4db1-4645-9b89-b646fdca891b"), new Guid("cab197b7-1800-4ba9-bfc4-bb0d3ac435e9"), new Guid("a37d6845-9076-475c-9302-4ca8b1f09f0f") },
                    { new Guid("c8e9d071-fe86-424c-b26d-d401c4e168ba"), new Guid("b415309e-197e-45fa-a326-ee54e2e51b5c"), new Guid("cab197b7-1800-4ba9-bfc4-bb0d3ac435e9"), new Guid("5b0e27a8-b03b-405e-9d61-be91ffb92942") },
                    { new Guid("660d8700-61e3-4c3c-a0c3-c4a8b8ea1f86"), new Guid("3611bf43-72e0-4091-be75-34dfe31baa6d"), new Guid("027520bc-c4fc-4196-9ee9-088ffb1c193b"), null },
                    { new Guid("d1699342-a060-4dcb-8707-dd46bb4e4710"), new Guid("dca63e32-3431-46ca-af05-696964ad8193"), new Guid("676383eb-631f-4d69-8f0d-fe62f8eddef8"), new Guid("56f39da2-627a-4954-8db5-d1b440669300") },
                    { new Guid("b1622035-d705-43d8-8f4b-51d1bb429e86"), new Guid("b4c433da-fbf6-4910-91fe-e04a44a3c9b2"), new Guid("676383eb-631f-4d69-8f0d-fe62f8eddef8"), new Guid("58f484aa-8ab3-44b3-979a-f5c7b99910f6") },
                    { new Guid("3ea90c43-0a8b-4d0b-b6b2-5fa6ab3be0ea"), new Guid("94966d72-ab9e-4689-9bc4-a9726cba0c1c"), new Guid("676383eb-631f-4d69-8f0d-fe62f8eddef8"), new Guid("0f54ee42-1e4a-403c-89a7-9ed72d8f6725") },
                    { new Guid("89a73c17-59f8-4c68-ae18-9429acc8e0d3"), new Guid("32f863c9-58ae-4229-8a5c-6ce4fffa7864"), new Guid("027520bc-c4fc-4196-9ee9-088ffb1c193b"), null }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "LeaderStudentId", "StudyYearId", "TutorTeacherId" },
                values: new object[,]
                {
                    { new Guid("527d0085-4747-4167-a01d-e1fd8c1e74fe"), new Guid("ad76fee0-0c33-421b-a277-f02dd4ae6c0d"), new Guid("027520bc-c4fc-4196-9ee9-088ffb1c193b"), null },
                    { new Guid("41dc4c28-ffe5-4739-b414-2c5d9ecf418e"), new Guid("97f1089f-26bb-47bb-8299-efb8f02e1957"), new Guid("02df93c8-ea46-4758-b759-7443ea2ce1fd"), new Guid("47a375c2-c9b6-4013-8239-e327ab21d4ec") },
                    { new Guid("4a6e755b-110e-4d50-a3ef-f5165f648eff"), new Guid("db80d9ab-0020-4d56-b5db-e5ac0300504f"), new Guid("cab197b7-1800-4ba9-bfc4-bb0d3ac435e9"), new Guid("6276add9-6269-4d1e-a285-a51ada727742") },
                    { new Guid("6f67e353-8158-4f04-98c8-3009a78d58f5"), new Guid("53dc3a1d-2aae-4534-a08f-ec97a382fe58"), new Guid("136db5da-532c-43d8-bf31-0994417f8050"), new Guid("47d9fc1a-717f-4d80-a88a-79195ef4c6b1") },
                    { new Guid("05916953-3275-42de-8aa8-e06a948ebc1f"), new Guid("a0bee3b3-e030-4f4b-93cd-0b1da3e772b3"), new Guid("2716b483-e550-44eb-98f1-1def20bb686f"), null },
                    { new Guid("dfdcb31f-6020-455e-b53e-2cc0a4de2ffe"), new Guid("6edc5e82-759e-4728-971d-2cab78fef5cf"), new Guid("d9cb6e31-684e-4662-beb7-80bc297a90a7"), new Guid("6980f4f6-226e-4bbd-b4ed-4125c696f4d0") },
                    { new Guid("b1513f73-1721-4a74-a0b9-796e480e897c"), new Guid("5150df5f-1496-48a1-86ed-a7d48d1ff598"), new Guid("2fda8a19-146e-419c-a8c4-aa99e77376bd"), null },
                    { new Guid("a6a817b7-3b98-4c6a-a9b6-124b01b4efea"), new Guid("f9d9c6ab-9605-4be0-bf73-3138e09485d9"), new Guid("9084113c-66ba-4d3c-b7cc-75693a82bad8"), new Guid("07fe7183-eeba-4290-ad4f-98cacee625ea") },
                    { new Guid("51630394-067b-4a5a-8145-bc15305a8bb1"), new Guid("3560bafc-aea7-46bf-80b2-6d726b0631b6"), new Guid("d9cb6e31-684e-4662-beb7-80bc297a90a7"), new Guid("f60e2337-f07e-45d8-9aa3-5e8314156a8d") },
                    { new Guid("5c423449-4209-4757-a71e-0751b645a670"), new Guid("2e712574-f6b7-41a1-b35e-b80dece3e13c"), new Guid("b4bcfcd1-a4c3-44fd-a0fc-4dbd1f9611ea"), null },
                    { new Guid("0d5752f9-087d-4900-aa52-ffe1f1e5806b"), new Guid("e7c67907-2ba5-4cab-acc2-3d074a1b04fd"), new Guid("9084113c-66ba-4d3c-b7cc-75693a82bad8"), new Guid("e05af25e-082a-4b80-a28f-832214ce10bc") },
                    { new Guid("9619f5c4-3f71-47b9-9950-87882623b578"), new Guid("88fbf6b1-56bf-4244-adb3-1b9a1986c34f"), new Guid("c835e65e-383b-4353-95dc-7c0bd4aef5a2"), new Guid("84ea72b7-9dc5-4c45-a282-0d138774b216") },
                    { new Guid("52455bfd-56ae-4e8f-a4d0-a5f00736aec8"), new Guid("e5879d89-0151-4665-ab4e-0c5bbf4d989d"), new Guid("2fda8a19-146e-419c-a8c4-aa99e77376bd"), null },
                    { new Guid("3cc7e2fb-634a-475d-bdd9-4878383f8731"), new Guid("fce2f744-4445-4d77-abd6-483200dbd9a9"), new Guid("c835e65e-383b-4353-95dc-7c0bd4aef5a2"), new Guid("c69543f7-c451-44af-8136-7600bf55903c") },
                    { new Guid("5018a3e3-badd-428a-a5b0-615941965a37"), new Guid("dba8fa82-2c7b-4b67-b548-619c324260dd"), new Guid("3e9e3154-3dbe-4cd5-8f54-c1370474a8dc"), new Guid("9d0e4158-3440-4bf7-b67d-078faeeddbcb") },
                    { new Guid("47b31edd-3dc3-432c-89d7-2be29b39f51f"), new Guid("292911d0-a38d-4b62-a640-a3d750795509"), new Guid("b4bcfcd1-a4c3-44fd-a0fc-4dbd1f9611ea"), null },
                    { new Guid("0cea77ac-2dee-4a12-987c-44c46c47c784"), new Guid("36191ab2-a154-4af1-9425-c1656f15de98"), new Guid("b4bcfcd1-a4c3-44fd-a0fc-4dbd1f9611ea"), null },
                    { new Guid("1d2bfc9d-edcf-443a-9b69-b490c837a5e3"), new Guid("9fca6d1c-5d29-422f-b697-13089f084804"), new Guid("a30b9623-13b8-4be2-8564-554ede35100d"), new Guid("b589b9ab-99a7-42e6-ada6-d1d692d94214") },
                    { new Guid("ce36ea74-1a50-452a-9b9d-9408749eb8b2"), new Guid("f2737157-9ceb-4e62-8fa1-7ac95b94b535"), new Guid("a30b9623-13b8-4be2-8564-554ede35100d"), new Guid("b6fa213a-f7e3-453c-8d0c-7f4e3fbda256") },
                    { new Guid("7f704350-6559-476f-8506-f7d77c94a69c"), new Guid("a69b8d47-1187-45d4-814a-ce9257946a4a"), new Guid("a30b9623-13b8-4be2-8564-554ede35100d"), new Guid("e8405a7e-6809-4ac1-951d-03781410be97") },
                    { new Guid("a5156b6f-54d0-42a7-a3f2-c13a581200bf"), new Guid("04201684-7bb9-429d-bf97-94614d7fb528"), new Guid("c835e65e-383b-4353-95dc-7c0bd4aef5a2"), new Guid("1784f2dc-d5c1-429c-8642-19b865a1afb7") },
                    { new Guid("366805fb-6726-4abd-8a55-53d9fde7e94f"), new Guid("cae8f338-75fb-43b8-85a0-da555be55727"), new Guid("56816939-b856-47c9-835f-5fb18161e286"), new Guid("0714acfd-7b85-4714-95a4-2693f68cc7fe") },
                    { new Guid("249dd5a6-7a1b-47af-83ec-836721cdb26f"), new Guid("b8f0a5f6-f95b-4229-b5ac-bcb93cda97c9"), new Guid("9084113c-66ba-4d3c-b7cc-75693a82bad8"), new Guid("8ec1697b-d4d9-4c6c-8d7e-a7a369a05831") },
                    { new Guid("e5f4cf97-f96e-4bd4-ae48-db5211d8c640"), new Guid("1c34551e-db99-4e22-a0d3-335ae0365e2e"), new Guid("56816939-b856-47c9-835f-5fb18161e286"), new Guid("0be65fce-7327-4fdb-97e8-4638e8061847") },
                    { new Guid("00ce9ff2-ca21-4d74-98cb-c9c277659cb8"), new Guid("e8df6e37-707f-4e6b-af64-b8652ee07926"), new Guid("71ac52c5-1d95-4521-839c-370c459c7e85"), null },
                    { new Guid("6565a8d0-5276-49ba-9a0f-90c75681e35a"), new Guid("bef86030-c3dc-4c85-bf9f-c099d3ba22cd"), new Guid("b317460d-8ec6-4d88-b9a9-f6d21a1928db"), new Guid("5166b68f-19c7-4295-8001-acab80e3be59") },
                    { new Guid("3b92cc8e-a82c-4405-b84b-51b8dd8686c6"), new Guid("83649640-cd1c-430e-8978-04c7465128ea"), new Guid("40ee719b-5a39-4b5b-b19e-1e9b9f2eb3b9"), new Guid("91ed7051-9e55-4279-96b3-f8be2e6efe11") },
                    { new Guid("7fc6a5cb-8b6a-49c5-b0b6-8b511b04cffd"), new Guid("518e33e2-cb30-43db-bf9b-0e72f8b841e1"), new Guid("b317460d-8ec6-4d88-b9a9-f6d21a1928db"), new Guid("2a4c66f3-e06e-4d40-830b-2aff460b9aef") },
                    { new Guid("0b5dd85d-8633-4b18-a4e4-c26fdafc673f"), new Guid("ba7ba6f5-efce-4ff6-a596-7754338da65d"), new Guid("56816939-b856-47c9-835f-5fb18161e286"), new Guid("a92a7897-7ed2-4983-a5e7-33d72a168392") },
                    { new Guid("9849e7e6-de86-43e9-9b40-e0b433d6a5d4"), new Guid("e60ab03b-bdcc-4157-8f18-a5469b9148f2"), new Guid("2fda8a19-146e-419c-a8c4-aa99e77376bd"), null },
                    { new Guid("57bae36e-0423-4058-9713-97bf8d90f0cd"), new Guid("a9acdf1f-282d-4dd4-910c-895b4f1eca25"), new Guid("b317460d-8ec6-4d88-b9a9-f6d21a1928db"), new Guid("e13a6b5d-7312-488e-9cea-5f449d9b6ed5") },
                    { new Guid("58fc10f4-af4c-476c-846e-25106edc46db"), new Guid("261d21c8-2163-48ae-9c20-60e1b5a3132e"), new Guid("3e9e3154-3dbe-4cd5-8f54-c1370474a8dc"), new Guid("53f2f91f-3252-4cab-af3a-aaabf84f4422") },
                    { new Guid("4c5c3876-28eb-410f-b2b6-76078a50f398"), new Guid("8a18b36c-ceab-42bc-bf81-2070b160dfad"), new Guid("d9cb6e31-684e-4662-beb7-80bc297a90a7"), new Guid("c78d7301-bd14-40e7-b41e-b8ab84ad6c78") },
                    { new Guid("6c92e5cc-16f3-47f9-8fa2-bcb23f71b24d"), new Guid("c569615a-67d0-4597-a351-bd3073a0c9d4"), new Guid("71ac52c5-1d95-4521-839c-370c459c7e85"), null },
                    { new Guid("569e2cfb-d638-4d21-a4f9-184df6c18bcf"), new Guid("9185cbfa-61d3-41bb-a7ad-6d2de2018983"), new Guid("3e9e3154-3dbe-4cd5-8f54-c1370474a8dc"), new Guid("1bf88dee-3b4f-48fd-9679-6c90ced03977") },
                    { new Guid("9dcf1c99-b75a-4c79-82a5-b352fbbad561"), new Guid("196de7ae-4595-4429-bc09-998f63d8436d"), new Guid("71ac52c5-1d95-4521-839c-370c459c7e85"), null }
                });

            migrationBuilder.InsertData(
                table: "StudySemesters",
                columns: new[] { "Id", "Semester", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("609e61bd-5d31-48a8-9ed3-fefd675b1a08"), (short)2, new Guid("193b5d23-e92b-416e-ba8c-daf31ae9cdb7") },
                    { new Guid("a034c62b-e1b1-4ee2-8950-92a3de59b61c"), (short)1, new Guid("2716b483-e550-44eb-98f1-1def20bb686f") },
                    { new Guid("0253e66e-905c-45b6-a9f6-5845201fdccd"), (short)1, new Guid("915c94f2-6f23-470d-987b-97024d71bc84") },
                    { new Guid("d3269155-a2c0-49b7-89e5-93b14b670d85"), (short)1, new Guid("027520bc-c4fc-4196-9ee9-088ffb1c193b") },
                    { new Guid("3eab4340-3570-46fd-9bb7-fdaec0973133"), (short)2, new Guid("915c94f2-6f23-470d-987b-97024d71bc84") },
                    { new Guid("2a3dcf49-b486-4136-8b78-d46221adb6cc"), (short)2, new Guid("4fbb0709-4bfe-4329-be27-3fd7e437a94a") }
                });

            migrationBuilder.InsertData(
                table: "StudySemesters",
                columns: new[] { "Id", "Semester", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("8952f512-fe84-4820-b001-3b5c49c34a27"), (short)2, new Guid("027520bc-c4fc-4196-9ee9-088ffb1c193b") },
                    { new Guid("fc9fc9eb-7b60-460a-92d3-844feb48ef24"), (short)2, new Guid("2716b483-e550-44eb-98f1-1def20bb686f") },
                    { new Guid("f519c8d3-23c9-4ae8-858f-3c9c51c06b58"), (short)1, new Guid("193b5d23-e92b-416e-ba8c-daf31ae9cdb7") },
                    { new Guid("b87daf0c-eb51-4c07-b449-06332e24a3ae"), (short)1, new Guid("71ac52c5-1d95-4521-839c-370c459c7e85") },
                    { new Guid("9b4275d6-7484-48d9-a3d0-325ab5123f4d"), (short)1, new Guid("93eb07ca-01eb-4b0e-9448-4f11f5a94b04") },
                    { new Guid("aca00e4f-9891-42ce-b030-bdb460912a86"), (short)2, new Guid("2fda8a19-146e-419c-a8c4-aa99e77376bd") },
                    { new Guid("2dc17cb0-6837-492e-9a6b-1c6a3809bd66"), (short)2, new Guid("71ac52c5-1d95-4521-839c-370c459c7e85") },
                    { new Guid("56ff758d-1574-4779-821c-df8a31fb9c08"), (short)2, new Guid("c5f60dc8-53b1-4e69-98c0-72083f06cfb1") },
                    { new Guid("52e059ed-0b61-4f02-b827-247ce522fa88"), (short)1, new Guid("c5f60dc8-53b1-4e69-98c0-72083f06cfb1") },
                    { new Guid("f08fd625-7ae2-409f-b72a-f2cccf217e07"), (short)1, new Guid("a4834b5f-4ee4-413a-95a3-74e74d78cb49") },
                    { new Guid("f1358410-62e4-4bdf-bc20-338a4325b31c"), (short)2, new Guid("a4834b5f-4ee4-413a-95a3-74e74d78cb49") },
                    { new Guid("e0ad951f-546b-4de2-8d93-b34c9be25957"), (short)1, new Guid("d82c0cb2-d992-43ec-bf2d-22297ac70c47") },
                    { new Guid("d6241a14-3a43-4d50-ab66-2684d89fe179"), (short)2, new Guid("b4bcfcd1-a4c3-44fd-a0fc-4dbd1f9611ea") },
                    { new Guid("053cf60d-5963-4dcb-812d-a6a98e2b1817"), (short)1, new Guid("2fda8a19-146e-419c-a8c4-aa99e77376bd") },
                    { new Guid("0c0a35f6-aa29-4fff-bad0-13404b5950d4"), (short)2, new Guid("21a6c32d-8d6d-4520-95f3-0fbe8f8d389d") },
                    { new Guid("142fa12c-02f0-4a55-b09a-a3bb74d2a086"), (short)2, new Guid("d82c0cb2-d992-43ec-bf2d-22297ac70c47") },
                    { new Guid("6a34ac77-de2a-48ca-884a-0826d1b646ec"), (short)1, new Guid("b4bcfcd1-a4c3-44fd-a0fc-4dbd1f9611ea") },
                    { new Guid("bc1fff87-1a12-49cf-88cf-641e2e1a77ae"), (short)1, new Guid("aac619e7-d50b-4367-991b-e74acadf7337") },
                    { new Guid("4b5f9de0-1605-42c2-9fe8-afb7b0659bb1"), (short)2, new Guid("aa821b99-46e7-42cd-9548-4de32c15f0a3") },
                    { new Guid("0c51308b-6441-4f3d-b045-629877d81a46"), (short)2, new Guid("aac619e7-d50b-4367-991b-e74acadf7337") },
                    { new Guid("70d68c6a-b23d-4cf8-998c-9033d2bb756d"), (short)2, new Guid("93eb07ca-01eb-4b0e-9448-4f11f5a94b04") },
                    { new Guid("379b9d39-d466-43ac-b988-8c27a2c65f15"), (short)1, new Guid("aa821b99-46e7-42cd-9548-4de32c15f0a3") },
                    { new Guid("27c49487-1120-432b-b3ca-981af980749f"), (short)1, new Guid("21a6c32d-8d6d-4520-95f3-0fbe8f8d389d") },
                    { new Guid("10418318-09fe-4b62-924e-b02017044cd9"), (short)1, new Guid("4fbb0709-4bfe-4329-be27-3fd7e437a94a") },
                    { new Guid("49fd7f4c-a8ca-45d5-bbe0-55ef9faca700"), (short)2, new Guid("37ddbdf9-43e1-443e-a0ab-9766dad0dc7b") },
                    { new Guid("02023a19-1a5c-422a-97b1-e37c596b2a1e"), (short)1, new Guid("b8ec675c-6d10-4df1-ab05-a7799860331e") },
                    { new Guid("103abef8-fca5-4a1e-9b82-498ec853c71e"), (short)1, new Guid("3e9e3154-3dbe-4cd5-8f54-c1370474a8dc") },
                    { new Guid("b6d6e9f6-b969-4f1f-811b-b04a5da43f45"), (short)2, new Guid("3e9e3154-3dbe-4cd5-8f54-c1370474a8dc") },
                    { new Guid("5f765137-96f3-4988-9ff4-e3f35a729b00"), (short)1, new Guid("b317460d-8ec6-4d88-b9a9-f6d21a1928db") },
                    { new Guid("6f066c82-d8a4-488b-93e4-dc6d836b0d15"), (short)2, new Guid("b317460d-8ec6-4d88-b9a9-f6d21a1928db") },
                    { new Guid("26b42e2a-4fea-47e6-89bc-22524ccc8fac"), (short)1, new Guid("d9cb6e31-684e-4662-beb7-80bc297a90a7") },
                    { new Guid("a3e9c310-0cab-432f-aff0-f0105862fac2"), (short)2, new Guid("d9cb6e31-684e-4662-beb7-80bc297a90a7") },
                    { new Guid("2431d145-136a-4a23-b417-6af9821e039c"), (short)1, new Guid("c835e65e-383b-4353-95dc-7c0bd4aef5a2") },
                    { new Guid("4339ed05-7417-49fd-8890-8083bc51b3c5"), (short)2, new Guid("c835e65e-383b-4353-95dc-7c0bd4aef5a2") },
                    { new Guid("d49224d3-b1e7-4aa7-be06-6af013817419"), (short)1, new Guid("a30b9623-13b8-4be2-8564-554ede35100d") },
                    { new Guid("706dd721-f5b6-4281-b76e-9008f63e7c1a"), (short)2, new Guid("a30b9623-13b8-4be2-8564-554ede35100d") },
                    { new Guid("8f52bd94-9958-4f72-8fa0-3cb1ec30b731"), (short)1, new Guid("9084113c-66ba-4d3c-b7cc-75693a82bad8") },
                    { new Guid("04f6c475-8b10-4380-8777-0a2ca3806508"), (short)2, new Guid("9084113c-66ba-4d3c-b7cc-75693a82bad8") },
                    { new Guid("befde88f-9a14-4e2f-a0fe-07e28bf31301"), (short)1, new Guid("56816939-b856-47c9-835f-5fb18161e286") },
                    { new Guid("a03cb3ef-9bd7-4513-a995-4e46f5f6dd3b"), (short)2, new Guid("56816939-b856-47c9-835f-5fb18161e286") },
                    { new Guid("f63c3e39-c051-4b1f-bfe1-37e5fe47c397"), (short)1, new Guid("40ee719b-5a39-4b5b-b19e-1e9b9f2eb3b9") },
                    { new Guid("a34783f0-cd79-4260-82c6-79b4dbfcd112"), (short)2, new Guid("136db5da-532c-43d8-bf31-0994417f8050") }
                });

            migrationBuilder.InsertData(
                table: "StudySemesters",
                columns: new[] { "Id", "Semester", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("256a5b40-8012-4db3-b00c-10fd242f92cb"), (short)1, new Guid("136db5da-532c-43d8-bf31-0994417f8050") },
                    { new Guid("f522dc14-2a27-408b-a3b7-37ab0f14492b"), (short)2, new Guid("20638376-a5ba-4613-a73f-bb630c1c104e") },
                    { new Guid("6537ebae-4f75-4743-8fbc-71d75ad6c0f4"), (short)1, new Guid("20638376-a5ba-4613-a73f-bb630c1c104e") },
                    { new Guid("2c032d08-736e-42ea-bd92-327472a78910"), (short)1, new Guid("747251cf-9041-4b4a-b59c-3e2922b402ee") },
                    { new Guid("a5810ef7-fa39-4a3d-92a5-cc0236bbc26c"), (short)2, new Guid("747251cf-9041-4b4a-b59c-3e2922b402ee") },
                    { new Guid("270d93d2-2d14-4f27-bfb5-62541c50fe99"), (short)1, new Guid("4f604d58-d673-4d08-b29d-c0f277ac4a4b") },
                    { new Guid("c7955d67-ea7a-4095-9efc-23006bcb41fd"), (short)2, new Guid("4f604d58-d673-4d08-b29d-c0f277ac4a4b") },
                    { new Guid("11efde67-a191-45ea-a2be-bd903fcbb462"), (short)1, new Guid("cab197b7-1800-4ba9-bfc4-bb0d3ac435e9") },
                    { new Guid("023c8ee5-7bf3-4a2e-96ce-2448392692a4"), (short)2, new Guid("cab197b7-1800-4ba9-bfc4-bb0d3ac435e9") },
                    { new Guid("5f22df2e-ee85-4783-93f0-79eecd95ba4e"), (short)1, new Guid("676383eb-631f-4d69-8f0d-fe62f8eddef8") },
                    { new Guid("eec789ea-3e9e-4600-924b-1552317fc115"), (short)2, new Guid("40ee719b-5a39-4b5b-b19e-1e9b9f2eb3b9") },
                    { new Guid("0678b7cb-fd34-400c-8663-889e8330ec64"), (short)2, new Guid("676383eb-631f-4d69-8f0d-fe62f8eddef8") },
                    { new Guid("b60fa263-44f4-46b3-a494-ae3252ac925e"), (short)2, new Guid("02df93c8-ea46-4758-b759-7443ea2ce1fd") },
                    { new Guid("2af25551-4fd6-47f5-a00f-23916f40c162"), (short)1, new Guid("965ab070-a04a-4733-a261-2d4cb4c15bc5") },
                    { new Guid("feb2ea5d-268a-4665-bacd-4db6939390a6"), (short)2, new Guid("965ab070-a04a-4733-a261-2d4cb4c15bc5") },
                    { new Guid("45377600-9ee2-44cc-8217-60ae287409f2"), (short)1, new Guid("33521858-1daf-41eb-92f4-b354a45607c9") },
                    { new Guid("6adb62da-3b01-4757-b260-ddd2cf1d57de"), (short)2, new Guid("33521858-1daf-41eb-92f4-b354a45607c9") },
                    { new Guid("ae0d9476-94fc-45af-8017-d93e8b1368d5"), (short)1, new Guid("125618a6-205d-4674-83b3-90e199c7c53d") },
                    { new Guid("c9099a6b-63bf-4cac-9c6b-79375bbe3abb"), (short)2, new Guid("125618a6-205d-4674-83b3-90e199c7c53d") },
                    { new Guid("66efa1f8-c9ae-499f-b2da-58fb59772dd9"), (short)1, new Guid("02df93c8-ea46-4758-b759-7443ea2ce1fd") },
                    { new Guid("6ed53c09-0724-4630-a692-3d2ee46146b1"), (short)2, new Guid("b8ec675c-6d10-4df1-ab05-a7799860331e") },
                    { new Guid("a081e631-b30c-455c-95da-372bfec80e42"), (short)1, new Guid("cb98b69e-f858-4a62-b24f-5c472982fec0") },
                    { new Guid("d3f65c01-755b-4f6e-9400-b6f456384c83"), (short)1, new Guid("e6f5d97a-8c7b-4000-86cc-5c2187ec4bc8") },
                    { new Guid("34ec0591-8ec4-4c9c-9cd9-fa70ef5a2483"), (short)2, new Guid("e6dc408c-c4ce-4e05-a990-73a5a1984d8d") },
                    { new Guid("f33058bb-8a16-4cde-9306-f2868506d4e9"), (short)1, new Guid("7c2f55a3-fc9f-434a-a637-6969eb4ddf66") },
                    { new Guid("f0943399-5999-49bf-9fc0-642a5922a0bc"), (short)2, new Guid("7c2f55a3-fc9f-434a-a637-6969eb4ddf66") },
                    { new Guid("fc5fcbac-a0b5-4059-8e1b-d396aa269a67"), (short)1, new Guid("04860389-734d-4ad4-8f25-9ff56e8a1453") },
                    { new Guid("52beef09-20ce-4c37-ab89-94f2694cb95b"), (short)2, new Guid("04860389-734d-4ad4-8f25-9ff56e8a1453") },
                    { new Guid("1ec7df37-22d1-4853-9d82-fb38c117840a"), (short)1, new Guid("ec56666c-9f14-4a9c-be1c-20c3cbe47d23") },
                    { new Guid("3f7c878b-3e55-43a6-97dd-5707171e320c"), (short)2, new Guid("ec56666c-9f14-4a9c-be1c-20c3cbe47d23") },
                    { new Guid("25a05858-b0df-48b4-a719-2a20c674de64"), (short)1, new Guid("1fa54d7d-f576-4063-bd41-43e8e6282890") },
                    { new Guid("6fe7d50f-6e56-4689-8556-63f45d71cca1"), (short)2, new Guid("1fa54d7d-f576-4063-bd41-43e8e6282890") },
                    { new Guid("036ba574-9c62-495d-b2c2-63c784cf5e02"), (short)1, new Guid("7cbaceef-331d-4bf0-8f8c-6b38b20a989d") },
                    { new Guid("ae0ff115-bac3-489a-855e-21275acbc7b2"), (short)2, new Guid("7cbaceef-331d-4bf0-8f8c-6b38b20a989d") },
                    { new Guid("51f3469a-c46d-4f80-9b57-bd07ae06c11b"), (short)1, new Guid("baccba1d-ffbf-41f1-8f27-4435e2794571") },
                    { new Guid("172ca027-bcce-40dc-94c5-e2c2f419fe61"), (short)2, new Guid("baccba1d-ffbf-41f1-8f27-4435e2794571") },
                    { new Guid("f8104e82-2073-497c-a097-cdf5a46d801c"), (short)1, new Guid("e64207d3-eb61-454b-89cd-742e2d8bb273") },
                    { new Guid("3d631240-7dd1-400f-b4a2-b15b0f338da6"), (short)2, new Guid("e64207d3-eb61-454b-89cd-742e2d8bb273") },
                    { new Guid("6f27750f-59c8-4752-af90-d58085785dbd"), (short)1, new Guid("e6dc408c-c4ce-4e05-a990-73a5a1984d8d") },
                    { new Guid("41a946ba-8472-4abc-98dc-136ad09a5119"), (short)2, new Guid("e6bcaa6d-ecba-4c78-b8ed-6e2263f71c4d") },
                    { new Guid("370a7847-1322-49dd-a10e-c2715f4d761c"), (short)1, new Guid("e6bcaa6d-ecba-4c78-b8ed-6e2263f71c4d") },
                    { new Guid("64fad46b-9d9d-4f26-812c-5c78eea8b243"), (short)2, new Guid("6c645841-25c5-4ded-b6e7-0fc8eb0bd252") }
                });

            migrationBuilder.InsertData(
                table: "StudySemesters",
                columns: new[] { "Id", "Semester", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("d836d27d-e6d5-407f-813f-a9ff0fed87cc"), (short)2, new Guid("e6f5d97a-8c7b-4000-86cc-5c2187ec4bc8") },
                    { new Guid("a25ff68a-fe55-4ffd-af0a-e71c6d5fae6d"), (short)1, new Guid("bc6ad623-c769-4887-8264-90a5fe153efa") },
                    { new Guid("dedc1654-4d0a-43ed-a38d-143ea2a7b31c"), (short)2, new Guid("bc6ad623-c769-4887-8264-90a5fe153efa") },
                    { new Guid("58da87a9-c8e5-4be0-9c71-f9c9f73df7ba"), (short)1, new Guid("8acee112-8c60-4bec-8636-b36540f94aa9") },
                    { new Guid("d996b970-5404-4738-a074-8687d8aa9912"), (short)2, new Guid("8acee112-8c60-4bec-8636-b36540f94aa9") },
                    { new Guid("1ce051c7-7ad8-40fa-ad37-1cfe72f03558"), (short)1, new Guid("f5ef253d-1857-4f49-8c06-b40539de3148") },
                    { new Guid("f19afed3-7e28-4f8b-9c27-f9ee51eba060"), (short)2, new Guid("f5ef253d-1857-4f49-8c06-b40539de3148") },
                    { new Guid("2db86801-969f-48b3-905c-60b04d0cc4ad"), (short)2, new Guid("cb98b69e-f858-4a62-b24f-5c472982fec0") },
                    { new Guid("02e9c350-f74d-4f3c-82e2-d7b550aba073"), (short)1, new Guid("99f16b36-4b78-4b17-96f8-35d8e2fdfe3d") },
                    { new Guid("8241e5a3-9fd4-469c-8a3a-cafc329ef06f"), (short)1, new Guid("6705eaad-b3ba-4554-9438-edf45960d5fd") },
                    { new Guid("2c461059-c0ce-4014-8cda-322f87492aa6"), (short)2, new Guid("6705eaad-b3ba-4554-9438-edf45960d5fd") },
                    { new Guid("41098c2a-10e4-419d-bc3f-4a98fdcd9886"), (short)1, new Guid("af22145f-d1e3-4abe-90ed-6e77626ca697") },
                    { new Guid("8fe16bf2-da33-4ca5-9f7b-04698575b8c8"), (short)2, new Guid("af22145f-d1e3-4abe-90ed-6e77626ca697") },
                    { new Guid("4cc32661-5198-462d-a875-72e94db46c43"), (short)1, new Guid("37ddbdf9-43e1-443e-a0ab-9766dad0dc7b") },
                    { new Guid("963cf773-7521-432e-9982-1e2949e7027b"), (short)1, new Guid("f8e4ef34-70a2-495e-98b2-8be6343cb465") },
                    { new Guid("d7adb406-72ae-402a-ae73-f0e1e225e352"), (short)1, new Guid("6c645841-25c5-4ded-b6e7-0fc8eb0bd252") },
                    { new Guid("7b249737-e51c-4dec-8cbc-f80df205c401"), (short)2, new Guid("99f16b36-4b78-4b17-96f8-35d8e2fdfe3d") },
                    { new Guid("22dba56e-6888-463d-9228-fab9730af92f"), (short)2, new Guid("f8e4ef34-70a2-495e-98b2-8be6343cb465") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("906dd809-8d8a-495a-9c33-98d4afc17461"), (short)2, "Course0", new Guid("2c032d08-736e-42ea-bd92-327472a78910"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("136be3a8-a231-4c3b-92cf-61c72b460457"), (short)1, "Course56", new Guid("370a7847-1322-49dd-a10e-c2715f4d761c"), new Guid("ba1fcd39-4e90-42d6-a1f1-d52be00852c8") },
                    { new Guid("fec2a961-cb3d-4a04-b9ca-3439dfed1c6d"), (short)4, "Course112", new Guid("370a7847-1322-49dd-a10e-c2715f4d761c"), new Guid("47a375c2-c9b6-4013-8239-e327ab21d4ec") },
                    { new Guid("61277015-8741-4f85-ab0a-3de57a5d02e5"), (short)3, "Course168", new Guid("370a7847-1322-49dd-a10e-c2715f4d761c"), new Guid("af0a604d-1fc1-4e3f-b242-2acd97d398f3") },
                    { new Guid("e6747b92-ba89-441c-8d23-5dc14b0615c2"), (short)1, "Course224", new Guid("370a7847-1322-49dd-a10e-c2715f4d761c"), new Guid("1fd187e5-d7c8-42d2-81e4-fe3dde7b0701") },
                    { new Guid("d4983658-7edd-45ed-a06c-21569e7e1d79"), (short)1, "Course280", new Guid("370a7847-1322-49dd-a10e-c2715f4d761c"), new Guid("2b9f0266-611a-4820-b5c7-8d1bd747f55b") },
                    { new Guid("70580ee6-2b4a-4e64-b20b-9c6e9efa190b"), (short)0, "Course465", new Guid("2a3dcf49-b486-4136-8b78-d46221adb6cc"), new Guid("be501952-af82-4aa8-813c-ebe8bb64cd67") },
                    { new Guid("7715702b-51cc-4281-876a-4808ca9212b8"), (short)4, "Course372", new Guid("2a3dcf49-b486-4136-8b78-d46221adb6cc"), new Guid("d889d0ce-23d0-4a95-bd16-51e3a1cf0ce7") },
                    { new Guid("21ff42be-67d5-4255-88f6-f5ac97cb460b"), (short)1, "Course0", new Guid("370a7847-1322-49dd-a10e-c2715f4d761c"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("6c7f45df-852f-4d32-83c2-12d85202d28c"), (short)1, "Course0", new Guid("41a946ba-8472-4abc-98dc-136ad09a5119"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("64cf1122-7036-4dad-9807-58553ecd63dd"), (short)4, "Course114", new Guid("41a946ba-8472-4abc-98dc-136ad09a5119"), new Guid("c6c1ba00-b0aa-47df-88f4-33af23ac06cb") },
                    { new Guid("55151110-f4c0-446c-b38d-6442f3c310ad"), (short)4, "Course171", new Guid("41a946ba-8472-4abc-98dc-136ad09a5119"), new Guid("92bf0ac3-63b0-4789-811f-24ef059c3653") },
                    { new Guid("6ebe122a-a0cb-41f8-ae7e-053e36958751"), (short)3, "Course228", new Guid("41a946ba-8472-4abc-98dc-136ad09a5119"), new Guid("fd7aa746-fa3d-4b6c-bfc4-180fa0062035") },
                    { new Guid("85c70dca-a932-421b-bc5c-6cbcdfd7b870"), (short)2, "Course285", new Guid("41a946ba-8472-4abc-98dc-136ad09a5119"), new Guid("db11804c-38ec-4fc9-8136-dc47b7b789e3") },
                    { new Guid("e0b6feb6-05d2-411a-8ccf-833b1bb18f72"), (short)5, "Course279", new Guid("2a3dcf49-b486-4136-8b78-d46221adb6cc"), new Guid("2aeea0c4-8fec-45f9-a6b0-e00afbf6f983") },
                    { new Guid("080e5b0e-74e5-4dbd-a7ad-45082de7d2f9"), (short)2, "Course186", new Guid("2a3dcf49-b486-4136-8b78-d46221adb6cc"), new Guid("56dd0284-ef65-45c8-9633-7ece06a318f0") },
                    { new Guid("a9072093-c69d-4e65-bd2c-b4f0bc9888a5"), (short)2, "Course0", new Guid("6f27750f-59c8-4752-af90-d58085785dbd"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("f0503857-5baf-4402-a99e-9ba10825e283"), (short)3, "Course57", new Guid("41a946ba-8472-4abc-98dc-136ad09a5119"), new Guid("8762d3cf-d975-4550-b61c-1b891a10d890") },
                    { new Guid("5197d2e3-6959-4d8b-8a33-1c491abdd644"), (short)4, "Course275", new Guid("64fad46b-9d9d-4f26-812c-5c78eea8b243"), new Guid("4b3c243d-26a2-430b-a779-cf81b39134eb") },
                    { new Guid("22a1b9de-9728-4b02-b286-e14fd9c15be0"), (short)3, "Course220", new Guid("64fad46b-9d9d-4f26-812c-5c78eea8b243"), new Guid("a5b92ef6-ec55-4ce7-8fbf-2260b49d0ad7") },
                    { new Guid("2dc45e7a-6133-46b0-bc85-a0ffb0375203"), (short)4, "Course165", new Guid("64fad46b-9d9d-4f26-812c-5c78eea8b243"), new Guid("be501952-af82-4aa8-813c-ebe8bb64cd67") },
                    { new Guid("865bc821-6c67-447d-a901-4a32da9b67df"), (short)2, "Course106", new Guid("49fd7f4c-a8ca-45d5-bbe0-55ef9faca700"), new Guid("a37d6845-9076-475c-9302-4ca8b1f09f0f") },
                    { new Guid("7c04521c-ef15-4241-ae7a-97919fa4bc61"), (short)5, "Course159", new Guid("49fd7f4c-a8ca-45d5-bbe0-55ef9faca700"), new Guid("a90c16da-5d98-417b-b25e-97a364bd5cf8") },
                    { new Guid("c6a3aed2-6602-4511-a172-9c898b2f4398"), (short)0, "Course212", new Guid("49fd7f4c-a8ca-45d5-bbe0-55ef9faca700"), new Guid("47a375c2-c9b6-4013-8239-e327ab21d4ec") },
                    { new Guid("910e4442-248e-4648-abfa-703082a05beb"), (short)3, "Course265", new Guid("49fd7f4c-a8ca-45d5-bbe0-55ef9faca700"), new Guid("be501952-af82-4aa8-813c-ebe8bb64cd67") },
                    { new Guid("0dd4da5c-fa41-4f59-8c1b-40881314809d"), (short)0, "Course282", new Guid("053cf60d-5963-4dcb-812d-a6a98e2b1817"), new Guid("50e805fc-950a-4835-b29b-6cee79b22045") },
                    { new Guid("2960f5a3-9da4-4d15-ac6d-525c6ff9cf1b"), (short)2, "Course188", new Guid("053cf60d-5963-4dcb-812d-a6a98e2b1817"), new Guid("04b536cf-d059-43f5-a187-012c25285d74") },
                    { new Guid("0560ac6a-9403-41b8-9fdb-c45c8e612fec"), (short)5, "Course0", new Guid("d7adb406-72ae-402a-ae73-f0e1e225e352"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("feb34af5-ba19-4b84-930e-6d399703650e"), (short)2, "Course54", new Guid("d7adb406-72ae-402a-ae73-f0e1e225e352"), new Guid("471b80b9-dd36-4a48-89c2-39b5941f439d") },
                    { new Guid("8ae066be-f3be-49a9-a1f9-ce85055df517"), (short)1, "Course108", new Guid("d7adb406-72ae-402a-ae73-f0e1e225e352"), new Guid("5b0e27a8-b03b-405e-9d61-be91ffb92942") },
                    { new Guid("db71b300-6748-43b5-ab35-a65e081e6ffe"), (short)1, "Course162", new Guid("d7adb406-72ae-402a-ae73-f0e1e225e352"), new Guid("63d077b3-c8e6-414f-9036-959e8c825846") },
                    { new Guid("47758884-e890-4dd4-9680-4d383ec48629"), (short)4, "Course216", new Guid("d7adb406-72ae-402a-ae73-f0e1e225e352"), new Guid("1659619d-a195-40f0-9b32-7ae994c4f7c5") },
                    { new Guid("8e502882-9c2e-4af7-8bf9-08962b38e80a"), (short)0, "Course270", new Guid("d7adb406-72ae-402a-ae73-f0e1e225e352"), new Guid("8ef9a447-3f54-4ebc-854d-d176e74601b4") },
                    { new Guid("ab43902c-7dae-4efa-bb89-7db0183f0fff"), (short)4, "Course94", new Guid("053cf60d-5963-4dcb-812d-a6a98e2b1817"), new Guid("f37ac984-18b0-4afa-804c-e73b27c47f8e") },
                    { new Guid("1be6c824-bf98-4f3a-8258-ca628617fb99"), (short)3, "Course0", new Guid("053cf60d-5963-4dcb-812d-a6a98e2b1817"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("c8ff09b6-6b79-4cef-b942-d0e1efad3d02"), (short)1, "Course0", new Guid("64fad46b-9d9d-4f26-812c-5c78eea8b243"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("9a9bcaae-7cb7-4b38-876c-25cb8ebecefc"), (short)2, "Course55", new Guid("64fad46b-9d9d-4f26-812c-5c78eea8b243"), new Guid("42be7409-d3d8-4bfd-880e-2d18372f07d6") },
                    { new Guid("2c593985-7438-48fb-ba77-4a89ae6135c3"), (short)2, "Course110", new Guid("64fad46b-9d9d-4f26-812c-5c78eea8b243"), new Guid("58f484aa-8ab3-44b3-979a-f5c7b99910f6") },
                    { new Guid("c6b45424-b7e1-4456-ab46-8557a17897b6"), (short)1, "Course58", new Guid("6f27750f-59c8-4752-af90-d58085785dbd"), new Guid("0eafc5e8-bb25-43ce-aa71-fac4ee547b1c") },
                    { new Guid("01fc1b9d-26e3-4fe7-8a36-e5dc43819107"), (short)3, "Course116", new Guid("6f27750f-59c8-4752-af90-d58085785dbd"), new Guid("1659619d-a195-40f0-9b32-7ae994c4f7c5") },
                    { new Guid("2bc55284-e6af-4a54-b98b-de99f84995e1"), (short)4, "Course174", new Guid("6f27750f-59c8-4752-af90-d58085785dbd"), new Guid("6baee663-1d3a-4058-9a14-b4ed26be7e08") },
                    { new Guid("c272a85d-7dd9-4e8b-b659-ad2f515d2c0d"), (short)1, "Course232", new Guid("6f27750f-59c8-4752-af90-d58085785dbd"), new Guid("1bf88dee-3b4f-48fd-9679-6c90ced03977") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("a41297b6-ae7f-4251-8cd0-e7fad4f9ec6a"), (short)1, "Course244", new Guid("f0943399-5999-49bf-9fc0-642a5922a0bc"), new Guid("e8405a7e-6809-4ac1-951d-03781410be97") },
                    { new Guid("b3d10caf-0729-4901-bec7-d16f096bb4a7"), (short)3, "Course305", new Guid("f0943399-5999-49bf-9fc0-642a5922a0bc"), new Guid("5b5bebc1-9a18-4276-8f59-032c426a7461") },
                    { new Guid("ee61b4c7-16c0-4e82-bfbe-550ac2629f7a"), (short)0, "Course276", new Guid("10418318-09fe-4b62-924e-b02017044cd9"), new Guid("921e3f7f-7818-4f66-a546-133a47447022") },
                    { new Guid("491222a1-53be-435c-9195-978730c444dd"), (short)1, "Course184", new Guid("10418318-09fe-4b62-924e-b02017044cd9"), new Guid("ccb7a87a-5a14-4961-8ca6-8063675b2bce") },
                    { new Guid("1ecf20d7-1912-4d0a-bc20-f61267eb0240"), (short)5, "Course0", new Guid("fc5fcbac-a0b5-4059-8e1b-d396aa269a67"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("2fa64285-4f03-4a2c-91b3-dbc26f88ecf0"), (short)3, "Course62", new Guid("fc5fcbac-a0b5-4059-8e1b-d396aa269a67"), new Guid("63d077b3-c8e6-414f-9036-959e8c825846") },
                    { new Guid("4091d4cb-4d4e-48dd-b43c-2ef3238062c5"), (short)1, "Course124", new Guid("fc5fcbac-a0b5-4059-8e1b-d396aa269a67"), new Guid("1fd187e5-d7c8-42d2-81e4-fe3dde7b0701") },
                    { new Guid("18042d3f-9646-41f8-9bfd-3ff45008e2e9"), (short)3, "Course186", new Guid("fc5fcbac-a0b5-4059-8e1b-d396aa269a67"), new Guid("56dd0284-ef65-45c8-9633-7ece06a318f0") },
                    { new Guid("8d806659-c9e0-4af6-b593-55afa024adbd"), (short)5, "Course248", new Guid("fc5fcbac-a0b5-4059-8e1b-d396aa269a67"), new Guid("0714acfd-7b85-4714-95a4-2693f68cc7fe") },
                    { new Guid("62bb6b7c-2374-4a0a-b7a9-42f767228f83"), (short)4, "Course310", new Guid("fc5fcbac-a0b5-4059-8e1b-d396aa269a67"), new Guid("58f484aa-8ab3-44b3-979a-f5c7b99910f6") },
                    { new Guid("ff8cf2cd-1d04-4e7d-96cb-85f06b38d2a3"), (short)2, "Course92", new Guid("10418318-09fe-4b62-924e-b02017044cd9"), new Guid("f0b375b4-3975-4e1e-9ea4-49b33f1fa3c9") },
                    { new Guid("8ae75980-1503-411e-bd13-150a7b8f505e"), (short)0, "Course0", new Guid("10418318-09fe-4b62-924e-b02017044cd9"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("bcad8daf-8112-4f30-bd08-91117859dcf1"), (short)3, "Course0", new Guid("52beef09-20ce-4c37-ab89-94f2694cb95b"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("c4ec73a6-a647-4e02-9005-c1530177a495"), (short)1, "Course63", new Guid("52beef09-20ce-4c37-ab89-94f2694cb95b"), new Guid("63af8a63-3d9f-4a25-8e2c-db885be41b6e") },
                    { new Guid("2297a6f0-2152-4ec9-8f42-df199cb2b948"), (short)0, "Course126", new Guid("52beef09-20ce-4c37-ab89-94f2694cb95b"), new Guid("9bcbddf1-7697-462d-a409-ac2b527d26b9") },
                    { new Guid("9a386f20-022b-4a53-986c-3a62b7788d5e"), (short)5, "Course189", new Guid("52beef09-20ce-4c37-ab89-94f2694cb95b"), new Guid("320b7836-0470-4b4a-8ee5-5146e0766166") },
                    { new Guid("81eddf59-e7c3-4c7f-918c-e20063c11adf"), (short)2, "Course252", new Guid("52beef09-20ce-4c37-ab89-94f2694cb95b"), new Guid("cd4fcdd9-3743-4d8d-823d-c16e81bf7feb") },
                    { new Guid("11f30c98-0892-4a3b-a7c7-038a7b0f6566"), (short)1, "Course183", new Guid("f0943399-5999-49bf-9fc0-642a5922a0bc"), new Guid("55bcdfb7-5436-425f-aa75-67ed0bec3c6d") },
                    { new Guid("b3c01b3a-45d3-41d0-9b1b-561fdfe241f2"), (short)5, "Course53", new Guid("49fd7f4c-a8ca-45d5-bbe0-55ef9faca700"), new Guid("fa322a6f-6d03-46c5-a563-fb058063c944") },
                    { new Guid("b7e7c975-162e-430d-85c9-435cb564fd2f"), (short)1, "Course122", new Guid("f0943399-5999-49bf-9fc0-642a5922a0bc"), new Guid("f271e53b-f316-4f3c-9aca-8469584bb14a") },
                    { new Guid("4acaf61f-2521-4be4-853a-2feb54af0010"), (short)3, "Course0", new Guid("f0943399-5999-49bf-9fc0-642a5922a0bc"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("f8140da5-1062-4c78-a1c7-1976cfb085a0"), (short)3, "Course290", new Guid("6f27750f-59c8-4752-af90-d58085785dbd"), new Guid("dc2dccbe-b289-444f-b374-df5eae1ea96a") },
                    { new Guid("2d38f98e-6724-477c-a73f-396e5dcf01bc"), (short)2, "Course93", new Guid("2a3dcf49-b486-4136-8b78-d46221adb6cc"), new Guid("6354b09f-7243-4fb7-9695-f70ccf026e24") },
                    { new Guid("4d3d57c6-64aa-42da-b64b-2f59888b69f0"), (short)5, "Course0", new Guid("2a3dcf49-b486-4136-8b78-d46221adb6cc"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("96147c98-1e2f-4bb9-8b04-efa5fae73a17"), (short)2, "Course0", new Guid("34ec0591-8ec4-4c9c-9cd9-fa70ef5a2483"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("6bddb896-7dc5-4331-89b4-ce80f0ba25cb"), (short)5, "Course59", new Guid("34ec0591-8ec4-4c9c-9cd9-fa70ef5a2483"), new Guid("a90c16da-5d98-417b-b25e-97a364bd5cf8") },
                    { new Guid("99d47d15-0dd9-4137-ad27-69ba207e77ed"), (short)4, "Course118", new Guid("34ec0591-8ec4-4c9c-9cd9-fa70ef5a2483"), new Guid("6489c875-e57b-49e3-b8db-13d8166de086") },
                    { new Guid("a860fa67-d50c-41f3-ba5f-4286000b53a8"), (short)0, "Course177", new Guid("34ec0591-8ec4-4c9c-9cd9-fa70ef5a2483"), new Guid("ef9025e8-8f9b-49e2-862f-d9f742990e86") },
                    { new Guid("8b2a7c9b-1327-4d81-99e5-249983d9fe1e"), (short)3, "Course236", new Guid("34ec0591-8ec4-4c9c-9cd9-fa70ef5a2483"), new Guid("c78d7301-bd14-40e7-b41e-b8ab84ad6c78") },
                    { new Guid("e1f9a4cf-1c41-413a-b7d0-1003afcd86da"), (short)5, "Course295", new Guid("34ec0591-8ec4-4c9c-9cd9-fa70ef5a2483"), new Guid("a49dc22c-16b1-450f-bd05-54627b33a952") },
                    { new Guid("85d89554-73f9-415c-b2f8-2ac198b4f496"), (short)3, "Course0", new Guid("f33058bb-8a16-4cde-9306-f2868506d4e9"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("a8cce7e3-1203-47df-b7c8-60f61f264f69"), (short)1, "Course60", new Guid("f33058bb-8a16-4cde-9306-f2868506d4e9"), new Guid("6b5a6b95-6bd0-4340-babb-e56e9ac0171d") },
                    { new Guid("5f57b404-e088-46d0-8114-119ea99f8378"), (short)2, "Course120", new Guid("f33058bb-8a16-4cde-9306-f2868506d4e9"), new Guid("a5b92ef6-ec55-4ce7-8fbf-2260b49d0ad7") },
                    { new Guid("ea48a55c-1290-4288-9809-9f40bf9e04d3"), (short)0, "Course180", new Guid("f33058bb-8a16-4cde-9306-f2868506d4e9"), new Guid("2b9f0266-611a-4820-b5c7-8d1bd747f55b") },
                    { new Guid("0193c253-5ca8-4c45-a6eb-3e0f243dd5ff"), (short)5, "Course240", new Guid("f33058bb-8a16-4cde-9306-f2868506d4e9"), new Guid("c69543f7-c451-44af-8136-7600bf55903c") },
                    { new Guid("0cbf18c2-fc03-4c01-b4ac-8976d2731678"), (short)2, "Course300", new Guid("f33058bb-8a16-4cde-9306-f2868506d4e9"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("365b1816-2ac7-418b-879d-de53c9cc4df9"), (short)1, "Course460", new Guid("10418318-09fe-4b62-924e-b02017044cd9"), new Guid("6b5a6b95-6bd0-4340-babb-e56e9ac0171d") },
                    { new Guid("0dc3fa59-23a8-4dde-b131-aaa8731fba51"), (short)2, "Course368", new Guid("10418318-09fe-4b62-924e-b02017044cd9"), new Guid("af0a604d-1fc1-4e3f-b242-2acd97d398f3") },
                    { new Guid("f08d8e5e-3e4f-4652-96e8-b5f22d09e951"), (short)5, "Course61", new Guid("f0943399-5999-49bf-9fc0-642a5922a0bc"), new Guid("015f56f9-e4b3-41dc-adb6-ee2f90ec89cf") },
                    { new Guid("dfe54a19-41cd-4eb9-a4dc-503d39516f9d"), (short)2, "Course0", new Guid("49fd7f4c-a8ca-45d5-bbe0-55ef9faca700"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("c3e94dba-505c-4938-a317-bbb493a61267"), (short)5, "Course376", new Guid("053cf60d-5963-4dcb-812d-a6a98e2b1817"), new Guid("921e3f7f-7818-4f66-a546-133a47447022") },
                    { new Guid("f8b57cc8-624c-4129-a74b-8926fdae51e7"), (short)3, "Course470", new Guid("053cf60d-5963-4dcb-812d-a6a98e2b1817"), new Guid("8ef9a447-3f54-4ebc-854d-d176e74601b4") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("a401fb42-dd88-415a-9849-32ece64b8111"), (short)4, "Course384", new Guid("6a34ac77-de2a-48ca-884a-0826d1b646ec"), new Guid("ccb7a87a-5a14-4961-8ca6-8063675b2bce") },
                    { new Guid("9621d207-6d83-4c6b-bc62-dcc35f5fedcd"), (short)3, "Course0", new Guid("f19afed3-7e28-4f8b-9c27-f9ee51eba060"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("8a703608-de5c-4729-8a49-fbfe44634a57"), (short)2, "Course45", new Guid("f19afed3-7e28-4f8b-9c27-f9ee51eba060"), new Guid("8ec1697b-d4d9-4c6c-8d7e-a7a369a05831") },
                    { new Guid("db8022f7-6717-4b08-8a30-9fbb6da8ed38"), (short)1, "Course90", new Guid("f19afed3-7e28-4f8b-9c27-f9ee51eba060"), new Guid("dc2dccbe-b289-444f-b374-df5eae1ea96a") },
                    { new Guid("e717195b-2c14-4f1a-a957-783a0d11f43f"), (short)2, "Course135", new Guid("f19afed3-7e28-4f8b-9c27-f9ee51eba060"), new Guid("5166b68f-19c7-4295-8001-acab80e3be59") },
                    { new Guid("f72f65e5-2554-4030-8c36-623b65095e20"), (short)0, "Course180", new Guid("f19afed3-7e28-4f8b-9c27-f9ee51eba060"), new Guid("2b9f0266-611a-4820-b5c7-8d1bd747f55b") },
                    { new Guid("320a3c38-1f39-480e-9625-ebe0f3b971b2"), (short)1, "Course225", new Guid("f19afed3-7e28-4f8b-9c27-f9ee51eba060"), new Guid("384f6076-f8f2-4e95-b51f-f0883a9a5576") },
                    { new Guid("33636942-5a65-473e-9c8d-193ecf63aa1c"), (short)0, "Course288", new Guid("6a34ac77-de2a-48ca-884a-0826d1b646ec"), new Guid("04b536cf-d059-43f5-a187-012c25285d74") },
                    { new Guid("b32c18e4-f3a4-4ca3-a76b-2b8e83f1b064"), (short)0, "Course192", new Guid("6a34ac77-de2a-48ca-884a-0826d1b646ec"), new Guid("f0b375b4-3975-4e1e-9ea4-49b33f1fa3c9") },
                    { new Guid("94d5ca6c-0bf5-4313-a832-a36b704f50a8"), (short)1, "Course0", new Guid("02e9c350-f74d-4f3c-82e2-d7b550aba073"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("e30238c5-515f-4534-ac30-f3e12f04fffa"), (short)1, "Course46", new Guid("02e9c350-f74d-4f3c-82e2-d7b550aba073"), new Guid("07fe7183-eeba-4290-ad4f-98cacee625ea") },
                    { new Guid("d0138a6d-1664-48dc-ad9b-6345fd5e27a6"), (short)4, "Course92", new Guid("02e9c350-f74d-4f3c-82e2-d7b550aba073"), new Guid("f0b375b4-3975-4e1e-9ea4-49b33f1fa3c9") },
                    { new Guid("00dda823-b80f-4195-947b-792a84149392"), (short)4, "Course138", new Guid("02e9c350-f74d-4f3c-82e2-d7b550aba073"), new Guid("f60e2337-f07e-45d8-9aa3-5e8314156a8d") },
                    { new Guid("52ed327f-f18d-4e7f-8da7-0277b482b5fa"), (short)0, "Course184", new Guid("02e9c350-f74d-4f3c-82e2-d7b550aba073"), new Guid("ccb7a87a-5a14-4961-8ca6-8063675b2bce") },
                    { new Guid("1032c8ca-e7b2-4c28-8a0c-fadc6b6f6b02"), (short)2, "Course230", new Guid("02e9c350-f74d-4f3c-82e2-d7b550aba073"), new Guid("9d0e4158-3440-4bf7-b67d-078faeeddbcb") },
                    { new Guid("9832e2cd-57cc-47ce-a27e-7394a1cd2cf9"), (short)0, "Course96", new Guid("6a34ac77-de2a-48ca-884a-0826d1b646ec"), new Guid("af0231e3-54e5-4f62-a16d-7bcbcc3862b5") },
                    { new Guid("ecc8f969-a667-4e38-bd57-23220834fd7a"), (short)2, "Course0", new Guid("6a34ac77-de2a-48ca-884a-0826d1b646ec"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("17c0fec8-0a9a-43d3-9aa9-091dbe3a792e"), (short)2, "Course480", new Guid("6a34ac77-de2a-48ca-884a-0826d1b646ec"), new Guid("2b9f0266-611a-4820-b5c7-8d1bd747f55b") },
                    { new Guid("81c5c93a-d1a4-4ddf-9f49-b4e0aa66ed3c"), (short)0, "Course0", new Guid("7b249737-e51c-4dec-8cbc-f80df205c401"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("d7c270b6-0297-4a72-b41a-540e00a6f3e6"), (short)0, "Course220", new Guid("1ce051c7-7ad8-40fa-ad37-1cfe72f03558"), new Guid("a5b92ef6-ec55-4ce7-8fbf-2260b49d0ad7") },
                    { new Guid("8fcab235-194c-4f63-b329-509c548b39e8"), (short)1, "Course132", new Guid("1ce051c7-7ad8-40fa-ad37-1cfe72f03558"), new Guid("1bf88dee-3b4f-48fd-9679-6c90ced03977") },
                    { new Guid("79614cf3-0331-40f8-987d-4369266aba19"), (short)0, "Course0", new Guid("58da87a9-c8e5-4be0-9c71-f9c9f73df7ba"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("f1d0980e-c187-4d8d-b810-8c85d04ad27d"), (short)1, "Course42", new Guid("58da87a9-c8e5-4be0-9c71-f9c9f73df7ba"), new Guid("b589b9ab-99a7-42e6-ada6-d1d692d94214") },
                    { new Guid("8c51af39-1650-47eb-853c-37ae9fa9aa41"), (short)1, "Course84", new Guid("58da87a9-c8e5-4be0-9c71-f9c9f73df7ba"), new Guid("ccb7a87a-5a14-4961-8ca6-8063675b2bce") },
                    { new Guid("c55dc0e0-22c6-43d0-bd3a-9f99006635fa"), (short)3, "Course126", new Guid("58da87a9-c8e5-4be0-9c71-f9c9f73df7ba"), new Guid("9bcbddf1-7697-462d-a409-ac2b527d26b9") },
                    { new Guid("a38fa0b8-58a5-4a6d-8f3b-c86e91006fba"), (short)4, "Course168", new Guid("58da87a9-c8e5-4be0-9c71-f9c9f73df7ba"), new Guid("af0a604d-1fc1-4e3f-b242-2acd97d398f3") },
                    { new Guid("3a2f850f-9267-4c4e-9492-eb8d83d9eb91"), (short)5, "Course210", new Guid("58da87a9-c8e5-4be0-9c71-f9c9f73df7ba"), new Guid("58f484aa-8ab3-44b3-979a-f5c7b99910f6") },
                    { new Guid("87dd4002-8117-4b6a-a1ac-15d1f060d203"), (short)4, "Course97", new Guid("d6241a14-3a43-4d50-ab66-2684d89fe179"), new Guid("923257c6-f46b-4250-8337-b6ac1f4357ca") },
                    { new Guid("adc457f6-c2b1-41a5-9639-56479b96d0a7"), (short)5, "Course0", new Guid("d6241a14-3a43-4d50-ab66-2684d89fe179"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("19b859ea-d39e-41f9-a615-91bf002ab2dd"), (short)5, "Course0", new Guid("f08fd625-7ae2-409f-b72a-f2cccf217e07"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("f92a5121-d8c5-47e2-8c9b-941a18937187"), (short)0, "Course43", new Guid("d996b970-5404-4738-a074-8687d8aa9912"), new Guid("b6fa213a-f7e3-453c-8d0c-7f4e3fbda256") },
                    { new Guid("1cc8ea72-7a51-4a8d-8717-2d60d78993fc"), (short)5, "Course86", new Guid("d996b970-5404-4738-a074-8687d8aa9912"), new Guid("56dd0284-ef65-45c8-9633-7ece06a318f0") },
                    { new Guid("d248691c-b00a-49a9-ab0c-e2a7d7f025c5"), (short)3, "Course129", new Guid("d996b970-5404-4738-a074-8687d8aa9912"), new Guid("47d9fc1a-717f-4d80-a88a-79195ef4c6b1") },
                    { new Guid("0d64ed3c-b0a2-431e-a209-99c68767c9f6"), (short)5, "Course172", new Guid("d996b970-5404-4738-a074-8687d8aa9912"), new Guid("d889d0ce-23d0-4a95-bd16-51e3a1cf0ce7") },
                    { new Guid("368c371a-b13e-4037-b628-e9c527b51174"), (short)2, "Course215", new Guid("d996b970-5404-4738-a074-8687d8aa9912"), new Guid("b1b3057c-b83e-4a08-bc6a-9360d5af13bd") },
                    { new Guid("a0374bcb-22a0-4685-a0d1-c1ec3de6254e"), (short)4, "Course0", new Guid("1ce051c7-7ad8-40fa-ad37-1cfe72f03558"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("d6bcdf5c-d182-41ec-ad67-ad67cc7ef5ce"), (short)1, "Course44", new Guid("1ce051c7-7ad8-40fa-ad37-1cfe72f03558"), new Guid("e8405a7e-6809-4ac1-951d-03781410be97") },
                    { new Guid("8fdcb275-c6ce-4d35-82fb-5109a2fafdb0"), (short)4, "Course88", new Guid("1ce051c7-7ad8-40fa-ad37-1cfe72f03558"), new Guid("04b536cf-d059-43f5-a187-012c25285d74") },
                    { new Guid("7f0305fc-efee-4428-8450-7a2c27f29549"), (short)0, "Course176", new Guid("1ce051c7-7ad8-40fa-ad37-1cfe72f03558"), new Guid("921e3f7f-7818-4f66-a546-133a47447022") },
                    { new Guid("5f8f8b66-68c6-4938-b855-cce8fa627a1e"), (short)0, "Course315", new Guid("52beef09-20ce-4c37-ab89-94f2694cb95b"), new Guid("b1b3057c-b83e-4a08-bc6a-9360d5af13bd") },
                    { new Guid("9d8fc098-1879-419d-85bb-7ff089eff5ba"), (short)2, "Course47", new Guid("7b249737-e51c-4dec-8cbc-f80df205c401"), new Guid("e05af25e-082a-4b80-a28f-832214ce10bc") },
                    { new Guid("bc89d3c1-e7ed-4b36-a9bd-7b73cebd3e44"), (short)5, "Course141", new Guid("7b249737-e51c-4dec-8cbc-f80df205c401"), new Guid("1784f2dc-d5c1-429c-8642-19b865a1afb7") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("d733d0e4-0aae-4d5f-b006-045d257898a7"), (short)4, "Course150", new Guid("41098c2a-10e4-419d-bc3f-4a98fdcd9886"), new Guid("a92a7897-7ed2-4983-a5e7-33d72a168392") },
                    { new Guid("90b7c1c3-ae8d-4fed-a4cc-4d0271b535ef"), (short)4, "Course200", new Guid("41098c2a-10e4-419d-bc3f-4a98fdcd9886"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("b8ef3f15-1cac-49c6-ad90-a2831e579ee4"), (short)4, "Course250", new Guid("41098c2a-10e4-419d-bc3f-4a98fdcd9886"), new Guid("a92a7897-7ed2-4983-a5e7-33d72a168392") },
                    { new Guid("bcac115c-33e7-430e-b4d6-317dd31b3a6a"), (short)5, "Course95", new Guid("aca00e4f-9891-42ce-b030-bdb460912a86"), new Guid("a49dc22c-16b1-450f-bd05-54627b33a952") },
                    { new Guid("d4c75a46-8614-4032-b4a4-a3854e0c3584"), (short)0, "Course0", new Guid("aca00e4f-9891-42ce-b030-bdb460912a86"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("cb002d4c-d021-411c-8a07-affe1275b4d8"), (short)5, "Course0", new Guid("8fe16bf2-da33-4ca5-9f7b-04698575b8c8"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("eaacffb1-7a1f-4577-8ee5-58820ecffbf2"), (short)4, "Course51", new Guid("8fe16bf2-da33-4ca5-9f7b-04698575b8c8"), new Guid("91ed7051-9e55-4279-96b3-f8be2e6efe11") },
                    { new Guid("5b60d3f9-7471-4ea9-bc60-981c086e58d7"), (short)4, "Course102", new Guid("8fe16bf2-da33-4ca5-9f7b-04698575b8c8"), new Guid("ea8f4004-e239-4fe6-aebe-f954474d000f") },
                    { new Guid("46db6fa8-3745-4b86-bab2-10f2e56d2baf"), (short)3, "Course153", new Guid("8fe16bf2-da33-4ca5-9f7b-04698575b8c8"), new Guid("fa322a6f-6d03-46c5-a563-fb058063c944") },
                    { new Guid("195f9174-f332-4160-b8da-02cc2ed75b55"), (short)0, "Course204", new Guid("8fe16bf2-da33-4ca5-9f7b-04698575b8c8"), new Guid("e2ba043f-3076-4149-a411-f3ec84d0ac5f") },
                    { new Guid("357eef59-de6a-4f7c-bf94-ee1e7a7e76fe"), (short)2, "Course255", new Guid("8fe16bf2-da33-4ca5-9f7b-04698575b8c8"), new Guid("42be7409-d3d8-4bfd-880e-2d18372f07d6") },
                    { new Guid("38d2dc9f-8492-420f-b167-056b4d7ea71b"), (short)1, "Course0", new Guid("4cc32661-5198-462d-a875-72e94db46c43"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("6da16aa6-c777-4b3e-abde-5c6e7eb3cb70"), (short)0, "Course52", new Guid("4cc32661-5198-462d-a875-72e94db46c43"), new Guid("cd4fcdd9-3743-4d8d-823d-c16e81bf7feb") },
                    { new Guid("d74fe85d-cf5c-4b69-ab5c-e71da7fac185"), (short)5, "Course104", new Guid("4cc32661-5198-462d-a875-72e94db46c43"), new Guid("e2ba043f-3076-4149-a411-f3ec84d0ac5f") },
                    { new Guid("6cea15a0-5181-4c3f-838d-be23c8079dbd"), (short)4, "Course156", new Guid("4cc32661-5198-462d-a875-72e94db46c43"), new Guid("ba1fcd39-4e90-42d6-a1f1-d52be00852c8") },
                    { new Guid("d80b6ca1-4438-42e6-a534-637e758b39fd"), (short)4, "Course208", new Guid("4cc32661-5198-462d-a875-72e94db46c43"), new Guid("5b0e27a8-b03b-405e-9d61-be91ffb92942") },
                    { new Guid("1ecb286a-4410-4dcc-bef2-94cbc1fe8182"), (short)1, "Course260", new Guid("4cc32661-5198-462d-a875-72e94db46c43"), new Guid("6b5a6b95-6bd0-4340-babb-e56e9ac0171d") },
                    { new Guid("05a5e83a-ebba-4963-b678-4c71cf78ddfa"), (short)2, "Course100", new Guid("41098c2a-10e4-419d-bc3f-4a98fdcd9886"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("b82c32cd-00ba-4e06-998c-1d5272eb32f4"), (short)5, "Course94", new Guid("7b249737-e51c-4dec-8cbc-f80df205c401"), new Guid("f37ac984-18b0-4afa-804c-e73b27c47f8e") },
                    { new Guid("b57a9d6a-1579-452f-bf38-bd6a9170f8e3"), (short)4, "Course50", new Guid("41098c2a-10e4-419d-bc3f-4a98fdcd9886"), new Guid("a92a7897-7ed2-4983-a5e7-33d72a168392") },
                    { new Guid("e08b4cf5-a37b-486d-8150-6f9f9e310394"), (short)0, "Course190", new Guid("aca00e4f-9891-42ce-b030-bdb460912a86"), new Guid("dc2dccbe-b289-444f-b374-df5eae1ea96a") },
                    { new Guid("0a3b1817-2d58-4539-ad74-7c0b69a5c1e1"), (short)0, "Course188", new Guid("7b249737-e51c-4dec-8cbc-f80df205c401"), new Guid("04b536cf-d059-43f5-a187-012c25285d74") },
                    { new Guid("5ffbecd4-acfb-4650-8404-ac5d115f30c3"), (short)4, "Course235", new Guid("7b249737-e51c-4dec-8cbc-f80df205c401"), new Guid("5166b68f-19c7-4295-8001-acab80e3be59") },
                    { new Guid("e92ca218-caa4-42e2-812a-a1577e70a444"), (short)1, "Course0", new Guid("8241e5a3-9fd4-469c-8a3a-cafc329ef06f"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("9d9af125-ba93-486b-944b-12bb39e764ba"), (short)2, "Course48", new Guid("8241e5a3-9fd4-469c-8a3a-cafc329ef06f"), new Guid("0714acfd-7b85-4714-95a4-2693f68cc7fe") },
                    { new Guid("9a153a41-d798-41e2-97e0-34ceb31bb678"), (short)5, "Course96", new Guid("8241e5a3-9fd4-469c-8a3a-cafc329ef06f"), new Guid("af0231e3-54e5-4f62-a16d-7bcbcc3862b5") },
                    { new Guid("e9bd6569-cb7e-4832-bb61-3f8abde9ab12"), (short)5, "Course144", new Guid("8241e5a3-9fd4-469c-8a3a-cafc329ef06f"), new Guid("e8405a7e-6809-4ac1-951d-03781410be97") },
                    { new Guid("f51798fe-6687-40a1-8a82-092443538b18"), (short)3, "Course192", new Guid("8241e5a3-9fd4-469c-8a3a-cafc329ef06f"), new Guid("f0b375b4-3975-4e1e-9ea4-49b33f1fa3c9") },
                    { new Guid("f6f27e1d-48d9-42f9-8bb9-2181e1367f3b"), (short)4, "Course240", new Guid("8241e5a3-9fd4-469c-8a3a-cafc329ef06f"), new Guid("c69543f7-c451-44af-8136-7600bf55903c") },
                    { new Guid("139e4d0c-9df3-444a-ac7d-5f9ccfeab62b"), (short)4, "Course475", new Guid("aca00e4f-9891-42ce-b030-bdb460912a86"), new Guid("4b3c243d-26a2-430b-a779-cf81b39134eb") },
                    { new Guid("72251457-2318-4607-80ef-9a3db11cee5c"), (short)2, "Course380", new Guid("aca00e4f-9891-42ce-b030-bdb460912a86"), new Guid("2b9f0266-611a-4820-b5c7-8d1bd747f55b") },
                    { new Guid("b1c41c24-4526-451f-a167-8a060b0cadde"), (short)0, "Course0", new Guid("2c461059-c0ce-4014-8cda-322f87492aa6"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("6c045d78-59d0-4b34-bc63-e508c46861e7"), (short)5, "Course49", new Guid("2c461059-c0ce-4014-8cda-322f87492aa6"), new Guid("0be65fce-7327-4fdb-97e8-4638e8061847") },
                    { new Guid("0acfd76e-d45c-469c-87e8-f748e453916e"), (short)3, "Course98", new Guid("2c461059-c0ce-4014-8cda-322f87492aa6"), new Guid("261fa621-17a3-42c6-a69b-f7116739e82b") },
                    { new Guid("9ce836be-b409-41f3-ac2a-c0a6ae60f8ce"), (short)0, "Course147", new Guid("2c461059-c0ce-4014-8cda-322f87492aa6"), new Guid("e05af25e-082a-4b80-a28f-832214ce10bc") },
                    { new Guid("023a0b69-2e18-4106-8765-5a1612c11a7e"), (short)1, "Course196", new Guid("2c461059-c0ce-4014-8cda-322f87492aa6"), new Guid("af0231e3-54e5-4f62-a16d-7bcbcc3862b5") },
                    { new Guid("f79ba8ed-3c68-4ae5-ad8b-db925d4fc474"), (short)0, "Course245", new Guid("2c461059-c0ce-4014-8cda-322f87492aa6"), new Guid("8ec1697b-d4d9-4c6c-8d7e-a7a369a05831") },
                    { new Guid("8ec69f3a-3e2c-4d51-9925-875bc6049501"), (short)0, "Course285", new Guid("aca00e4f-9891-42ce-b030-bdb460912a86"), new Guid("db11804c-38ec-4fc9-8136-dc47b7b789e3") },
                    { new Guid("04175e91-7d7c-4b1c-9b4f-67fcce9d89bc"), (short)1, "Course0", new Guid("41098c2a-10e4-419d-bc3f-4a98fdcd9886"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("68bb7922-07ce-43d5-bb1e-ef4c3d931280"), (short)3, "Course194", new Guid("d6241a14-3a43-4d50-ab66-2684d89fe179"), new Guid("f37ac984-18b0-4afa-804c-e73b27c47f8e") },
                    { new Guid("7e5f915f-1c42-4721-ab8a-8ac5ca4dc07d"), (short)2, "Course0", new Guid("1ec7df37-22d1-4853-9d82-fb38c117840a"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("bf296057-f2dc-45a6-b5f2-6e068f7bf767"), (short)3, "Course128", new Guid("1ec7df37-22d1-4853-9d82-fb38c117840a"), new Guid("fd7aa746-fa3d-4b6c-bfc4-180fa0062035") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("b2c6e4d2-347e-41e5-9e3b-0bf457fb7f2f"), (short)0, "Course156", new Guid("f519c8d3-23c9-4ae8-858f-3c9c51c06b58"), new Guid("ba1fcd39-4e90-42d6-a1f1-d52be00852c8") },
                    { new Guid("c11b3d93-b992-4b2c-9082-c4eb5e77d809"), (short)2, "Course234", new Guid("f519c8d3-23c9-4ae8-858f-3c9c51c06b58"), new Guid("2a4c66f3-e06e-4d40-830b-2aff460b9aef") },
                    { new Guid("930f68aa-8b4b-4181-ae2e-fe575f402bc2"), (short)3, "Course312", new Guid("f519c8d3-23c9-4ae8-858f-3c9c51c06b58"), new Guid("47a375c2-c9b6-4013-8239-e327ab21d4ec") },
                    { new Guid("3bbcb71c-97dd-4fc2-93f0-d38930de4389"), (short)5, "Course390", new Guid("f519c8d3-23c9-4ae8-858f-3c9c51c06b58"), new Guid("dc2dccbe-b289-444f-b374-df5eae1ea96a") },
                    { new Guid("a3d69e67-62e8-46a9-9937-772ed9549216"), (short)2, "Course88", new Guid("bc1fff87-1a12-49cf-88cf-641e2e1a77ae"), new Guid("04b536cf-d059-43f5-a187-012c25285d74") },
                    { new Guid("750ca501-35ba-43c9-af8a-cdadee40002c"), (short)3, "Course0", new Guid("bc1fff87-1a12-49cf-88cf-641e2e1a77ae"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("c38651cd-9aa6-40b6-9415-8a857d7fa7d6"), (short)2, "Course0", new Guid("609e61bd-5d31-48a8-9ed3-fefd675b1a08"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("fef5b10d-e0b9-4b7f-b0f3-6c81a3f134b9"), (short)3, "Course78", new Guid("f519c8d3-23c9-4ae8-858f-3c9c51c06b58"), new Guid("ddd29bd3-3463-4300-aec9-f02ef123b657") },
                    { new Guid("8dc068ff-52bc-4164-82d8-05ab6f2501ea"), (short)4, "Course79", new Guid("609e61bd-5d31-48a8-9ed3-fefd675b1a08"), new Guid("2aeea0c4-8fec-45f9-a6b0-e00afbf6f983") },
                    { new Guid("5584b1cf-3c3f-4103-92c3-ea51a80ce58f"), (short)5, "Course237", new Guid("609e61bd-5d31-48a8-9ed3-fefd675b1a08"), new Guid("6980f4f6-226e-4bbd-b4ed-4125c696f4d0") },
                    { new Guid("41170bb6-9e42-44b0-8c46-ed00d9a8d112"), (short)1, "Course316", new Guid("609e61bd-5d31-48a8-9ed3-fefd675b1a08"), new Guid("1659619d-a195-40f0-9b32-7ae994c4f7c5") },
                    { new Guid("f034d7c3-4d34-4e6e-a47b-28a5400b39ab"), (short)1, "Course395", new Guid("609e61bd-5d31-48a8-9ed3-fefd675b1a08"), new Guid("a49dc22c-16b1-450f-bd05-54627b33a952") },
                    { new Guid("5fbe0c93-c100-4a74-800b-e93306a404f0"), (short)3, "Course0", new Guid("379b9d39-d466-43ac-b988-8c27a2c65f15"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("9d892738-d8a1-492f-9308-f4cbed4e20f3"), (short)1, "Course80", new Guid("379b9d39-d466-43ac-b988-8c27a2c65f15"), new Guid("2b9f0266-611a-4820-b5c7-8d1bd747f55b") },
                    { new Guid("98453230-9b95-4dfb-b16d-d8cfd7b257b5"), (short)4, "Course160", new Guid("379b9d39-d466-43ac-b988-8c27a2c65f15"), new Guid("6b5a6b95-6bd0-4340-babb-e56e9ac0171d") },
                    { new Guid("3c95d150-4cc0-48b6-9a04-65ab473f3155"), (short)2, "Course240", new Guid("379b9d39-d466-43ac-b988-8c27a2c65f15"), new Guid("c69543f7-c451-44af-8136-7600bf55903c") },
                    { new Guid("d424a4a6-1fbe-40df-89a5-b3b0ec22eb1b"), (short)4, "Course158", new Guid("609e61bd-5d31-48a8-9ed3-fefd675b1a08"), new Guid("0eafc5e8-bb25-43ce-aa71-fac4ee547b1c") },
                    { new Guid("a3125f94-ab1d-44a2-9bbf-3d11f917d2a3"), (short)5, "Course0", new Guid("f519c8d3-23c9-4ae8-858f-3c9c51c06b58"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("5eec352a-a177-46c5-893f-ab820a6f092b"), (short)2, "Course176", new Guid("bc1fff87-1a12-49cf-88cf-641e2e1a77ae"), new Guid("921e3f7f-7818-4f66-a546-133a47447022") },
                    { new Guid("deb915d8-1e8f-4941-9782-2ff10c0435af"), (short)5, "Course264", new Guid("bc1fff87-1a12-49cf-88cf-641e2e1a77ae"), new Guid("4ec77cc4-e026-4c2c-ab7a-924771e1fb57") },
                    { new Guid("7a2f8450-72ec-4da2-847f-7185def353c5"), (short)2, "Course225", new Guid("6ed53c09-0724-4630-a692-3d2ee46146b1"), new Guid("384f6076-f8f2-4e95-b51f-f0883a9a5576") },
                    { new Guid("bb8844f7-5f74-4d04-ad0b-64db4ba6127b"), (short)3, "Course300", new Guid("6ed53c09-0724-4630-a692-3d2ee46146b1"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("d39694e5-508c-4a03-a09c-dda1bfdaf717"), (short)4, "Course375", new Guid("6ed53c09-0724-4630-a692-3d2ee46146b1"), new Guid("4b3c243d-26a2-430b-a779-cf81b39134eb") },
                    { new Guid("3979b926-c90a-42ea-a06e-dadb84f263b9"), (short)3, "Course0", new Guid("a034c62b-e1b1-4ee2-8950-92a3de59b61c"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("b29fa4bb-220b-474c-a865-d56a9bfae267"), (short)1, "Course76", new Guid("a034c62b-e1b1-4ee2-8950-92a3de59b61c"), new Guid("921e3f7f-7818-4f66-a546-133a47447022") },
                    { new Guid("7719aad7-a2e9-48aa-b23d-80f70da4084a"), (short)3, "Course152", new Guid("a034c62b-e1b1-4ee2-8950-92a3de59b61c"), new Guid("cd4fcdd9-3743-4d8d-823d-c16e81bf7feb") },
                    { new Guid("9917c313-ecd0-4a76-9d83-e3f93f3cdeae"), (short)1, "Course228", new Guid("a034c62b-e1b1-4ee2-8950-92a3de59b61c"), new Guid("fd7aa746-fa3d-4b6c-bfc4-180fa0062035") },
                    { new Guid("497e2e0c-e4e5-4c68-bd92-3da82510a605"), (short)0, "Course304", new Guid("a034c62b-e1b1-4ee2-8950-92a3de59b61c"), new Guid("e2ba043f-3076-4149-a411-f3ec84d0ac5f") },
                    { new Guid("e9502cfe-5675-413b-85cd-1dc4b0175524"), (short)4, "Course380", new Guid("a034c62b-e1b1-4ee2-8950-92a3de59b61c"), new Guid("2b9f0266-611a-4820-b5c7-8d1bd747f55b") },
                    { new Guid("ecb73f88-e5cf-4625-95d2-cc26fa6b2754"), (short)4, "Course440", new Guid("bc1fff87-1a12-49cf-88cf-641e2e1a77ae"), new Guid("c69543f7-c451-44af-8136-7600bf55903c") },
                    { new Guid("0a818e57-1835-408f-aacb-9c3f3bf30e0e"), (short)2, "Course352", new Guid("bc1fff87-1a12-49cf-88cf-641e2e1a77ae"), new Guid("cd4fcdd9-3743-4d8d-823d-c16e81bf7feb") },
                    { new Guid("d8d63454-b2ec-4e98-b821-6199ae97a832"), (short)2, "Course0", new Guid("fc9fc9eb-7b60-460a-92d3-844feb48ef24"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("a6cfb3d1-b7b8-4293-9ad2-6b1c1e2e9271"), (short)0, "Course77", new Guid("fc9fc9eb-7b60-460a-92d3-844feb48ef24"), new Guid("ef9025e8-8f9b-49e2-862f-d9f742990e86") },
                    { new Guid("63b43c0e-b751-4dd1-8669-37fde7b384f5"), (short)1, "Course154", new Guid("fc9fc9eb-7b60-460a-92d3-844feb48ef24"), new Guid("471b80b9-dd36-4a48-89c2-39b5941f439d") },
                    { new Guid("6f538851-897f-4278-90b5-5a01e1bfeadd"), (short)4, "Course231", new Guid("fc9fc9eb-7b60-460a-92d3-844feb48ef24"), new Guid("53f2f91f-3252-4cab-af3a-aaabf84f4422") },
                    { new Guid("4e7b3485-05ba-4fec-9181-60338ca4941e"), (short)0, "Course308", new Guid("fc9fc9eb-7b60-460a-92d3-844feb48ef24"), new Guid("5b0e27a8-b03b-405e-9d61-be91ffb92942") },
                    { new Guid("4d5041bc-1d98-46dd-a075-d76034cd8034"), (short)3, "Course385", new Guid("fc9fc9eb-7b60-460a-92d3-844feb48ef24"), new Guid("db11804c-38ec-4fc9-8136-dc47b7b789e3") },
                    { new Guid("18e0edde-2cc5-4063-867f-cadc8ed5d631"), (short)1, "Course320", new Guid("379b9d39-d466-43ac-b988-8c27a2c65f15"), new Guid("a5b92ef6-ec55-4ce7-8fbf-2260b49d0ad7") },
                    { new Guid("1994a153-d5f3-42a0-8bc7-8eb9b36193a9"), (short)3, "Course400", new Guid("379b9d39-d466-43ac-b988-8c27a2c65f15"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("e7935253-4a23-4e03-80ed-a7b2cc4536ef"), (short)0, "Course435", new Guid("f1358410-62e4-4bdf-bc20-338a4325b31c"), new Guid("5166b68f-19c7-4295-8001-acab80e3be59") },
                    { new Guid("dd838dfd-6483-4da9-98ab-a713dea50c87"), (short)2, "Course348", new Guid("f1358410-62e4-4bdf-bc20-338a4325b31c"), new Guid("0714acfd-7b85-4714-95a4-2693f68cc7fe") },
                    { new Guid("d9d93ab9-9097-4dd9-ba87-e484c41bc68a"), (short)0, "Course415", new Guid("0c0a35f6-aa29-4fff-bad0-13404b5950d4"), new Guid("b1b3057c-b83e-4a08-bc6a-9360d5af13bd") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("98229c4c-aba1-480d-8cca-3e42f1c10eb4"), (short)3, "Course0", new Guid("52e059ed-0b61-4f02-b827-247ce522fa88"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("0c1510c0-8108-498c-b83e-f7d05a77b432"), (short)4, "Course84", new Guid("52e059ed-0b61-4f02-b827-247ce522fa88"), new Guid("ccb7a87a-5a14-4961-8ca6-8063675b2bce") },
                    { new Guid("0cf2c309-634c-4bfe-8aa1-7df968dc50d3"), (short)4, "Course168", new Guid("52e059ed-0b61-4f02-b827-247ce522fa88"), new Guid("af0a604d-1fc1-4e3f-b242-2acd97d398f3") },
                    { new Guid("9298002c-3d39-4ccd-855e-1cf8be979b50"), (short)0, "Course252", new Guid("52e059ed-0b61-4f02-b827-247ce522fa88"), new Guid("cd4fcdd9-3743-4d8d-823d-c16e81bf7feb") },
                    { new Guid("ffb38837-d710-46b7-a3d5-4b661ddc4640"), (short)2, "Course336", new Guid("52e059ed-0b61-4f02-b827-247ce522fa88"), new Guid("c78d7301-bd14-40e7-b41e-b8ab84ad6c78") },
                    { new Guid("f560b34e-dd65-45d6-b595-1e7158e1b48a"), (short)3, "Course420", new Guid("52e059ed-0b61-4f02-b827-247ce522fa88"), new Guid("a5b92ef6-ec55-4ce7-8fbf-2260b49d0ad7") },
                    { new Guid("680dae39-45dd-471d-b745-3c6db8f22caa"), (short)4, "Course430", new Guid("f08fd625-7ae2-409f-b72a-f2cccf217e07"), new Guid("9d0e4158-3440-4bf7-b67d-078faeeddbcb") },
                    { new Guid("735b69a9-5804-456d-b26e-7d2dd0f7cb62"), (short)4, "Course344", new Guid("f08fd625-7ae2-409f-b72a-f2cccf217e07"), new Guid("e8405a7e-6809-4ac1-951d-03781410be97") },
                    { new Guid("3b107469-d13f-4bbe-8c3c-976ee72b01d1"), (short)2, "Course0", new Guid("56ff758d-1574-4779-821c-df8a31fb9c08"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("50418daf-28f6-4828-b56d-3f574f66f9e2"), (short)5, "Course85", new Guid("56ff758d-1574-4779-821c-df8a31fb9c08"), new Guid("db11804c-38ec-4fc9-8136-dc47b7b789e3") },
                    { new Guid("6f6f5679-d6f5-4019-acd3-037343c27331"), (short)3, "Course170", new Guid("56ff758d-1574-4779-821c-df8a31fb9c08"), new Guid("8ef9a447-3f54-4ebc-854d-d176e74601b4") },
                    { new Guid("5cb730df-ee8c-4632-8256-f8ebee111194"), (short)1, "Course255", new Guid("56ff758d-1574-4779-821c-df8a31fb9c08"), new Guid("42be7409-d3d8-4bfd-880e-2d18372f07d6") },
                    { new Guid("f918fc4e-23ae-4cd8-ba95-8dc4c769482b"), (short)3, "Course340", new Guid("56ff758d-1574-4779-821c-df8a31fb9c08"), new Guid("c69543f7-c451-44af-8136-7600bf55903c") },
                    { new Guid("9df0465d-7311-4cea-9fd7-3c58c2e87693"), (short)5, "Course425", new Guid("56ff758d-1574-4779-821c-df8a31fb9c08"), new Guid("384f6076-f8f2-4e95-b51f-f0883a9a5576") },
                    { new Guid("267206a6-f209-4ef6-842f-9a0fbbcf0623"), (short)3, "Course258", new Guid("f08fd625-7ae2-409f-b72a-f2cccf217e07"), new Guid("0eafc5e8-bb25-43ce-aa71-fac4ee547b1c") },
                    { new Guid("9874628c-9ab9-42ea-a439-9cbbc20fe630"), (short)0, "Course172", new Guid("f08fd625-7ae2-409f-b72a-f2cccf217e07"), new Guid("d889d0ce-23d0-4a95-bd16-51e3a1cf0ce7") },
                    { new Guid("f0860a9b-27b4-405e-b0dd-88c79a3938fc"), (short)4, "Course332", new Guid("0c0a35f6-aa29-4fff-bad0-13404b5950d4"), new Guid("1bf88dee-3b4f-48fd-9679-6c90ced03977") },
                    { new Guid("0cd4b3f4-3d22-4145-ae4b-10a08ca63dd3"), (short)4, "Course150", new Guid("6ed53c09-0724-4630-a692-3d2ee46146b1"), new Guid("a92a7897-7ed2-4983-a5e7-33d72a168392") },
                    { new Guid("071fff7b-bf5b-4c48-80e3-cce37b2eccee"), (short)0, "Course249", new Guid("0c0a35f6-aa29-4fff-bad0-13404b5950d4"), new Guid("0be65fce-7327-4fdb-97e8-4638e8061847") },
                    { new Guid("cfadafaf-e4e0-414c-b47b-e13b10648da8"), (short)4, "Course83", new Guid("0c0a35f6-aa29-4fff-bad0-13404b5950d4"), new Guid("55bcdfb7-5436-425f-aa75-67ed0bec3c6d") },
                    { new Guid("078599bd-b078-416e-a914-5eb745243cbf"), (short)5, "Course0", new Guid("4b5f9de0-1605-42c2-9fe8-afb7b0659bb1"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("ffaaec34-38cd-4b63-ad96-4f6250391a27"), (short)1, "Course81", new Guid("4b5f9de0-1605-42c2-9fe8-afb7b0659bb1"), new Guid("64348b66-65ef-4051-a489-855fe874b9c0") },
                    { new Guid("2a944814-4148-45a1-8623-b61eda0ee1ad"), (short)4, "Course162", new Guid("4b5f9de0-1605-42c2-9fe8-afb7b0659bb1"), new Guid("63d077b3-c8e6-414f-9036-959e8c825846") },
                    { new Guid("dcecfe51-55b0-448e-baed-d974ad4c986a"), (short)3, "Course243", new Guid("4b5f9de0-1605-42c2-9fe8-afb7b0659bb1"), new Guid("b6fa213a-f7e3-453c-8d0c-7f4e3fbda256") },
                    { new Guid("fd49f361-8ceb-459b-885c-8a739981bd83"), (short)4, "Course324", new Guid("4b5f9de0-1605-42c2-9fe8-afb7b0659bb1"), new Guid("1fd187e5-d7c8-42d2-81e4-fe3dde7b0701") },
                    { new Guid("1f0d4a52-5482-43cd-a522-6c75addd790d"), (short)2, "Course405", new Guid("4b5f9de0-1605-42c2-9fe8-afb7b0659bb1"), new Guid("5b5bebc1-9a18-4276-8f59-032c426a7461") },
                    { new Guid("7111c714-ecad-40f0-bf45-03159d49b9ab"), (short)2, "Course261", new Guid("f1358410-62e4-4bdf-bc20-338a4325b31c"), new Guid("015f56f9-e4b3-41dc-adb6-ee2f90ec89cf") },
                    { new Guid("b14ae0a6-1b51-45b5-afc6-b7ed2e5d5bb8"), (short)2, "Course174", new Guid("f1358410-62e4-4bdf-bc20-338a4325b31c"), new Guid("6baee663-1d3a-4058-9a14-b4ed26be7e08") },
                    { new Guid("b5af113c-d182-423b-9f05-b553a19e307e"), (short)2, "Course0", new Guid("27c49487-1120-432b-b3ca-981af980749f"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("4ac500d4-6add-4813-b219-5594731edece"), (short)5, "Course82", new Guid("27c49487-1120-432b-b3ca-981af980749f"), new Guid("50e805fc-950a-4835-b29b-6cee79b22045") },
                    { new Guid("d391ea66-4b35-40a6-8d1d-7129b510e783"), (short)0, "Course164", new Guid("27c49487-1120-432b-b3ca-981af980749f"), new Guid("4ec77cc4-e026-4c2c-ab7a-924771e1fb57") },
                    { new Guid("dde8838f-6da6-4b29-b157-109f7100a998"), (short)0, "Course246", new Guid("27c49487-1120-432b-b3ca-981af980749f"), new Guid("07fe7183-eeba-4290-ad4f-98cacee625ea") },
                    { new Guid("9524c8e7-69fb-419d-bbcd-977005106eb6"), (short)1, "Course328", new Guid("27c49487-1120-432b-b3ca-981af980749f"), new Guid("fd7aa746-fa3d-4b6c-bfc4-180fa0062035") },
                    { new Guid("903387be-044e-4e3b-973e-44e719e8ceed"), (short)1, "Course410", new Guid("27c49487-1120-432b-b3ca-981af980749f"), new Guid("58f484aa-8ab3-44b3-979a-f5c7b99910f6") },
                    { new Guid("4824178b-d402-4a4c-a20a-4ae4e541ea7a"), (short)1, "Course87", new Guid("f1358410-62e4-4bdf-bc20-338a4325b31c"), new Guid("0db6ac70-8dd3-4da1-bcff-27696faa9338") },
                    { new Guid("84eb1e7b-b59c-4cec-9824-8e5f55a0c93b"), (short)5, "Course0", new Guid("f1358410-62e4-4bdf-bc20-338a4325b31c"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("7af7ad84-18a9-4b52-8c1a-d2d43ab20d9c"), (short)1, "Course0", new Guid("0c0a35f6-aa29-4fff-bad0-13404b5950d4"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("1e8c431f-a6b7-4634-bedb-31aa1931fb31"), (short)4, "Course166", new Guid("0c0a35f6-aa29-4fff-bad0-13404b5950d4"), new Guid("fdb2981f-f449-49ef-bc96-5d7152ea43e0") },
                    { new Guid("4f263617-ad5b-4131-9d9c-4dced2d97e48"), (short)0, "Course75", new Guid("6ed53c09-0724-4630-a692-3d2ee46146b1"), new Guid("4b3c243d-26a2-430b-a779-cf81b39134eb") },
                    { new Guid("3e89b16f-0f06-40e8-bed8-12945d36575e"), (short)0, "Course0", new Guid("6ed53c09-0724-4630-a692-3d2ee46146b1"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("856f5dbe-c6b3-4ff3-bb61-b6302968865a"), (short)0, "Course0", new Guid("0c51308b-6441-4f3d-b045-629877d81a46"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("b82c6320-2658-4dd2-850b-06b3627feba5"), (short)2, "Course0", new Guid("6fe7d50f-6e56-4689-8556-63f45d71cca1"), new Guid("d520389d-d791-479c-a509-27d5bb244858") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("6c25fcfd-dd3d-45c4-9989-d527229257a7"), (short)3, "Course67", new Guid("6fe7d50f-6e56-4689-8556-63f45d71cca1"), new Guid("b26cb6d2-a318-447d-a303-57c481a8df2c") },
                    { new Guid("597941e9-1199-490a-9daa-884e66f68a1c"), (short)0, "Course134", new Guid("6fe7d50f-6e56-4689-8556-63f45d71cca1"), new Guid("2a4c66f3-e06e-4d40-830b-2aff460b9aef") },
                    { new Guid("dcfb66e4-52de-4861-911a-5187137d4f9c"), (short)2, "Course201", new Guid("6fe7d50f-6e56-4689-8556-63f45d71cca1"), new Guid("51e9dc92-d8bc-4914-808a-9e4faaf09da6") },
                    { new Guid("622839ea-1851-4bf5-b26c-a9e3c1067e90"), (short)1, "Course268", new Guid("6fe7d50f-6e56-4689-8556-63f45d71cca1"), new Guid("af0a604d-1fc1-4e3f-b242-2acd97d398f3") },
                    { new Guid("925ba40c-35db-4660-96c6-0ca734f69eb6"), (short)1, "Course335", new Guid("6fe7d50f-6e56-4689-8556-63f45d71cca1"), new Guid("5166b68f-19c7-4295-8001-acab80e3be59") },
                    { new Guid("647a4ade-2866-4984-a5c9-1febd53711d0"), (short)5, "Course0", new Guid("036ba574-9c62-495d-b2c2-63c784cf5e02"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("0b0ad637-f8a1-4cb9-a64c-69e2a4d99718"), (short)2, "Course68", new Guid("036ba574-9c62-495d-b2c2-63c784cf5e02"), new Guid("af0a604d-1fc1-4e3f-b242-2acd97d398f3") },
                    { new Guid("9464d70c-e92c-46f1-a07c-c184455fad8c"), (short)4, "Course136", new Guid("036ba574-9c62-495d-b2c2-63c784cf5e02"), new Guid("c78d7301-bd14-40e7-b41e-b8ab84ad6c78") },
                    { new Guid("4c3701e8-a661-4116-9e16-23ba5bfe6c9b"), (short)2, "Course204", new Guid("036ba574-9c62-495d-b2c2-63c784cf5e02"), new Guid("e2ba043f-3076-4149-a411-f3ec84d0ac5f") },
                    { new Guid("c8596cdf-04db-4c5a-a49a-1fd94fc60dab"), (short)1, "Course272", new Guid("036ba574-9c62-495d-b2c2-63c784cf5e02"), new Guid("d889d0ce-23d0-4a95-bd16-51e3a1cf0ce7") },
                    { new Guid("1c6b31e7-b069-4d59-96c5-dd7cde244b46"), (short)4, "Course340", new Guid("036ba574-9c62-495d-b2c2-63c784cf5e02"), new Guid("c69543f7-c451-44af-8136-7600bf55903c") },
                    { new Guid("30a4021e-17e1-4b27-96c5-fb4112e1b8b2"), (short)2, "Course450", new Guid("0253e66e-905c-45b6-a9f6-5845201fdccd"), new Guid("a92a7897-7ed2-4983-a5e7-33d72a168392") },
                    { new Guid("49c3d4e5-ce14-4a63-98a6-822934d9a5af"), (short)2, "Course360", new Guid("0253e66e-905c-45b6-a9f6-5845201fdccd"), new Guid("6b5a6b95-6bd0-4340-babb-e56e9ac0171d") },
                    { new Guid("f10c5104-fae9-4553-9a64-b56b1495b528"), (short)0, "Course0", new Guid("ae0ff115-bac3-489a-855e-21275acbc7b2"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("70b433d2-6c62-4601-a362-443aa5a7f45d"), (short)5, "Course69", new Guid("ae0ff115-bac3-489a-855e-21275acbc7b2"), new Guid("962082e2-14d7-498d-80fb-2427625c671a") },
                    { new Guid("6507a5d4-d579-467d-8684-03b9213dbac1"), (short)1, "Course138", new Guid("ae0ff115-bac3-489a-855e-21275acbc7b2"), new Guid("f60e2337-f07e-45d8-9aa3-5e8314156a8d") },
                    { new Guid("f5c485b3-62c6-4609-8a03-f8a439086037"), (short)0, "Course0", new Guid("3eab4340-3570-46fd-9bb7-fdaec0973133"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("767471f9-3ba6-40eb-aa0e-569d3ac73304"), (short)3, "Course207", new Guid("ae0ff115-bac3-489a-855e-21275acbc7b2"), new Guid("6276add9-6269-4d1e-a285-a51ada727742") },
                    { new Guid("74621e4a-5318-4f0c-a214-e55a75c5421a"), (short)5, "Course91", new Guid("3eab4340-3570-46fd-9bb7-fdaec0973133"), new Guid("6e99f39c-e2fa-42f8-be2f-7d704a299585") },
                    { new Guid("52e98f15-6d76-4982-babb-ef9e7acaf41e"), (short)1, "Course264", new Guid("25a05858-b0df-48b4-a719-2a20c674de64"), new Guid("4ec77cc4-e026-4c2c-ab7a-924771e1fb57") },
                    { new Guid("d1fca32a-fd6b-4dc6-85bc-540716adf12d"), (short)3, "Course192", new Guid("1ec7df37-22d1-4853-9d82-fb38c117840a"), new Guid("f0b375b4-3975-4e1e-9ea4-49b33f1fa3c9") },
                    { new Guid("8baa45c2-6ed3-460e-ac9f-0871467fe7f0"), (short)1, "Course256", new Guid("1ec7df37-22d1-4853-9d82-fb38c117840a"), new Guid("ba1fcd39-4e90-42d6-a1f1-d52be00852c8") },
                    { new Guid("8b06b245-8871-48bf-b266-e9cf0da1057b"), (short)5, "Course320", new Guid("1ec7df37-22d1-4853-9d82-fb38c117840a"), new Guid("a5b92ef6-ec55-4ce7-8fbf-2260b49d0ad7") },
                    { new Guid("33d17f72-d83c-485e-8846-106f3634e43f"), (short)2, "Course455", new Guid("3eab4340-3570-46fd-9bb7-fdaec0973133"), new Guid("42be7409-d3d8-4bfd-880e-2d18372f07d6") },
                    { new Guid("6bbe86af-969e-4935-9f81-c5e8febc3a68"), (short)0, "Course364", new Guid("3eab4340-3570-46fd-9bb7-fdaec0973133"), new Guid("4ec77cc4-e026-4c2c-ab7a-924771e1fb57") },
                    { new Guid("c761f421-c213-4196-9c1a-096315b9805d"), (short)2, "Course0", new Guid("3f7c878b-3e55-43a6-97dd-5707171e320c"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("2be3ecfc-3f24-4128-b80b-7a8af7f7ac27"), (short)1, "Course65", new Guid("3f7c878b-3e55-43a6-97dd-5707171e320c"), new Guid("be501952-af82-4aa8-813c-ebe8bb64cd67") },
                    { new Guid("e84db76b-7203-4969-b546-3b12772ce911"), (short)4, "Course130", new Guid("3f7c878b-3e55-43a6-97dd-5707171e320c"), new Guid("9d0e4158-3440-4bf7-b67d-078faeeddbcb") },
                    { new Guid("2a0ca0a9-10b5-4e75-9906-d62ce0a82a58"), (short)0, "Course195", new Guid("3f7c878b-3e55-43a6-97dd-5707171e320c"), new Guid("a49dc22c-16b1-450f-bd05-54627b33a952") },
                    { new Guid("c2d05434-4209-45f7-a38d-e726402d8582"), (short)5, "Course260", new Guid("3f7c878b-3e55-43a6-97dd-5707171e320c"), new Guid("6b5a6b95-6bd0-4340-babb-e56e9ac0171d") },
                    { new Guid("302c9704-f9c6-4616-9288-bc0493396ba5"), (short)0, "Course325", new Guid("3f7c878b-3e55-43a6-97dd-5707171e320c"), new Guid("384f6076-f8f2-4e95-b51f-f0883a9a5576") },
                    { new Guid("0ec1f656-c1b5-40d5-bbea-c5b183f44cbf"), (short)0, "Course273", new Guid("3eab4340-3570-46fd-9bb7-fdaec0973133"), new Guid("b8280292-5d91-45f6-9e15-c45f342b22b9") },
                    { new Guid("e050406f-3944-4541-a5a2-9bd2c541f79e"), (short)1, "Course182", new Guid("3eab4340-3570-46fd-9bb7-fdaec0973133"), new Guid("50e805fc-950a-4835-b29b-6cee79b22045") },
                    { new Guid("d82acacb-dcec-4b60-b615-4f36a4350601"), (short)2, "Course0", new Guid("25a05858-b0df-48b4-a719-2a20c674de64"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("1f77dd05-53fb-44cd-85d4-426d4fc1bfd1"), (short)5, "Course66", new Guid("25a05858-b0df-48b4-a719-2a20c674de64"), new Guid("fdb2981f-f449-49ef-bc96-5d7152ea43e0") },
                    { new Guid("ebd18feb-39e3-4855-930b-ae1eaa239322"), (short)5, "Course132", new Guid("25a05858-b0df-48b4-a719-2a20c674de64"), new Guid("1bf88dee-3b4f-48fd-9679-6c90ced03977") },
                    { new Guid("5c2e57c7-1bff-4725-8244-de22545a2014"), (short)3, "Course198", new Guid("25a05858-b0df-48b4-a719-2a20c674de64"), new Guid("261fa621-17a3-42c6-a69b-f7116739e82b") },
                    { new Guid("c9dd8714-b77f-438e-8d6e-21ab82c3d364"), (short)3, "Course330", new Guid("25a05858-b0df-48b4-a719-2a20c674de64"), new Guid("9d0e4158-3440-4bf7-b67d-078faeeddbcb") },
                    { new Guid("24f6fad8-8597-4183-bc0e-b28020e902a0"), (short)1, "Course64", new Guid("1ec7df37-22d1-4853-9d82-fb38c117840a"), new Guid("4ec77cc4-e026-4c2c-ab7a-924771e1fb57") },
                    { new Guid("c752255c-ae94-4039-be22-151441a772a3"), (short)3, "Course276", new Guid("ae0ff115-bac3-489a-855e-21275acbc7b2"), new Guid("921e3f7f-7818-4f66-a546-133a47447022") },
                    { new Guid("6cab65d9-0ce4-4854-8c52-d79764471216"), (short)2, "Course270", new Guid("0253e66e-905c-45b6-a9f6-5845201fdccd"), new Guid("8ef9a447-3f54-4ebc-854d-d176e74601b4") },
                    { new Guid("71ad9974-7a10-429d-b2bc-ad828948421d"), (short)5, "Course445", new Guid("0c51308b-6441-4f3d-b045-629877d81a46"), new Guid("8ec1697b-d4d9-4c6c-8d7e-a7a369a05831") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("0c1141d9-f09b-462e-9ee6-e3289e5ad138"), (short)3, "Course356", new Guid("0c51308b-6441-4f3d-b045-629877d81a46"), new Guid("ba1fcd39-4e90-42d6-a1f1-d52be00852c8") },
                    { new Guid("2424d66c-68e1-4e79-8f27-cc9ade742d74"), (short)2, "Course0", new Guid("3d631240-7dd1-400f-b4a2-b15b0f338da6"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("8c1b40c7-f107-4ba8-8d7d-800602db77bf"), (short)1, "Course73", new Guid("3d631240-7dd1-400f-b4a2-b15b0f338da6"), new Guid("b8280292-5d91-45f6-9e15-c45f342b22b9") },
                    { new Guid("4b9231d4-69dd-4274-8f61-8a7521d02676"), (short)1, "Course146", new Guid("3d631240-7dd1-400f-b4a2-b15b0f338da6"), new Guid("07fe7183-eeba-4290-ad4f-98cacee625ea") },
                    { new Guid("1dd10bb7-0b0c-4e98-9a3b-3c8bbef0761e"), (short)5, "Course219", new Guid("3d631240-7dd1-400f-b4a2-b15b0f338da6"), new Guid("0ca079c5-33ca-4528-a75a-d9207ff75e6c") },
                    { new Guid("cd3107f0-9d78-4077-a7ff-51e4c1ef9a0f"), (short)5, "Course292", new Guid("3d631240-7dd1-400f-b4a2-b15b0f338da6"), new Guid("f0b375b4-3975-4e1e-9ea4-49b33f1fa3c9") },
                    { new Guid("05735d08-0e42-4795-bd92-39601560ba41"), (short)5, "Course365", new Guid("3d631240-7dd1-400f-b4a2-b15b0f338da6"), new Guid("be501952-af82-4aa8-813c-ebe8bb64cd67") },
                    { new Guid("d18672ea-4792-4fa6-871c-9531cc363802"), (short)0, "Course267", new Guid("0c51308b-6441-4f3d-b045-629877d81a46"), new Guid("b26cb6d2-a318-447d-a303-57c481a8df2c") },
                    { new Guid("c0a84efb-63aa-4760-8ff6-05402e4ea5b1"), (short)5, "Course178", new Guid("0c51308b-6441-4f3d-b045-629877d81a46"), new Guid("ddd29bd3-3463-4300-aec9-f02ef123b657") },
                    { new Guid("70d36de6-3fae-4870-8938-54e2ba33ce65"), (short)5, "Course0", new Guid("02023a19-1a5c-422a-97b1-e37c596b2a1e"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("d1515929-2c2a-479e-a362-99bbe1cfb697"), (short)0, "Course74", new Guid("02023a19-1a5c-422a-97b1-e37c596b2a1e"), new Guid("6baee663-1d3a-4058-9a14-b4ed26be7e08") },
                    { new Guid("26989b2e-539f-4201-b5f1-a61bac7b2975"), (short)4, "Course148", new Guid("02023a19-1a5c-422a-97b1-e37c596b2a1e"), new Guid("0714acfd-7b85-4714-95a4-2693f68cc7fe") },
                    { new Guid("d41e073a-0e98-4ce5-b2ca-fbd960827d48"), (short)1, "Course222", new Guid("02023a19-1a5c-422a-97b1-e37c596b2a1e"), new Guid("f271e53b-f316-4f3c-9aca-8469584bb14a") },
                    { new Guid("a84d2576-5ae3-4c0c-ad68-cab695ad010b"), (short)1, "Course296", new Guid("02023a19-1a5c-422a-97b1-e37c596b2a1e"), new Guid("af0231e3-54e5-4f62-a16d-7bcbcc3862b5") },
                    { new Guid("28237164-a4b3-49ad-b283-e8c6e19c2fb7"), (short)4, "Course370", new Guid("02023a19-1a5c-422a-97b1-e37c596b2a1e"), new Guid("8ef9a447-3f54-4ebc-854d-d176e74601b4") },
                    { new Guid("eedad298-7f57-433b-a158-bd84d00f13c0"), (short)0, "Course89", new Guid("0c51308b-6441-4f3d-b045-629877d81a46"), new Guid("320b7836-0470-4b4a-8ee5-5146e0766166") },
                    { new Guid("e05b5cd7-8dc8-4379-a94d-1f4d04353501"), (short)1, "Course360", new Guid("f8104e82-2073-497c-a097-cdf5a46d801c"), new Guid("6b5a6b95-6bd0-4340-babb-e56e9ac0171d") },
                    { new Guid("ff9da90c-779b-4a1d-8f75-9d3ddeaae63d"), (short)3, "Course345", new Guid("ae0ff115-bac3-489a-855e-21275acbc7b2"), new Guid("8ec1697b-d4d9-4c6c-8d7e-a7a369a05831") },
                    { new Guid("d06897bb-40df-493b-b7d4-29fb10726582"), (short)5, "Course288", new Guid("f8104e82-2073-497c-a097-cdf5a46d801c"), new Guid("04b536cf-d059-43f5-a187-012c25285d74") },
                    { new Guid("af216556-1312-4d8c-b96f-3fe334e2ba66"), (short)3, "Course144", new Guid("f8104e82-2073-497c-a097-cdf5a46d801c"), new Guid("e8405a7e-6809-4ac1-951d-03781410be97") },
                    { new Guid("011a7b94-3f11-4004-a9dd-23a479b77ea8"), (short)2, "Course180", new Guid("0253e66e-905c-45b6-a9f6-5845201fdccd"), new Guid("2b9f0266-611a-4820-b5c7-8d1bd747f55b") },
                    { new Guid("f1df0d53-e26e-49ef-b7a6-fa0b896272d0"), (short)2, "Course0", new Guid("51f3469a-c46d-4f80-9b57-bd07ae06c11b"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("00cc2b94-3d83-4694-b28c-7ed1bc5ef87c"), (short)1, "Course70", new Guid("51f3469a-c46d-4f80-9b57-bd07ae06c11b"), new Guid("8ef9a447-3f54-4ebc-854d-d176e74601b4") },
                    { new Guid("c8b56d06-a8de-4fc4-ab25-bae3a44387aa"), (short)5, "Course140", new Guid("51f3469a-c46d-4f80-9b57-bd07ae06c11b"), new Guid("c69543f7-c451-44af-8136-7600bf55903c") },
                    { new Guid("b1011531-0907-4a4e-90f1-99cdb27c94d7"), (short)5, "Course210", new Guid("51f3469a-c46d-4f80-9b57-bd07ae06c11b"), new Guid("58f484aa-8ab3-44b3-979a-f5c7b99910f6") },
                    { new Guid("1354e9d3-a5b5-4166-8d8e-6c8865972323"), (short)1, "Course280", new Guid("51f3469a-c46d-4f80-9b57-bd07ae06c11b"), new Guid("2b9f0266-611a-4820-b5c7-8d1bd747f55b") },
                    { new Guid("4700eddf-2925-4314-a827-69bbc6a61965"), (short)4, "Course350", new Guid("51f3469a-c46d-4f80-9b57-bd07ae06c11b"), new Guid("a92a7897-7ed2-4983-a5e7-33d72a168392") },
                    { new Guid("6ed2a149-1a80-48f8-b803-c6d61b3b0979"), (short)3, "Course90", new Guid("0253e66e-905c-45b6-a9f6-5845201fdccd"), new Guid("dc2dccbe-b289-444f-b374-df5eae1ea96a") },
                    { new Guid("b0b67a6b-bdc4-4254-bef5-2b86e5b01fe3"), (short)1, "Course0", new Guid("0253e66e-905c-45b6-a9f6-5845201fdccd"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("c9032bc3-2961-4715-a724-30ebfd7cf542"), (short)1, "Course0", new Guid("172ca027-bcce-40dc-94c5-e2c2f419fe61"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("b8fa2e9c-a648-4ee8-95d8-e737b1abc596"), (short)2, "Course71", new Guid("172ca027-bcce-40dc-94c5-e2c2f419fe61"), new Guid("92bf0ac3-63b0-4789-811f-24ef059c3653") },
                    { new Guid("dd8817fe-6306-4be7-83fa-55fe337df204"), (short)5, "Course142", new Guid("172ca027-bcce-40dc-94c5-e2c2f419fe61"), new Guid("b589b9ab-99a7-42e6-ada6-d1d692d94214") },
                    { new Guid("24a31380-4044-4d66-abb4-2424a8f38859"), (short)5, "Course213", new Guid("172ca027-bcce-40dc-94c5-e2c2f419fe61"), new Guid("4d6becdd-d8c4-409d-905b-e152c03679f2") },
                    { new Guid("d81df557-0420-4bec-908d-94cf3a43f29a"), (short)1, "Course284", new Guid("172ca027-bcce-40dc-94c5-e2c2f419fe61"), new Guid("ccb7a87a-5a14-4961-8ca6-8063675b2bce") },
                    { new Guid("c16e2a2d-38d5-48b9-84ed-b8bddf9157a3"), (short)3, "Course355", new Guid("172ca027-bcce-40dc-94c5-e2c2f419fe61"), new Guid("42be7409-d3d8-4bfd-880e-2d18372f07d6") },
                    { new Guid("517f350b-178f-4e34-b216-4f014c43fd4a"), (short)5, "Course0", new Guid("f8104e82-2073-497c-a097-cdf5a46d801c"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("2c1ad336-b59c-4ae0-9c31-20f3a6ddbf3e"), (short)4, "Course72", new Guid("f8104e82-2073-497c-a097-cdf5a46d801c"), new Guid("d889d0ce-23d0-4a95-bd16-51e3a1cf0ce7") },
                    { new Guid("a99ce375-0117-4186-97ca-db0776281839"), (short)0, "Course216", new Guid("f8104e82-2073-497c-a097-cdf5a46d801c"), new Guid("1659619d-a195-40f0-9b32-7ae994c4f7c5") },
                    { new Guid("03532a1e-5b00-475c-bf25-442927b0dbb7"), (short)4, "Course291", new Guid("d6241a14-3a43-4d50-ab66-2684d89fe179"), new Guid("6e99f39c-e2fa-42f8-be2f-7d704a299585") },
                    { new Guid("26442ee8-f6be-4efb-b295-1b2d210e977a"), (short)2, "Course0", new Guid("d996b970-5404-4738-a074-8687d8aa9912"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("669a59c7-4627-4782-b044-c04d4a8ea1ca"), (short)3, "Course164", new Guid("dedc1654-4d0a-43ed-a38d-143ea2a7b31c"), new Guid("4ec77cc4-e026-4c2c-ab7a-924771e1fb57") },
                    { new Guid("85429e1c-41b3-4358-aeac-b3360d53f420"), (short)1, "Course0", new Guid("ae0d9476-94fc-45af-8017-d93e8b1368d5"), new Guid("d520389d-d791-479c-a509-27d5bb244858") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("1ff859c2-7512-4161-88ad-199dc17b8995"), (short)2, "Course14", new Guid("ae0d9476-94fc-45af-8017-d93e8b1368d5"), new Guid("c6c1ba00-b0aa-47df-88f4-33af23ac06cb") },
                    { new Guid("a02c7f6b-f46f-42f6-8218-cdffcb97bc2d"), (short)2, "Course28", new Guid("ae0d9476-94fc-45af-8017-d93e8b1368d5"), new Guid("fd7aa746-fa3d-4b6c-bfc4-180fa0062035") },
                    { new Guid("91b829c3-fb22-4945-8104-033c7889a74a"), (short)0, "Course42", new Guid("ae0d9476-94fc-45af-8017-d93e8b1368d5"), new Guid("b589b9ab-99a7-42e6-ada6-d1d692d94214") },
                    { new Guid("c310ff60-9aa5-436c-8f6d-024e483ad812"), (short)3, "Course56", new Guid("ae0d9476-94fc-45af-8017-d93e8b1368d5"), new Guid("ba1fcd39-4e90-42d6-a1f1-d52be00852c8") },
                    { new Guid("fb7cf8ac-bb44-44e7-8bb1-ab8fd20b19c7"), (short)3, "Course70", new Guid("ae0d9476-94fc-45af-8017-d93e8b1368d5"), new Guid("8ef9a447-3f54-4ebc-854d-d176e74601b4") },
                    { new Guid("4f038e08-6557-4a50-aa8d-9b593cc2c386"), (short)0, "Course104", new Guid("d3269155-a2c0-49b7-89e5-93b14b670d85"), new Guid("e2ba043f-3076-4149-a411-f3ec84d0ac5f") },
                    { new Guid("57112f71-aba9-4c26-b494-ed3ea5e58020"), (short)3, "Course0", new Guid("d3269155-a2c0-49b7-89e5-93b14b670d85"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("5b022871-07db-4351-832c-c8189108a7da"), (short)4, "Course0", new Guid("c9099a6b-63bf-4cac-9c6b-79375bbe3abb"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("365f84e6-9262-43e4-b8a7-38d2531f79b3"), (short)2, "Course15", new Guid("c9099a6b-63bf-4cac-9c6b-79375bbe3abb"), new Guid("b1b3057c-b83e-4a08-bc6a-9360d5af13bd") },
                    { new Guid("73894451-3373-4450-9b4d-a9351cb1c721"), (short)5, "Course30", new Guid("c9099a6b-63bf-4cac-9c6b-79375bbe3abb"), new Guid("9d0e4158-3440-4bf7-b67d-078faeeddbcb") },
                    { new Guid("043367c3-d87d-4740-b0aa-5224c84c0d88"), (short)2, "Course45", new Guid("c9099a6b-63bf-4cac-9c6b-79375bbe3abb"), new Guid("8ec1697b-d4d9-4c6c-8d7e-a7a369a05831") },
                    { new Guid("dd21e305-b9da-41ad-8ee1-d04ba6cb6d70"), (short)5, "Course60", new Guid("c9099a6b-63bf-4cac-9c6b-79375bbe3abb"), new Guid("6b5a6b95-6bd0-4340-babb-e56e9ac0171d") },
                    { new Guid("4f136d6a-eba0-47b9-9ba5-871672f39b01"), (short)1, "Course75", new Guid("c9099a6b-63bf-4cac-9c6b-79375bbe3abb"), new Guid("4b3c243d-26a2-430b-a779-cf81b39134eb") },
                    { new Guid("1a779596-3901-4200-9a6a-bb8969780080"), (short)2, "Course0", new Guid("6537ebae-4f75-4743-8fbc-71d75ad6c0f4"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("ff8c7d38-a00f-413c-be43-c05744c9af42"), (short)4, "Course16", new Guid("6537ebae-4f75-4743-8fbc-71d75ad6c0f4"), new Guid("1659619d-a195-40f0-9b32-7ae994c4f7c5") },
                    { new Guid("1d387c8a-200b-40ba-bd7c-c8ffe4d692e9"), (short)4, "Course32", new Guid("6537ebae-4f75-4743-8fbc-71d75ad6c0f4"), new Guid("1bf88dee-3b4f-48fd-9679-6c90ced03977") },
                    { new Guid("60070494-6865-4156-abd0-1dbfb800388e"), (short)4, "Course208", new Guid("d3269155-a2c0-49b7-89e5-93b14b670d85"), new Guid("5b0e27a8-b03b-405e-9d61-be91ffb92942") },
                    { new Guid("dbade529-f894-4c2c-bd48-99904096140b"), (short)5, "Course48", new Guid("6537ebae-4f75-4743-8fbc-71d75ad6c0f4"), new Guid("0714acfd-7b85-4714-95a4-2693f68cc7fe") },
                    { new Guid("4fbc845e-7f52-48e8-ab7b-e986ace870bd"), (short)2, "Course312", new Guid("d3269155-a2c0-49b7-89e5-93b14b670d85"), new Guid("47a375c2-c9b6-4013-8239-e327ab21d4ec") },
                    { new Guid("b4f0416e-6b12-4e75-822e-7790fbce77d2"), (short)2, "Course52", new Guid("6adb62da-3b01-4757-b260-ddd2cf1d57de"), new Guid("cd4fcdd9-3743-4d8d-823d-c16e81bf7feb") },
                    { new Guid("964fb0b6-48e3-4fb0-9aa8-e4601f02fb64"), (short)0, "Course11", new Guid("feb2ea5d-268a-4665-bacd-4db6939390a6"), new Guid("0f54ee42-1e4a-403c-89a7-9ed72d8f6725") },
                    { new Guid("c1809617-eee9-4d09-a112-29c63c68a555"), (short)5, "Course22", new Guid("feb2ea5d-268a-4665-bacd-4db6939390a6"), new Guid("f271e53b-f316-4f3c-9aca-8469584bb14a") },
                    { new Guid("01f3ccf8-f1d1-4560-8ff1-7ad0b5e4b9db"), (short)5, "Course33", new Guid("feb2ea5d-268a-4665-bacd-4db6939390a6"), new Guid("e13a6b5d-7312-488e-9cea-5f449d9b6ed5") },
                    { new Guid("74735ed4-3bfa-40c3-a0e4-0eefdaefc94b"), (short)0, "Course44", new Guid("feb2ea5d-268a-4665-bacd-4db6939390a6"), new Guid("e8405a7e-6809-4ac1-951d-03781410be97") },
                    { new Guid("93d8e9eb-c858-4d02-9dc8-c698186af4d7"), (short)3, "Course55", new Guid("feb2ea5d-268a-4665-bacd-4db6939390a6"), new Guid("42be7409-d3d8-4bfd-880e-2d18372f07d6") },
                    { new Guid("c4106aa3-ee32-4e2c-94cf-c4d06454f6b2"), (short)4, "Course0", new Guid("45377600-9ee2-44cc-8217-60ae287409f2"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("550c2194-35c3-4b5c-9138-45d8eb0bb664"), (short)5, "Course12", new Guid("45377600-9ee2-44cc-8217-60ae287409f2"), new Guid("47a375c2-c9b6-4013-8239-e327ab21d4ec") },
                    { new Guid("1f28ebe4-c5e5-4b79-9109-6892dfc893e2"), (short)5, "Course24", new Guid("45377600-9ee2-44cc-8217-60ae287409f2"), new Guid("1fd187e5-d7c8-42d2-81e4-fe3dde7b0701") },
                    { new Guid("bca65d3c-c1b3-499a-bba8-0d23898e0e76"), (short)2, "Course36", new Guid("45377600-9ee2-44cc-8217-60ae287409f2"), new Guid("c78d7301-bd14-40e7-b41e-b8ab84ad6c78") },
                    { new Guid("66be96ba-108c-48e1-a3a0-43f7e39fadc2"), (short)5, "Course48", new Guid("45377600-9ee2-44cc-8217-60ae287409f2"), new Guid("0714acfd-7b85-4714-95a4-2693f68cc7fe") },
                    { new Guid("c21452fc-19fd-4a48-869a-e43dfa2766be"), (short)5, "Course60", new Guid("45377600-9ee2-44cc-8217-60ae287409f2"), new Guid("6b5a6b95-6bd0-4340-babb-e56e9ac0171d") },
                    { new Guid("f72b164c-3e31-4bbc-9d35-5061e110b20d"), (short)0, "Course520", new Guid("d3269155-a2c0-49b7-89e5-93b14b670d85"), new Guid("a5b92ef6-ec55-4ce7-8fbf-2260b49d0ad7") },
                    { new Guid("dda5ad16-4b91-496e-abd4-91cdfb0f48a4"), (short)3, "Course416", new Guid("d3269155-a2c0-49b7-89e5-93b14b670d85"), new Guid("1659619d-a195-40f0-9b32-7ae994c4f7c5") },
                    { new Guid("4279b063-6c9d-4ded-bf63-6fb34061389e"), (short)1, "Course0", new Guid("6adb62da-3b01-4757-b260-ddd2cf1d57de"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("209bf03a-881c-4af9-8fb9-71fc0eb8e99c"), (short)4, "Course13", new Guid("6adb62da-3b01-4757-b260-ddd2cf1d57de"), new Guid("4d6becdd-d8c4-409d-905b-e152c03679f2") },
                    { new Guid("e45b2a67-3ac9-4261-819f-1aaf2b206347"), (short)3, "Course26", new Guid("6adb62da-3b01-4757-b260-ddd2cf1d57de"), new Guid("9bcbddf1-7697-462d-a409-ac2b527d26b9") },
                    { new Guid("ee6b1f5b-bdb0-4f56-8522-3f34d94ce4c5"), (short)4, "Course39", new Guid("6adb62da-3b01-4757-b260-ddd2cf1d57de"), new Guid("84ea72b7-9dc5-4c45-a282-0d138774b216") },
                    { new Guid("173060a7-3c8c-4362-80c5-182eeb91350c"), (short)1, "Course65", new Guid("6adb62da-3b01-4757-b260-ddd2cf1d57de"), new Guid("be501952-af82-4aa8-813c-ebe8bb64cd67") },
                    { new Guid("a8b57484-d6cb-4294-b63c-d71e233e4603"), (short)2, "Course0", new Guid("feb2ea5d-268a-4665-bacd-4db6939390a6"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("6d0e55d8-ca22-4f9a-861d-967497427ea7"), (short)5, "Course64", new Guid("6537ebae-4f75-4743-8fbc-71d75ad6c0f4"), new Guid("4ec77cc4-e026-4c2c-ab7a-924771e1fb57") },
                    { new Guid("67118017-d505-457e-8219-b97c11524acf"), (short)0, "Course515", new Guid("70d68c6a-b23d-4cf8-998c-9033d2bb756d"), new Guid("b1b3057c-b83e-4a08-bc6a-9360d5af13bd") },
                    { new Guid("7ea9d2cd-0fc9-4750-9d3a-9c087769b115"), (short)4, "Course76", new Guid("a34783f0-cd79-4260-82c6-79b4dbfcd112"), new Guid("921e3f7f-7818-4f66-a546-133a47447022") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("b80040fa-da02-4606-ac16-c6bb32ac394d"), (short)2, "Course95", new Guid("a34783f0-cd79-4260-82c6-79b4dbfcd112"), new Guid("a49dc22c-16b1-450f-bd05-54627b33a952") },
                    { new Guid("4b9f8b76-30e1-45ef-95bb-cd86a392e85c"), (short)2, "Course0", new Guid("103abef8-fca5-4a1e-9b82-498ec853c71e"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("9863c8dc-577e-4492-a8df-0312de5fcb40"), (short)4, "Course20", new Guid("103abef8-fca5-4a1e-9b82-498ec853c71e"), new Guid("a5b92ef6-ec55-4ce7-8fbf-2260b49d0ad7") },
                    { new Guid("b4dc9cc7-9f0d-4f22-8fba-cb1c89195514"), (short)1, "Course40", new Guid("103abef8-fca5-4a1e-9b82-498ec853c71e"), new Guid("c69543f7-c451-44af-8136-7600bf55903c") },
                    { new Guid("29df3103-3725-44a8-981a-b82d563a92b5"), (short)0, "Course60", new Guid("103abef8-fca5-4a1e-9b82-498ec853c71e"), new Guid("6b5a6b95-6bd0-4340-babb-e56e9ac0171d") },
                    { new Guid("17a2473f-ed5d-4aa0-ae65-07102ed771a6"), (short)5, "Course80", new Guid("103abef8-fca5-4a1e-9b82-498ec853c71e"), new Guid("2b9f0266-611a-4820-b5c7-8d1bd747f55b") },
                    { new Guid("122ea5e4-fb47-4216-b14e-7d9da7bd2809"), (short)2, "Course100", new Guid("103abef8-fca5-4a1e-9b82-498ec853c71e"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("1190f84a-e240-4266-adc3-95f980eedbb4"), (short)5, "Course510", new Guid("9b4275d6-7484-48d9-a3d0-325ab5123f4d"), new Guid("58f484aa-8ab3-44b3-979a-f5c7b99910f6") },
                    { new Guid("4e53262a-beeb-4144-9a6d-ce09560af8a2"), (short)4, "Course205", new Guid("dedc1654-4d0a-43ed-a38d-143ea2a7b31c"), new Guid("5b5bebc1-9a18-4276-8f59-032c426a7461") },
                    { new Guid("3ddc54dc-5617-4dc0-b3a0-6d64a25135b5"), (short)0, "Course408", new Guid("9b4275d6-7484-48d9-a3d0-325ab5123f4d"), new Guid("5b0e27a8-b03b-405e-9d61-be91ffb92942") },
                    { new Guid("170028a0-2df8-4427-bd49-f96cbe2db258"), (short)3, "Course0", new Guid("b6d6e9f6-b969-4f1f-811b-b04a5da43f45"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("6c70aba6-0abe-4618-8f5a-0e64af359986"), (short)0, "Course21", new Guid("b6d6e9f6-b969-4f1f-811b-b04a5da43f45"), new Guid("5599f6d0-3655-4d17-8ea1-096103c7b1a7") },
                    { new Guid("c994ecf5-42cb-4d89-8332-581af2c6bbba"), (short)0, "Course42", new Guid("b6d6e9f6-b969-4f1f-811b-b04a5da43f45"), new Guid("b589b9ab-99a7-42e6-ada6-d1d692d94214") },
                    { new Guid("e7f90cf7-9309-443f-a6be-8631c984d6ad"), (short)4, "Course63", new Guid("b6d6e9f6-b969-4f1f-811b-b04a5da43f45"), new Guid("63af8a63-3d9f-4a25-8e2c-db885be41b6e") },
                    { new Guid("06fa3803-5d80-4e61-8875-eb7a47705769"), (short)2, "Course84", new Guid("b6d6e9f6-b969-4f1f-811b-b04a5da43f45"), new Guid("ccb7a87a-5a14-4961-8ca6-8063675b2bce") },
                    { new Guid("bb097aff-4bce-48a5-a166-cd82cda9dbe9"), (short)5, "Course105", new Guid("b6d6e9f6-b969-4f1f-811b-b04a5da43f45"), new Guid("5b5bebc1-9a18-4276-8f59-032c426a7461") },
                    { new Guid("8eb14f75-02cd-4872-ba8d-564bc916c1c3"), (short)0, "Course57", new Guid("a34783f0-cd79-4260-82c6-79b4dbfcd112"), new Guid("8762d3cf-d975-4550-b61c-1b891a10d890") },
                    { new Guid("52b5d875-0d7d-4501-9ec0-096d97ba17cf"), (short)0, "Course80", new Guid("6537ebae-4f75-4743-8fbc-71d75ad6c0f4"), new Guid("2b9f0266-611a-4820-b5c7-8d1bd747f55b") },
                    { new Guid("84845cb4-1af1-4f6c-a4a2-6b23db1cefc8"), (short)2, "Course38", new Guid("a34783f0-cd79-4260-82c6-79b4dbfcd112"), new Guid("f60e2337-f07e-45d8-9aa3-5e8314156a8d") },
                    { new Guid("7e01b589-e678-48db-9f8b-1489290aa745"), (short)4, "Course0", new Guid("a34783f0-cd79-4260-82c6-79b4dbfcd112"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("5ab38318-82af-47fa-84bb-e30f6f7e2646"), (short)2, "Course412", new Guid("70d68c6a-b23d-4cf8-998c-9033d2bb756d"), new Guid("47a375c2-c9b6-4013-8239-e327ab21d4ec") },
                    { new Guid("d3657a9f-c570-41e8-b3a7-ddfdcbed81a6"), (short)4, "Course0", new Guid("f522dc14-2a27-408b-a3b7-37ab0f14492b"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("99ce6f0b-750c-4e94-8803-4785a1200fe7"), (short)0, "Course17", new Guid("f522dc14-2a27-408b-a3b7-37ab0f14492b"), new Guid("2373980d-fec4-403e-82d4-ec6a5bcd66f5") },
                    { new Guid("b6d4bb62-119f-4422-b929-8249fc157833"), (short)4, "Course34", new Guid("f522dc14-2a27-408b-a3b7-37ab0f14492b"), new Guid("2a4c66f3-e06e-4d40-830b-2aff460b9aef") },
                    { new Guid("86643ecd-0523-4def-922c-ad6379af8837"), (short)2, "Course51", new Guid("f522dc14-2a27-408b-a3b7-37ab0f14492b"), new Guid("91ed7051-9e55-4279-96b3-f8be2e6efe11") },
                    { new Guid("e75b2a1e-e7ee-4be0-99b0-05a8b9e6ec16"), (short)5, "Course68", new Guid("f522dc14-2a27-408b-a3b7-37ab0f14492b"), new Guid("af0a604d-1fc1-4e3f-b242-2acd97d398f3") },
                    { new Guid("a4efc6dd-07e3-4482-8c7c-0de2f2f2dc73"), (short)2, "Course85", new Guid("f522dc14-2a27-408b-a3b7-37ab0f14492b"), new Guid("db11804c-38ec-4fc9-8136-dc47b7b789e3") },
                    { new Guid("428b44bf-7575-4903-b173-3147b4342897"), (short)3, "Course309", new Guid("70d68c6a-b23d-4cf8-998c-9033d2bb756d"), new Guid("56f39da2-627a-4954-8db5-d1b440669300") },
                    { new Guid("28af707f-c321-4c88-be16-69af9438e64e"), (short)2, "Course206", new Guid("70d68c6a-b23d-4cf8-998c-9033d2bb756d"), new Guid("a37d6845-9076-475c-9302-4ca8b1f09f0f") },
                    { new Guid("002d4352-d3cb-496a-b6d4-46ccebbe1069"), (short)3, "Course0", new Guid("256a5b40-8012-4db3-b00c-10fd242f92cb"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("06555ca4-a430-48e9-8a35-d5dd6f8fb6ab"), (short)1, "Course18", new Guid("256a5b40-8012-4db3-b00c-10fd242f92cb"), new Guid("6489c875-e57b-49e3-b8db-13d8166de086") },
                    { new Guid("d7740398-1cb1-4027-ae74-d9c64c24ed34"), (short)4, "Course36", new Guid("256a5b40-8012-4db3-b00c-10fd242f92cb"), new Guid("c78d7301-bd14-40e7-b41e-b8ab84ad6c78") },
                    { new Guid("87d7d8df-d98e-41f8-98ba-92bda74000e4"), (short)3, "Course54", new Guid("256a5b40-8012-4db3-b00c-10fd242f92cb"), new Guid("471b80b9-dd36-4a48-89c2-39b5941f439d") },
                    { new Guid("99e270e3-c123-4686-8680-42b06c3143ae"), (short)2, "Course72", new Guid("256a5b40-8012-4db3-b00c-10fd242f92cb"), new Guid("d889d0ce-23d0-4a95-bd16-51e3a1cf0ce7") },
                    { new Guid("0b929151-5e25-4bc2-a99c-9a93b9b1e629"), (short)3, "Course90", new Guid("256a5b40-8012-4db3-b00c-10fd242f92cb"), new Guid("dc2dccbe-b289-444f-b374-df5eae1ea96a") },
                    { new Guid("acfd6532-9918-4ac4-9447-d725b532e33e"), (short)4, "Course103", new Guid("70d68c6a-b23d-4cf8-998c-9033d2bb756d"), new Guid("3e2c035a-3595-4ba5-a65c-d7e11fd02240") },
                    { new Guid("69222ed3-aa10-4723-98d1-96ceb90d55c9"), (short)3, "Course0", new Guid("70d68c6a-b23d-4cf8-998c-9033d2bb756d"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("45bfb32d-b756-4bb1-a312-b0015ccbeddc"), (short)5, "Course19", new Guid("a34783f0-cd79-4260-82c6-79b4dbfcd112"), new Guid("0ca079c5-33ca-4528-a75a-d9207ff75e6c") },
                    { new Guid("7023d566-d931-4c72-a904-2996cd8b1363"), (short)0, "Course306", new Guid("9b4275d6-7484-48d9-a3d0-325ab5123f4d"), new Guid("a37d6845-9076-475c-9302-4ca8b1f09f0f") },
                    { new Guid("8dd7eb16-3e2c-4d75-ae4a-dea7d5d64d35"), (short)3, "Course0", new Guid("8952f512-fe84-4820-b001-3b5c49c34a27"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("4c777673-2ca0-48d9-800f-630c77d4627c"), (short)0, "Course50", new Guid("2af25551-4fd6-47f5-a00f-23916f40c162"), new Guid("a92a7897-7ed2-4983-a5e7-33d72a168392") },
                    { new Guid("8b13aa59-2125-4a11-84c2-b591e3ea9899"), (short)0, "Course107", new Guid("22dba56e-6888-463d-9228-fab9730af92f"), new Guid("6276add9-6269-4d1e-a285-a51ada727742") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("04c07496-8b0b-4c11-8aa8-299bdc180dd3"), (short)4, "Course0", new Guid("22dba56e-6888-463d-9228-fab9730af92f"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("ca6320a2-0704-4c4e-a060-f81f4bd69435"), (short)4, "Course0", new Guid("c7955d67-ea7a-4095-9efc-23006bcb41fd"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("d1f8b212-661b-4504-877a-0a2b2a522d8e"), (short)1, "Course3", new Guid("c7955d67-ea7a-4095-9efc-23006bcb41fd"), new Guid("3e2c035a-3595-4ba5-a65c-d7e11fd02240") },
                    { new Guid("41b6bbb9-d8e7-4340-bb24-a60d389ce30b"), (short)3, "Course6", new Guid("c7955d67-ea7a-4095-9efc-23006bcb41fd"), new Guid("a37d6845-9076-475c-9302-4ca8b1f09f0f") },
                    { new Guid("ab7f2042-91a1-4eb7-acba-8b5a52af881d"), (short)5, "Course9", new Guid("c7955d67-ea7a-4095-9efc-23006bcb41fd"), new Guid("56f39da2-627a-4954-8db5-d1b440669300") },
                    { new Guid("b31beb9f-5070-4da6-b6d9-bcfb25736c02"), (short)4, "Course12", new Guid("c7955d67-ea7a-4095-9efc-23006bcb41fd"), new Guid("47a375c2-c9b6-4013-8239-e327ab21d4ec") },
                    { new Guid("d48ea909-7f47-4698-8254-477cb390338d"), (short)1, "Course15", new Guid("c7955d67-ea7a-4095-9efc-23006bcb41fd"), new Guid("b1b3057c-b83e-4a08-bc6a-9360d5af13bd") },
                    { new Guid("dcba670a-cb2f-420e-a638-fcd48e2e2023"), (short)5, "Course0", new Guid("11efde67-a191-45ea-a2be-bd903fcbb462"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("db204a41-ea25-4f9d-b9c9-cea12c4a092f"), (short)4, "Course4", new Guid("11efde67-a191-45ea-a2be-bd903fcbb462"), new Guid("e2ba043f-3076-4149-a411-f3ec84d0ac5f") },
                    { new Guid("ed10782e-10e5-4872-a749-d7705aa4fe76"), (short)1, "Course8", new Guid("11efde67-a191-45ea-a2be-bd903fcbb462"), new Guid("5b0e27a8-b03b-405e-9d61-be91ffb92942") },
                    { new Guid("f8361e0a-d4cf-4c80-a439-841417fd7616"), (short)1, "Course12", new Guid("11efde67-a191-45ea-a2be-bd903fcbb462"), new Guid("47a375c2-c9b6-4013-8239-e327ab21d4ec") },
                    { new Guid("7be7de27-dd7a-45f6-a9f2-ad1c955fdc13"), (short)3, "Course16", new Guid("11efde67-a191-45ea-a2be-bd903fcbb462"), new Guid("1659619d-a195-40f0-9b32-7ae994c4f7c5") },
                    { new Guid("076e33c1-d308-414e-999d-fc4d4e02d185"), (short)0, "Course20", new Guid("11efde67-a191-45ea-a2be-bd903fcbb462"), new Guid("a5b92ef6-ec55-4ce7-8fbf-2260b49d0ad7") },
                    { new Guid("6995d3c6-998e-49a3-ad6e-cd04719c17e1"), (short)4, "Course530", new Guid("963cf773-7521-432e-9982-1e2949e7027b"), new Guid("9d0e4158-3440-4bf7-b67d-078faeeddbcb") },
                    { new Guid("a54909d7-17bb-4001-ab34-074ba6c61955"), (short)4, "Course424", new Guid("963cf773-7521-432e-9982-1e2949e7027b"), new Guid("1fd187e5-d7c8-42d2-81e4-fe3dde7b0701") },
                    { new Guid("f64d766c-08cb-4d48-bffc-c47270f562b6"), (short)2, "Course0", new Guid("023c8ee5-7bf3-4a2e-96ce-2448392692a4"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("83315c46-3552-4201-af3f-d3b00cc179fb"), (short)4, "Course10", new Guid("270d93d2-2d14-4f27-bfb5-62541c50fe99"), new Guid("58f484aa-8ab3-44b3-979a-f5c7b99910f6") },
                    { new Guid("8f440e57-0273-4ee2-b752-a535550a3e00"), (short)5, "Course5", new Guid("023c8ee5-7bf3-4a2e-96ce-2448392692a4"), new Guid("5b5bebc1-9a18-4276-8f59-032c426a7461") },
                    { new Guid("58c42734-633f-49b2-877f-8def8e76b203"), (short)5, "Course8", new Guid("270d93d2-2d14-4f27-bfb5-62541c50fe99"), new Guid("5b0e27a8-b03b-405e-9d61-be91ffb92942") },
                    { new Guid("30a826e8-69c5-4f0a-ad18-1b07ed1430c9"), (short)0, "Course4", new Guid("270d93d2-2d14-4f27-bfb5-62541c50fe99"), new Guid("e2ba043f-3076-4149-a411-f3ec84d0ac5f") },
                    { new Guid("aba2b145-17d7-41dc-b337-d6d7852ba08c"), (short)5, "Course0", new Guid("2c032d08-736e-42ea-bd92-327472a78910"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("dd5a35f8-94e5-422d-92cf-85fdeaa8cd52"), (short)5, "Course0", new Guid("2c032d08-736e-42ea-bd92-327472a78910"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("7f980b4a-6a9e-40eb-9501-78f4e55ef849"), (short)5, "Course0", new Guid("2c032d08-736e-42ea-bd92-327472a78910"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("c87c9570-3da0-4cb0-9d23-451902dfc023"), (short)0, "Course0", new Guid("2c032d08-736e-42ea-bd92-327472a78910"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("3265d25b-b98f-4f02-bebf-c4ee853604ff"), (short)1, "Course0", new Guid("2c032d08-736e-42ea-bd92-327472a78910"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("4b49402e-5ca4-43fc-b9e8-cc4022257222"), (short)3, "Course535", new Guid("22dba56e-6888-463d-9228-fab9730af92f"), new Guid("5166b68f-19c7-4295-8001-acab80e3be59") },
                    { new Guid("43958334-480b-4354-bdac-50515cde3f70"), (short)4, "Course428", new Guid("22dba56e-6888-463d-9228-fab9730af92f"), new Guid("fd7aa746-fa3d-4b6c-bfc4-180fa0062035") },
                    { new Guid("4787cbe6-08aa-4866-9b6d-9027a4ec13b6"), (short)0, "Course0", new Guid("a5810ef7-fa39-4a3d-92a5-cc0236bbc26c"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("a56eb231-8694-43bc-b476-e0a7763f7cea"), (short)5, "Course1", new Guid("a5810ef7-fa39-4a3d-92a5-cc0236bbc26c"), new Guid("51e9dc92-d8bc-4914-808a-9e4faaf09da6") },
                    { new Guid("7508975d-efb3-4905-ae40-246bd0c3f035"), (short)0, "Course2", new Guid("a5810ef7-fa39-4a3d-92a5-cc0236bbc26c"), new Guid("ea8f4004-e239-4fe6-aebe-f954474d000f") },
                    { new Guid("c9c9ac3b-e999-4363-84e3-5214fb7ada34"), (short)2, "Course3", new Guid("a5810ef7-fa39-4a3d-92a5-cc0236bbc26c"), new Guid("3e2c035a-3595-4ba5-a65c-d7e11fd02240") },
                    { new Guid("d6b26c57-379b-4509-9010-cd1da4d32f55"), (short)5, "Course4", new Guid("a5810ef7-fa39-4a3d-92a5-cc0236bbc26c"), new Guid("e2ba043f-3076-4149-a411-f3ec84d0ac5f") },
                    { new Guid("b7a42ed3-3be2-449d-9f33-fc825025c87a"), (short)0, "Course5", new Guid("a5810ef7-fa39-4a3d-92a5-cc0236bbc26c"), new Guid("5b5bebc1-9a18-4276-8f59-032c426a7461") },
                    { new Guid("c40f7303-1a5b-4d15-b264-388befcf261f"), (short)4, "Course321", new Guid("22dba56e-6888-463d-9228-fab9730af92f"), new Guid("5599f6d0-3655-4d17-8ea1-096103c7b1a7") },
                    { new Guid("e02d77e5-78bd-4d2f-9a60-a47a3b257251"), (short)4, "Course214", new Guid("22dba56e-6888-463d-9228-fab9730af92f"), new Guid("c6c1ba00-b0aa-47df-88f4-33af23ac06cb") },
                    { new Guid("73b0fc53-3e95-4733-aa59-06818799af41"), (short)3, "Course0", new Guid("270d93d2-2d14-4f27-bfb5-62541c50fe99"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("f21aff41-fa83-4438-afc1-57410496e699"), (short)5, "Course2", new Guid("270d93d2-2d14-4f27-bfb5-62541c50fe99"), new Guid("ea8f4004-e239-4fe6-aebe-f954474d000f") },
                    { new Guid("520b5539-32ed-4873-895f-8145e82f8768"), (short)4, "Course6", new Guid("270d93d2-2d14-4f27-bfb5-62541c50fe99"), new Guid("a37d6845-9076-475c-9302-4ca8b1f09f0f") },
                    { new Guid("95b24a68-08bf-40b4-bbcc-61a88fd691d2"), (short)1, "Course105", new Guid("8952f512-fe84-4820-b001-3b5c49c34a27"), new Guid("5b5bebc1-9a18-4276-8f59-032c426a7461") },
                    { new Guid("6ad02056-add5-46b5-b9ca-97e83d93092f"), (short)0, "Course10", new Guid("023c8ee5-7bf3-4a2e-96ce-2448392692a4"), new Guid("58f484aa-8ab3-44b3-979a-f5c7b99910f6") },
                    { new Guid("138c5ecf-e09f-4405-818a-ab40a89dc091"), (short)1, "Course20", new Guid("023c8ee5-7bf3-4a2e-96ce-2448392692a4"), new Guid("a5b92ef6-ec55-4ce7-8fbf-2260b49d0ad7") },
                    { new Guid("d1775a0c-fe47-4807-b7c4-36638156bfdc"), (short)4, "Course32", new Guid("66efa1f8-c9ae-499f-b2da-58fb59772dd9"), new Guid("1bf88dee-3b4f-48fd-9679-6c90ced03977") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("6f49cd53-e814-4768-b1b1-bbe4bb199457"), (short)3, "Course40", new Guid("66efa1f8-c9ae-499f-b2da-58fb59772dd9"), new Guid("c69543f7-c451-44af-8136-7600bf55903c") },
                    { new Guid("0d91857a-b47d-4eb0-9fbb-7a31bdb96a71"), (short)0, "Course525", new Guid("8952f512-fe84-4820-b001-3b5c49c34a27"), new Guid("384f6076-f8f2-4e95-b51f-f0883a9a5576") },
                    { new Guid("0f714ec4-3e32-4e08-8c02-ba8119f36ee2"), (short)2, "Course420", new Guid("8952f512-fe84-4820-b001-3b5c49c34a27"), new Guid("a5b92ef6-ec55-4ce7-8fbf-2260b49d0ad7") },
                    { new Guid("fe33ad57-cd34-49db-9feb-c6258b2b982f"), (short)0, "Course0", new Guid("b60fa263-44f4-46b3-a494-ae3252ac925e"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("ac5c835b-ae08-4ca2-bd27-3297b86655cb"), (short)2, "Course9", new Guid("b60fa263-44f4-46b3-a494-ae3252ac925e"), new Guid("56f39da2-627a-4954-8db5-d1b440669300") },
                    { new Guid("5ddd7f99-9883-4ddb-bd83-d13b6f09a728"), (short)3, "Course18", new Guid("b60fa263-44f4-46b3-a494-ae3252ac925e"), new Guid("6489c875-e57b-49e3-b8db-13d8166de086") },
                    { new Guid("a9cc07fd-c375-41e5-8c82-8d0fc7cc63be"), (short)5, "Course27", new Guid("b60fa263-44f4-46b3-a494-ae3252ac925e"), new Guid("0e9cfc47-3a8c-481d-ab60-4cbcc7d579e4") },
                    { new Guid("420b6559-6802-4317-9d8d-e8416e5995c5"), (short)2, "Course36", new Guid("b60fa263-44f4-46b3-a494-ae3252ac925e"), new Guid("c78d7301-bd14-40e7-b41e-b8ab84ad6c78") },
                    { new Guid("e35ee43f-9f8e-4afa-b0c2-f59a3bd40fa5"), (short)1, "Course45", new Guid("b60fa263-44f4-46b3-a494-ae3252ac925e"), new Guid("8ec1697b-d4d9-4c6c-8d7e-a7a369a05831") },
                    { new Guid("b63dac18-1508-416a-baa0-993729de3040"), (short)4, "Course315", new Guid("8952f512-fe84-4820-b001-3b5c49c34a27"), new Guid("b1b3057c-b83e-4a08-bc6a-9360d5af13bd") },
                    { new Guid("a380a05a-784f-4af0-9f0d-e51fbb9e302b"), (short)2, "Course210", new Guid("8952f512-fe84-4820-b001-3b5c49c34a27"), new Guid("58f484aa-8ab3-44b3-979a-f5c7b99910f6") },
                    { new Guid("c9e069e9-1c0b-4434-ba14-09c3b9e158c2"), (short)5, "Course0", new Guid("2af25551-4fd6-47f5-a00f-23916f40c162"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("090cbb6d-4410-43f1-88d0-dbed7ce75371"), (short)2, "Course10", new Guid("2af25551-4fd6-47f5-a00f-23916f40c162"), new Guid("58f484aa-8ab3-44b3-979a-f5c7b99910f6") },
                    { new Guid("23a5df25-2d16-456c-b8c5-c702bb017f5d"), (short)5, "Course20", new Guid("2af25551-4fd6-47f5-a00f-23916f40c162"), new Guid("a5b92ef6-ec55-4ce7-8fbf-2260b49d0ad7") },
                    { new Guid("84522022-7828-4e12-83d3-05419319713d"), (short)3, "Course30", new Guid("2af25551-4fd6-47f5-a00f-23916f40c162"), new Guid("9d0e4158-3440-4bf7-b67d-078faeeddbcb") },
                    { new Guid("23393068-33ed-4b85-817a-94b5382599fd"), (short)3, "Course40", new Guid("2af25551-4fd6-47f5-a00f-23916f40c162"), new Guid("c69543f7-c451-44af-8136-7600bf55903c") },
                    { new Guid("a09976ef-e36c-4bba-b633-956243a4c8ba"), (short)4, "Course24", new Guid("66efa1f8-c9ae-499f-b2da-58fb59772dd9"), new Guid("1fd187e5-d7c8-42d2-81e4-fe3dde7b0701") },
                    { new Guid("f9641fd2-43ac-48f0-9a98-bc3d0655e8fa"), (short)1, "Course15", new Guid("023c8ee5-7bf3-4a2e-96ce-2448392692a4"), new Guid("b1b3057c-b83e-4a08-bc6a-9360d5af13bd") },
                    { new Guid("537257fb-2e55-4137-95d1-82822fa5e849"), (short)1, "Course16", new Guid("66efa1f8-c9ae-499f-b2da-58fb59772dd9"), new Guid("1659619d-a195-40f0-9b32-7ae994c4f7c5") },
                    { new Guid("21359ee6-c3ff-460d-9c24-86f98a555fa3"), (short)4, "Course0", new Guid("66efa1f8-c9ae-499f-b2da-58fb59772dd9"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("c25e4674-54c2-48ad-b3d4-733237f118f1"), (short)4, "Course25", new Guid("023c8ee5-7bf3-4a2e-96ce-2448392692a4"), new Guid("384f6076-f8f2-4e95-b51f-f0883a9a5576") },
                    { new Guid("25e10eac-99ad-4de5-a11a-4de26b6faabb"), (short)2, "Course318", new Guid("963cf773-7521-432e-9982-1e2949e7027b"), new Guid("6489c875-e57b-49e3-b8db-13d8166de086") },
                    { new Guid("63537ede-c880-46a9-a05b-f02b05b440c3"), (short)5, "Course212", new Guid("963cf773-7521-432e-9982-1e2949e7027b"), new Guid("47a375c2-c9b6-4013-8239-e327ab21d4ec") },
                    { new Guid("8c57281f-f7a0-47f8-9bc4-d31eb8a56a87"), (short)1, "Course0", new Guid("5f22df2e-ee85-4783-93f0-79eecd95ba4e"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("1e4bafef-3838-459d-8071-7c905ab3bd1e"), (short)1, "Course6", new Guid("5f22df2e-ee85-4783-93f0-79eecd95ba4e"), new Guid("a37d6845-9076-475c-9302-4ca8b1f09f0f") },
                    { new Guid("7bfc1ba9-7538-474d-92d0-1d6f691f83cc"), (short)4, "Course12", new Guid("5f22df2e-ee85-4783-93f0-79eecd95ba4e"), new Guid("47a375c2-c9b6-4013-8239-e327ab21d4ec") },
                    { new Guid("df139c49-55d9-4747-9068-55140c786573"), (short)1, "Course18", new Guid("5f22df2e-ee85-4783-93f0-79eecd95ba4e"), new Guid("6489c875-e57b-49e3-b8db-13d8166de086") },
                    { new Guid("5fb6b314-376e-43ed-a1bd-aa75297d8547"), (short)1, "Course24", new Guid("5f22df2e-ee85-4783-93f0-79eecd95ba4e"), new Guid("1fd187e5-d7c8-42d2-81e4-fe3dde7b0701") },
                    { new Guid("0ab227b5-5bd1-4368-a747-b3c769e9ed6d"), (short)5, "Course30", new Guid("5f22df2e-ee85-4783-93f0-79eecd95ba4e"), new Guid("9d0e4158-3440-4bf7-b67d-078faeeddbcb") },
                    { new Guid("396e54ff-bbb0-4819-9e21-8d1da775bdb1"), (short)5, "Course106", new Guid("963cf773-7521-432e-9982-1e2949e7027b"), new Guid("a37d6845-9076-475c-9302-4ca8b1f09f0f") },
                    { new Guid("9db023e7-a8cf-4101-af2d-65d8c86796fa"), (short)2, "Course0", new Guid("963cf773-7521-432e-9982-1e2949e7027b"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("71caf51c-6f03-472c-8a16-76c3493a34ef"), (short)3, "Course0", new Guid("0678b7cb-fd34-400c-8663-889e8330ec64"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("d503a812-9200-496d-8b4b-1b505e4320b2"), (short)0, "Course7", new Guid("0678b7cb-fd34-400c-8663-889e8330ec64"), new Guid("6276add9-6269-4d1e-a285-a51ada727742") },
                    { new Guid("68420f91-ffcb-4b23-8679-17518ba27e06"), (short)1, "Course14", new Guid("0678b7cb-fd34-400c-8663-889e8330ec64"), new Guid("c6c1ba00-b0aa-47df-88f4-33af23ac06cb") },
                    { new Guid("da1e9716-e38a-436f-b4f7-5c5fa4dd7765"), (short)3, "Course21", new Guid("0678b7cb-fd34-400c-8663-889e8330ec64"), new Guid("5599f6d0-3655-4d17-8ea1-096103c7b1a7") },
                    { new Guid("aacd5c75-ec5f-46bb-be83-58d1fd0e2f6d"), (short)4, "Course28", new Guid("0678b7cb-fd34-400c-8663-889e8330ec64"), new Guid("fd7aa746-fa3d-4b6c-bfc4-180fa0062035") },
                    { new Guid("296d57fb-1a6e-4029-a667-17e0889d7ffa"), (short)2, "Course35", new Guid("0678b7cb-fd34-400c-8663-889e8330ec64"), new Guid("5166b68f-19c7-4295-8001-acab80e3be59") },
                    { new Guid("01805b87-e386-4ec8-8157-2d07cbc1379d"), (short)5, "Course8", new Guid("66efa1f8-c9ae-499f-b2da-58fb59772dd9"), new Guid("5b0e27a8-b03b-405e-9d61-be91ffb92942") },
                    { new Guid("21a4c5ef-9dd0-4c89-a58c-399626698db7"), (short)3, "Course204", new Guid("9b4275d6-7484-48d9-a3d0-325ab5123f4d"), new Guid("e2ba043f-3076-4149-a411-f3ec84d0ac5f") },
                    { new Guid("885bc2be-13bc-488b-9af0-98a9d5577b31"), (short)1, "Course86", new Guid("f08fd625-7ae2-409f-b72a-f2cccf217e07"), new Guid("56dd0284-ef65-45c8-9633-7ece06a318f0") },
                    { new Guid("b56ee3f7-9fb5-41e8-a491-28fdc745c327"), (short)2, "Course22", new Guid("5f765137-96f3-4988-9ff4-e3f35a729b00"), new Guid("f271e53b-f316-4f3c-9aca-8469584bb14a") },
                    { new Guid("1e2c5c43-f3e3-4370-b3a1-a83d499ece9a"), (short)5, "Course64", new Guid("befde88f-9a14-4e2f-a0fe-07e28bf31301"), new Guid("4ec77cc4-e026-4c2c-ab7a-924771e1fb57") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("70ec4f99-fb1e-4c08-a44d-f5869650064b"), (short)2, "Course96", new Guid("befde88f-9a14-4e2f-a0fe-07e28bf31301"), new Guid("af0231e3-54e5-4f62-a16d-7bcbcc3862b5") },
                    { new Guid("13cde076-c714-4fe3-bae0-7e643f57b989"), (short)2, "Course128", new Guid("befde88f-9a14-4e2f-a0fe-07e28bf31301"), new Guid("fd7aa746-fa3d-4b6c-bfc4-180fa0062035") },
                    { new Guid("51691377-1e07-4fdf-aeb5-79ea7d4dd62b"), (short)3, "Course160", new Guid("befde88f-9a14-4e2f-a0fe-07e28bf31301"), new Guid("6b5a6b95-6bd0-4340-babb-e56e9ac0171d") },
                    { new Guid("12865d7e-13d7-4a90-809e-4a0dbd7f63b1"), (short)3, "Course495", new Guid("2dc17cb0-6837-492e-9a6b-1c6a3809bd66"), new Guid("a49dc22c-16b1-450f-bd05-54627b33a952") },
                    { new Guid("4ff506f2-547f-4f94-b3d9-0285339580c4"), (short)0, "Course396", new Guid("2dc17cb0-6837-492e-9a6b-1c6a3809bd66"), new Guid("af0231e3-54e5-4f62-a16d-7bcbcc3862b5") },
                    { new Guid("c7740a10-db99-4c9d-93d2-6fe5423c1562"), (short)4, "Course32", new Guid("befde88f-9a14-4e2f-a0fe-07e28bf31301"), new Guid("1bf88dee-3b4f-48fd-9679-6c90ced03977") },
                    { new Guid("fb1fec8b-4c3c-4dde-a786-7ce4447b6819"), (short)2, "Course39", new Guid("d836d27d-e6d5-407f-813f-a9ff0fed87cc"), new Guid("84ea72b7-9dc5-4c45-a282-0d138774b216") },
                    { new Guid("23494678-493e-4f8c-ac77-69237b745591"), (short)3, "Course0", new Guid("a03cb3ef-9bd7-4513-a995-4e46f5f6dd3b"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("da3892ef-0b88-4725-b1ae-93297ddab6c3"), (short)0, "Course33", new Guid("a03cb3ef-9bd7-4513-a995-4e46f5f6dd3b"), new Guid("e13a6b5d-7312-488e-9cea-5f449d9b6ed5") },
                    { new Guid("4aac41de-da10-4fc0-8a34-25dc63670ad0"), (short)2, "Course66", new Guid("a03cb3ef-9bd7-4513-a995-4e46f5f6dd3b"), new Guid("fdb2981f-f449-49ef-bc96-5d7152ea43e0") },
                    { new Guid("d79d508b-f7b2-4062-8141-8441a2b4732d"), (short)0, "Course99", new Guid("a03cb3ef-9bd7-4513-a995-4e46f5f6dd3b"), new Guid("c00c03a3-29fa-42e0-a672-a5722b674330") },
                    { new Guid("83945ce0-7a43-4835-9637-b857db052464"), (short)3, "Course132", new Guid("a03cb3ef-9bd7-4513-a995-4e46f5f6dd3b"), new Guid("1bf88dee-3b4f-48fd-9679-6c90ced03977") },
                    { new Guid("005db020-c24c-4162-aae0-eed0138768f1"), (short)0, "Course165", new Guid("a03cb3ef-9bd7-4513-a995-4e46f5f6dd3b"), new Guid("be501952-af82-4aa8-813c-ebe8bb64cd67") },
                    { new Guid("607cdf2e-054a-46cb-b50a-2b76066636a5"), (short)3, "Course0", new Guid("d836d27d-e6d5-407f-813f-a9ff0fed87cc"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("505e06b6-2cca-4b22-98ee-0d999805c042"), (short)1, "Course78", new Guid("d836d27d-e6d5-407f-813f-a9ff0fed87cc"), new Guid("ddd29bd3-3463-4300-aec9-f02ef123b657") },
                    { new Guid("365e78ae-b3a5-4f2c-aa4e-ecde9a831942"), (short)0, "Course117", new Guid("d836d27d-e6d5-407f-813f-a9ff0fed87cc"), new Guid("2373980d-fec4-403e-82d4-ec6a5bcd66f5") },
                    { new Guid("36c4a39b-0c96-4f7b-af70-02351f477c4d"), (short)2, "Course0", new Guid("befde88f-9a14-4e2f-a0fe-07e28bf31301"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("4d6602be-4ba4-40d8-a57c-2477c3316120"), (short)2, "Course30", new Guid("8f52bd94-9958-4f72-8fa0-3cb1ec30b731"), new Guid("9d0e4158-3440-4bf7-b67d-078faeeddbcb") },
                    { new Guid("81ef8ca5-a967-4d88-82aa-d016d013e4db"), (short)1, "Course60", new Guid("8f52bd94-9958-4f72-8fa0-3cb1ec30b731"), new Guid("6b5a6b95-6bd0-4340-babb-e56e9ac0171d") },
                    { new Guid("c77145cf-d9af-4a36-af22-69edf6a826fb"), (short)0, "Course90", new Guid("8f52bd94-9958-4f72-8fa0-3cb1ec30b731"), new Guid("dc2dccbe-b289-444f-b374-df5eae1ea96a") },
                    { new Guid("a9a9f872-2648-4600-a625-d325f89f21db"), (short)2, "Course120", new Guid("8f52bd94-9958-4f72-8fa0-3cb1ec30b731"), new Guid("a5b92ef6-ec55-4ce7-8fbf-2260b49d0ad7") },
                    { new Guid("fd7d493a-1053-449b-9e68-e4822b50441f"), (short)2, "Course150", new Guid("8f52bd94-9958-4f72-8fa0-3cb1ec30b731"), new Guid("a92a7897-7ed2-4983-a5e7-33d72a168392") },
                    { new Guid("b45ffc8b-febb-4208-8f03-0e5d5798d355"), (short)0, "Course100", new Guid("e0ad951f-546b-4de2-8d93-b34c9be25957"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("f0a02555-267f-4d14-9fc9-b344441b7ca3"), (short)5, "Course0", new Guid("e0ad951f-546b-4de2-8d93-b34c9be25957"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("b22e6881-40a6-4407-ba68-e0662ea55c2e"), (short)5, "Course0", new Guid("04f6c475-8b10-4380-8777-0a2ca3806508"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("a3086452-a51d-4611-915c-17b4cb2c3eee"), (short)5, "Course31", new Guid("04f6c475-8b10-4380-8777-0a2ca3806508"), new Guid("53f2f91f-3252-4cab-af3a-aaabf84f4422") },
                    { new Guid("6d242c2e-6055-4402-ba2b-9f1973c9e941"), (short)4, "Course62", new Guid("04f6c475-8b10-4380-8777-0a2ca3806508"), new Guid("63d077b3-c8e6-414f-9036-959e8c825846") },
                    { new Guid("6caf4227-31cf-4120-bf51-4f146f40c1b6"), (short)5, "Course93", new Guid("04f6c475-8b10-4380-8777-0a2ca3806508"), new Guid("6354b09f-7243-4fb7-9695-f70ccf026e24") },
                    { new Guid("d084a33a-5a3c-4c7f-af5c-0e279f36d4e4"), (short)0, "Course124", new Guid("04f6c475-8b10-4380-8777-0a2ca3806508"), new Guid("1fd187e5-d7c8-42d2-81e4-fe3dde7b0701") },
                    { new Guid("65189cc4-6029-4c6e-aefc-01861e09f92b"), (short)2, "Course155", new Guid("04f6c475-8b10-4380-8777-0a2ca3806508"), new Guid("42be7409-d3d8-4bfd-880e-2d18372f07d6") },
                    { new Guid("5706a302-21bf-442c-a19f-185052d137eb"), (short)0, "Course156", new Guid("d836d27d-e6d5-407f-813f-a9ff0fed87cc"), new Guid("ba1fcd39-4e90-42d6-a1f1-d52be00852c8") },
                    { new Guid("d34c82ad-bb9d-4e4d-9812-97bb5c77fa60"), (short)3, "Course0", new Guid("5f765137-96f3-4988-9ff4-e3f35a729b00"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("75dbfaec-4cc4-446a-9100-e794d51bddfb"), (short)1, "Course297", new Guid("2dc17cb0-6837-492e-9a6b-1c6a3809bd66"), new Guid("923257c6-f46b-4250-8337-b6ac1f4357ca") },
                    { new Guid("fa3de19f-4008-4f3a-9dfb-550239bc32a5"), (short)1, "Course198", new Guid("2dc17cb0-6837-492e-9a6b-1c6a3809bd66"), new Guid("261fa621-17a3-42c6-a69b-f7116739e82b") },
                    { new Guid("6ea1db72-b97a-4d53-a339-45a8d4ee5200"), (short)4, "Course0", new Guid("f63c3e39-c051-4b1f-bfe1-37e5fe47c397"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("ee042627-cb1f-43ad-a57a-bdc2a3311183"), (short)0, "Course34", new Guid("f63c3e39-c051-4b1f-bfe1-37e5fe47c397"), new Guid("2a4c66f3-e06e-4d40-830b-2aff460b9aef") },
                    { new Guid("ceb4b329-6484-41dc-92c7-6989f45c9cc5"), (short)5, "Course36", new Guid("a081e631-b30c-455c-95da-372bfec80e42"), new Guid("c78d7301-bd14-40e7-b41e-b8ab84ad6c78") },
                    { new Guid("8177e729-8ddf-4036-afcd-ae49d9c11888"), (short)0, "Course38", new Guid("d3f65c01-755b-4f6e-9400-b6f456384c83"), new Guid("f60e2337-f07e-45d8-9aa3-5e8314156a8d") },
                    { new Guid("8422c289-44ec-49db-8e66-8f8b0f363c4f"), (short)2, "Course72", new Guid("a081e631-b30c-455c-95da-372bfec80e42"), new Guid("d889d0ce-23d0-4a95-bd16-51e3a1cf0ce7") },
                    { new Guid("33c3e45f-35c8-47b3-b00a-259ebe3d027e"), (short)5, "Course108", new Guid("a081e631-b30c-455c-95da-372bfec80e42"), new Guid("5b0e27a8-b03b-405e-9d61-be91ffb92942") },
                    { new Guid("92d8c506-fcd9-4599-b541-2579cff05554"), (short)3, "Course144", new Guid("a081e631-b30c-455c-95da-372bfec80e42"), new Guid("e8405a7e-6809-4ac1-951d-03781410be97") },
                    { new Guid("3d7d4508-7223-4db1-9761-cfa136bf8e5f"), (short)3, "Course180", new Guid("a081e631-b30c-455c-95da-372bfec80e42"), new Guid("2b9f0266-611a-4820-b5c7-8d1bd747f55b") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("da81764b-3919-4fd2-b3be-b97160420d1b"), (short)1, "Course490", new Guid("b87daf0c-eb51-4c07-b449-06332e24a3ae"), new Guid("dc2dccbe-b289-444f-b374-df5eae1ea96a") },
                    { new Guid("f5f3eafe-0384-43d7-b099-3ab19e5df208"), (short)5, "Course392", new Guid("b87daf0c-eb51-4c07-b449-06332e24a3ae"), new Guid("f0b375b4-3975-4e1e-9ea4-49b33f1fa3c9") },
                    { new Guid("aa696219-b1ee-4123-996a-e5a420877eff"), (short)3, "Course0", new Guid("2db86801-969f-48b3-905c-60b04d0cc4ad"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("3fc6e508-4828-442d-8704-0e0d99311261"), (short)1, "Course37", new Guid("2db86801-969f-48b3-905c-60b04d0cc4ad"), new Guid("6980f4f6-226e-4bbd-b4ed-4125c696f4d0") },
                    { new Guid("fcfb05fb-2d4a-417a-83c1-d2878042290c"), (short)0, "Course74", new Guid("2db86801-969f-48b3-905c-60b04d0cc4ad"), new Guid("6baee663-1d3a-4058-9a14-b4ed26be7e08") },
                    { new Guid("9d33cb9c-218e-48f2-a719-f588d381cb4a"), (short)5, "Course111", new Guid("2db86801-969f-48b3-905c-60b04d0cc4ad"), new Guid("0f54ee42-1e4a-403c-89a7-9ed72d8f6725") },
                    { new Guid("8f394588-37c3-49d7-a0ea-c0effa9b4eb4"), (short)0, "Course148", new Guid("2db86801-969f-48b3-905c-60b04d0cc4ad"), new Guid("0714acfd-7b85-4714-95a4-2693f68cc7fe") },
                    { new Guid("02806877-a0c4-40b9-8240-40f43d5947f4"), (short)5, "Course185", new Guid("2db86801-969f-48b3-905c-60b04d0cc4ad"), new Guid("db11804c-38ec-4fc9-8136-dc47b7b789e3") },
                    { new Guid("91c4a4b5-3bdf-44a4-92de-edc96990ec4a"), (short)1, "Course294", new Guid("b87daf0c-eb51-4c07-b449-06332e24a3ae"), new Guid("f37ac984-18b0-4afa-804c-e73b27c47f8e") },
                    { new Guid("ef25ba9f-79da-4e90-9365-8f626baa0062"), (short)4, "Course0", new Guid("a081e631-b30c-455c-95da-372bfec80e42"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("1af858fb-3673-49c3-86dc-6ff3fd6a18f4"), (short)4, "Course196", new Guid("b87daf0c-eb51-4c07-b449-06332e24a3ae"), new Guid("af0231e3-54e5-4f62-a16d-7bcbcc3862b5") },
                    { new Guid("56123100-fb13-46b7-8003-a1018d9a647d"), (short)5, "Course76", new Guid("d3f65c01-755b-4f6e-9400-b6f456384c83"), new Guid("921e3f7f-7818-4f66-a546-133a47447022") },
                    { new Guid("027f21bc-2ec0-4537-affd-432ec5d55929"), (short)0, "Course152", new Guid("d3f65c01-755b-4f6e-9400-b6f456384c83"), new Guid("cd4fcdd9-3743-4d8d-823d-c16e81bf7feb") },
                    { new Guid("a88e0be6-edae-4895-969a-4975d87c30f8"), (short)4, "Course68", new Guid("f63c3e39-c051-4b1f-bfe1-37e5fe47c397"), new Guid("af0a604d-1fc1-4e3f-b242-2acd97d398f3") },
                    { new Guid("bf05567a-a0c1-44ed-8f3c-ff1636cececd"), (short)1, "Course102", new Guid("f63c3e39-c051-4b1f-bfe1-37e5fe47c397"), new Guid("ea8f4004-e239-4fe6-aebe-f954474d000f") },
                    { new Guid("3d17993f-acc1-4470-8b80-22cedab8ce68"), (short)1, "Course136", new Guid("f63c3e39-c051-4b1f-bfe1-37e5fe47c397"), new Guid("c78d7301-bd14-40e7-b41e-b8ab84ad6c78") },
                    { new Guid("285e4456-0618-4799-8617-3b59fb5d1b7e"), (short)5, "Course0", new Guid("b87daf0c-eb51-4c07-b449-06332e24a3ae"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("5cf56e16-582b-4693-9ab3-22b5d63687a0"), (short)3, "Course98", new Guid("b87daf0c-eb51-4c07-b449-06332e24a3ae"), new Guid("261fa621-17a3-42c6-a69b-f7116739e82b") },
                    { new Guid("7b23f419-2950-4003-8c16-0b5a938366d5"), (short)2, "Course170", new Guid("f63c3e39-c051-4b1f-bfe1-37e5fe47c397"), new Guid("8ef9a447-3f54-4ebc-854d-d176e74601b4") },
                    { new Guid("ef109b87-38b7-408d-b57f-70e1ef1aebd0"), (short)3, "Course99", new Guid("2dc17cb0-6837-492e-9a6b-1c6a3809bd66"), new Guid("c00c03a3-29fa-42e0-a672-a5722b674330") },
                    { new Guid("a8019cf6-c9ea-4f10-bf8c-041ed1eba726"), (short)4, "Course0", new Guid("2dc17cb0-6837-492e-9a6b-1c6a3809bd66"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("5b47276d-c9d7-4c3a-8a82-51bded49a9b1"), (short)5, "Course0", new Guid("eec789ea-3e9e-4600-924b-1552317fc115"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("1d9bd6fe-ab2c-4def-8d79-c837ed336a74"), (short)5, "Course35", new Guid("eec789ea-3e9e-4600-924b-1552317fc115"), new Guid("5166b68f-19c7-4295-8001-acab80e3be59") },
                    { new Guid("6d5a4eef-82b6-4dc4-af87-131edafe2355"), (short)4, "Course70", new Guid("eec789ea-3e9e-4600-924b-1552317fc115"), new Guid("8ef9a447-3f54-4ebc-854d-d176e74601b4") },
                    { new Guid("9ccb6862-3da5-428b-8ecf-36bc0e550db5"), (short)5, "Course105", new Guid("eec789ea-3e9e-4600-924b-1552317fc115"), new Guid("5b5bebc1-9a18-4276-8f59-032c426a7461") },
                    { new Guid("58385227-afde-41c7-a264-50420a2477ab"), (short)2, "Course140", new Guid("eec789ea-3e9e-4600-924b-1552317fc115"), new Guid("c69543f7-c451-44af-8136-7600bf55903c") },
                    { new Guid("81f0d957-04c7-4515-9b00-b672e83de48a"), (short)4, "Course175", new Guid("eec789ea-3e9e-4600-924b-1552317fc115"), new Guid("4b3c243d-26a2-430b-a779-cf81b39134eb") },
                    { new Guid("e7bab72a-d9f0-479b-9931-acb587ae849d"), (short)2, "Course190", new Guid("d3f65c01-755b-4f6e-9400-b6f456384c83"), new Guid("dc2dccbe-b289-444f-b374-df5eae1ea96a") },
                    { new Guid("b86e7894-e296-454c-afa0-acfc0eeb8a45"), (short)5, "Course114", new Guid("d3f65c01-755b-4f6e-9400-b6f456384c83"), new Guid("c6c1ba00-b0aa-47df-88f4-33af23ac06cb") },
                    { new Guid("52bb624a-e5fb-4363-b0e3-b4ce2ef1f9cc"), (short)5, "Course200", new Guid("e0ad951f-546b-4de2-8d93-b34c9be25957"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("03b32731-7931-4c0d-aecf-d50dfb1621d6"), (short)5, "Course0", new Guid("8f52bd94-9958-4f72-8fa0-3cb1ec30b731"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("c21620a2-79c2-4cfd-a748-b5c05ffa6fc1"), (short)0, "Course26", new Guid("2431d145-136a-4a23-b417-6af9821e039c"), new Guid("9bcbddf1-7697-462d-a409-ac2b527d26b9") },
                    { new Guid("8c032de8-05a1-4cd1-8e70-b650d979a771"), (short)3, "Course72", new Guid("26b42e2a-4fea-47e6-89bc-22524ccc8fac"), new Guid("d889d0ce-23d0-4a95-bd16-51e3a1cf0ce7") },
                    { new Guid("359a442e-2188-4ba6-ace8-b4e9ab3f3d07"), (short)1, "Course96", new Guid("26b42e2a-4fea-47e6-89bc-22524ccc8fac"), new Guid("af0231e3-54e5-4f62-a16d-7bcbcc3862b5") },
                    { new Guid("fdf60d35-27a1-4e24-8f7a-64323c44e652"), (short)2, "Course485", new Guid("d6241a14-3a43-4d50-ab66-2684d89fe179"), new Guid("db11804c-38ec-4fc9-8136-dc47b7b789e3") },
                    { new Guid("7fd466df-7734-4cc6-bfc2-fa40367e888c"), (short)2, "Course200", new Guid("a25ff68a-fe55-4ffd-af0a-e71c6d5fae6d"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("b3cacf8f-bf93-442c-a311-877216cac0c1"), (short)3, "Course120", new Guid("26b42e2a-4fea-47e6-89bc-22524ccc8fac"), new Guid("a5b92ef6-ec55-4ce7-8fbf-2260b49d0ad7") },
                    { new Guid("e33b2719-0583-4fe1-9c42-11f32d82f873"), (short)5, "Course505", new Guid("142fa12c-02f0-4a55-b09a-a3bb74d2a086"), new Guid("5b5bebc1-9a18-4276-8f59-032c426a7461") },
                    { new Guid("07c38110-84b7-4210-baf7-25027a8862be"), (short)2, "Course404", new Guid("142fa12c-02f0-4a55-b09a-a3bb74d2a086"), new Guid("e2ba043f-3076-4149-a411-f3ec84d0ac5f") },
                    { new Guid("9eda335e-5229-4fc3-9887-42c1e6b22f14"), (short)2, "Course0", new Guid("a3e9c310-0cab-432f-aff0-f0105862fac2"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("f3012474-c1e8-41bf-9274-61a0d073bd03"), (short)0, "Course25", new Guid("a3e9c310-0cab-432f-aff0-f0105862fac2"), new Guid("384f6076-f8f2-4e95-b51f-f0883a9a5576") },
                    { new Guid("c5c90579-4c3a-4b4f-83fd-674b99fdc7ac"), (short)0, "Course50", new Guid("a3e9c310-0cab-432f-aff0-f0105862fac2"), new Guid("a92a7897-7ed2-4983-a5e7-33d72a168392") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("e6354639-1a29-41bf-82a5-9298fb816ea6"), (short)0, "Course75", new Guid("a3e9c310-0cab-432f-aff0-f0105862fac2"), new Guid("4b3c243d-26a2-430b-a779-cf81b39134eb") },
                    { new Guid("eef9c6d7-ddbb-4b08-9ddd-3ec7d2da23ae"), (short)1, "Course100", new Guid("a3e9c310-0cab-432f-aff0-f0105862fac2"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("4b1a58e6-8481-4213-9ce3-49e2a64e8820"), (short)1, "Course125", new Guid("a3e9c310-0cab-432f-aff0-f0105862fac2"), new Guid("384f6076-f8f2-4e95-b51f-f0883a9a5576") },
                    { new Guid("10de1222-ff26-49d8-b577-4f4f88ec1e2b"), (short)1, "Course303", new Guid("142fa12c-02f0-4a55-b09a-a3bb74d2a086"), new Guid("3e2c035a-3595-4ba5-a65c-d7e11fd02240") },
                    { new Guid("5e89f0fe-46a2-4dad-a1c7-22806f8ffa8d"), (short)5, "Course202", new Guid("142fa12c-02f0-4a55-b09a-a3bb74d2a086"), new Guid("ea8f4004-e239-4fe6-aebe-f954474d000f") },
                    { new Guid("cf40ad8b-fef7-4f06-bd64-c0d09601c11e"), (short)1, "Course48", new Guid("26b42e2a-4fea-47e6-89bc-22524ccc8fac"), new Guid("0714acfd-7b85-4714-95a4-2693f68cc7fe") },
                    { new Guid("cbedfa51-cfc3-4068-85da-66541935c81d"), (short)2, "Course24", new Guid("26b42e2a-4fea-47e6-89bc-22524ccc8fac"), new Guid("1fd187e5-d7c8-42d2-81e4-fe3dde7b0701") },
                    { new Guid("cb1fc84b-8d05-42b4-a5b0-9626dd770db1"), (short)4, "Course388", new Guid("d6241a14-3a43-4d50-ab66-2684d89fe179"), new Guid("04b536cf-d059-43f5-a187-012c25285d74") },
                    { new Guid("2c4ccd22-0e7f-4506-9d41-d870707c3aa3"), (short)4, "Course0", new Guid("dedc1654-4d0a-43ed-a38d-143ea2a7b31c"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("e33e797e-9c94-4aee-8854-dcfa92bef69b"), (short)1, "Course44", new Guid("5f765137-96f3-4988-9ff4-e3f35a729b00"), new Guid("e8405a7e-6809-4ac1-951d-03781410be97") },
                    { new Guid("e7096edd-c7cb-4833-9039-2c02552b3bde"), (short)4, "Course66", new Guid("5f765137-96f3-4988-9ff4-e3f35a729b00"), new Guid("fdb2981f-f449-49ef-bc96-5d7152ea43e0") },
                    { new Guid("ce5cc425-705d-4261-81cd-ee921716fb0c"), (short)3, "Course88", new Guid("5f765137-96f3-4988-9ff4-e3f35a729b00"), new Guid("04b536cf-d059-43f5-a187-012c25285d74") },
                    { new Guid("a7263524-c1ec-4d93-8832-4ec75b9e48ae"), (short)3, "Course110", new Guid("5f765137-96f3-4988-9ff4-e3f35a729b00"), new Guid("58f484aa-8ab3-44b3-979a-f5c7b99910f6") },
                    { new Guid("776467e3-a0bd-41a5-b132-a1bc375c0666"), (short)4, "Course102", new Guid("9b4275d6-7484-48d9-a3d0-325ab5123f4d"), new Guid("ea8f4004-e239-4fe6-aebe-f954474d000f") },
                    { new Guid("53497afd-7229-4bb5-af2d-0c040fe4461f"), (short)1, "Course0", new Guid("9b4275d6-7484-48d9-a3d0-325ab5123f4d"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("cfdbf6f1-238f-4171-a06b-66e39cecb64f"), (short)4, "Course0", new Guid("6f066c82-d8a4-488b-93e4-dc6d836b0d15"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("47802229-5108-4e5f-8af5-df53d3fd394d"), (short)4, "Course0", new Guid("2431d145-136a-4a23-b417-6af9821e039c"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("4fddeb69-1903-4586-897c-ea85da8d0c64"), (short)3, "Course123", new Guid("dedc1654-4d0a-43ed-a38d-143ea2a7b31c"), new Guid("dc366896-8c46-4e59-86b1-7be25e6b25cf") },
                    { new Guid("fde009a6-66fb-407e-9608-7f27109b3510"), (short)0, "Course46", new Guid("6f066c82-d8a4-488b-93e4-dc6d836b0d15"), new Guid("07fe7183-eeba-4290-ad4f-98cacee625ea") },
                    { new Guid("489ac9e2-b5cd-420c-924a-96d2ce61e416"), (short)3, "Course69", new Guid("6f066c82-d8a4-488b-93e4-dc6d836b0d15"), new Guid("962082e2-14d7-498d-80fb-2427625c671a") },
                    { new Guid("f24a54dd-dbbc-4af0-bcce-fabbe2f3903a"), (short)5, "Course92", new Guid("6f066c82-d8a4-488b-93e4-dc6d836b0d15"), new Guid("f0b375b4-3975-4e1e-9ea4-49b33f1fa3c9") },
                    { new Guid("6a3325be-af1e-415f-8b47-9150e1ff0273"), (short)3, "Course115", new Guid("6f066c82-d8a4-488b-93e4-dc6d836b0d15"), new Guid("b1b3057c-b83e-4a08-bc6a-9360d5af13bd") },
                    { new Guid("2a0e5e6d-a605-40a1-8332-cd988c8a3706"), (short)1, "Course82", new Guid("dedc1654-4d0a-43ed-a38d-143ea2a7b31c"), new Guid("50e805fc-950a-4835-b29b-6cee79b22045") },
                    { new Guid("f8d0cc75-9fdf-451d-a046-310a8db6e197"), (short)5, "Course41", new Guid("dedc1654-4d0a-43ed-a38d-143ea2a7b31c"), new Guid("1784f2dc-d5c1-429c-8642-19b865a1afb7") },
                    { new Guid("7794f130-8c8a-4c31-9399-72328fd62b27"), (short)5, "Course0", new Guid("26b42e2a-4fea-47e6-89bc-22524ccc8fac"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("2f00e311-07de-4b4e-9030-1fc484fdd87d"), (short)2, "Course23", new Guid("6f066c82-d8a4-488b-93e4-dc6d836b0d15"), new Guid("dc366896-8c46-4e59-86b1-7be25e6b25cf") },
                    { new Guid("ab921d38-cd71-41e4-b1d9-b3d923e409fd"), (short)3, "Course300", new Guid("e0ad951f-546b-4de2-8d93-b34c9be25957"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("4ea6d5f2-3ffd-447a-9864-40019f7f047e"), (short)5, "Course0", new Guid("d3f65c01-755b-4f6e-9400-b6f456384c83"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("e042ea62-80e0-48b8-854b-d9561b496165"), (short)4, "Course78", new Guid("2431d145-136a-4a23-b417-6af9821e039c"), new Guid("ddd29bd3-3463-4300-aec9-f02ef123b657") },
                    { new Guid("a6b26eb3-8595-4279-8810-17b297a98ab3"), (short)3, "Course145", new Guid("706dd721-f5b6-4281-b76e-9008f63e7c1a"), new Guid("8ec1697b-d4d9-4c6c-8d7e-a7a369a05831") },
                    { new Guid("541ef130-caf2-4533-9486-a31b1daefba0"), (short)0, "Course116", new Guid("706dd721-f5b6-4281-b76e-9008f63e7c1a"), new Guid("1659619d-a195-40f0-9b32-7ae994c4f7c5") },
                    { new Guid("2729dd1e-af62-4d48-9d29-827edf96ed3d"), (short)5, "Course87", new Guid("706dd721-f5b6-4281-b76e-9008f63e7c1a"), new Guid("0db6ac70-8dd3-4da1-bcff-27696faa9338") },
                    { new Guid("178e1d33-75ba-407d-a075-1ded4865f106"), (short)1, "Course58", new Guid("706dd721-f5b6-4281-b76e-9008f63e7c1a"), new Guid("0eafc5e8-bb25-43ce-aa71-fac4ee547b1c") },
                    { new Guid("44f6e410-de6a-486c-a0a3-5960ad394b36"), (short)4, "Course29", new Guid("706dd721-f5b6-4281-b76e-9008f63e7c1a"), new Guid("47d9fc1a-717f-4d80-a88a-79195ef4c6b1") },
                    { new Guid("d6b99ea1-3045-4fb1-b44b-1f9d274ca9c1"), (short)4, "Course0", new Guid("706dd721-f5b6-4281-b76e-9008f63e7c1a"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("0adc7655-86f6-47bf-be54-dfc296d5ff2e"), (short)2, "Course400", new Guid("e0ad951f-546b-4de2-8d93-b34c9be25957"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("7bcfe56d-0170-48d2-96a9-8d9c13e5bac2"), (short)0, "Course500", new Guid("e0ad951f-546b-4de2-8d93-b34c9be25957"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("9842554c-a98b-4470-8f74-8d5b01d4afb8"), (short)3, "Course140", new Guid("d49224d3-b1e7-4aa7-be06-6af013817419"), new Guid("c69543f7-c451-44af-8136-7600bf55903c") },
                    { new Guid("18f54794-6a01-46a4-a698-c13d60c4a3c1"), (short)0, "Course112", new Guid("d49224d3-b1e7-4aa7-be06-6af013817419"), new Guid("47a375c2-c9b6-4013-8239-e327ab21d4ec") },
                    { new Guid("cb739a41-d069-4b0d-9a69-a572a305057a"), (short)0, "Course84", new Guid("d49224d3-b1e7-4aa7-be06-6af013817419"), new Guid("ccb7a87a-5a14-4961-8ca6-8063675b2bce") },
                    { new Guid("16f09f17-a0d8-4573-bcb4-4466eca5b2bd"), (short)0, "Course195", new Guid("d836d27d-e6d5-407f-813f-a9ff0fed87cc"), new Guid("a49dc22c-16b1-450f-bd05-54627b33a952") },
                    { new Guid("b8f584a1-d9bd-4416-9f10-944ba824766a"), (short)5, "Course52", new Guid("2431d145-136a-4a23-b417-6af9821e039c"), new Guid("cd4fcdd9-3743-4d8d-823d-c16e81bf7feb") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("6150ce6d-ec1d-4707-a94c-3fdc25738b97"), (short)2, "Course28", new Guid("d49224d3-b1e7-4aa7-be06-6af013817419"), new Guid("fd7aa746-fa3d-4b6c-bfc4-180fa0062035") },
                    { new Guid("21d945ac-5bcc-4f8e-86b2-66c0822bf70d"), (short)3, "Course0", new Guid("d49224d3-b1e7-4aa7-be06-6af013817419"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("e020daa6-09bb-44f4-b885-34b1695e0bcb"), (short)5, "Course56", new Guid("d49224d3-b1e7-4aa7-be06-6af013817419"), new Guid("ba1fcd39-4e90-42d6-a1f1-d52be00852c8") },
                    { new Guid("881340e5-391e-4b05-ab52-d709c7ae65f0"), (short)1, "Course0", new Guid("a25ff68a-fe55-4ffd-af0a-e71c6d5fae6d"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("9f911dbd-9647-4877-8b4b-6c3290755d6c"), (short)5, "Course135", new Guid("4339ed05-7417-49fd-8890-8083bc51b3c5"), new Guid("5166b68f-19c7-4295-8001-acab80e3be59") },
                    { new Guid("03eb4806-45fc-490e-9728-41357cf12bcc"), (short)4, "Course40", new Guid("a25ff68a-fe55-4ffd-af0a-e71c6d5fae6d"), new Guid("c69543f7-c451-44af-8136-7600bf55903c") },
                    { new Guid("e82ca562-ba8c-4284-a37e-fac562bd61b6"), (short)2, "Course80", new Guid("a25ff68a-fe55-4ffd-af0a-e71c6d5fae6d"), new Guid("2b9f0266-611a-4820-b5c7-8d1bd747f55b") },
                    { new Guid("12748b2b-2b68-4155-a985-af85f6ca9e5a"), (short)5, "Course108", new Guid("4339ed05-7417-49fd-8890-8083bc51b3c5"), new Guid("5b0e27a8-b03b-405e-9d61-be91ffb92942") },
                    { new Guid("7e035751-0600-4175-b588-0945c16af875"), (short)1, "Course160", new Guid("a25ff68a-fe55-4ffd-af0a-e71c6d5fae6d"), new Guid("6b5a6b95-6bd0-4340-babb-e56e9ac0171d") },
                    { new Guid("987d3d2b-1455-45cb-a7a8-038080492cc9"), (short)1, "Course81", new Guid("4339ed05-7417-49fd-8890-8083bc51b3c5"), new Guid("64348b66-65ef-4051-a489-855fe874b9c0") },
                    { new Guid("7e4366d7-3dbf-4f46-828c-bbf598257de3"), (short)4, "Course54", new Guid("4339ed05-7417-49fd-8890-8083bc51b3c5"), new Guid("471b80b9-dd36-4a48-89c2-39b5941f439d") },
                    { new Guid("5ac3c2dd-4095-4786-bd89-5ead02a8f2ce"), (short)2, "Course120", new Guid("a25ff68a-fe55-4ffd-af0a-e71c6d5fae6d"), new Guid("a5b92ef6-ec55-4ce7-8fbf-2260b49d0ad7") },
                    { new Guid("a018570d-87b0-491e-beaa-d8f5622bb7ef"), (short)0, "Course104", new Guid("2431d145-136a-4a23-b417-6af9821e039c"), new Guid("e2ba043f-3076-4149-a411-f3ec84d0ac5f") },
                    { new Guid("8b1c2710-404c-40bd-8f48-7f24138e81e4"), (short)5, "Course27", new Guid("4339ed05-7417-49fd-8890-8083bc51b3c5"), new Guid("0e9cfc47-3a8c-481d-ab60-4cbcc7d579e4") },
                    { new Guid("f778d586-8214-4281-a514-382e7527a6f1"), (short)1, "Course0", new Guid("4339ed05-7417-49fd-8890-8083bc51b3c5"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("943f4869-81ef-4775-bb15-e878b8bf0159"), (short)3, "Course0", new Guid("142fa12c-02f0-4a55-b09a-a3bb74d2a086"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("45ebbe01-3b53-487b-a7fb-8cecd559e958"), (short)4, "Course101", new Guid("142fa12c-02f0-4a55-b09a-a3bb74d2a086"), new Guid("51e9dc92-d8bc-4914-808a-9e4faaf09da6") },
                    { new Guid("a916fd86-1945-4547-8625-5063666bdc05"), (short)2, "Course130", new Guid("2431d145-136a-4a23-b417-6af9821e039c"), new Guid("9d0e4158-3440-4bf7-b67d-078faeeddbcb") }
                });

            migrationBuilder.InsertData(
                table: "OptionalCourses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("9d6fbba5-fb1d-4a54-9146-bf7087a7a827"), (short)0, "Course96", new Guid("6a34ac77-de2a-48ca-884a-0826d1b646ec"), new Guid("af0231e3-54e5-4f62-a16d-7bcbcc3862b5") },
                    { new Guid("f339faa2-19a5-4ae1-9c24-5385912f94b6"), (short)4, "Course86", new Guid("f08fd625-7ae2-409f-b72a-f2cccf217e07"), new Guid("56dd0284-ef65-45c8-9633-7ece06a318f0") },
                    { new Guid("7f9d323b-2e7d-4ef3-8d6d-41da03fc01bd"), (short)0, "Course0", new Guid("6a34ac77-de2a-48ca-884a-0826d1b646ec"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("ab15dde1-7353-40db-9786-20dd03c98a37"), (short)3, "Course106", new Guid("963cf773-7521-432e-9982-1e2949e7027b"), new Guid("a37d6845-9076-475c-9302-4ca8b1f09f0f") },
                    { new Guid("673be51b-c4dc-4f56-95b9-608872850f78"), (short)5, "Course97", new Guid("d6241a14-3a43-4d50-ab66-2684d89fe179"), new Guid("923257c6-f46b-4250-8337-b6ac1f4357ca") },
                    { new Guid("034c0d73-d284-43dd-8972-2fe63226de71"), (short)5, "Course0", new Guid("d6241a14-3a43-4d50-ab66-2684d89fe179"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("e0b500f6-bcd2-4f34-993c-edba5c26427e"), (short)0, "Course0", new Guid("f08fd625-7ae2-409f-b72a-f2cccf217e07"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("729aec25-6251-4df0-83ec-304663dc1092"), (short)1, "Course0", new Guid("2dc17cb0-6837-492e-9a6b-1c6a3809bd66"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("86b29b00-4424-4762-bbc3-4ab07c23ff89"), (short)3, "Course0", new Guid("f1358410-62e4-4bdf-bc20-338a4325b31c"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("bf431e0c-7465-4040-b05f-0ecb00750b26"), (short)5, "Course91", new Guid("3eab4340-3570-46fd-9bb7-fdaec0973133"), new Guid("6e99f39c-e2fa-42f8-be2f-7d704a299585") },
                    { new Guid("2e3cdd08-2c18-484b-8993-350a369485ec"), (short)1, "Course101", new Guid("142fa12c-02f0-4a55-b09a-a3bb74d2a086"), new Guid("51e9dc92-d8bc-4914-808a-9e4faaf09da6") },
                    { new Guid("85c8a636-c6f1-4585-a462-e4694481c5c9"), (short)0, "Course0", new Guid("142fa12c-02f0-4a55-b09a-a3bb74d2a086"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("1ff22614-00aa-4df7-8048-42b0f4b9f2b9"), (short)5, "Course0", new Guid("9b4275d6-7484-48d9-a3d0-325ab5123f4d"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("1d104f78-9a1b-4b02-b847-fc8bb3dd4fe7"), (short)5, "Course102", new Guid("9b4275d6-7484-48d9-a3d0-325ab5123f4d"), new Guid("ea8f4004-e239-4fe6-aebe-f954474d000f") },
                    { new Guid("8cfd1ed7-446d-496b-a84f-2d53f20e5df6"), (short)5, "Course0", new Guid("10418318-09fe-4b62-924e-b02017044cd9"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("1ca865ab-179d-4f89-9768-f3016af761a1"), (short)5, "Course92", new Guid("10418318-09fe-4b62-924e-b02017044cd9"), new Guid("f0b375b4-3975-4e1e-9ea4-49b33f1fa3c9") },
                    { new Guid("a4492a95-21d1-45da-a54a-181db403ec4e"), (short)1, "Course90", new Guid("0253e66e-905c-45b6-a9f6-5845201fdccd"), new Guid("dc2dccbe-b289-444f-b374-df5eae1ea96a") },
                    { new Guid("0943ded9-80e4-4a17-baf1-a25a376d55bd"), (short)3, "Course0", new Guid("0253e66e-905c-45b6-a9f6-5845201fdccd"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("184597c5-b467-4c16-a23f-2012c97d32b0"), (short)5, "Course0", new Guid("70d68c6a-b23d-4cf8-998c-9033d2bb756d"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("5b4777f1-0bbf-4ed1-bf4c-e6d978305a7f"), (short)0, "Course103", new Guid("70d68c6a-b23d-4cf8-998c-9033d2bb756d"), new Guid("3e2c035a-3595-4ba5-a65c-d7e11fd02240") },
                    { new Guid("0b65a50e-d0d3-4c53-852b-fce19c5b267d"), (short)2, "Course100", new Guid("e0ad951f-546b-4de2-8d93-b34c9be25957"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("2c4f9b71-8440-4111-a1b7-73edbd8165c6"), (short)1, "Course0", new Guid("e0ad951f-546b-4de2-8d93-b34c9be25957"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("10244d3f-c24b-4f54-b8e8-50fd7b0e9251"), (short)4, "Course0", new Guid("2a3dcf49-b486-4136-8b78-d46221adb6cc"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("c72b8d75-6554-449f-b2d3-a4055d3c983c"), (short)2, "Course93", new Guid("2a3dcf49-b486-4136-8b78-d46221adb6cc"), new Guid("6354b09f-7243-4fb7-9695-f70ccf026e24") }
                });

            migrationBuilder.InsertData(
                table: "OptionalCourses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("9246764c-fdfb-44c9-815c-132aa8e2daf5"), (short)4, "Course89", new Guid("0c51308b-6441-4f3d-b045-629877d81a46"), new Guid("320b7836-0470-4b4a-8ee5-5146e0766166") },
                    { new Guid("d2bd72cd-ba4f-4fd0-9cc8-468424aef840"), (short)0, "Course0", new Guid("0c51308b-6441-4f3d-b045-629877d81a46"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("a4f709d7-64f3-4dcb-b1bf-906f9fd0a780"), (short)2, "Course87", new Guid("f1358410-62e4-4bdf-bc20-338a4325b31c"), new Guid("0db6ac70-8dd3-4da1-bcff-27696faa9338") },
                    { new Guid("f2bd4226-64e0-4156-84e2-e44ee05bfc09"), (short)2, "Course0", new Guid("b87daf0c-eb51-4c07-b449-06332e24a3ae"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("67599df0-4e94-4dc6-8486-853db4994aa2"), (short)1, "Course95", new Guid("aca00e4f-9891-42ce-b030-bdb460912a86"), new Guid("a49dc22c-16b1-450f-bd05-54627b33a952") },
                    { new Guid("0d9e2f74-9fa7-4422-859b-dffca5ce123b"), (short)2, "Course0", new Guid("aca00e4f-9891-42ce-b030-bdb460912a86"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("8e130879-c17c-4e99-8da4-775c423e4b5f"), (short)1, "Course98", new Guid("b87daf0c-eb51-4c07-b449-06332e24a3ae"), new Guid("261fa621-17a3-42c6-a69b-f7116739e82b") },
                    { new Guid("612dfbc6-65d3-4084-99c0-a6ffa23e12d8"), (short)2, "Course105", new Guid("8952f512-fe84-4820-b001-3b5c49c34a27"), new Guid("5b5bebc1-9a18-4276-8f59-032c426a7461") },
                    { new Guid("5721e14a-2312-4c16-bee6-ae805952dc34"), (short)3, "Course0", new Guid("963cf773-7521-432e-9982-1e2949e7027b"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("62878184-a0f0-4001-a9f5-f31f8fd58179"), (short)1, "Course0", new Guid("8952f512-fe84-4820-b001-3b5c49c34a27"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("b4d8d209-5fd6-4db0-9887-89c6a0f691f9"), (short)4, "Course88", new Guid("bc1fff87-1a12-49cf-88cf-641e2e1a77ae"), new Guid("04b536cf-d059-43f5-a187-012c25285d74") },
                    { new Guid("710920d5-a86b-4f14-9db4-89ff06b69cf4"), (short)4, "Course94", new Guid("053cf60d-5963-4dcb-812d-a6a98e2b1817"), new Guid("f37ac984-18b0-4afa-804c-e73b27c47f8e") },
                    { new Guid("33cb32be-564a-4b0d-ac00-c20729807336"), (short)5, "Course0", new Guid("053cf60d-5963-4dcb-812d-a6a98e2b1817"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("aaff1993-cd78-408f-afb5-5900f9f9c4b3"), (short)5, "Course99", new Guid("2dc17cb0-6837-492e-9a6b-1c6a3809bd66"), new Guid("c00c03a3-29fa-42e0-a672-a5722b674330") },
                    { new Guid("ba36e657-9dad-417e-929b-dcb3deca447b"), (short)4, "Course104", new Guid("d3269155-a2c0-49b7-89e5-93b14b670d85"), new Guid("e2ba043f-3076-4149-a411-f3ec84d0ac5f") },
                    { new Guid("4bc34497-06d2-4511-a6f8-119356c05116"), (short)1, "Course0", new Guid("d3269155-a2c0-49b7-89e5-93b14b670d85"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("6bdca90f-f8e9-41df-9910-d285ba8c3fee"), (short)5, "Course0", new Guid("bc1fff87-1a12-49cf-88cf-641e2e1a77ae"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("97ea2170-27f9-4aa4-b59d-fdc88ed55aab"), (short)1, "Course0", new Guid("3eab4340-3570-46fd-9bb7-fdaec0973133"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("ee776c3e-a778-430e-bf81-08b871b284f4"), (short)2, "Course53", new Guid("49fd7f4c-a8ca-45d5-bbe0-55ef9faca700"), new Guid("fa322a6f-6d03-46c5-a563-fb058063c944") },
                    { new Guid("a97584d4-ce05-403a-9909-f05286f12805"), (short)3, "Course0", new Guid("56ff758d-1574-4779-821c-df8a31fb9c08"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("2b318988-6722-4714-95ae-a39483ba18fe"), (short)5, "Course0", new Guid("8f52bd94-9958-4f72-8fa0-3cb1ec30b731"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("4b2fe408-cce3-4a54-936f-3a96a9a649e2"), (short)2, "Course29", new Guid("706dd721-f5b6-4281-b76e-9008f63e7c1a"), new Guid("47d9fc1a-717f-4d80-a88a-79195ef4c6b1") },
                    { new Guid("1ac53308-4f5b-424b-8634-b37bbb3240ed"), (short)4, "Course0", new Guid("706dd721-f5b6-4281-b76e-9008f63e7c1a"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("c19a1c5b-42f1-454f-8908-49a8113e268f"), (short)4, "Course28", new Guid("d49224d3-b1e7-4aa7-be06-6af013817419"), new Guid("fd7aa746-fa3d-4b6c-bfc4-180fa0062035") },
                    { new Guid("b744410d-337e-4268-9b31-f9f7b975c2ec"), (short)5, "Course0", new Guid("d49224d3-b1e7-4aa7-be06-6af013817419"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("c0ff419f-525d-4b5f-a35c-7c3557b09a7f"), (short)1, "Course27", new Guid("4339ed05-7417-49fd-8890-8083bc51b3c5"), new Guid("0e9cfc47-3a8c-481d-ab60-4cbcc7d579e4") },
                    { new Guid("1949ecc5-f2e9-4e4c-a843-b2fed63d1f51"), (short)3, "Course0", new Guid("4339ed05-7417-49fd-8890-8083bc51b3c5"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("8778101f-c3d1-4b01-82ed-74267c535fd2"), (short)3, "Course26", new Guid("2431d145-136a-4a23-b417-6af9821e039c"), new Guid("9bcbddf1-7697-462d-a409-ac2b527d26b9") },
                    { new Guid("4f0ad544-41f3-4c82-82b6-aaf7f8d70b9f"), (short)3, "Course0", new Guid("2431d145-136a-4a23-b417-6af9821e039c"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("0328acea-b330-40c9-a87d-653b3c6ffda0"), (short)3, "Course25", new Guid("a3e9c310-0cab-432f-aff0-f0105862fac2"), new Guid("384f6076-f8f2-4e95-b51f-f0883a9a5576") },
                    { new Guid("0f6dea53-87c2-49d5-a043-834b3bc28c4d"), (short)3, "Course0", new Guid("a3e9c310-0cab-432f-aff0-f0105862fac2"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("681e8430-f3d7-46c1-b3b6-b1fa953044bf"), (short)5, "Course24", new Guid("26b42e2a-4fea-47e6-89bc-22524ccc8fac"), new Guid("1fd187e5-d7c8-42d2-81e4-fe3dde7b0701") },
                    { new Guid("151ab050-a2ca-4215-ba0b-e28f9ee3722c"), (short)3, "Course0", new Guid("26b42e2a-4fea-47e6-89bc-22524ccc8fac"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("c520b3db-ad84-4971-ac9a-f39fd1a9d64d"), (short)0, "Course23", new Guid("6f066c82-d8a4-488b-93e4-dc6d836b0d15"), new Guid("dc366896-8c46-4e59-86b1-7be25e6b25cf") },
                    { new Guid("9b569205-18bf-4050-b783-b67f7ecdc769"), (short)3, "Course0", new Guid("6f066c82-d8a4-488b-93e4-dc6d836b0d15"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("7018abe6-9dd7-4175-badf-bdbfc057ccfc"), (short)0, "Course22", new Guid("5f765137-96f3-4988-9ff4-e3f35a729b00"), new Guid("f271e53b-f316-4f3c-9aca-8469584bb14a") },
                    { new Guid("0cb6edcb-8b63-49a4-b3eb-031e5d693135"), (short)1, "Course0", new Guid("5f765137-96f3-4988-9ff4-e3f35a729b00"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("e44a4cc7-56ce-44fc-aa81-cecea4e5f978"), (short)1, "Course30", new Guid("8f52bd94-9958-4f72-8fa0-3cb1ec30b731"), new Guid("9d0e4158-3440-4bf7-b67d-078faeeddbcb") },
                    { new Guid("12a596ed-e4a6-467b-ab41-835b214ac866"), (short)2, "Course0", new Guid("04f6c475-8b10-4380-8777-0a2ca3806508"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("966c1074-13c9-4185-882b-e6044d92b5ec"), (short)2, "Course31", new Guid("04f6c475-8b10-4380-8777-0a2ca3806508"), new Guid("53f2f91f-3252-4cab-af3a-aaabf84f4422") },
                    { new Guid("a012dc17-6070-4917-bd0e-907bb3288107"), (short)3, "Course0", new Guid("befde88f-9a14-4e2f-a0fe-07e28bf31301"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("238cbe8d-98b1-4e7c-9885-6ed3919b14b1"), (short)3, "Course0", new Guid("dedc1654-4d0a-43ed-a38d-143ea2a7b31c"), new Guid("d520389d-d791-479c-a509-27d5bb244858") }
                });

            migrationBuilder.InsertData(
                table: "OptionalCourses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("11b10126-73cf-4a44-984d-929679b9caf4"), (short)0, "Course40", new Guid("a25ff68a-fe55-4ffd-af0a-e71c6d5fae6d"), new Guid("c69543f7-c451-44af-8136-7600bf55903c") },
                    { new Guid("0f3e35ef-a9eb-4980-a820-a20d0231199d"), (short)5, "Course0", new Guid("a25ff68a-fe55-4ffd-af0a-e71c6d5fae6d"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("bebdca91-3419-4868-987a-926bc7dcd4d7"), (short)3, "Course39", new Guid("d836d27d-e6d5-407f-813f-a9ff0fed87cc"), new Guid("84ea72b7-9dc5-4c45-a282-0d138774b216") },
                    { new Guid("6aa7c940-ab95-4d20-a3b8-a75eebcc7022"), (short)0, "Course0", new Guid("d836d27d-e6d5-407f-813f-a9ff0fed87cc"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("cb59500e-7ec1-4f74-a79f-c7b71dcce144"), (short)0, "Course38", new Guid("d3f65c01-755b-4f6e-9400-b6f456384c83"), new Guid("f60e2337-f07e-45d8-9aa3-5e8314156a8d") },
                    { new Guid("7eae90ae-7632-4941-8eff-224b453830af"), (short)4, "Course0", new Guid("d3f65c01-755b-4f6e-9400-b6f456384c83"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("9a274d7e-5685-4998-b454-fe5473610beb"), (short)2, "Course37", new Guid("2db86801-969f-48b3-905c-60b04d0cc4ad"), new Guid("6980f4f6-226e-4bbd-b4ed-4125c696f4d0") },
                    { new Guid("0e7ba6c1-fdb2-47bd-a5ba-0ebcc47e9be5"), (short)2, "Course21", new Guid("b6d6e9f6-b969-4f1f-811b-b04a5da43f45"), new Guid("5599f6d0-3655-4d17-8ea1-096103c7b1a7") },
                    { new Guid("6abfc635-39ac-4b89-8acc-34761c5a890d"), (short)5, "Course0", new Guid("2db86801-969f-48b3-905c-60b04d0cc4ad"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("a62d2987-4ecf-4f6a-af9c-6f808f6b85a3"), (short)4, "Course0", new Guid("a081e631-b30c-455c-95da-372bfec80e42"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("e52beae5-1f71-4228-8aff-c3bf5518ae4f"), (short)1, "Course35", new Guid("eec789ea-3e9e-4600-924b-1552317fc115"), new Guid("5166b68f-19c7-4295-8001-acab80e3be59") },
                    { new Guid("d0a4d0de-61e4-4ccf-bd23-58307b8cd9ce"), (short)2, "Course0", new Guid("eec789ea-3e9e-4600-924b-1552317fc115"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("3d8ce4c9-cb0c-418a-8264-c17d82781318"), (short)5, "Course34", new Guid("f63c3e39-c051-4b1f-bfe1-37e5fe47c397"), new Guid("2a4c66f3-e06e-4d40-830b-2aff460b9aef") },
                    { new Guid("72c6f44a-8b65-4680-98ef-8af360859c53"), (short)1, "Course0", new Guid("f63c3e39-c051-4b1f-bfe1-37e5fe47c397"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("73419f68-99c1-400d-9a86-1291a25d2879"), (short)0, "Course33", new Guid("a03cb3ef-9bd7-4513-a995-4e46f5f6dd3b"), new Guid("e13a6b5d-7312-488e-9cea-5f449d9b6ed5") },
                    { new Guid("316b0275-1a26-41a4-8930-d2c0c07f8511"), (short)5, "Course0", new Guid("a03cb3ef-9bd7-4513-a995-4e46f5f6dd3b"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("90fda2a3-a54e-413c-9669-f86a44d14f89"), (short)5, "Course32", new Guid("befde88f-9a14-4e2f-a0fe-07e28bf31301"), new Guid("1bf88dee-3b4f-48fd-9679-6c90ced03977") },
                    { new Guid("26fb7645-a5f0-4cc6-bf6c-f9b13f816525"), (short)1, "Course36", new Guid("a081e631-b30c-455c-95da-372bfec80e42"), new Guid("c78d7301-bd14-40e7-b41e-b8ab84ad6c78") },
                    { new Guid("62818ca8-8e0a-4a8e-b8e3-d597936e95c5"), (short)5, "Course0", new Guid("b6d6e9f6-b969-4f1f-811b-b04a5da43f45"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("c58284ea-9419-4dda-b9fe-89b596d52cbf"), (short)3, "Course20", new Guid("103abef8-fca5-4a1e-9b82-498ec853c71e"), new Guid("a5b92ef6-ec55-4ce7-8fbf-2260b49d0ad7") },
                    { new Guid("fe6ce376-5852-4ad0-93dd-1e481b0214b8"), (short)1, "Course0", new Guid("103abef8-fca5-4a1e-9b82-498ec853c71e"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("512225ed-9b82-44b6-9784-add563eaad42"), (short)3, "Course8", new Guid("66efa1f8-c9ae-499f-b2da-58fb59772dd9"), new Guid("5b0e27a8-b03b-405e-9d61-be91ffb92942") },
                    { new Guid("64277d71-1bc1-42ec-b057-50fe7b723c54"), (short)1, "Course0", new Guid("66efa1f8-c9ae-499f-b2da-58fb59772dd9"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("0c3f985e-e28d-4b4f-8dcf-7c989d6a4cda"), (short)0, "Course7", new Guid("0678b7cb-fd34-400c-8663-889e8330ec64"), new Guid("6276add9-6269-4d1e-a285-a51ada727742") },
                    { new Guid("1cbf3e74-b008-4af1-ae66-66d44120520d"), (short)4, "Course0", new Guid("0678b7cb-fd34-400c-8663-889e8330ec64"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("da0ee43b-2557-4d71-9c61-e9a1f0a570bf"), (short)4, "Course6", new Guid("5f22df2e-ee85-4783-93f0-79eecd95ba4e"), new Guid("a37d6845-9076-475c-9302-4ca8b1f09f0f") },
                    { new Guid("482a9498-8385-423e-99ca-99d2a3ffd9cd"), (short)2, "Course0", new Guid("5f22df2e-ee85-4783-93f0-79eecd95ba4e"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("faa62583-229e-4c1c-9026-73c3f5985ed2"), (short)3, "Course5", new Guid("023c8ee5-7bf3-4a2e-96ce-2448392692a4"), new Guid("5b5bebc1-9a18-4276-8f59-032c426a7461") },
                    { new Guid("da14cfd6-e3bd-40e7-bbb8-63849bea068a"), (short)2, "Course0", new Guid("023c8ee5-7bf3-4a2e-96ce-2448392692a4"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("372569ec-3c17-49e7-aba0-b146f38820fd"), (short)0, "Course0", new Guid("b60fa263-44f4-46b3-a494-ae3252ac925e"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("a687078c-6af4-4a2d-9523-c46f547f5528"), (short)5, "Course4", new Guid("11efde67-a191-45ea-a2be-bd903fcbb462"), new Guid("e2ba043f-3076-4149-a411-f3ec84d0ac5f") },
                    { new Guid("274b4646-85b7-4078-9669-2e1d248a49a0"), (short)5, "Course3", new Guid("c7955d67-ea7a-4095-9efc-23006bcb41fd"), new Guid("3e2c035a-3595-4ba5-a65c-d7e11fd02240") },
                    { new Guid("654ea075-6f9a-488e-bd87-bee5276b507b"), (short)0, "Course0", new Guid("c7955d67-ea7a-4095-9efc-23006bcb41fd"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("f9326861-4ff0-4f28-88ce-c52264970477"), (short)0, "Course2", new Guid("270d93d2-2d14-4f27-bfb5-62541c50fe99"), new Guid("ea8f4004-e239-4fe6-aebe-f954474d000f") },
                    { new Guid("dea94db2-262a-4836-903d-3d7fd704fe94"), (short)2, "Course0", new Guid("270d93d2-2d14-4f27-bfb5-62541c50fe99"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("8709e44b-2dad-4085-ab75-58cd3646a9aa"), (short)2, "Course1", new Guid("a5810ef7-fa39-4a3d-92a5-cc0236bbc26c"), new Guid("51e9dc92-d8bc-4914-808a-9e4faaf09da6") },
                    { new Guid("80449a12-5de8-44bd-b031-f66d67422cb4"), (short)3, "Course0", new Guid("a5810ef7-fa39-4a3d-92a5-cc0236bbc26c"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("318a6048-1709-4dcf-b6e5-55c283b6e5f2"), (short)5, "Course0", new Guid("2c032d08-736e-42ea-bd92-327472a78910"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("5acff67f-321b-4a0a-97d2-949b01371b9b"), (short)3, "Course0", new Guid("2c032d08-736e-42ea-bd92-327472a78910"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("92a1f2d8-9a72-46c9-b441-142275dd1444"), (short)4, "Course0", new Guid("11efde67-a191-45ea-a2be-bd903fcbb462"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("b6a65bcb-d5ad-4679-bd3f-ed0a76266fe4"), (short)2, "Course41", new Guid("dedc1654-4d0a-43ed-a38d-143ea2a7b31c"), new Guid("1784f2dc-d5c1-429c-8642-19b865a1afb7") },
                    { new Guid("bd539441-8714-4ebc-823c-14e7039b4028"), (short)1, "Course9", new Guid("b60fa263-44f4-46b3-a494-ae3252ac925e"), new Guid("56f39da2-627a-4954-8db5-d1b440669300") }
                });

            migrationBuilder.InsertData(
                table: "OptionalCourses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("7d70aaa4-1148-49dd-8547-656f8968fb16"), (short)1, "Course10", new Guid("2af25551-4fd6-47f5-a00f-23916f40c162"), new Guid("58f484aa-8ab3-44b3-979a-f5c7b99910f6") },
                    { new Guid("c39d9054-cd73-4841-8317-1c1540463b56"), (short)0, "Course19", new Guid("a34783f0-cd79-4260-82c6-79b4dbfcd112"), new Guid("0ca079c5-33ca-4528-a75a-d9207ff75e6c") },
                    { new Guid("88cec539-57ea-43c2-b889-46848ef35141"), (short)0, "Course0", new Guid("a34783f0-cd79-4260-82c6-79b4dbfcd112"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("5105c2d7-8f32-4c90-98db-2ece7391540d"), (short)0, "Course18", new Guid("256a5b40-8012-4db3-b00c-10fd242f92cb"), new Guid("6489c875-e57b-49e3-b8db-13d8166de086") },
                    { new Guid("5725ef74-7cca-4315-86b0-2bc4d34b1e32"), (short)4, "Course0", new Guid("256a5b40-8012-4db3-b00c-10fd242f92cb"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("9a0e558f-7fe2-455a-9bb8-d830f0b1c585"), (short)3, "Course17", new Guid("f522dc14-2a27-408b-a3b7-37ab0f14492b"), new Guid("2373980d-fec4-403e-82d4-ec6a5bcd66f5") },
                    { new Guid("dccd78e6-5693-4eec-8982-fe53868dbb28"), (short)4, "Course0", new Guid("f522dc14-2a27-408b-a3b7-37ab0f14492b"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("bb566bff-9dab-48d5-9ffc-a05a6037189d"), (short)3, "Course16", new Guid("6537ebae-4f75-4743-8fbc-71d75ad6c0f4"), new Guid("1659619d-a195-40f0-9b32-7ae994c4f7c5") },
                    { new Guid("1c8ca4e4-c942-4add-a67e-e8983d161ece"), (short)4, "Course0", new Guid("6537ebae-4f75-4743-8fbc-71d75ad6c0f4"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("ebae2397-b16c-4778-bd1b-acfa1d713a08"), (short)0, "Course0", new Guid("2af25551-4fd6-47f5-a00f-23916f40c162"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("8c5fa166-52f4-4445-9d29-ccd0e1ef0b5f"), (short)1, "Course15", new Guid("c9099a6b-63bf-4cac-9c6b-79375bbe3abb"), new Guid("b1b3057c-b83e-4a08-bc6a-9360d5af13bd") },
                    { new Guid("4b17e8bd-34fc-4c72-8d2c-05a4ddf5022c"), (short)2, "Course14", new Guid("ae0d9476-94fc-45af-8017-d93e8b1368d5"), new Guid("c6c1ba00-b0aa-47df-88f4-33af23ac06cb") },
                    { new Guid("2ac49b1f-619e-40d9-8884-722f017187fb"), (short)5, "Course0", new Guid("ae0d9476-94fc-45af-8017-d93e8b1368d5"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("20dd3a2c-4110-49f1-8a01-c3d512fc2f70"), (short)3, "Course13", new Guid("6adb62da-3b01-4757-b260-ddd2cf1d57de"), new Guid("4d6becdd-d8c4-409d-905b-e152c03679f2") },
                    { new Guid("e19394b2-2a73-4459-8e3b-0112c6069fca"), (short)5, "Course0", new Guid("6adb62da-3b01-4757-b260-ddd2cf1d57de"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("0602ce5f-d011-470a-b75a-761fee82dc51"), (short)0, "Course12", new Guid("45377600-9ee2-44cc-8217-60ae287409f2"), new Guid("47a375c2-c9b6-4013-8239-e327ab21d4ec") },
                    { new Guid("e68d9723-1173-48f9-9689-b34d2e173db6"), (short)1, "Course0", new Guid("45377600-9ee2-44cc-8217-60ae287409f2"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("0989ac48-092b-4d69-96b3-8e2c0e017c11"), (short)5, "Course11", new Guid("feb2ea5d-268a-4665-bacd-4db6939390a6"), new Guid("0f54ee42-1e4a-403c-89a7-9ed72d8f6725") },
                    { new Guid("ed617561-2956-4d5d-b264-7338128f9d76"), (short)2, "Course0", new Guid("feb2ea5d-268a-4665-bacd-4db6939390a6"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("597c9603-a866-4485-94a5-eddfbd36db61"), (short)0, "Course0", new Guid("c9099a6b-63bf-4cac-9c6b-79375bbe3abb"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("d884a640-059d-4bf7-8f7c-922808fa3f8d"), (short)1, "Course85", new Guid("56ff758d-1574-4779-821c-df8a31fb9c08"), new Guid("db11804c-38ec-4fc9-8136-dc47b7b789e3") },
                    { new Guid("88f73e08-9864-46ff-845d-88c939ee207d"), (short)5, "Course0", new Guid("58da87a9-c8e5-4be0-9c71-f9c9f73df7ba"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("3dddde4a-d8be-4037-9ce8-711c4ea8d25c"), (short)1, "Course0", new Guid("d996b970-5404-4738-a074-8687d8aa9912"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("9dc6bf86-df31-4d50-8dce-4d4f7e2ef3df"), (short)3, "Course73", new Guid("3d631240-7dd1-400f-b4a2-b15b0f338da6"), new Guid("b8280292-5d91-45f6-9e15-c45f342b22b9") },
                    { new Guid("72de68cd-bf0c-4df8-8de8-f975b8a7c463"), (short)4, "Course0", new Guid("3d631240-7dd1-400f-b4a2-b15b0f338da6"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("5b22f8ff-251f-4d2b-8092-d2271cc420e0"), (short)2, "Course72", new Guid("f8104e82-2073-497c-a097-cdf5a46d801c"), new Guid("d889d0ce-23d0-4a95-bd16-51e3a1cf0ce7") },
                    { new Guid("0370f251-3d1c-4e52-91ed-ed5417a2a05f"), (short)2, "Course0", new Guid("f8104e82-2073-497c-a097-cdf5a46d801c"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("9c5ccc3e-833d-4a83-8a48-e7f8e152c2e8"), (short)4, "Course71", new Guid("172ca027-bcce-40dc-94c5-e2c2f419fe61"), new Guid("92bf0ac3-63b0-4789-811f-24ef059c3653") },
                    { new Guid("cb6a2208-83f9-46d7-98de-1dd82182751a"), (short)1, "Course0", new Guid("172ca027-bcce-40dc-94c5-e2c2f419fe61"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("ea42fa70-e327-42d9-91e9-119c28fc1c2c"), (short)4, "Course70", new Guid("51f3469a-c46d-4f80-9b57-bd07ae06c11b"), new Guid("8ef9a447-3f54-4ebc-854d-d176e74601b4") },
                    { new Guid("4f0e67c0-a2cf-49b6-8c6b-18f4d2714be0"), (short)3, "Course0", new Guid("51f3469a-c46d-4f80-9b57-bd07ae06c11b"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("793ee2c9-5260-4fb5-bb3b-3d4ba8d7d659"), (short)4, "Course69", new Guid("ae0ff115-bac3-489a-855e-21275acbc7b2"), new Guid("962082e2-14d7-498d-80fb-2427625c671a") },
                    { new Guid("16efe7f8-637c-4001-b085-7f6bc077dfd0"), (short)4, "Course0", new Guid("ae0ff115-bac3-489a-855e-21275acbc7b2"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("20504184-23b5-44ff-aae2-17282ab6f2fd"), (short)1, "Course68", new Guid("036ba574-9c62-495d-b2c2-63c784cf5e02"), new Guid("af0a604d-1fc1-4e3f-b242-2acd97d398f3") },
                    { new Guid("265905c2-13ce-453d-97c8-78d8454ec116"), (short)2, "Course0", new Guid("036ba574-9c62-495d-b2c2-63c784cf5e02"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("8b0ec849-1b0f-48ce-ba0d-db23b9619410"), (short)0, "Course67", new Guid("6fe7d50f-6e56-4689-8556-63f45d71cca1"), new Guid("b26cb6d2-a318-447d-a303-57c481a8df2c") },
                    { new Guid("cc246783-4507-44ff-8950-3468e969c6a8"), (short)2, "Course0", new Guid("6fe7d50f-6e56-4689-8556-63f45d71cca1"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("013e1b00-7850-4f44-91c6-11aaa7600c11"), (short)5, "Course66", new Guid("25a05858-b0df-48b4-a719-2a20c674de64"), new Guid("fdb2981f-f449-49ef-bc96-5d7152ea43e0") },
                    { new Guid("4cf67d5d-1a97-443c-8fcb-618b3ba3f773"), (short)1, "Course0", new Guid("25a05858-b0df-48b4-a719-2a20c674de64"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("422d7a0f-ce2d-4883-b06c-51e77bdbb8d6"), (short)1, "Course65", new Guid("3f7c878b-3e55-43a6-97dd-5707171e320c"), new Guid("be501952-af82-4aa8-813c-ebe8bb64cd67") },
                    { new Guid("c3da7816-a54c-4825-9ef8-e5fce56b304f"), (short)0, "Course0", new Guid("02023a19-1a5c-422a-97b1-e37c596b2a1e"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("a597fe53-a0a6-4d70-9300-eda2080bd739"), (short)5, "Course74", new Guid("02023a19-1a5c-422a-97b1-e37c596b2a1e"), new Guid("6baee663-1d3a-4058-9a14-b4ed26be7e08") }
                });

            migrationBuilder.InsertData(
                table: "OptionalCourses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("ea0788ab-eaab-499b-8b95-6eeddc85df0b"), (short)2, "Course0", new Guid("6ed53c09-0724-4630-a692-3d2ee46146b1"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("9a386c8f-a267-47cb-b247-939e30070cf4"), (short)1, "Course75", new Guid("6ed53c09-0724-4630-a692-3d2ee46146b1"), new Guid("4b3c243d-26a2-430b-a779-cf81b39134eb") },
                    { new Guid("d2a91080-2333-4232-bbca-ee87b72a7d36"), (short)1, "Course84", new Guid("52e059ed-0b61-4f02-b827-247ce522fa88"), new Guid("ccb7a87a-5a14-4961-8ca6-8063675b2bce") },
                    { new Guid("e00fc931-736c-4319-93f7-6643fab7740d"), (short)5, "Course0", new Guid("52e059ed-0b61-4f02-b827-247ce522fa88"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("82ce6525-0775-411c-97a0-8276d26a7f7a"), (short)0, "Course83", new Guid("0c0a35f6-aa29-4fff-bad0-13404b5950d4"), new Guid("55bcdfb7-5436-425f-aa75-67ed0bec3c6d") },
                    { new Guid("bb223a04-bdf1-48d9-9aa4-5c502be90fc5"), (short)5, "Course0", new Guid("0c0a35f6-aa29-4fff-bad0-13404b5950d4"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("125e747f-d4f2-42e7-9f19-4b174767bc17"), (short)5, "Course82", new Guid("27c49487-1120-432b-b3ca-981af980749f"), new Guid("50e805fc-950a-4835-b29b-6cee79b22045") },
                    { new Guid("e831b4bc-5833-431a-a1c4-b702a4ac3fe4"), (short)2, "Course0", new Guid("27c49487-1120-432b-b3ca-981af980749f"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("1f79f698-75fe-4413-8220-4e9b34f7a344"), (short)0, "Course81", new Guid("4b5f9de0-1605-42c2-9fe8-afb7b0659bb1"), new Guid("64348b66-65ef-4051-a489-855fe874b9c0") },
                    { new Guid("d0292c1a-269f-4010-8eb4-647147da3836"), (short)5, "Course0", new Guid("4b5f9de0-1605-42c2-9fe8-afb7b0659bb1"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("3a47339d-1d47-412b-8e0d-1a8158cec96e"), (short)5, "Course0", new Guid("3f7c878b-3e55-43a6-97dd-5707171e320c"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("7aac4692-c699-42b3-9321-ac2a1c8c7038"), (short)0, "Course80", new Guid("379b9d39-d466-43ac-b988-8c27a2c65f15"), new Guid("2b9f0266-611a-4820-b5c7-8d1bd747f55b") },
                    { new Guid("f0db9352-a0e4-446c-a3ce-2262e9d6d5c2"), (short)0, "Course79", new Guid("609e61bd-5d31-48a8-9ed3-fefd675b1a08"), new Guid("2aeea0c4-8fec-45f9-a6b0-e00afbf6f983") },
                    { new Guid("c31a189e-2e76-4fd1-9502-f284f1930bb4"), (short)5, "Course0", new Guid("609e61bd-5d31-48a8-9ed3-fefd675b1a08"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("06fd311a-347d-4a37-ad7a-0bcbab9ac207"), (short)4, "Course78", new Guid("f519c8d3-23c9-4ae8-858f-3c9c51c06b58"), new Guid("ddd29bd3-3463-4300-aec9-f02ef123b657") },
                    { new Guid("ea69785b-47ac-4f05-8891-f2cb2c2ede9a"), (short)0, "Course0", new Guid("f519c8d3-23c9-4ae8-858f-3c9c51c06b58"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("1413771f-31de-4a39-b61e-44913db0a448"), (short)1, "Course77", new Guid("fc9fc9eb-7b60-460a-92d3-844feb48ef24"), new Guid("ef9025e8-8f9b-49e2-862f-d9f742990e86") },
                    { new Guid("9b1349aa-6a06-4477-8eaf-182bc959b697"), (short)2, "Course0", new Guid("fc9fc9eb-7b60-460a-92d3-844feb48ef24"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("0b1bda5f-3a78-45f9-a8c0-8e795cda8d0f"), (short)2, "Course76", new Guid("a034c62b-e1b1-4ee2-8950-92a3de59b61c"), new Guid("921e3f7f-7818-4f66-a546-133a47447022") },
                    { new Guid("b827067b-2fc6-47e1-af92-302ee48be7e5"), (short)5, "Course0", new Guid("a034c62b-e1b1-4ee2-8950-92a3de59b61c"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("2ffe7957-3a27-4abc-aaf1-8854dd440f0b"), (short)1, "Course0", new Guid("379b9d39-d466-43ac-b988-8c27a2c65f15"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("e6bc6f92-99ca-44b3-88db-2d04adfd1c0c"), (short)0, "Course64", new Guid("1ec7df37-22d1-4853-9d82-fb38c117840a"), new Guid("4ec77cc4-e026-4c2c-ab7a-924771e1fb57") },
                    { new Guid("b95dc705-b1ea-4849-8c04-49db1075940a"), (short)4, "Course0", new Guid("1ec7df37-22d1-4853-9d82-fb38c117840a"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("78d7d82e-9658-4ae8-aa74-1eb9869d6a5c"), (short)1, "Course63", new Guid("52beef09-20ce-4c37-ab89-94f2694cb95b"), new Guid("63af8a63-3d9f-4a25-8e2c-db885be41b6e") },
                    { new Guid("51a0f4fe-21e1-411a-82f0-544c3cf398da"), (short)4, "Course0", new Guid("4cc32661-5198-462d-a875-72e94db46c43"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("a6c68aa0-4673-43ae-8597-66802501c46f"), (short)1, "Course51", new Guid("8fe16bf2-da33-4ca5-9f7b-04698575b8c8"), new Guid("91ed7051-9e55-4279-96b3-f8be2e6efe11") },
                    { new Guid("6e594425-c454-4fc4-a43c-157fe1967345"), (short)2, "Course0", new Guid("8fe16bf2-da33-4ca5-9f7b-04698575b8c8"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("0d8a0935-e929-42ce-b7f5-f44fdc41d414"), (short)1, "Course50", new Guid("41098c2a-10e4-419d-bc3f-4a98fdcd9886"), new Guid("a92a7897-7ed2-4983-a5e7-33d72a168392") },
                    { new Guid("e2d313cb-52f1-46bf-8dbb-f52d6a754c38"), (short)5, "Course0", new Guid("41098c2a-10e4-419d-bc3f-4a98fdcd9886"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("a8ce02a5-1cf6-4957-9d81-bf041145645e"), (short)2, "Course49", new Guid("2c461059-c0ce-4014-8cda-322f87492aa6"), new Guid("0be65fce-7327-4fdb-97e8-4638e8061847") },
                    { new Guid("4b264ca0-b71b-4ca1-b580-3d791aa3c87b"), (short)3, "Course0", new Guid("2c461059-c0ce-4014-8cda-322f87492aa6"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("3f18b244-1030-4457-a2da-0a3763f75ba8"), (short)5, "Course48", new Guid("8241e5a3-9fd4-469c-8a3a-cafc329ef06f"), new Guid("0714acfd-7b85-4714-95a4-2693f68cc7fe") },
                    { new Guid("f55ac4ee-4333-4990-a121-9150f1e575a4"), (short)5, "Course52", new Guid("4cc32661-5198-462d-a875-72e94db46c43"), new Guid("cd4fcdd9-3743-4d8d-823d-c16e81bf7feb") },
                    { new Guid("df2d9127-a947-4eaa-a363-cb0121695e17"), (short)5, "Course0", new Guid("8241e5a3-9fd4-469c-8a3a-cafc329ef06f"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("7043b497-4ae4-4bf0-ba88-8ab4fe92056a"), (short)3, "Course0", new Guid("7b249737-e51c-4dec-8cbc-f80df205c401"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("084a7c2f-5877-4b32-8451-a365ec59cbc4"), (short)2, "Course46", new Guid("02e9c350-f74d-4f3c-82e2-d7b550aba073"), new Guid("07fe7183-eeba-4290-ad4f-98cacee625ea") },
                    { new Guid("498bd2ec-1f07-43fb-a04a-d74ecaf0bacd"), (short)5, "Course0", new Guid("02e9c350-f74d-4f3c-82e2-d7b550aba073"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("29d594d1-b26f-4d59-92a2-1ac679cc0b0c"), (short)4, "Course45", new Guid("f19afed3-7e28-4f8b-9c27-f9ee51eba060"), new Guid("8ec1697b-d4d9-4c6c-8d7e-a7a369a05831") },
                    { new Guid("f9a6313c-6f65-4883-9a47-dd7098a33406"), (short)2, "Course0", new Guid("f19afed3-7e28-4f8b-9c27-f9ee51eba060"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("9b6300d8-b20e-4896-9298-f5cb30fb88dc"), (short)5, "Course44", new Guid("1ce051c7-7ad8-40fa-ad37-1cfe72f03558"), new Guid("e8405a7e-6809-4ac1-951d-03781410be97") },
                    { new Guid("0a7d99de-d702-4064-86cd-1605a3245db9"), (short)5, "Course0", new Guid("1ce051c7-7ad8-40fa-ad37-1cfe72f03558"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("9b712f62-b665-4e55-adda-c17301cea5b1"), (short)1, "Course43", new Guid("d996b970-5404-4738-a074-8687d8aa9912"), new Guid("b6fa213a-f7e3-453c-8d0c-7f4e3fbda256") }
                });

            migrationBuilder.InsertData(
                table: "OptionalCourses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("f9d08c50-6ae4-4807-87be-d6c0a6d9b24b"), (short)3, "Course47", new Guid("7b249737-e51c-4dec-8cbc-f80df205c401"), new Guid("e05af25e-082a-4b80-a28f-832214ce10bc") },
                    { new Guid("640e8cb9-0161-4ade-8227-34c6899f9589"), (short)3, "Course42", new Guid("58da87a9-c8e5-4be0-9c71-f9c9f73df7ba"), new Guid("b589b9ab-99a7-42e6-ada6-d1d692d94214") },
                    { new Guid("13291a2b-aea0-4004-980d-433f87b4de5d"), (short)5, "Course0", new Guid("49fd7f4c-a8ca-45d5-bbe0-55ef9faca700"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("088a8289-d2fd-4aa7-aa22-db7c180b628d"), (short)2, "Course0", new Guid("d7adb406-72ae-402a-ae73-f0e1e225e352"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("072e4c74-e79d-45f8-8f03-9bc19ef35750"), (short)0, "Course0", new Guid("52beef09-20ce-4c37-ab89-94f2694cb95b"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("28a2e68c-938d-487f-9a7c-3027d02ca1e8"), (short)4, "Course62", new Guid("fc5fcbac-a0b5-4059-8e1b-d396aa269a67"), new Guid("63d077b3-c8e6-414f-9036-959e8c825846") },
                    { new Guid("a0177edd-7540-4744-8a34-0503fb1ff785"), (short)1, "Course0", new Guid("fc5fcbac-a0b5-4059-8e1b-d396aa269a67"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("fe85f486-168f-4da3-855c-6dab060c484c"), (short)2, "Course61", new Guid("f0943399-5999-49bf-9fc0-642a5922a0bc"), new Guid("015f56f9-e4b3-41dc-adb6-ee2f90ec89cf") },
                    { new Guid("6385a242-98be-450d-b119-5a0c3ef5acc7"), (short)4, "Course0", new Guid("f0943399-5999-49bf-9fc0-642a5922a0bc"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("a5e730e2-511f-4564-a61f-d1f8b46ce3b4"), (short)2, "Course60", new Guid("f33058bb-8a16-4cde-9306-f2868506d4e9"), new Guid("6b5a6b95-6bd0-4340-babb-e56e9ac0171d") },
                    { new Guid("15b706d9-f6a8-4dc6-9d5c-fbcc1f9802aa"), (short)0, "Course0", new Guid("f33058bb-8a16-4cde-9306-f2868506d4e9"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("3e8e6057-6cd2-4e65-a3dd-50249a221f6c"), (short)1, "Course59", new Guid("34ec0591-8ec4-4c9c-9cd9-fa70ef5a2483"), new Guid("a90c16da-5d98-417b-b25e-97a364bd5cf8") },
                    { new Guid("d8c5bff6-d63b-47ea-bb3d-450c700b02b0"), (short)2, "Course0", new Guid("22dba56e-6888-463d-9228-fab9730af92f"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("f2f2e917-606b-40c6-a212-ebc7bb47884c"), (short)0, "Course0", new Guid("34ec0591-8ec4-4c9c-9cd9-fa70ef5a2483"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("d1c23e05-de43-4d4f-a7b6-7523cbcbbf50"), (short)0, "Course0", new Guid("6f27750f-59c8-4752-af90-d58085785dbd"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("aef6ea87-bb4e-4d29-b687-d7dc61341634"), (short)0, "Course57", new Guid("41a946ba-8472-4abc-98dc-136ad09a5119"), new Guid("8762d3cf-d975-4550-b61c-1b891a10d890") },
                    { new Guid("086eb4ce-86da-400b-949a-83ab24bc5d53"), (short)5, "Course0", new Guid("41a946ba-8472-4abc-98dc-136ad09a5119"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("8999f0db-1c02-4f2f-8014-0df615ff4762"), (short)4, "Course56", new Guid("370a7847-1322-49dd-a10e-c2715f4d761c"), new Guid("ba1fcd39-4e90-42d6-a1f1-d52be00852c8") },
                    { new Guid("4e39e14d-4b35-413b-b3b7-68a0e21b18d2"), (short)0, "Course0", new Guid("370a7847-1322-49dd-a10e-c2715f4d761c"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("588adb53-1e1d-4e72-bdc2-d6666273046c"), (short)3, "Course55", new Guid("64fad46b-9d9d-4f26-812c-5c78eea8b243"), new Guid("42be7409-d3d8-4bfd-880e-2d18372f07d6") },
                    { new Guid("2f2deccc-9313-4aaf-ada7-89e4ac0d117e"), (short)1, "Course0", new Guid("64fad46b-9d9d-4f26-812c-5c78eea8b243"), new Guid("d520389d-d791-479c-a509-27d5bb244858") },
                    { new Guid("c1e3c36a-0eb3-4651-b4ec-61662a6204d6"), (short)0, "Course54", new Guid("d7adb406-72ae-402a-ae73-f0e1e225e352"), new Guid("471b80b9-dd36-4a48-89c2-39b5941f439d") },
                    { new Guid("5c688c66-713c-4c5b-83aa-bb079a1efdf9"), (short)5, "Course58", new Guid("6f27750f-59c8-4752-af90-d58085785dbd"), new Guid("0eafc5e8-bb25-43ce-aa71-fac4ee547b1c") },
                    { new Guid("f3c64975-3db8-4e33-8f49-416980d83fb7"), (short)5, "Course107", new Guid("22dba56e-6888-463d-9228-fab9730af92f"), new Guid("6276add9-6269-4d1e-a285-a51ada727742") }
                });

            migrationBuilder.InsertData(
                table: "StudyContracts",
                columns: new[] { "Id", "GroupId", "OptionalCourseId", "SignedAt", "StudentId", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("659c0c9f-9be2-48d1-8fc7-7197aabeb562"), new Guid("62cbcb67-5f17-4f2b-9442-00f25f885c40"), new Guid("5acff67f-321b-4a0a-97d2-949b01371b9b"), 1647781930L, new Guid("8e0e2189-5374-4025-b8f6-51207e345bcb"), null },
                    { new Guid("fe9e5805-e38c-4ec4-bedf-df8f57112031"), new Guid("b65ee02f-13fd-406b-ab3d-2f196d23fa53"), new Guid("72de68cd-bf0c-4df8-8de8-f975b8a7c463"), 1647781930L, new Guid("de89dd7a-ab66-4c01-b33b-51b469b1de87"), null },
                    { new Guid("cb704f1e-5a2a-4da8-baf3-289cd4d88094"), new Guid("096f4d5b-2dd0-48d6-a9c1-a82f8fb067a5"), new Guid("5b22f8ff-251f-4d2b-8092-d2271cc420e0"), 1647781930L, new Guid("a5a8add7-64aa-4a2c-b735-2f597e575147"), null },
                    { new Guid("d8c690e6-92ce-449e-8dbb-2c9a809d3357"), new Guid("b65ee02f-13fd-406b-ab3d-2f196d23fa53"), new Guid("0370f251-3d1c-4e52-91ed-ed5417a2a05f"), 1647781930L, new Guid("872a482d-753f-47f5-a7f3-8bc43e2d9fb1"), null },
                    { new Guid("35a63c4c-44cb-45ec-b713-6bd436f5a7e5"), new Guid("9e16a3ec-34e2-4748-a79e-61e77774055f"), new Guid("0370f251-3d1c-4e52-91ed-ed5417a2a05f"), 1647781930L, new Guid("569d1736-12d0-47a0-a7c9-d404c7c25112"), null },
                    { new Guid("5a0dd12e-7548-44e3-8afb-32818a7c0eb6"), new Guid("b63b1bd2-28fb-4de5-8a07-d73eb3263cb8"), new Guid("9c5ccc3e-833d-4a83-8a48-e7f8e152c2e8"), 1647781930L, new Guid("783cb4aa-afaa-459f-89de-244701b37a0a"), null },
                    { new Guid("45cde019-e17d-4583-841a-23d3bed470de"), new Guid("edd60f8a-5bc6-48d4-ad5c-ff76382a3749"), new Guid("9c5ccc3e-833d-4a83-8a48-e7f8e152c2e8"), 1647781930L, new Guid("eb981660-a462-4f74-b527-2d6ff4ea3223"), null },
                    { new Guid("1d55aaf5-aa99-46e5-8080-af736be4a047"), new Guid("fbe9bb9a-15b2-40c2-8095-580acfe6e9b4"), new Guid("cb6a2208-83f9-46d7-98de-1dd82182751a"), 1647781930L, new Guid("4e25fbfe-0e0d-4ed3-b194-5e3ba951bad9"), null },
                    { new Guid("5be20729-56b8-49ba-b8d4-24eb51061fa3"), new Guid("9e16a3ec-34e2-4748-a79e-61e77774055f"), new Guid("72de68cd-bf0c-4df8-8de8-f975b8a7c463"), 1647781930L, new Guid("5134e1ce-26b6-4fed-a0c7-bd91daa55b43"), null },
                    { new Guid("b9efc199-7afa-49e5-93e3-099a779ac4f1"), new Guid("edd60f8a-5bc6-48d4-ad5c-ff76382a3749"), new Guid("ea42fa70-e327-42d9-91e9-119c28fc1c2c"), 1647781930L, new Guid("a2a887fe-7e7b-4341-b8dd-19766d16e04c"), null },
                    { new Guid("ef731237-7d40-4b88-8ba3-a97215a3e4b2"), new Guid("fbe9bb9a-15b2-40c2-8095-580acfe6e9b4"), new Guid("4f0e67c0-a2cf-49b6-8c6b-18f4d2714be0"), 1647781930L, new Guid("6db9fc75-fc1e-4b3e-b4b3-1b4ff0a2f0ed"), null },
                    { new Guid("6edc1529-acb3-4402-b57d-061753144a86"), new Guid("7ac752f1-191b-4834-927c-8d0833e9faea"), new Guid("793ee2c9-5260-4fb5-bb3b-3d4ba8d7d659"), 1647781930L, new Guid("8c0ce950-4e74-44dd-b6a4-f21f74df87f9"), null },
                    { new Guid("5a482e24-6fdf-4a96-84e0-159ef7954ec2"), new Guid("4f6608fb-8035-41e0-8731-f442cf062415"), new Guid("16efe7f8-637c-4001-b085-7f6bc077dfd0"), 1647781930L, new Guid("4d3a1b4b-c984-4aa9-a192-e7fbc113e1c4"), null },
                    { new Guid("7788d9ff-a146-4236-986f-23d59d33d32b"), new Guid("d5f1bea8-f1a2-4dc4-952c-86dd5c55062c"), new Guid("16efe7f8-637c-4001-b085-7f6bc077dfd0"), 1647781930L, new Guid("b4c5f4ed-6d5e-4755-b911-43eebcacda5f"), null },
                    { new Guid("4d181752-a138-4f6d-b0d0-82525d6f01ce"), new Guid("7ac752f1-191b-4834-927c-8d0833e9faea"), new Guid("20504184-23b5-44ff-aae2-17282ab6f2fd"), 1647781930L, new Guid("59ba496a-844e-4aa2-82cc-a0f838143dc4"), null },
                    { new Guid("b02349e3-b917-4d82-a935-52d1d728048d"), new Guid("d5f1bea8-f1a2-4dc4-952c-86dd5c55062c"), new Guid("265905c2-13ce-453d-97c8-78d8454ec116"), 1647781930L, new Guid("d7a78302-2999-4117-8863-905b6d6885ec"), null },
                    { new Guid("1a618e2b-0b15-4eed-b551-171046b09b14"), new Guid("4f6608fb-8035-41e0-8731-f442cf062415"), new Guid("265905c2-13ce-453d-97c8-78d8454ec116"), 1647781930L, new Guid("3f4dff8f-2572-4eb8-89ba-73b9596024d7"), null },
                    { new Guid("3231bde7-5a0a-46c6-a52f-4608f40c9f85"), new Guid("b63b1bd2-28fb-4de5-8a07-d73eb3263cb8"), new Guid("ea42fa70-e327-42d9-91e9-119c28fc1c2c"), 1647781930L, new Guid("327387fd-7b3c-42b9-8d0f-1b350148e96c"), null },
                    { new Guid("395f0a2a-ee73-426f-acee-5c6b3c8daf96"), new Guid("096f4d5b-2dd0-48d6-a9c1-a82f8fb067a5"), new Guid("9dc6bf86-df31-4d50-8dce-4d4f7e2ef3df"), 1647781930L, new Guid("160d61bb-b4eb-4122-8190-fe1f5dc1a231"), null },
                    { new Guid("f2298c11-7cd2-4cab-9c10-275e48811703"), new Guid("d770c30c-6912-4640-9de1-0d8cfc87aef9"), new Guid("c3da7816-a54c-4825-9ef8-e5fce56b304f"), 1647781930L, new Guid("d285a66b-b98b-42e5-adac-95e9838a7f6d"), null },
                    { new Guid("f69ac0cd-5e88-4dcc-9362-d4ef167b913e"), new Guid("cfedd346-fc6a-4954-9b89-280e4ae476bb"), new Guid("a597fe53-a0a6-4d70-9300-eda2080bd739"), 1647781930L, new Guid("453cd121-87f0-444e-a4c0-10a4beb11f49"), null },
                    { new Guid("7ab712ac-982c-4c87-b78b-340c9e3233d4"), new Guid("1a8cd514-fb97-446e-9396-a5af59929df6"), new Guid("2ffe7957-3a27-4abc-aaf1-8854dd440f0b"), 1647781930L, new Guid("968d81c5-f9d0-4cbb-9d55-928cc83498eb"), null },
                    { new Guid("a96f357f-ebfd-4535-a5c5-31f7fb614eaf"), new Guid("98902e90-eb7a-46f0-9451-586052c216b6"), new Guid("f0db9352-a0e4-446c-a3ce-2262e9d6d5c2"), 1647781930L, new Guid("487ec70a-b54e-4a31-8b7b-c01ffb606505"), null },
                    { new Guid("75d4cf78-fd81-4832-ae91-073166ecf057"), new Guid("79732f55-f50d-4034-91d0-89e7c5985d34"), new Guid("f0db9352-a0e4-446c-a3ce-2262e9d6d5c2"), 1647781930L, new Guid("dc42ee9a-f036-4860-b625-c2abe67475ab"), null },
                    { new Guid("670c8b72-bc1c-4f1e-9435-330bad3fb3a2"), new Guid("718ceab4-03a0-4f68-866f-8861c531fb8a"), new Guid("c31a189e-2e76-4fd1-9502-f284f1930bb4"), 1647781930L, new Guid("d7d3e120-2400-4fca-ab64-99e754c8039a"), null },
                    { new Guid("19a856cc-b54c-4a35-bf32-806da81b705b"), new Guid("79732f55-f50d-4034-91d0-89e7c5985d34"), new Guid("06fd311a-347d-4a37-ad7a-0bcbab9ac207"), 1647781930L, new Guid("bae39c79-1c1d-4779-bce0-7559ef2b9cb9"), null },
                    { new Guid("21040d7f-9bf8-4c45-9f39-ef048ae258c0"), new Guid("98902e90-eb7a-46f0-9451-586052c216b6"), new Guid("06fd311a-347d-4a37-ad7a-0bcbab9ac207"), 1647781930L, new Guid("46b827f8-0528-4747-8e42-a82d587cd9db"), null },
                    { new Guid("83066b48-9dc9-414f-b14e-fd9a5283c2dc"), new Guid("718ceab4-03a0-4f68-866f-8861c531fb8a"), new Guid("ea69785b-47ac-4f05-8891-f2cb2c2ede9a"), 1647781930L, new Guid("9a595c28-592b-442a-814e-72654cc3e8e9"), null },
                    { new Guid("fcdd40b3-cb42-4b0e-a591-b0110d60b4ae"), new Guid("05916953-3275-42de-8aa8-e06a948ebc1f"), new Guid("1413771f-31de-4a39-b61e-44913db0a448"), 1647781930L, new Guid("a0bee3b3-e030-4f4b-93cd-0b1da3e772b3"), null },
                    { new Guid("055d42ce-fb4a-4e70-a9b8-9e799a548bcb"), new Guid("396d465e-07ac-445e-a021-fa91cb34fb4e"), new Guid("9b1349aa-6a06-4477-8eaf-182bc959b697"), 1647781930L, new Guid("1da7b03b-3e5c-4a26-9b0a-67393f1845cc"), null },
                    { new Guid("dfae652d-baef-4e55-a88d-865c5f8397e9"), new Guid("52907d3c-65ba-4fba-91b4-50b8a7f3a4c6"), new Guid("9b1349aa-6a06-4477-8eaf-182bc959b697"), 1647781930L, new Guid("5d6d0787-c41c-4074-b4c7-f1a7466cbc80"), null },
                    { new Guid("4205c971-c110-4e82-a718-d109901155a4"), new Guid("05916953-3275-42de-8aa8-e06a948ebc1f"), new Guid("0b1bda5f-3a78-45f9-a8c0-8e795cda8d0f"), 1647781930L, new Guid("7989cd9d-ba2c-4b09-8ba2-bb38f055d08c"), null },
                    { new Guid("b2acd2e7-6a13-4ab0-9943-cfb585306500"), new Guid("52907d3c-65ba-4fba-91b4-50b8a7f3a4c6"), new Guid("b827067b-2fc6-47e1-af92-302ee48be7e5"), 1647781930L, new Guid("5b051fdf-aee4-4a0d-874e-5db5b83eff46"), null },
                    { new Guid("f4afbdea-f857-4cc2-ad3c-5d91297dc454"), new Guid("396d465e-07ac-445e-a021-fa91cb34fb4e"), new Guid("b827067b-2fc6-47e1-af92-302ee48be7e5"), 1647781930L, new Guid("4faeaa19-6a39-4988-875e-ab5948b470f0"), null },
                    { new Guid("03a5a942-e76a-4367-97a0-732e9bcf0b7c"), new Guid("cfedd346-fc6a-4954-9b89-280e4ae476bb"), new Guid("9a386c8f-a267-47cb-b247-939e30070cf4"), 1647781930L, new Guid("403bd0cb-6c38-496b-a0ab-f2d2c48f91f2"), null },
                    { new Guid("35454035-d0ff-4a92-8286-65d1fa85b84f"), new Guid("f50126be-a3eb-4225-8bcf-38758c8d9cb1"), new Guid("9a386c8f-a267-47cb-b247-939e30070cf4"), 1647781930L, new Guid("8a71b582-13e4-4e0d-a661-e00cb1b7432e"), null },
                    { new Guid("717db7e6-37a3-4a39-86dc-2a8a8a37c2c3"), new Guid("d770c30c-6912-4640-9de1-0d8cfc87aef9"), new Guid("ea0788ab-eaab-499b-8b95-6eeddc85df0b"), 1647781930L, new Guid("c49f0fcc-63f5-4ddd-8e39-011e5eea7bb1"), null },
                    { new Guid("9ab9032e-0101-4bc3-a87b-b9f72679a0ee"), new Guid("f50126be-a3eb-4225-8bcf-38758c8d9cb1"), new Guid("a597fe53-a0a6-4d70-9300-eda2080bd739"), 1647781930L, new Guid("7535c9e5-8337-440a-9931-2abc739f8d6b"), null },
                    { new Guid("21ae630a-3d2a-49cb-88c9-65adb6616eb5"), new Guid("05035b0e-0c15-48ed-afbc-c1afc5f0cabc"), new Guid("8b0ec849-1b0f-48ce-ba0d-db23b9619410"), 1647781930L, new Guid("5dc5b31a-2796-4094-a7d9-575e300b0afe"), null },
                    { new Guid("66be67d7-ffb5-4440-9c2a-edfb3d5e6dc7"), new Guid("9f89c1de-57e7-44d5-a551-98b06bef6109"), new Guid("8b0ec849-1b0f-48ce-ba0d-db23b9619410"), 1647781930L, new Guid("e0b609ea-aa32-44f3-addd-6cc9cb6c1576"), null },
                    { new Guid("9ac237c3-396c-4d50-840a-6c6890990c9a"), new Guid("124233e7-080b-42a8-8ec8-77e1a7bbc9c4"), new Guid("cc246783-4507-44ff-8950-3468e969c6a8"), 1647781930L, new Guid("01fab89e-aee2-4c68-8b07-69202835eebc"), null },
                    { new Guid("31981f06-625c-497e-bb8a-e96d4a9134a9"), new Guid("9f89c1de-57e7-44d5-a551-98b06bef6109"), new Guid("013e1b00-7850-4f44-91c6-11aaa7600c11"), 1647781930L, new Guid("ae25e307-db05-481f-aa06-2becaa25783f"), null }
                });

            migrationBuilder.InsertData(
                table: "StudyContracts",
                columns: new[] { "Id", "GroupId", "OptionalCourseId", "SignedAt", "StudentId", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("8d5dbdb6-ecaa-4d9c-9de1-b6af80182c81"), new Guid("e13d694c-56d9-40c1-a71d-3ca81aad9974"), new Guid("3e8e6057-6cd2-4e65-a3dd-50249a221f6c"), 1647781930L, new Guid("027822bd-e570-480a-8a15-b5a584d02fa4"), null },
                    { new Guid("d12b8418-a448-40fd-84c0-243ec06fad59"), new Guid("4470ecff-cc78-4204-9cdd-2c9821328f65"), new Guid("3e8e6057-6cd2-4e65-a3dd-50249a221f6c"), 1647781930L, new Guid("1f8d5abe-daa1-476d-98cf-622a9f45c4c4"), null },
                    { new Guid("04a8546a-f448-4ed9-9706-f2dcabfcb8b0"), new Guid("c3da6eb0-ae21-4904-9eaf-1c7b47f4613a"), new Guid("f2f2e917-606b-40c6-a212-ebc7bb47884c"), 1647781930L, new Guid("18ef1291-93ea-4f80-b78e-99dce5655853"), null },
                    { new Guid("3bcaad06-e6fa-4b9c-94c5-5b7919ca17c7"), new Guid("41b1c5c1-d2ef-422d-a47b-e1a333bb5546"), new Guid("f2f2e917-606b-40c6-a212-ebc7bb47884c"), 1647781930L, new Guid("18ef1291-93ea-4f80-b78e-99dce5655853"), null },
                    { new Guid("21f78ab8-8fd3-4e1a-bc98-e9443519f6c7"), new Guid("4470ecff-cc78-4204-9cdd-2c9821328f65"), new Guid("5c688c66-713c-4c5b-83aa-bb079a1efdf9"), 1647781930L, new Guid("20f0c76e-50ef-4b6c-9cf6-e78ece3ba113"), null },
                    { new Guid("207552e4-6426-4d79-9eb8-8064e70fc9b4"), new Guid("e13d694c-56d9-40c1-a71d-3ca81aad9974"), new Guid("5c688c66-713c-4c5b-83aa-bb079a1efdf9"), 1647781930L, new Guid("c2bc1dd8-6eb7-460d-8dc4-3fe5eccc24a0"), null },
                    { new Guid("5f79bd92-8fab-4dca-ab02-7aa57a78ab87"), new Guid("41b1c5c1-d2ef-422d-a47b-e1a333bb5546"), new Guid("d1c23e05-de43-4d4f-a7b6-7523cbcbbf50"), 1647781930L, new Guid("bb83e0e2-a245-4253-8ad6-433d65b84031"), null },
                    { new Guid("b411e29c-72b8-437f-aeba-a9271f05d8a8"), new Guid("d491d7d9-89b3-443b-9a4b-92d6deed94aa"), new Guid("aef6ea87-bb4e-4d29-b687-d7dc61341634"), 1647781930L, new Guid("61731a1e-ddae-4771-adec-d1e909316d2d"), null },
                    { new Guid("e9fc5fa4-da0b-42e1-b290-628256a630c8"), new Guid("71317992-d07e-46bc-b4bd-08015be611e3"), new Guid("086eb4ce-86da-400b-949a-83ab24bc5d53"), 1647781930L, new Guid("7f3003dc-a33f-4d63-b1ce-b356142de5d6"), null },
                    { new Guid("ee6f0c9c-ec6a-430c-9ae7-fc93e4e74d43"), new Guid("37079549-de56-48c6-ba23-852f8dc5dabf"), new Guid("086eb4ce-86da-400b-949a-83ab24bc5d53"), 1647781930L, new Guid("efe3adef-fe2c-4659-9796-f66fc524f45f"), null },
                    { new Guid("7d07b3ce-57d0-42d9-b555-db160f543748"), new Guid("d491d7d9-89b3-443b-9a4b-92d6deed94aa"), new Guid("8999f0db-1c02-4f2f-8014-0df615ff4762"), 1647781930L, new Guid("4ea85f44-5fcf-4ae5-afba-297b2201cf9a"), null },
                    { new Guid("de116dc7-dc09-46ca-a054-8c5f2bf03eff"), new Guid("37079549-de56-48c6-ba23-852f8dc5dabf"), new Guid("4e39e14d-4b35-413b-b3b7-68a0e21b18d2"), 1647781930L, new Guid("8afe67c9-5ea9-4b81-a327-bd3a8576a3dc"), null },
                    { new Guid("ef4ea63d-fbda-4c07-ad8a-724e1fc7897a"), new Guid("71317992-d07e-46bc-b4bd-08015be611e3"), new Guid("4e39e14d-4b35-413b-b3b7-68a0e21b18d2"), 1647781930L, new Guid("a17a90ca-5e60-4b66-845c-74014cec6ee3"), null },
                    { new Guid("4d3fccf0-46d7-404c-be4e-f2577342c6f2"), new Guid("83d4325e-c5e0-4383-8599-f5a37c7a8c50"), new Guid("588adb53-1e1d-4e72-bdc2-d6666273046c"), 1647781930L, new Guid("07a24a57-e399-4bdf-943a-4c6d1167b9c6"), null },
                    { new Guid("7929d579-68af-4561-b905-7583a085788a"), new Guid("e7ea80e9-a52d-4349-980c-949ef688f788"), new Guid("588adb53-1e1d-4e72-bdc2-d6666273046c"), 1647781930L, new Guid("955fa333-9b43-4fa7-9329-01f29609ea7b"), null },
                    { new Guid("0e57bf88-3d18-48e9-aefa-9764b9c05167"), new Guid("6432bd10-fccd-401a-bef9-bdc2ccda38fb"), new Guid("2f2deccc-9313-4aaf-ada7-89e4ac0d117e"), 1647781930L, new Guid("20c81011-191a-4c09-973b-0e2eabbfcf80"), null },
                    { new Guid("0681a514-8744-47bf-9488-99107fceb897"), new Guid("e7ea80e9-a52d-4349-980c-949ef688f788"), new Guid("c1e3c36a-0eb3-4651-b4ec-61662a6204d6"), 1647781930L, new Guid("7cb805ee-825e-46cc-bd4c-4cf60718eb11"), null },
                    { new Guid("e75ce8a5-ea2a-4861-a248-80e47e55c216"), new Guid("67ebb07b-3678-44ea-a38c-ec827a8410d6"), new Guid("15b706d9-f6a8-4dc6-9d5c-fbcc1f9802aa"), 1647781930L, new Guid("b12ba677-c23e-418e-93f2-3e253fd45a88"), null },
                    { new Guid("75c6702e-a6d8-4452-a0e7-823b754a1939"), new Guid("1a871327-f40a-48ff-8feb-973e7033ea01"), new Guid("2ffe7957-3a27-4abc-aaf1-8854dd440f0b"), 1647781930L, new Guid("14034147-6a87-4dbf-880e-520ad22bf330"), null },
                    { new Guid("074c1783-a8d6-40b0-90cf-18c58df7bccd"), new Guid("91f98255-fa8d-4a28-9745-decf9c91b928"), new Guid("15b706d9-f6a8-4dc6-9d5c-fbcc1f9802aa"), 1647781930L, new Guid("cf6f93fe-b14f-4f6d-9294-d7afb5b60523"), null },
                    { new Guid("92f78b29-1f64-4e14-a2a2-41088d7f1e58"), new Guid("91f98255-fa8d-4a28-9745-decf9c91b928"), new Guid("6385a242-98be-450d-b119-5a0c3ef5acc7"), 1647781930L, new Guid("72174b2b-530c-4f9d-a934-9085d0694ef9"), null },
                    { new Guid("5afce716-ea09-4f4a-8f00-00b240486dcc"), new Guid("05035b0e-0c15-48ed-afbc-c1afc5f0cabc"), new Guid("013e1b00-7850-4f44-91c6-11aaa7600c11"), 1647781930L, new Guid("3b39b3fd-9031-4b82-979b-b5e2bb597871"), null },
                    { new Guid("56b66103-56a9-44c1-ba88-69d86e336e5f"), new Guid("1ea2740e-d501-4ced-9a27-eb06287c97bd"), new Guid("4cf67d5d-1a97-443c-8fcb-618b3ba3f773"), 1647781930L, new Guid("baae8c9f-ed52-4842-ab91-7ef98ac9012d"), null },
                    { new Guid("67cc6f7b-0d7e-4ba5-acab-89c73536f2b0"), new Guid("124233e7-080b-42a8-8ec8-77e1a7bbc9c4"), new Guid("4cf67d5d-1a97-443c-8fcb-618b3ba3f773"), 1647781930L, new Guid("baae8c9f-ed52-4842-ab91-7ef98ac9012d"), null },
                    { new Guid("9788cf4a-431b-411a-9928-6e942567876c"), new Guid("f56ce2e1-c474-4cf8-ac0c-45405f71f4d9"), new Guid("422d7a0f-ce2d-4883-b06c-51e77bdbb8d6"), 1647781930L, new Guid("3972f777-d431-401c-a7d9-5e1acfd05141"), null },
                    { new Guid("ad143e96-87d7-47d1-97ab-cb352de975d0"), new Guid("623cdfc9-d7e8-4f31-8fd3-f9bb1c5d33a9"), new Guid("3a47339d-1d47-412b-8e0d-1a8158cec96e"), 1647781930L, new Guid("66914d46-a3ff-42e5-9482-9a0cbd02912d"), null },
                    { new Guid("e6e53eaf-7e4a-4b6a-8d9b-12c0d0149c72"), new Guid("c17175ac-0712-4855-a2f7-5b64f8502340"), new Guid("3a47339d-1d47-412b-8e0d-1a8158cec96e"), 1647781930L, new Guid("0eccb1ed-df7f-47bc-874e-f9be50a6e2d1"), null },
                    { new Guid("36c7e3d1-cde8-44e2-824b-8a67a2531802"), new Guid("f56ce2e1-c474-4cf8-ac0c-45405f71f4d9"), new Guid("e6bc6f92-99ca-44b3-88db-2d04adfd1c0c"), 1647781930L, new Guid("36c1f06d-9cc7-47e2-9c3e-7c44a569f1a0"), null },
                    { new Guid("6356540b-37bd-4c38-bece-495ca2f5ef46"), new Guid("c17175ac-0712-4855-a2f7-5b64f8502340"), new Guid("b95dc705-b1ea-4849-8c04-49db1075940a"), 1647781930L, new Guid("30424b48-0a19-4374-9ee4-85d56710a043"), null },
                    { new Guid("99e8a2af-b045-407e-8cf0-551730832bff"), new Guid("623cdfc9-d7e8-4f31-8fd3-f9bb1c5d33a9"), new Guid("b95dc705-b1ea-4849-8c04-49db1075940a"), 1647781930L, new Guid("71256187-2515-46fd-825a-efcbba5066b4"), null },
                    { new Guid("ccc8a570-d7d0-4f24-9ac7-c25a2675556b"), new Guid("f5ed8500-c11d-4f0f-8e48-e74b69224c12"), new Guid("78d7d82e-9658-4ae8-aa74-1eb9869d6a5c"), 1647781930L, new Guid("bbdc9601-9917-47cf-bf3b-054ccb3885aa"), null },
                    { new Guid("23e73f6c-fc76-4145-9da9-317fa4386d7e"), new Guid("ff7c04a2-5eeb-4fb3-a0ee-cc08d315d567"), new Guid("78d7d82e-9658-4ae8-aa74-1eb9869d6a5c"), 1647781930L, new Guid("6c6064f2-6066-42a0-9122-fe6d38ee9332"), null },
                    { new Guid("96f2dac2-cad8-4e41-8c49-35b9dfdcc1d6"), new Guid("b1016c6f-24b4-4dce-9a06-cba81c7407f9"), new Guid("072e4c74-e79d-45f8-8f03-9bc19ef35750"), 1647781930L, new Guid("8980183f-e781-4fe8-abb8-e5314452fb20"), null },
                    { new Guid("9a9b1f88-9458-4ef1-8de7-656cdf855edf"), new Guid("ff7c04a2-5eeb-4fb3-a0ee-cc08d315d567"), new Guid("28a2e68c-938d-487f-9a7c-3027d02ca1e8"), 1647781930L, new Guid("aef90b6a-bd3a-4486-bec0-1c41d2c7f103"), null },
                    { new Guid("f1712e45-37b6-44cb-afd6-a6ed1fabf022"), new Guid("f5ed8500-c11d-4f0f-8e48-e74b69224c12"), new Guid("28a2e68c-938d-487f-9a7c-3027d02ca1e8"), 1647781930L, new Guid("09d18b54-641b-41c3-a496-2063e0bb4b4e"), null },
                    { new Guid("16fb3995-5900-45a0-b101-008737977bf5"), new Guid("b1016c6f-24b4-4dce-9a06-cba81c7407f9"), new Guid("a0177edd-7540-4744-8a34-0503fb1ff785"), 1647781930L, new Guid("73d5914f-57d9-4704-aadb-8b9e4df4f80d"), null },
                    { new Guid("c06a3163-c04a-4004-ad4c-fce8e95da4e5"), new Guid("14a449d5-2b7d-4857-b167-f326ec5964e2"), new Guid("fe85f486-168f-4da3-855c-6dab060c484c"), 1647781930L, new Guid("392d2f6e-c8c2-435e-9cc7-f2a5db0b0099"), null },
                    { new Guid("7f5a957a-4c29-4d18-8dcf-31c741fbf7ed"), new Guid("67ebb07b-3678-44ea-a38c-ec827a8410d6"), new Guid("6385a242-98be-450d-b119-5a0c3ef5acc7"), 1647781930L, new Guid("6540d709-9e28-4f27-afa2-75a3d133035c"), null },
                    { new Guid("299d8da0-5833-4b34-82ad-b138e53d73c8"), new Guid("14a449d5-2b7d-4857-b167-f326ec5964e2"), new Guid("a5e730e2-511f-4564-a61f-d1f8b46ce3b4"), 1647781930L, new Guid("f118d66a-6f65-49a9-8bba-b6d1805da164"), null },
                    { new Guid("b886b163-4f76-431a-baff-501d11f9f354"), new Guid("83d4325e-c5e0-4383-8599-f5a37c7a8c50"), new Guid("c1e3c36a-0eb3-4651-b4ec-61662a6204d6"), 1647781930L, new Guid("8b557991-3975-4871-a5c8-252c248ab494"), null },
                    { new Guid("9daf794c-1a73-471c-bb43-644acde8b139"), new Guid("456fa297-b340-4f05-b3f7-ef601718a102"), new Guid("7aac4692-c699-42b3-9321-ac2a1c8c7038"), 1647781930L, new Guid("642c916d-a67e-49e6-916e-1217ee9eb077"), null },
                    { new Guid("4b3b3761-8547-4ae3-affd-b6f4a86f65be"), new Guid("1a8cd514-fb97-446e-9396-a5af59929df6"), new Guid("d0292c1a-269f-4010-8eb4-647147da3836"), 1647781930L, new Guid("8fedd17a-d68c-44f3-a2ee-840b9a94663d"), null }
                });

            migrationBuilder.InsertData(
                table: "StudyContracts",
                columns: new[] { "Id", "GroupId", "OptionalCourseId", "SignedAt", "StudentId", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("4d2d8ac5-87e2-42b5-9035-49fbea1071a4"), new Guid("b88fe164-14d4-4c3d-9636-654de90ae00e"), new Guid("2c4f9b71-8440-4111-a1b7-73edbd8165c6"), 1647781930L, new Guid("68b95b3d-ec70-4d42-a541-fb86fa9d08a5"), null },
                    { new Guid("75cbef01-c022-424d-89a9-7d185fb6ccaf"), new Guid("b3d0f73e-0d00-4a94-a3ab-bfcf211f1f6a"), new Guid("2c4f9b71-8440-4111-a1b7-73edbd8165c6"), 1647781930L, new Guid("f4422084-ef6c-4bf7-a412-fcec3dd78ee7"), null },
                    { new Guid("355f7aaa-c6d1-4710-9652-c8845ad098e8"), new Guid("9dcf1c99-b75a-4c79-82a5-b352fbbad561"), new Guid("aaff1993-cd78-408f-afb5-5900f9f9c4b3"), 1647781930L, new Guid("8b5d7a5d-c8be-4885-9d3c-e78f5efbc5fa"), null },
                    { new Guid("e98b2337-560a-44cd-9f74-e35c51c318b4"), new Guid("00ce9ff2-ca21-4d74-98cb-c9c277659cb8"), new Guid("aaff1993-cd78-408f-afb5-5900f9f9c4b3"), 1647781930L, new Guid("e8df6e37-707f-4e6b-af64-b8652ee07926"), null },
                    { new Guid("0e50b09f-dcd1-4b0c-a520-3bba36105595"), new Guid("6c92e5cc-16f3-47f9-8fa2-bcb23f71b24d"), new Guid("729aec25-6251-4df0-83ec-304663dc1092"), 1647781930L, new Guid("ac18481b-0a8f-4a37-9864-906478ffd2df"), null },
                    { new Guid("bee519bb-0f7e-423c-af02-4705898f5da1"), new Guid("00ce9ff2-ca21-4d74-98cb-c9c277659cb8"), new Guid("8e130879-c17c-4e99-8da4-775c423e4b5f"), 1647781930L, new Guid("d7f63d2b-5ead-4607-a40a-deb582ea5308"), null },
                    { new Guid("f41d7d77-ebdc-42b4-baa2-8b8a508f7060"), new Guid("9dcf1c99-b75a-4c79-82a5-b352fbbad561"), new Guid("8e130879-c17c-4e99-8da4-775c423e4b5f"), 1647781930L, new Guid("196de7ae-4595-4429-bc09-998f63d8436d"), null },
                    { new Guid("2bacf612-bd84-4918-8d62-3b75dae1da28"), new Guid("ff644d2b-3e4b-47d6-8adc-3d4b8d1adb90"), new Guid("0b65a50e-d0d3-4c53-852b-fce19c5b267d"), 1647781930L, new Guid("44594ce6-bf71-4a46-8266-98bfeb1c2970"), null },
                    { new Guid("6acbd48e-2523-4500-b526-bc604a3c7664"), new Guid("6c92e5cc-16f3-47f9-8fa2-bcb23f71b24d"), new Guid("f2bd4226-64e0-4156-84e2-e44ee05bfc09"), 1647781930L, new Guid("c569615a-67d0-4597-a351-bd3073a0c9d4"), null },
                    { new Guid("000095c2-5fb3-4244-81eb-ae6309f92b19"), new Guid("0cea77ac-2dee-4a12-987c-44c46c47c784"), new Guid("034c0d73-d284-43dd-8972-2fe63226de71"), 1647781930L, new Guid("dc5e4cc8-2e0c-49ed-a005-6f0618b6e9aa"), null },
                    { new Guid("124107e7-2771-4c4f-9854-bf7abda0a207"), new Guid("5c423449-4209-4757-a71e-0751b645a670"), new Guid("034c0d73-d284-43dd-8972-2fe63226de71"), 1647781930L, new Guid("2e712574-f6b7-41a1-b35e-b80dece3e13c"), null },
                    { new Guid("18a18691-ed11-43fa-bbc3-a1f8fd052fbd"), new Guid("47b31edd-3dc3-432c-89d7-2be29b39f51f"), new Guid("9d6fbba5-fb1d-4a54-9146-bf7087a7a827"), 1647781930L, new Guid("292911d0-a38d-4b62-a640-a3d750795509"), null },
                    { new Guid("9e2088b1-13fe-4dfe-a8a0-a354cab36091"), new Guid("5c423449-4209-4757-a71e-0751b645a670"), new Guid("7f9d323b-2e7d-4ef3-8d6d-41da03fc01bd"), 1647781930L, new Guid("ef20cb96-cb50-468a-a290-60982c4624cf"), null },
                    { new Guid("a00e7949-27e3-4364-81c4-017e58b714e6"), new Guid("0cea77ac-2dee-4a12-987c-44c46c47c784"), new Guid("7f9d323b-2e7d-4ef3-8d6d-41da03fc01bd"), 1647781930L, new Guid("36191ab2-a154-4af1-9425-c1656f15de98"), null },
                    { new Guid("91890b22-ac53-4e51-8cdf-05eb7ee4bf10"), new Guid("9849e7e6-de86-43e9-9b40-e0b433d6a5d4"), new Guid("67599df0-4e94-4dc6-8486-853db4994aa2"), 1647781930L, new Guid("591870ee-cbed-4c8d-acfb-31311af495c0"), null },
                    { new Guid("ca18d2d6-a7e6-4f61-8ed7-7f02182d25a4"), new Guid("b1513f73-1721-4a74-a0b9-796e480e897c"), new Guid("67599df0-4e94-4dc6-8486-853db4994aa2"), 1647781930L, new Guid("5150df5f-1496-48a1-86ed-a7d48d1ff598"), null },
                    { new Guid("d994a288-8d15-4fae-87e9-3450419ed633"), new Guid("47b31edd-3dc3-432c-89d7-2be29b39f51f"), new Guid("673be51b-c4dc-4f56-95b9-608872850f78"), 1647781930L, new Guid("0f476780-2609-488f-b0fa-3e6eb9b0b157"), null },
                    { new Guid("cf349557-d774-42e7-a063-481c5f42fc95"), new Guid("b88fe164-14d4-4c3d-9636-654de90ae00e"), new Guid("85c8a636-c6f1-4585-a462-e4694481c5c9"), 1647781930L, new Guid("ff7af21a-daa6-4288-8bc4-31a72f230c93"), null },
                    { new Guid("32237403-8108-427f-999e-84b62417ed0b"), new Guid("62cbcb67-5f17-4f2b-9442-00f25f885c40"), new Guid("85c8a636-c6f1-4585-a462-e4694481c5c9"), 1647781930L, new Guid("ff7af21a-daa6-4288-8bc4-31a72f230c93"), null },
                    { new Guid("ea0f8460-2619-4f1d-97a8-aef02ef60683"), new Guid("b3d0f73e-0d00-4a94-a3ab-bfcf211f1f6a"), new Guid("85c8a636-c6f1-4585-a462-e4694481c5c9"), 1647781930L, new Guid("4dfa468b-e025-4229-a276-1e5495b80859"), null },
                    { new Guid("26586a68-4e1f-4a66-9a6f-43fd9f032108"), new Guid("85d46aff-337f-404d-b14d-f0c5189082cb"), new Guid("d8c5bff6-d63b-47ea-bb3d-450c700b02b0"), 1647781930L, new Guid("172d66d7-51d2-4466-a948-cfd5048f39f0"), null },
                    { new Guid("6b69df23-b456-4adb-8e96-2b62cb9425b4"), new Guid("87fb648d-c85b-4c8e-b040-22f2f5715e34"), new Guid("ab15dde1-7353-40db-9786-20dd03c98a37"), 1647781930L, new Guid("5be602af-f69e-4fe9-a831-cdc006c419bd"), null },
                    { new Guid("34fc55a2-c9c6-4c01-aee8-a30539bc87d6"), new Guid("c7f35476-928f-435a-afda-c0022ab40097"), new Guid("ab15dde1-7353-40db-9786-20dd03c98a37"), 1647781930L, new Guid("76e619ff-b12b-448b-b12d-bd6cf3a02da6"), null },
                    { new Guid("eb7a4a49-e0fd-4382-bc14-41a2268f13ed"), new Guid("85d46aff-337f-404d-b14d-f0c5189082cb"), new Guid("5721e14a-2312-4c16-bee6-ae805952dc34"), 1647781930L, new Guid("40659082-765c-455c-98e9-f338a60fbd3d"), null },
                    { new Guid("98272f62-df40-4ca1-b28b-9d2020fa2045"), new Guid("89a73c17-59f8-4c68-ae18-9429acc8e0d3"), new Guid("612dfbc6-65d3-4084-99c0-a6ffa23e12d8"), 1647781930L, new Guid("cda50d53-914e-4fe1-a2e2-353383f278c4"), null },
                    { new Guid("63c1c6e1-7245-4044-b0a8-f78256bc7ef7"), new Guid("527d0085-4747-4167-a01d-e1fd8c1e74fe"), new Guid("62878184-a0f0-4001-a9f5-f31f8fd58179"), 1647781930L, new Guid("b30b7ea2-c339-4c6f-8cd8-a7b32ce3314f"), null },
                    { new Guid("05f1667e-04b3-4886-8025-9a7334d7843f"), new Guid("660d8700-61e3-4c3c-a0c3-c4a8b8ea1f86"), new Guid("62878184-a0f0-4001-a9f5-f31f8fd58179"), 1647781930L, new Guid("3611bf43-72e0-4091-be75-34dfe31baa6d"), null },
                    { new Guid("7a198200-c157-4e97-98ce-27e9b653de5e"), new Guid("89a73c17-59f8-4c68-ae18-9429acc8e0d3"), new Guid("ba36e657-9dad-417e-929b-dcb3deca447b"), 1647781930L, new Guid("32f863c9-58ae-4229-8a5c-6ce4fffa7864"), null },
                    { new Guid("a60dd3bf-795c-4b38-8aa7-9de7fcb16c5f"), new Guid("660d8700-61e3-4c3c-a0c3-c4a8b8ea1f86"), new Guid("4bc34497-06d2-4511-a6f8-119356c05116"), 1647781930L, new Guid("5a81dec3-3e42-4eda-a9ef-39f42595fbda"), null },
                    { new Guid("6f095671-5837-4f11-8de1-732e4d20bb53"), new Guid("527d0085-4747-4167-a01d-e1fd8c1e74fe"), new Guid("4bc34497-06d2-4511-a6f8-119356c05116"), 1647781930L, new Guid("ad76fee0-0c33-421b-a277-f02dd4ae6c0d"), null },
                    { new Guid("5cc3b98f-062b-4ecb-b42d-8d6b419d81c7"), new Guid("cbec33c5-ebaf-4c47-9e4b-57621ececcae"), new Guid("5b4777f1-0bbf-4ed1-bf4c-e6d978305a7f"), 1647781930L, new Guid("ea76f81e-3023-40d6-a406-ebc88e6d9db8"), null },
                    { new Guid("6a29459b-75fa-44e1-b1ff-8e83f2d81405"), new Guid("fa667767-de97-49ee-9352-88c0b39935be"), new Guid("5b4777f1-0bbf-4ed1-bf4c-e6d978305a7f"), 1647781930L, new Guid("58d96033-418d-4dc3-a70d-a7536f044873"), null },
                    { new Guid("011e2a97-cedb-4c40-8cd7-d84451197b20"), new Guid("8eb5d991-7824-4bd4-8b01-9e14364acfd6"), new Guid("184597c5-b467-4c16-a23f-2012c97d32b0"), 1647781930L, new Guid("32ff53c3-461d-4dc8-a6ef-d77b7cad6b66"), null },
                    { new Guid("dadc09b2-b32b-4c54-afb3-0fea669bb9b8"), new Guid("fa667767-de97-49ee-9352-88c0b39935be"), new Guid("1d104f78-9a1b-4b02-b847-fc8bb3dd4fe7"), 1647781930L, new Guid("194e9bdc-cfca-4531-b386-6a7fa43b0449"), null },
                    { new Guid("0e19475b-d2b0-4eb4-949a-30e966feb8da"), new Guid("cbec33c5-ebaf-4c47-9e4b-57621ececcae"), new Guid("1d104f78-9a1b-4b02-b847-fc8bb3dd4fe7"), 1647781930L, new Guid("1eacd3b6-a453-4919-bc4a-3f59ff2b2743"), null },
                    { new Guid("6055596e-ef51-466d-9fff-48969d26b411"), new Guid("8eb5d991-7824-4bd4-8b01-9e14364acfd6"), new Guid("1ff22614-00aa-4df7-8048-42b0f4b9f2b9"), 1647781930L, new Guid("50154cfa-4043-48f6-854a-fa1c029696ad"), null },
                    { new Guid("a3b38213-d416-47a0-8c95-0f4a61d4b819"), new Guid("ff644d2b-3e4b-47d6-8adc-3d4b8d1adb90"), new Guid("2e3cdd08-2c18-484b-8993-350a369485ec"), 1647781930L, new Guid("2c827012-0335-4c2e-bbfc-f80b250e189c"), null },
                    { new Guid("4caeb7fd-b9ef-4b60-a684-57a08358f230"), new Guid("52455bfd-56ae-4e8f-a4d0-a5f00736aec8"), new Guid("0d9e2f74-9fa7-4422-859b-dffca5ce123b"), 1647781930L, new Guid("e5879d89-0151-4665-ab4e-0c5bbf4d989d"), null },
                    { new Guid("36677d9c-6102-422d-aa51-d99477435b40"), new Guid("b1513f73-1721-4a74-a0b9-796e480e897c"), new Guid("710920d5-a86b-4f14-9db4-89ff06b69cf4"), 1647781930L, new Guid("4e31d876-41d5-4f98-95ed-24d6f4217948"), null },
                    { new Guid("575248a9-233a-4a6e-89ff-67845d5a6dc5"), new Guid("9849e7e6-de86-43e9-9b40-e0b433d6a5d4"), new Guid("710920d5-a86b-4f14-9db4-89ff06b69cf4"), 1647781930L, new Guid("e60ab03b-bdcc-4157-8f18-a5469b9148f2"), null },
                    { new Guid("ed591ead-98f4-4cde-bd77-c2c37d897c46"), new Guid("52455bfd-56ae-4e8f-a4d0-a5f00736aec8"), new Guid("33cb32be-564a-4b0d-ac00-c20729807336"), 1647781930L, new Guid("68561834-df19-4d14-87a4-0d015c7cc5b4"), null },
                    { new Guid("8bc39c6d-1a32-4edd-beb5-21328bea1398"), new Guid("3b679473-cd87-4835-83f0-5beb7e86e310"), new Guid("86b29b00-4424-4762-bbc3-4ab07c23ff89"), 1647781930L, new Guid("625247ff-426e-428b-8516-0eb1f3bf85a1"), null }
                });

            migrationBuilder.InsertData(
                table: "StudyContracts",
                columns: new[] { "Id", "GroupId", "OptionalCourseId", "SignedAt", "StudentId", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("ba78791d-04b6-42c5-b4b9-bcc2faf31986"), new Guid("e8d622c5-99a1-422c-b3b0-891a7e031445"), new Guid("f339faa2-19a5-4ae1-9c24-5385912f94b6"), 1647781930L, new Guid("d12cbea7-c1ba-4ae0-9e19-840376567159"), null },
                    { new Guid("fb3ec461-0789-4b38-bc53-4d83c441c2be"), new Guid("3a1b9a04-07e6-40e6-abaf-2fad5e396dd8"), new Guid("f339faa2-19a5-4ae1-9c24-5385912f94b6"), 1647781930L, new Guid("cdd47089-5999-4d0c-8517-72682def3943"), null },
                    { new Guid("8840006d-5399-4891-9777-03361c33ba0b"), new Guid("3b679473-cd87-4835-83f0-5beb7e86e310"), new Guid("e0b500f6-bcd2-4f34-993c-edba5c26427e"), 1647781930L, new Guid("c6938e97-d6fa-4b2a-9d5b-a7597474ecb8"), null },
                    { new Guid("5eb6484a-9f2e-476f-a747-75b3bbba8d67"), new Guid("26a0f818-c243-4345-ba51-a7770af916c8"), new Guid("d884a640-059d-4bf7-8f7c-922808fa3f8d"), 1647781930L, new Guid("d35b0409-6a42-417c-b81a-84291d3819ea"), null },
                    { new Guid("d398d164-51de-4d86-8237-ab90ae129aa6"), new Guid("2a331e7c-3ddb-4a54-ac32-ce296c07beb8"), new Guid("a97584d4-ce05-403a-9909-f05286f12805"), 1647781930L, new Guid("9a2ba3c1-1ac3-4848-8437-05aa5798c84a"), null },
                    { new Guid("71a90ccc-7f85-4902-9348-c68bbd695b94"), new Guid("1ea2740e-d501-4ced-9a27-eb06287c97bd"), new Guid("a97584d4-ce05-403a-9909-f05286f12805"), 1647781930L, new Guid("359efe2a-afca-4c4e-be6d-cc40be28d0c4"), null },
                    { new Guid("d7eb5d14-aa3d-49f8-8814-bae6e815855f"), new Guid("26a0f818-c243-4345-ba51-a7770af916c8"), new Guid("d2a91080-2333-4232-bbca-ee87b72a7d36"), 1647781930L, new Guid("13226643-dc98-41f7-acc7-6096bf7aa512"), null },
                    { new Guid("68d90611-4997-4e68-9a34-71225a6e0eb3"), new Guid("1ea2740e-d501-4ced-9a27-eb06287c97bd"), new Guid("e00fc931-736c-4319-93f7-6643fab7740d"), 1647781930L, new Guid("9bbb43b1-7d42-47c4-9148-1c81a476ffe6"), null },
                    { new Guid("7d5f60a0-66d1-48de-a71e-5f5bdde45c60"), new Guid("2a331e7c-3ddb-4a54-ac32-ce296c07beb8"), new Guid("e00fc931-736c-4319-93f7-6643fab7740d"), 1647781930L, new Guid("59bcacaf-37b5-4ab7-a9d8-3fa7f527b894"), null },
                    { new Guid("7002608a-b50c-4a43-992a-9f0bea37bde6"), new Guid("b2960685-f076-448b-b119-96ca5bac4072"), new Guid("82ce6525-0775-411c-97a0-8276d26a7f7a"), 1647781930L, new Guid("75ef86b3-6b75-4fa2-9a90-8d8dbe014dbb"), null },
                    { new Guid("0769decf-0bf2-403d-bef6-1741dd4a3dc8"), new Guid("93226548-0f7c-48b8-88a5-cac8d985252b"), new Guid("82ce6525-0775-411c-97a0-8276d26a7f7a"), 1647781930L, new Guid("9d72fe8f-6c84-4d52-a986-90ee9b005d05"), null },
                    { new Guid("8ad44e18-5edc-427c-bf8b-30042ac12c79"), new Guid("ff4d5794-3bea-489c-b3cf-da19e953214b"), new Guid("bb223a04-bdf1-48d9-9aa4-5c502be90fc5"), 1647781930L, new Guid("65ac3529-37a4-4d27-879d-40969d658ab3"), null },
                    { new Guid("113c9d84-b695-4674-9e3d-a0322262625f"), new Guid("93226548-0f7c-48b8-88a5-cac8d985252b"), new Guid("125e747f-d4f2-42e7-9f19-4b174767bc17"), 1647781930L, new Guid("e1c742e4-9cfd-4c20-85be-43d3de4544db"), null },
                    { new Guid("07d7a1bb-3515-4817-8953-ddccbad1ddaf"), new Guid("b2960685-f076-448b-b119-96ca5bac4072"), new Guid("125e747f-d4f2-42e7-9f19-4b174767bc17"), 1647781930L, new Guid("97bbb4cc-6c1b-4c7a-b3f4-8de07361b810"), null },
                    { new Guid("9b851889-c803-402f-b9a1-22f3d1475547"), new Guid("ff4d5794-3bea-489c-b3cf-da19e953214b"), new Guid("e831b4bc-5833-431a-a1c4-b702a4ac3fe4"), 1647781930L, new Guid("eea5ce76-afe3-4daa-a76e-4b163eeb9368"), null },
                    { new Guid("8ac4883f-9e86-43d4-8e70-90565e4774f1"), new Guid("456fa297-b340-4f05-b3f7-ef601718a102"), new Guid("1f79f698-75fe-4413-8220-4e9b34f7a344"), 1647781930L, new Guid("cc3c8718-d3d2-4a23-a181-21f583172446"), null },
                    { new Guid("bc8792e1-915f-47aa-82f4-d8a7721099ff"), new Guid("e8d622c5-99a1-422c-b3b0-891a7e031445"), new Guid("a4f709d7-64f3-4dcb-b1bf-906f9fd0a780"), 1647781930L, new Guid("d7c37fe4-9402-4cb1-9683-8e929155ca02"), null },
                    { new Guid("3a33f66b-99a0-4224-8281-30d3de8bfbdb"), new Guid("1a871327-f40a-48ff-8feb-973e7033ea01"), new Guid("d0292c1a-269f-4010-8eb4-647147da3836"), 1647781930L, new Guid("29920b9d-cd90-4115-bc6a-1cfcee40ddbd"), null },
                    { new Guid("592301b7-fefc-4d61-a7ac-a4302f9bc164"), new Guid("3a1b9a04-07e6-40e6-abaf-2fad5e396dd8"), new Guid("a4f709d7-64f3-4dcb-b1bf-906f9fd0a780"), 1647781930L, new Guid("0047c884-94a0-40c3-a6fa-d7a4c54d225d"), null },
                    { new Guid("a358780e-52a9-40cb-98e7-208332695e4a"), new Guid("2f1bff92-2745-41a2-81e0-1a814d40eba6"), new Guid("6bdca90f-f8e9-41df-9910-d285ba8c3fee"), 1647781930L, new Guid("4cff8695-f6e3-4066-8114-6d6e5092e8a1"), null },
                    { new Guid("8b9993be-8d66-487a-ab08-57169084a933"), new Guid("4b255de1-8a2a-4e7c-bf2b-ad59d7d739bb"), new Guid("c72b8d75-6554-449f-b2d3-a4055d3c983c"), 1647781930L, new Guid("19f553a5-d493-49b8-aa3f-868d51b9e044"), null },
                    { new Guid("1dddfbaf-daea-4ecf-b8e1-5f75e79df855"), new Guid("f56e4108-5956-4698-9374-bc8c8f064f9b"), new Guid("10244d3f-c24b-4f54-b8e8-50fd7b0e9251"), 1647781930L, new Guid("1f1fe638-1b54-40f2-96cf-18f962b9a5f9"), null },
                    { new Guid("e0baa862-90f8-4f13-810b-73bbf39cdf12"), new Guid("ea4c2813-7b5d-47dd-b138-73436b921274"), new Guid("10244d3f-c24b-4f54-b8e8-50fd7b0e9251"), 1647781930L, new Guid("002a0c96-511b-461e-ac79-5bea5628fe6e"), null },
                    { new Guid("057b510d-73ba-49e4-86a8-3c756b686d5d"), new Guid("4b255de1-8a2a-4e7c-bf2b-ad59d7d739bb"), new Guid("1ca865ab-179d-4f89-9768-f3016af761a1"), 1647781930L, new Guid("53cb595c-526c-42f2-b2aa-fe6542a552cb"), null },
                    { new Guid("489e5fb6-cae0-443d-9b4d-289b18062931"), new Guid("92cc8310-af5c-47da-a2d6-d18a22443fa6"), new Guid("8cfd1ed7-446d-496b-a84f-2d53f20e5df6"), 1647781930L, new Guid("99d9eccb-5100-40de-b3a0-cc91b1f9b9b1"), null },
                    { new Guid("75c2caa0-9e24-430a-92b6-324914330bf3"), new Guid("ea4c2813-7b5d-47dd-b138-73436b921274"), new Guid("8cfd1ed7-446d-496b-a84f-2d53f20e5df6"), 1647781930L, new Guid("99d9eccb-5100-40de-b3a0-cc91b1f9b9b1"), null },
                    { new Guid("b7e4b3e8-33bf-4cd9-8778-6e0724cdc95e"), new Guid("f56e4108-5956-4698-9374-bc8c8f064f9b"), new Guid("8cfd1ed7-446d-496b-a84f-2d53f20e5df6"), 1647781930L, new Guid("69ef18e5-8b3c-46e6-9fe2-549ab2d0ec82"), null },
                    { new Guid("38bc5f23-d1d5-4db3-b5d1-009c77e7330c"), new Guid("040c1022-a32d-454a-aa40-79d5ecd3309e"), new Guid("bf431e0c-7465-4040-b05f-0ecb00750b26"), 1647781930L, new Guid("81d14df4-91b9-4f25-b538-87ef29f51bdf"), null },
                    { new Guid("5512d5d8-e6ff-4a2a-a2c2-75add0120c71"), new Guid("1fac0d1e-413c-4492-b4e9-6d1e57139165"), new Guid("bf431e0c-7465-4040-b05f-0ecb00750b26"), 1647781930L, new Guid("36c84e5f-efed-46a9-9d91-d1e9e446a0de"), null },
                    { new Guid("f10e4929-7dc7-4cc7-8a68-07a5e726e9d9"), new Guid("c3da6eb0-ae21-4904-9eaf-1c7b47f4613a"), new Guid("97ea2170-27f9-4aa4-b59d-fdc88ed55aab"), 1647781930L, new Guid("bc63fa64-7223-4e03-8d83-3217e3600e22"), null },
                    { new Guid("7733f2d3-105c-427e-b8f5-982f7d559703"), new Guid("1fac0d1e-413c-4492-b4e9-6d1e57139165"), new Guid("a4492a95-21d1-45da-a54a-181db403ec4e"), 1647781930L, new Guid("d6ff772d-059b-4705-b2a9-86a2a922581b"), null },
                    { new Guid("33851cb4-1ce4-4909-89e6-a9aab4126ccb"), new Guid("040c1022-a32d-454a-aa40-79d5ecd3309e"), new Guid("a4492a95-21d1-45da-a54a-181db403ec4e"), 1647781930L, new Guid("19c3452d-a94d-4779-94ea-58f6505825a9"), null },
                    { new Guid("81a4e4dc-ff3b-4730-8ea9-91494b6264f0"), new Guid("c3da6eb0-ae21-4904-9eaf-1c7b47f4613a"), new Guid("0943ded9-80e4-4a17-baf1-a25a376d55bd"), 1647781930L, new Guid("50fb7931-89aa-4f79-ab55-9412f253c4d5"), null },
                    { new Guid("fe714267-f648-4682-9f23-ea110d60e90a"), new Guid("5eae801d-c3fe-4753-8a85-c74d1cdaa35f"), new Guid("9246764c-fdfb-44c9-815c-132aa8e2daf5"), 1647781930L, new Guid("6c8a85f6-6c11-4efd-ad98-d851e6add12c"), null },
                    { new Guid("4b38fba2-a1e2-4e7b-b482-23118d87d376"), new Guid("cb61a038-60dd-4bfd-98b0-488b51adb232"), new Guid("d2bd72cd-ba4f-4fd0-9cc8-468424aef840"), 1647781930L, new Guid("58f39776-9c1e-47aa-9eea-19197e1be932"), null },
                    { new Guid("3e15efa5-7211-40b1-aa82-332c5d267e3e"), new Guid("2f1bff92-2745-41a2-81e0-1a814d40eba6"), new Guid("d2bd72cd-ba4f-4fd0-9cc8-468424aef840"), 1647781930L, new Guid("84089d22-33d2-4f02-b3ad-e2f1d566826d"), null },
                    { new Guid("f61d6002-d6a9-4faf-a26a-910c119939c1"), new Guid("5eae801d-c3fe-4753-8a85-c74d1cdaa35f"), new Guid("b4d8d209-5fd6-4db0-9887-89c6a0f691f9"), 1647781930L, new Guid("6f9f853c-fbd8-4bd1-bf90-35c81de11af2"), null },
                    { new Guid("1160ee5c-972c-4f70-8e35-33ba5f2a1728"), new Guid("cb61a038-60dd-4bfd-98b0-488b51adb232"), new Guid("6bdca90f-f8e9-41df-9910-d285ba8c3fee"), 1647781930L, new Guid("97999cd8-82ae-4dbb-ad7d-9718ac62cc10"), null },
                    { new Guid("974ef9d7-c446-4627-bfde-0a5a5ef2e642"), new Guid("87fb648d-c85b-4c8e-b040-22f2f5715e34"), new Guid("f3c64975-3db8-4e33-8f49-416980d83fb7"), 1647781930L, new Guid("5d47e3ec-3aa5-4829-a899-37981125aaea"), null },
                    { new Guid("16346b6b-abe1-4685-be45-33fff6e7f727"), new Guid("6432bd10-fccd-401a-bef9-bdc2ccda38fb"), new Guid("088a8289-d2fd-4aa7-aa22-db7c180b628d"), 1647781930L, new Guid("900eb128-17c8-4256-93cb-794bde9bbd2e"), null },
                    { new Guid("025c5011-e788-4c6d-91df-475340adb2dc"), new Guid("7846e11d-0257-4c2d-b161-55fb73c3800b"), new Guid("13291a2b-aea0-4004-980d-433f87b4de5d"), 1647781930L, new Guid("dbb2e57a-04d6-4da5-9807-e241731ec56c"), null },
                    { new Guid("d26519ad-b40f-4b70-961f-0c3f85292f2b"), new Guid("b0c86f26-5ad3-49d2-83a1-8a14f6321b27"), new Guid("88cec539-57ea-43c2-b889-46848ef35141"), 1647781930L, new Guid("7b7d4e6f-6af7-405a-88b8-e13aba66c309"), null }
                });

            migrationBuilder.InsertData(
                table: "StudyContracts",
                columns: new[] { "Id", "GroupId", "OptionalCourseId", "SignedAt", "StudentId", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("083c3b98-5635-46a7-a57b-9e40acb6e6a8"), new Guid("1f811026-6fca-4ce6-bc31-443c0bdb265d"), new Guid("5105c2d7-8f32-4c90-98db-2ece7391540d"), 1647781930L, new Guid("9b3d4def-357a-47ef-be7b-96fe3a543731"), null },
                    { new Guid("14d728e6-d38c-4d1f-8f30-75d0fb77411c"), new Guid("6f67e353-8158-4f04-98c8-3009a78d58f5"), new Guid("5105c2d7-8f32-4c90-98db-2ece7391540d"), 1647781930L, new Guid("53dc3a1d-2aae-4534-a08f-ec97a382fe58"), null },
                    { new Guid("d95ba3e8-7adf-46d2-92db-46c67181255d"), new Guid("b0c86f26-5ad3-49d2-83a1-8a14f6321b27"), new Guid("5725ef74-7cca-4315-86b0-2bc4d34b1e32"), 1647781930L, new Guid("eb5f8810-fbd1-4dd6-94b3-579625ff346e"), null },
                    { new Guid("ec815e54-9aae-4e52-b73b-205b16925eb4"), new Guid("da0722bd-e76e-45b4-a9de-255fb63e7296"), new Guid("9a0e558f-7fe2-455a-9bb8-d830f0b1c585"), 1647781930L, new Guid("617766f8-ca42-4352-9c3f-f0467fa11b36"), null },
                    { new Guid("1107bccc-c6b7-40fc-b7e8-fef623cbe493"), new Guid("3e85100c-1136-4bfa-acdd-19deb0260580"), new Guid("dccd78e6-5693-4eec-8982-fe53868dbb28"), 1647781930L, new Guid("d7d601ab-76a3-46ae-918f-dcffc52ffea0"), null },
                    { new Guid("9bb5e72a-e4ec-4261-8590-fee2f371a9e6"), new Guid("ab21092d-aa9e-4d64-bd28-570e5c3270a8"), new Guid("dccd78e6-5693-4eec-8982-fe53868dbb28"), 1647781930L, new Guid("544997e0-2a82-4be5-9011-9f0195da70e4"), null },
                    { new Guid("549597f1-4de3-40b3-ad3e-27311afe7d98"), new Guid("1f811026-6fca-4ce6-bc31-443c0bdb265d"), new Guid("c39d9054-cd73-4841-8317-1c1540463b56"), 1647781930L, new Guid("76f6c3c2-187a-4649-8a4c-f7e3cc1b1a4a"), null },
                    { new Guid("1eabecdb-58ed-4e51-8c03-6c19a60b50aa"), new Guid("da0722bd-e76e-45b4-a9de-255fb63e7296"), new Guid("bb566bff-9dab-48d5-9ffc-a05a6037189d"), 1647781930L, new Guid("d2b93a5f-548f-46e2-82d2-7b4256ddc7c7"), null },
                    { new Guid("f910a308-784c-4aa9-ae8c-8cd8a8e0046d"), new Guid("3e85100c-1136-4bfa-acdd-19deb0260580"), new Guid("1c8ca4e4-c942-4add-a67e-e8983d161ece"), 1647781930L, new Guid("228de7c0-9100-4173-a73d-82a43496ceba"), null },
                    { new Guid("ceaf277a-ae29-4c59-9562-00bf60d5db8e"), new Guid("cb4aef2c-4b2a-438e-be4a-0253dc2b8469"), new Guid("8c5fa166-52f4-4445-9d29-ccd0e1ef0b5f"), 1647781930L, new Guid("8269ca96-4564-42f3-865a-166c53b70048"), null },
                    { new Guid("af68d775-f0aa-4406-aeca-15c0ccf14e78"), new Guid("47193d05-a9fe-46e3-a59e-680d3266abf2"), new Guid("8c5fa166-52f4-4445-9d29-ccd0e1ef0b5f"), 1647781930L, new Guid("d3f255b5-1a24-4fdc-a8c4-8e4230821346"), null },
                    { new Guid("7dab6951-cb63-48d1-9a3d-171fa569246e"), new Guid("c296338a-554a-4d8b-bdd0-35c754fb26ac"), new Guid("597c9603-a866-4485-94a5-eddfbd36db61"), 1647781930L, new Guid("cd8d4b90-8223-446b-b2ef-9186c311d535"), null },
                    { new Guid("8ff763a8-f90c-48d9-887d-2e396e024b95"), new Guid("47193d05-a9fe-46e3-a59e-680d3266abf2"), new Guid("4b17e8bd-34fc-4c72-8d2c-05a4ddf5022c"), 1647781930L, new Guid("79a3d751-db8d-4495-813d-a6203154549a"), null },
                    { new Guid("113b38ce-8211-461c-b75d-40d691be1241"), new Guid("cb4aef2c-4b2a-438e-be4a-0253dc2b8469"), new Guid("4b17e8bd-34fc-4c72-8d2c-05a4ddf5022c"), 1647781930L, new Guid("a0c41db5-510b-41dd-8030-d1c66fb7d09a"), null },
                    { new Guid("f952369a-0b8c-40f3-b965-710d83d2da58"), new Guid("c296338a-554a-4d8b-bdd0-35c754fb26ac"), new Guid("2ac49b1f-619e-40d9-8884-722f017187fb"), 1647781930L, new Guid("6453708a-2fea-44e4-9de2-d2cf2389915d"), null },
                    { new Guid("76c30935-8514-4c47-b950-df36cad1b5b1"), new Guid("ab21092d-aa9e-4d64-bd28-570e5c3270a8"), new Guid("1c8ca4e4-c942-4add-a67e-e8983d161ece"), 1647781930L, new Guid("44d0869b-72ff-4f9b-847e-29916d7a693a"), null },
                    { new Guid("57d1eb7b-70c4-4b97-8a1f-c671d68948ac"), new Guid("6f67e353-8158-4f04-98c8-3009a78d58f5"), new Guid("c39d9054-cd73-4841-8317-1c1540463b56"), 1647781930L, new Guid("f03af296-40a2-4ef2-9fc3-26ff5c3ab206"), null },
                    { new Guid("dbc3d745-3261-4ecf-a35e-b072ea6082a4"), new Guid("569e2cfb-d638-4d21-a4f9-184df6c18bcf"), new Guid("fe6ce376-5852-4ad0-93dd-1e481b0214b8"), 1647781930L, new Guid("9185cbfa-61d3-41bb-a7ad-6d2de2018983"), null },
                    { new Guid("ad781271-8f43-4ea5-b788-a05bdef7e1dd"), new Guid("5018a3e3-badd-428a-a5b0-615941965a37"), new Guid("fe6ce376-5852-4ad0-93dd-1e481b0214b8"), 1647781930L, new Guid("3f015aff-d63d-4694-aef8-0c2e7b6368cc"), null },
                    { new Guid("be082062-7f14-41e6-8d53-99e644bf2166"), new Guid("dfdcb31f-6020-455e-b53e-2cc0a4de2ffe"), new Guid("0328acea-b330-40c9-a87d-653b3c6ffda0"), 1647781930L, new Guid("922f2946-a18a-4498-b3ce-5a48d253f485"), null },
                    { new Guid("c15e1440-318a-4c23-a69b-d25fc1e0e871"), new Guid("4c5c3876-28eb-410f-b2b6-76078a50f398"), new Guid("0f6dea53-87c2-49d5-a043-834b3bc28c4d"), 1647781930L, new Guid("3f926b42-d0ee-40d0-bd0a-16d5b543c41b"), null },
                    { new Guid("bdb7ba06-64e0-4ef3-bc74-95c110674fd1"), new Guid("51630394-067b-4a5a-8145-bc15305a8bb1"), new Guid("0f6dea53-87c2-49d5-a043-834b3bc28c4d"), 1647781930L, new Guid("3560bafc-aea7-46bf-80b2-6d726b0631b6"), null },
                    { new Guid("f6840a04-c53b-4df0-9ff1-f25c889db7e4"), new Guid("dfdcb31f-6020-455e-b53e-2cc0a4de2ffe"), new Guid("681e8430-f3d7-46c1-b3b6-b1fa953044bf"), 1647781930L, new Guid("6edc5e82-759e-4728-971d-2cab78fef5cf"), null },
                    { new Guid("10bb6d3b-4e99-4c6c-ae70-7a3e4ff966cf"), new Guid("d6e60c34-eafa-46cf-925d-a57cc18f1e89"), new Guid("151ab050-a2ca-4215-ba0b-e28f9ee3722c"), 1647781930L, new Guid("e8cce8c0-a6d7-4df2-aacd-e7b73066b15d"), null },
                    { new Guid("a44bf3bc-2f5d-49a7-9d12-5b809c963dd5"), new Guid("51630394-067b-4a5a-8145-bc15305a8bb1"), new Guid("151ab050-a2ca-4215-ba0b-e28f9ee3722c"), 1647781930L, new Guid("e8cce8c0-a6d7-4df2-aacd-e7b73066b15d"), null },
                    { new Guid("d877ec62-d0b1-4b1e-920e-cb3eb152d2a6"), new Guid("4c5c3876-28eb-410f-b2b6-76078a50f398"), new Guid("151ab050-a2ca-4215-ba0b-e28f9ee3722c"), 1647781930L, new Guid("8a18b36c-ceab-42bc-bf81-2070b160dfad"), null },
                    { new Guid("674847dc-6993-4d1d-be65-c20353453df5"), new Guid("57bae36e-0423-4058-9713-97bf8d90f0cd"), new Guid("c520b3db-ad84-4971-ac9a-f39fd1a9d64d"), 1647781930L, new Guid("5e5ca85e-0a93-4873-9372-b5a5c662b052"), null },
                    { new Guid("ac317784-2c1c-4fd9-bbb8-9ee659a6683b"), new Guid("6565a8d0-5276-49ba-9a0f-90c75681e35a"), new Guid("c520b3db-ad84-4971-ac9a-f39fd1a9d64d"), 1647781930L, new Guid("bef86030-c3dc-4c85-bf9f-c099d3ba22cd"), null },
                    { new Guid("e26419d7-11c0-407f-b5e5-847291cdfc8f"), new Guid("7fc6a5cb-8b6a-49c5-b0b6-8b511b04cffd"), new Guid("9b569205-18bf-4050-b783-b67f7ecdc769"), 1647781930L, new Guid("518e33e2-cb30-43db-bf9b-0e72f8b841e1"), null },
                    { new Guid("6dd3cf6b-6379-4d21-866c-96c9363f1616"), new Guid("6565a8d0-5276-49ba-9a0f-90c75681e35a"), new Guid("7018abe6-9dd7-4175-badf-bdbfc057ccfc"), 1647781930L, new Guid("a596de6d-9472-4dcd-bd27-5332a82d3af6"), null },
                    { new Guid("da5428fe-22a1-4c0f-9327-32672612aeec"), new Guid("57bae36e-0423-4058-9713-97bf8d90f0cd"), new Guid("7018abe6-9dd7-4175-badf-bdbfc057ccfc"), 1647781930L, new Guid("a9acdf1f-282d-4dd4-910c-895b4f1eca25"), null },
                    { new Guid("01c356ed-10d2-44a8-aad9-6171c658c30d"), new Guid("7fc6a5cb-8b6a-49c5-b0b6-8b511b04cffd"), new Guid("0cb6edcb-8b63-49a4-b3eb-031e5d693135"), 1647781930L, new Guid("ca9958e8-1315-4ed6-97cb-ffbf16656321"), null },
                    { new Guid("77a522c6-349f-4c3e-86af-ecb76832265f"), new Guid("58fc10f4-af4c-476c-846e-25106edc46db"), new Guid("0e7ba6c1-fdb2-47bd-a5ba-0ebcc47e9be5"), 1647781930L, new Guid("261d21c8-2163-48ae-9c20-60e1b5a3132e"), null },
                    { new Guid("46572422-afbf-48e3-afbf-67a9c4e033ae"), new Guid("569e2cfb-d638-4d21-a4f9-184df6c18bcf"), new Guid("62818ca8-8e0a-4a8e-b8e3-d597936e95c5"), 1647781930L, new Guid("b69f3e09-aa52-4f92-8902-546043865030"), null },
                    { new Guid("4485a944-b34b-489d-bff1-684ef10a19f6"), new Guid("5018a3e3-badd-428a-a5b0-615941965a37"), new Guid("62818ca8-8e0a-4a8e-b8e3-d597936e95c5"), 1647781930L, new Guid("dba8fa82-2c7b-4b67-b548-619c324260dd"), null },
                    { new Guid("39213952-715e-462f-9b82-6121d6a3d0a4"), new Guid("58fc10f4-af4c-476c-846e-25106edc46db"), new Guid("c58284ea-9419-4dda-b9fe-89b596d52cbf"), 1647781930L, new Guid("f86d7461-18a7-45a2-b52f-ba3908594baa"), null },
                    { new Guid("b7260773-f1de-47b1-b3d1-22aa83414127"), new Guid("6e57b032-8343-4387-a1e0-dda532adc939"), new Guid("20dd3a2c-4110-49f1-8a01-c3d512fc2f70"), 1647781930L, new Guid("97f67177-05f3-44e5-9ba7-e5df48640131"), null },
                    { new Guid("0ff790bb-0b7c-4826-96ff-9d6585db8b64"), new Guid("f5d8c706-ee93-4cc2-87be-57e0af7eb798"), new Guid("e19394b2-2a73-4459-8e3b-0112c6069fca"), 1647781930L, new Guid("0cc54009-5402-4edf-99c9-a7b99b06a030"), null },
                    { new Guid("3306b599-4c34-4c8c-81f2-2f150a69744f"), new Guid("31cf7b40-0bb6-4211-a7ca-c7b918d1a253"), new Guid("e19394b2-2a73-4459-8e3b-0112c6069fca"), 1647781930L, new Guid("873bf5e1-3a14-4ed3-9d3e-64c42719c71c"), null },
                    { new Guid("3c3dffe5-c64d-47bf-8eca-ff8745f69cb7"), new Guid("6e57b032-8343-4387-a1e0-dda532adc939"), new Guid("0602ce5f-d011-470a-b75a-761fee82dc51"), 1647781930L, new Guid("4e52143f-1096-4527-82a4-952946e770ee"), null },
                    { new Guid("f224e68d-25c3-4dd8-adfd-ad66935a0423"), new Guid("c8e9d071-fe86-424c-b26d-d401c4e168ba"), new Guid("da14cfd6-e3bd-40e7-bbb8-63849bea068a"), 1647781930L, new Guid("26ffa7f4-c957-4630-b05c-02d0c840c97f"), null },
                    { new Guid("4eabc0e2-2e51-4b2b-aae3-66184ec16f12"), new Guid("7f690dc8-22ff-49de-9b11-c2ecff7774d3"), new Guid("da14cfd6-e3bd-40e7-bbb8-63849bea068a"), 1647781930L, new Guid("6d68095a-4db1-4645-9b89-b646fdca891b"), null }
                });

            migrationBuilder.InsertData(
                table: "StudyContracts",
                columns: new[] { "Id", "GroupId", "OptionalCourseId", "SignedAt", "StudentId", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("324250ad-a139-4e74-bc8c-fd27e7df7308"), new Guid("4a6e755b-110e-4d50-a3ef-f5165f648eff"), new Guid("a687078c-6af4-4a2d-9523-c46f547f5528"), 1647781930L, new Guid("f2135e60-f330-4ed1-8742-1a848f1c524c"), null },
                    { new Guid("3863cade-1857-4bdf-8b0b-a94b70b56615"), new Guid("7f690dc8-22ff-49de-9b11-c2ecff7774d3"), new Guid("92a1f2d8-9a72-46c9-b441-142275dd1444"), 1647781930L, new Guid("e7dbd668-f65e-4a4f-a219-7df85426eb7d"), null },
                    { new Guid("779787d3-9e72-4af8-b2d0-0441dfccd7bf"), new Guid("c8e9d071-fe86-424c-b26d-d401c4e168ba"), new Guid("92a1f2d8-9a72-46c9-b441-142275dd1444"), 1647781930L, new Guid("b415309e-197e-45fa-a326-ee54e2e51b5c"), null },
                    { new Guid("fd3160f8-0a55-42c0-9720-5a385347a232"), new Guid("f54d55c1-b7c1-4784-b575-f22a8d038585"), new Guid("274b4646-85b7-4078-9669-2e1d248a49a0"), 1647781930L, new Guid("cb4553fe-491c-4ae1-a9ec-728e0e23aa41"), null },
                    { new Guid("6d68964b-b33d-4582-bd0a-5e6209feed2f"), new Guid("5d72fca2-3afc-42fd-bbe7-a2106390536a"), new Guid("274b4646-85b7-4078-9669-2e1d248a49a0"), 1647781930L, new Guid("7118da7d-3026-4168-9aff-ac661e2bb369"), null },
                    { new Guid("16a21a21-5421-4227-8273-517d2df02650"), new Guid("92cc8310-af5c-47da-a2d6-d18a22443fa6"), new Guid("654ea075-6f9a-488e-bd87-bee5276b507b"), 1647781930L, new Guid("df53a171-3c34-4018-b758-1879fc9d5668"), null },
                    { new Guid("a42f2b63-b834-4532-a91f-5e0b657e0f95"), new Guid("5d72fca2-3afc-42fd-bbe7-a2106390536a"), new Guid("f9326861-4ff0-4f28-88ce-c52264970477"), 1647781930L, new Guid("a2a3b028-b19f-4f32-b37f-559e7faa36ea"), null },
                    { new Guid("536d1d9f-bf31-4f05-8a23-fda2f4d33519"), new Guid("f54d55c1-b7c1-4784-b575-f22a8d038585"), new Guid("f9326861-4ff0-4f28-88ce-c52264970477"), 1647781930L, new Guid("ec510e3b-016c-42bb-9b5a-32b09d4e3ddb"), null },
                    { new Guid("8eb7ee43-750a-49f3-a213-3d98ed8d7fbd"), new Guid("92cc8310-af5c-47da-a2d6-d18a22443fa6"), new Guid("dea94db2-262a-4836-903d-3d7fd704fe94"), 1647781930L, new Guid("a9dfc290-8b48-498a-be8d-7fdceae7d20e"), null },
                    { new Guid("b19f6f59-ef90-4da0-b9f6-2aa7dc55a885"), new Guid("d1b6b5e8-16df-4744-a5e0-34bb7eb51d1e"), new Guid("8709e44b-2dad-4085-ab75-58cd3646a9aa"), 1647781930L, new Guid("b8808a4e-a209-4f3d-bc48-44df7cd85f6f"), null },
                    { new Guid("79f810c8-b47f-42e5-8df6-4bc5b096afa9"), new Guid("62cbcb67-5f17-4f2b-9442-00f25f885c40"), new Guid("80449a12-5de8-44bd-b031-f66d67422cb4"), 1647781930L, new Guid("fb65a8c2-8073-4046-9c10-6b539ac221b9"), null },
                    { new Guid("8581cc2a-002d-45af-b3d0-61eaeca4d0a8"), new Guid("dea5a9a8-7c7d-48c1-9f6b-5040becf710a"), new Guid("80449a12-5de8-44bd-b031-f66d67422cb4"), 1647781930L, new Guid("d9cefb51-8a84-4796-9613-67f6d7493cd7"), null },
                    { new Guid("4fa5756d-45f1-448f-a474-2aef8de2a504"), new Guid("d1b6b5e8-16df-4744-a5e0-34bb7eb51d1e"), new Guid("318a6048-1709-4dcf-b6e5-55c283b6e5f2"), 1647781930L, new Guid("ea092d03-3c10-4421-9662-10b66b385f11"), null },
                    { new Guid("b0e82037-42d5-4e0a-ade3-1edacd70059e"), new Guid("dea5a9a8-7c7d-48c1-9f6b-5040becf710a"), new Guid("5acff67f-321b-4a0a-97d2-949b01371b9b"), 1647781930L, new Guid("83f0aaff-d4c3-4309-8768-77893c992640"), null },
                    { new Guid("47a25ac1-0ff9-4ffd-a3ee-b01ab84327c0"), new Guid("b35c6813-10f3-49f6-b5d5-c533a200568e"), new Guid("5acff67f-321b-4a0a-97d2-949b01371b9b"), 1647781930L, new Guid("8e0e2189-5374-4025-b8f6-51207e345bcb"), null },
                    { new Guid("3c0d5d1d-daeb-44ba-927f-cf76bf30ed87"), new Guid("4a6e755b-110e-4d50-a3ef-f5165f648eff"), new Guid("faa62583-229e-4c1c-9026-73c3f5985ed2"), 1647781930L, new Guid("db80d9ab-0020-4d56-b5db-e5ac0300504f"), null },
                    { new Guid("0a3b65aa-7dc6-4948-86d0-a59d4f11dbe9"), new Guid("3cc7e2fb-634a-475d-bdd9-4878383f8731"), new Guid("4f0ad544-41f3-4c82-82b6-aaf7f8d70b9f"), 1647781930L, new Guid("fce2f744-4445-4d77-abd6-483200dbd9a9"), null },
                    { new Guid("1522ea77-214d-4c3b-b09a-1566e5b52d55"), new Guid("b1622035-d705-43d8-8f4b-51d1bb429e86"), new Guid("482a9498-8385-423e-99ca-99d2a3ffd9cd"), 1647781930L, new Guid("7d2df82a-da60-435f-92f3-00b9a08a83a7"), null },
                    { new Guid("195c48e1-419c-4661-b40d-5934a85a3d12"), new Guid("3ea90c43-0a8b-4d0b-b6b2-5fa6ab3be0ea"), new Guid("da0ee43b-2557-4d71-9c61-e9a1f0a570bf"), 1647781930L, new Guid("cceb338c-3b15-42c3-bea6-c1858c4f97de"), null },
                    { new Guid("ec95efa1-205d-4813-95ad-e38fa0a32b6b"), new Guid("31cf7b40-0bb6-4211-a7ca-c7b918d1a253"), new Guid("e68d9723-1173-48f9-9689-b34d2e173db6"), 1647781930L, new Guid("504758c1-1de9-4ac0-975f-e5aa3792eab9"), null },
                    { new Guid("6b2eb65a-39ce-410f-8aa2-1c35b5619847"), new Guid("f5d8c706-ee93-4cc2-87be-57e0af7eb798"), new Guid("e68d9723-1173-48f9-9689-b34d2e173db6"), 1647781930L, new Guid("338856a0-41f5-4122-859c-ab548c3268b9"), null },
                    { new Guid("b0474c60-291f-4907-8e3b-48483a59a487"), new Guid("84acd630-c9ca-4090-94a9-ce5aaf1e0ba3"), new Guid("0989ac48-092b-4d69-96b3-8e2c0e017c11"), 1647781930L, new Guid("41d233cb-3722-419c-aad6-5b7a501869ce"), null },
                    { new Guid("b3b44dd8-084d-42a0-90e7-012f92ee71e7"), new Guid("b35c6813-10f3-49f6-b5d5-c533a200568e"), new Guid("0989ac48-092b-4d69-96b3-8e2c0e017c11"), 1647781930L, new Guid("69a77913-f8e0-43bc-80cf-55f4bc8b41d3"), null },
                    { new Guid("1497f30a-ac75-4cbd-ba5a-7ad9da4a9396"), new Guid("7be3598e-a3da-4c32-809b-c7ce27f65d9f"), new Guid("ed617561-2956-4d5d-b264-7338128f9d76"), 1647781930L, new Guid("3aaac02f-d7ca-4353-9bae-963860cd45bb"), null },
                    { new Guid("1f70abb6-3a33-4061-96a8-1d007db725e2"), new Guid("b35c6813-10f3-49f6-b5d5-c533a200568e"), new Guid("7d70aaa4-1148-49dd-8547-656f8968fb16"), 1647781930L, new Guid("81207023-d172-4ea8-b484-38d6edc3639d"), null },
                    { new Guid("94d719af-3672-4d2c-ad30-cefd58aa0bb7"), new Guid("84acd630-c9ca-4090-94a9-ce5aaf1e0ba3"), new Guid("7d70aaa4-1148-49dd-8547-656f8968fb16"), 1647781930L, new Guid("4bc14726-65e3-45a7-be85-fdb13ec2e979"), null },
                    { new Guid("5091aeef-ff2b-48d4-b331-94f362feb4a1"), new Guid("7be3598e-a3da-4c32-809b-c7ce27f65d9f"), new Guid("ebae2397-b16c-4778-bd1b-acfa1d713a08"), 1647781930L, new Guid("cebbf0a8-18f3-43fb-8063-756e6f1417f0"), null },
                    { new Guid("ff6365de-cfda-46b1-8a39-a05b8bad4eb0"), new Guid("96ae3f82-ac27-4a62-8da3-09daad1c1e1a"), new Guid("bd539441-8714-4ebc-823c-14e7039b4028"), 1647781930L, new Guid("0fb317ef-fef9-495b-999e-ce868c915bf3"), null },
                    { new Guid("15439f56-4196-4f31-9a36-93e20ae77b01"), new Guid("41dc4c28-ffe5-4739-b414-2c5d9ecf418e"), new Guid("372569ec-3c17-49e7-aba0-b146f38820fd"), 1647781930L, new Guid("9e90e22e-ab55-4562-88cf-99dd907f971d"), null },
                    { new Guid("e9ba35f1-c5e6-400f-ad34-04a22e053417"), new Guid("d846ec0d-4ede-4dc9-8594-3f68623d1c41"), new Guid("372569ec-3c17-49e7-aba0-b146f38820fd"), 1647781930L, new Guid("8161fc28-57b1-490a-88c5-f303538d27fa"), null },
                    { new Guid("60091a35-5620-4a59-9fea-6c378fd3ed3b"), new Guid("96ae3f82-ac27-4a62-8da3-09daad1c1e1a"), new Guid("512225ed-9b82-44b6-9784-add563eaad42"), 1647781930L, new Guid("655f95ab-ffd9-45cb-adb0-2a7315670381"), null },
                    { new Guid("d1392c68-355c-4651-928a-3cf43852fd27"), new Guid("d846ec0d-4ede-4dc9-8594-3f68623d1c41"), new Guid("64277d71-1bc1-42ec-b057-50fe7b723c54"), 1647781930L, new Guid("7d6a60dc-e3ba-41b5-8431-e6b8051ce24b"), null },
                    { new Guid("9ccdd3ec-56f4-4d6b-8aa0-489f2c60c8ca"), new Guid("41dc4c28-ffe5-4739-b414-2c5d9ecf418e"), new Guid("64277d71-1bc1-42ec-b057-50fe7b723c54"), 1647781930L, new Guid("97f1089f-26bb-47bb-8299-efb8f02e1957"), null },
                    { new Guid("bc114925-bce0-4945-b792-dfa9292b3e73"), new Guid("d1699342-a060-4dcb-8707-dd46bb4e4710"), new Guid("0c3f985e-e28d-4b4f-8dcf-7c989d6a4cda"), 1647781930L, new Guid("798888f4-378a-4b06-9966-c2f5b8a9e9e9"), null },
                    { new Guid("a90647f7-27d8-44ee-9d21-88e2f1a0b1c0"), new Guid("3ea90c43-0a8b-4d0b-b6b2-5fa6ab3be0ea"), new Guid("0c3f985e-e28d-4b4f-8dcf-7c989d6a4cda"), 1647781930L, new Guid("94966d72-ab9e-4689-9bc4-a9726cba0c1c"), null },
                    { new Guid("613b40df-f250-4371-a9d5-d3cb5e2cbbce"), new Guid("b1622035-d705-43d8-8f4b-51d1bb429e86"), new Guid("1cbf3e74-b008-4af1-ae66-66d44120520d"), 1647781930L, new Guid("b4c433da-fbf6-4910-91fe-e04a44a3c9b2"), null },
                    { new Guid("1c629b90-b4c7-4677-8087-1fa01f8f3194"), new Guid("d1699342-a060-4dcb-8707-dd46bb4e4710"), new Guid("da0ee43b-2557-4d71-9c61-e9a1f0a570bf"), 1647781930L, new Guid("dca63e32-3431-46ca-af05-696964ad8193"), null },
                    { new Guid("d89a7eb8-8e34-4541-8476-d9c12cf4bf39"), new Guid("51d6d2c4-6705-4baa-b863-dfc51e493c5c"), new Guid("ee776c3e-a778-430e-bf81-08b871b284f4"), 1647781930L, new Guid("d0124d76-39e2-486a-a981-13c8d86a6b3a"), null },
                    { new Guid("538cc6d4-5e7e-40ba-b53d-c088c242d20e"), new Guid("a5156b6f-54d0-42a7-a3f2-c13a581200bf"), new Guid("8778101f-c3d1-4b01-82ed-74267c535fd2"), 1647781930L, new Guid("04201684-7bb9-429d-bf97-94614d7fb528"), null },
                    { new Guid("a996e26a-73ac-47b2-9f98-1ef697e46a99"), new Guid("3cc7e2fb-634a-475d-bdd9-4878383f8731"), new Guid("1949ecc5-f2e9-4e4c-a843-b2fed63d1f51"), 1647781930L, new Guid("9cc46841-0155-4390-99f3-f7e4d7ac780e"), null },
                    { new Guid("48319c91-3826-4789-a745-f411fde6be9e"), new Guid("c4aa670b-a3ef-4380-98e1-909f0f207103"), new Guid("498bd2ec-1f07-43fb-a04a-d74ecaf0bacd"), 1647781930L, new Guid("58cf84e0-73f5-4c1b-961e-29665e86da87"), null },
                    { new Guid("1384ead9-2700-4231-abe8-bf73d4b87ef2"), new Guid("0c6ef373-1002-4fe5-90aa-411d217feecd"), new Guid("29d594d1-b26f-4d59-92a2-1ac679cc0b0c"), 1647781930L, new Guid("388b0f4a-ed15-4d7b-8a5c-b99ad1cbdad3"), null }
                });

            migrationBuilder.InsertData(
                table: "StudyContracts",
                columns: new[] { "Id", "GroupId", "OptionalCourseId", "SignedAt", "StudentId", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("ead22d30-8694-4a7d-8843-93382f1326e5"), new Guid("4cbf34cb-f771-4e12-8ec7-4ac38c35fb67"), new Guid("f9a6313c-6f65-4883-9a47-dd7098a33406"), 1647781930L, new Guid("6774b573-7200-4d5d-88c0-cef6a816f01f"), null },
                    { new Guid("6b04f080-63ed-460b-9800-9ce7f2a059ac"), new Guid("128c466a-2d16-423a-b514-f91d8055a1ba"), new Guid("f9a6313c-6f65-4883-9a47-dd7098a33406"), 1647781930L, new Guid("74a2131e-49ca-42e8-a50a-fa8addb3a3bd"), null },
                    { new Guid("a6c4c1dc-834e-4ea9-a0ad-f8449cedad00"), new Guid("0c6ef373-1002-4fe5-90aa-411d217feecd"), new Guid("9b6300d8-b20e-4896-9298-f5cb30fb88dc"), 1647781930L, new Guid("d0897d78-3ffc-4624-a205-15aa2700139f"), null },
                    { new Guid("fe6104eb-104c-41aa-bad8-ae15a558b1d1"), new Guid("128c466a-2d16-423a-b514-f91d8055a1ba"), new Guid("0a7d99de-d702-4064-86cd-1605a3245db9"), 1647781930L, new Guid("1fa772cb-9259-465d-b97a-ae2265ca6210"), null },
                    { new Guid("9170e030-7b39-4530-8c0b-0c47c1ed41a3"), new Guid("4cbf34cb-f771-4e12-8ec7-4ac38c35fb67"), new Guid("0a7d99de-d702-4064-86cd-1605a3245db9"), 1647781930L, new Guid("ad12e637-d343-4408-84a9-65cfdfe3dc73"), null },
                    { new Guid("b09358f9-9338-4590-b851-6c158aa4f994"), new Guid("bb3872f3-f46d-45e2-91a6-4032c786e0b6"), new Guid("084a7c2f-5877-4b32-8451-a365ec59cbc4"), 1647781930L, new Guid("c3669e5f-71a0-44ab-8a3c-14b02846bbbb"), null },
                    { new Guid("c85137aa-07c0-4618-824c-3dae220359be"), new Guid("6762477c-1436-4089-be8c-2a36eb17bcf2"), new Guid("9b712f62-b665-4e55-adda-c17301cea5b1"), 1647781930L, new Guid("e0559ad2-d756-4eab-8021-c0afc81c238a"), null },
                    { new Guid("44daec15-6e01-4e2e-9f04-f40a91afe695"), new Guid("f35fb798-7939-418e-8783-58b245c8bd9d"), new Guid("3dddde4a-d8be-4037-9ce8-711c4ea8d25c"), 1647781930L, new Guid("2714b08d-7f60-44ad-9fae-c07d44490839"), null },
                    { new Guid("927a5635-c9f0-4344-974a-bda66a25ae81"), new Guid("b5ba755d-f476-4917-933c-57190a19ba98"), new Guid("640e8cb9-0161-4ade-8227-34c6899f9589"), 1647781930L, new Guid("daad96b5-c534-4e42-83eb-7d6bdc5bfb62"), null },
                    { new Guid("3b06633f-cf63-40fd-a704-d6881c644dbb"), new Guid("6762477c-1436-4089-be8c-2a36eb17bcf2"), new Guid("640e8cb9-0161-4ade-8227-34c6899f9589"), 1647781930L, new Guid("9987eb5c-dc02-43ab-a1e1-cb2f9eb6e3f9"), null },
                    { new Guid("d8ff644a-398c-4602-b81c-a1f0e0abf5fa"), new Guid("f35fb798-7939-418e-8783-58b245c8bd9d"), new Guid("88f73e08-9864-46ff-845d-88c939ee207d"), 1647781930L, new Guid("55fb4ed3-8a69-450a-b8e9-8256f5492496"), null },
                    { new Guid("4474e0c8-e145-4685-980a-14769e30a731"), new Guid("d54eace9-2333-420f-a318-b9c8bf6b4487"), new Guid("b6a65bcb-d5ad-4679-bd3f-ed0a76266fe4"), 1647781930L, new Guid("187b99f1-dc75-4724-acee-0688e37c285e"), null },
                    { new Guid("4d0a6e1b-0512-4980-a4ed-83a068046f50"), new Guid("e5d176bd-ac04-45e4-b0b3-0229930bd5db"), new Guid("238cbe8d-98b1-4e7c-9885-6ed3919b14b1"), 1647781930L, new Guid("65e9b087-2128-47d2-b1f4-72faeda4be77"), null },
                    { new Guid("ec4b3a57-3811-4ae7-91e7-74cfbe2e3560"), new Guid("f80c4207-da1a-4bf5-ace5-3fc2efc68ac6"), new Guid("238cbe8d-98b1-4e7c-9885-6ed3919b14b1"), 1647781930L, new Guid("88cd4327-729b-43d5-8e52-9b4d0b2665e8"), null },
                    { new Guid("52da10c6-8308-47dd-9fa7-2634aedda7a3"), new Guid("b5ba755d-f476-4917-933c-57190a19ba98"), new Guid("9b712f62-b665-4e55-adda-c17301cea5b1"), 1647781930L, new Guid("ed47126b-bac0-4ee1-9089-29594f549127"), null },
                    { new Guid("e8581805-bfe9-4fd2-af0b-adcafab0daa8"), new Guid("4420736c-6ff7-4842-9e12-b32af5a0ae46"), new Guid("084a7c2f-5877-4b32-8451-a365ec59cbc4"), 1647781930L, new Guid("a0054c88-2d59-4e3c-a98e-7f52dc08eaad"), null },
                    { new Guid("e6bc47fe-99b7-477e-8f7a-802d45243678"), new Guid("c4aa670b-a3ef-4380-98e1-909f0f207103"), new Guid("7043b497-4ae4-4bf0-ba88-8ab4fe92056a"), 1647781930L, new Guid("aa3169d1-bbfd-4933-85c2-4f49f3676855"), null },
                    { new Guid("57b9e5f5-5ffb-41c9-ad83-b05bc65f170a"), new Guid("4420736c-6ff7-4842-9e12-b32af5a0ae46"), new Guid("f9d08c50-6ae4-4807-87be-d6c0a6d9b24b"), 1647781930L, new Guid("9f8f6a89-2419-4fe3-8a66-fa9966a98ee5"), null },
                    { new Guid("3fa184e3-7811-4a29-9fe6-c70406b0d369"), new Guid("e9d91c93-b4d0-4f17-ba8b-4b899d9129c9"), new Guid("13291a2b-aea0-4004-980d-433f87b4de5d"), 1647781930L, new Guid("74ff278d-d314-4f09-8845-4fbc0ea1d379"), null },
                    { new Guid("980598b4-14cd-4d7f-9bfe-d61503b039e6"), new Guid("51d6d2c4-6705-4baa-b863-dfc51e493c5c"), new Guid("f55ac4ee-4333-4990-a121-9150f1e575a4"), 1647781930L, new Guid("2b472ca3-f141-48c9-ab38-6a195e189141"), null },
                    { new Guid("683793f1-7f05-47e3-9209-47009464f229"), new Guid("e9d91c93-b4d0-4f17-ba8b-4b899d9129c9"), new Guid("51a0f4fe-21e1-411a-82f0-544c3cf398da"), 1647781930L, new Guid("58496d48-fe44-461e-8200-c742545241ab"), null },
                    { new Guid("02285703-8104-419a-8b9a-7bbfeb118cc6"), new Guid("7846e11d-0257-4c2d-b161-55fb73c3800b"), new Guid("51a0f4fe-21e1-411a-82f0-544c3cf398da"), 1647781930L, new Guid("6bbc0ee6-4921-4439-b34b-72fdc83f9961"), null },
                    { new Guid("b2fa80aa-3576-482d-8b44-7a2708053446"), new Guid("d6e60c34-eafa-46cf-925d-a57cc18f1e89"), new Guid("a6c68aa0-4673-43ae-8597-66802501c46f"), 1647781930L, new Guid("9293b6a7-a036-4351-8792-db04aa5af7b3"), null },
                    { new Guid("d26fbc22-3acf-400d-924e-012ddbf6b0dd"), new Guid("32c398e2-1303-46e6-a239-f3d1374711ed"), new Guid("a6c68aa0-4673-43ae-8597-66802501c46f"), 1647781930L, new Guid("ff362916-b504-41a3-805f-fc866fcc9869"), null },
                    { new Guid("96b51e71-91bc-4b8d-9284-de25cb16c3fa"), new Guid("ea8f77ae-01e1-427c-a63a-fea391795fe5"), new Guid("6e594425-c454-4fc4-a43c-157fe1967345"), 1647781930L, new Guid("d9d6ed4f-a798-403a-a63c-8f792771cb95"), null },
                    { new Guid("6f7a4d41-8cc5-4a10-bfca-61e81774f0b1"), new Guid("32c398e2-1303-46e6-a239-f3d1374711ed"), new Guid("0d8a0935-e929-42ce-b7f5-f44fdc41d414"), 1647781930L, new Guid("3ce1fd54-2160-433e-898b-e68c99beb58b"), null },
                    { new Guid("7ce4e328-8b2e-4073-b9bd-e4c21f8842de"), new Guid("d6e60c34-eafa-46cf-925d-a57cc18f1e89"), new Guid("0d8a0935-e929-42ce-b7f5-f44fdc41d414"), 1647781930L, new Guid("9be9c274-648c-4e23-869a-2edd4c2a203f"), null },
                    { new Guid("dac48c46-45f1-4046-8144-82ee756b7081"), new Guid("ea8f77ae-01e1-427c-a63a-fea391795fe5"), new Guid("e2d313cb-52f1-46bf-8dbb-f52d6a754c38"), 1647781930L, new Guid("eb173913-be12-4ec9-823d-a76228d49f25"), null },
                    { new Guid("c45771fc-8ea3-454b-bc21-70f826e91477"), new Guid("a8b36863-5eb4-4c5e-9068-8709d02cec31"), new Guid("a8ce02a5-1cf6-4957-9d81-bf041145645e"), 1647781930L, new Guid("609c1c51-cbdc-41cb-96cd-df974ec96f66"), null },
                    { new Guid("1a8a6595-cd74-493d-bd09-cf8ba4916763"), new Guid("cafc442d-70ff-41f1-b2af-04094ba8f252"), new Guid("4b264ca0-b71b-4ca1-b580-3d791aa3c87b"), 1647781930L, new Guid("4497e812-b06e-42a6-b1f1-bb8943367274"), null },
                    { new Guid("da29a2b3-9677-45f0-9c3a-181ae91ef501"), new Guid("c18c1c95-47de-460a-88f9-791f848ce0e5"), new Guid("4b264ca0-b71b-4ca1-b580-3d791aa3c87b"), 1647781930L, new Guid("4eb30257-b721-4f03-a24d-4d7aa9f1c081"), null },
                    { new Guid("e22c897f-e947-4374-923f-e20472cdd9ad"), new Guid("a8b36863-5eb4-4c5e-9068-8709d02cec31"), new Guid("3f18b244-1030-4457-a2da-0a3763f75ba8"), 1647781930L, new Guid("6f55bc98-5098-49fe-a642-b160755432cf"), null },
                    { new Guid("087c8539-bb46-4f5b-b74e-207f83862805"), new Guid("c18c1c95-47de-460a-88f9-791f848ce0e5"), new Guid("df2d9127-a947-4eaa-a363-cb0121695e17"), 1647781930L, new Guid("b83b0979-6a2a-4f6a-839f-bd3800b5bbde"), null },
                    { new Guid("f9607212-1c85-42cc-9dc2-4a404ded271d"), new Guid("cafc442d-70ff-41f1-b2af-04094ba8f252"), new Guid("df2d9127-a947-4eaa-a363-cb0121695e17"), 1647781930L, new Guid("9c652d82-d255-4153-9534-f16d659220ce"), null },
                    { new Guid("b70c8118-04d5-4e2c-ba8b-d7ea21f15313"), new Guid("bb3872f3-f46d-45e2-91a6-4032c786e0b6"), new Guid("f9d08c50-6ae4-4807-87be-d6c0a6d9b24b"), 1647781930L, new Guid("22c95cc3-864f-4d3c-a724-f8c99ca66554"), null },
                    { new Guid("42780c3b-43ac-4791-86fc-33bfa30540b9"), new Guid("d54eace9-2333-420f-a318-b9c8bf6b4487"), new Guid("11b10126-73cf-4a44-984d-929679b9caf4"), 1647781930L, new Guid("a1c21055-059f-4bbe-91ce-6b5b74b60ce6"), null },
                    { new Guid("69764114-510b-46dc-a1a0-791c9bca1fe8"), new Guid("f80c4207-da1a-4bf5-ace5-3fc2efc68ac6"), new Guid("0f3e35ef-a9eb-4980-a820-a20d0231199d"), 1647781930L, new Guid("9b17143b-d672-4017-bf8b-a5365d1856ff"), null },
                    { new Guid("0bc66231-899b-4d2d-85d5-aff0dd50e28d"), new Guid("e5d176bd-ac04-45e4-b0b3-0229930bd5db"), new Guid("0f3e35ef-a9eb-4980-a820-a20d0231199d"), 1647781930L, new Guid("51d3c047-04b2-4180-999e-45fc5f34c085"), null },
                    { new Guid("b4310313-d6ad-4155-b59d-2d77fb0c3031"), new Guid("84b305bf-fe02-49e7-bb5c-344c140b20c9"), new Guid("bebdca91-3419-4868-987a-926bc7dcd4d7"), 1647781930L, new Guid("7acce61f-3fe2-4a52-98c5-9d143e44accd"), null },
                    { new Guid("8fa9f214-625e-4570-93c7-ddf5f1169262"), new Guid("e5f4cf97-f96e-4bd4-ae48-db5211d8c640"), new Guid("90fda2a3-a54e-413c-9669-f86a44d14f89"), 1647781930L, new Guid("1c34551e-db99-4e22-a0d3-335ae0365e2e"), null },
                    { new Guid("dda184a2-bb52-450a-be40-26bb573f87a9"), new Guid("0b5dd85d-8633-4b18-a4e4-c26fdafc673f"), new Guid("a012dc17-6070-4917-bd0e-907bb3288107"), 1647781930L, new Guid("33d83e89-2847-4d20-bf48-d0f0e1d78a6c"), null },
                    { new Guid("e7b3816c-3904-4a42-abdb-69daf83b768b"), new Guid("366805fb-6726-4abd-8a55-53d9fde7e94f"), new Guid("a012dc17-6070-4917-bd0e-907bb3288107"), 1647781930L, new Guid("cae8f338-75fb-43b8-85a0-da555be55727"), null }
                });

            migrationBuilder.InsertData(
                table: "StudyContracts",
                columns: new[] { "Id", "GroupId", "OptionalCourseId", "SignedAt", "StudentId", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("1a7ed3d9-a529-4c28-af62-b2eb5f7067c0"), new Guid("249dd5a6-7a1b-47af-83ec-836721cdb26f"), new Guid("966c1074-13c9-4185-882b-e6044d92b5ec"), 1647781930L, new Guid("bbfc8107-929d-4aab-8b28-7616f5814396"), null },
                    { new Guid("8e87601b-44d3-4197-856a-8df7845b9cbb"), new Guid("0d5752f9-087d-4900-aa52-ffe1f1e5806b"), new Guid("966c1074-13c9-4185-882b-e6044d92b5ec"), 1647781930L, new Guid("e7c67907-2ba5-4cab-acc2-3d074a1b04fd"), null },
                    { new Guid("09f29df1-2bd8-4fc8-93db-7d1685aba22d"), new Guid("a6a817b7-3b98-4c6a-a9b6-124b01b4efea"), new Guid("12a596ed-e4a6-467b-ab41-835b214ac866"), 1647781930L, new Guid("f9d9c6ab-9605-4be0-bf73-3138e09485d9"), null },
                    { new Guid("f0b808d2-7902-4820-b74e-21e47ec2cad4"), new Guid("0d5752f9-087d-4900-aa52-ffe1f1e5806b"), new Guid("e44a4cc7-56ce-44fc-aa81-cecea4e5f978"), 1647781930L, new Guid("b7aad71e-ce21-49ca-948f-226796882c25"), null },
                    { new Guid("026f8207-aaf7-4a42-b7e8-29e1d8b6515c"), new Guid("249dd5a6-7a1b-47af-83ec-836721cdb26f"), new Guid("e44a4cc7-56ce-44fc-aa81-cecea4e5f978"), 1647781930L, new Guid("b8f0a5f6-f95b-4229-b5ac-bcb93cda97c9"), null },
                    { new Guid("ec646450-887d-42b5-94a0-3cb0844c3434"), new Guid("a6a817b7-3b98-4c6a-a9b6-124b01b4efea"), new Guid("2b318988-6722-4714-95ae-a39483ba18fe"), 1647781930L, new Guid("2d497cd0-bee9-49c0-babd-25e8da2a9a1e"), null },
                    { new Guid("4d4fcd33-a291-4d4d-a843-70eac6fc54c6"), new Guid("ce36ea74-1a50-452a-9b9d-9408749eb8b2"), new Guid("4b2fe408-cce3-4a54-936f-3a96a9a649e2"), 1647781930L, new Guid("f2737157-9ceb-4e62-8fa1-7ac95b94b535"), null },
                    { new Guid("f848fa4e-a8a1-4c85-a575-3bdbb7d9c781"), new Guid("7f704350-6559-476f-8506-f7d77c94a69c"), new Guid("1ac53308-4f5b-424b-8634-b37bbb3240ed"), 1647781930L, new Guid("b8aa879e-aba4-4bb3-a21e-80986743f329"), null },
                    { new Guid("1b479965-b74d-4950-b05b-624691f62399"), new Guid("1d2bfc9d-edcf-443a-9b69-b490c837a5e3"), new Guid("1ac53308-4f5b-424b-8634-b37bbb3240ed"), 1647781930L, new Guid("9fca6d1c-5d29-422f-b697-13089f084804"), null },
                    { new Guid("cc02ba02-67ad-4d3f-a6c3-a62b5e3cc1c1"), new Guid("ce36ea74-1a50-452a-9b9d-9408749eb8b2"), new Guid("c19a1c5b-42f1-454f-8908-49a8113e268f"), 1647781930L, new Guid("4b74c468-4b10-429f-af14-57f82c38074e"), null },
                    { new Guid("0a9af5f4-57bb-48a2-9d06-ee8658d22f33"), new Guid("1d2bfc9d-edcf-443a-9b69-b490c837a5e3"), new Guid("b744410d-337e-4268-9b31-f9f7b975c2ec"), 1647781930L, new Guid("96eafb06-3ef5-4d35-a126-cd859ebab54b"), null },
                    { new Guid("5be481ed-7aee-43d5-b706-0181efadc8ca"), new Guid("7f704350-6559-476f-8506-f7d77c94a69c"), new Guid("b744410d-337e-4268-9b31-f9f7b975c2ec"), 1647781930L, new Guid("a69b8d47-1187-45d4-814a-ce9257946a4a"), null },
                    { new Guid("9de36093-87d9-46c2-ae2e-bb060584da73"), new Guid("a5156b6f-54d0-42a7-a3f2-c13a581200bf"), new Guid("c0ff419f-525d-4b5f-a35c-7c3557b09a7f"), 1647781930L, new Guid("6640d55c-1fec-4f4b-b20c-090874155d04"), null },
                    { new Guid("d1ddbb4b-568f-40a5-be8b-9498298a6d1e"), new Guid("9619f5c4-3f71-47b9-9950-87882623b578"), new Guid("c0ff419f-525d-4b5f-a35c-7c3557b09a7f"), 1647781930L, new Guid("88fbf6b1-56bf-4244-adb3-1b9a1986c34f"), null },
                    { new Guid("4e625259-7643-46ec-adb4-5f71bec699ac"), new Guid("0b5dd85d-8633-4b18-a4e4-c26fdafc673f"), new Guid("316b0275-1a26-41a4-8930-d2c0c07f8511"), 1647781930L, new Guid("ba7ba6f5-efce-4ff6-a596-7754338da65d"), null },
                    { new Guid("63cc1c60-aaea-40df-a806-ee50ece0d575"), new Guid("9619f5c4-3f71-47b9-9950-87882623b578"), new Guid("8778101f-c3d1-4b01-82ed-74267c535fd2"), 1647781930L, new Guid("00cfaf2e-77ab-419b-85e1-9eb50bcab65b"), null },
                    { new Guid("421e4d32-7f80-4c97-9a4e-eeffb380a5f1"), new Guid("83d4325e-c5e0-4383-8599-f5a37c7a8c50"), new Guid("316b0275-1a26-41a4-8930-d2c0c07f8511"), 1647781930L, new Guid("ba7ba6f5-efce-4ff6-a596-7754338da65d"), null },
                    { new Guid("e6240d78-e688-49e9-a7eb-1775fada266c"), new Guid("e5f4cf97-f96e-4bd4-ae48-db5211d8c640"), new Guid("73419f68-99c1-400d-9a86-1291a25d2879"), 1647781930L, new Guid("0b78ab89-9922-4fca-9324-53468e94f42d"), null },
                    { new Guid("60ed2d16-762e-496f-87fc-4b6b47f5b582"), new Guid("bfea7927-22d0-4223-9815-618332d7244b"), new Guid("bebdca91-3419-4868-987a-926bc7dcd4d7"), 1647781930L, new Guid("78d042f0-bc66-4142-9ca0-360d532a84de"), null },
                    { new Guid("3676a70c-95c5-44e6-85d0-fabea661bda1"), new Guid("5ccc6202-e67e-4956-892f-947ae4bdecb7"), new Guid("6aa7c940-ab95-4d20-a3b8-a75eebcc7022"), 1647781930L, new Guid("2013f71f-3396-4c41-9978-79a219896a6c"), null },
                    { new Guid("0e19e68f-3d6a-40e7-8b7c-f388ee5e1ad7"), new Guid("bfea7927-22d0-4223-9815-618332d7244b"), new Guid("cb59500e-7ec1-4f74-a79f-c7b71dcce144"), 1647781930L, new Guid("6cc23fe4-411e-4646-9994-7cc46252e727"), null },
                    { new Guid("3a649792-6726-43c7-8128-6177d8cb7015"), new Guid("84b305bf-fe02-49e7-bb5c-344c140b20c9"), new Guid("cb59500e-7ec1-4f74-a79f-c7b71dcce144"), 1647781930L, new Guid("ca1c12ca-c9a3-4695-bdfe-a24b5cc068a8"), null },
                    { new Guid("ed65b9bc-e360-4706-ac19-6a353e77da19"), new Guid("5ccc6202-e67e-4956-892f-947ae4bdecb7"), new Guid("7eae90ae-7632-4941-8eff-224b453830af"), 1647781930L, new Guid("fda7fbe1-71fb-4bc7-a626-5a2e8173e5bb"), null },
                    { new Guid("88f941dc-e632-48a9-9672-b514192af7c8"), new Guid("75ec85f2-1d60-47e1-81a2-cf239caa5bb2"), new Guid("9a274d7e-5685-4998-b454-fe5473610beb"), 1647781930L, new Guid("ec22172b-660c-46e4-a4a6-283e08b96740"), null },
                    { new Guid("3c888d10-b21e-4b2b-b068-581020339e1f"), new Guid("40e23e3b-9147-4a3f-83d8-2bfd65a74d6a"), new Guid("6abfc635-39ac-4b89-8acc-34761c5a890d"), 1647781930L, new Guid("2b3498c6-10a0-426c-93a3-2622d26b841f"), null },
                    { new Guid("6e3ab22a-af1e-4cac-b42e-02626d86a580"), new Guid("effa59e4-86f9-4eae-9bd8-fa5be29daa4b"), new Guid("6abfc635-39ac-4b89-8acc-34761c5a890d"), 1647781930L, new Guid("38fbaba1-020b-47cd-b57d-557d02d9f38b"), null },
                    { new Guid("5e20652a-daf2-4ccc-a7e7-f327544e4d1b"), new Guid("75ec85f2-1d60-47e1-81a2-cf239caa5bb2"), new Guid("26fb7645-a5f0-4cc6-bf6c-f9b13f816525"), 1647781930L, new Guid("debc8434-5db8-4a6b-abc4-132837b26f6b"), null },
                    { new Guid("8a9718f0-0160-407f-bc10-33527d9237f4"), new Guid("effa59e4-86f9-4eae-9bd8-fa5be29daa4b"), new Guid("a62d2987-4ecf-4f6a-af9c-6f808f6b85a3"), 1647781930L, new Guid("9dd19ed5-05e0-4aa7-b933-2832a2ca3052"), null },
                    { new Guid("07b3c735-44f5-4dfb-be8b-35722abd224a"), new Guid("40e23e3b-9147-4a3f-83d8-2bfd65a74d6a"), new Guid("a62d2987-4ecf-4f6a-af9c-6f808f6b85a3"), 1647781930L, new Guid("2293caa9-4cb8-4398-b99c-21e35429c8bb"), null },
                    { new Guid("79f5173b-a1a7-4d67-948c-b79ba8543d15"), new Guid("9b89b944-644a-488d-8e0c-e2518f17da3e"), new Guid("e52beae5-1f71-4228-8aff-c3bf5518ae4f"), 1647781930L, new Guid("511b0914-a3f0-4bfd-829d-e20dad19b485"), null },
                    { new Guid("7ab924bd-ab22-4d23-ac74-673a35b6ef2a"), new Guid("3b92cc8e-a82c-4405-b84b-51b8dd8686c6"), new Guid("e52beae5-1f71-4228-8aff-c3bf5518ae4f"), 1647781930L, new Guid("83649640-cd1c-430e-8978-04c7465128ea"), null },
                    { new Guid("28f1b334-5f5b-438f-a981-c55f9a6efbe8"), new Guid("494ea6fd-ff9d-4f31-ae0a-c544d9ad455b"), new Guid("d0a4d0de-61e4-4ccf-bd23-58307b8cd9ce"), 1647781930L, new Guid("3e192081-d7ea-4b18-b630-f54a03c98803"), null },
                    { new Guid("12792dea-1aa4-4b45-828b-8c1b41601e9f"), new Guid("3b92cc8e-a82c-4405-b84b-51b8dd8686c6"), new Guid("3d8ce4c9-cb0c-418a-8264-c17d82781318"), 1647781930L, new Guid("2ea179f1-87dc-427a-a259-1152d6877613"), null },
                    { new Guid("3f627b2f-cc2c-4de1-9739-a102dc210f66"), new Guid("9b89b944-644a-488d-8e0c-e2518f17da3e"), new Guid("3d8ce4c9-cb0c-418a-8264-c17d82781318"), 1647781930L, new Guid("ab5d06a7-851c-46e7-8f5e-6153419ce8fc"), null },
                    { new Guid("37181a79-a899-4eee-9f88-6a1a95d06716"), new Guid("494ea6fd-ff9d-4f31-ae0a-c544d9ad455b"), new Guid("72c6f44a-8b65-4680-98ef-8af360859c53"), 1647781930L, new Guid("eceeb4fa-d83e-49dc-98cc-c3b1c3b7ee75"), null },
                    { new Guid("bdd8cdbf-17ea-4fe1-a603-e23cbde59041"), new Guid("366805fb-6726-4abd-8a55-53d9fde7e94f"), new Guid("316b0275-1a26-41a4-8930-d2c0c07f8511"), 1647781930L, new Guid("f59f1af2-80d2-4c7c-961f-236bccdca5b9"), null },
                    { new Guid("450268ab-98f7-4d44-aa2a-64f4d05fe380"), new Guid("c7f35476-928f-435a-afda-c0022ab40097"), new Guid("f3c64975-3db8-4e33-8f49-416980d83fb7"), 1647781930L, new Guid("02818ffd-0589-4354-9300-85fc7438e701"), null }
                });

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
                name: "IX_Groups_StudyYearId",
                table: "Groups",
                column: "StudyYearId");

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
                name: "IX_OptionalCoursePreferences_StudyContractId",
                table: "OptionalCoursePreferences",
                column: "StudyContractId");

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
                name: "IX_Specialisations_StudyDegreeId",
                table: "Specialisations",
                column: "StudyDegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyContracts_GroupId",
                table: "StudyContracts",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyContracts_OptionalCourseId",
                table: "StudyContracts",
                column: "OptionalCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyContracts_StudentId",
                table: "StudyContracts",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyContracts_StudyYearId",
                table: "StudyContracts",
                column: "StudyYearId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyDegrees_FacultyId",
                table: "StudyDegrees",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_StudySemesters_StudyYearId",
                table: "StudySemesters",
                column: "StudyYearId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyYears_SpecialisationId",
                table: "StudyYears",
                column: "SpecialisationId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyYears_StudentLeaderUserId",
                table: "StudyYears",
                column: "StudentLeaderUserId",
                unique: true,
                filter: "[StudentLeaderUserId] IS NOT NULL");

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
                name: "Courses");

            migrationBuilder.DropTable(
                name: "StudyContracts");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "OptionalCourses");

            migrationBuilder.DropTable(
                name: "StudySemesters");

            migrationBuilder.DropTable(
                name: "StudyYears");

            migrationBuilder.DropTable(
                name: "Specialisations");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "StudyDegrees");

            migrationBuilder.DropTable(
                name: "Faculties");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "TeacherDegrees");
        }
    }
}
