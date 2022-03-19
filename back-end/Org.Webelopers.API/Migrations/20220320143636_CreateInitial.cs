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
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    { new Guid("1dbb4ccf-5413-4566-877b-ebe4ee3bb5fb"), "dummyEmailHash", "firstName0", "firstName0", "dummyPasswordHash", "dummySalt", "TestAdmin0" },
                    { new Guid("6c43af69-17c0-4bce-9d9c-196e86d9be6d"), "dummyEmailHash", "firstName72", "firstName72", "dummyPasswordHash", "dummySalt", "TestAdmin72" },
                    { new Guid("0422ffef-facb-4742-bccd-42aaaa0e0e18"), "dummyEmailHash", "firstName71", "firstName71", "dummyPasswordHash", "dummySalt", "TestAdmin71" },
                    { new Guid("9b45e54b-11bf-48de-b5a7-c19c26d93ce0"), "dummyEmailHash", "firstName70", "firstName70", "dummyPasswordHash", "dummySalt", "TestAdmin70" },
                    { new Guid("c0f73981-651e-419b-89d9-9b2b6d0d69b6"), "dummyEmailHash", "firstName69", "firstName69", "dummyPasswordHash", "dummySalt", "TestAdmin69" },
                    { new Guid("4a18aac1-bf6c-4545-bc45-249b435417e7"), "dummyEmailHash", "firstName68", "firstName68", "dummyPasswordHash", "dummySalt", "TestAdmin68" },
                    { new Guid("b6f46648-d9d9-41af-99e1-a883ea8a2c2c"), "dummyEmailHash", "firstName67", "firstName67", "dummyPasswordHash", "dummySalt", "TestAdmin67" },
                    { new Guid("1d9ce096-5f84-4bf7-8372-9ae49229141a"), "dummyEmailHash", "firstName66", "firstName66", "dummyPasswordHash", "dummySalt", "TestAdmin66" },
                    { new Guid("944d54bb-a61e-4541-9e28-9454bd7f3ae7"), "dummyEmailHash", "firstName65", "firstName65", "dummyPasswordHash", "dummySalt", "TestAdmin65" },
                    { new Guid("6e9ea27c-94c3-412a-bc39-a8442634743b"), "dummyEmailHash", "firstName64", "firstName64", "dummyPasswordHash", "dummySalt", "TestAdmin64" },
                    { new Guid("34c905e1-67b6-453c-a53c-6764186fc551"), "dummyEmailHash", "firstName63", "firstName63", "dummyPasswordHash", "dummySalt", "TestAdmin63" },
                    { new Guid("66b342c2-24f5-431f-b7a1-26c0a18f91fe"), "dummyEmailHash", "firstName62", "firstName62", "dummyPasswordHash", "dummySalt", "TestAdmin62" },
                    { new Guid("5e1450ef-c8f3-4de1-914d-cdf0fdfe3622"), "dummyEmailHash", "firstName61", "firstName61", "dummyPasswordHash", "dummySalt", "TestAdmin61" },
                    { new Guid("7d1709c2-f990-4326-b35e-fd76dc5594d4"), "dummyEmailHash", "firstName60", "firstName60", "dummyPasswordHash", "dummySalt", "TestAdmin60" },
                    { new Guid("bfb76d4c-60f5-4f2e-8da9-1438bfaf9798"), "dummyEmailHash", "firstName59", "firstName59", "dummyPasswordHash", "dummySalt", "TestAdmin59" },
                    { new Guid("7f7c8efe-fd6a-4993-ace0-94d97241cc52"), "dummyEmailHash", "firstName58", "firstName58", "dummyPasswordHash", "dummySalt", "TestAdmin58" },
                    { new Guid("4e35170c-a330-4971-a83c-a6bb499681d8"), "dummyEmailHash", "firstName57", "firstName57", "dummyPasswordHash", "dummySalt", "TestAdmin57" },
                    { new Guid("35d02632-f41e-4dc3-9e4a-3abfa417af8c"), "dummyEmailHash", "firstName56", "firstName56", "dummyPasswordHash", "dummySalt", "TestAdmin56" },
                    { new Guid("57587de3-3c63-4f9a-a19b-6c218ea1f40a"), "dummyEmailHash", "firstName55", "firstName55", "dummyPasswordHash", "dummySalt", "TestAdmin55" },
                    { new Guid("19d178d2-8f6f-471a-b644-4edb13b902ed"), "dummyEmailHash", "firstName54", "firstName54", "dummyPasswordHash", "dummySalt", "TestAdmin54" },
                    { new Guid("e06bc1ca-83e4-4204-a137-23ba3df705cb"), "dummyEmailHash", "firstName53", "firstName53", "dummyPasswordHash", "dummySalt", "TestAdmin53" },
                    { new Guid("ce851d1e-fb51-436c-a679-f4071dabf1cd"), "dummyEmailHash", "firstName52", "firstName52", "dummyPasswordHash", "dummySalt", "TestAdmin52" },
                    { new Guid("e40dcb01-5ec8-4c2a-a01e-ab62b0cec470"), "dummyEmailHash", "firstName73", "firstName73", "dummyPasswordHash", "dummySalt", "TestAdmin73" },
                    { new Guid("5c5cc17a-3a89-47d5-bb32-cc82d61c005d"), "dummyEmailHash", "firstName74", "firstName74", "dummyPasswordHash", "dummySalt", "TestAdmin74" },
                    { new Guid("252db1a5-ef1e-4c74-a9d5-1ec0192e3e63"), "dummyEmailHash", "firstName75", "firstName75", "dummyPasswordHash", "dummySalt", "TestAdmin75" },
                    { new Guid("ad43c50a-6653-46ae-a05b-69885e645690"), "dummyEmailHash", "firstName76", "firstName76", "dummyPasswordHash", "dummySalt", "TestAdmin76" },
                    { new Guid("004be149-6003-43f6-bf31-204ca72b7ebd"), "dummyEmailHash", "firstName99", "firstName99", "dummyPasswordHash", "dummySalt", "TestAdmin99" },
                    { new Guid("9aed8dc1-22ea-4b80-97a6-f90d4bfc82f9"), "dummyEmailHash", "firstName98", "firstName98", "dummyPasswordHash", "dummySalt", "TestAdmin98" },
                    { new Guid("9956af0d-5f82-462b-89e4-e376b9216248"), "dummyEmailHash", "firstName97", "firstName97", "dummyPasswordHash", "dummySalt", "TestAdmin97" },
                    { new Guid("614cd29c-8099-4e78-94c6-5ba5150f7c5f"), "dummyEmailHash", "firstName96", "firstName96", "dummyPasswordHash", "dummySalt", "TestAdmin96" },
                    { new Guid("924065b0-a4ed-48c7-babd-1a708c6c3ecb"), "dummyEmailHash", "firstName95", "firstName95", "dummyPasswordHash", "dummySalt", "TestAdmin95" },
                    { new Guid("deaa5725-a62b-4217-84fb-58c1cc4901ff"), "dummyEmailHash", "firstName94", "firstName94", "dummyPasswordHash", "dummySalt", "TestAdmin94" },
                    { new Guid("d823f66b-2253-4a4c-ba79-00ee494f8918"), "dummyEmailHash", "firstName93", "firstName93", "dummyPasswordHash", "dummySalt", "TestAdmin93" },
                    { new Guid("9c359bf1-d5d7-4c5c-887c-c707d4766b0b"), "dummyEmailHash", "firstName92", "firstName92", "dummyPasswordHash", "dummySalt", "TestAdmin92" },
                    { new Guid("d1e32799-8829-4c32-ae8e-94f9d9867eaa"), "dummyEmailHash", "firstName91", "firstName91", "dummyPasswordHash", "dummySalt", "TestAdmin91" },
                    { new Guid("c59ff66f-a038-4147-9ef9-1a8ea04b70ca"), "dummyEmailHash", "firstName90", "firstName90", "dummyPasswordHash", "dummySalt", "TestAdmin90" },
                    { new Guid("fb5a4580-f14e-4283-abad-9abefe6d3dd4"), "dummyEmailHash", "firstName51", "firstName51", "dummyPasswordHash", "dummySalt", "TestAdmin51" },
                    { new Guid("81c0ba0e-c733-4ba7-8364-14398393a4e6"), "dummyEmailHash", "firstName88", "firstName88", "dummyPasswordHash", "dummySalt", "TestAdmin88" },
                    { new Guid("5c6d78db-390e-454a-a3db-246525b4149f"), "dummyEmailHash", "firstName86", "firstName86", "dummyPasswordHash", "dummySalt", "TestAdmin86" },
                    { new Guid("4a159e32-2df1-4d48-a0d4-c2ff56e9f5d7"), "dummyEmailHash", "firstName85", "firstName85", "dummyPasswordHash", "dummySalt", "TestAdmin85" },
                    { new Guid("99e06ce0-76d7-4097-ba96-c4ccb90491de"), "dummyEmailHash", "firstName84", "firstName84", "dummyPasswordHash", "dummySalt", "TestAdmin84" },
                    { new Guid("2869f918-bc5b-4a38-b65d-e70cc4b65d89"), "dummyEmailHash", "firstName83", "firstName83", "dummyPasswordHash", "dummySalt", "TestAdmin83" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "EmailHash", "FirstName", "LastName", "PasswordHash", "Salt", "Username" },
                values: new object[,]
                {
                    { new Guid("e5644b7e-f573-4155-a17a-e3c0ca899bb7"), "dummyEmailHash", "firstName82", "firstName82", "dummyPasswordHash", "dummySalt", "TestAdmin82" },
                    { new Guid("5326bad9-09d4-4539-8d25-11c94de72d3c"), "dummyEmailHash", "firstName81", "firstName81", "dummyPasswordHash", "dummySalt", "TestAdmin81" },
                    { new Guid("6eed0e39-c2b9-4a7e-a14b-5e380e36ad00"), "dummyEmailHash", "firstName80", "firstName80", "dummyPasswordHash", "dummySalt", "TestAdmin80" },
                    { new Guid("18ed5367-9a06-4064-b5f0-a87d86f7a6ad"), "dummyEmailHash", "firstName79", "firstName79", "dummyPasswordHash", "dummySalt", "TestAdmin79" },
                    { new Guid("23f750c8-5434-4a06-a7d1-776880085a28"), "dummyEmailHash", "firstName78", "firstName78", "dummyPasswordHash", "dummySalt", "TestAdmin78" },
                    { new Guid("96db4eb6-3ecf-4974-b87b-116e0d8dabec"), "dummyEmailHash", "firstName77", "firstName77", "dummyPasswordHash", "dummySalt", "TestAdmin77" },
                    { new Guid("60ad3246-4ff4-4d9a-9a23-b9e8320f0276"), "dummyEmailHash", "firstName87", "firstName87", "dummyPasswordHash", "dummySalt", "TestAdmin87" },
                    { new Guid("b25fa007-fcbd-49f6-adec-4b37a402e2ed"), "dummyEmailHash", "firstName50", "firstName50", "dummyPasswordHash", "dummySalt", "TestAdmin50" },
                    { new Guid("23ef0e62-ace1-49c7-a5f8-004d2ee6adbb"), "dummyEmailHash", "firstName89", "firstName89", "dummyPasswordHash", "dummySalt", "TestAdmin89" },
                    { new Guid("c2efa611-a37c-475f-96fb-7ddca58a2832"), "dummyEmailHash", "firstName48", "firstName48", "dummyPasswordHash", "dummySalt", "TestAdmin48" },
                    { new Guid("6b36c9a9-8a1a-409d-80de-690329156146"), "dummyEmailHash", "firstName21", "firstName21", "dummyPasswordHash", "dummySalt", "TestAdmin21" },
                    { new Guid("d1b891b5-56d1-4f0f-9f3f-53b825e2b6d1"), "dummyEmailHash", "firstName20", "firstName20", "dummyPasswordHash", "dummySalt", "TestAdmin20" },
                    { new Guid("e4f93d1d-a66c-470a-a831-d62ffc1ffefb"), "dummyEmailHash", "firstName19", "firstName19", "dummyPasswordHash", "dummySalt", "TestAdmin19" },
                    { new Guid("7e2cc815-61f7-4490-ad17-a068febaa633"), "dummyEmailHash", "firstName18", "firstName18", "dummyPasswordHash", "dummySalt", "TestAdmin18" },
                    { new Guid("aef556d1-d79f-4fa4-80dc-73c8d819b426"), "dummyEmailHash", "firstName17", "firstName17", "dummyPasswordHash", "dummySalt", "TestAdmin17" },
                    { new Guid("fbb179f1-e4a8-4904-aff8-a421a636005a"), "dummyEmailHash", "firstName16", "firstName16", "dummyPasswordHash", "dummySalt", "TestAdmin16" },
                    { new Guid("329d0a08-9a05-42d7-a778-78e846367926"), "dummyEmailHash", "firstName15", "firstName15", "dummyPasswordHash", "dummySalt", "TestAdmin15" },
                    { new Guid("2e417bd7-dd07-4d5f-8c38-3f107baa8d2d"), "dummyEmailHash", "firstName14", "firstName14", "dummyPasswordHash", "dummySalt", "TestAdmin14" },
                    { new Guid("984fddcc-9e19-43c1-8663-45ccf15aa7e5"), "dummyEmailHash", "firstName13", "firstName13", "dummyPasswordHash", "dummySalt", "TestAdmin13" },
                    { new Guid("aaac38ec-c0df-47d6-a829-3462e52b4a2a"), "dummyEmailHash", "firstName12", "firstName12", "dummyPasswordHash", "dummySalt", "TestAdmin12" },
                    { new Guid("8d513d19-7ea4-4ea9-ab3a-90a30135caae"), "dummyEmailHash", "firstName11", "firstName11", "dummyPasswordHash", "dummySalt", "TestAdmin11" },
                    { new Guid("d31b1cdb-2d82-4a09-8b4e-599fba8e20c7"), "dummyEmailHash", "firstName10", "firstName10", "dummyPasswordHash", "dummySalt", "TestAdmin10" },
                    { new Guid("60906680-f322-4480-a2d9-f4c74ec27ee8"), "dummyEmailHash", "firstName9", "firstName9", "dummyPasswordHash", "dummySalt", "TestAdmin9" },
                    { new Guid("803c2907-c81c-4f7a-8fa2-46119eb8913d"), "dummyEmailHash", "firstName8", "firstName8", "dummyPasswordHash", "dummySalt", "TestAdmin8" },
                    { new Guid("bbd11363-c65b-42ce-87ad-2b4c0b10663c"), "dummyEmailHash", "firstName7", "firstName7", "dummyPasswordHash", "dummySalt", "TestAdmin7" },
                    { new Guid("a12a70b4-463d-4b10-be03-c35b2f28eb5b"), "dummyEmailHash", "firstName5", "firstName5", "dummyPasswordHash", "dummySalt", "TestAdmin5" },
                    { new Guid("ad210b83-30d9-4b17-9c29-14a52b2c13f7"), "dummyEmailHash", "firstName4", "firstName4", "dummyPasswordHash", "dummySalt", "TestAdmin4" },
                    { new Guid("fd8acd4e-94f9-4eb7-915a-8084befefc55"), "dummyEmailHash", "firstName3", "firstName3", "dummyPasswordHash", "dummySalt", "TestAdmin3" },
                    { new Guid("e435dd51-40ad-4e35-a3e8-c8d949a5826a"), "dummyEmailHash", "firstName2", "firstName2", "dummyPasswordHash", "dummySalt", "TestAdmin2" },
                    { new Guid("8908e192-0574-4498-a50d-82637dd732dc"), "dummyEmailHash", "firstName1", "firstName1", "dummyPasswordHash", "dummySalt", "TestAdmin1" },
                    { new Guid("08cac619-e93e-4fa2-9e69-41fd782d5210"), "dummyEmailHash", "firstName49", "firstName49", "dummyPasswordHash", "dummySalt", "TestAdmin49" },
                    { new Guid("48720cc4-223a-4e83-a6cf-59e121d66b98"), "dummyEmailHash", "firstName22", "firstName22", "dummyPasswordHash", "dummySalt", "TestAdmin22" },
                    { new Guid("d6d9f4b8-3756-4f31-888d-c988832e4560"), "dummyEmailHash", "firstName23", "firstName23", "dummyPasswordHash", "dummySalt", "TestAdmin23" },
                    { new Guid("6042c91b-7238-42af-b490-75c394f36ef4"), "dummyEmailHash", "firstName6", "firstName6", "dummyPasswordHash", "dummySalt", "TestAdmin6" },
                    { new Guid("236cf485-d1f8-4337-9ddb-bd58236b1d13"), "dummyEmailHash", "firstName25", "firstName25", "dummyPasswordHash", "dummySalt", "TestAdmin25" },
                    { new Guid("44e74f59-877d-434e-9a20-aa370ca42972"), "dummyEmailHash", "firstName47", "firstName47", "dummyPasswordHash", "dummySalt", "TestAdmin47" },
                    { new Guid("40137b8e-1418-4a8e-a8d9-4fe84e919c6e"), "dummyEmailHash", "firstName24", "firstName24", "dummyPasswordHash", "dummySalt", "TestAdmin24" },
                    { new Guid("e6d9a15a-48bd-4dd9-94cd-10e14b0e463e"), "dummyEmailHash", "firstName46", "firstName46", "dummyPasswordHash", "dummySalt", "TestAdmin46" },
                    { new Guid("6fe0d17e-ef39-4c14-8e3a-78fc13d2033c"), "dummyEmailHash", "firstName45", "firstName45", "dummyPasswordHash", "dummySalt", "TestAdmin45" },
                    { new Guid("28d1e373-ddf5-409a-b48a-83a1c1161c05"), "dummyEmailHash", "firstName44", "firstName44", "dummyPasswordHash", "dummySalt", "TestAdmin44" },
                    { new Guid("721fd12a-146d-448d-a353-2352749f6e36"), "dummyEmailHash", "firstName42", "firstName42", "dummyPasswordHash", "dummySalt", "TestAdmin42" },
                    { new Guid("9390babd-e168-4804-9b91-c4ce52eef236"), "dummyEmailHash", "firstName41", "firstName41", "dummyPasswordHash", "dummySalt", "TestAdmin41" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "EmailHash", "FirstName", "LastName", "PasswordHash", "Salt", "Username" },
                values: new object[,]
                {
                    { new Guid("2805cc17-1d1e-460c-b968-eae53b527f18"), "dummyEmailHash", "firstName40", "firstName40", "dummyPasswordHash", "dummySalt", "TestAdmin40" },
                    { new Guid("66543362-636d-4606-9e2f-e5c77ec2e8ac"), "dummyEmailHash", "firstName39", "firstName39", "dummyPasswordHash", "dummySalt", "TestAdmin39" },
                    { new Guid("2acb6e2f-f094-418a-a14b-a8b00b75d169"), "dummyEmailHash", "firstName38", "firstName38", "dummyPasswordHash", "dummySalt", "TestAdmin38" },
                    { new Guid("3114d084-cf51-4e33-ab11-aa90dd6b7898"), "dummyEmailHash", "firstName37", "firstName37", "dummyPasswordHash", "dummySalt", "TestAdmin37" },
                    { new Guid("1de52a5b-590e-4500-a84b-e06cfd4b9271"), "dummyEmailHash", "firstName43", "firstName43", "dummyPasswordHash", "dummySalt", "TestAdmin43" },
                    { new Guid("4147b574-6756-4e15-893f-d18e5664fa7f"), "dummyEmailHash", "firstName29", "firstName29", "dummyPasswordHash", "dummySalt", "TestAdmin29" },
                    { new Guid("94ea1d33-6a94-4e5e-b4c5-1f347c394e83"), "dummyEmailHash", "firstName36", "firstName36", "dummyPasswordHash", "dummySalt", "TestAdmin36" },
                    { new Guid("06f0b930-568b-4295-be03-0abe339869b1"), "dummyEmailHash", "firstName28", "firstName28", "dummyPasswordHash", "dummySalt", "TestAdmin28" },
                    { new Guid("051cc4c1-cd25-429a-a0b5-ac8cfd58b1f5"), "dummyEmailHash", "firstName30", "firstName30", "dummyPasswordHash", "dummySalt", "TestAdmin30" },
                    { new Guid("6a60b2e1-3501-44bb-a238-0b5ec9f6c883"), "dummyEmailHash", "firstName31", "firstName31", "dummyPasswordHash", "dummySalt", "TestAdmin31" },
                    { new Guid("6cd07114-5a66-4824-a5b4-93698a703576"), "dummyEmailHash", "firstName27", "firstName27", "dummyPasswordHash", "dummySalt", "TestAdmin27" },
                    { new Guid("67ba2cf5-c415-4d33-8354-3f2e1e7e1a23"), "dummyEmailHash", "firstName32", "firstName32", "dummyPasswordHash", "dummySalt", "TestAdmin32" },
                    { new Guid("e89209fb-2348-496d-a29a-386f9a3b8ea9"), "dummyEmailHash", "firstName33", "firstName33", "dummyPasswordHash", "dummySalt", "TestAdmin33" },
                    { new Guid("849a4b58-8711-43aa-aaec-6ec82f3e20cf"), "dummyEmailHash", "firstName34", "firstName34", "dummyPasswordHash", "dummySalt", "TestAdmin34" },
                    { new Guid("c3125951-1545-43c3-82fe-81612b371178"), "dummyEmailHash", "firstName35", "firstName35", "dummyPasswordHash", "dummySalt", "TestAdmin35" },
                    { new Guid("8bad514a-a851-489f-80fb-19e15be8c688"), "dummyEmailHash", "firstName26", "firstName26", "dummyPasswordHash", "dummySalt", "TestAdmin26" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "EmailHash", "FirstName", "LastName", "PasswordHash", "Salt", "Username" },
                values: new object[,]
                {
                    { new Guid("498890aa-b2d9-4f17-9655-296668070b73"), 732624581L, "dummyEmailHash", "firstName220", "firstName220", "dummyPasswordHash", "dummySalt", "TestStudent220" },
                    { new Guid("7e430a2b-32bc-4e9b-b879-745ab1aef3a9"), 732624581L, "dummyEmailHash", "firstName214", "firstName214", "dummyPasswordHash", "dummySalt", "TestStudent214" },
                    { new Guid("4a135aca-13a7-40f1-8a06-a7c6feb5a86f"), 732624581L, "dummyEmailHash", "firstName219", "firstName219", "dummyPasswordHash", "dummySalt", "TestStudent219" },
                    { new Guid("abb4e237-62c7-44e9-ac45-00e6a3c9fea9"), 732624581L, "dummyEmailHash", "firstName218", "firstName218", "dummyPasswordHash", "dummySalt", "TestStudent218" },
                    { new Guid("b5433351-d2fd-4189-b61f-cad1bc745503"), 732624581L, "dummyEmailHash", "firstName217", "firstName217", "dummyPasswordHash", "dummySalt", "TestStudent217" },
                    { new Guid("6fff1278-42d4-4156-ba25-09613d2a09af"), 732624581L, "dummyEmailHash", "firstName216", "firstName216", "dummyPasswordHash", "dummySalt", "TestStudent216" },
                    { new Guid("029687cd-540a-4e29-9928-70bdec6bf879"), 732624581L, "dummyEmailHash", "firstName215", "firstName215", "dummyPasswordHash", "dummySalt", "TestStudent215" },
                    { new Guid("b28b0111-9144-4e2e-9607-85a3ee198caa"), 732624581L, "dummyEmailHash", "firstName205", "firstName205", "dummyPasswordHash", "dummySalt", "TestStudent205" },
                    { new Guid("e8063d35-47ed-4f4f-b395-84668d31e1a6"), 732624581L, "dummyEmailHash", "firstName210", "firstName210", "dummyPasswordHash", "dummySalt", "TestStudent210" },
                    { new Guid("e685708f-ea4b-4f04-8391-d00c91fbacd8"), 732624581L, "dummyEmailHash", "firstName212", "firstName212", "dummyPasswordHash", "dummySalt", "TestStudent212" },
                    { new Guid("b9ac4919-78e7-4730-9b53-626e37a8c7dc"), 732624581L, "dummyEmailHash", "firstName211", "firstName211", "dummyPasswordHash", "dummySalt", "TestStudent211" },
                    { new Guid("fc6579c5-99e4-4a47-828c-59eae285a105"), 732624581L, "dummyEmailHash", "firstName209", "firstName209", "dummyPasswordHash", "dummySalt", "TestStudent209" },
                    { new Guid("a2d251f7-5129-406a-a6b4-c1e4c996eb9f"), 732624581L, "dummyEmailHash", "firstName208", "firstName208", "dummyPasswordHash", "dummySalt", "TestStudent208" },
                    { new Guid("e3cca282-eb69-43e5-a639-80746e532af4"), 732624581L, "dummyEmailHash", "firstName207", "firstName207", "dummyPasswordHash", "dummySalt", "TestStudent207" },
                    { new Guid("39924560-12c6-45db-90bd-9c645ffc68ef"), 732624581L, "dummyEmailHash", "firstName221", "firstName221", "dummyPasswordHash", "dummySalt", "TestStudent221" },
                    { new Guid("f3d7e5b3-91a7-4091-b1d4-70d977015a97"), 732624581L, "dummyEmailHash", "firstName206", "firstName206", "dummyPasswordHash", "dummySalt", "TestStudent206" },
                    { new Guid("68306c6b-2c57-495c-a51e-ac45f7e88ca5"), 732624581L, "dummyEmailHash", "firstName213", "firstName213", "dummyPasswordHash", "dummySalt", "TestStudent213" },
                    { new Guid("104286ed-bef5-4225-aa2a-ce23cc959565"), 732624581L, "dummyEmailHash", "firstName222", "firstName222", "dummyPasswordHash", "dummySalt", "TestStudent222" },
                    { new Guid("b0e76f2b-23f7-4c86-80e0-3893b50b360f"), 732624581L, "dummyEmailHash", "firstName233", "firstName233", "dummyPasswordHash", "dummySalt", "TestStudent233" },
                    { new Guid("cbcfe3d0-78dd-4cd0-b0fe-48aa4381baff"), 732624581L, "dummyEmailHash", "firstName224", "firstName224", "dummyPasswordHash", "dummySalt", "TestStudent224" },
                    { new Guid("3dbe9795-2646-4328-b8da-116461317c7a"), 732624581L, "dummyEmailHash", "firstName241", "firstName241", "dummyPasswordHash", "dummySalt", "TestStudent241" },
                    { new Guid("acdaa934-2f77-4a09-8636-940a3e799fa9"), 732624581L, "dummyEmailHash", "firstName204", "firstName204", "dummyPasswordHash", "dummySalt", "TestStudent204" },
                    { new Guid("b7dd3531-470d-4fa2-981a-013623b45c39"), 732624581L, "dummyEmailHash", "firstName240", "firstName240", "dummyPasswordHash", "dummySalt", "TestStudent240" },
                    { new Guid("c6fb3335-b3d2-4549-b4ea-189a5da3888c"), 732624581L, "dummyEmailHash", "firstName239", "firstName239", "dummyPasswordHash", "dummySalt", "TestStudent239" },
                    { new Guid("2fbaff75-b3d7-4446-a9ee-1a4f57821abc"), 732624581L, "dummyEmailHash", "firstName238", "firstName238", "dummyPasswordHash", "dummySalt", "TestStudent238" },
                    { new Guid("6092dfbd-a8dc-43a9-b594-45344f3981cb"), 732624581L, "dummyEmailHash", "firstName237", "firstName237", "dummyPasswordHash", "dummySalt", "TestStudent237" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "EmailHash", "FirstName", "LastName", "PasswordHash", "Salt", "Username" },
                values: new object[,]
                {
                    { new Guid("ee16b62b-de15-4957-a929-868772ca9c56"), 732624581L, "dummyEmailHash", "firstName236", "firstName236", "dummyPasswordHash", "dummySalt", "TestStudent236" },
                    { new Guid("49fd54da-83d4-488d-bff6-4ce4f5de6369"), 732624581L, "dummyEmailHash", "firstName235", "firstName235", "dummyPasswordHash", "dummySalt", "TestStudent235" },
                    { new Guid("4a70ac57-6eee-461a-b9c4-ecaed19de418"), 732624581L, "dummyEmailHash", "firstName234", "firstName234", "dummyPasswordHash", "dummySalt", "TestStudent234" },
                    { new Guid("1dad04fc-3a6a-422a-a9ed-cde3e9de3243"), 732624581L, "dummyEmailHash", "firstName232", "firstName232", "dummyPasswordHash", "dummySalt", "TestStudent232" },
                    { new Guid("e42d1d91-c378-4444-b1d6-ce8853879377"), 732624581L, "dummyEmailHash", "firstName231", "firstName231", "dummyPasswordHash", "dummySalt", "TestStudent231" },
                    { new Guid("02c2ba64-0eab-4371-8720-2f648fb24cd2"), 732624581L, "dummyEmailHash", "firstName230", "firstName230", "dummyPasswordHash", "dummySalt", "TestStudent230" },
                    { new Guid("bd20d12e-7af3-451e-a1e8-a8c6a79a612c"), 732624581L, "dummyEmailHash", "firstName229", "firstName229", "dummyPasswordHash", "dummySalt", "TestStudent229" },
                    { new Guid("9b8a47c8-541e-4f12-b475-bda37c711a63"), 732624581L, "dummyEmailHash", "firstName228", "firstName228", "dummyPasswordHash", "dummySalt", "TestStudent228" },
                    { new Guid("d1122ea9-142a-495c-8e86-a0ce3908e68f"), 732624581L, "dummyEmailHash", "firstName227", "firstName227", "dummyPasswordHash", "dummySalt", "TestStudent227" },
                    { new Guid("b3ace2d3-eb4b-4228-bd0c-a7140dafc193"), 732624581L, "dummyEmailHash", "firstName226", "firstName226", "dummyPasswordHash", "dummySalt", "TestStudent226" },
                    { new Guid("d8e37b87-a231-4d24-82c0-54f2e0fcbb40"), 732624581L, "dummyEmailHash", "firstName225", "firstName225", "dummyPasswordHash", "dummySalt", "TestStudent225" },
                    { new Guid("73136877-d126-41a6-b9b1-2a647037f4c6"), 732624581L, "dummyEmailHash", "firstName223", "firstName223", "dummyPasswordHash", "dummySalt", "TestStudent223" },
                    { new Guid("71cbeeee-1bf5-407b-8dd8-36e62fde3a79"), 732624581L, "dummyEmailHash", "firstName203", "firstName203", "dummyPasswordHash", "dummySalt", "TestStudent203" },
                    { new Guid("8728511e-ea06-44a5-b0c9-e80a114c10c0"), 732624581L, "dummyEmailHash", "firstName179", "firstName179", "dummyPasswordHash", "dummySalt", "TestStudent179" },
                    { new Guid("657d11eb-d104-4856-a54f-3ae5037b06f0"), 732624581L, "dummyEmailHash", "firstName201", "firstName201", "dummyPasswordHash", "dummySalt", "TestStudent201" },
                    { new Guid("2ab25825-0066-4d1e-9098-aaea358c0632"), 732624581L, "dummyEmailHash", "firstName178", "firstName178", "dummyPasswordHash", "dummySalt", "TestStudent178" },
                    { new Guid("ede3806c-24b2-4caf-974b-20b608430d61"), 732624581L, "dummyEmailHash", "firstName177", "firstName177", "dummyPasswordHash", "dummySalt", "TestStudent177" },
                    { new Guid("6dee2159-93c5-4840-b02c-0a60d268f282"), 732624581L, "dummyEmailHash", "firstName176", "firstName176", "dummyPasswordHash", "dummySalt", "TestStudent176" },
                    { new Guid("c1addc98-abc7-4493-a562-633a1e719f77"), 732624581L, "dummyEmailHash", "firstName175", "firstName175", "dummyPasswordHash", "dummySalt", "TestStudent175" },
                    { new Guid("034205a1-5249-47f4-8951-61cbf368b5dc"), 732624581L, "dummyEmailHash", "firstName174", "firstName174", "dummyPasswordHash", "dummySalt", "TestStudent174" },
                    { new Guid("f2febae9-35f3-4b86-b3b3-b1e1ecb4e861"), 732624581L, "dummyEmailHash", "firstName173", "firstName173", "dummyPasswordHash", "dummySalt", "TestStudent173" },
                    { new Guid("102ab3b0-919e-48b0-9fb1-925aa313869d"), 732624581L, "dummyEmailHash", "firstName172", "firstName172", "dummyPasswordHash", "dummySalt", "TestStudent172" },
                    { new Guid("b88e69ab-96b0-4c31-875b-87db21c52748"), 732624581L, "dummyEmailHash", "firstName180", "firstName180", "dummyPasswordHash", "dummySalt", "TestStudent180" },
                    { new Guid("839f9d3b-e785-4b39-8130-33ac35670340"), 732624581L, "dummyEmailHash", "firstName171", "firstName171", "dummyPasswordHash", "dummySalt", "TestStudent171" },
                    { new Guid("87a8f497-6a15-4f69-9094-66adcd3b13b2"), 732624581L, "dummyEmailHash", "firstName169", "firstName169", "dummyPasswordHash", "dummySalt", "TestStudent169" },
                    { new Guid("b6b2b206-598d-41e3-b410-4c3acf449735"), 732624581L, "dummyEmailHash", "firstName168", "firstName168", "dummyPasswordHash", "dummySalt", "TestStudent168" },
                    { new Guid("70d9f5de-f8fe-469e-aa65-68f5e659dd84"), 732624581L, "dummyEmailHash", "firstName167", "firstName167", "dummyPasswordHash", "dummySalt", "TestStudent167" },
                    { new Guid("3f40c9db-1d84-4673-b8b0-73fc6ea7d248"), 732624581L, "dummyEmailHash", "firstName166", "firstName166", "dummyPasswordHash", "dummySalt", "TestStudent166" },
                    { new Guid("e49c781a-6856-47a2-a206-3fd03874608f"), 732624581L, "dummyEmailHash", "firstName165", "firstName165", "dummyPasswordHash", "dummySalt", "TestStudent165" },
                    { new Guid("664befdf-b645-4d8c-aa73-d14496869eba"), 732624581L, "dummyEmailHash", "firstName164", "firstName164", "dummyPasswordHash", "dummySalt", "TestStudent164" },
                    { new Guid("dbe00385-6825-43b5-b976-8d98e6e8e000"), 732624581L, "dummyEmailHash", "firstName242", "firstName242", "dummyPasswordHash", "dummySalt", "TestStudent242" },
                    { new Guid("4032b233-6023-43f0-a1f1-2c0941eaedd7"), 732624581L, "dummyEmailHash", "firstName170", "firstName170", "dummyPasswordHash", "dummySalt", "TestStudent170" },
                    { new Guid("a5a596fa-2419-45a8-b1c8-16d399e326b4"), 732624581L, "dummyEmailHash", "firstName181", "firstName181", "dummyPasswordHash", "dummySalt", "TestStudent181" },
                    { new Guid("82be3127-ceef-4a1d-9480-bc114fc05137"), 732624581L, "dummyEmailHash", "firstName182", "firstName182", "dummyPasswordHash", "dummySalt", "TestStudent182" },
                    { new Guid("2ea92a17-9605-4e8d-bd3b-61465a47ffe8"), 732624581L, "dummyEmailHash", "firstName183", "firstName183", "dummyPasswordHash", "dummySalt", "TestStudent183" },
                    { new Guid("74a645cf-4626-4325-8dee-dbc380528ae6"), 732624581L, "dummyEmailHash", "firstName200", "firstName200", "dummyPasswordHash", "dummySalt", "TestStudent200" },
                    { new Guid("4e3e9429-5c50-4c20-95b7-6a8fedbfb2da"), 732624581L, "dummyEmailHash", "firstName199", "firstName199", "dummyPasswordHash", "dummySalt", "TestStudent199" },
                    { new Guid("7c17fb27-b47a-4edd-91de-688e407e5460"), 732624581L, "dummyEmailHash", "firstName198", "firstName198", "dummyPasswordHash", "dummySalt", "TestStudent198" },
                    { new Guid("83322174-7e4f-494a-b115-27daf6d6e6e1"), 732624581L, "dummyEmailHash", "firstName197", "firstName197", "dummyPasswordHash", "dummySalt", "TestStudent197" },
                    { new Guid("b51ad3a0-635a-4d13-a6fc-edf8fd21fbc2"), 732624581L, "dummyEmailHash", "firstName196", "firstName196", "dummyPasswordHash", "dummySalt", "TestStudent196" },
                    { new Guid("723ab0be-a73a-4611-a8fc-2c8ce51b1be5"), 732624581L, "dummyEmailHash", "firstName195", "firstName195", "dummyPasswordHash", "dummySalt", "TestStudent195" },
                    { new Guid("bfd7054d-299f-4e52-a521-8fb6acfa857f"), 732624581L, "dummyEmailHash", "firstName194", "firstName194", "dummyPasswordHash", "dummySalt", "TestStudent194" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "EmailHash", "FirstName", "LastName", "PasswordHash", "Salt", "Username" },
                values: new object[,]
                {
                    { new Guid("0df20739-b873-4ad0-9537-5d7aa1dd2fa1"), 732624581L, "dummyEmailHash", "firstName193", "firstName193", "dummyPasswordHash", "dummySalt", "TestStudent193" },
                    { new Guid("e1930e3d-90f4-4176-a376-8d1fb8100629"), 732624581L, "dummyEmailHash", "firstName192", "firstName192", "dummyPasswordHash", "dummySalt", "TestStudent192" },
                    { new Guid("add5b217-1bb0-403b-a709-be9f01140f5e"), 732624581L, "dummyEmailHash", "firstName191", "firstName191", "dummyPasswordHash", "dummySalt", "TestStudent191" },
                    { new Guid("8d0e976e-7510-4594-9e04-6e3f53de7148"), 732624581L, "dummyEmailHash", "firstName190", "firstName190", "dummyPasswordHash", "dummySalt", "TestStudent190" },
                    { new Guid("5553abad-f7aa-4637-9511-0d36f191e4df"), 732624581L, "dummyEmailHash", "firstName189", "firstName189", "dummyPasswordHash", "dummySalt", "TestStudent189" },
                    { new Guid("b096de2c-c80c-4f21-8221-7e9a55c9d585"), 732624581L, "dummyEmailHash", "firstName188", "firstName188", "dummyPasswordHash", "dummySalt", "TestStudent188" },
                    { new Guid("3527f188-5244-478d-99f3-3d5503678796"), 732624581L, "dummyEmailHash", "firstName187", "firstName187", "dummyPasswordHash", "dummySalt", "TestStudent187" },
                    { new Guid("8d5f5622-bab3-425a-bf90-d9af92c9310e"), 732624581L, "dummyEmailHash", "firstName186", "firstName186", "dummyPasswordHash", "dummySalt", "TestStudent186" },
                    { new Guid("a9e3f6f6-0150-4470-9ca9-92a95d4c8dd8"), 732624581L, "dummyEmailHash", "firstName185", "firstName185", "dummyPasswordHash", "dummySalt", "TestStudent185" },
                    { new Guid("db1851fa-28b4-4912-a35b-3610c0e774f6"), 732624581L, "dummyEmailHash", "firstName184", "firstName184", "dummyPasswordHash", "dummySalt", "TestStudent184" },
                    { new Guid("8816b4ed-b512-4ce6-8bee-540a69ed5763"), 732624581L, "dummyEmailHash", "firstName202", "firstName202", "dummyPasswordHash", "dummySalt", "TestStudent202" },
                    { new Guid("514b3aa0-f29c-434f-b70b-8d1bfab24d6e"), 732624581L, "dummyEmailHash", "firstName243", "firstName243", "dummyPasswordHash", "dummySalt", "TestStudent243" },
                    { new Guid("67d6e05a-4023-4715-9bc5-0f5fa18a8acc"), 732624581L, "dummyEmailHash", "firstName293", "firstName293", "dummyPasswordHash", "dummySalt", "TestStudent293" },
                    { new Guid("70c98e16-c838-4299-86fb-e3c3a804e650"), 732624581L, "dummyEmailHash", "firstName245", "firstName245", "dummyPasswordHash", "dummySalt", "TestStudent245" },
                    { new Guid("ef08e474-7578-419b-ac6b-83392842dd51"), 732624581L, "dummyEmailHash", "firstName302", "firstName302", "dummyPasswordHash", "dummySalt", "TestStudent302" },
                    { new Guid("b652343f-a958-450e-a265-25805b225b57"), 732624581L, "dummyEmailHash", "firstName301", "firstName301", "dummyPasswordHash", "dummySalt", "TestStudent301" },
                    { new Guid("d35c7242-f9b6-4bc9-9b0c-9b6fc3c75d92"), 732624581L, "dummyEmailHash", "firstName300", "firstName300", "dummyPasswordHash", "dummySalt", "TestStudent300" },
                    { new Guid("92d84e5e-87ed-4ea0-a828-fea94d00fa5a"), 732624581L, "dummyEmailHash", "firstName299", "firstName299", "dummyPasswordHash", "dummySalt", "TestStudent299" },
                    { new Guid("9ce042d1-daf4-4e30-a404-7ce187a25c7c"), 732624581L, "dummyEmailHash", "firstName298", "firstName298", "dummyPasswordHash", "dummySalt", "TestStudent298" },
                    { new Guid("5778d25a-58ba-4d52-bb81-443bf5197cf1"), 732624581L, "dummyEmailHash", "firstName297", "firstName297", "dummyPasswordHash", "dummySalt", "TestStudent297" },
                    { new Guid("a40bde53-1a7a-4e33-a73e-af65ee77bd76"), 732624581L, "dummyEmailHash", "firstName296", "firstName296", "dummyPasswordHash", "dummySalt", "TestStudent296" },
                    { new Guid("c8dd57b0-b5bb-4c7f-8f6a-0cffd5b88eab"), 732624581L, "dummyEmailHash", "firstName303", "firstName303", "dummyPasswordHash", "dummySalt", "TestStudent303" },
                    { new Guid("3ea12ca8-8743-45cd-9015-48fa186aca1a"), 732624581L, "dummyEmailHash", "firstName295", "firstName295", "dummyPasswordHash", "dummySalt", "TestStudent295" },
                    { new Guid("ee45c3f3-05b8-4f14-8c3b-d1bfcd715390"), 732624581L, "dummyEmailHash", "firstName163", "firstName163", "dummyPasswordHash", "dummySalt", "TestStudent163" },
                    { new Guid("59070f1c-d1e7-4023-a58d-18874734ab3a"), 732624581L, "dummyEmailHash", "firstName292", "firstName292", "dummyPasswordHash", "dummySalt", "TestStudent292" },
                    { new Guid("4998e75e-99ef-414b-b8aa-0d9851941e98"), 732624581L, "dummyEmailHash", "firstName291", "firstName291", "dummyPasswordHash", "dummySalt", "TestStudent291" },
                    { new Guid("a0365af9-d3d6-4528-9779-93017a645143"), 732624581L, "dummyEmailHash", "firstName290", "firstName290", "dummyPasswordHash", "dummySalt", "TestStudent290" },
                    { new Guid("27e719d4-cb33-49db-a096-3fcb00ab5638"), 732624581L, "dummyEmailHash", "firstName289", "firstName289", "dummyPasswordHash", "dummySalt", "TestStudent289" },
                    { new Guid("1d2c3013-a1eb-4185-8dd4-6aebe9516962"), 732624581L, "dummyEmailHash", "firstName288", "firstName288", "dummyPasswordHash", "dummySalt", "TestStudent288" },
                    { new Guid("b54c2649-b3e6-46f0-9695-a20ec1738fb1"), 732624581L, "dummyEmailHash", "firstName287", "firstName287", "dummyPasswordHash", "dummySalt", "TestStudent287" },
                    { new Guid("3a029cb5-7d86-443c-83a5-53ee63e13ae6"), 732624581L, "dummyEmailHash", "firstName294", "firstName294", "dummyPasswordHash", "dummySalt", "TestStudent294" },
                    { new Guid("ea45c5f5-58b3-4307-8ffb-40ff51923401"), 732624581L, "dummyEmailHash", "firstName304", "firstName304", "dummyPasswordHash", "dummySalt", "TestStudent304" },
                    { new Guid("da13e3ce-e667-4275-b1f8-f2dcd875fa80"), 732624581L, "dummyEmailHash", "firstName305", "firstName305", "dummyPasswordHash", "dummySalt", "TestStudent305" },
                    { new Guid("a64ea290-fc9c-43ab-8112-24e0fe230e45"), 732624581L, "dummyEmailHash", "firstName306", "firstName306", "dummyPasswordHash", "dummySalt", "TestStudent306" },
                    { new Guid("15990e24-7a24-4428-9daa-dc7e94cf8746"), 732624581L, "dummyEmailHash", "firstName323", "firstName323", "dummyPasswordHash", "dummySalt", "TestStudent323" },
                    { new Guid("d7eac763-0bd3-4811-a9f3-9111e8592eb3"), 732624581L, "dummyEmailHash", "firstName322", "firstName322", "dummyPasswordHash", "dummySalt", "TestStudent322" },
                    { new Guid("9811d264-e14b-45e1-85cc-6d600ed41192"), 732624581L, "dummyEmailHash", "firstName321", "firstName321", "dummyPasswordHash", "dummySalt", "TestStudent321" },
                    { new Guid("38282870-8e13-4d78-a50e-151e15d193e6"), 732624581L, "dummyEmailHash", "firstName320", "firstName320", "dummyPasswordHash", "dummySalt", "TestStudent320" },
                    { new Guid("432b123c-7650-4ad9-b4a9-4126b47b838a"), 732624581L, "dummyEmailHash", "firstName319", "firstName319", "dummyPasswordHash", "dummySalt", "TestStudent319" },
                    { new Guid("dc584618-166d-4f96-8ab1-4527abdc85ce"), 732624581L, "dummyEmailHash", "firstName318", "firstName318", "dummyPasswordHash", "dummySalt", "TestStudent318" },
                    { new Guid("c4ddbdf2-a7d9-40f7-9de8-33656c930bcb"), 732624581L, "dummyEmailHash", "firstName317", "firstName317", "dummyPasswordHash", "dummySalt", "TestStudent317" },
                    { new Guid("9ef5b13a-4ea0-48c9-9883-3c7bfd0bb6ae"), 732624581L, "dummyEmailHash", "firstName316", "firstName316", "dummyPasswordHash", "dummySalt", "TestStudent316" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "EmailHash", "FirstName", "LastName", "PasswordHash", "Salt", "Username" },
                values: new object[,]
                {
                    { new Guid("3abb006c-9e8a-4aa9-ad5a-04d7530b67d5"), 732624581L, "dummyEmailHash", "firstName315", "firstName315", "dummyPasswordHash", "dummySalt", "TestStudent315" },
                    { new Guid("0ad4bc5c-bfae-41aa-9f10-5549e3fc81bc"), 732624581L, "dummyEmailHash", "firstName314", "firstName314", "dummyPasswordHash", "dummySalt", "TestStudent314" },
                    { new Guid("5b8db878-675f-4854-ab23-e623ec26efc7"), 732624581L, "dummyEmailHash", "firstName313", "firstName313", "dummyPasswordHash", "dummySalt", "TestStudent313" },
                    { new Guid("092118b5-82c2-426f-ae63-f572f71f2d97"), 732624581L, "dummyEmailHash", "firstName312", "firstName312", "dummyPasswordHash", "dummySalt", "TestStudent312" },
                    { new Guid("e1e25103-0537-4986-99c1-876f28de6751"), 732624581L, "dummyEmailHash", "firstName311", "firstName311", "dummyPasswordHash", "dummySalt", "TestStudent311" },
                    { new Guid("06033bdc-8cc2-413b-9979-47b70caa4463"), 732624581L, "dummyEmailHash", "firstName310", "firstName310", "dummyPasswordHash", "dummySalt", "TestStudent310" },
                    { new Guid("d6d71a77-f07c-42ff-89a1-668acae606d2"), 732624581L, "dummyEmailHash", "firstName309", "firstName309", "dummyPasswordHash", "dummySalt", "TestStudent309" },
                    { new Guid("f3251bb7-b9cf-4911-95c2-2ee3d3ae0179"), 732624581L, "dummyEmailHash", "firstName308", "firstName308", "dummyPasswordHash", "dummySalt", "TestStudent308" },
                    { new Guid("2305358d-1f58-4179-a22f-5e467fc91058"), 732624581L, "dummyEmailHash", "firstName307", "firstName307", "dummyPasswordHash", "dummySalt", "TestStudent307" },
                    { new Guid("42bb4201-6c1d-4c88-b802-997973f3c978"), 732624581L, "dummyEmailHash", "firstName286", "firstName286", "dummyPasswordHash", "dummySalt", "TestStudent286" },
                    { new Guid("35e6a6d2-8f49-446b-aeaf-4e0258e15f82"), 732624581L, "dummyEmailHash", "firstName244", "firstName244", "dummyPasswordHash", "dummySalt", "TestStudent244" },
                    { new Guid("cc36c48c-7795-46ad-8d29-950da22bcd48"), 732624581L, "dummyEmailHash", "firstName285", "firstName285", "dummyPasswordHash", "dummySalt", "TestStudent285" },
                    { new Guid("3969aed8-c985-4dab-9fa6-8ba71ea85cfa"), 732624581L, "dummyEmailHash", "firstName283", "firstName283", "dummyPasswordHash", "dummySalt", "TestStudent283" },
                    { new Guid("fb2e4fdc-22b4-481c-b7e1-4ebf7b6fec94"), 732624581L, "dummyEmailHash", "firstName261", "firstName261", "dummyPasswordHash", "dummySalt", "TestStudent261" },
                    { new Guid("28028785-a9b3-46cf-b60d-fad21fc6cbc8"), 732624581L, "dummyEmailHash", "firstName260", "firstName260", "dummyPasswordHash", "dummySalt", "TestStudent260" },
                    { new Guid("cd239fb6-62a9-4a8f-8051-b3074bc1e3e7"), 732624581L, "dummyEmailHash", "firstName259", "firstName259", "dummyPasswordHash", "dummySalt", "TestStudent259" },
                    { new Guid("d80ac3cd-0cac-4312-a12f-01af46a6152a"), 732624581L, "dummyEmailHash", "firstName258", "firstName258", "dummyPasswordHash", "dummySalt", "TestStudent258" },
                    { new Guid("9dee2159-dc20-4746-a707-5cc08ad56f6c"), 732624581L, "dummyEmailHash", "firstName257", "firstName257", "dummyPasswordHash", "dummySalt", "TestStudent257" },
                    { new Guid("8b17d139-38ab-494b-8bf8-8a235fb019ce"), 732624581L, "dummyEmailHash", "firstName256", "firstName256", "dummyPasswordHash", "dummySalt", "TestStudent256" },
                    { new Guid("0c4522ba-625b-424c-aaa9-2cb0db789b0e"), 732624581L, "dummyEmailHash", "firstName255", "firstName255", "dummyPasswordHash", "dummySalt", "TestStudent255" },
                    { new Guid("e83709f8-62cd-4a9a-af06-8e4d847ebdf5"), 732624581L, "dummyEmailHash", "firstName262", "firstName262", "dummyPasswordHash", "dummySalt", "TestStudent262" },
                    { new Guid("e8311585-2529-44f5-ad94-03245d319ff8"), 732624581L, "dummyEmailHash", "firstName254", "firstName254", "dummyPasswordHash", "dummySalt", "TestStudent254" },
                    { new Guid("5e12cb7d-e2e7-4d52-b3e0-41c045b5ccd6"), 732624581L, "dummyEmailHash", "firstName252", "firstName252", "dummyPasswordHash", "dummySalt", "TestStudent252" },
                    { new Guid("c52d524f-dd0e-4e1c-9d18-e04e4841c8e3"), 732624581L, "dummyEmailHash", "firstName251", "firstName251", "dummyPasswordHash", "dummySalt", "TestStudent251" },
                    { new Guid("955fb4f9-f43f-4c90-884f-661e61ac2176"), 732624581L, "dummyEmailHash", "firstName250", "firstName250", "dummyPasswordHash", "dummySalt", "TestStudent250" },
                    { new Guid("db090111-fde3-4835-86a2-15394f2e21aa"), 732624581L, "dummyEmailHash", "firstName249", "firstName249", "dummyPasswordHash", "dummySalt", "TestStudent249" },
                    { new Guid("1ff6bb01-adf5-4687-8c7a-4f39cac64e51"), 732624581L, "dummyEmailHash", "firstName248", "firstName248", "dummyPasswordHash", "dummySalt", "TestStudent248" },
                    { new Guid("5027f098-c201-44d5-a86e-ba5b0fd5fe06"), 732624581L, "dummyEmailHash", "firstName247", "firstName247", "dummyPasswordHash", "dummySalt", "TestStudent247" },
                    { new Guid("1c2ac9c7-29c2-430f-8b20-49d4884e345a"), 732624581L, "dummyEmailHash", "firstName246", "firstName246", "dummyPasswordHash", "dummySalt", "TestStudent246" },
                    { new Guid("136d741a-295a-4a95-9d94-cf8515406e11"), 732624581L, "dummyEmailHash", "firstName253", "firstName253", "dummyPasswordHash", "dummySalt", "TestStudent253" },
                    { new Guid("30f79060-316f-407b-8d04-aff0d3aa7933"), 732624581L, "dummyEmailHash", "firstName263", "firstName263", "dummyPasswordHash", "dummySalt", "TestStudent263" },
                    { new Guid("3f6b1bf9-9275-4816-bcc7-416100ca32ce"), 732624581L, "dummyEmailHash", "firstName264", "firstName264", "dummyPasswordHash", "dummySalt", "TestStudent264" },
                    { new Guid("87b51cef-f381-4f81-be94-f26b10c5547a"), 732624581L, "dummyEmailHash", "firstName265", "firstName265", "dummyPasswordHash", "dummySalt", "TestStudent265" },
                    { new Guid("865a9719-9115-4af1-a32d-52f4b5c41aac"), 732624581L, "dummyEmailHash", "firstName282", "firstName282", "dummyPasswordHash", "dummySalt", "TestStudent282" },
                    { new Guid("463087fb-4b76-4cf7-b5e0-d4c5b470f82d"), 732624581L, "dummyEmailHash", "firstName281", "firstName281", "dummyPasswordHash", "dummySalt", "TestStudent281" },
                    { new Guid("097ce2db-8946-42b8-b991-765c9521f934"), 732624581L, "dummyEmailHash", "firstName280", "firstName280", "dummyPasswordHash", "dummySalt", "TestStudent280" },
                    { new Guid("69ad9026-f844-4512-952d-98703052c385"), 732624581L, "dummyEmailHash", "firstName279", "firstName279", "dummyPasswordHash", "dummySalt", "TestStudent279" },
                    { new Guid("2fee2389-4171-469b-ba54-6ff0c86f3081"), 732624581L, "dummyEmailHash", "firstName278", "firstName278", "dummyPasswordHash", "dummySalt", "TestStudent278" },
                    { new Guid("aeefe73b-d430-4c86-9446-5b40b07e9040"), 732624581L, "dummyEmailHash", "firstName277", "firstName277", "dummyPasswordHash", "dummySalt", "TestStudent277" },
                    { new Guid("0e1dac2a-3686-4a8a-add6-d62ee1282082"), 732624581L, "dummyEmailHash", "firstName276", "firstName276", "dummyPasswordHash", "dummySalt", "TestStudent276" },
                    { new Guid("5ac7564f-c06a-4f1a-acef-86f6ff9631ac"), 732624581L, "dummyEmailHash", "firstName275", "firstName275", "dummyPasswordHash", "dummySalt", "TestStudent275" },
                    { new Guid("0c221012-5710-4be9-a5f7-051b4059275c"), 732624581L, "dummyEmailHash", "firstName274", "firstName274", "dummyPasswordHash", "dummySalt", "TestStudent274" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "EmailHash", "FirstName", "LastName", "PasswordHash", "Salt", "Username" },
                values: new object[,]
                {
                    { new Guid("65412f63-e74f-48d3-ae3f-6ed20700b7cf"), 732624581L, "dummyEmailHash", "firstName273", "firstName273", "dummyPasswordHash", "dummySalt", "TestStudent273" },
                    { new Guid("777997a9-cea2-467e-8ddd-9e3ae5efcc12"), 732624581L, "dummyEmailHash", "firstName272", "firstName272", "dummyPasswordHash", "dummySalt", "TestStudent272" },
                    { new Guid("952441a7-cf1f-4a4a-988f-91388efc4aac"), 732624581L, "dummyEmailHash", "firstName271", "firstName271", "dummyPasswordHash", "dummySalt", "TestStudent271" },
                    { new Guid("1016fe8a-e137-4922-89d6-34d12f3483d6"), 732624581L, "dummyEmailHash", "firstName270", "firstName270", "dummyPasswordHash", "dummySalt", "TestStudent270" },
                    { new Guid("718b3471-a7c9-4ae5-b6a2-166c1b6f330f"), 732624581L, "dummyEmailHash", "firstName269", "firstName269", "dummyPasswordHash", "dummySalt", "TestStudent269" },
                    { new Guid("fb27ce38-3b9c-4dd6-abad-b62c7b45dc1f"), 732624581L, "dummyEmailHash", "firstName268", "firstName268", "dummyPasswordHash", "dummySalt", "TestStudent268" },
                    { new Guid("bfef2ba1-75ed-4f47-9ba5-f2c7b2712cac"), 732624581L, "dummyEmailHash", "firstName267", "firstName267", "dummyPasswordHash", "dummySalt", "TestStudent267" },
                    { new Guid("2b3e04f2-89e1-461a-aa13-fdc1e4924b35"), 732624581L, "dummyEmailHash", "firstName266", "firstName266", "dummyPasswordHash", "dummySalt", "TestStudent266" },
                    { new Guid("6a0d3f2a-744f-4937-98d8-856059e9b941"), 732624581L, "dummyEmailHash", "firstName284", "firstName284", "dummyPasswordHash", "dummySalt", "TestStudent284" },
                    { new Guid("537c0fe6-3df0-49a2-a6ad-12b44b8a25c0"), 732624581L, "dummyEmailHash", "firstName162", "firstName162", "dummyPasswordHash", "dummySalt", "TestStudent162" },
                    { new Guid("13077e2f-d755-4755-9f7f-2acf479f447f"), 732624581L, "dummyEmailHash", "firstName114", "firstName114", "dummyPasswordHash", "dummySalt", "TestStudent114" },
                    { new Guid("61b7b406-e691-461e-9388-630ea6c15249"), 732624581L, "dummyEmailHash", "firstName160", "firstName160", "dummyPasswordHash", "dummySalt", "TestStudent160" },
                    { new Guid("44268b05-2ef3-431c-84d1-1a19ba42b983"), 732624581L, "dummyEmailHash", "firstName56", "firstName56", "dummyPasswordHash", "dummySalt", "TestStudent56" },
                    { new Guid("0a048c60-3802-45b2-b31b-a3ad5366e0d3"), 732624581L, "dummyEmailHash", "firstName55", "firstName55", "dummyPasswordHash", "dummySalt", "TestStudent55" },
                    { new Guid("71ad4df6-ad99-45a5-9eee-147afda9ad20"), 732624581L, "dummyEmailHash", "firstName54", "firstName54", "dummyPasswordHash", "dummySalt", "TestStudent54" },
                    { new Guid("46b3b7cf-e3b0-470b-b93e-35719a67d3da"), 732624581L, "dummyEmailHash", "firstName53", "firstName53", "dummyPasswordHash", "dummySalt", "TestStudent53" },
                    { new Guid("c9c42e84-25a8-413a-bfd8-b0fc618e15d5"), 732624581L, "dummyEmailHash", "firstName52", "firstName52", "dummyPasswordHash", "dummySalt", "TestStudent52" },
                    { new Guid("7b2bed68-61b5-4257-a9bc-a224a85b0906"), 732624581L, "dummyEmailHash", "firstName51", "firstName51", "dummyPasswordHash", "dummySalt", "TestStudent51" },
                    { new Guid("4b5534b7-7816-4258-a054-ac2e4b14cd99"), 732624581L, "dummyEmailHash", "firstName50", "firstName50", "dummyPasswordHash", "dummySalt", "TestStudent50" },
                    { new Guid("edd6ca17-b15a-42dc-9d58-19b3f1f758fe"), 732624581L, "dummyEmailHash", "firstName57", "firstName57", "dummyPasswordHash", "dummySalt", "TestStudent57" },
                    { new Guid("2e5be4c6-013a-4d61-bb77-54bd64d52d59"), 732624581L, "dummyEmailHash", "firstName49", "firstName49", "dummyPasswordHash", "dummySalt", "TestStudent49" },
                    { new Guid("1f42d139-f2c7-4498-8f98-50ff212865b4"), 732624581L, "dummyEmailHash", "firstName47", "firstName47", "dummyPasswordHash", "dummySalt", "TestStudent47" },
                    { new Guid("16490c8e-804e-4bb7-b27b-9eacccb56751"), 732624581L, "dummyEmailHash", "firstName46", "firstName46", "dummyPasswordHash", "dummySalt", "TestStudent46" },
                    { new Guid("e6ab51f7-3efb-433f-94c4-686be78ec13c"), 732624581L, "dummyEmailHash", "firstName45", "firstName45", "dummyPasswordHash", "dummySalt", "TestStudent45" },
                    { new Guid("99958972-fb6c-41f1-bdcc-3d2239061506"), 732624581L, "dummyEmailHash", "firstName44", "firstName44", "dummyPasswordHash", "dummySalt", "TestStudent44" },
                    { new Guid("1c6e3c16-ca7f-4350-9a40-30483ad2378a"), 732624581L, "dummyEmailHash", "firstName43", "firstName43", "dummyPasswordHash", "dummySalt", "TestStudent43" },
                    { new Guid("7777f4f1-9471-4e7b-86a7-02793fdd5f12"), 732624581L, "dummyEmailHash", "firstName42", "firstName42", "dummyPasswordHash", "dummySalt", "TestStudent42" },
                    { new Guid("68501085-da2e-4cae-a58e-425c25f1ebc2"), 732624581L, "dummyEmailHash", "firstName41", "firstName41", "dummyPasswordHash", "dummySalt", "TestStudent41" },
                    { new Guid("069dbe85-ca34-4a06-8e55-3f7babeab277"), 732624581L, "dummyEmailHash", "firstName48", "firstName48", "dummyPasswordHash", "dummySalt", "TestStudent48" },
                    { new Guid("70c6f552-ad16-4f08-b6c4-6dc4e333ed88"), 732624581L, "dummyEmailHash", "firstName58", "firstName58", "dummyPasswordHash", "dummySalt", "TestStudent58" },
                    { new Guid("f39f58a5-66a3-48d5-a8c4-c759c9381daf"), 732624581L, "dummyEmailHash", "firstName59", "firstName59", "dummyPasswordHash", "dummySalt", "TestStudent59" },
                    { new Guid("a2c2a7ad-527d-4d3e-9f82-bad53d4a25c9"), 732624581L, "dummyEmailHash", "firstName60", "firstName60", "dummyPasswordHash", "dummySalt", "TestStudent60" },
                    { new Guid("f2e22ec6-9ed7-4589-9e91-1a533a0ea55e"), 732624581L, "dummyEmailHash", "firstName77", "firstName77", "dummyPasswordHash", "dummySalt", "TestStudent77" },
                    { new Guid("84e9b211-30f7-4da1-bd76-dda8b1ea93fa"), 732624581L, "dummyEmailHash", "firstName76", "firstName76", "dummyPasswordHash", "dummySalt", "TestStudent76" },
                    { new Guid("dabab4a3-4996-48ae-8f84-158d11dddad1"), 732624581L, "dummyEmailHash", "firstName75", "firstName75", "dummyPasswordHash", "dummySalt", "TestStudent75" },
                    { new Guid("f670ee20-cfec-489f-b6ba-2e43907d9bc1"), 732624581L, "dummyEmailHash", "firstName74", "firstName74", "dummyPasswordHash", "dummySalt", "TestStudent74" },
                    { new Guid("b649f119-26be-4457-a1c5-f371f099324a"), 732624581L, "dummyEmailHash", "firstName73", "firstName73", "dummyPasswordHash", "dummySalt", "TestStudent73" },
                    { new Guid("7760094a-f97f-4d90-964e-4bead3c6548a"), 732624581L, "dummyEmailHash", "firstName72", "firstName72", "dummyPasswordHash", "dummySalt", "TestStudent72" },
                    { new Guid("fa0f5fea-3047-4228-aaf3-78fb56f629d9"), 732624581L, "dummyEmailHash", "firstName71", "firstName71", "dummyPasswordHash", "dummySalt", "TestStudent71" },
                    { new Guid("99ddf014-1e00-44cf-b50c-f310e9c7a578"), 732624581L, "dummyEmailHash", "firstName70", "firstName70", "dummyPasswordHash", "dummySalt", "TestStudent70" },
                    { new Guid("ec9022c9-d5d9-4fe8-b6e9-0bb8b761a2c7"), 732624581L, "dummyEmailHash", "firstName69", "firstName69", "dummyPasswordHash", "dummySalt", "TestStudent69" },
                    { new Guid("9ddc7694-8886-4342-9e35-e30f49b914a6"), 732624581L, "dummyEmailHash", "firstName68", "firstName68", "dummyPasswordHash", "dummySalt", "TestStudent68" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "EmailHash", "FirstName", "LastName", "PasswordHash", "Salt", "Username" },
                values: new object[,]
                {
                    { new Guid("e6fdc458-a365-4d6b-9302-1dcd1ff0b3bb"), 732624581L, "dummyEmailHash", "firstName67", "firstName67", "dummyPasswordHash", "dummySalt", "TestStudent67" },
                    { new Guid("d44bdecf-2774-4ba7-82fb-dc73ef88301e"), 732624581L, "dummyEmailHash", "firstName66", "firstName66", "dummyPasswordHash", "dummySalt", "TestStudent66" },
                    { new Guid("1b3b9a22-c256-4471-8356-fa51c2330f45"), 732624581L, "dummyEmailHash", "firstName65", "firstName65", "dummyPasswordHash", "dummySalt", "TestStudent65" },
                    { new Guid("c068f017-9340-4626-9e26-38a2afac6cc4"), 732624581L, "dummyEmailHash", "firstName64", "firstName64", "dummyPasswordHash", "dummySalt", "TestStudent64" },
                    { new Guid("1c937154-b733-436c-a8f6-894e21eb44c7"), 732624581L, "dummyEmailHash", "firstName63", "firstName63", "dummyPasswordHash", "dummySalt", "TestStudent63" },
                    { new Guid("1782d872-4343-4121-a74a-b8d9f4de521a"), 732624581L, "dummyEmailHash", "firstName62", "firstName62", "dummyPasswordHash", "dummySalt", "TestStudent62" },
                    { new Guid("5dbcd666-8455-4b6d-b151-f7b63f5b9a41"), 732624581L, "dummyEmailHash", "firstName61", "firstName61", "dummyPasswordHash", "dummySalt", "TestStudent61" },
                    { new Guid("73daa1b1-1887-4bd9-a347-0933e0acc910"), 732624581L, "dummyEmailHash", "firstName40", "firstName40", "dummyPasswordHash", "dummySalt", "TestStudent40" },
                    { new Guid("e1c1167c-2743-4960-bac2-ffe944a0ba1b"), 732624581L, "dummyEmailHash", "firstName161", "firstName161", "dummyPasswordHash", "dummySalt", "TestStudent161" },
                    { new Guid("72343ca2-81ec-4197-845d-9eb2abec963a"), 732624581L, "dummyEmailHash", "firstName39", "firstName39", "dummyPasswordHash", "dummySalt", "TestStudent39" },
                    { new Guid("45502922-a8d2-4ed0-acd3-e91c795cd85a"), 732624581L, "dummyEmailHash", "firstName37", "firstName37", "dummyPasswordHash", "dummySalt", "TestStudent37" },
                    { new Guid("58501e6f-7c91-4691-a51a-0949d17b75fd"), 732624581L, "dummyEmailHash", "firstName15", "firstName15", "dummyPasswordHash", "dummySalt", "TestStudent15" },
                    { new Guid("df3878bb-d580-4e33-bfd4-d031c9e8f752"), 732624581L, "dummyEmailHash", "firstName14", "firstName14", "dummyPasswordHash", "dummySalt", "TestStudent14" },
                    { new Guid("7b10af2a-5c2f-4cce-a94c-f70bdef294d9"), 732624581L, "dummyEmailHash", "firstName13", "firstName13", "dummyPasswordHash", "dummySalt", "TestStudent13" },
                    { new Guid("7ce79836-fb94-479a-926b-8435573f2418"), 732624581L, "dummyEmailHash", "firstName12", "firstName12", "dummyPasswordHash", "dummySalt", "TestStudent12" },
                    { new Guid("416ec3a4-399a-47ca-b4b4-d91f2cb91d2b"), 732624581L, "dummyEmailHash", "firstName11", "firstName11", "dummyPasswordHash", "dummySalt", "TestStudent11" },
                    { new Guid("7b6b190b-375a-42d0-b035-9ae590e89083"), 732624581L, "dummyEmailHash", "firstName10", "firstName10", "dummyPasswordHash", "dummySalt", "TestStudent10" },
                    { new Guid("9c540e22-43ad-4ce9-9ecb-b2dbc96dd528"), 732624581L, "dummyEmailHash", "firstName9", "firstName9", "dummyPasswordHash", "dummySalt", "TestStudent9" },
                    { new Guid("299d52f7-3535-4cef-b79c-13424f94beba"), 732624581L, "dummyEmailHash", "firstName16", "firstName16", "dummyPasswordHash", "dummySalt", "TestStudent16" },
                    { new Guid("0979c688-52ae-4b59-9d3e-e9bde3e9b348"), 732624581L, "dummyEmailHash", "firstName8", "firstName8", "dummyPasswordHash", "dummySalt", "TestStudent8" },
                    { new Guid("330b8fd4-506d-4eb5-b9b4-9f8abde2f0bf"), 732624581L, "dummyEmailHash", "firstName6", "firstName6", "dummyPasswordHash", "dummySalt", "TestStudent6" },
                    { new Guid("412348ff-091f-4345-971b-b4b83f86b151"), 732624581L, "dummyEmailHash", "firstName5", "firstName5", "dummyPasswordHash", "dummySalt", "TestStudent5" },
                    { new Guid("13087178-68d4-40a7-b444-83a46657a477"), 732624581L, "dummyEmailHash", "firstName4", "firstName4", "dummyPasswordHash", "dummySalt", "TestStudent4" },
                    { new Guid("cb885879-5935-4d4a-b938-13a5b6fc15ab"), 732624581L, "dummyEmailHash", "firstName3", "firstName3", "dummyPasswordHash", "dummySalt", "TestStudent3" },
                    { new Guid("f4e54ad5-484d-4ce5-8a18-b26b4d0113c4"), 732624581L, "dummyEmailHash", "firstName2", "firstName2", "dummyPasswordHash", "dummySalt", "TestStudent2" },
                    { new Guid("9cc8c670-bb4d-4fdd-9f81-8cee91a8cb9f"), 732624581L, "dummyEmailHash", "firstName1", "firstName1", "dummyPasswordHash", "dummySalt", "TestStudent1" },
                    { new Guid("864835ed-983c-47ab-9fa4-74182f9a7efd"), 732624581L, "dummyEmailHash", "firstName0", "firstName0", "dummyPasswordHash", "dummySalt", "TestStudent0" },
                    { new Guid("ffb1dd7b-95c3-434d-b85a-1a3ea6abe788"), 732624581L, "dummyEmailHash", "firstName7", "firstName7", "dummyPasswordHash", "dummySalt", "TestStudent7" },
                    { new Guid("0896c167-f916-4364-9665-5a96c4ecbc35"), 732624581L, "dummyEmailHash", "firstName17", "firstName17", "dummyPasswordHash", "dummySalt", "TestStudent17" },
                    { new Guid("6eb6a595-aa87-42ba-81b4-30ad94f1eb9a"), 732624581L, "dummyEmailHash", "firstName18", "firstName18", "dummyPasswordHash", "dummySalt", "TestStudent18" },
                    { new Guid("196422ec-3dfa-409d-902a-172d2384d9e1"), 732624581L, "dummyEmailHash", "firstName19", "firstName19", "dummyPasswordHash", "dummySalt", "TestStudent19" },
                    { new Guid("05ee30ee-8b11-4d3e-af76-a485857c3b9a"), 732624581L, "dummyEmailHash", "firstName36", "firstName36", "dummyPasswordHash", "dummySalt", "TestStudent36" },
                    { new Guid("4de0f0f5-0763-4385-9c12-f6a190d13554"), 732624581L, "dummyEmailHash", "firstName35", "firstName35", "dummyPasswordHash", "dummySalt", "TestStudent35" },
                    { new Guid("5a2c668f-251c-46e6-8d42-be806abfb858"), 732624581L, "dummyEmailHash", "firstName34", "firstName34", "dummyPasswordHash", "dummySalt", "TestStudent34" },
                    { new Guid("739cfc78-e082-4f19-9777-5cf8bded81a8"), 732624581L, "dummyEmailHash", "firstName33", "firstName33", "dummyPasswordHash", "dummySalt", "TestStudent33" },
                    { new Guid("073f6e0c-eb54-42f3-bb6f-008afd69404c"), 732624581L, "dummyEmailHash", "firstName32", "firstName32", "dummyPasswordHash", "dummySalt", "TestStudent32" },
                    { new Guid("8cd82215-d2fa-4bf4-85ec-f9f515f5d2c1"), 732624581L, "dummyEmailHash", "firstName31", "firstName31", "dummyPasswordHash", "dummySalt", "TestStudent31" },
                    { new Guid("93d1065f-7022-4671-b78a-13752eba08cd"), 732624581L, "dummyEmailHash", "firstName30", "firstName30", "dummyPasswordHash", "dummySalt", "TestStudent30" },
                    { new Guid("bf68980c-e4cd-44a6-a5d2-474793c2c1d2"), 732624581L, "dummyEmailHash", "firstName29", "firstName29", "dummyPasswordHash", "dummySalt", "TestStudent29" },
                    { new Guid("a843baa3-ada5-4cdb-b8bf-c60200748133"), 732624581L, "dummyEmailHash", "firstName28", "firstName28", "dummyPasswordHash", "dummySalt", "TestStudent28" },
                    { new Guid("d1642386-4878-4964-87d5-0f5fa4d0c98e"), 732624581L, "dummyEmailHash", "firstName27", "firstName27", "dummyPasswordHash", "dummySalt", "TestStudent27" },
                    { new Guid("99b21604-e6db-45a3-8902-1dbd9bea7400"), 732624581L, "dummyEmailHash", "firstName26", "firstName26", "dummyPasswordHash", "dummySalt", "TestStudent26" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "EmailHash", "FirstName", "LastName", "PasswordHash", "Salt", "Username" },
                values: new object[,]
                {
                    { new Guid("7a142833-c5de-45ff-ae44-fdf6da5c681b"), 732624581L, "dummyEmailHash", "firstName25", "firstName25", "dummyPasswordHash", "dummySalt", "TestStudent25" },
                    { new Guid("953ecf4a-f36f-4b05-9723-5129140836de"), 732624581L, "dummyEmailHash", "firstName24", "firstName24", "dummyPasswordHash", "dummySalt", "TestStudent24" },
                    { new Guid("8e565ee7-d587-4aa5-b01f-989367e86395"), 732624581L, "dummyEmailHash", "firstName23", "firstName23", "dummyPasswordHash", "dummySalt", "TestStudent23" },
                    { new Guid("68f5d54b-8f01-4734-a280-7bc37d59d478"), 732624581L, "dummyEmailHash", "firstName22", "firstName22", "dummyPasswordHash", "dummySalt", "TestStudent22" },
                    { new Guid("7d948772-69b8-41f8-85e0-adf5532b5ea9"), 732624581L, "dummyEmailHash", "firstName21", "firstName21", "dummyPasswordHash", "dummySalt", "TestStudent21" },
                    { new Guid("671ecf27-fde4-4e5f-97d2-77b23cc5f9ea"), 732624581L, "dummyEmailHash", "firstName20", "firstName20", "dummyPasswordHash", "dummySalt", "TestStudent20" },
                    { new Guid("f1eca1a9-96f4-42bc-b47c-daead5a449fd"), 732624581L, "dummyEmailHash", "firstName38", "firstName38", "dummyPasswordHash", "dummySalt", "TestStudent38" },
                    { new Guid("d649f312-18aa-4508-b497-6da80a0aa84b"), 732624581L, "dummyEmailHash", "firstName79", "firstName79", "dummyPasswordHash", "dummySalt", "TestStudent79" },
                    { new Guid("614a8376-606e-40a3-9b5e-756a635cc0b9"), 732624581L, "dummyEmailHash", "firstName78", "firstName78", "dummyPasswordHash", "dummySalt", "TestStudent78" },
                    { new Guid("26890b54-e6eb-49b3-82cf-3cf959ab419a"), 732624581L, "dummyEmailHash", "firstName81", "firstName81", "dummyPasswordHash", "dummySalt", "TestStudent81" },
                    { new Guid("863ed0d2-93ec-4c81-b767-bfd4628afebd"), 732624581L, "dummyEmailHash", "firstName138", "firstName138", "dummyPasswordHash", "dummySalt", "TestStudent138" },
                    { new Guid("84aa42e6-6afe-41c9-b59c-def2a9e99ab6"), 732624581L, "dummyEmailHash", "firstName137", "firstName137", "dummyPasswordHash", "dummySalt", "TestStudent137" },
                    { new Guid("226a90ab-88ca-4c07-8821-c57d057e188e"), 732624581L, "dummyEmailHash", "firstName136", "firstName136", "dummyPasswordHash", "dummySalt", "TestStudent136" },
                    { new Guid("8d50fa94-dd14-4f89-ade5-77de4e179397"), 732624581L, "dummyEmailHash", "firstName135", "firstName135", "dummyPasswordHash", "dummySalt", "TestStudent135" },
                    { new Guid("f4e0b2d0-bdac-4053-a2c9-e5a175d2146e"), 732624581L, "dummyEmailHash", "firstName134", "firstName134", "dummyPasswordHash", "dummySalt", "TestStudent134" },
                    { new Guid("7f47cfd9-dc83-4cc3-a421-b2774d0e2ae1"), 732624581L, "dummyEmailHash", "firstName133", "firstName133", "dummyPasswordHash", "dummySalt", "TestStudent133" },
                    { new Guid("18c3c341-23fd-4e47-9381-eaf90370bb99"), 732624581L, "dummyEmailHash", "firstName132", "firstName132", "dummyPasswordHash", "dummySalt", "TestStudent132" },
                    { new Guid("a9aa0b7e-f85f-406b-b6e0-688b0a2c756f"), 732624581L, "dummyEmailHash", "firstName139", "firstName139", "dummyPasswordHash", "dummySalt", "TestStudent139" },
                    { new Guid("83c8473f-2064-468d-8de3-30d552fce6fe"), 732624581L, "dummyEmailHash", "firstName131", "firstName131", "dummyPasswordHash", "dummySalt", "TestStudent131" },
                    { new Guid("ab6434e1-e0f0-4fe8-bce0-04899751ff73"), 732624581L, "dummyEmailHash", "firstName129", "firstName129", "dummyPasswordHash", "dummySalt", "TestStudent129" },
                    { new Guid("38685ac5-15b1-4f8b-9c1a-061d09450c67"), 732624581L, "dummyEmailHash", "firstName128", "firstName128", "dummyPasswordHash", "dummySalt", "TestStudent128" },
                    { new Guid("3df895dc-321d-4fae-897d-6b0ff9fd4db4"), 732624581L, "dummyEmailHash", "firstName127", "firstName127", "dummyPasswordHash", "dummySalt", "TestStudent127" },
                    { new Guid("be2d873b-0c79-4bde-b1f4-d35143b07d6a"), 732624581L, "dummyEmailHash", "firstName126", "firstName126", "dummyPasswordHash", "dummySalt", "TestStudent126" },
                    { new Guid("727b8bd1-c77a-4540-96d5-713dfdcb4398"), 732624581L, "dummyEmailHash", "firstName125", "firstName125", "dummyPasswordHash", "dummySalt", "TestStudent125" },
                    { new Guid("fb8aaa98-d82f-400f-bf8c-0af6af0fea5c"), 732624581L, "dummyEmailHash", "firstName124", "firstName124", "dummyPasswordHash", "dummySalt", "TestStudent124" },
                    { new Guid("987966cd-caf4-4960-b37b-3c6bf1b89888"), 732624581L, "dummyEmailHash", "firstName123", "firstName123", "dummyPasswordHash", "dummySalt", "TestStudent123" },
                    { new Guid("8c08748d-5061-481b-ba1f-9c1f74b21a73"), 732624581L, "dummyEmailHash", "firstName130", "firstName130", "dummyPasswordHash", "dummySalt", "TestStudent130" },
                    { new Guid("01c22997-99b4-43bd-9330-76f98d09a137"), 732624581L, "dummyEmailHash", "firstName140", "firstName140", "dummyPasswordHash", "dummySalt", "TestStudent140" },
                    { new Guid("ffce7b9f-a013-4c2d-8e41-395c4c5845f6"), 732624581L, "dummyEmailHash", "firstName141", "firstName141", "dummyPasswordHash", "dummySalt", "TestStudent141" },
                    { new Guid("3cb8198f-c176-4315-a194-63c46aec4833"), 732624581L, "dummyEmailHash", "firstName142", "firstName142", "dummyPasswordHash", "dummySalt", "TestStudent142" },
                    { new Guid("a5b17a71-d528-468f-9874-36e2d816f8d6"), 732624581L, "dummyEmailHash", "firstName159", "firstName159", "dummyPasswordHash", "dummySalt", "TestStudent159" },
                    { new Guid("dbf91b18-0a45-4e59-a116-93a6792cd012"), 732624581L, "dummyEmailHash", "firstName158", "firstName158", "dummyPasswordHash", "dummySalt", "TestStudent158" },
                    { new Guid("342aebf0-6d60-42e8-8c35-1f241c86ff5a"), 732624581L, "dummyEmailHash", "firstName157", "firstName157", "dummyPasswordHash", "dummySalt", "TestStudent157" },
                    { new Guid("5f7f1bc6-bbfd-4a14-8ac2-8ae7d3757a3b"), 732624581L, "dummyEmailHash", "firstName156", "firstName156", "dummyPasswordHash", "dummySalt", "TestStudent156" },
                    { new Guid("3db660ce-c4f8-4fda-8c70-9d105fd3fcee"), 732624581L, "dummyEmailHash", "firstName155", "firstName155", "dummyPasswordHash", "dummySalt", "TestStudent155" },
                    { new Guid("4dde0d15-b580-4c9e-8487-cc25b592b9b4"), 732624581L, "dummyEmailHash", "firstName154", "firstName154", "dummyPasswordHash", "dummySalt", "TestStudent154" },
                    { new Guid("13ed3d8c-73cc-491f-9929-93fb87dc8f54"), 732624581L, "dummyEmailHash", "firstName153", "firstName153", "dummyPasswordHash", "dummySalt", "TestStudent153" },
                    { new Guid("4f625f37-6d29-4969-9796-05f3d93733db"), 732624581L, "dummyEmailHash", "firstName152", "firstName152", "dummyPasswordHash", "dummySalt", "TestStudent152" },
                    { new Guid("2d0f8025-5996-4660-b7eb-20e59b755322"), 732624581L, "dummyEmailHash", "firstName151", "firstName151", "dummyPasswordHash", "dummySalt", "TestStudent151" },
                    { new Guid("7f939a55-7ec9-454a-838e-947c141f3f0b"), 732624581L, "dummyEmailHash", "firstName150", "firstName150", "dummyPasswordHash", "dummySalt", "TestStudent150" },
                    { new Guid("b999311e-2b35-4b8c-8fae-2398c06f7dd3"), 732624581L, "dummyEmailHash", "firstName149", "firstName149", "dummyPasswordHash", "dummySalt", "TestStudent149" },
                    { new Guid("594bf687-59fe-4832-b96b-01a6372eaa97"), 732624581L, "dummyEmailHash", "firstName148", "firstName148", "dummyPasswordHash", "dummySalt", "TestStudent148" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "EmailHash", "FirstName", "LastName", "PasswordHash", "Salt", "Username" },
                values: new object[,]
                {
                    { new Guid("2667a758-41a7-4f2f-bd61-6b2121f9fd4f"), 732624581L, "dummyEmailHash", "firstName147", "firstName147", "dummyPasswordHash", "dummySalt", "TestStudent147" },
                    { new Guid("29772d53-f49f-4a11-b808-d51237e1e700"), 732624581L, "dummyEmailHash", "firstName146", "firstName146", "dummyPasswordHash", "dummySalt", "TestStudent146" },
                    { new Guid("970239f2-226b-43fa-8628-cabdf415b58a"), 732624581L, "dummyEmailHash", "firstName145", "firstName145", "dummyPasswordHash", "dummySalt", "TestStudent145" },
                    { new Guid("5f802300-59fe-4265-9e8e-97aa329de809"), 732624581L, "dummyEmailHash", "firstName144", "firstName144", "dummyPasswordHash", "dummySalt", "TestStudent144" },
                    { new Guid("87c7ee17-2764-4dc8-86dc-bc5d459dcff8"), 732624581L, "dummyEmailHash", "firstName143", "firstName143", "dummyPasswordHash", "dummySalt", "TestStudent143" },
                    { new Guid("941284c7-92a1-4031-adac-632f2740aa19"), 732624581L, "dummyEmailHash", "firstName80", "firstName80", "dummyPasswordHash", "dummySalt", "TestStudent80" },
                    { new Guid("013f8663-4b57-46a0-af8a-c8fb6c25b58c"), 732624581L, "dummyEmailHash", "firstName121", "firstName121", "dummyPasswordHash", "dummySalt", "TestStudent121" },
                    { new Guid("46b22d75-cb5d-48c6-b394-378bde695691"), 732624581L, "dummyEmailHash", "firstName122", "firstName122", "dummyPasswordHash", "dummySalt", "TestStudent122" },
                    { new Guid("d86f7859-ac80-4845-917e-1cdb92bc8647"), 732624581L, "dummyEmailHash", "firstName119", "firstName119", "dummyPasswordHash", "dummySalt", "TestStudent119" },
                    { new Guid("6ab839d1-a272-489c-9f2c-38da55d9a097"), 732624581L, "dummyEmailHash", "firstName97", "firstName97", "dummyPasswordHash", "dummySalt", "TestStudent97" },
                    { new Guid("51fdf115-e2e1-4598-bf8d-7e9ffb23307a"), 732624581L, "dummyEmailHash", "firstName96", "firstName96", "dummyPasswordHash", "dummySalt", "TestStudent96" },
                    { new Guid("7f518d29-60ad-4aa9-be1c-3dc5676b38f7"), 732624581L, "dummyEmailHash", "firstName95", "firstName95", "dummyPasswordHash", "dummySalt", "TestStudent95" },
                    { new Guid("3925e9f5-cc86-4bba-aa83-ebe94ddce1f7"), 732624581L, "dummyEmailHash", "firstName94", "firstName94", "dummyPasswordHash", "dummySalt", "TestStudent94" },
                    { new Guid("0130e8bf-7265-4191-824b-02f042815014"), 732624581L, "dummyEmailHash", "firstName93", "firstName93", "dummyPasswordHash", "dummySalt", "TestStudent93" },
                    { new Guid("23f78dad-ca3d-4aff-a610-7764a650205c"), 732624581L, "dummyEmailHash", "firstName92", "firstName92", "dummyPasswordHash", "dummySalt", "TestStudent92" },
                    { new Guid("abe7cc15-e681-48e4-8033-18a482ed1910"), 732624581L, "dummyEmailHash", "firstName91", "firstName91", "dummyPasswordHash", "dummySalt", "TestStudent91" },
                    { new Guid("341f6fb4-9b6c-4fc1-a184-fdf0cc488288"), 732624581L, "dummyEmailHash", "firstName120", "firstName120", "dummyPasswordHash", "dummySalt", "TestStudent120" },
                    { new Guid("37566277-11bd-45c6-95ef-b8c207ef98dd"), 732624581L, "dummyEmailHash", "firstName90", "firstName90", "dummyPasswordHash", "dummySalt", "TestStudent90" },
                    { new Guid("1be7ad0c-995e-4ced-8bd8-7a21fb31efcf"), 732624581L, "dummyEmailHash", "firstName88", "firstName88", "dummyPasswordHash", "dummySalt", "TestStudent88" },
                    { new Guid("76770a32-b4e0-4299-8fe6-142312594dec"), 732624581L, "dummyEmailHash", "firstName87", "firstName87", "dummyPasswordHash", "dummySalt", "TestStudent87" },
                    { new Guid("a4f9dcdd-70c1-47b4-aac0-7d5c3e211977"), 732624581L, "dummyEmailHash", "firstName86", "firstName86", "dummyPasswordHash", "dummySalt", "TestStudent86" },
                    { new Guid("dec162df-07e1-4a73-9469-c7339c202f6c"), 732624581L, "dummyEmailHash", "firstName85", "firstName85", "dummyPasswordHash", "dummySalt", "TestStudent85" },
                    { new Guid("ee3ee571-892c-4fc2-aca1-823e1fcd1b23"), 732624581L, "dummyEmailHash", "firstName84", "firstName84", "dummyPasswordHash", "dummySalt", "TestStudent84" },
                    { new Guid("503cdcf5-b606-49fa-a8db-042c6b3fa9b0"), 732624581L, "dummyEmailHash", "firstName83", "firstName83", "dummyPasswordHash", "dummySalt", "TestStudent83" },
                    { new Guid("847fdbea-4a6c-42bf-b267-2a5e6aded89e"), 732624581L, "dummyEmailHash", "firstName82", "firstName82", "dummyPasswordHash", "dummySalt", "TestStudent82" },
                    { new Guid("0b0b66b9-5365-490d-980b-e77543d0e7f8"), 732624581L, "dummyEmailHash", "firstName89", "firstName89", "dummyPasswordHash", "dummySalt", "TestStudent89" },
                    { new Guid("e570d899-3729-4c6e-a91b-ebcbf1a65655"), 732624581L, "dummyEmailHash", "firstName99", "firstName99", "dummyPasswordHash", "dummySalt", "TestStudent99" },
                    { new Guid("9bb96f6a-452d-4af4-b820-4c4d53089018"), 732624581L, "dummyEmailHash", "firstName98", "firstName98", "dummyPasswordHash", "dummySalt", "TestStudent98" },
                    { new Guid("39b97487-2694-4ffd-a0b5-07aa0798be6c"), 732624581L, "dummyEmailHash", "firstName101", "firstName101", "dummyPasswordHash", "dummySalt", "TestStudent101" },
                    { new Guid("4d8e230c-a9db-4671-8879-64740666635e"), 732624581L, "dummyEmailHash", "firstName118", "firstName118", "dummyPasswordHash", "dummySalt", "TestStudent118" },
                    { new Guid("ec8355e1-51fb-45c1-a4ef-b2abcaab690e"), 732624581L, "dummyEmailHash", "firstName117", "firstName117", "dummyPasswordHash", "dummySalt", "TestStudent117" },
                    { new Guid("88f1f6ee-3ae1-41e3-a71b-f7d3353eb0ea"), 732624581L, "dummyEmailHash", "firstName116", "firstName116", "dummyPasswordHash", "dummySalt", "TestStudent116" },
                    { new Guid("fdf7cc8f-841d-43d9-be0d-002200118890"), 732624581L, "dummyEmailHash", "firstName115", "firstName115", "dummyPasswordHash", "dummySalt", "TestStudent115" },
                    { new Guid("9d5d424c-c240-44e5-babd-d2f251db44bd"), 732624581L, "dummyEmailHash", "firstName113", "firstName113", "dummyPasswordHash", "dummySalt", "TestStudent113" },
                    { new Guid("b392d44a-8521-4389-a1cb-8d8161e5485e"), 732624581L, "dummyEmailHash", "firstName100", "firstName100", "dummyPasswordHash", "dummySalt", "TestStudent100" },
                    { new Guid("5653e140-a7c1-4f81-bb3d-d1106305200a"), 732624581L, "dummyEmailHash", "firstName111", "firstName111", "dummyPasswordHash", "dummySalt", "TestStudent111" },
                    { new Guid("8354d94a-b9bf-44f3-8bbd-34577523110c"), 732624581L, "dummyEmailHash", "firstName110", "firstName110", "dummyPasswordHash", "dummySalt", "TestStudent110" },
                    { new Guid("8a4c5196-13ba-465f-a83f-418ad25fd9c6"), 732624581L, "dummyEmailHash", "firstName112", "firstName112", "dummyPasswordHash", "dummySalt", "TestStudent112" },
                    { new Guid("f33f4675-e4f2-413e-ad20-ed7e12d356d4"), 732624581L, "dummyEmailHash", "firstName108", "firstName108", "dummyPasswordHash", "dummySalt", "TestStudent108" },
                    { new Guid("9f635dbe-b5e1-4930-9d12-671306eb2b52"), 732624581L, "dummyEmailHash", "firstName107", "firstName107", "dummyPasswordHash", "dummySalt", "TestStudent107" },
                    { new Guid("fca9dbb9-c681-43c4-8d37-c0d97fb00ea4"), 732624581L, "dummyEmailHash", "firstName106", "firstName106", "dummyPasswordHash", "dummySalt", "TestStudent106" },
                    { new Guid("ea9b6355-8e01-4f09-9191-a0f8ca9c651c"), 732624581L, "dummyEmailHash", "firstName105", "firstName105", "dummyPasswordHash", "dummySalt", "TestStudent105" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "EmailHash", "FirstName", "LastName", "PasswordHash", "Salt", "Username" },
                values: new object[,]
                {
                    { new Guid("7a67f2b0-2b07-4922-af6d-b561ce84017f"), 732624581L, "dummyEmailHash", "firstName104", "firstName104", "dummyPasswordHash", "dummySalt", "TestStudent104" },
                    { new Guid("b8030296-ce82-429e-808a-79366f01888b"), 732624581L, "dummyEmailHash", "firstName103", "firstName103", "dummyPasswordHash", "dummySalt", "TestStudent103" },
                    { new Guid("14890cdf-16be-4c9b-a898-10a6e7e5d16e"), 732624581L, "dummyEmailHash", "firstName102", "firstName102", "dummyPasswordHash", "dummySalt", "TestStudent102" },
                    { new Guid("bb062a85-d596-4716-9036-8ec40fadd48b"), 732624581L, "dummyEmailHash", "firstName109", "firstName109", "dummyPasswordHash", "dummySalt", "TestStudent109" }
                });

            migrationBuilder.InsertData(
                table: "TeacherDegrees",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("ccb8a353-17bc-4e58-b4f9-274e96bcf5e8"), "TeacherDegree3" },
                    { new Guid("dba7f37d-5603-4523-ae4c-4a697a3b4efc"), "TeacherDegree0" },
                    { new Guid("ad7bfb67-c85a-4fe5-9e29-f076d4abe93d"), "TeacherDegree1" },
                    { new Guid("b77eb52b-a2cc-422a-a182-0ec7f2415033"), "TeacherDegree2" },
                    { new Guid("7bdfa859-a50a-407b-a971-7234f1b0e08d"), "TeacherDegree4" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "DateOfBirth", "EmailHash", "FirstName", "LastName", "PasswordHash", "Salt", "TeacherDegreeId", "Username" },
                values: new object[,]
                {
                    { new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3"), 732624581L, "dummyEmailHash", "firstName0", "firstName0", "dummyPasswordHash", "dummySalt", new Guid("dba7f37d-5603-4523-ae4c-4a697a3b4efc"), "TestTeacher0" },
                    { new Guid("105a879d-9688-41fc-85f0-a8743376ac65"), 732624581L, "dummyEmailHash", "firstName63", "firstName63", "dummyPasswordHash", "dummySalt", new Guid("ccb8a353-17bc-4e58-b4f9-274e96bcf5e8"), "TestTeacher63" },
                    { new Guid("c02be181-5f7c-4685-89ee-d0b4b1c3dea0"), 732624581L, "dummyEmailHash", "firstName58", "firstName58", "dummyPasswordHash", "dummySalt", new Guid("ccb8a353-17bc-4e58-b4f9-274e96bcf5e8"), "TestTeacher58" },
                    { new Guid("f24549c9-0ce2-4f17-b827-6994bf335d46"), 732624581L, "dummyEmailHash", "firstName53", "firstName53", "dummyPasswordHash", "dummySalt", new Guid("ccb8a353-17bc-4e58-b4f9-274e96bcf5e8"), "TestTeacher53" },
                    { new Guid("adbec3db-e798-4b59-a8a1-3ef0c251f642"), 732624581L, "dummyEmailHash", "firstName48", "firstName48", "dummyPasswordHash", "dummySalt", new Guid("ccb8a353-17bc-4e58-b4f9-274e96bcf5e8"), "TestTeacher48" },
                    { new Guid("f695bb45-0fcc-4233-b615-69daac6c3ac7"), 732624581L, "dummyEmailHash", "firstName43", "firstName43", "dummyPasswordHash", "dummySalt", new Guid("ccb8a353-17bc-4e58-b4f9-274e96bcf5e8"), "TestTeacher43" },
                    { new Guid("64f7e86e-e102-4040-acc2-89d5c9c06788"), 732624581L, "dummyEmailHash", "firstName38", "firstName38", "dummyPasswordHash", "dummySalt", new Guid("ccb8a353-17bc-4e58-b4f9-274e96bcf5e8"), "TestTeacher38" },
                    { new Guid("c0b88834-6a9a-4c54-9efd-9eba8cba2b31"), 732624581L, "dummyEmailHash", "firstName33", "firstName33", "dummyPasswordHash", "dummySalt", new Guid("ccb8a353-17bc-4e58-b4f9-274e96bcf5e8"), "TestTeacher33" },
                    { new Guid("a60a1d7e-06fa-458f-8a6b-5665cb75fb3c"), 732624581L, "dummyEmailHash", "firstName28", "firstName28", "dummyPasswordHash", "dummySalt", new Guid("ccb8a353-17bc-4e58-b4f9-274e96bcf5e8"), "TestTeacher28" },
                    { new Guid("b09b8afc-d93d-419f-bd2d-c9c2277531d9"), 732624581L, "dummyEmailHash", "firstName23", "firstName23", "dummyPasswordHash", "dummySalt", new Guid("ccb8a353-17bc-4e58-b4f9-274e96bcf5e8"), "TestTeacher23" },
                    { new Guid("a6f53d31-2194-4fad-b679-d54cba290f0a"), 732624581L, "dummyEmailHash", "firstName18", "firstName18", "dummyPasswordHash", "dummySalt", new Guid("ccb8a353-17bc-4e58-b4f9-274e96bcf5e8"), "TestTeacher18" },
                    { new Guid("18ada024-e7e8-40f8-98c2-7f773bbbb751"), 732624581L, "dummyEmailHash", "firstName13", "firstName13", "dummyPasswordHash", "dummySalt", new Guid("ccb8a353-17bc-4e58-b4f9-274e96bcf5e8"), "TestTeacher13" },
                    { new Guid("ebeffb2e-3a83-47bf-b89a-f738c8edc152"), 732624581L, "dummyEmailHash", "firstName8", "firstName8", "dummyPasswordHash", "dummySalt", new Guid("ccb8a353-17bc-4e58-b4f9-274e96bcf5e8"), "TestTeacher8" },
                    { new Guid("99e90f8f-d4ef-4493-93c7-929399c870d5"), 732624581L, "dummyEmailHash", "firstName3", "firstName3", "dummyPasswordHash", "dummySalt", new Guid("ccb8a353-17bc-4e58-b4f9-274e96bcf5e8"), "TestTeacher3" },
                    { new Guid("0a56d0c8-98c6-400e-abe3-fb0a9a9f286b"), 732624581L, "dummyEmailHash", "firstName97", "firstName97", "dummyPasswordHash", "dummySalt", new Guid("b77eb52b-a2cc-422a-a182-0ec7f2415033"), "TestTeacher97" },
                    { new Guid("ce390f41-873c-453d-9f08-1266e2189587"), 732624581L, "dummyEmailHash", "firstName92", "firstName92", "dummyPasswordHash", "dummySalt", new Guid("b77eb52b-a2cc-422a-a182-0ec7f2415033"), "TestTeacher92" },
                    { new Guid("cb6e00a5-c211-4508-b6d7-cd48332e9344"), 732624581L, "dummyEmailHash", "firstName87", "firstName87", "dummyPasswordHash", "dummySalt", new Guid("b77eb52b-a2cc-422a-a182-0ec7f2415033"), "TestTeacher87" },
                    { new Guid("0529f9b9-58d2-4049-ad74-15f95b12b9cf"), 732624581L, "dummyEmailHash", "firstName82", "firstName82", "dummyPasswordHash", "dummySalt", new Guid("b77eb52b-a2cc-422a-a182-0ec7f2415033"), "TestTeacher82" },
                    { new Guid("d3d71917-ddd3-40d3-9ba2-c2d1827161e5"), 732624581L, "dummyEmailHash", "firstName77", "firstName77", "dummyPasswordHash", "dummySalt", new Guid("b77eb52b-a2cc-422a-a182-0ec7f2415033"), "TestTeacher77" },
                    { new Guid("ed1486d0-4af1-449f-882e-93b5bc021952"), 732624581L, "dummyEmailHash", "firstName72", "firstName72", "dummyPasswordHash", "dummySalt", new Guid("b77eb52b-a2cc-422a-a182-0ec7f2415033"), "TestTeacher72" },
                    { new Guid("4a2d65f4-7aa3-4350-83f3-35994bbcb0d9"), 732624581L, "dummyEmailHash", "firstName67", "firstName67", "dummyPasswordHash", "dummySalt", new Guid("b77eb52b-a2cc-422a-a182-0ec7f2415033"), "TestTeacher67" },
                    { new Guid("ed739eb3-57d3-4d4d-9fa3-1ad130210c41"), 732624581L, "dummyEmailHash", "firstName62", "firstName62", "dummyPasswordHash", "dummySalt", new Guid("b77eb52b-a2cc-422a-a182-0ec7f2415033"), "TestTeacher62" },
                    { new Guid("4bc31229-4343-493d-94ba-f19b12c1369e"), 732624581L, "dummyEmailHash", "firstName68", "firstName68", "dummyPasswordHash", "dummySalt", new Guid("ccb8a353-17bc-4e58-b4f9-274e96bcf5e8"), "TestTeacher68" },
                    { new Guid("00539901-185f-4490-9481-1d072c53c697"), 732624581L, "dummyEmailHash", "firstName57", "firstName57", "dummyPasswordHash", "dummySalt", new Guid("b77eb52b-a2cc-422a-a182-0ec7f2415033"), "TestTeacher57" },
                    { new Guid("d9de457e-9281-402d-98fd-7d467de2be83"), 732624581L, "dummyEmailHash", "firstName73", "firstName73", "dummyPasswordHash", "dummySalt", new Guid("ccb8a353-17bc-4e58-b4f9-274e96bcf5e8"), "TestTeacher73" },
                    { new Guid("f7e5f018-9a10-4752-9db7-83a5ca102f64"), 732624581L, "dummyEmailHash", "firstName83", "firstName83", "dummyPasswordHash", "dummySalt", new Guid("ccb8a353-17bc-4e58-b4f9-274e96bcf5e8"), "TestTeacher83" },
                    { new Guid("4161656d-8fe1-4a17-915a-7ff4d8343cc3"), 732624581L, "dummyEmailHash", "firstName89", "firstName89", "dummyPasswordHash", "dummySalt", new Guid("7bdfa859-a50a-407b-a971-7234f1b0e08d"), "TestTeacher89" },
                    { new Guid("07ed323a-f925-4a9a-bcfa-cbfa4333a7b1"), 732624581L, "dummyEmailHash", "firstName84", "firstName84", "dummyPasswordHash", "dummySalt", new Guid("7bdfa859-a50a-407b-a971-7234f1b0e08d"), "TestTeacher84" },
                    { new Guid("1766f994-8239-4121-b06d-ad7564b3bfc6"), 732624581L, "dummyEmailHash", "firstName79", "firstName79", "dummyPasswordHash", "dummySalt", new Guid("7bdfa859-a50a-407b-a971-7234f1b0e08d"), "TestTeacher79" },
                    { new Guid("c4a5a9d7-7554-4f06-9602-178bba9fb90f"), 732624581L, "dummyEmailHash", "firstName74", "firstName74", "dummyPasswordHash", "dummySalt", new Guid("7bdfa859-a50a-407b-a971-7234f1b0e08d"), "TestTeacher74" },
                    { new Guid("8a4e5172-587a-4f9a-a024-fa1a78aac605"), 732624581L, "dummyEmailHash", "firstName69", "firstName69", "dummyPasswordHash", "dummySalt", new Guid("7bdfa859-a50a-407b-a971-7234f1b0e08d"), "TestTeacher69" },
                    { new Guid("c8258a3d-48f8-4eac-b14e-18ced7b5618e"), 732624581L, "dummyEmailHash", "firstName64", "firstName64", "dummyPasswordHash", "dummySalt", new Guid("7bdfa859-a50a-407b-a971-7234f1b0e08d"), "TestTeacher64" },
                    { new Guid("14ea1798-d8e8-4752-833b-931135f3cc46"), 732624581L, "dummyEmailHash", "firstName59", "firstName59", "dummyPasswordHash", "dummySalt", new Guid("7bdfa859-a50a-407b-a971-7234f1b0e08d"), "TestTeacher59" },
                    { new Guid("cb80fe9b-1a1d-4214-bb57-2e630f55f6e9"), 732624581L, "dummyEmailHash", "firstName54", "firstName54", "dummyPasswordHash", "dummySalt", new Guid("7bdfa859-a50a-407b-a971-7234f1b0e08d"), "TestTeacher54" },
                    { new Guid("2b8b30bd-1ff4-4f45-81e7-92d191fae001"), 732624581L, "dummyEmailHash", "firstName49", "firstName49", "dummyPasswordHash", "dummySalt", new Guid("7bdfa859-a50a-407b-a971-7234f1b0e08d"), "TestTeacher49" },
                    { new Guid("0fe90da4-1897-46a6-a2e8-5326e2ad84d8"), 732624581L, "dummyEmailHash", "firstName44", "firstName44", "dummyPasswordHash", "dummySalt", new Guid("7bdfa859-a50a-407b-a971-7234f1b0e08d"), "TestTeacher44" },
                    { new Guid("7c3a81a4-266d-4f0c-b73a-38e6d61e9622"), 732624581L, "dummyEmailHash", "firstName39", "firstName39", "dummyPasswordHash", "dummySalt", new Guid("7bdfa859-a50a-407b-a971-7234f1b0e08d"), "TestTeacher39" },
                    { new Guid("0fd529d1-e3e2-47c5-b856-7aba08cbbbf0"), 732624581L, "dummyEmailHash", "firstName34", "firstName34", "dummyPasswordHash", "dummySalt", new Guid("7bdfa859-a50a-407b-a971-7234f1b0e08d"), "TestTeacher34" },
                    { new Guid("ce09c1a2-6510-4c84-a533-688fbff0d1b4"), 732624581L, "dummyEmailHash", "firstName29", "firstName29", "dummyPasswordHash", "dummySalt", new Guid("7bdfa859-a50a-407b-a971-7234f1b0e08d"), "TestTeacher29" },
                    { new Guid("d8ddd747-6d87-410d-bf56-417d725c9a22"), 732624581L, "dummyEmailHash", "firstName24", "firstName24", "dummyPasswordHash", "dummySalt", new Guid("7bdfa859-a50a-407b-a971-7234f1b0e08d"), "TestTeacher24" },
                    { new Guid("86902e3d-1f5b-4abe-9ab7-3fd73dd5ab90"), 732624581L, "dummyEmailHash", "firstName19", "firstName19", "dummyPasswordHash", "dummySalt", new Guid("7bdfa859-a50a-407b-a971-7234f1b0e08d"), "TestTeacher19" },
                    { new Guid("5eb8b880-4da8-4c05-9c7b-0e9c25dc8cac"), 732624581L, "dummyEmailHash", "firstName14", "firstName14", "dummyPasswordHash", "dummySalt", new Guid("7bdfa859-a50a-407b-a971-7234f1b0e08d"), "TestTeacher14" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "DateOfBirth", "EmailHash", "FirstName", "LastName", "PasswordHash", "Salt", "TeacherDegreeId", "Username" },
                values: new object[,]
                {
                    { new Guid("a78db448-cd3f-412c-9d1e-0fd2a204ba46"), 732624581L, "dummyEmailHash", "firstName9", "firstName9", "dummyPasswordHash", "dummySalt", new Guid("7bdfa859-a50a-407b-a971-7234f1b0e08d"), "TestTeacher9" },
                    { new Guid("b525ecf2-7acd-47bd-87ae-5309b598ee56"), 732624581L, "dummyEmailHash", "firstName4", "firstName4", "dummyPasswordHash", "dummySalt", new Guid("7bdfa859-a50a-407b-a971-7234f1b0e08d"), "TestTeacher4" },
                    { new Guid("7ad86313-7bbc-4d7f-899c-86985ce8b6ab"), 732624581L, "dummyEmailHash", "firstName98", "firstName98", "dummyPasswordHash", "dummySalt", new Guid("ccb8a353-17bc-4e58-b4f9-274e96bcf5e8"), "TestTeacher98" },
                    { new Guid("c693d672-a076-4715-8681-ac0e1c9e8ffe"), 732624581L, "dummyEmailHash", "firstName93", "firstName93", "dummyPasswordHash", "dummySalt", new Guid("ccb8a353-17bc-4e58-b4f9-274e96bcf5e8"), "TestTeacher93" },
                    { new Guid("e6b51413-4b52-4843-85a2-78ed2c0eea2f"), 732624581L, "dummyEmailHash", "firstName88", "firstName88", "dummyPasswordHash", "dummySalt", new Guid("ccb8a353-17bc-4e58-b4f9-274e96bcf5e8"), "TestTeacher88" },
                    { new Guid("2d18691c-989d-416d-a354-29be08ce9df1"), 732624581L, "dummyEmailHash", "firstName78", "firstName78", "dummyPasswordHash", "dummySalt", new Guid("ccb8a353-17bc-4e58-b4f9-274e96bcf5e8"), "TestTeacher78" },
                    { new Guid("a5da19b2-60d3-4a47-aa17-6a9bb34f6923"), 732624581L, "dummyEmailHash", "firstName52", "firstName52", "dummyPasswordHash", "dummySalt", new Guid("b77eb52b-a2cc-422a-a182-0ec7f2415033"), "TestTeacher52" },
                    { new Guid("8c7fd48c-4b7c-4b23-a1eb-7b91ac817ded"), 732624581L, "dummyEmailHash", "firstName47", "firstName47", "dummyPasswordHash", "dummySalt", new Guid("b77eb52b-a2cc-422a-a182-0ec7f2415033"), "TestTeacher47" },
                    { new Guid("6cc73e31-6f80-4272-82bf-eb0a1325aeb4"), 732624581L, "dummyEmailHash", "firstName42", "firstName42", "dummyPasswordHash", "dummySalt", new Guid("b77eb52b-a2cc-422a-a182-0ec7f2415033"), "TestTeacher42" },
                    { new Guid("63e1742b-49cd-41ed-b0dc-d6616bf232ba"), 732624581L, "dummyEmailHash", "firstName6", "firstName6", "dummyPasswordHash", "dummySalt", new Guid("ad7bfb67-c85a-4fe5-9e29-f076d4abe93d"), "TestTeacher6" },
                    { new Guid("c1ca1d9c-52aa-4c4f-a70a-268d06835428"), 732624581L, "dummyEmailHash", "firstName1", "firstName1", "dummyPasswordHash", "dummySalt", new Guid("ad7bfb67-c85a-4fe5-9e29-f076d4abe93d"), "TestTeacher1" },
                    { new Guid("5d1d8f68-958b-4b72-a3d9-ab026d6c9b3b"), 732624581L, "dummyEmailHash", "firstName95", "firstName95", "dummyPasswordHash", "dummySalt", new Guid("dba7f37d-5603-4523-ae4c-4a697a3b4efc"), "TestTeacher95" },
                    { new Guid("d3e32fcf-a08d-4708-8b06-0d1ea51a808f"), 732624581L, "dummyEmailHash", "firstName90", "firstName90", "dummyPasswordHash", "dummySalt", new Guid("dba7f37d-5603-4523-ae4c-4a697a3b4efc"), "TestTeacher90" },
                    { new Guid("1bb30181-e8ba-4ab9-85d3-d81474aca8d1"), 732624581L, "dummyEmailHash", "firstName85", "firstName85", "dummyPasswordHash", "dummySalt", new Guid("dba7f37d-5603-4523-ae4c-4a697a3b4efc"), "TestTeacher85" },
                    { new Guid("0f3a6be6-d338-4180-9f66-12eea50cc59b"), 732624581L, "dummyEmailHash", "firstName80", "firstName80", "dummyPasswordHash", "dummySalt", new Guid("dba7f37d-5603-4523-ae4c-4a697a3b4efc"), "TestTeacher80" },
                    { new Guid("92b3dc88-fead-4a45-aba3-4aeae5dbec80"), 732624581L, "dummyEmailHash", "firstName75", "firstName75", "dummyPasswordHash", "dummySalt", new Guid("dba7f37d-5603-4523-ae4c-4a697a3b4efc"), "TestTeacher75" },
                    { new Guid("a07c095e-f185-4765-958b-121530f33152"), 732624581L, "dummyEmailHash", "firstName70", "firstName70", "dummyPasswordHash", "dummySalt", new Guid("dba7f37d-5603-4523-ae4c-4a697a3b4efc"), "TestTeacher70" },
                    { new Guid("71fbe949-8b66-4ee4-b52b-3c5370663ef6"), 732624581L, "dummyEmailHash", "firstName65", "firstName65", "dummyPasswordHash", "dummySalt", new Guid("dba7f37d-5603-4523-ae4c-4a697a3b4efc"), "TestTeacher65" },
                    { new Guid("b7e178a9-8cfe-4c9c-aeab-dc77f9f2de35"), 732624581L, "dummyEmailHash", "firstName60", "firstName60", "dummyPasswordHash", "dummySalt", new Guid("dba7f37d-5603-4523-ae4c-4a697a3b4efc"), "TestTeacher60" },
                    { new Guid("3789d0c1-a469-45be-ae4a-383778d9e884"), 732624581L, "dummyEmailHash", "firstName55", "firstName55", "dummyPasswordHash", "dummySalt", new Guid("dba7f37d-5603-4523-ae4c-4a697a3b4efc"), "TestTeacher55" },
                    { new Guid("a6a34e96-0ca8-49d8-a157-d49457805cae"), 732624581L, "dummyEmailHash", "firstName50", "firstName50", "dummyPasswordHash", "dummySalt", new Guid("dba7f37d-5603-4523-ae4c-4a697a3b4efc"), "TestTeacher50" },
                    { new Guid("2a164668-67e3-4a12-b8a1-af89e56f1a14"), 732624581L, "dummyEmailHash", "firstName45", "firstName45", "dummyPasswordHash", "dummySalt", new Guid("dba7f37d-5603-4523-ae4c-4a697a3b4efc"), "TestTeacher45" },
                    { new Guid("057dfd7c-e065-4359-ad7d-4f9203a48204"), 732624581L, "dummyEmailHash", "firstName40", "firstName40", "dummyPasswordHash", "dummySalt", new Guid("dba7f37d-5603-4523-ae4c-4a697a3b4efc"), "TestTeacher40" },
                    { new Guid("5e08f64f-4cf8-4a4f-8b01-640e5291e9ba"), 732624581L, "dummyEmailHash", "firstName35", "firstName35", "dummyPasswordHash", "dummySalt", new Guid("dba7f37d-5603-4523-ae4c-4a697a3b4efc"), "TestTeacher35" },
                    { new Guid("3c7e6dc1-9f2d-42d3-9e4d-e2431a493beb"), 732624581L, "dummyEmailHash", "firstName30", "firstName30", "dummyPasswordHash", "dummySalt", new Guid("dba7f37d-5603-4523-ae4c-4a697a3b4efc"), "TestTeacher30" },
                    { new Guid("6985d0e1-cd88-42c9-814a-158b42abd6d6"), 732624581L, "dummyEmailHash", "firstName25", "firstName25", "dummyPasswordHash", "dummySalt", new Guid("dba7f37d-5603-4523-ae4c-4a697a3b4efc"), "TestTeacher25" },
                    { new Guid("a188125a-5041-418b-ac92-5303ce6e8a12"), 732624581L, "dummyEmailHash", "firstName20", "firstName20", "dummyPasswordHash", "dummySalt", new Guid("dba7f37d-5603-4523-ae4c-4a697a3b4efc"), "TestTeacher20" },
                    { new Guid("ec29cecf-9bb4-4b00-9d9a-5d0ccad64829"), 732624581L, "dummyEmailHash", "firstName15", "firstName15", "dummyPasswordHash", "dummySalt", new Guid("dba7f37d-5603-4523-ae4c-4a697a3b4efc"), "TestTeacher15" },
                    { new Guid("13204af6-237b-4597-bb1a-c82c23c09636"), 732624581L, "dummyEmailHash", "firstName10", "firstName10", "dummyPasswordHash", "dummySalt", new Guid("dba7f37d-5603-4523-ae4c-4a697a3b4efc"), "TestTeacher10" },
                    { new Guid("4769333d-bd39-4438-862b-97f82854efd1"), 732624581L, "dummyEmailHash", "firstName5", "firstName5", "dummyPasswordHash", "dummySalt", new Guid("dba7f37d-5603-4523-ae4c-4a697a3b4efc"), "TestTeacher5" },
                    { new Guid("86828be7-9d59-413e-8b29-4318311399e4"), 732624581L, "dummyEmailHash", "firstName11", "firstName11", "dummyPasswordHash", "dummySalt", new Guid("ad7bfb67-c85a-4fe5-9e29-f076d4abe93d"), "TestTeacher11" },
                    { new Guid("8d205a81-e2bc-4419-9b80-76829198e56a"), 732624581L, "dummyEmailHash", "firstName16", "firstName16", "dummyPasswordHash", "dummySalt", new Guid("ad7bfb67-c85a-4fe5-9e29-f076d4abe93d"), "TestTeacher16" },
                    { new Guid("88cd051e-9532-48bd-813a-11525e0bc1af"), 732624581L, "dummyEmailHash", "firstName21", "firstName21", "dummyPasswordHash", "dummySalt", new Guid("ad7bfb67-c85a-4fe5-9e29-f076d4abe93d"), "TestTeacher21" },
                    { new Guid("ba0e5c03-6f8b-4477-9e10-0a882b4c3832"), 732624581L, "dummyEmailHash", "firstName26", "firstName26", "dummyPasswordHash", "dummySalt", new Guid("ad7bfb67-c85a-4fe5-9e29-f076d4abe93d"), "TestTeacher26" },
                    { new Guid("7edca406-8727-4468-98f7-a23690714cf9"), 732624581L, "dummyEmailHash", "firstName37", "firstName37", "dummyPasswordHash", "dummySalt", new Guid("b77eb52b-a2cc-422a-a182-0ec7f2415033"), "TestTeacher37" },
                    { new Guid("d27b117a-d80a-4155-8dfa-522f22cd4429"), 732624581L, "dummyEmailHash", "firstName32", "firstName32", "dummyPasswordHash", "dummySalt", new Guid("b77eb52b-a2cc-422a-a182-0ec7f2415033"), "TestTeacher32" },
                    { new Guid("c3463b63-6f38-4d78-ba4c-b946177b6401"), 732624581L, "dummyEmailHash", "firstName27", "firstName27", "dummyPasswordHash", "dummySalt", new Guid("b77eb52b-a2cc-422a-a182-0ec7f2415033"), "TestTeacher27" },
                    { new Guid("69f353ab-b263-41df-ad3e-e3fb8493d9ac"), 732624581L, "dummyEmailHash", "firstName22", "firstName22", "dummyPasswordHash", "dummySalt", new Guid("b77eb52b-a2cc-422a-a182-0ec7f2415033"), "TestTeacher22" },
                    { new Guid("a62b56c5-0991-4667-bd30-c537863e29b8"), 732624581L, "dummyEmailHash", "firstName17", "firstName17", "dummyPasswordHash", "dummySalt", new Guid("b77eb52b-a2cc-422a-a182-0ec7f2415033"), "TestTeacher17" },
                    { new Guid("063abe97-7452-429b-8088-ae02501cf52a"), 732624581L, "dummyEmailHash", "firstName12", "firstName12", "dummyPasswordHash", "dummySalt", new Guid("b77eb52b-a2cc-422a-a182-0ec7f2415033"), "TestTeacher12" },
                    { new Guid("5a91c10d-b6e0-4886-9ff9-10107fcb6761"), 732624581L, "dummyEmailHash", "firstName7", "firstName7", "dummyPasswordHash", "dummySalt", new Guid("b77eb52b-a2cc-422a-a182-0ec7f2415033"), "TestTeacher7" },
                    { new Guid("38eccc3c-7b82-450f-8c4c-bdcbae4ec305"), 732624581L, "dummyEmailHash", "firstName2", "firstName2", "dummyPasswordHash", "dummySalt", new Guid("b77eb52b-a2cc-422a-a182-0ec7f2415033"), "TestTeacher2" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "DateOfBirth", "EmailHash", "FirstName", "LastName", "PasswordHash", "Salt", "TeacherDegreeId", "Username" },
                values: new object[,]
                {
                    { new Guid("77abbb72-1f82-42ba-8f26-b31bc1a26767"), 732624581L, "dummyEmailHash", "firstName96", "firstName96", "dummyPasswordHash", "dummySalt", new Guid("ad7bfb67-c85a-4fe5-9e29-f076d4abe93d"), "TestTeacher96" },
                    { new Guid("1e35327d-ef8b-4490-bfda-21a7cd39cdd0"), 732624581L, "dummyEmailHash", "firstName91", "firstName91", "dummyPasswordHash", "dummySalt", new Guid("ad7bfb67-c85a-4fe5-9e29-f076d4abe93d"), "TestTeacher91" },
                    { new Guid("8766bb6f-dce9-4dac-a46c-7c2a0243cf58"), 732624581L, "dummyEmailHash", "firstName94", "firstName94", "dummyPasswordHash", "dummySalt", new Guid("7bdfa859-a50a-407b-a971-7234f1b0e08d"), "TestTeacher94" },
                    { new Guid("4adb9302-baad-4231-9a53-e750e5383bc8"), 732624581L, "dummyEmailHash", "firstName86", "firstName86", "dummyPasswordHash", "dummySalt", new Guid("ad7bfb67-c85a-4fe5-9e29-f076d4abe93d"), "TestTeacher86" },
                    { new Guid("a906fee8-00ee-4be0-aa58-fc3469ded86a"), 732624581L, "dummyEmailHash", "firstName76", "firstName76", "dummyPasswordHash", "dummySalt", new Guid("ad7bfb67-c85a-4fe5-9e29-f076d4abe93d"), "TestTeacher76" },
                    { new Guid("70ebd0f8-7890-43df-9cce-ceeabc3afca3"), 732624581L, "dummyEmailHash", "firstName71", "firstName71", "dummyPasswordHash", "dummySalt", new Guid("ad7bfb67-c85a-4fe5-9e29-f076d4abe93d"), "TestTeacher71" },
                    { new Guid("d45a85ca-e996-416a-b2d8-606426c8a15a"), 732624581L, "dummyEmailHash", "firstName66", "firstName66", "dummyPasswordHash", "dummySalt", new Guid("ad7bfb67-c85a-4fe5-9e29-f076d4abe93d"), "TestTeacher66" },
                    { new Guid("7b4542fb-e33d-46d2-aada-0d7a91ac04b4"), 732624581L, "dummyEmailHash", "firstName61", "firstName61", "dummyPasswordHash", "dummySalt", new Guid("ad7bfb67-c85a-4fe5-9e29-f076d4abe93d"), "TestTeacher61" },
                    { new Guid("0a2bec6b-65e9-4c34-8fa8-eb3a98e94d6c"), 732624581L, "dummyEmailHash", "firstName56", "firstName56", "dummyPasswordHash", "dummySalt", new Guid("ad7bfb67-c85a-4fe5-9e29-f076d4abe93d"), "TestTeacher56" },
                    { new Guid("68b80fce-73ac-4d0a-8df7-929dde1bad2b"), 732624581L, "dummyEmailHash", "firstName51", "firstName51", "dummyPasswordHash", "dummySalt", new Guid("ad7bfb67-c85a-4fe5-9e29-f076d4abe93d"), "TestTeacher51" },
                    { new Guid("501d7bb4-8a43-4591-ba6f-19ea8a68a32d"), 732624581L, "dummyEmailHash", "firstName46", "firstName46", "dummyPasswordHash", "dummySalt", new Guid("ad7bfb67-c85a-4fe5-9e29-f076d4abe93d"), "TestTeacher46" },
                    { new Guid("6b48d1dc-3249-4c0a-b1c0-1eced2993fae"), 732624581L, "dummyEmailHash", "firstName41", "firstName41", "dummyPasswordHash", "dummySalt", new Guid("ad7bfb67-c85a-4fe5-9e29-f076d4abe93d"), "TestTeacher41" },
                    { new Guid("3f76ac73-0ba7-4d6a-ab40-bc387998856f"), 732624581L, "dummyEmailHash", "firstName36", "firstName36", "dummyPasswordHash", "dummySalt", new Guid("ad7bfb67-c85a-4fe5-9e29-f076d4abe93d"), "TestTeacher36" },
                    { new Guid("a338538a-abb1-4870-b2be-f707276ce47b"), 732624581L, "dummyEmailHash", "firstName31", "firstName31", "dummyPasswordHash", "dummySalt", new Guid("ad7bfb67-c85a-4fe5-9e29-f076d4abe93d"), "TestTeacher31" },
                    { new Guid("271a7c7b-38db-467b-a441-d5f44884446b"), 732624581L, "dummyEmailHash", "firstName81", "firstName81", "dummyPasswordHash", "dummySalt", new Guid("ad7bfb67-c85a-4fe5-9e29-f076d4abe93d"), "TestTeacher81" },
                    { new Guid("11d3e5cc-d08b-4545-aa68-881baf307590"), 732624581L, "dummyEmailHash", "firstName99", "firstName99", "dummyPasswordHash", "dummySalt", new Guid("7bdfa859-a50a-407b-a971-7234f1b0e08d"), "TestTeacher99" }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "ChiefOfDepartmentId", "Name" },
                values: new object[] { new Guid("d6d3dbd4-8983-48b9-9532-4dd5ab63e8f6"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3"), "Faculty-0" });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "ChiefOfDepartmentId", "Name" },
                values: new object[] { new Guid("0b834cd4-01a5-4c9e-be16-ad833796545a"), new Guid("c1ca1d9c-52aa-4c4f-a70a-268d06835428"), "Faculty-1" });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "ChiefOfDepartmentId", "Name" },
                values: new object[] { new Guid("caf55053-f8d4-42b1-a5b6-e94f00725a0d"), new Guid("38eccc3c-7b82-450f-8c4c-bdcbae4ec305"), "Faculty-2" });

            migrationBuilder.InsertData(
                table: "StudyDegrees",
                columns: new[] { "Id", "FacultyId", "Name" },
                values: new object[,]
                {
                    { new Guid("43dd92a3-6293-45d3-9c5b-a6dbf9db90c6"), new Guid("d6d3dbd4-8983-48b9-9532-4dd5ab63e8f6"), "StudyDegree-0" },
                    { new Guid("1752d89d-6dc1-48fb-8ab2-0dbd19cbb3d4"), new Guid("d6d3dbd4-8983-48b9-9532-4dd5ab63e8f6"), "StudyDegree-1" },
                    { new Guid("af5d3569-a960-4e9a-9d4d-6c825e70809a"), new Guid("0b834cd4-01a5-4c9e-be16-ad833796545a"), "StudyDegree-2" },
                    { new Guid("31bd8ce1-a380-4694-a8be-59c221ee40d0"), new Guid("0b834cd4-01a5-4c9e-be16-ad833796545a"), "StudyDegree-3" },
                    { new Guid("1186e97f-b540-49db-978a-729a1db1a4bc"), new Guid("caf55053-f8d4-42b1-a5b6-e94f00725a0d"), "StudyDegree-4" },
                    { new Guid("02987f43-2f76-4e6d-bcf2-2e436ca5458c"), new Guid("caf55053-f8d4-42b1-a5b6-e94f00725a0d"), "StudyDegree-5" }
                });

            migrationBuilder.InsertData(
                table: "Specialisations",
                columns: new[] { "Id", "Name", "StudyDegreeId" },
                values: new object[,]
                {
                    { new Guid("fb7b2029-c02c-4923-b814-a1eb22ee41be"), "Specialisation-0", new Guid("43dd92a3-6293-45d3-9c5b-a6dbf9db90c6") },
                    { new Guid("90b05f7e-4c81-4241-8fc8-0c77e71880d5"), "Specialisation-15", new Guid("02987f43-2f76-4e6d-bcf2-2e436ca5458c") },
                    { new Guid("448ceb05-cfb4-44b9-8123-afb138eb30e9"), "Specialisation-14", new Guid("1186e97f-b540-49db-978a-729a1db1a4bc") },
                    { new Guid("c0dd7644-d4f9-4dbc-98f0-dbd7e5893645"), "Specialisation-13", new Guid("1186e97f-b540-49db-978a-729a1db1a4bc") },
                    { new Guid("b274a5d0-4803-4502-8223-4c6271433dc2"), "Specialisation-12", new Guid("1186e97f-b540-49db-978a-729a1db1a4bc") },
                    { new Guid("1246db25-dc46-4452-8314-d476e8c94651"), "Specialisation-11", new Guid("31bd8ce1-a380-4694-a8be-59c221ee40d0") },
                    { new Guid("2159199a-09ad-4c9b-8398-523ab7e26539"), "Specialisation-10", new Guid("31bd8ce1-a380-4694-a8be-59c221ee40d0") },
                    { new Guid("9c6d7b51-8f57-4532-86a7-c72e4da75de5"), "Specialisation-9", new Guid("31bd8ce1-a380-4694-a8be-59c221ee40d0") },
                    { new Guid("f4022178-888c-46ca-9f22-211f1b59a893"), "Specialisation-8", new Guid("af5d3569-a960-4e9a-9d4d-6c825e70809a") },
                    { new Guid("ce62a5e1-0668-4152-bb3b-0649e5b15d99"), "Specialisation-7", new Guid("af5d3569-a960-4e9a-9d4d-6c825e70809a") },
                    { new Guid("4af0f500-05a8-4bdf-a6d1-7667146fe741"), "Specialisation-6", new Guid("af5d3569-a960-4e9a-9d4d-6c825e70809a") },
                    { new Guid("0288a31c-a87d-4aea-b2e5-977400a16b1a"), "Specialisation-5", new Guid("1752d89d-6dc1-48fb-8ab2-0dbd19cbb3d4") },
                    { new Guid("71292728-cfe3-44c6-9db7-581cdfec3206"), "Specialisation-4", new Guid("1752d89d-6dc1-48fb-8ab2-0dbd19cbb3d4") },
                    { new Guid("7fba1b03-a3d9-4b80-9de5-fc7dfe7ac695"), "Specialisation-3", new Guid("1752d89d-6dc1-48fb-8ab2-0dbd19cbb3d4") },
                    { new Guid("91305f01-8cf3-4101-8dad-841b7f559e29"), "Specialisation-2", new Guid("43dd92a3-6293-45d3-9c5b-a6dbf9db90c6") },
                    { new Guid("7a013779-b6f9-4c03-9c1c-3d2a85bdef57"), "Specialisation-1", new Guid("43dd92a3-6293-45d3-9c5b-a6dbf9db90c6") },
                    { new Guid("862c4c8c-7e6b-4c07-9854-e5da7f7ca9de"), "Specialisation-16", new Guid("02987f43-2f76-4e6d-bcf2-2e436ca5458c") },
                    { new Guid("15001e8d-b4d4-46a9-8e9a-9950d3458dc6"), "Specialisation-17", new Guid("02987f43-2f76-4e6d-bcf2-2e436ca5458c") }
                });

            migrationBuilder.InsertData(
                table: "StudyYears",
                columns: new[] { "Id", "SpecialisationId", "StudentLeaderUserId", "Year" },
                values: new object[,]
                {
                    { new Guid("ff2d24aa-a55c-48e3-ad76-4c727a541333"), new Guid("fb7b2029-c02c-4923-b814-a1eb22ee41be"), null, (short)1 },
                    { new Guid("f43c473b-a54c-492f-838b-9a8196a5bddf"), new Guid("9c6d7b51-8f57-4532-86a7-c72e4da75de5"), null, (short)3 },
                    { new Guid("f19b6bb5-fbcb-4ec2-bf35-eafa03f1a1d0"), new Guid("2159199a-09ad-4c9b-8398-523ab7e26539"), null, (short)1 },
                    { new Guid("63202067-dc60-4ff4-a0f0-444b930472a1"), new Guid("2159199a-09ad-4c9b-8398-523ab7e26539"), null, (short)2 },
                    { new Guid("e210df54-d162-4eb5-b175-39d5887e5364"), new Guid("2159199a-09ad-4c9b-8398-523ab7e26539"), null, (short)3 },
                    { new Guid("1d820d11-3d53-47d8-a9b1-842a7cb331af"), new Guid("1246db25-dc46-4452-8314-d476e8c94651"), null, (short)1 },
                    { new Guid("93152e98-e110-4205-8b7f-cf7bc3ca78eb"), new Guid("1246db25-dc46-4452-8314-d476e8c94651"), null, (short)2 },
                    { new Guid("dd16e975-2f23-44bb-a48f-1cd78c65049e"), new Guid("1246db25-dc46-4452-8314-d476e8c94651"), null, (short)3 },
                    { new Guid("4ec7995f-c463-4355-a14d-a1f23c753d80"), new Guid("b274a5d0-4803-4502-8223-4c6271433dc2"), null, (short)1 },
                    { new Guid("593a22af-f535-46d5-9d0c-45b6d66251c7"), new Guid("b274a5d0-4803-4502-8223-4c6271433dc2"), null, (short)2 },
                    { new Guid("af8f5041-d121-4e38-b3be-0d5eb38eb33b"), new Guid("b274a5d0-4803-4502-8223-4c6271433dc2"), null, (short)3 },
                    { new Guid("802d0b3e-e225-4f6d-a7c5-ef894d9249ec"), new Guid("c0dd7644-d4f9-4dbc-98f0-dbd7e5893645"), null, (short)1 },
                    { new Guid("2529e03f-5098-43fc-ba4d-d3948a0a661e"), new Guid("c0dd7644-d4f9-4dbc-98f0-dbd7e5893645"), null, (short)2 },
                    { new Guid("f8b802df-afbe-4fe6-a8bc-97f64504a163"), new Guid("c0dd7644-d4f9-4dbc-98f0-dbd7e5893645"), null, (short)3 },
                    { new Guid("cde5a564-98f9-4ce6-a236-e3d0fa45f86c"), new Guid("448ceb05-cfb4-44b9-8123-afb138eb30e9"), null, (short)1 },
                    { new Guid("ed636f8a-82b9-431b-a59a-878556432b38"), new Guid("448ceb05-cfb4-44b9-8123-afb138eb30e9"), null, (short)2 },
                    { new Guid("ae156b44-006d-41aa-bbf7-d0d776a6c4b4"), new Guid("448ceb05-cfb4-44b9-8123-afb138eb30e9"), null, (short)3 },
                    { new Guid("7f47db36-5375-4945-a34f-2fae66da2176"), new Guid("90b05f7e-4c81-4241-8fc8-0c77e71880d5"), null, (short)1 },
                    { new Guid("1b51e226-4a5c-4337-b683-4c5dc89335be"), new Guid("90b05f7e-4c81-4241-8fc8-0c77e71880d5"), null, (short)2 },
                    { new Guid("9a81dd99-365c-4697-80f6-125b0d2a211e"), new Guid("90b05f7e-4c81-4241-8fc8-0c77e71880d5"), null, (short)3 },
                    { new Guid("c86f3bf7-b95e-44d6-9a2f-e7454ee4c0c2"), new Guid("862c4c8c-7e6b-4c07-9854-e5da7f7ca9de"), null, (short)1 },
                    { new Guid("7301c3ee-f7b9-41c0-b20c-597da91df2e3"), new Guid("862c4c8c-7e6b-4c07-9854-e5da7f7ca9de"), null, (short)2 },
                    { new Guid("138beda2-6bb2-417c-aad3-6c4a38053888"), new Guid("862c4c8c-7e6b-4c07-9854-e5da7f7ca9de"), null, (short)3 },
                    { new Guid("00db8b6a-06d6-4482-85e2-aefe69fe7b27"), new Guid("15001e8d-b4d4-46a9-8e9a-9950d3458dc6"), null, (short)1 },
                    { new Guid("3ef93aae-dc2a-4121-b559-01526a9a6a25"), new Guid("9c6d7b51-8f57-4532-86a7-c72e4da75de5"), null, (short)2 },
                    { new Guid("66f6cf78-466b-4db6-a6c2-6ba3b325bf8b"), new Guid("9c6d7b51-8f57-4532-86a7-c72e4da75de5"), null, (short)1 },
                    { new Guid("b2b6c0b3-e2c3-4965-9eb4-d1b7983f393e"), new Guid("f4022178-888c-46ca-9f22-211f1b59a893"), null, (short)3 },
                    { new Guid("ef3e96d0-0704-4172-84da-2bad59787e24"), new Guid("f4022178-888c-46ca-9f22-211f1b59a893"), null, (short)2 },
                    { new Guid("2501a536-7053-448a-b66b-546d1fdff448"), new Guid("fb7b2029-c02c-4923-b814-a1eb22ee41be"), null, (short)2 },
                    { new Guid("29f0b5b1-adb8-49ad-a874-00f120477aed"), new Guid("fb7b2029-c02c-4923-b814-a1eb22ee41be"), null, (short)3 },
                    { new Guid("1a9ba576-f23b-432f-8b2b-eced7f477651"), new Guid("7a013779-b6f9-4c03-9c1c-3d2a85bdef57"), null, (short)1 },
                    { new Guid("423eb9cb-52be-4666-a31d-f3a136dd07e8"), new Guid("7a013779-b6f9-4c03-9c1c-3d2a85bdef57"), null, (short)2 },
                    { new Guid("09def265-353f-43ae-a03f-0181428f5c9e"), new Guid("7a013779-b6f9-4c03-9c1c-3d2a85bdef57"), null, (short)3 },
                    { new Guid("5e6d7f0e-082b-49b4-a587-e0e8a3c22908"), new Guid("91305f01-8cf3-4101-8dad-841b7f559e29"), null, (short)1 },
                    { new Guid("6a622921-055e-4ce6-ba5d-365b34d5d9df"), new Guid("91305f01-8cf3-4101-8dad-841b7f559e29"), null, (short)2 },
                    { new Guid("c1a2c35b-e87b-411d-8a02-613ef419826b"), new Guid("91305f01-8cf3-4101-8dad-841b7f559e29"), null, (short)3 },
                    { new Guid("f19ec3fc-1301-46b2-b8d3-59c84e514218"), new Guid("7fba1b03-a3d9-4b80-9de5-fc7dfe7ac695"), null, (short)1 },
                    { new Guid("c3856fc8-5768-4546-a85b-07d9d20aee14"), new Guid("7fba1b03-a3d9-4b80-9de5-fc7dfe7ac695"), null, (short)2 },
                    { new Guid("db2b8d50-3d9c-4d31-a7bf-cfb8f5543dec"), new Guid("7fba1b03-a3d9-4b80-9de5-fc7dfe7ac695"), null, (short)3 },
                    { new Guid("1d4c88b5-c469-4ef8-84fc-43eabbe25b1f"), new Guid("15001e8d-b4d4-46a9-8e9a-9950d3458dc6"), null, (short)2 },
                    { new Guid("92b4a8a6-88b6-4f7e-8570-84ace9a69dee"), new Guid("71292728-cfe3-44c6-9db7-581cdfec3206"), null, (short)1 },
                    { new Guid("4d5ad130-e756-4835-8f59-a023f609267b"), new Guid("71292728-cfe3-44c6-9db7-581cdfec3206"), null, (short)3 }
                });

            migrationBuilder.InsertData(
                table: "StudyYears",
                columns: new[] { "Id", "SpecialisationId", "StudentLeaderUserId", "Year" },
                values: new object[,]
                {
                    { new Guid("be9fd196-8d97-4ffa-9fb7-18abe9ebeb0d"), new Guid("0288a31c-a87d-4aea-b2e5-977400a16b1a"), null, (short)1 },
                    { new Guid("52612024-de25-4143-8d1b-bf9cd78ee344"), new Guid("0288a31c-a87d-4aea-b2e5-977400a16b1a"), null, (short)2 },
                    { new Guid("163a2cde-0aba-46cd-a99f-da9eebf05024"), new Guid("0288a31c-a87d-4aea-b2e5-977400a16b1a"), null, (short)3 },
                    { new Guid("ab7f4f05-ab53-46b6-a1f3-eb71f1c8a80c"), new Guid("4af0f500-05a8-4bdf-a6d1-7667146fe741"), null, (short)1 },
                    { new Guid("4228e05a-5d6d-40b9-9d99-3dcf71017039"), new Guid("4af0f500-05a8-4bdf-a6d1-7667146fe741"), null, (short)2 },
                    { new Guid("d6808fc1-bacc-4202-8bc2-ce825defe818"), new Guid("4af0f500-05a8-4bdf-a6d1-7667146fe741"), null, (short)3 },
                    { new Guid("112b6fe1-273a-470f-9c81-936b863d27e0"), new Guid("ce62a5e1-0668-4152-bb3b-0649e5b15d99"), null, (short)1 },
                    { new Guid("6115911a-0393-4803-ba8e-4486019dc05e"), new Guid("ce62a5e1-0668-4152-bb3b-0649e5b15d99"), null, (short)2 },
                    { new Guid("27e4abbd-7aab-4ecd-ac3e-65774fb30079"), new Guid("ce62a5e1-0668-4152-bb3b-0649e5b15d99"), null, (short)3 },
                    { new Guid("0f5d50c8-f210-4adc-a9c2-6c669ee84836"), new Guid("f4022178-888c-46ca-9f22-211f1b59a893"), null, (short)1 },
                    { new Guid("0f3c6123-6743-4043-9041-b8e2dc85adb6"), new Guid("71292728-cfe3-44c6-9db7-581cdfec3206"), null, (short)2 },
                    { new Guid("3cf1e957-ab13-4c01-8767-c559290dafdd"), new Guid("15001e8d-b4d4-46a9-8e9a-9950d3458dc6"), null, (short)3 }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "LeaderStudentId", "StudyYearId", "TutorTeacherId" },
                values: new object[,]
                {
                    { new Guid("c8c439f9-fec6-46e3-8ecf-8d7686b2b6ef"), new Guid("864835ed-983c-47ab-9fa4-74182f9a7efd"), new Guid("ff2d24aa-a55c-48e3-ad76-4c727a541333"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("963510d6-9a57-425d-a3ee-f0fd130b77ad"), new Guid("99ddf014-1e00-44cf-b50c-f310e9c7a578"), new Guid("27e4abbd-7aab-4ecd-ac3e-65774fb30079"), new Guid("a07c095e-f185-4765-958b-121530f33152") },
                    { new Guid("b8e83370-a520-488c-a567-ec7a913ffed7"), new Guid("fa0f5fea-3047-4228-aaf3-78fb56f629d9"), new Guid("27e4abbd-7aab-4ecd-ac3e-65774fb30079"), new Guid("70ebd0f8-7890-43df-9cce-ceeabc3afca3") },
                    { new Guid("2cbc2e49-ba23-4a22-87b3-fc7ab7dea5f7"), new Guid("7f47cfd9-dc83-4cc3-a421-b2774d0e2ae1"), new Guid("ae156b44-006d-41aa-bbf7-d0d776a6c4b4"), null },
                    { new Guid("e8f25d3f-996d-4f95-a814-8d739303df87"), new Guid("18c3c341-23fd-4e47-9381-eaf90370bb99"), new Guid("ae156b44-006d-41aa-bbf7-d0d776a6c4b4"), null },
                    { new Guid("dc723434-f040-4705-b7fe-a0ec875165fb"), new Guid("7760094a-f97f-4d90-964e-4bead3c6548a"), new Guid("0f5d50c8-f210-4adc-a9c2-6c669ee84836"), new Guid("ed1486d0-4af1-449f-882e-93b5bc021952") },
                    { new Guid("59c8db82-1bd5-4d52-82b9-de1534336c8e"), new Guid("b649f119-26be-4457-a1c5-f371f099324a"), new Guid("0f5d50c8-f210-4adc-a9c2-6c669ee84836"), new Guid("d9de457e-9281-402d-98fd-7d467de2be83") },
                    { new Guid("6d4d9195-dbc2-42ba-8b2b-02b4b7b5d7a2"), new Guid("f670ee20-cfec-489f-b6ba-2e43907d9bc1"), new Guid("0f5d50c8-f210-4adc-a9c2-6c669ee84836"), new Guid("c4a5a9d7-7554-4f06-9602-178bba9fb90f") },
                    { new Guid("09040555-410f-4bda-9ada-8558a462e97e"), new Guid("dabab4a3-4996-48ae-8f84-158d11dddad1"), new Guid("ef3e96d0-0704-4172-84da-2bad59787e24"), new Guid("92b3dc88-fead-4a45-aba3-4aeae5dbec80") },
                    { new Guid("dabd9a7f-01ef-49ff-830a-63c6b3d8c206"), new Guid("ec9022c9-d5d9-4fe8-b6e9-0bb8b761a2c7"), new Guid("27e4abbd-7aab-4ecd-ac3e-65774fb30079"), new Guid("8a4e5172-587a-4f9a-a024-fa1a78aac605") },
                    { new Guid("cc163017-0796-4e63-afe6-ed96f935ea2f"), new Guid("84e9b211-30f7-4da1-bd76-dda8b1ea93fa"), new Guid("ef3e96d0-0704-4172-84da-2bad59787e24"), new Guid("a906fee8-00ee-4be0-aa58-fc3469ded86a") },
                    { new Guid("32f5c383-18b1-4c1d-b8a0-9f863a6479f9"), new Guid("83c8473f-2064-468d-8de3-30d552fce6fe"), new Guid("ed636f8a-82b9-431b-a59a-878556432b38"), null },
                    { new Guid("b92365a8-758a-4b92-bcbd-d2533b01d134"), new Guid("8c08748d-5061-481b-ba1f-9c1f74b21a73"), new Guid("ed636f8a-82b9-431b-a59a-878556432b38"), null },
                    { new Guid("b543253e-a791-4fd6-b0cb-c8730e6c2311"), new Guid("614a8376-606e-40a3-9b5e-756a635cc0b9"), new Guid("b2b6c0b3-e2c3-4965-9eb4-d1b7983f393e"), new Guid("2d18691c-989d-416d-a354-29be08ce9df1") },
                    { new Guid("c7791c66-63f5-4afe-b85e-a455db16fe30"), new Guid("d649f312-18aa-4508-b497-6da80a0aa84b"), new Guid("b2b6c0b3-e2c3-4965-9eb4-d1b7983f393e"), new Guid("1766f994-8239-4121-b06d-ad7564b3bfc6") },
                    { new Guid("ba1fe61e-bc87-4f3e-b09d-f795e2f01b23"), new Guid("941284c7-92a1-4031-adac-632f2740aa19"), new Guid("b2b6c0b3-e2c3-4965-9eb4-d1b7983f393e"), new Guid("0f3a6be6-d338-4180-9f66-12eea50cc59b") },
                    { new Guid("ee4ad2e3-792f-4c49-9920-cd00516f67b9"), new Guid("ab6434e1-e0f0-4fe8-bce0-04899751ff73"), new Guid("ed636f8a-82b9-431b-a59a-878556432b38"), null },
                    { new Guid("135f2f04-61b8-4720-ac05-1b64dbe7f1b5"), new Guid("26890b54-e6eb-49b3-82cf-3cf959ab419a"), new Guid("66f6cf78-466b-4db6-a6c2-6ba3b325bf8b"), new Guid("271a7c7b-38db-467b-a441-d5f44884446b") },
                    { new Guid("4e213769-744f-4d00-8ab7-9f089ddce22f"), new Guid("847fdbea-4a6c-42bf-b267-2a5e6aded89e"), new Guid("66f6cf78-466b-4db6-a6c2-6ba3b325bf8b"), new Guid("0529f9b9-58d2-4049-ad74-15f95b12b9cf") },
                    { new Guid("53e919b5-1242-4a46-8cdb-0eb506db5312"), new Guid("f2e22ec6-9ed7-4589-9e91-1a533a0ea55e"), new Guid("ef3e96d0-0704-4172-84da-2bad59787e24"), new Guid("d3d71917-ddd3-40d3-9ba2-c2d1827161e5") },
                    { new Guid("51098ce2-4748-4d12-bddb-ba4050b0b895"), new Guid("503cdcf5-b606-49fa-a8db-042c6b3fa9b0"), new Guid("66f6cf78-466b-4db6-a6c2-6ba3b325bf8b"), new Guid("f7e5f018-9a10-4752-9db7-83a5ca102f64") },
                    { new Guid("c8c0ca4f-6734-425b-9a9e-db84ba01eb46"), new Guid("f4e0b2d0-bdac-4053-a2c9-e5a175d2146e"), new Guid("ae156b44-006d-41aa-bbf7-d0d776a6c4b4"), null },
                    { new Guid("61098e44-87fc-4376-990b-a4dd33662844"), new Guid("e6fdc458-a365-4d6b-9302-1dcd1ff0b3bb"), new Guid("6115911a-0393-4803-ba8e-4486019dc05e"), new Guid("4a2d65f4-7aa3-4350-83f3-35994bbcb0d9") },
                    { new Guid("a045fbe8-2653-4c69-81f4-a8f796c7892d"), new Guid("71ad4df6-ad99-45a5-9eee-147afda9ad20"), new Guid("ab7f4f05-ab53-46b6-a1f3-eb71f1c8a80c"), new Guid("cb80fe9b-1a1d-4214-bb57-2e630f55f6e9") },
                    { new Guid("fb811689-f1c5-4efe-8ee0-900892697acc"), new Guid("0a048c60-3802-45b2-b31b-a3ad5366e0d3"), new Guid("ab7f4f05-ab53-46b6-a1f3-eb71f1c8a80c"), new Guid("3789d0c1-a469-45be-ae4a-383778d9e884") },
                    { new Guid("8ae457fb-d6b5-4326-9269-7485c2066b65"), new Guid("44268b05-2ef3-431c-84d1-1a19ba42b983"), new Guid("ab7f4f05-ab53-46b6-a1f3-eb71f1c8a80c"), new Guid("0a2bec6b-65e9-4c34-8fa8-eb3a98e94d6c") },
                    { new Guid("cd2e3863-e10f-4456-90a1-bb7a908b1c7b"), new Guid("a9aa0b7e-f85f-406b-b6e0-688b0a2c756f"), new Guid("1b51e226-4a5c-4337-b683-4c5dc89335be"), null },
                    { new Guid("dc1c36b3-dea5-46d5-a014-33cf018ea978"), new Guid("863ed0d2-93ec-4c81-b767-bfd4628afebd"), new Guid("1b51e226-4a5c-4337-b683-4c5dc89335be"), null },
                    { new Guid("f9224c6e-0e08-4ef0-b121-a243afcef991"), new Guid("13077e2f-d755-4755-9f7f-2acf479f447f"), new Guid("af8f5041-d121-4e38-b3be-0d5eb38eb33b"), null },
                    { new Guid("838615c9-174a-4fc5-9374-35f14ae2748b"), new Guid("70c6f552-ad16-4f08-b6c4-6dc4e333ed88"), new Guid("4228e05a-5d6d-40b9-9d99-3dcf71017039"), new Guid("c02be181-5f7c-4685-89ee-d0b4b1c3dea0") },
                    { new Guid("4fe6eac9-23a0-48c1-90f7-82f5d574bddb"), new Guid("f39f58a5-66a3-48d5-a8c4-c759c9381daf"), new Guid("4228e05a-5d6d-40b9-9d99-3dcf71017039"), new Guid("14ea1798-d8e8-4752-833b-931135f3cc46") },
                    { new Guid("a0a65ae6-0fa8-4c45-93dc-bba19e92251a"), new Guid("9ddc7694-8886-4342-9e35-e30f49b914a6"), new Guid("6115911a-0393-4803-ba8e-4486019dc05e"), new Guid("4bc31229-4343-493d-94ba-f19b12c1369e") },
                    { new Guid("953ae21d-20d8-4e1e-bc3a-e8451f6245f9"), new Guid("a2c2a7ad-527d-4d3e-9f82-bad53d4a25c9"), new Guid("d6808fc1-bacc-4202-8bc2-ce825defe818"), new Guid("b7e178a9-8cfe-4c9c-aeab-dc77f9f2de35") },
                    { new Guid("8a0a3916-5a0d-4af8-9ba2-77c1488b57a0"), new Guid("1782d872-4343-4121-a74a-b8d9f4de521a"), new Guid("d6808fc1-bacc-4202-8bc2-ce825defe818"), new Guid("ed739eb3-57d3-4d4d-9fa3-1ad130210c41") },
                    { new Guid("266e0323-415e-4c4d-9423-46391f5bf26c"), new Guid("84aa42e6-6afe-41c9-b59c-def2a9e99ab6"), new Guid("7f47db36-5375-4945-a34f-2fae66da2176"), null },
                    { new Guid("614095b5-392a-4879-9a13-c519a2a93732"), new Guid("226a90ab-88ca-4c07-8821-c57d057e188e"), new Guid("7f47db36-5375-4945-a34f-2fae66da2176"), null },
                    { new Guid("3fd4e98d-1e7e-43ba-9e74-4bdd5ec2e9b4"), new Guid("1c937154-b733-436c-a8f6-894e21eb44c7"), new Guid("112b6fe1-273a-470f-9c81-936b863d27e0"), new Guid("105a879d-9688-41fc-85f0-a8743376ac65") },
                    { new Guid("deed5e6e-a5f7-48d8-8b72-e0fcabaa0183"), new Guid("c068f017-9340-4626-9e26-38a2afac6cc4"), new Guid("112b6fe1-273a-470f-9c81-936b863d27e0"), new Guid("c8258a3d-48f8-4eac-b14e-18ced7b5618e") },
                    { new Guid("328aea8e-09df-48b8-9e30-3674e7f72dc1"), new Guid("1b3b9a22-c256-4471-8356-fa51c2330f45"), new Guid("112b6fe1-273a-470f-9c81-936b863d27e0"), new Guid("71fbe949-8b66-4ee4-b52b-3c5370663ef6") },
                    { new Guid("2a6e29ca-6ea1-41fd-97bc-404eb791b965"), new Guid("8d50fa94-dd14-4f89-ade5-77de4e179397"), new Guid("7f47db36-5375-4945-a34f-2fae66da2176"), null },
                    { new Guid("f6cb6f78-ce0f-467b-91e1-a9ebc4a09a89"), new Guid("d44bdecf-2774-4ba7-82fb-dc73ef88301e"), new Guid("6115911a-0393-4803-ba8e-4486019dc05e"), new Guid("d45a85ca-e996-416a-b2d8-606426c8a15a") },
                    { new Guid("cdebe47b-21f6-4230-bf3f-fb87eafbae23"), new Guid("5dbcd666-8455-4b6d-b151-f7b63f5b9a41"), new Guid("d6808fc1-bacc-4202-8bc2-ce825defe818"), new Guid("7b4542fb-e33d-46d2-aada-0d7a91ac04b4") }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "LeaderStudentId", "StudyYearId", "TutorTeacherId" },
                values: new object[,]
                {
                    { new Guid("9f27beef-982a-45ea-8ca2-7096a7b3927b"), new Guid("01c22997-99b4-43bd-9330-76f98d09a137"), new Guid("1b51e226-4a5c-4337-b683-4c5dc89335be"), null },
                    { new Guid("d7d7914a-c951-4f3b-b5ca-39c90d6c0bae"), new Guid("38685ac5-15b1-4f8b-9c1a-061d09450c67"), new Guid("cde5a564-98f9-4ce6-a236-e3d0fa45f86c"), null },
                    { new Guid("2b4397bf-27ad-4a04-9ad9-4aa3fc2d5acf"), new Guid("dec162df-07e1-4a73-9469-c7339c202f6c"), new Guid("3ef93aae-dc2a-4121-b559-01526a9a6a25"), new Guid("1bb30181-e8ba-4ab9-85d3-d81474aca8d1") },
                    { new Guid("5a2f8a43-9669-4e1d-a867-c3fe5b7ed8c5"), new Guid("013f8663-4b57-46a0-af8a-c8fb6c25b58c"), new Guid("2529e03f-5098-43fc-ba4d-d3948a0a661e"), null },
                    { new Guid("7bd7673e-6f03-48b5-8cea-8581429ed37b"), new Guid("341f6fb4-9b6c-4fc1-a184-fdf0cc488288"), new Guid("2529e03f-5098-43fc-ba4d-d3948a0a661e"), null },
                    { new Guid("cca100c2-2c9b-48d3-94db-2d480c9cecb8"), new Guid("14890cdf-16be-4c9b-a898-10a6e7e5d16e"), new Guid("93152e98-e110-4205-8b7f-cf7bc3ca78eb"), null },
                    { new Guid("9e3a7b0d-8af2-44a1-a51b-a639a35064c7"), new Guid("b8030296-ce82-429e-808a-79366f01888b"), new Guid("93152e98-e110-4205-8b7f-cf7bc3ca78eb"), null },
                    { new Guid("888ec51d-cb31-4088-9eb9-e76d95e146a8"), new Guid("7a67f2b0-2b07-4922-af6d-b561ce84017f"), new Guid("93152e98-e110-4205-8b7f-cf7bc3ca78eb"), null },
                    { new Guid("e34365c9-032c-4e84-88ae-642af91fa4bd"), new Guid("ea9b6355-8e01-4f09-9191-a0f8ca9c651c"), new Guid("dd16e975-2f23-44bb-a48f-1cd78c65049e"), null },
                    { new Guid("7c03f659-1041-4079-9386-c22129f27f6c"), new Guid("fca9dbb9-c681-43c4-8d37-c0d97fb00ea4"), new Guid("dd16e975-2f23-44bb-a48f-1cd78c65049e"), null },
                    { new Guid("c4a928c7-211e-4ca5-b71e-e06f41a2349f"), new Guid("9f635dbe-b5e1-4930-9d12-671306eb2b52"), new Guid("dd16e975-2f23-44bb-a48f-1cd78c65049e"), null },
                    { new Guid("12aaba2b-95f1-4275-b0c0-37b81a587e4e"), new Guid("39b97487-2694-4ffd-a0b5-07aa0798be6c"), new Guid("1d820d11-3d53-47d8-a9b1-842a7cb331af"), null },
                    { new Guid("fb7b85a0-7668-40e3-a588-896fc24922ac"), new Guid("d86f7859-ac80-4845-917e-1cdb92bc8647"), new Guid("802d0b3e-e225-4f6d-a7c5-ef894d9249ec"), null },
                    { new Guid("05508eec-4671-4411-80dd-3a8d423a8074"), new Guid("f33f4675-e4f2-413e-ad20-ed7e12d356d4"), new Guid("4ec7995f-c463-4355-a14d-a1f23c753d80"), null },
                    { new Guid("595fea42-a7b8-4ff0-9fd5-53e1bf7da959"), new Guid("bb062a85-d596-4716-9036-8ec40fadd48b"), new Guid("4ec7995f-c463-4355-a14d-a1f23c753d80"), null },
                    { new Guid("ce17a767-e08c-49d1-9e2f-991193f5ecf1"), new Guid("8354d94a-b9bf-44f3-8bbd-34577523110c"), new Guid("4ec7995f-c463-4355-a14d-a1f23c753d80"), null },
                    { new Guid("1b35b476-0eff-4957-8217-1170dd4e1b62"), new Guid("ec8355e1-51fb-45c1-a4ef-b2abcaab690e"), new Guid("802d0b3e-e225-4f6d-a7c5-ef894d9249ec"), null },
                    { new Guid("b5c2f921-b844-4a72-90e1-ec7acf272325"), new Guid("5653e140-a7c1-4f81-bb3d-d1106305200a"), new Guid("593a22af-f535-46d5-9d0c-45b6d66251c7"), null },
                    { new Guid("78f6b406-99f2-4f23-9a19-7796212e4c62"), new Guid("8a4c5196-13ba-465f-a83f-418ad25fd9c6"), new Guid("593a22af-f535-46d5-9d0c-45b6d66251c7"), null },
                    { new Guid("8594eee3-4bc5-4e51-8322-78fb4012fc15"), new Guid("9d5d424c-c240-44e5-babd-d2f251db44bd"), new Guid("593a22af-f535-46d5-9d0c-45b6d66251c7"), null },
                    { new Guid("14aa362e-33a1-4a38-a2de-04f4e61b3250"), new Guid("88f1f6ee-3ae1-41e3-a71b-f7d3353eb0ea"), new Guid("af8f5041-d121-4e38-b3be-0d5eb38eb33b"), null },
                    { new Guid("fed1807c-4b6c-47bc-a93a-595eea8ebb05"), new Guid("4d8e230c-a9db-4671-8879-64740666635e"), new Guid("802d0b3e-e225-4f6d-a7c5-ef894d9249ec"), null },
                    { new Guid("033a9e62-4ebb-430f-a806-c4fa1c4c0363"), new Guid("ee3ee571-892c-4fc2-aca1-823e1fcd1b23"), new Guid("3ef93aae-dc2a-4121-b559-01526a9a6a25"), new Guid("07ed323a-f925-4a9a-bcfa-cbfa4333a7b1") },
                    { new Guid("15d1c55b-ef0e-478c-984c-081f79e4b108"), new Guid("b392d44a-8521-4389-a1cb-8d8161e5485e"), new Guid("1d820d11-3d53-47d8-a9b1-842a7cb331af"), null },
                    { new Guid("b37f671b-a4f2-48c5-88c9-22d955f6eda4"), new Guid("46b22d75-cb5d-48c6-b394-378bde695691"), new Guid("2529e03f-5098-43fc-ba4d-d3948a0a661e"), null },
                    { new Guid("7190f968-35d6-453e-8810-1d43994e9063"), new Guid("a4f9dcdd-70c1-47b4-aac0-7d5c3e211977"), new Guid("3ef93aae-dc2a-4121-b559-01526a9a6a25"), new Guid("4adb9302-baad-4231-9a53-e750e5383bc8") },
                    { new Guid("faaa30df-1354-4bc2-a9c3-13eeaa4ab270"), new Guid("3df895dc-321d-4fae-897d-6b0ff9fd4db4"), new Guid("cde5a564-98f9-4ce6-a236-e3d0fa45f86c"), null },
                    { new Guid("c489763f-1c11-4368-bea4-607f23193514"), new Guid("be2d873b-0c79-4bde-b1f4-d35143b07d6a"), new Guid("cde5a564-98f9-4ce6-a236-e3d0fa45f86c"), null },
                    { new Guid("1c2646f0-6411-41d2-8046-52f96d8210c8"), new Guid("76770a32-b4e0-4299-8fe6-142312594dec"), new Guid("f43c473b-a54c-492f-838b-9a8196a5bddf"), new Guid("cb6e00a5-c211-4508-b6d7-cd48332e9344") },
                    { new Guid("c49f6795-dc10-4f1f-ae36-18a1128b3b6f"), new Guid("1be7ad0c-995e-4ced-8bd8-7a21fb31efcf"), new Guid("f43c473b-a54c-492f-838b-9a8196a5bddf"), new Guid("e6b51413-4b52-4843-85a2-78ed2c0eea2f") },
                    { new Guid("2ace079e-1c49-4507-b25c-d46033f55c5f"), new Guid("0b0b66b9-5365-490d-980b-e77543d0e7f8"), new Guid("f43c473b-a54c-492f-838b-9a8196a5bddf"), new Guid("4161656d-8fe1-4a17-915a-7ff4d8343cc3") },
                    { new Guid("fcded791-01a5-4c89-b04b-fffba2c87b67"), new Guid("37566277-11bd-45c6-95ef-b8c207ef98dd"), new Guid("f19b6bb5-fbcb-4ec2-bf35-eafa03f1a1d0"), new Guid("d3e32fcf-a08d-4708-8b06-0d1ea51a808f") },
                    { new Guid("8bb35be2-552b-4f99-b872-b7cefae7c5d6"), new Guid("abe7cc15-e681-48e4-8033-18a482ed1910"), new Guid("f19b6bb5-fbcb-4ec2-bf35-eafa03f1a1d0"), new Guid("1e35327d-ef8b-4490-bfda-21a7cd39cdd0") },
                    { new Guid("bdc2f38a-ab1b-4244-a5fa-55fee555809d"), new Guid("e570d899-3729-4c6e-a91b-ebcbf1a65655"), new Guid("1d820d11-3d53-47d8-a9b1-842a7cb331af"), new Guid("11d3e5cc-d08b-4545-aa68-881baf307590") },
                    { new Guid("818986ca-f56f-40c3-a552-0184ed7e3f69"), new Guid("23f78dad-ca3d-4aff-a610-7764a650205c"), new Guid("f19b6bb5-fbcb-4ec2-bf35-eafa03f1a1d0"), new Guid("ce390f41-873c-453d-9f08-1266e2189587") },
                    { new Guid("1b0c2b9c-7727-4a37-b84c-684e3049f5f1"), new Guid("fb8aaa98-d82f-400f-bf8c-0af6af0fea5c"), new Guid("f8b802df-afbe-4fe6-a8bc-97f64504a163"), null },
                    { new Guid("3f02cd7e-cb65-48ce-aa03-8cf188ff1b45"), new Guid("0130e8bf-7265-4191-824b-02f042815014"), new Guid("63202067-dc60-4ff4-a0f0-444b930472a1"), new Guid("c693d672-a076-4715-8681-ac0e1c9e8ffe") },
                    { new Guid("1867367b-629b-4def-bf8b-f133cfd4a07a"), new Guid("3925e9f5-cc86-4bba-aa83-ebe94ddce1f7"), new Guid("63202067-dc60-4ff4-a0f0-444b930472a1"), new Guid("8766bb6f-dce9-4dac-a46c-7c2a0243cf58") },
                    { new Guid("83e76342-10af-41fa-a505-c7baf7c4435f"), new Guid("7f518d29-60ad-4aa9-be1c-3dc5676b38f7"), new Guid("63202067-dc60-4ff4-a0f0-444b930472a1"), new Guid("5d1d8f68-958b-4b72-a3d9-ab026d6c9b3b") },
                    { new Guid("e2d43aba-f61d-4141-b2a4-9d100d67eefe"), new Guid("987966cd-caf4-4960-b37b-3c6bf1b89888"), new Guid("f8b802df-afbe-4fe6-a8bc-97f64504a163"), null },
                    { new Guid("26f18793-341a-41c1-b301-2297fbcd4dc3"), new Guid("51fdf115-e2e1-4598-bf8d-7e9ffb23307a"), new Guid("e210df54-d162-4eb5-b175-39d5887e5364"), new Guid("77abbb72-1f82-42ba-8f26-b31bc1a26767") },
                    { new Guid("8535f5bf-8ab3-48a4-96b4-61894cbae6ee"), new Guid("6ab839d1-a272-489c-9f2c-38da55d9a097"), new Guid("e210df54-d162-4eb5-b175-39d5887e5364"), new Guid("0a56d0c8-98c6-400e-abe3-fb0a9a9f286b") }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "LeaderStudentId", "StudyYearId", "TutorTeacherId" },
                values: new object[,]
                {
                    { new Guid("a8b426db-93b9-465a-8cc6-ce1b84af535b"), new Guid("9bb96f6a-452d-4af4-b820-4c4d53089018"), new Guid("e210df54-d162-4eb5-b175-39d5887e5364"), new Guid("7ad86313-7bbc-4d7f-899c-86985ce8b6ab") },
                    { new Guid("0f99cbc9-1a7b-43ab-af23-81e929ecda9d"), new Guid("727b8bd1-c77a-4540-96d5-713dfdcb4398"), new Guid("f8b802df-afbe-4fe6-a8bc-97f64504a163"), null },
                    { new Guid("45a2fd61-ac20-4364-a661-1501a67fbd4c"), new Guid("46b3b7cf-e3b0-470b-b93e-35719a67d3da"), new Guid("163a2cde-0aba-46cd-a99f-da9eebf05024"), new Guid("f24549c9-0ce2-4f17-b827-6994bf335d46") },
                    { new Guid("3337d734-c60c-4db4-b380-4558552e3d9d"), new Guid("edd6ca17-b15a-42dc-9d58-19b3f1f758fe"), new Guid("4228e05a-5d6d-40b9-9d99-3dcf71017039"), new Guid("00539901-185f-4490-9481-1d072c53c697") },
                    { new Guid("a9eda55d-8654-49ea-9043-dd884393d546"), new Guid("2d0f8025-5996-4660-b7eb-20e59b755322"), new Guid("138beda2-6bb2-417c-aad3-6c4a38053888"), null },
                    { new Guid("36907eec-b95c-4ff7-83cb-c29dd0475900"), new Guid("0896c167-f916-4364-9665-5a96c4ecbc35"), new Guid("09def265-353f-43ae-a03f-0181428f5c9e"), new Guid("a62b56c5-0991-4667-bd30-c537863e29b8") },
                    { new Guid("ff3de86a-c58f-408e-8148-75bc9286a3d9"), new Guid("3db660ce-c4f8-4fda-8c70-9d105fd3fcee"), new Guid("00db8b6a-06d6-4482-85e2-aefe69fe7b27"), null },
                    { new Guid("89d1983a-4b37-4bbe-a9c1-1122c72b4295"), new Guid("4dde0d15-b580-4c9e-8487-cc25b592b9b4"), new Guid("00db8b6a-06d6-4482-85e2-aefe69fe7b27"), null },
                    { new Guid("12ca3e24-9594-4ce7-b436-b11c95f56dd9"), new Guid("6eb6a595-aa87-42ba-81b4-30ad94f1eb9a"), new Guid("5e6d7f0e-082b-49b4-a587-e0e8a3c22908"), new Guid("a6f53d31-2194-4fad-b679-d54cba290f0a") },
                    { new Guid("069868c9-0137-4182-bccc-cfca73bbb88d"), new Guid("196422ec-3dfa-409d-902a-172d2384d9e1"), new Guid("5e6d7f0e-082b-49b4-a587-e0e8a3c22908"), new Guid("86902e3d-1f5b-4abe-9ab7-3fd73dd5ab90") },
                    { new Guid("664314c5-7eac-4f78-a52d-b3cf51711e2a"), new Guid("671ecf27-fde4-4e5f-97d2-77b23cc5f9ea"), new Guid("5e6d7f0e-082b-49b4-a587-e0e8a3c22908"), new Guid("a188125a-5041-418b-ac92-5303ce6e8a12") },
                    { new Guid("c3413bb7-f127-4455-8dc5-07c3d0d4448b"), new Guid("13ed3d8c-73cc-491f-9929-93fb87dc8f54"), new Guid("00db8b6a-06d6-4482-85e2-aefe69fe7b27"), null },
                    { new Guid("ad8e56e6-8471-4c96-a531-4c796a0e702d"), new Guid("7d948772-69b8-41f8-85e0-adf5532b5ea9"), new Guid("6a622921-055e-4ce6-ba5d-365b34d5d9df"), new Guid("88cd051e-9532-48bd-813a-11525e0bc1af") },
                    { new Guid("a1c2b1ef-cd24-4235-ad6b-19b551ac3d13"), new Guid("68f5d54b-8f01-4734-a280-7bc37d59d478"), new Guid("6a622921-055e-4ce6-ba5d-365b34d5d9df"), new Guid("69f353ab-b263-41df-ad3e-e3fb8493d9ac") },
                    { new Guid("1bd75d0a-0299-46cc-958d-2fc185657c76"), new Guid("8e565ee7-d587-4aa5-b01f-989367e86395"), new Guid("6a622921-055e-4ce6-ba5d-365b34d5d9df"), new Guid("b09b8afc-d93d-419f-bd2d-c9c2277531d9") },
                    { new Guid("a779b198-04a5-4a11-8b7d-4d4783e95c71"), new Guid("4f625f37-6d29-4969-9796-05f3d93733db"), new Guid("138beda2-6bb2-417c-aad3-6c4a38053888"), null },
                    { new Guid("70802b04-96df-4eb8-9ee1-8e23848b66a3"), new Guid("953ecf4a-f36f-4b05-9723-5129140836de"), new Guid("c1a2c35b-e87b-411d-8a02-613ef419826b"), new Guid("d8ddd747-6d87-410d-bf56-417d725c9a22") },
                    { new Guid("2628f674-b7c6-4e80-9c09-54028f2657b9"), new Guid("7a142833-c5de-45ff-ae44-fdf6da5c681b"), new Guid("c1a2c35b-e87b-411d-8a02-613ef419826b"), new Guid("6985d0e1-cd88-42c9-814a-158b42abd6d6") },
                    { new Guid("62c03594-53ef-467f-b6df-5b21d90166de"), new Guid("99b21604-e6db-45a3-8902-1dbd9bea7400"), new Guid("c1a2c35b-e87b-411d-8a02-613ef419826b"), new Guid("ba0e5c03-6f8b-4477-9e10-0a882b4c3832") },
                    { new Guid("54ab9302-9169-4841-8640-507d0795f9ed"), new Guid("c9c42e84-25a8-413a-bfd8-b0fc618e15d5"), new Guid("163a2cde-0aba-46cd-a99f-da9eebf05024"), new Guid("a5da19b2-60d3-4a47-aa17-6a9bb34f6923") },
                    { new Guid("72c05b7f-6193-47b3-9b31-4a26b56f9af0"), new Guid("7f939a55-7ec9-454a-838e-947c141f3f0b"), new Guid("138beda2-6bb2-417c-aad3-6c4a38053888"), null },
                    { new Guid("35d46cd2-70e0-4173-b1a2-424034674091"), new Guid("d1642386-4878-4964-87d5-0f5fa4d0c98e"), new Guid("f19ec3fc-1301-46b2-b8d3-59c84e514218"), new Guid("c3463b63-6f38-4d78-ba4c-b946177b6401") },
                    { new Guid("b0c7235d-ac5e-4b10-b830-503d7045b047"), new Guid("299d52f7-3535-4cef-b79c-13424f94beba"), new Guid("09def265-353f-43ae-a03f-0181428f5c9e"), new Guid("8d205a81-e2bc-4419-9b80-76829198e56a") },
                    { new Guid("fd13fa20-be8c-4bbc-8400-efef49011b36"), new Guid("58501e6f-7c91-4691-a51a-0949d17b75fd"), new Guid("09def265-353f-43ae-a03f-0181428f5c9e"), new Guid("ec29cecf-9bb4-4b00-9d9a-5d0ccad64829") },
                    { new Guid("0afd0499-eb84-48dc-8da6-39f88384d9f4"), new Guid("df3878bb-d580-4e33-bfd4-d031c9e8f752"), new Guid("423eb9cb-52be-4666-a31d-f3a136dd07e8"), new Guid("5eb8b880-4da8-4c05-9c7b-0e9c25dc8cac") },
                    { new Guid("d46cffa2-3d58-4f86-81d8-dd72462e84f4"), new Guid("7b10af2a-5c2f-4cce-a94c-f70bdef294d9"), new Guid("423eb9cb-52be-4666-a31d-f3a136dd07e8"), new Guid("18ada024-e7e8-40f8-98c2-7f773bbbb751") },
                    { new Guid("fe7c25aa-4333-418f-9d15-f75e316f6a67"), new Guid("9cc8c670-bb4d-4fdd-9f81-8cee91a8cb9f"), new Guid("ff2d24aa-a55c-48e3-ad76-4c727a541333"), new Guid("c1ca1d9c-52aa-4c4f-a70a-268d06835428") },
                    { new Guid("83dd507d-4b6e-4f2a-beb8-dfc4e83afd72"), new Guid("f4e54ad5-484d-4ce5-8a18-b26b4d0113c4"), new Guid("ff2d24aa-a55c-48e3-ad76-4c727a541333"), new Guid("38eccc3c-7b82-450f-8c4c-bdcbae4ec305") },
                    { new Guid("3ba7f2cf-03a8-4040-831f-c63c37ccaedb"), new Guid("e1c1167c-2743-4960-bac2-ffe944a0ba1b"), new Guid("3cf1e957-ab13-4c01-8767-c559290dafdd"), null },
                    { new Guid("7b997601-d826-4450-86f0-c967552a9996"), new Guid("61b7b406-e691-461e-9388-630ea6c15249"), new Guid("3cf1e957-ab13-4c01-8767-c559290dafdd"), null },
                    { new Guid("6732bca1-e313-4fab-9cb3-071f97cb3446"), new Guid("cb885879-5935-4d4a-b938-13a5b6fc15ab"), new Guid("2501a536-7053-448a-b66b-546d1fdff448"), new Guid("99e90f8f-d4ef-4493-93c7-929399c870d5") },
                    { new Guid("9b5c73cf-a6d3-4e3e-ace5-7324e7c0dc20"), new Guid("13087178-68d4-40a7-b444-83a46657a477"), new Guid("2501a536-7053-448a-b66b-546d1fdff448"), new Guid("b525ecf2-7acd-47bd-87ae-5309b598ee56") },
                    { new Guid("7a53c558-199e-4143-945c-55faf57280dd"), new Guid("412348ff-091f-4345-971b-b4b83f86b151"), new Guid("2501a536-7053-448a-b66b-546d1fdff448"), new Guid("4769333d-bd39-4438-862b-97f82854efd1") },
                    { new Guid("a8181894-5d83-4333-a385-51133d82a7b2"), new Guid("a5b17a71-d528-468f-9874-36e2d816f8d6"), new Guid("3cf1e957-ab13-4c01-8767-c559290dafdd"), null },
                    { new Guid("50beb0ab-0353-4f95-9e7d-1dd5c19f604e"), new Guid("a843baa3-ada5-4cdb-b8bf-c60200748133"), new Guid("f19ec3fc-1301-46b2-b8d3-59c84e514218"), new Guid("a60a1d7e-06fa-458f-8a6b-5665cb75fb3c") },
                    { new Guid("6a924de5-af45-426c-88f1-7662cb537318"), new Guid("330b8fd4-506d-4eb5-b9b4-9f8abde2f0bf"), new Guid("29f0b5b1-adb8-49ad-a874-00f120477aed"), new Guid("63e1742b-49cd-41ed-b0dc-d6616bf232ba") },
                    { new Guid("a2375428-70b5-4dcb-9e98-efa5b49ed258"), new Guid("0979c688-52ae-4b59-9d3e-e9bde3e9b348"), new Guid("29f0b5b1-adb8-49ad-a874-00f120477aed"), new Guid("ebeffb2e-3a83-47bf-b89a-f738c8edc152") },
                    { new Guid("4ea8b217-d008-4236-966f-a3ee467691dc"), new Guid("dbf91b18-0a45-4e59-a116-93a6792cd012"), new Guid("1d4c88b5-c469-4ef8-84fc-43eabbe25b1f"), null },
                    { new Guid("d80dbc67-9640-4654-a154-8291acf9c042"), new Guid("9c540e22-43ad-4ce9-9ecb-b2dbc96dd528"), new Guid("1a9ba576-f23b-432f-8b2b-eced7f477651"), new Guid("a78db448-cd3f-412c-9d1e-0fd2a204ba46") },
                    { new Guid("b46bce9b-d46b-40ce-9048-042c8349e723"), new Guid("7b6b190b-375a-42d0-b035-9ae590e89083"), new Guid("1a9ba576-f23b-432f-8b2b-eced7f477651"), new Guid("13204af6-237b-4597-bb1a-c82c23c09636") },
                    { new Guid("65f797cf-3428-4826-8468-536c801ad57b"), new Guid("416ec3a4-399a-47ca-b4b4-d91f2cb91d2b"), new Guid("1a9ba576-f23b-432f-8b2b-eced7f477651"), new Guid("86828be7-9d59-413e-8b29-4318311399e4") },
                    { new Guid("804f34de-ba1c-49f3-9077-27e3f4810fc3"), new Guid("342aebf0-6d60-42e8-8c35-1f241c86ff5a"), new Guid("1d4c88b5-c469-4ef8-84fc-43eabbe25b1f"), null }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "LeaderStudentId", "StudyYearId", "TutorTeacherId" },
                values: new object[,]
                {
                    { new Guid("fc8f87d1-4b73-4ece-899e-94dee6ec4a06"), new Guid("5f7f1bc6-bbfd-4a14-8ac2-8ae7d3757a3b"), new Guid("1d4c88b5-c469-4ef8-84fc-43eabbe25b1f"), null },
                    { new Guid("e62ac446-7db4-4c2d-ac0e-a8484318e883"), new Guid("7ce79836-fb94-479a-926b-8435573f2418"), new Guid("423eb9cb-52be-4666-a31d-f3a136dd07e8"), new Guid("063abe97-7452-429b-8088-ae02501cf52a") },
                    { new Guid("c69ece68-2e7a-4458-a87e-3d251c5a9020"), new Guid("ffb1dd7b-95c3-434d-b85a-1a3ea6abe788"), new Guid("29f0b5b1-adb8-49ad-a874-00f120477aed"), new Guid("5a91c10d-b6e0-4886-9ff9-10107fcb6761") },
                    { new Guid("3eec704d-8929-4ea3-a4f6-49f2ac2c455f"), new Guid("bf68980c-e4cd-44a6-a5d2-474793c2c1d2"), new Guid("f19ec3fc-1301-46b2-b8d3-59c84e514218"), new Guid("ce09c1a2-6510-4c84-a533-688fbff0d1b4") },
                    { new Guid("7632dd87-0e4c-4b77-af0d-530348b4b743"), new Guid("fdf7cc8f-841d-43d9-be0d-002200118890"), new Guid("af8f5041-d121-4e38-b3be-0d5eb38eb33b"), null },
                    { new Guid("12e10ea6-e7ef-408f-90a6-bf30946b19a5"), new Guid("45502922-a8d2-4ed0-acd3-e91c795cd85a"), new Guid("92b4a8a6-88b6-4f7e-8570-84ace9a69dee"), new Guid("7edca406-8727-4468-98f7-a23690714cf9") },
                    { new Guid("e80d0250-becd-40ad-b385-5f5e8fc6a64d"), new Guid("87c7ee17-2764-4dc8-86dc-bc5d459dcff8"), new Guid("9a81dd99-365c-4697-80f6-125b0d2a211e"), null },
                    { new Guid("e9d2e865-c44e-424a-8444-8cc309733527"), new Guid("16490c8e-804e-4bb7-b27b-9eacccb56751"), new Guid("be9fd196-8d97-4ffa-9fb7-18abe9ebeb0d"), new Guid("501d7bb4-8a43-4591-ba6f-19ea8a68a32d") },
                    { new Guid("f9e261b5-a13f-4d01-9c66-d7e82ff462e2"), new Guid("f1eca1a9-96f4-42bc-b47c-daead5a449fd"), new Guid("92b4a8a6-88b6-4f7e-8570-84ace9a69dee"), new Guid("64f7e86e-e102-4040-acc2-89d5c9c06788") },
                    { new Guid("36d304c9-c5d3-4fe7-b57e-cfe7a6c9a10e"), new Guid("29772d53-f49f-4a11-b808-d51237e1e700"), new Guid("c86f3bf7-b95e-44d6-9a2f-e7454ee4c0c2"), null },
                    { new Guid("6aaf1a9b-37f5-42e9-acd9-8faa5ba78618"), new Guid("1f42d139-f2c7-4498-8f98-50ff212865b4"), new Guid("be9fd196-8d97-4ffa-9fb7-18abe9ebeb0d"), new Guid("8c7fd48c-4b7c-4b23-a1eb-7b91ac817ded") },
                    { new Guid("d2633a36-09c1-48bc-af67-5bd305e6a54f"), new Guid("72343ca2-81ec-4197-845d-9eb2abec963a"), new Guid("0f3c6123-6743-4043-9041-b8e2dc85adb6"), new Guid("7c3a81a4-266d-4f0c-b73a-38e6d61e9622") },
                    { new Guid("186c5903-4efc-4b31-bbc2-e919b9bdc54c"), new Guid("3cb8198f-c176-4315-a194-63c46aec4833"), new Guid("9a81dd99-365c-4697-80f6-125b0d2a211e"), null },
                    { new Guid("0c206d70-9233-4fff-9643-2fdaf6a4e9d7"), new Guid("73daa1b1-1887-4bd9-a347-0933e0acc910"), new Guid("0f3c6123-6743-4043-9041-b8e2dc85adb6"), new Guid("057dfd7c-e065-4359-ad7d-4f9203a48204") },
                    { new Guid("f6c174a4-4209-4940-ad16-1b669ec2284f"), new Guid("93d1065f-7022-4671-b78a-13752eba08cd"), new Guid("c3856fc8-5768-4546-a85b-07d9d20aee14"), new Guid("3c7e6dc1-9f2d-42d3-9e4d-e2431a493beb") },
                    { new Guid("33fa5ad4-ca1f-4bbd-90d4-073836ed62f0"), new Guid("970239f2-226b-43fa-8628-cabdf415b58a"), new Guid("c86f3bf7-b95e-44d6-9a2f-e7454ee4c0c2"), null },
                    { new Guid("71731171-39df-4f99-b43c-8259ad66d333"), new Guid("5f802300-59fe-4265-9e8e-97aa329de809"), new Guid("c86f3bf7-b95e-44d6-9a2f-e7454ee4c0c2"), null },
                    { new Guid("263dfaf9-823b-4360-a8bd-7696728de44e"), new Guid("7777f4f1-9471-4e7b-86a7-02793fdd5f12"), new Guid("4d5ad130-e756-4835-8f59-a023f609267b"), new Guid("6cc73e31-6f80-4272-82bf-eb0a1325aeb4") },
                    { new Guid("18f725d5-fca7-4b62-b3d1-a5d5b50fff66"), new Guid("1c6e3c16-ca7f-4350-9a40-30483ad2378a"), new Guid("4d5ad130-e756-4835-8f59-a023f609267b"), new Guid("f695bb45-0fcc-4233-b615-69daac6c3ac7") },
                    { new Guid("c2ab2780-dc6a-4a34-be5a-2aaf91bc9efd"), new Guid("99958972-fb6c-41f1-bdcc-3d2239061506"), new Guid("4d5ad130-e756-4835-8f59-a023f609267b"), new Guid("0fe90da4-1897-46a6-a2e8-5326e2ad84d8") },
                    { new Guid("ad9afa02-5847-4752-b687-1b6ff0966b98"), new Guid("68501085-da2e-4cae-a58e-425c25f1ebc2"), new Guid("0f3c6123-6743-4043-9041-b8e2dc85adb6"), new Guid("6b48d1dc-3249-4c0a-b1c0-1eced2993fae") },
                    { new Guid("e3375ee7-6cc6-4b66-955b-b4688d965fdb"), new Guid("069dbe85-ca34-4a06-8e55-3f7babeab277"), new Guid("52612024-de25-4143-8d1b-bf9cd78ee344"), new Guid("adbec3db-e798-4b59-a8a1-3ef0c251f642") },
                    { new Guid("5b8fcc6f-4f37-4415-9402-fef2ce053475"), new Guid("e6ab51f7-3efb-433f-94c4-686be78ec13c"), new Guid("be9fd196-8d97-4ffa-9fb7-18abe9ebeb0d"), new Guid("2a164668-67e3-4a12-b8a1-af89e56f1a14") },
                    { new Guid("299963dc-f175-496b-ab6a-688774dce4f4"), new Guid("2e5be4c6-013a-4d61-bb77-54bd64d52d59"), new Guid("52612024-de25-4143-8d1b-bf9cd78ee344"), new Guid("2b8b30bd-1ff4-4f45-81e7-92d191fae001") },
                    { new Guid("9e81d458-b5bd-4aa4-aabd-7127f2dc2eb6"), new Guid("2667a758-41a7-4f2f-bd61-6b2121f9fd4f"), new Guid("7301c3ee-f7b9-41c0-b20c-597da91df2e3"), null },
                    { new Guid("672c1ad4-1d47-4595-a9e2-608b07043052"), new Guid("4de0f0f5-0763-4385-9c12-f6a190d13554"), new Guid("db2b8d50-3d9c-4d31-a7bf-cfb8f5543dec"), new Guid("5e08f64f-4cf8-4a4f-8b01-640e5291e9ba") },
                    { new Guid("dcbac3e0-12ec-4c29-9850-f9d1c58c4c00"), new Guid("7b2bed68-61b5-4257-a9bc-a224a85b0906"), new Guid("163a2cde-0aba-46cd-a99f-da9eebf05024"), new Guid("68b80fce-73ac-4d0a-8df7-929dde1bad2b") },
                    { new Guid("9be8ba28-35fb-4476-83c7-1fca0147ef78"), new Guid("5a2c668f-251c-46e6-8d42-be806abfb858"), new Guid("db2b8d50-3d9c-4d31-a7bf-cfb8f5543dec"), new Guid("0fd529d1-e3e2-47c5-b856-7aba08cbbbf0") },
                    { new Guid("e90a85f5-89b8-4c83-bf15-ba04cd1c13bb"), new Guid("4b5534b7-7816-4258-a054-ac2e4b14cd99"), new Guid("52612024-de25-4143-8d1b-bf9cd78ee344"), new Guid("a6a34e96-0ca8-49d8-a157-d49457805cae") },
                    { new Guid("0791a613-7bff-4126-9efb-0a2b50fdaedb"), new Guid("ffce7b9f-a013-4c2d-8e41-395c4c5845f6"), new Guid("9a81dd99-365c-4697-80f6-125b0d2a211e"), null },
                    { new Guid("52ecc930-85d6-463a-a34a-73da73ef4ba8"), new Guid("739cfc78-e082-4f19-9777-5cf8bded81a8"), new Guid("db2b8d50-3d9c-4d31-a7bf-cfb8f5543dec"), new Guid("c0b88834-6a9a-4c54-9efd-9eba8cba2b31") },
                    { new Guid("9d90c050-8de4-4ddd-9fc2-4aad78a61815"), new Guid("8cd82215-d2fa-4bf4-85ec-f9f515f5d2c1"), new Guid("c3856fc8-5768-4546-a85b-07d9d20aee14"), new Guid("a338538a-abb1-4870-b2be-f707276ce47b") },
                    { new Guid("fd69bb20-cb9e-4106-b0e6-ee34db0791ff"), new Guid("05ee30ee-8b11-4d3e-af76-a485857c3b9a"), new Guid("92b4a8a6-88b6-4f7e-8570-84ace9a69dee"), new Guid("3f76ac73-0ba7-4d6a-ab40-bc387998856f") },
                    { new Guid("dbb15cef-ae49-4fd3-a7c7-017d65c39c18"), new Guid("594bf687-59fe-4832-b96b-01a6372eaa97"), new Guid("7301c3ee-f7b9-41c0-b20c-597da91df2e3"), null },
                    { new Guid("4756c00d-959e-4f41-afc8-f06351adc6b2"), new Guid("073f6e0c-eb54-42f3-bb6f-008afd69404c"), new Guid("c3856fc8-5768-4546-a85b-07d9d20aee14"), new Guid("d27b117a-d80a-4155-8dfa-522f22cd4429") },
                    { new Guid("ae8d4134-b21e-4249-aa4c-2a404f841697"), new Guid("b999311e-2b35-4b8c-8fae-2398c06f7dd3"), new Guid("7301c3ee-f7b9-41c0-b20c-597da91df2e3"), null }
                });

            migrationBuilder.InsertData(
                table: "StudySemesters",
                columns: new[] { "Id", "Semester", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("ed288f86-5f81-487f-a090-280ca0dfac4e"), (short)2, new Guid("802d0b3e-e225-4f6d-a7c5-ef894d9249ec") },
                    { new Guid("fb665d42-4b97-40cc-b2cd-53ddf9f111a8"), (short)1, new Guid("af8f5041-d121-4e38-b3be-0d5eb38eb33b") },
                    { new Guid("c91be2e9-073d-4b39-b2f8-cd198dcf81a8"), (short)1, new Guid("7f47db36-5375-4945-a34f-2fae66da2176") },
                    { new Guid("be0461b9-8bf4-429e-a034-39a1ae1f0265"), (short)1, new Guid("1d4c88b5-c469-4ef8-84fc-43eabbe25b1f") },
                    { new Guid("0cba8627-2e00-41e4-8e20-0a77842874ee"), (short)2, new Guid("7f47db36-5375-4945-a34f-2fae66da2176") },
                    { new Guid("4873084f-e5f3-4ebb-93af-1777e95bfb6e"), (short)2, new Guid("1b51e226-4a5c-4337-b683-4c5dc89335be") }
                });

            migrationBuilder.InsertData(
                table: "StudySemesters",
                columns: new[] { "Id", "Semester", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("27e43d58-7570-46bc-ba29-eec9624265ea"), (short)2, new Guid("1d4c88b5-c469-4ef8-84fc-43eabbe25b1f") },
                    { new Guid("a90d92b7-bb0c-49b0-9a76-a384554d2856"), (short)2, new Guid("af8f5041-d121-4e38-b3be-0d5eb38eb33b") },
                    { new Guid("be6619cc-a2d5-4765-814d-9b2feee87b89"), (short)1, new Guid("802d0b3e-e225-4f6d-a7c5-ef894d9249ec") },
                    { new Guid("5a26c4e3-d8fa-4b4c-a539-7d274408cfe3"), (short)1, new Guid("7301c3ee-f7b9-41c0-b20c-597da91df2e3") },
                    { new Guid("b1e1b13b-1c0d-4530-a1f5-763d76c7a8ca"), (short)1, new Guid("00db8b6a-06d6-4482-85e2-aefe69fe7b27") },
                    { new Guid("5a2662cc-c496-46eb-9a3f-c599a6888d43"), (short)2, new Guid("9a81dd99-365c-4697-80f6-125b0d2a211e") },
                    { new Guid("d7349cf1-5325-42b1-9313-0f2eff59eaf3"), (short)2, new Guid("7301c3ee-f7b9-41c0-b20c-597da91df2e3") },
                    { new Guid("448af37f-cac6-4d46-ad76-2b96c15aa522"), (short)2, new Guid("cde5a564-98f9-4ce6-a236-e3d0fa45f86c") },
                    { new Guid("ef4de7e3-ff4f-472f-90db-1dd4522b68c0"), (short)1, new Guid("cde5a564-98f9-4ce6-a236-e3d0fa45f86c") },
                    { new Guid("6260768b-db7c-43c8-b6ad-69de7795c445"), (short)1, new Guid("ed636f8a-82b9-431b-a59a-878556432b38") },
                    { new Guid("d299e537-237f-4d2e-9146-b884455575f3"), (short)2, new Guid("ed636f8a-82b9-431b-a59a-878556432b38") },
                    { new Guid("95eed3b1-2718-4d54-87ca-969cb51e880c"), (short)1, new Guid("138beda2-6bb2-417c-aad3-6c4a38053888") },
                    { new Guid("948db04e-01cc-4694-95d2-63fa40172191"), (short)2, new Guid("c86f3bf7-b95e-44d6-9a2f-e7454ee4c0c2") },
                    { new Guid("c57f448e-4350-49ee-8820-9a69c773dfb1"), (short)1, new Guid("9a81dd99-365c-4697-80f6-125b0d2a211e") },
                    { new Guid("cf575b9b-0435-4db6-8a44-045bc22e6c3f"), (short)2, new Guid("f8b802df-afbe-4fe6-a8bc-97f64504a163") },
                    { new Guid("be84a8ea-74da-4374-bfc1-d8f30d06b7e6"), (short)2, new Guid("138beda2-6bb2-417c-aad3-6c4a38053888") },
                    { new Guid("af06202b-f38f-450b-8c11-8fc66730120d"), (short)1, new Guid("c86f3bf7-b95e-44d6-9a2f-e7454ee4c0c2") },
                    { new Guid("52bc0a8f-57c0-4c34-9c11-4dd6ba359789"), (short)1, new Guid("ae156b44-006d-41aa-bbf7-d0d776a6c4b4") },
                    { new Guid("e2ee5fd1-dd4f-4079-a88d-fd45ac37094e"), (short)2, new Guid("2529e03f-5098-43fc-ba4d-d3948a0a661e") },
                    { new Guid("9b2071c3-7203-448b-ad6e-ae00e1161995"), (short)2, new Guid("ae156b44-006d-41aa-bbf7-d0d776a6c4b4") },
                    { new Guid("e62a2052-e393-49dd-8dda-5f1977a279c0"), (short)2, new Guid("00db8b6a-06d6-4482-85e2-aefe69fe7b27") },
                    { new Guid("90740841-d602-4469-a39e-e2971ff1f366"), (short)1, new Guid("2529e03f-5098-43fc-ba4d-d3948a0a661e") },
                    { new Guid("6543866f-3fb6-4d73-b99d-a914c389d363"), (short)1, new Guid("f8b802df-afbe-4fe6-a8bc-97f64504a163") },
                    { new Guid("313dd4a1-ce31-495e-be25-5ef618786573"), (short)1, new Guid("1b51e226-4a5c-4337-b683-4c5dc89335be") },
                    { new Guid("cedd27c4-267a-40f2-a0f0-87ca80472d9d"), (short)2, new Guid("b2b6c0b3-e2c3-4965-9eb4-d1b7983f393e") },
                    { new Guid("35c1baf9-0879-40b6-b538-5b59f815e8c2"), (short)1, new Guid("593a22af-f535-46d5-9d0c-45b6d66251c7") },
                    { new Guid("e2237afc-8e86-4571-afa7-b3741418bc38"), (short)1, new Guid("c3856fc8-5768-4546-a85b-07d9d20aee14") },
                    { new Guid("ce35b0a1-60a7-4966-892e-ce9b859e0585"), (short)2, new Guid("c3856fc8-5768-4546-a85b-07d9d20aee14") },
                    { new Guid("d9a848e5-db20-40f7-83aa-f546c4796307"), (short)1, new Guid("db2b8d50-3d9c-4d31-a7bf-cfb8f5543dec") },
                    { new Guid("907d852f-b1fe-4950-9afc-a3e746c9d6d2"), (short)2, new Guid("db2b8d50-3d9c-4d31-a7bf-cfb8f5543dec") },
                    { new Guid("b582d2dc-d7ef-412d-89d6-cec2f0a77292"), (short)1, new Guid("92b4a8a6-88b6-4f7e-8570-84ace9a69dee") },
                    { new Guid("5c881e8f-502b-4278-83c7-66bd963880bb"), (short)2, new Guid("92b4a8a6-88b6-4f7e-8570-84ace9a69dee") },
                    { new Guid("9266f3fa-79cf-434e-8365-4735048d2831"), (short)1, new Guid("0f3c6123-6743-4043-9041-b8e2dc85adb6") },
                    { new Guid("5e01e539-02ee-4509-99c0-0231e369dbc4"), (short)2, new Guid("0f3c6123-6743-4043-9041-b8e2dc85adb6") },
                    { new Guid("a0f85dc6-c855-4030-b1ba-6592434a7f57"), (short)1, new Guid("4d5ad130-e756-4835-8f59-a023f609267b") },
                    { new Guid("a931c6f4-9d60-4304-81ad-a1dfb9be030a"), (short)2, new Guid("4d5ad130-e756-4835-8f59-a023f609267b") },
                    { new Guid("d958eb54-3146-41c7-8977-2aa0cb663551"), (short)1, new Guid("be9fd196-8d97-4ffa-9fb7-18abe9ebeb0d") },
                    { new Guid("e4124ca5-3a97-4dfd-a778-d6d7f390d0e2"), (short)2, new Guid("be9fd196-8d97-4ffa-9fb7-18abe9ebeb0d") },
                    { new Guid("87fe76e1-3d2d-423e-abb6-68bf23ff2ae4"), (short)1, new Guid("52612024-de25-4143-8d1b-bf9cd78ee344") },
                    { new Guid("6fcc89ca-3601-4bd4-9ea8-137469053e94"), (short)2, new Guid("52612024-de25-4143-8d1b-bf9cd78ee344") },
                    { new Guid("1a79ae16-e107-4464-a22f-5bd96be4b2e3"), (short)1, new Guid("163a2cde-0aba-46cd-a99f-da9eebf05024") },
                    { new Guid("6dd9c059-e6f3-4116-b9ab-47f8c0f60c1d"), (short)2, new Guid("f19ec3fc-1301-46b2-b8d3-59c84e514218") }
                });

            migrationBuilder.InsertData(
                table: "StudySemesters",
                columns: new[] { "Id", "Semester", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("c8ea306c-571d-484a-b0ec-787254efcb71"), (short)1, new Guid("f19ec3fc-1301-46b2-b8d3-59c84e514218") },
                    { new Guid("077719f8-99b6-44d7-8e24-56e22f03f4f6"), (short)2, new Guid("c1a2c35b-e87b-411d-8a02-613ef419826b") },
                    { new Guid("ff4bb88a-b6d6-4256-9ea0-fe93fcd9697c"), (short)1, new Guid("c1a2c35b-e87b-411d-8a02-613ef419826b") },
                    { new Guid("ea6d9d48-6e3d-436f-9ce0-d725e934f311"), (short)1, new Guid("ff2d24aa-a55c-48e3-ad76-4c727a541333") },
                    { new Guid("0c5e5c66-4cf4-4666-876e-3a1de1a85d92"), (short)2, new Guid("ff2d24aa-a55c-48e3-ad76-4c727a541333") },
                    { new Guid("b7509275-37e5-4ce6-9402-e01efafc00c3"), (short)1, new Guid("2501a536-7053-448a-b66b-546d1fdff448") },
                    { new Guid("af58f530-80db-4ef5-8961-819c6b18453e"), (short)2, new Guid("2501a536-7053-448a-b66b-546d1fdff448") },
                    { new Guid("6aa84bea-944d-4081-b6c6-d4c938ad12bd"), (short)1, new Guid("29f0b5b1-adb8-49ad-a874-00f120477aed") },
                    { new Guid("7105bfa0-0571-4c9b-af19-748123a22da2"), (short)2, new Guid("29f0b5b1-adb8-49ad-a874-00f120477aed") },
                    { new Guid("4ab0f3a8-256f-407b-b9dd-ae5fc5d3d6df"), (short)1, new Guid("1a9ba576-f23b-432f-8b2b-eced7f477651") },
                    { new Guid("81575b03-8d04-4bf2-a869-3404de699b61"), (short)2, new Guid("163a2cde-0aba-46cd-a99f-da9eebf05024") },
                    { new Guid("a43aeedd-5642-410a-b006-f5bd23bb6afc"), (short)2, new Guid("1a9ba576-f23b-432f-8b2b-eced7f477651") },
                    { new Guid("1f729851-ec34-41f4-a629-c8c322acd5ea"), (short)2, new Guid("423eb9cb-52be-4666-a31d-f3a136dd07e8") },
                    { new Guid("330d8cef-7199-4287-871b-64aa88ce2123"), (short)1, new Guid("09def265-353f-43ae-a03f-0181428f5c9e") },
                    { new Guid("2c6cd864-2fe9-42c7-8bfe-8f7489e5810f"), (short)2, new Guid("09def265-353f-43ae-a03f-0181428f5c9e") },
                    { new Guid("d8cda68e-9336-4490-8716-b0196825807a"), (short)1, new Guid("5e6d7f0e-082b-49b4-a587-e0e8a3c22908") },
                    { new Guid("46f266a3-7b60-4d2f-ba82-d0a00be6b470"), (short)2, new Guid("5e6d7f0e-082b-49b4-a587-e0e8a3c22908") },
                    { new Guid("04f1be8e-ccc0-41e3-921a-71f2e2915a29"), (short)1, new Guid("6a622921-055e-4ce6-ba5d-365b34d5d9df") },
                    { new Guid("bdd6e79a-ad46-491c-8b58-e72975ac7f04"), (short)2, new Guid("6a622921-055e-4ce6-ba5d-365b34d5d9df") },
                    { new Guid("475c557a-fd49-4063-9110-e75d3c0ad792"), (short)1, new Guid("423eb9cb-52be-4666-a31d-f3a136dd07e8") },
                    { new Guid("bd932240-c2f0-4585-ae4b-578c673c95ee"), (short)2, new Guid("593a22af-f535-46d5-9d0c-45b6d66251c7") },
                    { new Guid("24594659-f059-49b0-8cf7-ba8b09eb0caf"), (short)1, new Guid("ab7f4f05-ab53-46b6-a1f3-eb71f1c8a80c") },
                    { new Guid("16bbd598-8c3a-41fc-b681-cd2926aa6ebe"), (short)1, new Guid("4228e05a-5d6d-40b9-9d99-3dcf71017039") },
                    { new Guid("1df224db-50d8-48cc-aa8c-c27dd0831dd4"), (short)2, new Guid("f43c473b-a54c-492f-838b-9a8196a5bddf") },
                    { new Guid("5425e4e3-1934-4b3b-b611-06d871ec6076"), (short)1, new Guid("f19b6bb5-fbcb-4ec2-bf35-eafa03f1a1d0") },
                    { new Guid("d2f6096b-44fe-4ab3-a7f5-448275ba3bbd"), (short)2, new Guid("f19b6bb5-fbcb-4ec2-bf35-eafa03f1a1d0") },
                    { new Guid("ad4fbc81-e4bc-4c85-8fdf-7a8c6028c1e5"), (short)1, new Guid("63202067-dc60-4ff4-a0f0-444b930472a1") },
                    { new Guid("edcdf2d2-e581-4950-b51c-d56b0fd95a74"), (short)2, new Guid("63202067-dc60-4ff4-a0f0-444b930472a1") },
                    { new Guid("369aba17-6ac2-4c10-9f1a-110ca5d4fa3c"), (short)1, new Guid("e210df54-d162-4eb5-b175-39d5887e5364") },
                    { new Guid("edfe5fec-2e28-470d-a752-528e295a7a1d"), (short)2, new Guid("e210df54-d162-4eb5-b175-39d5887e5364") },
                    { new Guid("95bef003-e624-4a2c-b353-abd991f97c9d"), (short)1, new Guid("1d820d11-3d53-47d8-a9b1-842a7cb331af") },
                    { new Guid("ec58bf3c-46fa-42a7-a277-e789f35aa6bd"), (short)2, new Guid("1d820d11-3d53-47d8-a9b1-842a7cb331af") },
                    { new Guid("260a5d56-6f38-43ee-b545-33dd4f88cccc"), (short)1, new Guid("93152e98-e110-4205-8b7f-cf7bc3ca78eb") },
                    { new Guid("31d1d97d-2694-4cdf-a1d5-0c3e386f072a"), (short)2, new Guid("93152e98-e110-4205-8b7f-cf7bc3ca78eb") },
                    { new Guid("8da7984a-6afa-45f0-87ac-36aa60384975"), (short)1, new Guid("dd16e975-2f23-44bb-a48f-1cd78c65049e") },
                    { new Guid("4833707f-1cef-4669-97ab-ddded2a3422a"), (short)2, new Guid("dd16e975-2f23-44bb-a48f-1cd78c65049e") },
                    { new Guid("6b107f46-46e2-4aca-ae01-a384b0d64a00"), (short)1, new Guid("4ec7995f-c463-4355-a14d-a1f23c753d80") },
                    { new Guid("f3acc840-3869-4c6c-9089-368d02fa3f8e"), (short)2, new Guid("4ec7995f-c463-4355-a14d-a1f23c753d80") },
                    { new Guid("f53b3b9f-6302-4971-89d4-9ece92d50fb7"), (short)1, new Guid("f43c473b-a54c-492f-838b-9a8196a5bddf") },
                    { new Guid("9b7a403a-58e4-42e3-9cb9-b753a068065b"), (short)2, new Guid("3ef93aae-dc2a-4121-b559-01526a9a6a25") },
                    { new Guid("cc1b153f-e74a-4f09-8511-0f5036167df4"), (short)1, new Guid("3ef93aae-dc2a-4121-b559-01526a9a6a25") },
                    { new Guid("84f9da08-1b22-4d9f-aa30-b448d1aa3734"), (short)2, new Guid("66f6cf78-466b-4db6-a6c2-6ba3b325bf8b") }
                });

            migrationBuilder.InsertData(
                table: "StudySemesters",
                columns: new[] { "Id", "Semester", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("db5f1cfb-af79-4c71-a881-0276a753b746"), (short)2, new Guid("4228e05a-5d6d-40b9-9d99-3dcf71017039") },
                    { new Guid("4dfc9fcf-13e9-4ec2-852b-2b76f9b37bf6"), (short)1, new Guid("d6808fc1-bacc-4202-8bc2-ce825defe818") },
                    { new Guid("b51bbea9-0afd-4738-a071-5a774b889837"), (short)2, new Guid("d6808fc1-bacc-4202-8bc2-ce825defe818") },
                    { new Guid("081cc945-5a01-4975-b6e6-387f6ac3ece8"), (short)1, new Guid("112b6fe1-273a-470f-9c81-936b863d27e0") },
                    { new Guid("b72b47d3-75c7-4543-9afc-5fd2000145d5"), (short)2, new Guid("112b6fe1-273a-470f-9c81-936b863d27e0") },
                    { new Guid("feecd83c-4205-49ce-ba72-610ff9124065"), (short)1, new Guid("6115911a-0393-4803-ba8e-4486019dc05e") },
                    { new Guid("33ab0796-72e9-4709-8e75-4560d3609e38"), (short)2, new Guid("6115911a-0393-4803-ba8e-4486019dc05e") },
                    { new Guid("bc11631b-0491-416b-b1ff-18ab635820e2"), (short)2, new Guid("ab7f4f05-ab53-46b6-a1f3-eb71f1c8a80c") },
                    { new Guid("fd7bf6f3-64b3-4f02-b1ad-6fd62014be98"), (short)1, new Guid("27e4abbd-7aab-4ecd-ac3e-65774fb30079") },
                    { new Guid("5a2feda2-ecce-428d-8a90-c8eebab44fc9"), (short)1, new Guid("0f5d50c8-f210-4adc-a9c2-6c669ee84836") },
                    { new Guid("1589bfb4-5aae-44bb-84c8-fd7a265c73be"), (short)2, new Guid("0f5d50c8-f210-4adc-a9c2-6c669ee84836") },
                    { new Guid("c904906c-036e-4feb-8775-92c3d78524df"), (short)1, new Guid("ef3e96d0-0704-4172-84da-2bad59787e24") },
                    { new Guid("de9b8934-ea96-4bff-bf45-e910ed1e9603"), (short)2, new Guid("ef3e96d0-0704-4172-84da-2bad59787e24") },
                    { new Guid("51d323aa-078d-4376-b325-0a32fda1b988"), (short)1, new Guid("b2b6c0b3-e2c3-4965-9eb4-d1b7983f393e") },
                    { new Guid("c72b46dc-7ba5-4934-bd46-d8633f2293e5"), (short)1, new Guid("3cf1e957-ab13-4c01-8767-c559290dafdd") },
                    { new Guid("d766e40b-ed6b-4423-bc83-5b5d3403bb22"), (short)1, new Guid("66f6cf78-466b-4db6-a6c2-6ba3b325bf8b") },
                    { new Guid("1f6234b3-22c7-474d-a894-77013b7832eb"), (short)2, new Guid("27e4abbd-7aab-4ecd-ac3e-65774fb30079") },
                    { new Guid("5c174f74-51b8-420b-9b46-cfee6b0c20bd"), (short)2, new Guid("3cf1e957-ab13-4c01-8767-c559290dafdd") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("4833b029-f158-4f77-98f1-d271156fb7d6"), (short)4, "Course0", new Guid("ea6d9d48-6e3d-436f-9ce0-d725e934f311"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("4d62ee5d-f73e-4e12-a06f-88bef79a780c"), (short)0, "Course56", new Guid("cc1b153f-e74a-4f09-8511-0f5036167df4"), new Guid("0a2bec6b-65e9-4c34-8fa8-eb3a98e94d6c") },
                    { new Guid("18eb3ff3-ba06-4d15-9c1e-022aa02f359b"), (short)1, "Course112", new Guid("cc1b153f-e74a-4f09-8511-0f5036167df4"), new Guid("063abe97-7452-429b-8088-ae02501cf52a") },
                    { new Guid("4b0c804c-bd96-48ca-8175-d66f895226e9"), (short)1, "Course168", new Guid("cc1b153f-e74a-4f09-8511-0f5036167df4"), new Guid("4bc31229-4343-493d-94ba-f19b12c1369e") },
                    { new Guid("af9ba642-0a80-47af-8639-74a3b63cd5b7"), (short)4, "Course224", new Guid("cc1b153f-e74a-4f09-8511-0f5036167df4"), new Guid("d8ddd747-6d87-410d-bf56-417d725c9a22") },
                    { new Guid("4942ec3a-a0cd-410e-81ce-a8b01a2047e6"), (short)0, "Course280", new Guid("cc1b153f-e74a-4f09-8511-0f5036167df4"), new Guid("0f3a6be6-d338-4180-9f66-12eea50cc59b") },
                    { new Guid("95fde7fa-93cc-4bd0-a855-7097dabb12cb"), (short)3, "Course465", new Guid("4873084f-e5f3-4ebb-93af-1777e95bfb6e"), new Guid("71fbe949-8b66-4ee4-b52b-3c5370663ef6") },
                    { new Guid("0b6725a8-3f54-42c1-87f6-365e20509e6b"), (short)1, "Course372", new Guid("4873084f-e5f3-4ebb-93af-1777e95bfb6e"), new Guid("ed1486d0-4af1-449f-882e-93b5bc021952") },
                    { new Guid("6928f976-3ccc-4683-ac87-2f477c52e494"), (short)1, "Course0", new Guid("cc1b153f-e74a-4f09-8511-0f5036167df4"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("cfcb6ed9-990a-4c13-a19f-3abae47bfcf1"), (short)5, "Course0", new Guid("9b7a403a-58e4-42e3-9cb9-b753a068065b"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("c6285a91-6e94-4fd1-8540-d79dbafe5204"), (short)0, "Course114", new Guid("9b7a403a-58e4-42e3-9cb9-b753a068065b"), new Guid("5eb8b880-4da8-4c05-9c7b-0e9c25dc8cac") },
                    { new Guid("d1cc45d1-16f9-4740-bece-644842685b74"), (short)0, "Course171", new Guid("9b7a403a-58e4-42e3-9cb9-b753a068065b"), new Guid("70ebd0f8-7890-43df-9cce-ceeabc3afca3") },
                    { new Guid("4d0d3e2e-ad5e-4dd9-9ede-1544b582c2e8"), (short)0, "Course228", new Guid("9b7a403a-58e4-42e3-9cb9-b753a068065b"), new Guid("a60a1d7e-06fa-458f-8a6b-5665cb75fb3c") },
                    { new Guid("67b650fc-160e-49be-8b19-7a051d628fb3"), (short)3, "Course285", new Guid("9b7a403a-58e4-42e3-9cb9-b753a068065b"), new Guid("1bb30181-e8ba-4ab9-85d3-d81474aca8d1") },
                    { new Guid("bfd65ff8-5e9b-49f6-89aa-00ed9ae9ec1b"), (short)3, "Course279", new Guid("4873084f-e5f3-4ebb-93af-1777e95bfb6e"), new Guid("1766f994-8239-4121-b06d-ad7564b3bfc6") },
                    { new Guid("9bcbaa0b-6207-454a-9f95-32d005eefb89"), (short)3, "Course186", new Guid("4873084f-e5f3-4ebb-93af-1777e95bfb6e"), new Guid("4adb9302-baad-4231-9a53-e750e5383bc8") },
                    { new Guid("99229fce-b926-4e2d-a8e8-9dffc2ce3abc"), (short)2, "Course0", new Guid("f53b3b9f-6302-4971-89d4-9ece92d50fb7"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("5c2518a0-6a90-4a9f-983e-194ea80bdf0a"), (short)3, "Course57", new Guid("9b7a403a-58e4-42e3-9cb9-b753a068065b"), new Guid("00539901-185f-4490-9481-1d072c53c697") },
                    { new Guid("501c2d4a-ecb1-4bec-ae18-e21e487fb736"), (short)4, "Course275", new Guid("84f9da08-1b22-4d9f-aa30-b448d1aa3734"), new Guid("92b3dc88-fead-4a45-aba3-4aeae5dbec80") },
                    { new Guid("1f9a4ec7-046a-432b-bdc5-bfc5a048e839"), (short)5, "Course220", new Guid("84f9da08-1b22-4d9f-aa30-b448d1aa3734"), new Guid("a188125a-5041-418b-ac92-5303ce6e8a12") },
                    { new Guid("77e1322f-fbce-4143-b2bb-b6c3a4684baf"), (short)2, "Course165", new Guid("84f9da08-1b22-4d9f-aa30-b448d1aa3734"), new Guid("71fbe949-8b66-4ee4-b52b-3c5370663ef6") },
                    { new Guid("1e33560b-a601-429f-b865-137ac43b67ec"), (short)5, "Course106", new Guid("cedd27c4-267a-40f2-a0f0-87ca80472d9d"), new Guid("63e1742b-49cd-41ed-b0dc-d6616bf232ba") },
                    { new Guid("90bf6648-589d-4c2a-bb81-1850b7f4d8a9"), (short)1, "Course159", new Guid("cedd27c4-267a-40f2-a0f0-87ca80472d9d"), new Guid("14ea1798-d8e8-4752-833b-931135f3cc46") },
                    { new Guid("cc8ef06a-8d6f-41bc-9823-a16868d3a334"), (short)4, "Course212", new Guid("cedd27c4-267a-40f2-a0f0-87ca80472d9d"), new Guid("063abe97-7452-429b-8088-ae02501cf52a") },
                    { new Guid("15fc28f7-2c75-4eb1-979b-6c4cd4e4729e"), (short)2, "Course265", new Guid("cedd27c4-267a-40f2-a0f0-87ca80472d9d"), new Guid("71fbe949-8b66-4ee4-b52b-3c5370663ef6") },
                    { new Guid("f85671b1-df4a-4098-8489-d0f34dc511e8"), (short)4, "Course282", new Guid("c57f448e-4350-49ee-8820-9a69c773dfb1"), new Guid("0529f9b9-58d2-4049-ad74-15f95b12b9cf") },
                    { new Guid("9af91f5f-167f-43ee-b1f3-c379a7cfd79a"), (short)5, "Course188", new Guid("c57f448e-4350-49ee-8820-9a69c773dfb1"), new Guid("e6b51413-4b52-4843-85a2-78ed2c0eea2f") },
                    { new Guid("cea4bc31-4d1f-4438-8cb3-149056086069"), (short)3, "Course0", new Guid("d766e40b-ed6b-4423-bc83-5b5d3403bb22"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("bdc52a55-77a8-48ce-ba65-115ee9bbf3a2"), (short)4, "Course54", new Guid("d766e40b-ed6b-4423-bc83-5b5d3403bb22"), new Guid("cb80fe9b-1a1d-4214-bb57-2e630f55f6e9") },
                    { new Guid("57d32b33-046b-4061-9b7d-c7314f1c1bbd"), (short)0, "Course108", new Guid("d766e40b-ed6b-4423-bc83-5b5d3403bb22"), new Guid("ebeffb2e-3a83-47bf-b89a-f738c8edc152") },
                    { new Guid("8c5c1908-7700-43dd-a2ca-47ebb50d6a54"), (short)5, "Course162", new Guid("d766e40b-ed6b-4423-bc83-5b5d3403bb22"), new Guid("ed739eb3-57d3-4d4d-9fa3-1ad130210c41") },
                    { new Guid("011d58f0-8eef-4171-b6d3-9a474bb740df"), (short)2, "Course216", new Guid("d766e40b-ed6b-4423-bc83-5b5d3403bb22"), new Guid("8d205a81-e2bc-4419-9b80-76829198e56a") },
                    { new Guid("b803272b-cd44-4523-bad6-3eaa5cc5e327"), (short)3, "Course270", new Guid("d766e40b-ed6b-4423-bc83-5b5d3403bb22"), new Guid("a07c095e-f185-4765-958b-121530f33152") },
                    { new Guid("553be06c-0f2f-40e3-b79a-b5d4105852f0"), (short)0, "Course94", new Guid("c57f448e-4350-49ee-8820-9a69c773dfb1"), new Guid("8766bb6f-dce9-4dac-a46c-7c2a0243cf58") },
                    { new Guid("d17cdc82-4be1-4b77-927d-5c31bb3d8198"), (short)3, "Course0", new Guid("c57f448e-4350-49ee-8820-9a69c773dfb1"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("2f8c929c-6947-4f21-ae41-d791dda4d0de"), (short)0, "Course0", new Guid("84f9da08-1b22-4d9f-aa30-b448d1aa3734"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("3332916a-f68d-44d7-a84d-1e93965750a6"), (short)4, "Course55", new Guid("84f9da08-1b22-4d9f-aa30-b448d1aa3734"), new Guid("3789d0c1-a469-45be-ae4a-383778d9e884") },
                    { new Guid("b12a6072-5797-407d-b098-343be68b0263"), (short)4, "Course110", new Guid("84f9da08-1b22-4d9f-aa30-b448d1aa3734"), new Guid("13204af6-237b-4597-bb1a-c82c23c09636") },
                    { new Guid("56823ca4-13d7-4fb0-a805-645a72d25b3e"), (short)5, "Course58", new Guid("f53b3b9f-6302-4971-89d4-9ece92d50fb7"), new Guid("c02be181-5f7c-4685-89ee-d0b4b1c3dea0") },
                    { new Guid("aa9596ba-395f-4265-b937-62957831e4a2"), (short)4, "Course116", new Guid("f53b3b9f-6302-4971-89d4-9ece92d50fb7"), new Guid("8d205a81-e2bc-4419-9b80-76829198e56a") },
                    { new Guid("988ca218-06d1-424d-8d88-97134a7c8d76"), (short)2, "Course174", new Guid("f53b3b9f-6302-4971-89d4-9ece92d50fb7"), new Guid("c4a5a9d7-7554-4f06-9602-178bba9fb90f") },
                    { new Guid("342f69a0-b33c-4131-a320-4cceea0f5a82"), (short)4, "Course232", new Guid("f53b3b9f-6302-4971-89d4-9ece92d50fb7"), new Guid("d27b117a-d80a-4155-8dfa-522f22cd4429") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("2c6618bb-bda9-49e0-bd7f-0109bf12b5c7"), (short)5, "Course244", new Guid("d2f6096b-44fe-4ab3-a7f5-448275ba3bbd"), new Guid("0fe90da4-1897-46a6-a2e8-5326e2ad84d8") },
                    { new Guid("c49c6d56-e9f1-4b06-b533-93bdc38cf738"), (short)3, "Course305", new Guid("d2f6096b-44fe-4ab3-a7f5-448275ba3bbd"), new Guid("4769333d-bd39-4438-862b-97f82854efd1") },
                    { new Guid("fa661ff1-520e-44a9-a7ee-a7a40fc90c70"), (short)0, "Course276", new Guid("313dd4a1-ce31-495e-be25-5ef618786573"), new Guid("a906fee8-00ee-4be0-aa58-fc3469ded86a") },
                    { new Guid("a9f001db-20d4-4618-8c82-714b97c09ff4"), (short)5, "Course184", new Guid("313dd4a1-ce31-495e-be25-5ef618786573"), new Guid("07ed323a-f925-4a9a-bcfa-cbfa4333a7b1") },
                    { new Guid("d3f12bc6-42f5-4b44-8768-2fff6fe971ef"), (short)4, "Course0", new Guid("ad4fbc81-e4bc-4c85-8fdf-7a8c6028c1e5"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("0ae2cfa1-e5f3-4aaa-9232-4f8c68dd5ff4"), (short)0, "Course62", new Guid("ad4fbc81-e4bc-4c85-8fdf-7a8c6028c1e5"), new Guid("ed739eb3-57d3-4d4d-9fa3-1ad130210c41") },
                    { new Guid("124f6140-c893-4129-94c6-a076011501a1"), (short)0, "Course124", new Guid("ad4fbc81-e4bc-4c85-8fdf-7a8c6028c1e5"), new Guid("d8ddd747-6d87-410d-bf56-417d725c9a22") },
                    { new Guid("b36c94f3-141c-499f-8a43-73f6b4b13ec1"), (short)2, "Course186", new Guid("ad4fbc81-e4bc-4c85-8fdf-7a8c6028c1e5"), new Guid("4adb9302-baad-4231-9a53-e750e5383bc8") },
                    { new Guid("0c10a1f7-2f65-4809-86c8-2f69ddd56d21"), (short)0, "Course248", new Guid("ad4fbc81-e4bc-4c85-8fdf-7a8c6028c1e5"), new Guid("adbec3db-e798-4b59-a8a1-3ef0c251f642") },
                    { new Guid("7c355ad3-49c9-401e-9771-b7c115f0dbea"), (short)5, "Course310", new Guid("ad4fbc81-e4bc-4c85-8fdf-7a8c6028c1e5"), new Guid("13204af6-237b-4597-bb1a-c82c23c09636") },
                    { new Guid("c998af95-9275-493c-979b-9fd4a2936c98"), (short)0, "Course92", new Guid("313dd4a1-ce31-495e-be25-5ef618786573"), new Guid("ce390f41-873c-453d-9f08-1266e2189587") },
                    { new Guid("793dc78a-9ee5-4cd3-a290-cb16e5ab6b40"), (short)1, "Course0", new Guid("313dd4a1-ce31-495e-be25-5ef618786573"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("762a515b-56e9-4a5e-ac10-a67f9eb816d9"), (short)5, "Course0", new Guid("edcdf2d2-e581-4950-b51c-d56b0fd95a74"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("2e6f5237-d728-4428-a610-1f4c07a5ebf8"), (short)5, "Course63", new Guid("edcdf2d2-e581-4950-b51c-d56b0fd95a74"), new Guid("105a879d-9688-41fc-85f0-a8743376ac65") },
                    { new Guid("a7a7cdd8-3aa1-4462-8923-23d7e453a9de"), (short)1, "Course126", new Guid("edcdf2d2-e581-4950-b51c-d56b0fd95a74"), new Guid("ba0e5c03-6f8b-4477-9e10-0a882b4c3832") },
                    { new Guid("9f9d8cfa-891a-4dad-b485-6daa3a468f4b"), (short)1, "Course189", new Guid("edcdf2d2-e581-4950-b51c-d56b0fd95a74"), new Guid("4161656d-8fe1-4a17-915a-7ff4d8343cc3") },
                    { new Guid("2711ff7b-e683-473f-89ab-76803113de34"), (short)2, "Course252", new Guid("edcdf2d2-e581-4950-b51c-d56b0fd95a74"), new Guid("a5da19b2-60d3-4a47-aa17-6a9bb34f6923") },
                    { new Guid("7b7c7d8d-86a8-42a6-9c75-7191a5eaca93"), (short)2, "Course183", new Guid("d2f6096b-44fe-4ab3-a7f5-448275ba3bbd"), new Guid("f7e5f018-9a10-4752-9db7-83a5ca102f64") },
                    { new Guid("13dae3e1-26b0-44ec-bbbf-61c3eb8d8266"), (short)4, "Course53", new Guid("cedd27c4-267a-40f2-a0f0-87ca80472d9d"), new Guid("f24549c9-0ce2-4f17-b827-6994bf335d46") },
                    { new Guid("370a32d1-9e37-4e48-ada2-bc15a17059fa"), (short)4, "Course122", new Guid("d2f6096b-44fe-4ab3-a7f5-448275ba3bbd"), new Guid("69f353ab-b263-41df-ad3e-e3fb8493d9ac") },
                    { new Guid("ac6b46e8-7648-4174-bc85-522a4514efe7"), (short)2, "Course0", new Guid("d2f6096b-44fe-4ab3-a7f5-448275ba3bbd"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("327d36da-fa31-4970-b2cd-40040594d0a3"), (short)2, "Course290", new Guid("f53b3b9f-6302-4971-89d4-9ece92d50fb7"), new Guid("d3e32fcf-a08d-4708-8b06-0d1ea51a808f") },
                    { new Guid("2dc3a022-0710-4882-9146-69eb4438669a"), (short)5, "Course93", new Guid("4873084f-e5f3-4ebb-93af-1777e95bfb6e"), new Guid("c693d672-a076-4715-8681-ac0e1c9e8ffe") },
                    { new Guid("f8306d0c-2637-4ad4-8c96-6e33f2bc596f"), (short)3, "Course0", new Guid("4873084f-e5f3-4ebb-93af-1777e95bfb6e"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("efba8859-cfe8-4a6d-bf94-6f53740f5710"), (short)2, "Course0", new Guid("1df224db-50d8-48cc-aa8c-c27dd0831dd4"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("da71ff92-affa-45fb-8278-656b70acd006"), (short)5, "Course59", new Guid("1df224db-50d8-48cc-aa8c-c27dd0831dd4"), new Guid("14ea1798-d8e8-4752-833b-931135f3cc46") },
                    { new Guid("7dafd6f4-7de8-438b-9562-8583f00f246c"), (short)4, "Course118", new Guid("1df224db-50d8-48cc-aa8c-c27dd0831dd4"), new Guid("a6f53d31-2194-4fad-b679-d54cba290f0a") },
                    { new Guid("7a479c95-dcba-49fb-a1e9-be68eb4aa97b"), (short)2, "Course177", new Guid("1df224db-50d8-48cc-aa8c-c27dd0831dd4"), new Guid("d3d71917-ddd3-40d3-9ba2-c2d1827161e5") },
                    { new Guid("00e15d49-8a56-47ca-8e3e-c2b5fae60a70"), (short)1, "Course236", new Guid("1df224db-50d8-48cc-aa8c-c27dd0831dd4"), new Guid("3f76ac73-0ba7-4d6a-ab40-bc387998856f") },
                    { new Guid("af0a6cf2-9340-468a-8f69-b501affcde7c"), (short)0, "Course295", new Guid("1df224db-50d8-48cc-aa8c-c27dd0831dd4"), new Guid("5d1d8f68-958b-4b72-a3d9-ab026d6c9b3b") },
                    { new Guid("5e1d60b2-7498-4bfc-8e0d-86d634634d59"), (short)2, "Course0", new Guid("5425e4e3-1934-4b3b-b611-06d871ec6076"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("0169a4fd-d963-4e10-96f0-48c93f96b258"), (short)1, "Course60", new Guid("5425e4e3-1934-4b3b-b611-06d871ec6076"), new Guid("b7e178a9-8cfe-4c9c-aeab-dc77f9f2de35") },
                    { new Guid("c2eb4d09-5b8a-41ab-865a-6adca9939cf0"), (short)5, "Course120", new Guid("5425e4e3-1934-4b3b-b611-06d871ec6076"), new Guid("a188125a-5041-418b-ac92-5303ce6e8a12") },
                    { new Guid("eae80782-ebe0-4a36-8011-3117164925ed"), (short)4, "Course180", new Guid("5425e4e3-1934-4b3b-b611-06d871ec6076"), new Guid("0f3a6be6-d338-4180-9f66-12eea50cc59b") },
                    { new Guid("79db5796-214d-431e-91a4-b8a9a12a4c5d"), (short)5, "Course240", new Guid("5425e4e3-1934-4b3b-b611-06d871ec6076"), new Guid("057dfd7c-e065-4359-ad7d-4f9203a48204") },
                    { new Guid("a5d902f7-b05f-412d-a1b9-718e5674fb9c"), (short)3, "Course300", new Guid("5425e4e3-1934-4b3b-b611-06d871ec6076"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("d7a2dc07-bc5f-4b4d-9c67-2eb6a53d0989"), (short)2, "Course460", new Guid("313dd4a1-ce31-495e-be25-5ef618786573"), new Guid("b7e178a9-8cfe-4c9c-aeab-dc77f9f2de35") },
                    { new Guid("8fee159a-771f-496d-a614-236549e74772"), (short)2, "Course368", new Guid("313dd4a1-ce31-495e-be25-5ef618786573"), new Guid("4bc31229-4343-493d-94ba-f19b12c1369e") },
                    { new Guid("e0c2c5c5-cf5d-4fa7-8ff2-25d8b106ec1d"), (short)0, "Course61", new Guid("d2f6096b-44fe-4ab3-a7f5-448275ba3bbd"), new Guid("7b4542fb-e33d-46d2-aada-0d7a91ac04b4") },
                    { new Guid("ed37b730-8171-4ea4-8823-9d08f2e0bf9b"), (short)1, "Course0", new Guid("cedd27c4-267a-40f2-a0f0-87ca80472d9d"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("71884d81-f220-4419-850a-74704a341e6b"), (short)4, "Course376", new Guid("c57f448e-4350-49ee-8820-9a69c773dfb1"), new Guid("a906fee8-00ee-4be0-aa58-fc3469ded86a") },
                    { new Guid("1876acff-6407-4c54-a172-26ccd76027ec"), (short)0, "Course470", new Guid("c57f448e-4350-49ee-8820-9a69c773dfb1"), new Guid("a07c095e-f185-4765-958b-121530f33152") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("5f14bae8-afb4-403a-9abd-205424e1a043"), (short)0, "Course384", new Guid("af06202b-f38f-450b-8c11-8fc66730120d"), new Guid("07ed323a-f925-4a9a-bcfa-cbfa4333a7b1") },
                    { new Guid("b51a5d11-27b9-475d-ae9d-efde805e8791"), (short)5, "Course0", new Guid("33ab0796-72e9-4709-8e75-4560d3609e38"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("4299e6db-43cd-45c1-a054-f0582ff63a9d"), (short)5, "Course45", new Guid("33ab0796-72e9-4709-8e75-4560d3609e38"), new Guid("2a164668-67e3-4a12-b8a1-af89e56f1a14") },
                    { new Guid("2a1d9f81-67eb-4cf3-bca7-aa6b41923260"), (short)4, "Course90", new Guid("33ab0796-72e9-4709-8e75-4560d3609e38"), new Guid("d3e32fcf-a08d-4708-8b06-0d1ea51a808f") },
                    { new Guid("84bededf-c4f5-4375-90ce-56352749291b"), (short)5, "Course135", new Guid("33ab0796-72e9-4709-8e75-4560d3609e38"), new Guid("5e08f64f-4cf8-4a4f-8b01-640e5291e9ba") },
                    { new Guid("8dc5d5dc-f1e3-41a8-b14e-def398864b3c"), (short)3, "Course180", new Guid("33ab0796-72e9-4709-8e75-4560d3609e38"), new Guid("0f3a6be6-d338-4180-9f66-12eea50cc59b") },
                    { new Guid("ecdb2b4f-63a9-413b-8833-bb3ad625baed"), (short)4, "Course225", new Guid("33ab0796-72e9-4709-8e75-4560d3609e38"), new Guid("6985d0e1-cd88-42c9-814a-158b42abd6d6") },
                    { new Guid("9804d522-be6f-4b3a-8f43-2b2f94730de3"), (short)1, "Course288", new Guid("af06202b-f38f-450b-8c11-8fc66730120d"), new Guid("e6b51413-4b52-4843-85a2-78ed2c0eea2f") },
                    { new Guid("16234fb5-5345-4f54-a452-d26dd2dd5c25"), (short)0, "Course192", new Guid("af06202b-f38f-450b-8c11-8fc66730120d"), new Guid("ce390f41-873c-453d-9f08-1266e2189587") },
                    { new Guid("fa455d2d-7718-4bd3-a3d5-5aa4809abd66"), (short)0, "Course0", new Guid("fd7bf6f3-64b3-4f02-b1ad-6fd62014be98"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("973f7086-d413-4295-8051-aedcc5844a6d"), (short)1, "Course46", new Guid("fd7bf6f3-64b3-4f02-b1ad-6fd62014be98"), new Guid("501d7bb4-8a43-4591-ba6f-19ea8a68a32d") },
                    { new Guid("d1690cac-5db4-44c9-bd5b-5612df766027"), (short)4, "Course92", new Guid("fd7bf6f3-64b3-4f02-b1ad-6fd62014be98"), new Guid("ce390f41-873c-453d-9f08-1266e2189587") },
                    { new Guid("f1f1d380-d014-48db-a1f9-554c2f311b57"), (short)3, "Course138", new Guid("fd7bf6f3-64b3-4f02-b1ad-6fd62014be98"), new Guid("64f7e86e-e102-4040-acc2-89d5c9c06788") },
                    { new Guid("bcdbb300-6ec0-4f37-96e4-c1e2f7fe5a15"), (short)1, "Course184", new Guid("fd7bf6f3-64b3-4f02-b1ad-6fd62014be98"), new Guid("07ed323a-f925-4a9a-bcfa-cbfa4333a7b1") },
                    { new Guid("a07e2bbf-b95c-4d4a-b427-cc83d19790e5"), (short)1, "Course230", new Guid("fd7bf6f3-64b3-4f02-b1ad-6fd62014be98"), new Guid("3c7e6dc1-9f2d-42d3-9e4d-e2431a493beb") },
                    { new Guid("23ea7a84-f27d-4ebf-9c38-3d642edb196c"), (short)4, "Course96", new Guid("af06202b-f38f-450b-8c11-8fc66730120d"), new Guid("77abbb72-1f82-42ba-8f26-b31bc1a26767") },
                    { new Guid("71a7281a-7ec6-48c2-8ee3-133ee4cba22b"), (short)3, "Course0", new Guid("af06202b-f38f-450b-8c11-8fc66730120d"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("7aa6fe96-cd65-499b-8150-0f9764e94376"), (short)4, "Course480", new Guid("af06202b-f38f-450b-8c11-8fc66730120d"), new Guid("0f3a6be6-d338-4180-9f66-12eea50cc59b") },
                    { new Guid("7d0047f3-b28a-49f4-b4d5-fd711fd26fc0"), (short)3, "Course0", new Guid("1f6234b3-22c7-474d-a894-77013b7832eb"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("9ff0da89-d510-4a78-8f05-adc43b5b0068"), (short)1, "Course220", new Guid("feecd83c-4205-49ce-ba72-610ff9124065"), new Guid("a188125a-5041-418b-ac92-5303ce6e8a12") },
                    { new Guid("125b1730-2e0f-4d05-8467-f9b22387e9c2"), (short)2, "Course132", new Guid("feecd83c-4205-49ce-ba72-610ff9124065"), new Guid("d27b117a-d80a-4155-8dfa-522f22cd4429") },
                    { new Guid("c34de7c8-a093-4271-8e55-979597396a0c"), (short)2, "Course0", new Guid("081cc945-5a01-4975-b6e6-387f6ac3ece8"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("acd09e7f-8d03-4e6b-b853-bf5df38a872e"), (short)2, "Course42", new Guid("081cc945-5a01-4975-b6e6-387f6ac3ece8"), new Guid("6cc73e31-6f80-4272-82bf-eb0a1325aeb4") },
                    { new Guid("70f7246f-0d57-4f77-8d22-bc34017ccde4"), (short)0, "Course84", new Guid("081cc945-5a01-4975-b6e6-387f6ac3ece8"), new Guid("07ed323a-f925-4a9a-bcfa-cbfa4333a7b1") },
                    { new Guid("48234e7d-fd38-497b-ad14-479b5838316d"), (short)3, "Course126", new Guid("081cc945-5a01-4975-b6e6-387f6ac3ece8"), new Guid("ba0e5c03-6f8b-4477-9e10-0a882b4c3832") },
                    { new Guid("9f77aaab-a3c2-4899-8f03-4836857b162c"), (short)1, "Course168", new Guid("081cc945-5a01-4975-b6e6-387f6ac3ece8"), new Guid("4bc31229-4343-493d-94ba-f19b12c1369e") },
                    { new Guid("7f1cf78a-f1f2-4424-b994-b4294b4bd118"), (short)2, "Course210", new Guid("081cc945-5a01-4975-b6e6-387f6ac3ece8"), new Guid("13204af6-237b-4597-bb1a-c82c23c09636") },
                    { new Guid("e193732b-9d86-4fd2-9e74-b9c573419709"), (short)5, "Course97", new Guid("948db04e-01cc-4694-95d2-63fa40172191"), new Guid("0a56d0c8-98c6-400e-abe3-fb0a9a9f286b") },
                    { new Guid("ab3d3828-f1c2-4186-b69c-ea7c30dc3c09"), (short)1, "Course0", new Guid("948db04e-01cc-4694-95d2-63fa40172191"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("1f4a30cc-581f-44ef-82c5-26e32ffd228e"), (short)4, "Course0", new Guid("6260768b-db7c-43c8-b6ad-69de7795c445"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("e30c3bf8-76bf-4a8f-b5d5-a499ab63c59e"), (short)2, "Course43", new Guid("b72b47d3-75c7-4543-9afc-5fd2000145d5"), new Guid("f695bb45-0fcc-4233-b615-69daac6c3ac7") },
                    { new Guid("4ac9a0ff-40a6-4d09-87fb-5b0f74eb9808"), (short)5, "Course86", new Guid("b72b47d3-75c7-4543-9afc-5fd2000145d5"), new Guid("4adb9302-baad-4231-9a53-e750e5383bc8") },
                    { new Guid("172dda53-2249-47f4-9482-2c8fb3e4c696"), (short)5, "Course129", new Guid("b72b47d3-75c7-4543-9afc-5fd2000145d5"), new Guid("ce09c1a2-6510-4c84-a533-688fbff0d1b4") },
                    { new Guid("e79c49c4-3f2c-42e6-a08f-8936df6952e5"), (short)3, "Course172", new Guid("b72b47d3-75c7-4543-9afc-5fd2000145d5"), new Guid("ed1486d0-4af1-449f-882e-93b5bc021952") },
                    { new Guid("8a2ad691-bb5d-4d18-b06b-bf86f6addbd4"), (short)2, "Course215", new Guid("b72b47d3-75c7-4543-9afc-5fd2000145d5"), new Guid("ec29cecf-9bb4-4b00-9d9a-5d0ccad64829") },
                    { new Guid("4ae5cedf-8233-483d-a327-4d1ac24ec488"), (short)4, "Course0", new Guid("feecd83c-4205-49ce-ba72-610ff9124065"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("69998c0f-7701-4695-b4eb-526d5567c0f6"), (short)2, "Course44", new Guid("feecd83c-4205-49ce-ba72-610ff9124065"), new Guid("0fe90da4-1897-46a6-a2e8-5326e2ad84d8") },
                    { new Guid("9ebc585c-29c1-4c47-a776-53d2c8280639"), (short)2, "Course88", new Guid("feecd83c-4205-49ce-ba72-610ff9124065"), new Guid("e6b51413-4b52-4843-85a2-78ed2c0eea2f") },
                    { new Guid("7b0e527d-06ec-4bac-8118-4980b02c2c24"), (short)5, "Course176", new Guid("feecd83c-4205-49ce-ba72-610ff9124065"), new Guid("a906fee8-00ee-4be0-aa58-fc3469ded86a") },
                    { new Guid("3785eb9d-6583-40f9-93b0-d3f6696ef6cc"), (short)1, "Course315", new Guid("edcdf2d2-e581-4950-b51c-d56b0fd95a74"), new Guid("ec29cecf-9bb4-4b00-9d9a-5d0ccad64829") },
                    { new Guid("c822a2f3-2cbd-44ef-8027-c90c8245cf5a"), (short)2, "Course47", new Guid("1f6234b3-22c7-474d-a894-77013b7832eb"), new Guid("8c7fd48c-4b7c-4b23-a1eb-7b91ac817ded") },
                    { new Guid("5963048e-6bdf-4570-a244-3346794ea382"), (short)4, "Course141", new Guid("1f6234b3-22c7-474d-a894-77013b7832eb"), new Guid("6b48d1dc-3249-4c0a-b1c0-1eced2993fae") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("232c9729-ba48-4af6-b206-72395d9e9db2"), (short)2, "Course150", new Guid("c904906c-036e-4feb-8775-92c3d78524df"), new Guid("a6a34e96-0ca8-49d8-a157-d49457805cae") },
                    { new Guid("e29f4773-3026-428e-8d19-81bdf864693a"), (short)4, "Course200", new Guid("c904906c-036e-4feb-8775-92c3d78524df"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("20e9555c-39d6-40d9-b80f-100eac3a3700"), (short)0, "Course250", new Guid("c904906c-036e-4feb-8775-92c3d78524df"), new Guid("a6a34e96-0ca8-49d8-a157-d49457805cae") },
                    { new Guid("e8f67716-ce1d-4a57-b8c8-3dbc660bee76"), (short)1, "Course95", new Guid("5a2662cc-c496-46eb-9a3f-c599a6888d43"), new Guid("5d1d8f68-958b-4b72-a3d9-ab026d6c9b3b") },
                    { new Guid("ab9ae549-dce9-4010-ad25-bec56867c4dd"), (short)1, "Course0", new Guid("5a2662cc-c496-46eb-9a3f-c599a6888d43"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("743890ff-28a1-43c5-ac69-b718823b9018"), (short)0, "Course0", new Guid("de9b8934-ea96-4bff-bf45-e910ed1e9603"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("89ed4101-5b88-45dc-80e8-e6568145f069"), (short)1, "Course51", new Guid("de9b8934-ea96-4bff-bf45-e910ed1e9603"), new Guid("68b80fce-73ac-4d0a-8df7-929dde1bad2b") },
                    { new Guid("24838e9b-7d02-4471-8824-05622a2e4d1f"), (short)3, "Course102", new Guid("de9b8934-ea96-4bff-bf45-e910ed1e9603"), new Guid("38eccc3c-7b82-450f-8c4c-bdcbae4ec305") },
                    { new Guid("27a87682-87fa-444a-886b-fa6e27f73e90"), (short)0, "Course153", new Guid("de9b8934-ea96-4bff-bf45-e910ed1e9603"), new Guid("f24549c9-0ce2-4f17-b827-6994bf335d46") },
                    { new Guid("892eaed2-8e74-4011-882d-b21a2b14a630"), (short)5, "Course204", new Guid("de9b8934-ea96-4bff-bf45-e910ed1e9603"), new Guid("b525ecf2-7acd-47bd-87ae-5309b598ee56") },
                    { new Guid("acf3178f-3c53-4750-ac16-69437b934f01"), (short)0, "Course255", new Guid("de9b8934-ea96-4bff-bf45-e910ed1e9603"), new Guid("3789d0c1-a469-45be-ae4a-383778d9e884") },
                    { new Guid("28dc1dd5-dfcf-4cdb-8749-4e9f448b3e42"), (short)2, "Course0", new Guid("51d323aa-078d-4376-b325-0a32fda1b988"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("38ca650f-3f06-4393-a017-62b9cfad8f8c"), (short)4, "Course52", new Guid("51d323aa-078d-4376-b325-0a32fda1b988"), new Guid("a5da19b2-60d3-4a47-aa17-6a9bb34f6923") },
                    { new Guid("0acaf844-0692-48d7-8cd9-4b9073db537b"), (short)4, "Course104", new Guid("51d323aa-078d-4376-b325-0a32fda1b988"), new Guid("b525ecf2-7acd-47bd-87ae-5309b598ee56") },
                    { new Guid("11f33ab1-d3db-45e1-966c-a182d9b8f7f2"), (short)5, "Course156", new Guid("51d323aa-078d-4376-b325-0a32fda1b988"), new Guid("0a2bec6b-65e9-4c34-8fa8-eb3a98e94d6c") },
                    { new Guid("200f4542-6fee-4e3c-b36f-b0bb00023cf3"), (short)1, "Course208", new Guid("51d323aa-078d-4376-b325-0a32fda1b988"), new Guid("ebeffb2e-3a83-47bf-b89a-f738c8edc152") },
                    { new Guid("3ddc103e-a447-476a-992a-a7bb297c06ef"), (short)5, "Course260", new Guid("51d323aa-078d-4376-b325-0a32fda1b988"), new Guid("b7e178a9-8cfe-4c9c-aeab-dc77f9f2de35") },
                    { new Guid("482cb9a0-1dc6-41bc-b6c0-7f9b04d64270"), (short)0, "Course100", new Guid("c904906c-036e-4feb-8775-92c3d78524df"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("aa535e79-9963-43f0-bbd0-ca3af223e0ec"), (short)3, "Course94", new Guid("1f6234b3-22c7-474d-a894-77013b7832eb"), new Guid("8766bb6f-dce9-4dac-a46c-7c2a0243cf58") },
                    { new Guid("9691d8f7-fbce-4a5d-b50a-1075c962abf4"), (short)0, "Course50", new Guid("c904906c-036e-4feb-8775-92c3d78524df"), new Guid("a6a34e96-0ca8-49d8-a157-d49457805cae") },
                    { new Guid("335ceb6c-0e49-4d2f-b5d2-96312b4a44c2"), (short)3, "Course190", new Guid("5a2662cc-c496-46eb-9a3f-c599a6888d43"), new Guid("d3e32fcf-a08d-4708-8b06-0d1ea51a808f") },
                    { new Guid("29e9d6da-0e11-4176-be18-4ac36d0021c2"), (short)3, "Course188", new Guid("1f6234b3-22c7-474d-a894-77013b7832eb"), new Guid("e6b51413-4b52-4843-85a2-78ed2c0eea2f") },
                    { new Guid("879cf584-b08d-4b99-bcf3-8ccfcedf623e"), (short)3, "Course235", new Guid("1f6234b3-22c7-474d-a894-77013b7832eb"), new Guid("5e08f64f-4cf8-4a4f-8b01-640e5291e9ba") },
                    { new Guid("70842d5d-d8af-427a-88d7-4adb96aa5d94"), (short)4, "Course0", new Guid("5a2feda2-ecce-428d-8a90-c8eebab44fc9"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("250080cb-f3b1-4ba2-9282-cb3fc8511b88"), (short)5, "Course48", new Guid("5a2feda2-ecce-428d-8a90-c8eebab44fc9"), new Guid("adbec3db-e798-4b59-a8a1-3ef0c251f642") },
                    { new Guid("5722c7d7-3046-43b8-9015-ecdd7b758c8f"), (short)5, "Course96", new Guid("5a2feda2-ecce-428d-8a90-c8eebab44fc9"), new Guid("77abbb72-1f82-42ba-8f26-b31bc1a26767") },
                    { new Guid("0fbfa57c-7458-4640-81f1-f298d8c54a73"), (short)1, "Course144", new Guid("5a2feda2-ecce-428d-8a90-c8eebab44fc9"), new Guid("0fe90da4-1897-46a6-a2e8-5326e2ad84d8") },
                    { new Guid("7e2cdf17-dfb6-488c-a0d7-2e5373fe5dbd"), (short)5, "Course192", new Guid("5a2feda2-ecce-428d-8a90-c8eebab44fc9"), new Guid("ce390f41-873c-453d-9f08-1266e2189587") },
                    { new Guid("25ef7cdc-93c7-4bf7-bd6f-87ed2d84ad81"), (short)2, "Course240", new Guid("5a2feda2-ecce-428d-8a90-c8eebab44fc9"), new Guid("057dfd7c-e065-4359-ad7d-4f9203a48204") },
                    { new Guid("ecb45624-bda9-48ec-88ab-a1e76b0567bb"), (short)3, "Course475", new Guid("5a2662cc-c496-46eb-9a3f-c599a6888d43"), new Guid("92b3dc88-fead-4a45-aba3-4aeae5dbec80") },
                    { new Guid("c0f4be65-eec6-4f27-aee5-691c5cb87211"), (short)1, "Course380", new Guid("5a2662cc-c496-46eb-9a3f-c599a6888d43"), new Guid("0f3a6be6-d338-4180-9f66-12eea50cc59b") },
                    { new Guid("5b63d26a-e1df-42a9-9ffd-56c0287f5262"), (short)3, "Course0", new Guid("1589bfb4-5aae-44bb-84c8-fd7a265c73be"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("e1b7634c-9f42-4bf6-8e13-adb6fc26569d"), (short)5, "Course49", new Guid("1589bfb4-5aae-44bb-84c8-fd7a265c73be"), new Guid("2b8b30bd-1ff4-4f45-81e7-92d191fae001") },
                    { new Guid("912edb0a-0f09-45d6-99af-a705781a7efb"), (short)2, "Course98", new Guid("1589bfb4-5aae-44bb-84c8-fd7a265c73be"), new Guid("7ad86313-7bbc-4d7f-899c-86985ce8b6ab") },
                    { new Guid("1e02c9e0-aaec-4a8e-88b3-8100ef7ca062"), (short)4, "Course147", new Guid("1589bfb4-5aae-44bb-84c8-fd7a265c73be"), new Guid("8c7fd48c-4b7c-4b23-a1eb-7b91ac817ded") },
                    { new Guid("4232e2f7-0193-4495-9038-dc493a955729"), (short)2, "Course196", new Guid("1589bfb4-5aae-44bb-84c8-fd7a265c73be"), new Guid("77abbb72-1f82-42ba-8f26-b31bc1a26767") },
                    { new Guid("0dc92c30-a79a-4e71-a193-0c7098c5415c"), (short)3, "Course245", new Guid("1589bfb4-5aae-44bb-84c8-fd7a265c73be"), new Guid("2a164668-67e3-4a12-b8a1-af89e56f1a14") },
                    { new Guid("6b00590d-ea22-4e60-9a5d-5bf4d57ab706"), (short)1, "Course285", new Guid("5a2662cc-c496-46eb-9a3f-c599a6888d43"), new Guid("1bb30181-e8ba-4ab9-85d3-d81474aca8d1") },
                    { new Guid("d6427c6e-e72c-40c3-8c4e-dc372edab2fe"), (short)3, "Course0", new Guid("c904906c-036e-4feb-8775-92c3d78524df"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("3c53a811-a78d-47e0-ac7b-782827faf1e6"), (short)4, "Course194", new Guid("948db04e-01cc-4694-95d2-63fa40172191"), new Guid("8766bb6f-dce9-4dac-a46c-7c2a0243cf58") },
                    { new Guid("f95c4693-660b-4508-b547-66220bbf31cf"), (short)3, "Course0", new Guid("369aba17-6ac2-4c10-9f1a-110ca5d4fa3c"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("070f186c-0878-44ba-87c2-225e74a8b9ad"), (short)3, "Course128", new Guid("369aba17-6ac2-4c10-9f1a-110ca5d4fa3c"), new Guid("a60a1d7e-06fa-458f-8a6b-5665cb75fb3c") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("2b7385a8-f496-483d-9819-fdc6e3b1b663"), (short)3, "Course156", new Guid("be6619cc-a2d5-4765-814d-9b2feee87b89"), new Guid("0a2bec6b-65e9-4c34-8fa8-eb3a98e94d6c") },
                    { new Guid("105496d5-add8-413a-a50b-685ca1e95d0e"), (short)0, "Course234", new Guid("be6619cc-a2d5-4765-814d-9b2feee87b89"), new Guid("0fd529d1-e3e2-47c5-b856-7aba08cbbbf0") },
                    { new Guid("fc8a98a1-483f-4638-938b-7040aba5a6dd"), (short)3, "Course312", new Guid("be6619cc-a2d5-4765-814d-9b2feee87b89"), new Guid("063abe97-7452-429b-8088-ae02501cf52a") },
                    { new Guid("c62b7824-2ea1-4d29-a8f1-c377e2e6ffbb"), (short)0, "Course390", new Guid("be6619cc-a2d5-4765-814d-9b2feee87b89"), new Guid("d3e32fcf-a08d-4708-8b06-0d1ea51a808f") },
                    { new Guid("77749faf-91d2-424a-a0d4-e9756287b094"), (short)5, "Course88", new Guid("52bc0a8f-57c0-4c34-9c11-4dd6ba359789"), new Guid("e6b51413-4b52-4843-85a2-78ed2c0eea2f") },
                    { new Guid("6c2e5440-ca97-41d7-a367-867b9e893aa3"), (short)0, "Course0", new Guid("52bc0a8f-57c0-4c34-9c11-4dd6ba359789"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("768672f5-e7ab-4c24-8820-6b67fc9f98a0"), (short)5, "Course0", new Guid("ed288f86-5f81-487f-a090-280ca0dfac4e"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("de77189c-8c5a-4663-b128-01e9f1be80be"), (short)1, "Course78", new Guid("be6619cc-a2d5-4765-814d-9b2feee87b89"), new Guid("2d18691c-989d-416d-a354-29be08ce9df1") },
                    { new Guid("261b1182-5a47-463e-9ad8-47117d741a0c"), (short)2, "Course79", new Guid("ed288f86-5f81-487f-a090-280ca0dfac4e"), new Guid("1766f994-8239-4121-b06d-ad7564b3bfc6") },
                    { new Guid("b1c51eb2-6202-4b52-9620-34fbac0ee8a5"), (short)3, "Course237", new Guid("ed288f86-5f81-487f-a090-280ca0dfac4e"), new Guid("7edca406-8727-4468-98f7-a23690714cf9") },
                    { new Guid("773e05ca-7a50-4aa8-8694-2c9ff3ecd357"), (short)3, "Course316", new Guid("ed288f86-5f81-487f-a090-280ca0dfac4e"), new Guid("8d205a81-e2bc-4419-9b80-76829198e56a") },
                    { new Guid("ef87aed8-1951-4134-b434-e7551827eb92"), (short)4, "Course395", new Guid("ed288f86-5f81-487f-a090-280ca0dfac4e"), new Guid("5d1d8f68-958b-4b72-a3d9-ab026d6c9b3b") },
                    { new Guid("14faf5eb-1c12-4b44-94df-8c939bc54a17"), (short)3, "Course0", new Guid("90740841-d602-4469-a39e-e2971ff1f366"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("7f43af0b-b04a-44f2-be8a-f07e5cb4e6b1"), (short)3, "Course80", new Guid("90740841-d602-4469-a39e-e2971ff1f366"), new Guid("0f3a6be6-d338-4180-9f66-12eea50cc59b") },
                    { new Guid("eefc8c06-c286-41ef-8ca7-78cbae151cb6"), (short)3, "Course160", new Guid("90740841-d602-4469-a39e-e2971ff1f366"), new Guid("b7e178a9-8cfe-4c9c-aeab-dc77f9f2de35") },
                    { new Guid("f6b125b5-0150-43c0-8ef8-7fb60e8623bd"), (short)2, "Course240", new Guid("90740841-d602-4469-a39e-e2971ff1f366"), new Guid("057dfd7c-e065-4359-ad7d-4f9203a48204") },
                    { new Guid("8b735a73-9393-4d5f-90ec-bcafc267a8a9"), (short)0, "Course158", new Guid("ed288f86-5f81-487f-a090-280ca0dfac4e"), new Guid("c02be181-5f7c-4685-89ee-d0b4b1c3dea0") },
                    { new Guid("547bd284-9931-45a0-aa5a-3c91cd18b38a"), (short)5, "Course0", new Guid("be6619cc-a2d5-4765-814d-9b2feee87b89"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("45aa3fe7-1a58-45a7-ba62-8e6916986e10"), (short)4, "Course176", new Guid("52bc0a8f-57c0-4c34-9c11-4dd6ba359789"), new Guid("a906fee8-00ee-4be0-aa58-fc3469ded86a") },
                    { new Guid("b99129e6-6052-43fe-ab89-93b367d564e4"), (short)5, "Course264", new Guid("52bc0a8f-57c0-4c34-9c11-4dd6ba359789"), new Guid("c8258a3d-48f8-4eac-b14e-18ced7b5618e") },
                    { new Guid("76e8aea8-e753-4373-a013-4a0163350e2d"), (short)2, "Course225", new Guid("bd932240-c2f0-4585-ae4b-578c673c95ee"), new Guid("6985d0e1-cd88-42c9-814a-158b42abd6d6") },
                    { new Guid("72094b8e-d590-4054-9503-cb317aee50e6"), (short)1, "Course300", new Guid("bd932240-c2f0-4585-ae4b-578c673c95ee"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("5eddddd7-3eea-421e-9864-d968d7e88b0a"), (short)5, "Course375", new Guid("bd932240-c2f0-4585-ae4b-578c673c95ee"), new Guid("92b3dc88-fead-4a45-aba3-4aeae5dbec80") },
                    { new Guid("54771783-d492-4d14-a58e-1f3b7a53041b"), (short)1, "Course0", new Guid("fb665d42-4b97-40cc-b2cd-53ddf9f111a8"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("7ceb832a-bf00-4638-92f8-238fe43aad6f"), (short)3, "Course76", new Guid("fb665d42-4b97-40cc-b2cd-53ddf9f111a8"), new Guid("a906fee8-00ee-4be0-aa58-fc3469ded86a") },
                    { new Guid("b1426549-77e7-4e7f-abb7-13a31c667e12"), (short)5, "Course152", new Guid("fb665d42-4b97-40cc-b2cd-53ddf9f111a8"), new Guid("a5da19b2-60d3-4a47-aa17-6a9bb34f6923") },
                    { new Guid("bcef31f2-0ed7-4783-babb-a9ff14b21396"), (short)3, "Course228", new Guid("fb665d42-4b97-40cc-b2cd-53ddf9f111a8"), new Guid("a60a1d7e-06fa-458f-8a6b-5665cb75fb3c") },
                    { new Guid("ce44095a-bdf0-480c-a2ee-249b7f2ec726"), (short)5, "Course304", new Guid("fb665d42-4b97-40cc-b2cd-53ddf9f111a8"), new Guid("b525ecf2-7acd-47bd-87ae-5309b598ee56") },
                    { new Guid("67cceb59-c6e8-4259-95eb-c1093c4433fb"), (short)3, "Course380", new Guid("fb665d42-4b97-40cc-b2cd-53ddf9f111a8"), new Guid("0f3a6be6-d338-4180-9f66-12eea50cc59b") },
                    { new Guid("5a8cd1f1-f67f-4a4e-9f02-9e62aa756cbb"), (short)5, "Course440", new Guid("52bc0a8f-57c0-4c34-9c11-4dd6ba359789"), new Guid("057dfd7c-e065-4359-ad7d-4f9203a48204") },
                    { new Guid("7ad44b25-ac86-4fbb-ad42-3642ea605821"), (short)1, "Course352", new Guid("52bc0a8f-57c0-4c34-9c11-4dd6ba359789"), new Guid("a5da19b2-60d3-4a47-aa17-6a9bb34f6923") },
                    { new Guid("e6e9d0d4-72ae-4d1d-8dd2-5330883b079c"), (short)3, "Course0", new Guid("a90d92b7-bb0c-49b0-9a76-a384554d2856"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("0bf49a54-924f-4e2f-a30b-53eb2fe52a48"), (short)3, "Course77", new Guid("a90d92b7-bb0c-49b0-9a76-a384554d2856"), new Guid("d3d71917-ddd3-40d3-9ba2-c2d1827161e5") },
                    { new Guid("aa945abf-4b56-45fb-b22e-495fa5dda6d0"), (short)2, "Course154", new Guid("a90d92b7-bb0c-49b0-9a76-a384554d2856"), new Guid("cb80fe9b-1a1d-4214-bb57-2e630f55f6e9") },
                    { new Guid("7a0ed1b9-6f04-4954-9e90-520c656dc972"), (short)1, "Course231", new Guid("a90d92b7-bb0c-49b0-9a76-a384554d2856"), new Guid("a338538a-abb1-4870-b2be-f707276ce47b") },
                    { new Guid("22a24156-7aa8-4107-94a5-f27f774d943d"), (short)2, "Course308", new Guid("a90d92b7-bb0c-49b0-9a76-a384554d2856"), new Guid("ebeffb2e-3a83-47bf-b89a-f738c8edc152") },
                    { new Guid("b395c811-2b4b-46fe-991c-f122c70e0328"), (short)2, "Course385", new Guid("a90d92b7-bb0c-49b0-9a76-a384554d2856"), new Guid("1bb30181-e8ba-4ab9-85d3-d81474aca8d1") },
                    { new Guid("283715bc-4148-4084-bb24-fc58e3feb905"), (short)3, "Course320", new Guid("90740841-d602-4469-a39e-e2971ff1f366"), new Guid("a188125a-5041-418b-ac92-5303ce6e8a12") },
                    { new Guid("0f281580-0c31-4101-861f-6d1a3bf7888b"), (short)3, "Course400", new Guid("90740841-d602-4469-a39e-e2971ff1f366"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("c4b35373-4831-49a8-b4cf-e99a9beddaf9"), (short)4, "Course435", new Guid("d299e537-237f-4d2e-9146-b884455575f3"), new Guid("5e08f64f-4cf8-4a4f-8b01-640e5291e9ba") },
                    { new Guid("864766f9-5fa1-4705-961e-3cc2dba7d7cc"), (short)0, "Course348", new Guid("d299e537-237f-4d2e-9146-b884455575f3"), new Guid("adbec3db-e798-4b59-a8a1-3ef0c251f642") },
                    { new Guid("3dba3c46-4266-4ac8-af93-6ddfcfb38d1a"), (short)0, "Course415", new Guid("cf575b9b-0435-4db6-8a44-045bc22e6c3f"), new Guid("ec29cecf-9bb4-4b00-9d9a-5d0ccad64829") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("b5ad6fa6-9fbd-45d4-adb2-ec90c893ce13"), (short)0, "Course0", new Guid("ef4de7e3-ff4f-472f-90db-1dd4522b68c0"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("1cb91acd-5449-4611-934f-3e2d47cab8a7"), (short)3, "Course84", new Guid("ef4de7e3-ff4f-472f-90db-1dd4522b68c0"), new Guid("07ed323a-f925-4a9a-bcfa-cbfa4333a7b1") },
                    { new Guid("bac5b4ca-1851-4684-877b-4a66f627fb9b"), (short)1, "Course168", new Guid("ef4de7e3-ff4f-472f-90db-1dd4522b68c0"), new Guid("4bc31229-4343-493d-94ba-f19b12c1369e") },
                    { new Guid("c6bd144c-8099-4afb-a7ae-3b9597fec59b"), (short)1, "Course252", new Guid("ef4de7e3-ff4f-472f-90db-1dd4522b68c0"), new Guid("a5da19b2-60d3-4a47-aa17-6a9bb34f6923") },
                    { new Guid("e1ee2e3a-53d3-4f96-9ea6-f55b572171b7"), (short)1, "Course336", new Guid("ef4de7e3-ff4f-472f-90db-1dd4522b68c0"), new Guid("3f76ac73-0ba7-4d6a-ab40-bc387998856f") },
                    { new Guid("47572941-497b-49ab-822f-fe524c2143b2"), (short)3, "Course420", new Guid("ef4de7e3-ff4f-472f-90db-1dd4522b68c0"), new Guid("a188125a-5041-418b-ac92-5303ce6e8a12") },
                    { new Guid("bcd14e92-7c6d-4725-82b1-ff80561e25ff"), (short)0, "Course430", new Guid("6260768b-db7c-43c8-b6ad-69de7795c445"), new Guid("3c7e6dc1-9f2d-42d3-9e4d-e2431a493beb") },
                    { new Guid("e399b06b-f908-431f-a7df-dacedaa55b74"), (short)2, "Course344", new Guid("6260768b-db7c-43c8-b6ad-69de7795c445"), new Guid("0fe90da4-1897-46a6-a2e8-5326e2ad84d8") },
                    { new Guid("e1d48364-2128-45d1-a0b2-c9b23ff08340"), (short)2, "Course0", new Guid("448af37f-cac6-4d46-ad76-2b96c15aa522"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("1bf1dc31-9369-494a-ae6b-51f44f74f25a"), (short)3, "Course85", new Guid("448af37f-cac6-4d46-ad76-2b96c15aa522"), new Guid("1bb30181-e8ba-4ab9-85d3-d81474aca8d1") },
                    { new Guid("8a85405a-5a06-4d54-8a2d-4f395afdc9f8"), (short)1, "Course170", new Guid("448af37f-cac6-4d46-ad76-2b96c15aa522"), new Guid("a07c095e-f185-4765-958b-121530f33152") },
                    { new Guid("023719f0-50fd-4b99-bccd-10446fc23a55"), (short)2, "Course255", new Guid("448af37f-cac6-4d46-ad76-2b96c15aa522"), new Guid("3789d0c1-a469-45be-ae4a-383778d9e884") },
                    { new Guid("201a1747-29ec-4bf7-b611-c418e4b8a213"), (short)0, "Course340", new Guid("448af37f-cac6-4d46-ad76-2b96c15aa522"), new Guid("057dfd7c-e065-4359-ad7d-4f9203a48204") },
                    { new Guid("58a3e1a6-3b0f-42ae-bb85-bb84c72fe921"), (short)5, "Course425", new Guid("448af37f-cac6-4d46-ad76-2b96c15aa522"), new Guid("6985d0e1-cd88-42c9-814a-158b42abd6d6") },
                    { new Guid("41c1226b-445f-46a9-9fcf-08ec35559392"), (short)5, "Course258", new Guid("6260768b-db7c-43c8-b6ad-69de7795c445"), new Guid("c02be181-5f7c-4685-89ee-d0b4b1c3dea0") },
                    { new Guid("3a7d1b3c-4e35-445b-95de-a1546a29f81b"), (short)5, "Course172", new Guid("6260768b-db7c-43c8-b6ad-69de7795c445"), new Guid("ed1486d0-4af1-449f-882e-93b5bc021952") },
                    { new Guid("1ee24eb8-0f0a-41e9-a45b-aff8a53ec5eb"), (short)3, "Course332", new Guid("cf575b9b-0435-4db6-8a44-045bc22e6c3f"), new Guid("d27b117a-d80a-4155-8dfa-522f22cd4429") },
                    { new Guid("50edf126-a969-4187-861d-b081ec75d15c"), (short)4, "Course150", new Guid("bd932240-c2f0-4585-ae4b-578c673c95ee"), new Guid("a6a34e96-0ca8-49d8-a157-d49457805cae") },
                    { new Guid("0df008b7-1897-4705-ae7f-9bc7cf8bc625"), (short)2, "Course249", new Guid("cf575b9b-0435-4db6-8a44-045bc22e6c3f"), new Guid("2b8b30bd-1ff4-4f45-81e7-92d191fae001") },
                    { new Guid("a5085170-ae70-49fe-9f15-858ac0504e0e"), (short)3, "Course83", new Guid("cf575b9b-0435-4db6-8a44-045bc22e6c3f"), new Guid("f7e5f018-9a10-4752-9db7-83a5ca102f64") },
                    { new Guid("bdcfde5b-ae1f-4211-93a7-3176459976c2"), (short)2, "Course0", new Guid("e2ee5fd1-dd4f-4079-a88d-fd45ac37094e"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("1d6c5973-544e-4a64-bcf6-a78a5f194d4e"), (short)0, "Course81", new Guid("e2ee5fd1-dd4f-4079-a88d-fd45ac37094e"), new Guid("271a7c7b-38db-467b-a441-d5f44884446b") },
                    { new Guid("5c7d7b8f-32bc-4f02-94a2-e025382e136c"), (short)0, "Course162", new Guid("e2ee5fd1-dd4f-4079-a88d-fd45ac37094e"), new Guid("ed739eb3-57d3-4d4d-9fa3-1ad130210c41") },
                    { new Guid("237274fb-bab9-48d2-b972-8f16ecf4aa1f"), (short)3, "Course243", new Guid("e2ee5fd1-dd4f-4079-a88d-fd45ac37094e"), new Guid("f695bb45-0fcc-4233-b615-69daac6c3ac7") },
                    { new Guid("d6e09cb9-616e-4f38-87dd-d4f395c63ada"), (short)5, "Course324", new Guid("e2ee5fd1-dd4f-4079-a88d-fd45ac37094e"), new Guid("d8ddd747-6d87-410d-bf56-417d725c9a22") },
                    { new Guid("5cb53f34-d159-4750-8d56-37104f3c55f1"), (short)1, "Course405", new Guid("e2ee5fd1-dd4f-4079-a88d-fd45ac37094e"), new Guid("4769333d-bd39-4438-862b-97f82854efd1") },
                    { new Guid("0739c364-58ab-411e-a8be-b3ff636682b2"), (short)2, "Course261", new Guid("d299e537-237f-4d2e-9146-b884455575f3"), new Guid("7b4542fb-e33d-46d2-aada-0d7a91ac04b4") },
                    { new Guid("c124ae75-ed9c-4c68-a963-0a62121b6ca8"), (short)1, "Course174", new Guid("d299e537-237f-4d2e-9146-b884455575f3"), new Guid("c4a5a9d7-7554-4f06-9602-178bba9fb90f") },
                    { new Guid("99d7b1d2-0565-4fff-82fb-8eccbb39329b"), (short)4, "Course0", new Guid("6543866f-3fb6-4d73-b99d-a914c389d363"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("a53bd21e-7210-4e0a-b2ce-0ad29872aafd"), (short)5, "Course82", new Guid("6543866f-3fb6-4d73-b99d-a914c389d363"), new Guid("0529f9b9-58d2-4049-ad74-15f95b12b9cf") },
                    { new Guid("503d192f-9a9b-4bc5-ab53-77432bc0beb4"), (short)1, "Course164", new Guid("6543866f-3fb6-4d73-b99d-a914c389d363"), new Guid("c8258a3d-48f8-4eac-b14e-18ced7b5618e") },
                    { new Guid("6aaa9c06-fb39-4c11-95d6-09b98fc5ccc8"), (short)1, "Course246", new Guid("6543866f-3fb6-4d73-b99d-a914c389d363"), new Guid("501d7bb4-8a43-4591-ba6f-19ea8a68a32d") },
                    { new Guid("e7c1c2c2-609b-4360-9534-5f1fa0508ff4"), (short)5, "Course328", new Guid("6543866f-3fb6-4d73-b99d-a914c389d363"), new Guid("a60a1d7e-06fa-458f-8a6b-5665cb75fb3c") },
                    { new Guid("fb5fcc1e-7ac3-4d1a-b6c1-25680d63384e"), (short)5, "Course410", new Guid("6543866f-3fb6-4d73-b99d-a914c389d363"), new Guid("13204af6-237b-4597-bb1a-c82c23c09636") },
                    { new Guid("437b565c-51c3-42d0-a341-f90f4435cb84"), (short)1, "Course87", new Guid("d299e537-237f-4d2e-9146-b884455575f3"), new Guid("cb6e00a5-c211-4508-b6d7-cd48332e9344") },
                    { new Guid("324dcb38-e315-4841-b4fd-0659d7dcc798"), (short)4, "Course0", new Guid("d299e537-237f-4d2e-9146-b884455575f3"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("325c97fa-79df-4df3-8493-564c6202f9d3"), (short)1, "Course0", new Guid("cf575b9b-0435-4db6-8a44-045bc22e6c3f"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("294417e5-de4a-4645-8a2c-61a3c38c70f3"), (short)5, "Course166", new Guid("cf575b9b-0435-4db6-8a44-045bc22e6c3f"), new Guid("d45a85ca-e996-416a-b2d8-606426c8a15a") },
                    { new Guid("13f9f809-1770-4bf6-ae07-05152fe26020"), (short)4, "Course75", new Guid("bd932240-c2f0-4585-ae4b-578c673c95ee"), new Guid("92b3dc88-fead-4a45-aba3-4aeae5dbec80") },
                    { new Guid("ddd4ddc0-27cd-420e-8b1b-513fcbb957bf"), (short)3, "Course0", new Guid("bd932240-c2f0-4585-ae4b-578c673c95ee"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("a8cd9dbc-2bb3-4f1b-bed3-3a5b843bcade"), (short)0, "Course0", new Guid("9b2071c3-7203-448b-ad6e-ae00e1161995"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("15766f69-08a3-4b77-99d4-1a4a2934fb7d"), (short)4, "Course0", new Guid("ec58bf3c-46fa-42a7-a277-e789f35aa6bd"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("3248d46e-cd0b-47fe-9ae4-36ebac0b1caa"), (short)4, "Course67", new Guid("ec58bf3c-46fa-42a7-a277-e789f35aa6bd"), new Guid("4a2d65f4-7aa3-4350-83f3-35994bbcb0d9") },
                    { new Guid("e3f1d57d-b5ae-43d1-99ca-239f005710a5"), (short)0, "Course134", new Guid("ec58bf3c-46fa-42a7-a277-e789f35aa6bd"), new Guid("0fd529d1-e3e2-47c5-b856-7aba08cbbbf0") },
                    { new Guid("a1ffd8d2-c304-4dfe-874b-a58f5acaeb38"), (short)5, "Course201", new Guid("ec58bf3c-46fa-42a7-a277-e789f35aa6bd"), new Guid("c1ca1d9c-52aa-4c4f-a70a-268d06835428") },
                    { new Guid("519202c6-ddf9-44bb-84d4-3d46978d0e40"), (short)2, "Course268", new Guid("ec58bf3c-46fa-42a7-a277-e789f35aa6bd"), new Guid("4bc31229-4343-493d-94ba-f19b12c1369e") },
                    { new Guid("0455fb1c-5496-4dae-805d-c1cd10c1d7c0"), (short)3, "Course335", new Guid("ec58bf3c-46fa-42a7-a277-e789f35aa6bd"), new Guid("5e08f64f-4cf8-4a4f-8b01-640e5291e9ba") },
                    { new Guid("d0784b1e-79b0-4f25-a031-790d312995b3"), (short)3, "Course0", new Guid("260a5d56-6f38-43ee-b545-33dd4f88cccc"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("f1a4722d-2eec-4b06-8422-d65681b1780f"), (short)0, "Course68", new Guid("260a5d56-6f38-43ee-b545-33dd4f88cccc"), new Guid("4bc31229-4343-493d-94ba-f19b12c1369e") },
                    { new Guid("f245eb71-e59c-48d6-b2ec-f9b6edc4e63f"), (short)4, "Course136", new Guid("260a5d56-6f38-43ee-b545-33dd4f88cccc"), new Guid("3f76ac73-0ba7-4d6a-ab40-bc387998856f") },
                    { new Guid("7f461a6b-ddd8-4df5-902d-7ae548ba1b2f"), (short)1, "Course204", new Guid("260a5d56-6f38-43ee-b545-33dd4f88cccc"), new Guid("b525ecf2-7acd-47bd-87ae-5309b598ee56") },
                    { new Guid("72d2e178-7500-4fd7-83ba-e8f96b4b25ac"), (short)5, "Course272", new Guid("260a5d56-6f38-43ee-b545-33dd4f88cccc"), new Guid("ed1486d0-4af1-449f-882e-93b5bc021952") },
                    { new Guid("d58f7adf-10d5-446d-a8f6-4a574b8a8ca8"), (short)2, "Course340", new Guid("260a5d56-6f38-43ee-b545-33dd4f88cccc"), new Guid("057dfd7c-e065-4359-ad7d-4f9203a48204") },
                    { new Guid("5c7a50da-d7d2-4780-8ad6-33af15b90e9d"), (short)3, "Course450", new Guid("c91be2e9-073d-4b39-b2f8-cd198dcf81a8"), new Guid("a6a34e96-0ca8-49d8-a157-d49457805cae") },
                    { new Guid("b4237380-3c41-48d0-8d60-0757fe59eff6"), (short)2, "Course360", new Guid("c91be2e9-073d-4b39-b2f8-cd198dcf81a8"), new Guid("b7e178a9-8cfe-4c9c-aeab-dc77f9f2de35") },
                    { new Guid("7f73b02b-4ed9-4d04-9a7a-4331a11bc938"), (short)5, "Course0", new Guid("31d1d97d-2694-4cdf-a1d5-0c3e386f072a"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("b2c3bb4a-930a-4922-92ec-e551967a077a"), (short)2, "Course69", new Guid("31d1d97d-2694-4cdf-a1d5-0c3e386f072a"), new Guid("8a4e5172-587a-4f9a-a024-fa1a78aac605") },
                    { new Guid("08d35d58-70d5-4f31-964a-3ee0a15db0e2"), (short)4, "Course138", new Guid("31d1d97d-2694-4cdf-a1d5-0c3e386f072a"), new Guid("64f7e86e-e102-4040-acc2-89d5c9c06788") },
                    { new Guid("89b95a10-ab21-4cc2-b153-9136602a865a"), (short)0, "Course0", new Guid("0cba8627-2e00-41e4-8e20-0a77842874ee"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("40308dd5-ef35-4fbc-9aab-22140da11a52"), (short)2, "Course207", new Guid("31d1d97d-2694-4cdf-a1d5-0c3e386f072a"), new Guid("5a91c10d-b6e0-4886-9ff9-10107fcb6761") },
                    { new Guid("a9c1e94d-bed1-410c-92c5-5d2c8b6f6502"), (short)1, "Course91", new Guid("0cba8627-2e00-41e4-8e20-0a77842874ee"), new Guid("1e35327d-ef8b-4490-bfda-21a7cd39cdd0") },
                    { new Guid("5896c2bf-2ece-4399-b1e3-c1e05ab16e1f"), (short)3, "Course264", new Guid("95bef003-e624-4a2c-b353-abd991f97c9d"), new Guid("c8258a3d-48f8-4eac-b14e-18ced7b5618e") },
                    { new Guid("0673071c-42e0-4bf8-9f20-74f96f9e8fb3"), (short)1, "Course192", new Guid("369aba17-6ac2-4c10-9f1a-110ca5d4fa3c"), new Guid("ce390f41-873c-453d-9f08-1266e2189587") },
                    { new Guid("17a802b9-bdfb-4d30-9100-ea686614d6e1"), (short)3, "Course256", new Guid("369aba17-6ac2-4c10-9f1a-110ca5d4fa3c"), new Guid("0a2bec6b-65e9-4c34-8fa8-eb3a98e94d6c") },
                    { new Guid("616453d8-f1a5-45ec-a071-9df534aa7d69"), (short)3, "Course320", new Guid("369aba17-6ac2-4c10-9f1a-110ca5d4fa3c"), new Guid("a188125a-5041-418b-ac92-5303ce6e8a12") },
                    { new Guid("8a72f886-4f19-418d-b0b6-0b0dc00a4fa2"), (short)4, "Course455", new Guid("0cba8627-2e00-41e4-8e20-0a77842874ee"), new Guid("3789d0c1-a469-45be-ae4a-383778d9e884") },
                    { new Guid("4ebc4d3f-db6f-4c0d-bbd3-273f8f2375c8"), (short)2, "Course364", new Guid("0cba8627-2e00-41e4-8e20-0a77842874ee"), new Guid("c8258a3d-48f8-4eac-b14e-18ced7b5618e") },
                    { new Guid("6bcd6059-ba07-4b45-9b2f-49b8f6860cb3"), (short)2, "Course0", new Guid("edfe5fec-2e28-470d-a752-528e295a7a1d"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("7853c0b3-8530-4765-8eb4-ad6caac8c45b"), (short)4, "Course65", new Guid("edfe5fec-2e28-470d-a752-528e295a7a1d"), new Guid("71fbe949-8b66-4ee4-b52b-3c5370663ef6") },
                    { new Guid("f64c8751-b620-4c09-b856-403d3af2b2b4"), (short)5, "Course130", new Guid("edfe5fec-2e28-470d-a752-528e295a7a1d"), new Guid("3c7e6dc1-9f2d-42d3-9e4d-e2431a493beb") },
                    { new Guid("f8c6d9d2-c2b5-4dde-a2a7-0a5fabdd8062"), (short)2, "Course195", new Guid("edfe5fec-2e28-470d-a752-528e295a7a1d"), new Guid("5d1d8f68-958b-4b72-a3d9-ab026d6c9b3b") },
                    { new Guid("9fe2e0ac-f4b8-4910-9783-8194c5bedda6"), (short)2, "Course260", new Guid("edfe5fec-2e28-470d-a752-528e295a7a1d"), new Guid("b7e178a9-8cfe-4c9c-aeab-dc77f9f2de35") },
                    { new Guid("0d3e16bb-a244-4681-a12e-c70e239e7bb2"), (short)0, "Course325", new Guid("edfe5fec-2e28-470d-a752-528e295a7a1d"), new Guid("6985d0e1-cd88-42c9-814a-158b42abd6d6") },
                    { new Guid("5e9a9fa0-1ad4-42df-8116-cbfb2ef803d9"), (short)3, "Course273", new Guid("0cba8627-2e00-41e4-8e20-0a77842874ee"), new Guid("d9de457e-9281-402d-98fd-7d467de2be83") },
                    { new Guid("51ad2e5d-581d-4f9e-b0b5-32ad8241e436"), (short)3, "Course182", new Guid("0cba8627-2e00-41e4-8e20-0a77842874ee"), new Guid("0529f9b9-58d2-4049-ad74-15f95b12b9cf") },
                    { new Guid("4c2b97d8-a26a-46e3-a0dc-2675dca254f0"), (short)2, "Course0", new Guid("95bef003-e624-4a2c-b353-abd991f97c9d"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("688ad508-4b4f-46e1-b539-3bee33b600bb"), (short)2, "Course66", new Guid("95bef003-e624-4a2c-b353-abd991f97c9d"), new Guid("d45a85ca-e996-416a-b2d8-606426c8a15a") },
                    { new Guid("ba1c2c78-99af-411f-b418-2fb39a818002"), (short)0, "Course132", new Guid("95bef003-e624-4a2c-b353-abd991f97c9d"), new Guid("d27b117a-d80a-4155-8dfa-522f22cd4429") },
                    { new Guid("3cbb61d6-5ae3-4d04-872e-b590f931198d"), (short)2, "Course198", new Guid("95bef003-e624-4a2c-b353-abd991f97c9d"), new Guid("7ad86313-7bbc-4d7f-899c-86985ce8b6ab") },
                    { new Guid("64354108-924c-41e0-a03c-f4cd4a896d5b"), (short)0, "Course330", new Guid("95bef003-e624-4a2c-b353-abd991f97c9d"), new Guid("3c7e6dc1-9f2d-42d3-9e4d-e2431a493beb") },
                    { new Guid("e3570759-e882-4169-9881-408eef4775fe"), (short)2, "Course64", new Guid("369aba17-6ac2-4c10-9f1a-110ca5d4fa3c"), new Guid("c8258a3d-48f8-4eac-b14e-18ced7b5618e") },
                    { new Guid("6a07fbfc-084c-41bb-85be-e7ceeda9bfa8"), (short)3, "Course276", new Guid("31d1d97d-2694-4cdf-a1d5-0c3e386f072a"), new Guid("a906fee8-00ee-4be0-aa58-fc3469ded86a") },
                    { new Guid("20f457ce-dc91-4942-b7a5-79d8af718721"), (short)2, "Course270", new Guid("c91be2e9-073d-4b39-b2f8-cd198dcf81a8"), new Guid("a07c095e-f185-4765-958b-121530f33152") },
                    { new Guid("6e9af919-3281-4afd-8c75-8d7eb3282cfd"), (short)0, "Course445", new Guid("9b2071c3-7203-448b-ad6e-ae00e1161995"), new Guid("2a164668-67e3-4a12-b8a1-af89e56f1a14") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("18c36c36-6690-4b86-ae61-79c81e169a48"), (short)5, "Course356", new Guid("9b2071c3-7203-448b-ad6e-ae00e1161995"), new Guid("0a2bec6b-65e9-4c34-8fa8-eb3a98e94d6c") },
                    { new Guid("e15b4075-8d20-47bd-9068-e7e7817ea3ab"), (short)5, "Course0", new Guid("f3acc840-3869-4c6c-9089-368d02fa3f8e"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("fab9ae04-09f5-4010-ab09-b3d8a6d71a07"), (short)2, "Course73", new Guid("f3acc840-3869-4c6c-9089-368d02fa3f8e"), new Guid("d9de457e-9281-402d-98fd-7d467de2be83") },
                    { new Guid("d7d8fece-4b90-4128-ae0e-abb50cc4091d"), (short)1, "Course146", new Guid("f3acc840-3869-4c6c-9089-368d02fa3f8e"), new Guid("501d7bb4-8a43-4591-ba6f-19ea8a68a32d") },
                    { new Guid("6fbc9eb5-537e-42dd-8cab-c23422ccb90d"), (short)2, "Course219", new Guid("f3acc840-3869-4c6c-9089-368d02fa3f8e"), new Guid("86902e3d-1f5b-4abe-9ab7-3fd73dd5ab90") },
                    { new Guid("2295c625-ce40-4e59-a5ad-169468f77029"), (short)3, "Course292", new Guid("f3acc840-3869-4c6c-9089-368d02fa3f8e"), new Guid("ce390f41-873c-453d-9f08-1266e2189587") },
                    { new Guid("2c375c1d-0180-4059-a9bc-fb1c4ff9748e"), (short)5, "Course365", new Guid("f3acc840-3869-4c6c-9089-368d02fa3f8e"), new Guid("71fbe949-8b66-4ee4-b52b-3c5370663ef6") },
                    { new Guid("6ee92d81-e7be-41dc-8091-d7a3e8c00da0"), (short)4, "Course267", new Guid("9b2071c3-7203-448b-ad6e-ae00e1161995"), new Guid("4a2d65f4-7aa3-4350-83f3-35994bbcb0d9") },
                    { new Guid("622ab60e-754e-4e51-aeff-5a837167ac1c"), (short)2, "Course178", new Guid("9b2071c3-7203-448b-ad6e-ae00e1161995"), new Guid("2d18691c-989d-416d-a354-29be08ce9df1") },
                    { new Guid("eda7bf35-97cb-4193-939f-e0ba972c94b4"), (short)1, "Course0", new Guid("35c1baf9-0879-40b6-b538-5b59f815e8c2"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("7577d201-1034-41c2-9004-24a04b32180f"), (short)2, "Course74", new Guid("35c1baf9-0879-40b6-b538-5b59f815e8c2"), new Guid("c4a5a9d7-7554-4f06-9602-178bba9fb90f") },
                    { new Guid("4e565a0f-d8cf-41a1-ae04-0cb8e53098e4"), (short)4, "Course148", new Guid("35c1baf9-0879-40b6-b538-5b59f815e8c2"), new Guid("adbec3db-e798-4b59-a8a1-3ef0c251f642") },
                    { new Guid("007e6d35-4f05-4ca8-8132-b232afa5accf"), (short)5, "Course222", new Guid("35c1baf9-0879-40b6-b538-5b59f815e8c2"), new Guid("69f353ab-b263-41df-ad3e-e3fb8493d9ac") },
                    { new Guid("f5c0eafc-b488-4863-92b2-16512b43f1ff"), (short)1, "Course296", new Guid("35c1baf9-0879-40b6-b538-5b59f815e8c2"), new Guid("77abbb72-1f82-42ba-8f26-b31bc1a26767") },
                    { new Guid("c7a2955d-6ea3-4aa5-b899-f4944c5dd86a"), (short)1, "Course370", new Guid("35c1baf9-0879-40b6-b538-5b59f815e8c2"), new Guid("a07c095e-f185-4765-958b-121530f33152") },
                    { new Guid("0d94986c-0b4c-40c2-9897-26281f4ec345"), (short)2, "Course89", new Guid("9b2071c3-7203-448b-ad6e-ae00e1161995"), new Guid("4161656d-8fe1-4a17-915a-7ff4d8343cc3") },
                    { new Guid("982ae7b6-de59-49c6-943c-8406da3de268"), (short)5, "Course360", new Guid("6b107f46-46e2-4aca-ae01-a384b0d64a00"), new Guid("b7e178a9-8cfe-4c9c-aeab-dc77f9f2de35") },
                    { new Guid("76be04ab-c335-439f-afe7-654aeb7d8629"), (short)5, "Course345", new Guid("31d1d97d-2694-4cdf-a1d5-0c3e386f072a"), new Guid("2a164668-67e3-4a12-b8a1-af89e56f1a14") },
                    { new Guid("359ed248-070d-4741-9c22-b17cf595a1a2"), (short)5, "Course288", new Guid("6b107f46-46e2-4aca-ae01-a384b0d64a00"), new Guid("e6b51413-4b52-4843-85a2-78ed2c0eea2f") },
                    { new Guid("5f43b2bb-9e64-4d0b-9154-5b1306497e80"), (short)2, "Course144", new Guid("6b107f46-46e2-4aca-ae01-a384b0d64a00"), new Guid("0fe90da4-1897-46a6-a2e8-5326e2ad84d8") },
                    { new Guid("b1f42124-6889-4420-bcfe-da8c0a7fb42f"), (short)4, "Course180", new Guid("c91be2e9-073d-4b39-b2f8-cd198dcf81a8"), new Guid("0f3a6be6-d338-4180-9f66-12eea50cc59b") },
                    { new Guid("16be51c9-6914-4f5d-a406-a03faede4fe4"), (short)3, "Course0", new Guid("8da7984a-6afa-45f0-87ac-36aa60384975"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("a83afa3c-fb1d-40a8-8334-6e8e4f7e40a7"), (short)2, "Course70", new Guid("8da7984a-6afa-45f0-87ac-36aa60384975"), new Guid("a07c095e-f185-4765-958b-121530f33152") },
                    { new Guid("8eed58b1-acb0-472c-823c-91e0139653eb"), (short)4, "Course140", new Guid("8da7984a-6afa-45f0-87ac-36aa60384975"), new Guid("057dfd7c-e065-4359-ad7d-4f9203a48204") },
                    { new Guid("3912cdef-a98e-4514-8f4e-b668aacfeda4"), (short)2, "Course210", new Guid("8da7984a-6afa-45f0-87ac-36aa60384975"), new Guid("13204af6-237b-4597-bb1a-c82c23c09636") },
                    { new Guid("436b6894-1d08-42c3-a71d-256dccc5b76b"), (short)0, "Course280", new Guid("8da7984a-6afa-45f0-87ac-36aa60384975"), new Guid("0f3a6be6-d338-4180-9f66-12eea50cc59b") },
                    { new Guid("314791d5-56df-402d-add4-10d939f7dfb7"), (short)1, "Course350", new Guid("8da7984a-6afa-45f0-87ac-36aa60384975"), new Guid("a6a34e96-0ca8-49d8-a157-d49457805cae") },
                    { new Guid("aab0ea3c-86e0-4ac8-930a-5da16d48ca82"), (short)5, "Course90", new Guid("c91be2e9-073d-4b39-b2f8-cd198dcf81a8"), new Guid("d3e32fcf-a08d-4708-8b06-0d1ea51a808f") },
                    { new Guid("0f2606a3-92b6-45c6-b3cd-25ecb350ae24"), (short)0, "Course0", new Guid("c91be2e9-073d-4b39-b2f8-cd198dcf81a8"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("e96b18bc-2efd-4bde-af4b-98b724a18268"), (short)3, "Course0", new Guid("4833707f-1cef-4669-97ab-ddded2a3422a"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("946ce606-b85a-4470-afb3-bdb3a32430ee"), (short)1, "Course71", new Guid("4833707f-1cef-4669-97ab-ddded2a3422a"), new Guid("70ebd0f8-7890-43df-9cce-ceeabc3afca3") },
                    { new Guid("ad3c678a-9c72-4cc1-8fc1-87d7248fc06f"), (short)1, "Course142", new Guid("4833707f-1cef-4669-97ab-ddded2a3422a"), new Guid("6cc73e31-6f80-4272-82bf-eb0a1325aeb4") },
                    { new Guid("2c8abad7-175c-4115-bedb-ba761e7b9f29"), (short)5, "Course213", new Guid("4833707f-1cef-4669-97ab-ddded2a3422a"), new Guid("18ada024-e7e8-40f8-98c2-7f773bbbb751") },
                    { new Guid("5d6f99c6-0bdd-449c-8369-ccd84c0e1020"), (short)1, "Course284", new Guid("4833707f-1cef-4669-97ab-ddded2a3422a"), new Guid("07ed323a-f925-4a9a-bcfa-cbfa4333a7b1") },
                    { new Guid("356933dc-f1d4-42c2-8bb7-183d0cbe7bbc"), (short)2, "Course355", new Guid("4833707f-1cef-4669-97ab-ddded2a3422a"), new Guid("3789d0c1-a469-45be-ae4a-383778d9e884") },
                    { new Guid("77967f07-80c6-4506-878e-0c7f36bc293b"), (short)5, "Course0", new Guid("6b107f46-46e2-4aca-ae01-a384b0d64a00"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("85003e42-0aed-4510-86ec-5e80363a8ed0"), (short)3, "Course72", new Guid("6b107f46-46e2-4aca-ae01-a384b0d64a00"), new Guid("ed1486d0-4af1-449f-882e-93b5bc021952") },
                    { new Guid("b2bef5bd-7e7a-4d16-b9bd-03066f6ff6d1"), (short)4, "Course216", new Guid("6b107f46-46e2-4aca-ae01-a384b0d64a00"), new Guid("8d205a81-e2bc-4419-9b80-76829198e56a") },
                    { new Guid("f2a4b74f-7c65-4a0d-9f2a-00d20dcaa3e4"), (short)2, "Course291", new Guid("948db04e-01cc-4694-95d2-63fa40172191"), new Guid("1e35327d-ef8b-4490-bfda-21a7cd39cdd0") },
                    { new Guid("6d40986d-165a-406d-b414-3c5322f79f2b"), (short)5, "Course0", new Guid("b72b47d3-75c7-4543-9afc-5fd2000145d5"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("48c67327-be38-4c0a-81ff-3373365beda7"), (short)0, "Course164", new Guid("b51bbea9-0afd-4738-a071-5a774b889837"), new Guid("c8258a3d-48f8-4eac-b14e-18ced7b5618e") },
                    { new Guid("40de9b4c-0219-4a99-abb5-88f6edac0c04"), (short)1, "Course0", new Guid("04f1be8e-ccc0-41e3-921a-71f2e2915a29"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("eadf8717-ea95-4752-bda3-f959c04d050b"), (short)5, "Course14", new Guid("04f1be8e-ccc0-41e3-921a-71f2e2915a29"), new Guid("5eb8b880-4da8-4c05-9c7b-0e9c25dc8cac") },
                    { new Guid("2e5c15af-3ab3-4de1-8abf-21588152d994"), (short)3, "Course28", new Guid("04f1be8e-ccc0-41e3-921a-71f2e2915a29"), new Guid("a60a1d7e-06fa-458f-8a6b-5665cb75fb3c") },
                    { new Guid("b42bcd03-18ef-4ad9-a031-7020ef62ded0"), (short)5, "Course42", new Guid("04f1be8e-ccc0-41e3-921a-71f2e2915a29"), new Guid("6cc73e31-6f80-4272-82bf-eb0a1325aeb4") },
                    { new Guid("6196e23c-b8bb-4723-8f9d-6d2e76ff2526"), (short)2, "Course56", new Guid("04f1be8e-ccc0-41e3-921a-71f2e2915a29"), new Guid("0a2bec6b-65e9-4c34-8fa8-eb3a98e94d6c") },
                    { new Guid("f28de44d-f1cf-43e2-8660-0c0930aa1f32"), (short)4, "Course70", new Guid("04f1be8e-ccc0-41e3-921a-71f2e2915a29"), new Guid("a07c095e-f185-4765-958b-121530f33152") },
                    { new Guid("e6a2ae49-a12d-4100-9bb0-aadf0e84f1b0"), (short)0, "Course104", new Guid("be0461b9-8bf4-429e-a034-39a1ae1f0265"), new Guid("b525ecf2-7acd-47bd-87ae-5309b598ee56") },
                    { new Guid("bb21e2a0-c8d5-4a94-922a-11754e639548"), (short)2, "Course0", new Guid("be0461b9-8bf4-429e-a034-39a1ae1f0265"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("6b51dec6-5424-4821-8521-289b9b70417d"), (short)4, "Course0", new Guid("bdd6e79a-ad46-491c-8b58-e72975ac7f04"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("53d6f876-d1db-415d-9f26-38f7f8fe0578"), (short)2, "Course15", new Guid("bdd6e79a-ad46-491c-8b58-e72975ac7f04"), new Guid("ec29cecf-9bb4-4b00-9d9a-5d0ccad64829") },
                    { new Guid("be040d87-09f1-4a18-9165-6f8b2e4a0ca3"), (short)2, "Course30", new Guid("bdd6e79a-ad46-491c-8b58-e72975ac7f04"), new Guid("3c7e6dc1-9f2d-42d3-9e4d-e2431a493beb") },
                    { new Guid("75b51f2c-9f2a-41bb-b964-30dcc96d54c5"), (short)1, "Course45", new Guid("bdd6e79a-ad46-491c-8b58-e72975ac7f04"), new Guid("2a164668-67e3-4a12-b8a1-af89e56f1a14") },
                    { new Guid("d9220708-0c4d-42db-9afc-e429118ccd3a"), (short)0, "Course60", new Guid("bdd6e79a-ad46-491c-8b58-e72975ac7f04"), new Guid("b7e178a9-8cfe-4c9c-aeab-dc77f9f2de35") },
                    { new Guid("b5c5ead0-de84-49f2-8398-9a18da2ac437"), (short)2, "Course75", new Guid("bdd6e79a-ad46-491c-8b58-e72975ac7f04"), new Guid("92b3dc88-fead-4a45-aba3-4aeae5dbec80") },
                    { new Guid("40c3efeb-638f-46fe-9e38-79ba2e5ebe08"), (short)3, "Course0", new Guid("ff4bb88a-b6d6-4256-9ea0-fe93fcd9697c"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("5838fcb5-b91c-4d8c-91da-2d757f8a71dc"), (short)2, "Course16", new Guid("ff4bb88a-b6d6-4256-9ea0-fe93fcd9697c"), new Guid("8d205a81-e2bc-4419-9b80-76829198e56a") },
                    { new Guid("15b377b8-d612-4a39-8fa9-d8ca79cf4730"), (short)1, "Course32", new Guid("ff4bb88a-b6d6-4256-9ea0-fe93fcd9697c"), new Guid("d27b117a-d80a-4155-8dfa-522f22cd4429") },
                    { new Guid("6b06b1bf-5098-4105-b3f1-88799f65444c"), (short)1, "Course208", new Guid("be0461b9-8bf4-429e-a034-39a1ae1f0265"), new Guid("ebeffb2e-3a83-47bf-b89a-f738c8edc152") },
                    { new Guid("31bdb089-e722-4eb8-9a2e-a76ce5f433b6"), (short)5, "Course48", new Guid("ff4bb88a-b6d6-4256-9ea0-fe93fcd9697c"), new Guid("adbec3db-e798-4b59-a8a1-3ef0c251f642") },
                    { new Guid("0d764709-5151-49bd-a19b-62c614ca7bf2"), (short)5, "Course312", new Guid("be0461b9-8bf4-429e-a034-39a1ae1f0265"), new Guid("063abe97-7452-429b-8088-ae02501cf52a") },
                    { new Guid("b7ca7ecd-58a1-4a1c-9173-4c6ebd7a3934"), (short)5, "Course52", new Guid("46f266a3-7b60-4d2f-ba82-d0a00be6b470"), new Guid("a5da19b2-60d3-4a47-aa17-6a9bb34f6923") },
                    { new Guid("985f8adc-fef6-4a50-89b6-055a914a82e8"), (short)5, "Course11", new Guid("2c6cd864-2fe9-42c7-8bfe-8f7489e5810f"), new Guid("86828be7-9d59-413e-8b29-4318311399e4") },
                    { new Guid("2023a9e0-8b1b-4783-b90e-f21bc572062d"), (short)5, "Course22", new Guid("2c6cd864-2fe9-42c7-8bfe-8f7489e5810f"), new Guid("69f353ab-b263-41df-ad3e-e3fb8493d9ac") },
                    { new Guid("9371f1fb-7741-41dc-8466-bb13d700e5b0"), (short)0, "Course33", new Guid("2c6cd864-2fe9-42c7-8bfe-8f7489e5810f"), new Guid("c0b88834-6a9a-4c54-9efd-9eba8cba2b31") },
                    { new Guid("29b45711-b4a0-49ba-8779-ad0dc5a92c66"), (short)3, "Course44", new Guid("2c6cd864-2fe9-42c7-8bfe-8f7489e5810f"), new Guid("0fe90da4-1897-46a6-a2e8-5326e2ad84d8") },
                    { new Guid("82c6714b-3fda-4e27-96d7-4e28a35f18cc"), (short)4, "Course55", new Guid("2c6cd864-2fe9-42c7-8bfe-8f7489e5810f"), new Guid("3789d0c1-a469-45be-ae4a-383778d9e884") },
                    { new Guid("8aa6ebb1-2f92-4777-a890-53b848af5fba"), (short)1, "Course0", new Guid("d8cda68e-9336-4490-8716-b0196825807a"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("39e2c378-f6f8-4a62-b88f-595c9fc76e2e"), (short)0, "Course12", new Guid("d8cda68e-9336-4490-8716-b0196825807a"), new Guid("063abe97-7452-429b-8088-ae02501cf52a") },
                    { new Guid("6948d661-cc56-43d1-8dbd-cf5d89ea7f5b"), (short)1, "Course24", new Guid("d8cda68e-9336-4490-8716-b0196825807a"), new Guid("d8ddd747-6d87-410d-bf56-417d725c9a22") },
                    { new Guid("f765ea59-2208-4a55-9752-1fa5479fd769"), (short)3, "Course36", new Guid("d8cda68e-9336-4490-8716-b0196825807a"), new Guid("3f76ac73-0ba7-4d6a-ab40-bc387998856f") },
                    { new Guid("8749769e-a8e8-48a3-8ce3-dd6daf713690"), (short)5, "Course48", new Guid("d8cda68e-9336-4490-8716-b0196825807a"), new Guid("adbec3db-e798-4b59-a8a1-3ef0c251f642") },
                    { new Guid("03cf222e-fa09-4703-85b6-30d8e3303338"), (short)3, "Course60", new Guid("d8cda68e-9336-4490-8716-b0196825807a"), new Guid("b7e178a9-8cfe-4c9c-aeab-dc77f9f2de35") },
                    { new Guid("6bec9212-8ebd-40e8-9dcf-57ef570a4211"), (short)4, "Course520", new Guid("be0461b9-8bf4-429e-a034-39a1ae1f0265"), new Guid("a188125a-5041-418b-ac92-5303ce6e8a12") },
                    { new Guid("3fb2ba52-d350-4578-976d-8cf26e53ac34"), (short)2, "Course416", new Guid("be0461b9-8bf4-429e-a034-39a1ae1f0265"), new Guid("8d205a81-e2bc-4419-9b80-76829198e56a") },
                    { new Guid("4ad53a1b-a0fc-46cb-9f0a-542347a3eed3"), (short)5, "Course0", new Guid("46f266a3-7b60-4d2f-ba82-d0a00be6b470"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("0827d681-f748-4b3c-9f75-0a6ed1c3a709"), (short)2, "Course13", new Guid("46f266a3-7b60-4d2f-ba82-d0a00be6b470"), new Guid("18ada024-e7e8-40f8-98c2-7f773bbbb751") },
                    { new Guid("4c514f58-5b6a-4f30-bacc-f1d9755d89c2"), (short)3, "Course26", new Guid("46f266a3-7b60-4d2f-ba82-d0a00be6b470"), new Guid("ba0e5c03-6f8b-4477-9e10-0a882b4c3832") },
                    { new Guid("345d993a-4ce3-4d10-9a46-c5b37c0a2bbc"), (short)4, "Course39", new Guid("46f266a3-7b60-4d2f-ba82-d0a00be6b470"), new Guid("7c3a81a4-266d-4f0c-b73a-38e6d61e9622") },
                    { new Guid("47259ba7-648f-48f1-af68-c15636d5ea13"), (short)5, "Course65", new Guid("46f266a3-7b60-4d2f-ba82-d0a00be6b470"), new Guid("71fbe949-8b66-4ee4-b52b-3c5370663ef6") },
                    { new Guid("9df76eea-54f8-4eba-85c8-b55fe4d60440"), (short)1, "Course0", new Guid("2c6cd864-2fe9-42c7-8bfe-8f7489e5810f"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("56fb3591-feb2-48b1-9dc0-e90f0e692571"), (short)0, "Course64", new Guid("ff4bb88a-b6d6-4256-9ea0-fe93fcd9697c"), new Guid("c8258a3d-48f8-4eac-b14e-18ced7b5618e") },
                    { new Guid("633ef101-2a4b-4a50-a131-f78f48b21ad8"), (short)2, "Course515", new Guid("e62a2052-e393-49dd-8dda-5f1977a279c0"), new Guid("ec29cecf-9bb4-4b00-9d9a-5d0ccad64829") },
                    { new Guid("de6a9e73-94a2-46ea-82b9-7c90f3b5818f"), (short)5, "Course76", new Guid("6dd9c059-e6f3-4116-b9ab-47f8c0f60c1d"), new Guid("a906fee8-00ee-4be0-aa58-fc3469ded86a") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("ff335baa-aa47-4be2-97e8-123444202781"), (short)1, "Course95", new Guid("6dd9c059-e6f3-4116-b9ab-47f8c0f60c1d"), new Guid("5d1d8f68-958b-4b72-a3d9-ab026d6c9b3b") },
                    { new Guid("d2795874-8cbf-4b8b-b718-7b7139403c88"), (short)5, "Course0", new Guid("e2237afc-8e86-4571-afa7-b3741418bc38"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("579ca7a8-d9a1-49dc-abba-8b936f2329e3"), (short)5, "Course20", new Guid("e2237afc-8e86-4571-afa7-b3741418bc38"), new Guid("a188125a-5041-418b-ac92-5303ce6e8a12") },
                    { new Guid("32dbe609-e232-4655-8efb-381301b2e5ce"), (short)2, "Course40", new Guid("e2237afc-8e86-4571-afa7-b3741418bc38"), new Guid("057dfd7c-e065-4359-ad7d-4f9203a48204") },
                    { new Guid("6fb68be4-6e1e-4a7a-8587-aaa035da0e95"), (short)0, "Course60", new Guid("e2237afc-8e86-4571-afa7-b3741418bc38"), new Guid("b7e178a9-8cfe-4c9c-aeab-dc77f9f2de35") },
                    { new Guid("8506cae1-74a2-4503-83a6-ed3f4ad9ccae"), (short)0, "Course80", new Guid("e2237afc-8e86-4571-afa7-b3741418bc38"), new Guid("0f3a6be6-d338-4180-9f66-12eea50cc59b") },
                    { new Guid("46514450-d3b1-42f6-9430-f134e85c71d3"), (short)2, "Course100", new Guid("e2237afc-8e86-4571-afa7-b3741418bc38"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("b3b0f3aa-4845-4043-a143-9f1080a1e5e4"), (short)1, "Course510", new Guid("b1e1b13b-1c0d-4530-a1f5-763d76c7a8ca"), new Guid("13204af6-237b-4597-bb1a-c82c23c09636") },
                    { new Guid("8d13bdac-a152-4e38-8018-162be3585c3b"), (short)0, "Course205", new Guid("b51bbea9-0afd-4738-a071-5a774b889837"), new Guid("4769333d-bd39-4438-862b-97f82854efd1") },
                    { new Guid("98ce1ac4-878b-455d-925b-9cfeb498ed55"), (short)4, "Course408", new Guid("b1e1b13b-1c0d-4530-a1f5-763d76c7a8ca"), new Guid("ebeffb2e-3a83-47bf-b89a-f738c8edc152") },
                    { new Guid("1fa4e2cd-5b36-4b49-a4ec-96819b58d9d7"), (short)0, "Course0", new Guid("ce35b0a1-60a7-4966-892e-ce9b859e0585"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("ae300d87-929a-49d9-b72e-2661bb1316a1"), (short)3, "Course21", new Guid("ce35b0a1-60a7-4966-892e-ce9b859e0585"), new Guid("88cd051e-9532-48bd-813a-11525e0bc1af") },
                    { new Guid("c7ffbe1d-ad60-450a-810b-4f7655b14a1a"), (short)1, "Course42", new Guid("ce35b0a1-60a7-4966-892e-ce9b859e0585"), new Guid("6cc73e31-6f80-4272-82bf-eb0a1325aeb4") },
                    { new Guid("6303e49d-84ad-49e9-9098-7238a6fd37b5"), (short)5, "Course63", new Guid("ce35b0a1-60a7-4966-892e-ce9b859e0585"), new Guid("105a879d-9688-41fc-85f0-a8743376ac65") },
                    { new Guid("c5e60685-ddc7-4d45-b493-d46ab65fe934"), (short)2, "Course84", new Guid("ce35b0a1-60a7-4966-892e-ce9b859e0585"), new Guid("07ed323a-f925-4a9a-bcfa-cbfa4333a7b1") },
                    { new Guid("48314dda-4d63-4c8c-8d01-90afb0b29026"), (short)2, "Course105", new Guid("ce35b0a1-60a7-4966-892e-ce9b859e0585"), new Guid("4769333d-bd39-4438-862b-97f82854efd1") },
                    { new Guid("2f42ff20-2375-41d1-9b0b-34146fa21a9c"), (short)5, "Course57", new Guid("6dd9c059-e6f3-4116-b9ab-47f8c0f60c1d"), new Guid("00539901-185f-4490-9481-1d072c53c697") },
                    { new Guid("eff29481-ddd8-42f6-848d-5fb7be499893"), (short)1, "Course80", new Guid("ff4bb88a-b6d6-4256-9ea0-fe93fcd9697c"), new Guid("0f3a6be6-d338-4180-9f66-12eea50cc59b") },
                    { new Guid("ab87b95a-1b4e-407e-a01e-fd1a9362e917"), (short)1, "Course38", new Guid("6dd9c059-e6f3-4116-b9ab-47f8c0f60c1d"), new Guid("64f7e86e-e102-4040-acc2-89d5c9c06788") },
                    { new Guid("1fb59f37-8a6d-4943-a5f4-dde7f2c9901f"), (short)4, "Course0", new Guid("6dd9c059-e6f3-4116-b9ab-47f8c0f60c1d"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("4f4c1535-9138-4902-80aa-0316704da911"), (short)4, "Course412", new Guid("e62a2052-e393-49dd-8dda-5f1977a279c0"), new Guid("063abe97-7452-429b-8088-ae02501cf52a") },
                    { new Guid("9932f76d-f52b-48d2-877c-3622af7a7919"), (short)2, "Course0", new Guid("077719f8-99b6-44d7-8e24-56e22f03f4f6"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("cdaf69cf-dbcc-443d-b32a-d0529ecf7af9"), (short)4, "Course17", new Guid("077719f8-99b6-44d7-8e24-56e22f03f4f6"), new Guid("a62b56c5-0991-4667-bd30-c537863e29b8") },
                    { new Guid("e14bf0ed-36ff-40d9-88e4-a19df0db0ebc"), (short)4, "Course34", new Guid("077719f8-99b6-44d7-8e24-56e22f03f4f6"), new Guid("0fd529d1-e3e2-47c5-b856-7aba08cbbbf0") },
                    { new Guid("e3be5ccb-f3fe-49ee-9efa-36aabfa30fef"), (short)4, "Course51", new Guid("077719f8-99b6-44d7-8e24-56e22f03f4f6"), new Guid("68b80fce-73ac-4d0a-8df7-929dde1bad2b") },
                    { new Guid("d75bd25f-40fc-4202-803c-c93a2fac9e34"), (short)2, "Course68", new Guid("077719f8-99b6-44d7-8e24-56e22f03f4f6"), new Guid("4bc31229-4343-493d-94ba-f19b12c1369e") },
                    { new Guid("3f8f269e-0756-4b74-ae49-c7418c412c2f"), (short)2, "Course85", new Guid("077719f8-99b6-44d7-8e24-56e22f03f4f6"), new Guid("1bb30181-e8ba-4ab9-85d3-d81474aca8d1") },
                    { new Guid("8db32eee-a17f-44ba-8fed-7209ad21ab85"), (short)3, "Course309", new Guid("e62a2052-e393-49dd-8dda-5f1977a279c0"), new Guid("a78db448-cd3f-412c-9d1e-0fd2a204ba46") },
                    { new Guid("eaf17804-8d17-4431-af89-34622694efcb"), (short)1, "Course206", new Guid("e62a2052-e393-49dd-8dda-5f1977a279c0"), new Guid("63e1742b-49cd-41ed-b0dc-d6616bf232ba") },
                    { new Guid("c10e7959-96e1-491d-8efc-78ddf5f5039a"), (short)2, "Course0", new Guid("c8ea306c-571d-484a-b0ec-787254efcb71"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("3de863ef-1d33-4338-ae9b-6708afd5c63b"), (short)4, "Course18", new Guid("c8ea306c-571d-484a-b0ec-787254efcb71"), new Guid("a6f53d31-2194-4fad-b679-d54cba290f0a") },
                    { new Guid("365e5de3-34a8-49c1-9f49-814e4c0060c1"), (short)0, "Course36", new Guid("c8ea306c-571d-484a-b0ec-787254efcb71"), new Guid("3f76ac73-0ba7-4d6a-ab40-bc387998856f") },
                    { new Guid("6dc66903-f6da-4d77-812c-b9dfe123b29a"), (short)1, "Course54", new Guid("c8ea306c-571d-484a-b0ec-787254efcb71"), new Guid("cb80fe9b-1a1d-4214-bb57-2e630f55f6e9") },
                    { new Guid("a5aef864-9786-441d-8811-568e3511c21f"), (short)1, "Course72", new Guid("c8ea306c-571d-484a-b0ec-787254efcb71"), new Guid("ed1486d0-4af1-449f-882e-93b5bc021952") },
                    { new Guid("bb77c1e8-1630-4591-b051-95ae50d6f8ed"), (short)3, "Course90", new Guid("c8ea306c-571d-484a-b0ec-787254efcb71"), new Guid("d3e32fcf-a08d-4708-8b06-0d1ea51a808f") },
                    { new Guid("153925ce-45fc-4254-80a0-0cdcaa961fc8"), (short)2, "Course103", new Guid("e62a2052-e393-49dd-8dda-5f1977a279c0"), new Guid("99e90f8f-d4ef-4493-93c7-929399c870d5") },
                    { new Guid("173a652f-1886-44fb-89cb-8e89ca4e3daf"), (short)3, "Course0", new Guid("e62a2052-e393-49dd-8dda-5f1977a279c0"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("ba910abb-a0b4-41f5-8e07-171884ae3a7a"), (short)2, "Course19", new Guid("6dd9c059-e6f3-4116-b9ab-47f8c0f60c1d"), new Guid("86902e3d-1f5b-4abe-9ab7-3fd73dd5ab90") },
                    { new Guid("2c7d36e0-3ec2-464c-949f-9d3d84010691"), (short)1, "Course306", new Guid("b1e1b13b-1c0d-4530-a1f5-763d76c7a8ca"), new Guid("63e1742b-49cd-41ed-b0dc-d6616bf232ba") },
                    { new Guid("e56db4af-7831-45e4-ad5e-8a9d37baca56"), (short)2, "Course0", new Guid("27e43d58-7570-46bc-ba29-eec9624265ea"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("7e93c736-e341-4c99-b195-612fcda2bb45"), (short)4, "Course50", new Guid("330d8cef-7199-4287-871b-64aa88ce2123"), new Guid("a6a34e96-0ca8-49d8-a157-d49457805cae") },
                    { new Guid("6abd870d-c43e-4892-9389-04783b68dc38"), (short)3, "Course107", new Guid("5c174f74-51b8-420b-9b46-cfee6b0c20bd"), new Guid("5a91c10d-b6e0-4886-9ff9-10107fcb6761") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("666ab9bf-22ba-41bb-8819-d2a5a559aacb"), (short)4, "Course0", new Guid("5c174f74-51b8-420b-9b46-cfee6b0c20bd"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("5705487a-9ee2-47e7-8dc0-803d21b88e8e"), (short)4, "Course0", new Guid("af58f530-80db-4ef5-8961-819c6b18453e"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("1442ed17-f2e0-475b-b2c8-d73726c2f69e"), (short)5, "Course3", new Guid("af58f530-80db-4ef5-8961-819c6b18453e"), new Guid("99e90f8f-d4ef-4493-93c7-929399c870d5") },
                    { new Guid("54a8569c-20ed-4c33-b367-6460825a948f"), (short)2, "Course6", new Guid("af58f530-80db-4ef5-8961-819c6b18453e"), new Guid("63e1742b-49cd-41ed-b0dc-d6616bf232ba") },
                    { new Guid("6f0b291c-862f-46d1-9a2e-2792c37f1150"), (short)2, "Course9", new Guid("af58f530-80db-4ef5-8961-819c6b18453e"), new Guid("a78db448-cd3f-412c-9d1e-0fd2a204ba46") },
                    { new Guid("fd9b3275-5082-4188-b83b-07d3648a24db"), (short)5, "Course12", new Guid("af58f530-80db-4ef5-8961-819c6b18453e"), new Guid("063abe97-7452-429b-8088-ae02501cf52a") },
                    { new Guid("0cb0d721-ac7a-4b9e-ba1d-c12a55153175"), (short)1, "Course15", new Guid("af58f530-80db-4ef5-8961-819c6b18453e"), new Guid("ec29cecf-9bb4-4b00-9d9a-5d0ccad64829") },
                    { new Guid("278a6a61-cb57-40a7-9adf-24f010155fbb"), (short)3, "Course0", new Guid("6aa84bea-944d-4081-b6c6-d4c938ad12bd"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("2726cfe5-5a35-4d9e-a381-e0141310d9c3"), (short)0, "Course4", new Guid("6aa84bea-944d-4081-b6c6-d4c938ad12bd"), new Guid("b525ecf2-7acd-47bd-87ae-5309b598ee56") },
                    { new Guid("78b0ffdb-4a85-4b2d-956a-808b75e232d6"), (short)5, "Course8", new Guid("6aa84bea-944d-4081-b6c6-d4c938ad12bd"), new Guid("ebeffb2e-3a83-47bf-b89a-f738c8edc152") },
                    { new Guid("01dbec8f-45a8-4065-8a3f-9b3be3cc49c9"), (short)5, "Course12", new Guid("6aa84bea-944d-4081-b6c6-d4c938ad12bd"), new Guid("063abe97-7452-429b-8088-ae02501cf52a") },
                    { new Guid("a9b92d32-77aa-43ca-8092-1882793243d7"), (short)5, "Course16", new Guid("6aa84bea-944d-4081-b6c6-d4c938ad12bd"), new Guid("8d205a81-e2bc-4419-9b80-76829198e56a") },
                    { new Guid("008dc206-4d5b-4956-a9a5-747c55c9bd50"), (short)2, "Course20", new Guid("6aa84bea-944d-4081-b6c6-d4c938ad12bd"), new Guid("a188125a-5041-418b-ac92-5303ce6e8a12") },
                    { new Guid("8766727e-804d-45de-a3a1-56f18aec249f"), (short)2, "Course530", new Guid("c72b46dc-7ba5-4934-bd46-d8633f2293e5"), new Guid("3c7e6dc1-9f2d-42d3-9e4d-e2431a493beb") },
                    { new Guid("e24303e1-d481-485b-874a-2eaa13c65714"), (short)4, "Course424", new Guid("c72b46dc-7ba5-4934-bd46-d8633f2293e5"), new Guid("d8ddd747-6d87-410d-bf56-417d725c9a22") },
                    { new Guid("675e4cbf-d304-44f1-857a-0e8096ca11f1"), (short)0, "Course0", new Guid("7105bfa0-0571-4c9b-af19-748123a22da2"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("f7dfce42-530c-420d-8f2c-34ca73061644"), (short)1, "Course10", new Guid("b7509275-37e5-4ce6-9402-e01efafc00c3"), new Guid("13204af6-237b-4597-bb1a-c82c23c09636") },
                    { new Guid("f597453c-a98b-4b3d-8452-d7c5c14dccbf"), (short)4, "Course5", new Guid("7105bfa0-0571-4c9b-af19-748123a22da2"), new Guid("4769333d-bd39-4438-862b-97f82854efd1") },
                    { new Guid("42d93c16-efa2-4e1e-800f-d9573f118ece"), (short)2, "Course8", new Guid("b7509275-37e5-4ce6-9402-e01efafc00c3"), new Guid("ebeffb2e-3a83-47bf-b89a-f738c8edc152") },
                    { new Guid("8297c5ab-372b-4450-898d-8cf3a64c74f8"), (short)5, "Course4", new Guid("b7509275-37e5-4ce6-9402-e01efafc00c3"), new Guid("b525ecf2-7acd-47bd-87ae-5309b598ee56") },
                    { new Guid("5b65ea89-9d57-48ec-b8ae-52a5a63155cf"), (short)1, "Course0", new Guid("ea6d9d48-6e3d-436f-9ce0-d725e934f311"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("da6a8224-89ef-4c05-9c7f-b013b4dc8315"), (short)4, "Course0", new Guid("ea6d9d48-6e3d-436f-9ce0-d725e934f311"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("9f92525c-bfc1-4621-a8d6-e80091ac8a06"), (short)2, "Course0", new Guid("ea6d9d48-6e3d-436f-9ce0-d725e934f311"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("4a41f773-3c72-4bde-b4f7-ca6d199a2d18"), (short)5, "Course0", new Guid("ea6d9d48-6e3d-436f-9ce0-d725e934f311"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("4d9ba653-ec02-44de-9fe8-abe65cde11fc"), (short)1, "Course0", new Guid("ea6d9d48-6e3d-436f-9ce0-d725e934f311"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("814a2fde-ac1a-41f1-9cf1-dbcf4b9df264"), (short)3, "Course535", new Guid("5c174f74-51b8-420b-9b46-cfee6b0c20bd"), new Guid("5e08f64f-4cf8-4a4f-8b01-640e5291e9ba") },
                    { new Guid("6ebd62e6-7cdf-4c18-bdd7-0f38d1607324"), (short)3, "Course428", new Guid("5c174f74-51b8-420b-9b46-cfee6b0c20bd"), new Guid("a60a1d7e-06fa-458f-8a6b-5665cb75fb3c") },
                    { new Guid("c67e8cc1-1ddb-4248-81c7-0cbcaf77c3d6"), (short)3, "Course0", new Guid("0c5e5c66-4cf4-4666-876e-3a1de1a85d92"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("f43380a7-35b5-4624-8d70-4b197ce73280"), (short)5, "Course1", new Guid("0c5e5c66-4cf4-4666-876e-3a1de1a85d92"), new Guid("c1ca1d9c-52aa-4c4f-a70a-268d06835428") },
                    { new Guid("f8f64340-0cfd-4f46-bddf-0a05d99fb4ec"), (short)4, "Course2", new Guid("0c5e5c66-4cf4-4666-876e-3a1de1a85d92"), new Guid("38eccc3c-7b82-450f-8c4c-bdcbae4ec305") },
                    { new Guid("9b018c49-f897-4f09-9e90-2e318306035e"), (short)4, "Course3", new Guid("0c5e5c66-4cf4-4666-876e-3a1de1a85d92"), new Guid("99e90f8f-d4ef-4493-93c7-929399c870d5") },
                    { new Guid("f7afeeaf-cbe4-424a-b6a7-60917b5042e3"), (short)4, "Course4", new Guid("0c5e5c66-4cf4-4666-876e-3a1de1a85d92"), new Guid("b525ecf2-7acd-47bd-87ae-5309b598ee56") },
                    { new Guid("62f1ef81-acce-4562-8469-9c3e736a2741"), (short)0, "Course5", new Guid("0c5e5c66-4cf4-4666-876e-3a1de1a85d92"), new Guid("4769333d-bd39-4438-862b-97f82854efd1") },
                    { new Guid("b1d4eb55-5159-4630-b1e5-d1734bdb22a4"), (short)2, "Course321", new Guid("5c174f74-51b8-420b-9b46-cfee6b0c20bd"), new Guid("88cd051e-9532-48bd-813a-11525e0bc1af") },
                    { new Guid("53e56866-8d07-4974-a46f-523b286bf41e"), (short)1, "Course214", new Guid("5c174f74-51b8-420b-9b46-cfee6b0c20bd"), new Guid("5eb8b880-4da8-4c05-9c7b-0e9c25dc8cac") },
                    { new Guid("3b0e1e1c-c18c-4cbf-b12f-c43025cc1382"), (short)2, "Course0", new Guid("b7509275-37e5-4ce6-9402-e01efafc00c3"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("5d586045-9ba6-4c10-a3a6-aafb88db6d16"), (short)0, "Course2", new Guid("b7509275-37e5-4ce6-9402-e01efafc00c3"), new Guid("38eccc3c-7b82-450f-8c4c-bdcbae4ec305") },
                    { new Guid("fd7bed4b-1cad-438a-94c7-77f4caaa9fa8"), (short)1, "Course6", new Guid("b7509275-37e5-4ce6-9402-e01efafc00c3"), new Guid("63e1742b-49cd-41ed-b0dc-d6616bf232ba") },
                    { new Guid("118e9383-65c5-4490-b94f-b4a9c6bfd629"), (short)1, "Course105", new Guid("27e43d58-7570-46bc-ba29-eec9624265ea"), new Guid("4769333d-bd39-4438-862b-97f82854efd1") },
                    { new Guid("e6fa48c8-dd62-40cc-8434-296567df17a6"), (short)5, "Course10", new Guid("7105bfa0-0571-4c9b-af19-748123a22da2"), new Guid("13204af6-237b-4597-bb1a-c82c23c09636") },
                    { new Guid("2f7d339e-0857-4b5e-969d-6649caa889b8"), (short)4, "Course20", new Guid("7105bfa0-0571-4c9b-af19-748123a22da2"), new Guid("a188125a-5041-418b-ac92-5303ce6e8a12") },
                    { new Guid("0cb00fbf-566a-413b-9a2d-dbc595985550"), (short)4, "Course32", new Guid("475c557a-fd49-4063-9110-e75d3c0ad792"), new Guid("d27b117a-d80a-4155-8dfa-522f22cd4429") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("c4bfa208-f493-4180-8495-6c02780a55ad"), (short)2, "Course40", new Guid("475c557a-fd49-4063-9110-e75d3c0ad792"), new Guid("057dfd7c-e065-4359-ad7d-4f9203a48204") },
                    { new Guid("51fd0556-4a42-4109-b3d6-ad2b617f2cbd"), (short)2, "Course525", new Guid("27e43d58-7570-46bc-ba29-eec9624265ea"), new Guid("6985d0e1-cd88-42c9-814a-158b42abd6d6") },
                    { new Guid("9385ae6a-2346-49f7-9b7d-1ebf4d00d5c1"), (short)1, "Course420", new Guid("27e43d58-7570-46bc-ba29-eec9624265ea"), new Guid("a188125a-5041-418b-ac92-5303ce6e8a12") },
                    { new Guid("59900d07-4574-46d9-94b1-667d1620580e"), (short)1, "Course0", new Guid("1f729851-ec34-41f4-a629-c8c322acd5ea"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("f986c997-e0dd-49d5-90a9-ebf4164bf5d9"), (short)1, "Course9", new Guid("1f729851-ec34-41f4-a629-c8c322acd5ea"), new Guid("a78db448-cd3f-412c-9d1e-0fd2a204ba46") },
                    { new Guid("e117ff0a-1878-4dd6-ad28-ab9bf8c9f4e5"), (short)3, "Course18", new Guid("1f729851-ec34-41f4-a629-c8c322acd5ea"), new Guid("a6f53d31-2194-4fad-b679-d54cba290f0a") },
                    { new Guid("8c1ba707-43f1-4cef-a014-7cba13d296a6"), (short)5, "Course27", new Guid("1f729851-ec34-41f4-a629-c8c322acd5ea"), new Guid("c3463b63-6f38-4d78-ba4c-b946177b6401") },
                    { new Guid("6e9cb98f-4c38-4ea9-97ce-f59e33eb4d18"), (short)5, "Course36", new Guid("1f729851-ec34-41f4-a629-c8c322acd5ea"), new Guid("3f76ac73-0ba7-4d6a-ab40-bc387998856f") },
                    { new Guid("270ff333-75de-4f55-a182-7dfc3c3745ee"), (short)5, "Course45", new Guid("1f729851-ec34-41f4-a629-c8c322acd5ea"), new Guid("2a164668-67e3-4a12-b8a1-af89e56f1a14") },
                    { new Guid("6edd97d5-501b-4152-86c7-6ae94ef0d11b"), (short)0, "Course315", new Guid("27e43d58-7570-46bc-ba29-eec9624265ea"), new Guid("ec29cecf-9bb4-4b00-9d9a-5d0ccad64829") },
                    { new Guid("cba064e0-bf3f-44c3-a23e-dee11d75f2db"), (short)0, "Course210", new Guid("27e43d58-7570-46bc-ba29-eec9624265ea"), new Guid("13204af6-237b-4597-bb1a-c82c23c09636") },
                    { new Guid("255267c0-9f05-4486-8d4c-e7390e9cd971"), (short)2, "Course0", new Guid("330d8cef-7199-4287-871b-64aa88ce2123"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("d0960783-36c6-446e-b7be-65db10ee3c93"), (short)3, "Course10", new Guid("330d8cef-7199-4287-871b-64aa88ce2123"), new Guid("13204af6-237b-4597-bb1a-c82c23c09636") },
                    { new Guid("30bc778e-3f69-48f3-827f-c8e34ed18b2e"), (short)2, "Course20", new Guid("330d8cef-7199-4287-871b-64aa88ce2123"), new Guid("a188125a-5041-418b-ac92-5303ce6e8a12") },
                    { new Guid("147b0d69-fb47-468e-81f9-3a5de733573b"), (short)0, "Course30", new Guid("330d8cef-7199-4287-871b-64aa88ce2123"), new Guid("3c7e6dc1-9f2d-42d3-9e4d-e2431a493beb") },
                    { new Guid("4c549d72-0318-4223-a709-53411c5a9b7d"), (short)4, "Course40", new Guid("330d8cef-7199-4287-871b-64aa88ce2123"), new Guid("057dfd7c-e065-4359-ad7d-4f9203a48204") },
                    { new Guid("3a436b7e-16ae-42f3-8278-bdbcc422bc29"), (short)4, "Course24", new Guid("475c557a-fd49-4063-9110-e75d3c0ad792"), new Guid("d8ddd747-6d87-410d-bf56-417d725c9a22") },
                    { new Guid("a0f9338b-e2af-470a-8b71-778463406515"), (short)5, "Course15", new Guid("7105bfa0-0571-4c9b-af19-748123a22da2"), new Guid("ec29cecf-9bb4-4b00-9d9a-5d0ccad64829") },
                    { new Guid("ee4a6838-3451-4fcf-af2c-a008166b43e9"), (short)4, "Course16", new Guid("475c557a-fd49-4063-9110-e75d3c0ad792"), new Guid("8d205a81-e2bc-4419-9b80-76829198e56a") },
                    { new Guid("5f0d874a-bdb9-406b-9e22-d3c91886266e"), (short)3, "Course0", new Guid("475c557a-fd49-4063-9110-e75d3c0ad792"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("5abd9a3e-26bc-4640-90ee-004f6afd9902"), (short)0, "Course25", new Guid("7105bfa0-0571-4c9b-af19-748123a22da2"), new Guid("6985d0e1-cd88-42c9-814a-158b42abd6d6") },
                    { new Guid("653b9420-2d97-4f97-9443-3688472e9559"), (short)2, "Course318", new Guid("c72b46dc-7ba5-4934-bd46-d8633f2293e5"), new Guid("a6f53d31-2194-4fad-b679-d54cba290f0a") },
                    { new Guid("5648cb72-9724-4538-bdd0-dd645dd5d374"), (short)1, "Course212", new Guid("c72b46dc-7ba5-4934-bd46-d8633f2293e5"), new Guid("063abe97-7452-429b-8088-ae02501cf52a") },
                    { new Guid("e1255dbb-2071-43d2-b794-08959337457c"), (short)0, "Course0", new Guid("4ab0f3a8-256f-407b-b9dd-ae5fc5d3d6df"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("f5e267f9-dbc4-4775-8f79-75aaa20ed435"), (short)4, "Course6", new Guid("4ab0f3a8-256f-407b-b9dd-ae5fc5d3d6df"), new Guid("63e1742b-49cd-41ed-b0dc-d6616bf232ba") },
                    { new Guid("c4b66957-3110-40d9-96df-c96e4d428853"), (short)3, "Course12", new Guid("4ab0f3a8-256f-407b-b9dd-ae5fc5d3d6df"), new Guid("063abe97-7452-429b-8088-ae02501cf52a") },
                    { new Guid("e6aeda63-12dc-4921-8659-5767ff7169de"), (short)1, "Course18", new Guid("4ab0f3a8-256f-407b-b9dd-ae5fc5d3d6df"), new Guid("a6f53d31-2194-4fad-b679-d54cba290f0a") },
                    { new Guid("89ffb272-e78d-4ffa-973a-89307fdcc4bb"), (short)1, "Course24", new Guid("4ab0f3a8-256f-407b-b9dd-ae5fc5d3d6df"), new Guid("d8ddd747-6d87-410d-bf56-417d725c9a22") },
                    { new Guid("2bdcef24-dd67-4398-80bd-7148523c7759"), (short)2, "Course30", new Guid("4ab0f3a8-256f-407b-b9dd-ae5fc5d3d6df"), new Guid("3c7e6dc1-9f2d-42d3-9e4d-e2431a493beb") },
                    { new Guid("1ecae45c-8b19-4962-b883-34d67783e053"), (short)4, "Course106", new Guid("c72b46dc-7ba5-4934-bd46-d8633f2293e5"), new Guid("63e1742b-49cd-41ed-b0dc-d6616bf232ba") },
                    { new Guid("9b309f78-73e0-4458-a0bb-4d77fb735465"), (short)1, "Course0", new Guid("c72b46dc-7ba5-4934-bd46-d8633f2293e5"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("f9107f46-16ab-48f1-ad58-5139416bb4b5"), (short)0, "Course0", new Guid("a43aeedd-5642-410a-b006-f5bd23bb6afc"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("a854c6e3-1cf2-4bc1-a762-7f5c881287b6"), (short)1, "Course7", new Guid("a43aeedd-5642-410a-b006-f5bd23bb6afc"), new Guid("5a91c10d-b6e0-4886-9ff9-10107fcb6761") },
                    { new Guid("ad443f94-4e53-4cf1-96ea-3524f943fd65"), (short)0, "Course14", new Guid("a43aeedd-5642-410a-b006-f5bd23bb6afc"), new Guid("5eb8b880-4da8-4c05-9c7b-0e9c25dc8cac") },
                    { new Guid("36bca1c7-7b7d-4359-b0eb-a3e955a3012e"), (short)4, "Course21", new Guid("a43aeedd-5642-410a-b006-f5bd23bb6afc"), new Guid("88cd051e-9532-48bd-813a-11525e0bc1af") },
                    { new Guid("011a6f2b-e89c-48cb-b4d2-7153a636a79a"), (short)2, "Course28", new Guid("a43aeedd-5642-410a-b006-f5bd23bb6afc"), new Guid("a60a1d7e-06fa-458f-8a6b-5665cb75fb3c") },
                    { new Guid("8185b2c2-c92a-4ed5-81b1-47b0fef4f1e7"), (short)3, "Course35", new Guid("a43aeedd-5642-410a-b006-f5bd23bb6afc"), new Guid("5e08f64f-4cf8-4a4f-8b01-640e5291e9ba") },
                    { new Guid("8c5fb294-19a8-4115-bf45-543b13d7a3e6"), (short)0, "Course8", new Guid("475c557a-fd49-4063-9110-e75d3c0ad792"), new Guid("ebeffb2e-3a83-47bf-b89a-f738c8edc152") },
                    { new Guid("08f5f051-8fbc-464b-b4c0-b4dd846e6791"), (short)5, "Course204", new Guid("b1e1b13b-1c0d-4530-a1f5-763d76c7a8ca"), new Guid("b525ecf2-7acd-47bd-87ae-5309b598ee56") },
                    { new Guid("750ed328-82d9-4be7-9d26-d792e83798ae"), (short)0, "Course86", new Guid("6260768b-db7c-43c8-b6ad-69de7795c445"), new Guid("4adb9302-baad-4231-9a53-e750e5383bc8") },
                    { new Guid("84e8fe0d-2f30-4081-97bc-9c1ca3c9932f"), (short)0, "Course22", new Guid("d9a848e5-db20-40f7-83aa-f546c4796307"), new Guid("69f353ab-b263-41df-ad3e-e3fb8493d9ac") },
                    { new Guid("ce842240-e6d0-4fb5-8554-3e9d336b9dab"), (short)0, "Course64", new Guid("87fe76e1-3d2d-423e-abb6-68bf23ff2ae4"), new Guid("c8258a3d-48f8-4eac-b14e-18ced7b5618e") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("6e099b6f-581a-4e4f-bfbf-7e45d618ef00"), (short)2, "Course96", new Guid("87fe76e1-3d2d-423e-abb6-68bf23ff2ae4"), new Guid("77abbb72-1f82-42ba-8f26-b31bc1a26767") },
                    { new Guid("310859f9-0408-4392-8eee-266ee5041218"), (short)0, "Course128", new Guid("87fe76e1-3d2d-423e-abb6-68bf23ff2ae4"), new Guid("a60a1d7e-06fa-458f-8a6b-5665cb75fb3c") },
                    { new Guid("33a396b5-f312-4436-adb0-86da4b94b08a"), (short)5, "Course160", new Guid("87fe76e1-3d2d-423e-abb6-68bf23ff2ae4"), new Guid("b7e178a9-8cfe-4c9c-aeab-dc77f9f2de35") },
                    { new Guid("abec4348-dfd5-441b-87e1-ed520e4425b1"), (short)5, "Course495", new Guid("d7349cf1-5325-42b1-9313-0f2eff59eaf3"), new Guid("5d1d8f68-958b-4b72-a3d9-ab026d6c9b3b") },
                    { new Guid("f30185af-ce6e-4e05-89d7-d0c7fe5b55ce"), (short)4, "Course396", new Guid("d7349cf1-5325-42b1-9313-0f2eff59eaf3"), new Guid("77abbb72-1f82-42ba-8f26-b31bc1a26767") },
                    { new Guid("e8218e83-9344-4953-9e1e-9ef83f545022"), (short)5, "Course32", new Guid("87fe76e1-3d2d-423e-abb6-68bf23ff2ae4"), new Guid("d27b117a-d80a-4155-8dfa-522f22cd4429") },
                    { new Guid("6f3182f2-1068-4a08-b512-2d829248b972"), (short)1, "Course39", new Guid("db5f1cfb-af79-4c71-a881-0276a753b746"), new Guid("7c3a81a4-266d-4f0c-b73a-38e6d61e9622") },
                    { new Guid("4e3408fd-5690-44ed-9b0d-111630c7893a"), (short)1, "Course0", new Guid("6fcc89ca-3601-4bd4-9ea8-137469053e94"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("1d318b58-7497-48ab-a835-a95c2f4b1312"), (short)0, "Course33", new Guid("6fcc89ca-3601-4bd4-9ea8-137469053e94"), new Guid("c0b88834-6a9a-4c54-9efd-9eba8cba2b31") },
                    { new Guid("f4de6f26-074c-479b-818b-71950959aaec"), (short)0, "Course66", new Guid("6fcc89ca-3601-4bd4-9ea8-137469053e94"), new Guid("d45a85ca-e996-416a-b2d8-606426c8a15a") },
                    { new Guid("9e52ffef-efdf-4330-a078-eda047f06c6a"), (short)0, "Course99", new Guid("6fcc89ca-3601-4bd4-9ea8-137469053e94"), new Guid("11d3e5cc-d08b-4545-aa68-881baf307590") },
                    { new Guid("1f2a54ad-58c8-49b0-b0b3-d6b49084aa54"), (short)1, "Course132", new Guid("6fcc89ca-3601-4bd4-9ea8-137469053e94"), new Guid("d27b117a-d80a-4155-8dfa-522f22cd4429") },
                    { new Guid("ba1d2b78-36a0-43c5-aa68-4eb61323fbc4"), (short)5, "Course165", new Guid("6fcc89ca-3601-4bd4-9ea8-137469053e94"), new Guid("71fbe949-8b66-4ee4-b52b-3c5370663ef6") },
                    { new Guid("6bac9340-11d2-4d36-8140-4d41291fc5fe"), (short)5, "Course0", new Guid("db5f1cfb-af79-4c71-a881-0276a753b746"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("fcf8cba9-3258-463b-8ba2-d38106d62ca2"), (short)4, "Course78", new Guid("db5f1cfb-af79-4c71-a881-0276a753b746"), new Guid("2d18691c-989d-416d-a354-29be08ce9df1") },
                    { new Guid("80ee90ce-1eda-4274-af73-8623d68b0e57"), (short)3, "Course117", new Guid("db5f1cfb-af79-4c71-a881-0276a753b746"), new Guid("a62b56c5-0991-4667-bd30-c537863e29b8") },
                    { new Guid("f05e5026-576d-4f98-af84-3b0f905a7d33"), (short)0, "Course0", new Guid("87fe76e1-3d2d-423e-abb6-68bf23ff2ae4"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("6c656205-44f3-421b-b2d8-5fa97011b1c1"), (short)1, "Course30", new Guid("d958eb54-3146-41c7-8977-2aa0cb663551"), new Guid("3c7e6dc1-9f2d-42d3-9e4d-e2431a493beb") },
                    { new Guid("0223767f-aa16-4841-9dd8-a16c23984434"), (short)3, "Course60", new Guid("d958eb54-3146-41c7-8977-2aa0cb663551"), new Guid("b7e178a9-8cfe-4c9c-aeab-dc77f9f2de35") },
                    { new Guid("c01aff01-eba2-4cc2-bc61-c6fc2b32aa18"), (short)0, "Course90", new Guid("d958eb54-3146-41c7-8977-2aa0cb663551"), new Guid("d3e32fcf-a08d-4708-8b06-0d1ea51a808f") },
                    { new Guid("ca58968e-9049-4486-9aca-57c6b14b86b0"), (short)4, "Course120", new Guid("d958eb54-3146-41c7-8977-2aa0cb663551"), new Guid("a188125a-5041-418b-ac92-5303ce6e8a12") },
                    { new Guid("96d4275a-f03e-4d1e-8ae8-e02aeecc4f65"), (short)1, "Course150", new Guid("d958eb54-3146-41c7-8977-2aa0cb663551"), new Guid("a6a34e96-0ca8-49d8-a157-d49457805cae") },
                    { new Guid("d432ecf4-cf8d-4ccf-a629-a11b69245a7d"), (short)5, "Course100", new Guid("95eed3b1-2718-4d54-87ca-969cb51e880c"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("e2314f8f-0134-401e-b0ce-d6c7b15550c7"), (short)4, "Course0", new Guid("95eed3b1-2718-4d54-87ca-969cb51e880c"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("64cb142c-2e25-43c6-af83-be58c980dfc3"), (short)5, "Course0", new Guid("e4124ca5-3a97-4dfd-a778-d6d7f390d0e2"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("0f14bbe1-8732-497e-8eab-e656c598ef9d"), (short)3, "Course31", new Guid("e4124ca5-3a97-4dfd-a778-d6d7f390d0e2"), new Guid("a338538a-abb1-4870-b2be-f707276ce47b") },
                    { new Guid("1080ca2d-9f2b-4c7a-9b6e-2fce068a40e6"), (short)5, "Course62", new Guid("e4124ca5-3a97-4dfd-a778-d6d7f390d0e2"), new Guid("ed739eb3-57d3-4d4d-9fa3-1ad130210c41") },
                    { new Guid("fe53d592-65ff-45ab-82f6-7d8e803a7100"), (short)0, "Course93", new Guid("e4124ca5-3a97-4dfd-a778-d6d7f390d0e2"), new Guid("c693d672-a076-4715-8681-ac0e1c9e8ffe") },
                    { new Guid("06bc16c3-64ee-4ba0-a586-fc80c8f271b3"), (short)0, "Course124", new Guid("e4124ca5-3a97-4dfd-a778-d6d7f390d0e2"), new Guid("d8ddd747-6d87-410d-bf56-417d725c9a22") },
                    { new Guid("0a17dd2b-4954-42a1-870b-97a0c62d9e20"), (short)0, "Course155", new Guid("e4124ca5-3a97-4dfd-a778-d6d7f390d0e2"), new Guid("3789d0c1-a469-45be-ae4a-383778d9e884") },
                    { new Guid("bf75ebef-313b-41e5-a992-f20b229909b3"), (short)0, "Course156", new Guid("db5f1cfb-af79-4c71-a881-0276a753b746"), new Guid("0a2bec6b-65e9-4c34-8fa8-eb3a98e94d6c") },
                    { new Guid("5bb5a6d6-f886-49a7-8bf3-b12015f3fcdb"), (short)3, "Course0", new Guid("d9a848e5-db20-40f7-83aa-f546c4796307"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("1a36900c-d0d1-459b-b01d-92df153460c4"), (short)0, "Course297", new Guid("d7349cf1-5325-42b1-9313-0f2eff59eaf3"), new Guid("0a56d0c8-98c6-400e-abe3-fb0a9a9f286b") },
                    { new Guid("059db3f5-5af5-42d3-a699-508627db4592"), (short)3, "Course198", new Guid("d7349cf1-5325-42b1-9313-0f2eff59eaf3"), new Guid("7ad86313-7bbc-4d7f-899c-86985ce8b6ab") },
                    { new Guid("e40848de-ee6a-4375-845d-b635bb928686"), (short)3, "Course0", new Guid("1a79ae16-e107-4464-a22f-5bd96be4b2e3"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("c54274f4-14eb-43b4-9329-22238eacfdaa"), (short)3, "Course34", new Guid("1a79ae16-e107-4464-a22f-5bd96be4b2e3"), new Guid("0fd529d1-e3e2-47c5-b856-7aba08cbbbf0") },
                    { new Guid("cd028e7c-6f19-4d8e-925b-57da834047b6"), (short)3, "Course36", new Guid("24594659-f059-49b0-8cf7-ba8b09eb0caf"), new Guid("3f76ac73-0ba7-4d6a-ab40-bc387998856f") },
                    { new Guid("cdf4ac3f-6f6c-487b-9955-68d37fcc3d78"), (short)2, "Course38", new Guid("16bbd598-8c3a-41fc-b681-cd2926aa6ebe"), new Guid("64f7e86e-e102-4040-acc2-89d5c9c06788") },
                    { new Guid("0027fb6d-1dcc-4799-9f76-7ac50aea5244"), (short)1, "Course72", new Guid("24594659-f059-49b0-8cf7-ba8b09eb0caf"), new Guid("ed1486d0-4af1-449f-882e-93b5bc021952") },
                    { new Guid("24a72022-8c7b-4933-bb21-76f889dc91f9"), (short)4, "Course108", new Guid("24594659-f059-49b0-8cf7-ba8b09eb0caf"), new Guid("ebeffb2e-3a83-47bf-b89a-f738c8edc152") },
                    { new Guid("a3830000-a6fb-42f7-ab4c-eba99194e2ac"), (short)2, "Course144", new Guid("24594659-f059-49b0-8cf7-ba8b09eb0caf"), new Guid("0fe90da4-1897-46a6-a2e8-5326e2ad84d8") },
                    { new Guid("2b410c50-1047-4fa0-bfca-7dc6e3012f3d"), (short)1, "Course180", new Guid("24594659-f059-49b0-8cf7-ba8b09eb0caf"), new Guid("0f3a6be6-d338-4180-9f66-12eea50cc59b") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("b34d2b5d-a904-4a97-aa52-aa4fe67e717e"), (short)3, "Course490", new Guid("5a26c4e3-d8fa-4b4c-a539-7d274408cfe3"), new Guid("d3e32fcf-a08d-4708-8b06-0d1ea51a808f") },
                    { new Guid("71e83d80-5313-4509-9abd-32667f12236d"), (short)4, "Course392", new Guid("5a26c4e3-d8fa-4b4c-a539-7d274408cfe3"), new Guid("ce390f41-873c-453d-9f08-1266e2189587") },
                    { new Guid("f8793b9b-6bdd-45f0-969d-b3329101b99c"), (short)2, "Course0", new Guid("bc11631b-0491-416b-b1ff-18ab635820e2"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("d4c79626-1c43-42df-987e-0e606c461870"), (short)1, "Course37", new Guid("bc11631b-0491-416b-b1ff-18ab635820e2"), new Guid("7edca406-8727-4468-98f7-a23690714cf9") },
                    { new Guid("d812ef09-c50e-4745-a4a2-8955ce600122"), (short)4, "Course74", new Guid("bc11631b-0491-416b-b1ff-18ab635820e2"), new Guid("c4a5a9d7-7554-4f06-9602-178bba9fb90f") },
                    { new Guid("bb5c973b-ade7-4a14-b4ca-c280f05a5b2f"), (short)2, "Course111", new Guid("bc11631b-0491-416b-b1ff-18ab635820e2"), new Guid("86828be7-9d59-413e-8b29-4318311399e4") },
                    { new Guid("605d150f-aae4-4f2b-b2a8-75d024ca3383"), (short)0, "Course148", new Guid("bc11631b-0491-416b-b1ff-18ab635820e2"), new Guid("adbec3db-e798-4b59-a8a1-3ef0c251f642") },
                    { new Guid("00cb1e9c-c679-44af-9b55-01e8293ed60e"), (short)4, "Course185", new Guid("bc11631b-0491-416b-b1ff-18ab635820e2"), new Guid("1bb30181-e8ba-4ab9-85d3-d81474aca8d1") },
                    { new Guid("de19cca0-b8bb-4b9d-954b-65e4eea7fb72"), (short)3, "Course294", new Guid("5a26c4e3-d8fa-4b4c-a539-7d274408cfe3"), new Guid("8766bb6f-dce9-4dac-a46c-7c2a0243cf58") },
                    { new Guid("79ea199a-0e98-4720-84c0-3e61903c8953"), (short)0, "Course0", new Guid("24594659-f059-49b0-8cf7-ba8b09eb0caf"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("a8ec5fde-f435-497c-9152-3a0dabd0a1ee"), (short)4, "Course196", new Guid("5a26c4e3-d8fa-4b4c-a539-7d274408cfe3"), new Guid("77abbb72-1f82-42ba-8f26-b31bc1a26767") },
                    { new Guid("281b067b-77cf-4db3-a0b1-b703770c556b"), (short)2, "Course76", new Guid("16bbd598-8c3a-41fc-b681-cd2926aa6ebe"), new Guid("a906fee8-00ee-4be0-aa58-fc3469ded86a") },
                    { new Guid("e3786d94-26b8-4484-90de-c5b41d91fa2a"), (short)5, "Course152", new Guid("16bbd598-8c3a-41fc-b681-cd2926aa6ebe"), new Guid("a5da19b2-60d3-4a47-aa17-6a9bb34f6923") },
                    { new Guid("9c2158a9-19cb-45db-ac7e-602fd07c388b"), (short)3, "Course68", new Guid("1a79ae16-e107-4464-a22f-5bd96be4b2e3"), new Guid("4bc31229-4343-493d-94ba-f19b12c1369e") },
                    { new Guid("d3125f29-82f0-4ded-b6c1-b2a29c27a49a"), (short)1, "Course102", new Guid("1a79ae16-e107-4464-a22f-5bd96be4b2e3"), new Guid("38eccc3c-7b82-450f-8c4c-bdcbae4ec305") },
                    { new Guid("b7b46d65-6027-4a8f-894c-e625dea017e3"), (short)2, "Course136", new Guid("1a79ae16-e107-4464-a22f-5bd96be4b2e3"), new Guid("3f76ac73-0ba7-4d6a-ab40-bc387998856f") },
                    { new Guid("0e0177e8-ac42-4d83-819d-da0a5f76b842"), (short)3, "Course0", new Guid("5a26c4e3-d8fa-4b4c-a539-7d274408cfe3"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("c7509892-d262-44fd-b16b-5c11d9cd3705"), (short)5, "Course98", new Guid("5a26c4e3-d8fa-4b4c-a539-7d274408cfe3"), new Guid("7ad86313-7bbc-4d7f-899c-86985ce8b6ab") },
                    { new Guid("99b2ee2f-1c6d-4df2-9e5b-a406a6c68475"), (short)0, "Course170", new Guid("1a79ae16-e107-4464-a22f-5bd96be4b2e3"), new Guid("a07c095e-f185-4765-958b-121530f33152") },
                    { new Guid("67e814c0-5474-4dbe-8bf2-6d2858da32fd"), (short)2, "Course99", new Guid("d7349cf1-5325-42b1-9313-0f2eff59eaf3"), new Guid("11d3e5cc-d08b-4545-aa68-881baf307590") },
                    { new Guid("f26818a0-dc2b-49e3-b8e4-9f4526612b2d"), (short)0, "Course0", new Guid("d7349cf1-5325-42b1-9313-0f2eff59eaf3"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("1748a475-a47c-4b73-894f-c1e1e13239f9"), (short)3, "Course0", new Guid("81575b03-8d04-4bf2-a869-3404de699b61"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("21425773-b9fc-4b13-acc9-cff966a26b5a"), (short)0, "Course35", new Guid("81575b03-8d04-4bf2-a869-3404de699b61"), new Guid("5e08f64f-4cf8-4a4f-8b01-640e5291e9ba") },
                    { new Guid("0c4a7018-9c56-4ce9-8dc7-f69937e5c4a9"), (short)2, "Course70", new Guid("81575b03-8d04-4bf2-a869-3404de699b61"), new Guid("a07c095e-f185-4765-958b-121530f33152") },
                    { new Guid("40857c7a-db16-4c9a-920d-25ab461d375c"), (short)1, "Course105", new Guid("81575b03-8d04-4bf2-a869-3404de699b61"), new Guid("4769333d-bd39-4438-862b-97f82854efd1") },
                    { new Guid("3f8bd056-62b6-4d8c-96f3-f7967b13efdd"), (short)2, "Course140", new Guid("81575b03-8d04-4bf2-a869-3404de699b61"), new Guid("057dfd7c-e065-4359-ad7d-4f9203a48204") },
                    { new Guid("bab8031a-6ad7-49f6-bb5b-dabfca9758f2"), (short)2, "Course175", new Guid("81575b03-8d04-4bf2-a869-3404de699b61"), new Guid("92b3dc88-fead-4a45-aba3-4aeae5dbec80") },
                    { new Guid("b0893f1d-24e7-4b08-b724-bbfa2e46cffe"), (short)5, "Course190", new Guid("16bbd598-8c3a-41fc-b681-cd2926aa6ebe"), new Guid("d3e32fcf-a08d-4708-8b06-0d1ea51a808f") },
                    { new Guid("74b366b6-fab4-47f2-aec6-94327d253b8c"), (short)0, "Course114", new Guid("16bbd598-8c3a-41fc-b681-cd2926aa6ebe"), new Guid("5eb8b880-4da8-4c05-9c7b-0e9c25dc8cac") },
                    { new Guid("5004c9ff-d249-457b-ac9c-0ec7e3cd2f44"), (short)5, "Course200", new Guid("95eed3b1-2718-4d54-87ca-969cb51e880c"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("43f86a93-4360-464e-99ea-4341af5077c4"), (short)5, "Course0", new Guid("d958eb54-3146-41c7-8977-2aa0cb663551"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("d3ddd244-e448-4a33-a514-b3b4efc4cb2f"), (short)3, "Course26", new Guid("9266f3fa-79cf-434e-8365-4735048d2831"), new Guid("ba0e5c03-6f8b-4477-9e10-0a882b4c3832") },
                    { new Guid("112a90d5-6cd3-4532-aa9f-851df469d8e5"), (short)4, "Course72", new Guid("b582d2dc-d7ef-412d-89d6-cec2f0a77292"), new Guid("ed1486d0-4af1-449f-882e-93b5bc021952") },
                    { new Guid("1101f3ca-9c0e-42fc-bb12-daaf70b27ead"), (short)4, "Course96", new Guid("b582d2dc-d7ef-412d-89d6-cec2f0a77292"), new Guid("77abbb72-1f82-42ba-8f26-b31bc1a26767") },
                    { new Guid("0a9bbfe9-dc6c-4940-9727-1448cb8829a0"), (short)5, "Course485", new Guid("948db04e-01cc-4694-95d2-63fa40172191"), new Guid("1bb30181-e8ba-4ab9-85d3-d81474aca8d1") },
                    { new Guid("6e1677fc-9b90-4106-980f-9720a8d0a45c"), (short)3, "Course200", new Guid("4dfc9fcf-13e9-4ec2-852b-2b76f9b37bf6"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("1a8ec518-a33a-43c4-ab88-86ab28cea0e2"), (short)1, "Course120", new Guid("b582d2dc-d7ef-412d-89d6-cec2f0a77292"), new Guid("a188125a-5041-418b-ac92-5303ce6e8a12") },
                    { new Guid("2f156509-59ed-4e86-a7ed-18ba31e8016d"), (short)3, "Course505", new Guid("be84a8ea-74da-4374-bfc1-d8f30d06b7e6"), new Guid("4769333d-bd39-4438-862b-97f82854efd1") },
                    { new Guid("5916c3d7-39f5-4af9-94fd-b4e806a4a9eb"), (short)1, "Course404", new Guid("be84a8ea-74da-4374-bfc1-d8f30d06b7e6"), new Guid("b525ecf2-7acd-47bd-87ae-5309b598ee56") },
                    { new Guid("a652b870-78d7-4ee2-b357-c6a011e7c944"), (short)4, "Course0", new Guid("5c881e8f-502b-4278-83c7-66bd963880bb"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("416e0c57-5173-47a0-9875-e2f901e22349"), (short)5, "Course25", new Guid("5c881e8f-502b-4278-83c7-66bd963880bb"), new Guid("6985d0e1-cd88-42c9-814a-158b42abd6d6") },
                    { new Guid("6dd23768-ee39-4399-ad73-275b2312eae3"), (short)0, "Course50", new Guid("5c881e8f-502b-4278-83c7-66bd963880bb"), new Guid("a6a34e96-0ca8-49d8-a157-d49457805cae") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("57f1a31b-f63d-46c1-9418-514f7b74cfc6"), (short)3, "Course75", new Guid("5c881e8f-502b-4278-83c7-66bd963880bb"), new Guid("92b3dc88-fead-4a45-aba3-4aeae5dbec80") },
                    { new Guid("377b1024-c2ff-4f2d-9537-82435b4844b4"), (short)5, "Course100", new Guid("5c881e8f-502b-4278-83c7-66bd963880bb"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("9857e418-c4a6-4a87-b2ae-014ddedbeb87"), (short)2, "Course125", new Guid("5c881e8f-502b-4278-83c7-66bd963880bb"), new Guid("6985d0e1-cd88-42c9-814a-158b42abd6d6") },
                    { new Guid("938bdb0d-e46a-4ed6-8de5-0ff8c65596ff"), (short)2, "Course303", new Guid("be84a8ea-74da-4374-bfc1-d8f30d06b7e6"), new Guid("99e90f8f-d4ef-4493-93c7-929399c870d5") },
                    { new Guid("e39d452c-db59-48be-8212-d636b1cb7ec5"), (short)4, "Course202", new Guid("be84a8ea-74da-4374-bfc1-d8f30d06b7e6"), new Guid("38eccc3c-7b82-450f-8c4c-bdcbae4ec305") },
                    { new Guid("c2696ab1-a299-4bc7-9ba1-44dcd110c45b"), (short)5, "Course48", new Guid("b582d2dc-d7ef-412d-89d6-cec2f0a77292"), new Guid("adbec3db-e798-4b59-a8a1-3ef0c251f642") },
                    { new Guid("32e279d4-0da9-4473-bc07-646d88e21f8f"), (short)3, "Course24", new Guid("b582d2dc-d7ef-412d-89d6-cec2f0a77292"), new Guid("d8ddd747-6d87-410d-bf56-417d725c9a22") },
                    { new Guid("55af742f-adc4-4ed1-841a-ccd4ca252050"), (short)0, "Course388", new Guid("948db04e-01cc-4694-95d2-63fa40172191"), new Guid("e6b51413-4b52-4843-85a2-78ed2c0eea2f") },
                    { new Guid("7114803d-4f2e-4de0-976d-1502bd8b7838"), (short)4, "Course0", new Guid("b51bbea9-0afd-4738-a071-5a774b889837"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("a93815e2-0389-4715-b9e0-b4d85629ab96"), (short)1, "Course44", new Guid("d9a848e5-db20-40f7-83aa-f546c4796307"), new Guid("0fe90da4-1897-46a6-a2e8-5326e2ad84d8") },
                    { new Guid("3b492081-c9bc-4d5c-923f-93d705fab4c7"), (short)2, "Course66", new Guid("d9a848e5-db20-40f7-83aa-f546c4796307"), new Guid("d45a85ca-e996-416a-b2d8-606426c8a15a") },
                    { new Guid("260ceb70-5626-4496-b889-69ddc3d6b24f"), (short)0, "Course88", new Guid("d9a848e5-db20-40f7-83aa-f546c4796307"), new Guid("e6b51413-4b52-4843-85a2-78ed2c0eea2f") },
                    { new Guid("50f51fce-fc63-4a1e-adc5-391cbc553e30"), (short)0, "Course110", new Guid("d9a848e5-db20-40f7-83aa-f546c4796307"), new Guid("13204af6-237b-4597-bb1a-c82c23c09636") },
                    { new Guid("8585745b-b7e4-4c84-b9bd-13ab492a19b4"), (short)1, "Course102", new Guid("b1e1b13b-1c0d-4530-a1f5-763d76c7a8ca"), new Guid("38eccc3c-7b82-450f-8c4c-bdcbae4ec305") },
                    { new Guid("1616ff03-4d0c-48ca-8b58-7c3acf687d40"), (short)0, "Course0", new Guid("b1e1b13b-1c0d-4530-a1f5-763d76c7a8ca"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("c76ea13f-8598-4877-9bc7-fd3a0d60bd69"), (short)5, "Course0", new Guid("907d852f-b1fe-4950-9afc-a3e746c9d6d2"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("cfb71de1-487e-4fa9-ab12-4f0b2a212650"), (short)5, "Course0", new Guid("9266f3fa-79cf-434e-8365-4735048d2831"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("edbe4cf7-373f-4090-b145-930695d4b56b"), (short)3, "Course123", new Guid("b51bbea9-0afd-4738-a071-5a774b889837"), new Guid("b09b8afc-d93d-419f-bd2d-c9c2277531d9") },
                    { new Guid("8352c9d3-f4ac-4d10-a4fe-3ef1e154206b"), (short)4, "Course46", new Guid("907d852f-b1fe-4950-9afc-a3e746c9d6d2"), new Guid("501d7bb4-8a43-4591-ba6f-19ea8a68a32d") },
                    { new Guid("0d070d2e-40f5-4838-a84c-302fbe5fa29b"), (short)3, "Course69", new Guid("907d852f-b1fe-4950-9afc-a3e746c9d6d2"), new Guid("8a4e5172-587a-4f9a-a024-fa1a78aac605") },
                    { new Guid("56c49dbc-8b27-4171-99dd-dcd44b119547"), (short)2, "Course92", new Guid("907d852f-b1fe-4950-9afc-a3e746c9d6d2"), new Guid("ce390f41-873c-453d-9f08-1266e2189587") },
                    { new Guid("16102ea6-b874-418f-b396-b4f357a587c1"), (short)1, "Course115", new Guid("907d852f-b1fe-4950-9afc-a3e746c9d6d2"), new Guid("ec29cecf-9bb4-4b00-9d9a-5d0ccad64829") },
                    { new Guid("ef26cc07-065b-46c0-96da-7da5281a4bb6"), (short)5, "Course82", new Guid("b51bbea9-0afd-4738-a071-5a774b889837"), new Guid("0529f9b9-58d2-4049-ad74-15f95b12b9cf") },
                    { new Guid("66e8f984-54bf-441a-a4d9-6d70a6e1c558"), (short)5, "Course41", new Guid("b51bbea9-0afd-4738-a071-5a774b889837"), new Guid("6b48d1dc-3249-4c0a-b1c0-1eced2993fae") },
                    { new Guid("5b60c6ca-faed-4069-aed1-55c550333d65"), (short)2, "Course0", new Guid("b582d2dc-d7ef-412d-89d6-cec2f0a77292"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("50137722-bcf0-432b-81e6-f0b51755cd66"), (short)5, "Course23", new Guid("907d852f-b1fe-4950-9afc-a3e746c9d6d2"), new Guid("b09b8afc-d93d-419f-bd2d-c9c2277531d9") },
                    { new Guid("4fc9fbf0-e173-4712-b671-7b24af214604"), (short)2, "Course300", new Guid("95eed3b1-2718-4d54-87ca-969cb51e880c"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("f338abf6-081f-4832-9a23-4ca2d3329d69"), (short)3, "Course0", new Guid("16bbd598-8c3a-41fc-b681-cd2926aa6ebe"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("7ffca31d-da80-44c6-a37b-25112b5a51a9"), (short)5, "Course78", new Guid("9266f3fa-79cf-434e-8365-4735048d2831"), new Guid("2d18691c-989d-416d-a354-29be08ce9df1") },
                    { new Guid("0c78f673-7ccf-4012-b614-be0d58030494"), (short)5, "Course145", new Guid("a931c6f4-9d60-4304-81ad-a1dfb9be030a"), new Guid("2a164668-67e3-4a12-b8a1-af89e56f1a14") },
                    { new Guid("97ef0c11-c419-4ec4-8fda-1e5a3dea3539"), (short)3, "Course116", new Guid("a931c6f4-9d60-4304-81ad-a1dfb9be030a"), new Guid("8d205a81-e2bc-4419-9b80-76829198e56a") },
                    { new Guid("8f6de52f-1b18-401f-8bf0-a9b3610d802a"), (short)4, "Course87", new Guid("a931c6f4-9d60-4304-81ad-a1dfb9be030a"), new Guid("cb6e00a5-c211-4508-b6d7-cd48332e9344") },
                    { new Guid("4f20e865-db4b-4d1a-9ae2-86839dcf5b8d"), (short)5, "Course58", new Guid("a931c6f4-9d60-4304-81ad-a1dfb9be030a"), new Guid("c02be181-5f7c-4685-89ee-d0b4b1c3dea0") },
                    { new Guid("8cab8270-dea9-4f56-a5af-759a668bfd36"), (short)2, "Course29", new Guid("a931c6f4-9d60-4304-81ad-a1dfb9be030a"), new Guid("ce09c1a2-6510-4c84-a533-688fbff0d1b4") },
                    { new Guid("a13dfea7-3600-4850-8746-093ba3762325"), (short)4, "Course0", new Guid("a931c6f4-9d60-4304-81ad-a1dfb9be030a"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("77fbffc6-bbf4-4991-8619-f2479cabd9a1"), (short)0, "Course400", new Guid("95eed3b1-2718-4d54-87ca-969cb51e880c"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("377d545e-7372-473b-bdd7-1d9c131548f3"), (short)4, "Course500", new Guid("95eed3b1-2718-4d54-87ca-969cb51e880c"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("417c8892-b7dd-448b-89ad-42b664d56033"), (short)5, "Course140", new Guid("a0f85dc6-c855-4030-b1ba-6592434a7f57"), new Guid("057dfd7c-e065-4359-ad7d-4f9203a48204") },
                    { new Guid("5e4376fe-080b-4552-b298-efdea91efc31"), (short)5, "Course112", new Guid("a0f85dc6-c855-4030-b1ba-6592434a7f57"), new Guid("063abe97-7452-429b-8088-ae02501cf52a") },
                    { new Guid("27f7d2b9-7320-4084-82ff-af657ee4a322"), (short)3, "Course84", new Guid("a0f85dc6-c855-4030-b1ba-6592434a7f57"), new Guid("07ed323a-f925-4a9a-bcfa-cbfa4333a7b1") },
                    { new Guid("cebc5029-eb51-4270-8048-30f8cdf7e012"), (short)1, "Course195", new Guid("db5f1cfb-af79-4c71-a881-0276a753b746"), new Guid("5d1d8f68-958b-4b72-a3d9-ab026d6c9b3b") },
                    { new Guid("8edff100-94c8-49b3-ba9e-4e99ca5ce60d"), (short)5, "Course52", new Guid("9266f3fa-79cf-434e-8365-4735048d2831"), new Guid("a5da19b2-60d3-4a47-aa17-6a9bb34f6923") }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("36791b67-8842-428b-a30c-4891f265223d"), (short)0, "Course28", new Guid("a0f85dc6-c855-4030-b1ba-6592434a7f57"), new Guid("a60a1d7e-06fa-458f-8a6b-5665cb75fb3c") },
                    { new Guid("3ad1a1a1-a406-4f01-bfbc-3bb98016b2ea"), (short)3, "Course0", new Guid("a0f85dc6-c855-4030-b1ba-6592434a7f57"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("4131a080-cecc-4fff-8b6d-ce23218a796c"), (short)2, "Course56", new Guid("a0f85dc6-c855-4030-b1ba-6592434a7f57"), new Guid("0a2bec6b-65e9-4c34-8fa8-eb3a98e94d6c") },
                    { new Guid("9d44d24a-c403-4e7b-ad5a-27af3cfd556c"), (short)2, "Course0", new Guid("4dfc9fcf-13e9-4ec2-852b-2b76f9b37bf6"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("8ed924d0-df25-4f61-9d93-be725954729c"), (short)5, "Course135", new Guid("5e01e539-02ee-4509-99c0-0231e369dbc4"), new Guid("5e08f64f-4cf8-4a4f-8b01-640e5291e9ba") },
                    { new Guid("0e25e1c4-92c4-4073-9cc0-48e513ea07d2"), (short)1, "Course40", new Guid("4dfc9fcf-13e9-4ec2-852b-2b76f9b37bf6"), new Guid("057dfd7c-e065-4359-ad7d-4f9203a48204") },
                    { new Guid("29c8ea4c-00b9-4d93-bd0b-998eeaa95f52"), (short)0, "Course80", new Guid("4dfc9fcf-13e9-4ec2-852b-2b76f9b37bf6"), new Guid("0f3a6be6-d338-4180-9f66-12eea50cc59b") },
                    { new Guid("f51956d2-251b-4865-bac4-904aa21da1b8"), (short)1, "Course108", new Guid("5e01e539-02ee-4509-99c0-0231e369dbc4"), new Guid("ebeffb2e-3a83-47bf-b89a-f738c8edc152") },
                    { new Guid("ffa401e5-7123-4519-ac9e-27741158b234"), (short)1, "Course160", new Guid("4dfc9fcf-13e9-4ec2-852b-2b76f9b37bf6"), new Guid("b7e178a9-8cfe-4c9c-aeab-dc77f9f2de35") },
                    { new Guid("b5db031d-bceb-4c21-a72d-4d325b7133a3"), (short)4, "Course81", new Guid("5e01e539-02ee-4509-99c0-0231e369dbc4"), new Guid("271a7c7b-38db-467b-a441-d5f44884446b") },
                    { new Guid("31782b3c-2028-496e-b3bc-68aefcb28156"), (short)2, "Course54", new Guid("5e01e539-02ee-4509-99c0-0231e369dbc4"), new Guid("cb80fe9b-1a1d-4214-bb57-2e630f55f6e9") },
                    { new Guid("72c65298-d726-4339-9b76-3f89037db075"), (short)2, "Course120", new Guid("4dfc9fcf-13e9-4ec2-852b-2b76f9b37bf6"), new Guid("a188125a-5041-418b-ac92-5303ce6e8a12") },
                    { new Guid("f9d9054d-4862-4357-89ce-e4727b012d68"), (short)3, "Course104", new Guid("9266f3fa-79cf-434e-8365-4735048d2831"), new Guid("b525ecf2-7acd-47bd-87ae-5309b598ee56") },
                    { new Guid("2b5b55c5-0fea-458d-8ea4-3c31f9441ec5"), (short)0, "Course27", new Guid("5e01e539-02ee-4509-99c0-0231e369dbc4"), new Guid("c3463b63-6f38-4d78-ba4c-b946177b6401") },
                    { new Guid("26e89cf4-3b10-4bb2-b9a0-adfbe87fa5ad"), (short)0, "Course0", new Guid("5e01e539-02ee-4509-99c0-0231e369dbc4"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("ea90dbbe-31cf-4106-8f95-400c86c3fe78"), (short)4, "Course0", new Guid("be84a8ea-74da-4374-bfc1-d8f30d06b7e6"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("c1444b51-b772-4d03-8071-4f845e94d2f0"), (short)2, "Course101", new Guid("be84a8ea-74da-4374-bfc1-d8f30d06b7e6"), new Guid("c1ca1d9c-52aa-4c4f-a70a-268d06835428") },
                    { new Guid("9bf153f2-098b-49a9-8605-6afd6b4de241"), (short)2, "Course130", new Guid("9266f3fa-79cf-434e-8365-4735048d2831"), new Guid("3c7e6dc1-9f2d-42d3-9e4d-e2431a493beb") }
                });

            migrationBuilder.InsertData(
                table: "OptionalCourses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("00427450-8189-4f75-9e30-41c0d5ae5768"), (short)5, "Course96", new Guid("af06202b-f38f-450b-8c11-8fc66730120d"), new Guid("77abbb72-1f82-42ba-8f26-b31bc1a26767") },
                    { new Guid("206abe8f-f54c-45fb-9881-6c1f223e39b5"), (short)5, "Course86", new Guid("6260768b-db7c-43c8-b6ad-69de7795c445"), new Guid("4adb9302-baad-4231-9a53-e750e5383bc8") },
                    { new Guid("1de9546b-82a3-4fc5-9708-b9939a52bdbe"), (short)0, "Course0", new Guid("af06202b-f38f-450b-8c11-8fc66730120d"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("6ae2f873-7839-4533-9c69-99a14b6f7f1d"), (short)5, "Course106", new Guid("c72b46dc-7ba5-4934-bd46-d8633f2293e5"), new Guid("63e1742b-49cd-41ed-b0dc-d6616bf232ba") },
                    { new Guid("063b8743-8896-4222-8104-cccb1b09ca24"), (short)1, "Course97", new Guid("948db04e-01cc-4694-95d2-63fa40172191"), new Guid("0a56d0c8-98c6-400e-abe3-fb0a9a9f286b") },
                    { new Guid("962c1bdd-ae6a-4529-970c-29413d3c7178"), (short)5, "Course0", new Guid("948db04e-01cc-4694-95d2-63fa40172191"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("d55a7b46-0918-43af-8bb2-d3edeb0c6cbc"), (short)2, "Course0", new Guid("6260768b-db7c-43c8-b6ad-69de7795c445"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("98e62f08-dd08-445f-bf4d-3f6c73c22b79"), (short)3, "Course0", new Guid("d7349cf1-5325-42b1-9313-0f2eff59eaf3"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("f7c409a0-49f6-403d-b747-840a4e33698d"), (short)3, "Course0", new Guid("d299e537-237f-4d2e-9146-b884455575f3"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("f153eb48-30dc-45a5-a50a-a76f90146629"), (short)0, "Course91", new Guid("0cba8627-2e00-41e4-8e20-0a77842874ee"), new Guid("1e35327d-ef8b-4490-bfda-21a7cd39cdd0") },
                    { new Guid("6836446e-af51-4b58-a1c5-48b9c2d47cd3"), (short)2, "Course101", new Guid("be84a8ea-74da-4374-bfc1-d8f30d06b7e6"), new Guid("c1ca1d9c-52aa-4c4f-a70a-268d06835428") },
                    { new Guid("29439911-2153-469a-bb26-abd115367f7c"), (short)4, "Course0", new Guid("be84a8ea-74da-4374-bfc1-d8f30d06b7e6"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("9694b9b4-1684-4bef-92c2-ab84a262bba5"), (short)4, "Course0", new Guid("b1e1b13b-1c0d-4530-a1f5-763d76c7a8ca"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("f0158a3a-2298-450e-9e5f-c8b849c0d8df"), (short)0, "Course102", new Guid("b1e1b13b-1c0d-4530-a1f5-763d76c7a8ca"), new Guid("38eccc3c-7b82-450f-8c4c-bdcbae4ec305") },
                    { new Guid("7b59a691-aea5-480c-b871-0a189d560fd9"), (short)5, "Course0", new Guid("313dd4a1-ce31-495e-be25-5ef618786573"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("b3ec53e9-f86e-40ed-8e57-740ecd73847b"), (short)0, "Course92", new Guid("313dd4a1-ce31-495e-be25-5ef618786573"), new Guid("ce390f41-873c-453d-9f08-1266e2189587") },
                    { new Guid("6ea7b5f0-1ce3-4d13-8553-1a0ca94b0fa0"), (short)5, "Course90", new Guid("c91be2e9-073d-4b39-b2f8-cd198dcf81a8"), new Guid("d3e32fcf-a08d-4708-8b06-0d1ea51a808f") },
                    { new Guid("301c46cb-4303-4dd3-8703-133dfd3e51b4"), (short)1, "Course0", new Guid("c91be2e9-073d-4b39-b2f8-cd198dcf81a8"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("8b8dca1c-33a6-48f2-b71e-f72a162aed06"), (short)5, "Course0", new Guid("e62a2052-e393-49dd-8dda-5f1977a279c0"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("2477bca4-8a5b-4a7e-ba8b-bbce44ed621f"), (short)3, "Course103", new Guid("e62a2052-e393-49dd-8dda-5f1977a279c0"), new Guid("99e90f8f-d4ef-4493-93c7-929399c870d5") },
                    { new Guid("bcd8be92-8bf1-49ef-8ca2-8cfbb6935532"), (short)3, "Course100", new Guid("95eed3b1-2718-4d54-87ca-969cb51e880c"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("4611f390-6837-45a7-85cc-8fef2d96d1a3"), (short)2, "Course0", new Guid("95eed3b1-2718-4d54-87ca-969cb51e880c"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("4b8210ff-3f07-4635-9606-f161a30ce4e5"), (short)1, "Course0", new Guid("4873084f-e5f3-4ebb-93af-1777e95bfb6e"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("2ed121a3-afb9-4b0d-81be-6c6d01c0864f"), (short)4, "Course93", new Guid("4873084f-e5f3-4ebb-93af-1777e95bfb6e"), new Guid("c693d672-a076-4715-8681-ac0e1c9e8ffe") }
                });

            migrationBuilder.InsertData(
                table: "OptionalCourses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("8291530a-b29c-49da-8223-aeb6affaf435"), (short)2, "Course89", new Guid("9b2071c3-7203-448b-ad6e-ae00e1161995"), new Guid("4161656d-8fe1-4a17-915a-7ff4d8343cc3") },
                    { new Guid("8c936da8-ab92-40ae-8c20-c798a40b5289"), (short)5, "Course0", new Guid("9b2071c3-7203-448b-ad6e-ae00e1161995"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("5c8cb8a8-02f0-4842-8981-a7bc9d6999ec"), (short)3, "Course87", new Guid("d299e537-237f-4d2e-9146-b884455575f3"), new Guid("cb6e00a5-c211-4508-b6d7-cd48332e9344") },
                    { new Guid("c28e10d1-7484-4747-b3f6-030fa9996509"), (short)5, "Course0", new Guid("5a26c4e3-d8fa-4b4c-a539-7d274408cfe3"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("2c113018-1fc5-48c8-88d9-6faf89248fa2"), (short)1, "Course95", new Guid("5a2662cc-c496-46eb-9a3f-c599a6888d43"), new Guid("5d1d8f68-958b-4b72-a3d9-ab026d6c9b3b") },
                    { new Guid("a917e7ff-5397-47f8-a9e5-6122160a88d9"), (short)4, "Course0", new Guid("5a2662cc-c496-46eb-9a3f-c599a6888d43"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("e3f0783a-b285-4c03-8915-f62462c6f03b"), (short)3, "Course98", new Guid("5a26c4e3-d8fa-4b4c-a539-7d274408cfe3"), new Guid("7ad86313-7bbc-4d7f-899c-86985ce8b6ab") },
                    { new Guid("639eec63-db14-46c1-b0b0-25fc7edac3bc"), (short)0, "Course105", new Guid("27e43d58-7570-46bc-ba29-eec9624265ea"), new Guid("4769333d-bd39-4438-862b-97f82854efd1") },
                    { new Guid("f5a00626-51fb-4e08-b0b4-03bc4c5800a0"), (short)1, "Course0", new Guid("c72b46dc-7ba5-4934-bd46-d8633f2293e5"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("c55391dd-a1bc-4a57-8c76-a45b26e558ba"), (short)5, "Course0", new Guid("27e43d58-7570-46bc-ba29-eec9624265ea"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("ba1a5454-c798-4c8d-85b1-28a058ea90cc"), (short)0, "Course88", new Guid("52bc0a8f-57c0-4c34-9c11-4dd6ba359789"), new Guid("e6b51413-4b52-4843-85a2-78ed2c0eea2f") },
                    { new Guid("b4518f8f-f3f7-4ecd-b65e-83fc933967f6"), (short)0, "Course94", new Guid("c57f448e-4350-49ee-8820-9a69c773dfb1"), new Guid("8766bb6f-dce9-4dac-a46c-7c2a0243cf58") },
                    { new Guid("0fc0ebef-b91e-4c1a-b2c1-bb94c3fc7756"), (short)5, "Course0", new Guid("c57f448e-4350-49ee-8820-9a69c773dfb1"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("09ace841-cab4-402b-8f9a-5a3514da14ef"), (short)1, "Course99", new Guid("d7349cf1-5325-42b1-9313-0f2eff59eaf3"), new Guid("11d3e5cc-d08b-4545-aa68-881baf307590") },
                    { new Guid("69e7d901-dca5-4fc3-bbeb-3a1d0240e5f5"), (short)0, "Course104", new Guid("be0461b9-8bf4-429e-a034-39a1ae1f0265"), new Guid("b525ecf2-7acd-47bd-87ae-5309b598ee56") },
                    { new Guid("ecd0186d-34d6-4a44-bd14-9f8047d47c8b"), (short)1, "Course0", new Guid("be0461b9-8bf4-429e-a034-39a1ae1f0265"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("35733407-4aa4-4159-9fdb-16c4fa9eaaab"), (short)1, "Course0", new Guid("52bc0a8f-57c0-4c34-9c11-4dd6ba359789"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("2e7858da-f950-4300-9c0d-f24f355425ce"), (short)3, "Course0", new Guid("0cba8627-2e00-41e4-8e20-0a77842874ee"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("1e0cc69a-0479-4b70-99fb-c4f4e377b6e9"), (short)5, "Course53", new Guid("cedd27c4-267a-40f2-a0f0-87ca80472d9d"), new Guid("f24549c9-0ce2-4f17-b827-6994bf335d46") },
                    { new Guid("a5c04128-75f3-4d19-a9a0-7a4577aa02ef"), (short)5, "Course0", new Guid("448af37f-cac6-4d46-ad76-2b96c15aa522"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("a881f091-5c20-4fcc-bdd6-fd820c482bc3"), (short)1, "Course0", new Guid("d958eb54-3146-41c7-8977-2aa0cb663551"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("22c2943c-8ba3-4965-866c-4b4266ac5995"), (short)3, "Course29", new Guid("a931c6f4-9d60-4304-81ad-a1dfb9be030a"), new Guid("ce09c1a2-6510-4c84-a533-688fbff0d1b4") },
                    { new Guid("a9fc3faa-9252-46f4-9a4f-8185417f58a5"), (short)3, "Course0", new Guid("a931c6f4-9d60-4304-81ad-a1dfb9be030a"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("da7374f4-9c06-472e-a617-32c423a22cb0"), (short)0, "Course28", new Guid("a0f85dc6-c855-4030-b1ba-6592434a7f57"), new Guid("a60a1d7e-06fa-458f-8a6b-5665cb75fb3c") },
                    { new Guid("ecc38925-a001-4768-a433-6d36197fd0fb"), (short)1, "Course0", new Guid("a0f85dc6-c855-4030-b1ba-6592434a7f57"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("c7ee94a8-1727-4f09-a8c7-abe1f3a0538f"), (short)2, "Course27", new Guid("5e01e539-02ee-4509-99c0-0231e369dbc4"), new Guid("c3463b63-6f38-4d78-ba4c-b946177b6401") },
                    { new Guid("76329fd5-8908-440a-89f0-4bbdd3cbfaf3"), (short)3, "Course0", new Guid("5e01e539-02ee-4509-99c0-0231e369dbc4"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("c37f77ba-35b7-4f64-8609-770636f6d97d"), (short)1, "Course26", new Guid("9266f3fa-79cf-434e-8365-4735048d2831"), new Guid("ba0e5c03-6f8b-4477-9e10-0a882b4c3832") },
                    { new Guid("12c5c906-bf3c-4906-80dd-610cfa151004"), (short)0, "Course0", new Guid("9266f3fa-79cf-434e-8365-4735048d2831"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("5d1c8d14-69b1-4846-827e-8b405c3d04fc"), (short)3, "Course25", new Guid("5c881e8f-502b-4278-83c7-66bd963880bb"), new Guid("6985d0e1-cd88-42c9-814a-158b42abd6d6") },
                    { new Guid("6735721d-cd78-4b9f-8e7a-f2e5c69ca744"), (short)2, "Course0", new Guid("5c881e8f-502b-4278-83c7-66bd963880bb"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("8b955a3e-0e98-4f76-b03c-f302b619bd75"), (short)2, "Course24", new Guid("b582d2dc-d7ef-412d-89d6-cec2f0a77292"), new Guid("d8ddd747-6d87-410d-bf56-417d725c9a22") },
                    { new Guid("a8ca35d8-bddc-4347-9a54-2b7e9e6a835b"), (short)3, "Course0", new Guid("b582d2dc-d7ef-412d-89d6-cec2f0a77292"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("ce84b3aa-9f71-412c-b7a5-4d23b4e11537"), (short)1, "Course23", new Guid("907d852f-b1fe-4950-9afc-a3e746c9d6d2"), new Guid("b09b8afc-d93d-419f-bd2d-c9c2277531d9") },
                    { new Guid("30492c2b-6156-4680-a7f1-966300dbd148"), (short)4, "Course0", new Guid("907d852f-b1fe-4950-9afc-a3e746c9d6d2"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("ce394b92-27c7-42c4-9115-cadbf73ec318"), (short)3, "Course22", new Guid("d9a848e5-db20-40f7-83aa-f546c4796307"), new Guid("69f353ab-b263-41df-ad3e-e3fb8493d9ac") },
                    { new Guid("e7a43b47-50f8-4560-a785-3b16ec77e177"), (short)5, "Course0", new Guid("d9a848e5-db20-40f7-83aa-f546c4796307"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("8eff2996-22b0-44a7-8e4e-e77715b91532"), (short)5, "Course30", new Guid("d958eb54-3146-41c7-8977-2aa0cb663551"), new Guid("3c7e6dc1-9f2d-42d3-9e4d-e2431a493beb") },
                    { new Guid("36ae2d8e-7ac3-4007-bfec-de10689502ae"), (short)4, "Course0", new Guid("e4124ca5-3a97-4dfd-a778-d6d7f390d0e2"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("8f37800a-9b09-4f31-875f-9509d3c72aca"), (short)4, "Course31", new Guid("e4124ca5-3a97-4dfd-a778-d6d7f390d0e2"), new Guid("a338538a-abb1-4870-b2be-f707276ce47b") },
                    { new Guid("61002e77-9dd2-4126-ae98-98c631891fa0"), (short)5, "Course0", new Guid("87fe76e1-3d2d-423e-abb6-68bf23ff2ae4"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("327470e1-e9eb-466d-a388-5fa859aab073"), (short)4, "Course0", new Guid("b51bbea9-0afd-4738-a071-5a774b889837"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") }
                });

            migrationBuilder.InsertData(
                table: "OptionalCourses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("f5abbe2c-2466-4143-9011-c0f97d06fcf7"), (short)4, "Course40", new Guid("4dfc9fcf-13e9-4ec2-852b-2b76f9b37bf6"), new Guid("057dfd7c-e065-4359-ad7d-4f9203a48204") },
                    { new Guid("f1f87f7b-c672-4aa6-9339-31327d56e589"), (short)5, "Course0", new Guid("4dfc9fcf-13e9-4ec2-852b-2b76f9b37bf6"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("9c54d910-07a8-4aed-ba07-90eccb1f1e05"), (short)1, "Course39", new Guid("db5f1cfb-af79-4c71-a881-0276a753b746"), new Guid("7c3a81a4-266d-4f0c-b73a-38e6d61e9622") },
                    { new Guid("0baf744a-56bb-4d47-84b8-a9b6667ae6b3"), (short)2, "Course0", new Guid("db5f1cfb-af79-4c71-a881-0276a753b746"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("257474ee-eef9-4ff6-a783-997e8851b579"), (short)1, "Course38", new Guid("16bbd598-8c3a-41fc-b681-cd2926aa6ebe"), new Guid("64f7e86e-e102-4040-acc2-89d5c9c06788") },
                    { new Guid("ba589761-e059-4c2f-a29e-9cadd11cf75c"), (short)5, "Course0", new Guid("16bbd598-8c3a-41fc-b681-cd2926aa6ebe"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("27e2a2e3-39ad-4b1d-b250-15b9dfe9fc35"), (short)3, "Course37", new Guid("bc11631b-0491-416b-b1ff-18ab635820e2"), new Guid("7edca406-8727-4468-98f7-a23690714cf9") },
                    { new Guid("9eab98d3-22b2-4338-8ad1-d0857fe26a9a"), (short)4, "Course21", new Guid("ce35b0a1-60a7-4966-892e-ce9b859e0585"), new Guid("88cd051e-9532-48bd-813a-11525e0bc1af") },
                    { new Guid("06b5f55b-846a-497c-aa80-3ac96537152a"), (short)2, "Course0", new Guid("bc11631b-0491-416b-b1ff-18ab635820e2"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("ad8ff214-5498-413f-a52c-9941ab792a51"), (short)4, "Course0", new Guid("24594659-f059-49b0-8cf7-ba8b09eb0caf"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("878d8a55-6623-4dac-b0f6-bb2f30805bc5"), (short)4, "Course35", new Guid("81575b03-8d04-4bf2-a869-3404de699b61"), new Guid("5e08f64f-4cf8-4a4f-8b01-640e5291e9ba") },
                    { new Guid("69955edd-46b2-4dce-9956-f806aed6aca2"), (short)4, "Course0", new Guid("81575b03-8d04-4bf2-a869-3404de699b61"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("4c311789-cc2c-45f9-9dc4-2415ce6d200e"), (short)4, "Course34", new Guid("1a79ae16-e107-4464-a22f-5bd96be4b2e3"), new Guid("0fd529d1-e3e2-47c5-b856-7aba08cbbbf0") },
                    { new Guid("48ded944-cc48-4c76-8a09-99b67455b739"), (short)1, "Course0", new Guid("1a79ae16-e107-4464-a22f-5bd96be4b2e3"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("8b080705-3b5b-4fe1-933f-f815fdbfb0b4"), (short)1, "Course33", new Guid("6fcc89ca-3601-4bd4-9ea8-137469053e94"), new Guid("c0b88834-6a9a-4c54-9efd-9eba8cba2b31") },
                    { new Guid("89bfefe7-37cb-4e9d-99d1-80d383c491fb"), (short)3, "Course0", new Guid("6fcc89ca-3601-4bd4-9ea8-137469053e94"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("482e8325-1986-4c5f-8260-781f9ed4318d"), (short)4, "Course32", new Guid("87fe76e1-3d2d-423e-abb6-68bf23ff2ae4"), new Guid("d27b117a-d80a-4155-8dfa-522f22cd4429") },
                    { new Guid("b5364a53-48ef-47ed-a431-fcbeeb8235d2"), (short)3, "Course36", new Guid("24594659-f059-49b0-8cf7-ba8b09eb0caf"), new Guid("3f76ac73-0ba7-4d6a-ab40-bc387998856f") },
                    { new Guid("8e326157-995c-47ff-91bd-8131ba2d21c1"), (short)4, "Course0", new Guid("ce35b0a1-60a7-4966-892e-ce9b859e0585"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("dfd106c3-688a-4ec7-a310-472a011cb35e"), (short)2, "Course20", new Guid("e2237afc-8e86-4571-afa7-b3741418bc38"), new Guid("a188125a-5041-418b-ac92-5303ce6e8a12") },
                    { new Guid("0fd08e6c-0007-4ca4-8634-65851d64b77e"), (short)1, "Course0", new Guid("e2237afc-8e86-4571-afa7-b3741418bc38"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("daa5a389-753f-49df-ae73-3e18df435ead"), (short)2, "Course8", new Guid("475c557a-fd49-4063-9110-e75d3c0ad792"), new Guid("ebeffb2e-3a83-47bf-b89a-f738c8edc152") },
                    { new Guid("e62a9428-cb16-48f0-b466-5eeaf9e61054"), (short)2, "Course0", new Guid("475c557a-fd49-4063-9110-e75d3c0ad792"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("1fd1773b-3374-416e-bfe7-a95df88e7d36"), (short)1, "Course7", new Guid("a43aeedd-5642-410a-b006-f5bd23bb6afc"), new Guid("5a91c10d-b6e0-4886-9ff9-10107fcb6761") },
                    { new Guid("f255a1ba-2d4c-4997-b5f9-a9d2bacd2717"), (short)0, "Course0", new Guid("a43aeedd-5642-410a-b006-f5bd23bb6afc"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("e38d492a-cb2e-4ab7-95a8-9133d16753d4"), (short)3, "Course6", new Guid("4ab0f3a8-256f-407b-b9dd-ae5fc5d3d6df"), new Guid("63e1742b-49cd-41ed-b0dc-d6616bf232ba") },
                    { new Guid("1b7d8fb7-0f81-411e-b500-497e1a661e93"), (short)5, "Course0", new Guid("4ab0f3a8-256f-407b-b9dd-ae5fc5d3d6df"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("751fea05-1fdd-4aba-b833-5f513edd9c5e"), (short)5, "Course5", new Guid("7105bfa0-0571-4c9b-af19-748123a22da2"), new Guid("4769333d-bd39-4438-862b-97f82854efd1") },
                    { new Guid("cf3ed867-c9c5-489b-a22f-49d8e9abb95a"), (short)3, "Course0", new Guid("7105bfa0-0571-4c9b-af19-748123a22da2"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("f0a30ae4-29a6-4244-8758-9f9666c8f5f8"), (short)5, "Course0", new Guid("1f729851-ec34-41f4-a629-c8c322acd5ea"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("bb05a410-124f-43a2-8706-e1c5b3948d51"), (short)3, "Course4", new Guid("6aa84bea-944d-4081-b6c6-d4c938ad12bd"), new Guid("b525ecf2-7acd-47bd-87ae-5309b598ee56") },
                    { new Guid("67f94c49-3db1-4041-a13c-d8a30bbf3bd0"), (short)0, "Course3", new Guid("af58f530-80db-4ef5-8961-819c6b18453e"), new Guid("99e90f8f-d4ef-4493-93c7-929399c870d5") },
                    { new Guid("a95e201b-f7b0-43df-83e9-7c5e944f8b16"), (short)2, "Course0", new Guid("af58f530-80db-4ef5-8961-819c6b18453e"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("9790264e-3bd7-4d2b-8ecd-95a61253d84c"), (short)3, "Course2", new Guid("b7509275-37e5-4ce6-9402-e01efafc00c3"), new Guid("38eccc3c-7b82-450f-8c4c-bdcbae4ec305") },
                    { new Guid("700883ab-0b2a-404f-bbdd-879908916d60"), (short)3, "Course0", new Guid("b7509275-37e5-4ce6-9402-e01efafc00c3"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("01e149bf-a905-4910-819d-b759443a9667"), (short)0, "Course1", new Guid("0c5e5c66-4cf4-4666-876e-3a1de1a85d92"), new Guid("c1ca1d9c-52aa-4c4f-a70a-268d06835428") },
                    { new Guid("96aaff7d-9226-4d85-ac21-5dd04c3f106b"), (short)0, "Course0", new Guid("0c5e5c66-4cf4-4666-876e-3a1de1a85d92"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("6835ec29-7d43-485a-b778-63df211acfd2"), (short)1, "Course0", new Guid("ea6d9d48-6e3d-436f-9ce0-d725e934f311"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("b176b53e-7c91-4de1-8ba7-1f8f138b618f"), (short)4, "Course0", new Guid("ea6d9d48-6e3d-436f-9ce0-d725e934f311"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("30f28f6e-8ea3-4365-97bd-24dc3b0b9688"), (short)0, "Course0", new Guid("6aa84bea-944d-4081-b6c6-d4c938ad12bd"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("6f44f636-7779-4ef6-882f-6b327fcccf14"), (short)3, "Course41", new Guid("b51bbea9-0afd-4738-a071-5a774b889837"), new Guid("6b48d1dc-3249-4c0a-b1c0-1eced2993fae") },
                    { new Guid("6e58b18a-b7d5-459c-a3bd-fa31e8f6d792"), (short)0, "Course9", new Guid("1f729851-ec34-41f4-a629-c8c322acd5ea"), new Guid("a78db448-cd3f-412c-9d1e-0fd2a204ba46") }
                });

            migrationBuilder.InsertData(
                table: "OptionalCourses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("81059acd-7b27-493c-8bbf-e2dc408013a9"), (short)4, "Course10", new Guid("330d8cef-7199-4287-871b-64aa88ce2123"), new Guid("13204af6-237b-4597-bb1a-c82c23c09636") },
                    { new Guid("38f49376-2d5a-4f08-85f0-7f016df57d00"), (short)5, "Course19", new Guid("6dd9c059-e6f3-4116-b9ab-47f8c0f60c1d"), new Guid("86902e3d-1f5b-4abe-9ab7-3fd73dd5ab90") },
                    { new Guid("76678ebc-7d16-43e2-91e4-506fe036cdd3"), (short)3, "Course0", new Guid("6dd9c059-e6f3-4116-b9ab-47f8c0f60c1d"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("ca879c35-6f91-4d67-8a75-04a8de820413"), (short)0, "Course18", new Guid("c8ea306c-571d-484a-b0ec-787254efcb71"), new Guid("a6f53d31-2194-4fad-b679-d54cba290f0a") },
                    { new Guid("7173d661-233a-4cb0-91c6-7d491ac80c8e"), (short)1, "Course0", new Guid("c8ea306c-571d-484a-b0ec-787254efcb71"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("fd6ed403-6843-4349-afd5-2c056b59558d"), (short)3, "Course17", new Guid("077719f8-99b6-44d7-8e24-56e22f03f4f6"), new Guid("a62b56c5-0991-4667-bd30-c537863e29b8") },
                    { new Guid("0097aef2-e173-470d-aea8-a93bae9a4ca4"), (short)2, "Course0", new Guid("077719f8-99b6-44d7-8e24-56e22f03f4f6"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("ad51ad64-3415-4f4c-a55d-15322ab17bf0"), (short)4, "Course16", new Guid("ff4bb88a-b6d6-4256-9ea0-fe93fcd9697c"), new Guid("8d205a81-e2bc-4419-9b80-76829198e56a") },
                    { new Guid("1fbaf758-1543-4c85-ba4f-474139743635"), (short)1, "Course0", new Guid("ff4bb88a-b6d6-4256-9ea0-fe93fcd9697c"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("999ea8b7-c728-4992-9f4d-4764383f02a0"), (short)0, "Course0", new Guid("330d8cef-7199-4287-871b-64aa88ce2123"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("28e969a2-4bbb-4ae4-bfa5-9553923ca11d"), (short)3, "Course15", new Guid("bdd6e79a-ad46-491c-8b58-e72975ac7f04"), new Guid("ec29cecf-9bb4-4b00-9d9a-5d0ccad64829") },
                    { new Guid("c6cf7793-f455-4005-99cf-f641d8728ba2"), (short)2, "Course14", new Guid("04f1be8e-ccc0-41e3-921a-71f2e2915a29"), new Guid("5eb8b880-4da8-4c05-9c7b-0e9c25dc8cac") },
                    { new Guid("d650dc11-73cc-475e-acb2-536ac96217fa"), (short)2, "Course0", new Guid("04f1be8e-ccc0-41e3-921a-71f2e2915a29"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("b8cc9c8d-673c-4f7f-95cb-06af185cfa43"), (short)3, "Course13", new Guid("46f266a3-7b60-4d2f-ba82-d0a00be6b470"), new Guid("18ada024-e7e8-40f8-98c2-7f773bbbb751") },
                    { new Guid("9c5c96a8-99c2-4d2a-9fbb-d3fd3f70c558"), (short)2, "Course0", new Guid("46f266a3-7b60-4d2f-ba82-d0a00be6b470"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("969f76fb-fd4a-416b-b940-697bd7034fa7"), (short)0, "Course12", new Guid("d8cda68e-9336-4490-8716-b0196825807a"), new Guid("063abe97-7452-429b-8088-ae02501cf52a") },
                    { new Guid("67ef47f5-ca22-4192-887d-2a1a90b230ae"), (short)0, "Course0", new Guid("d8cda68e-9336-4490-8716-b0196825807a"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("d5d42cfa-9d5e-4917-91bd-bd1578f774e1"), (short)1, "Course11", new Guid("2c6cd864-2fe9-42c7-8bfe-8f7489e5810f"), new Guid("86828be7-9d59-413e-8b29-4318311399e4") },
                    { new Guid("896ac401-17e8-42de-812a-64613bfc15e0"), (short)2, "Course0", new Guid("2c6cd864-2fe9-42c7-8bfe-8f7489e5810f"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("e230faaa-c81e-4586-9be8-d9e28b31765e"), (short)0, "Course0", new Guid("bdd6e79a-ad46-491c-8b58-e72975ac7f04"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("34f431ef-4cae-42a2-a2fa-3ddb7d87ad7f"), (short)1, "Course85", new Guid("448af37f-cac6-4d46-ad76-2b96c15aa522"), new Guid("1bb30181-e8ba-4ab9-85d3-d81474aca8d1") },
                    { new Guid("c15371b4-a255-4dd8-91ed-afb91fea8b74"), (short)1, "Course0", new Guid("081cc945-5a01-4975-b6e6-387f6ac3ece8"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("add9b43c-f713-4aac-8f28-4b64997d1d70"), (short)3, "Course0", new Guid("b72b47d3-75c7-4543-9afc-5fd2000145d5"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("a682bf19-2d8e-4ec4-837f-db2b93e7dc60"), (short)1, "Course73", new Guid("f3acc840-3869-4c6c-9089-368d02fa3f8e"), new Guid("d9de457e-9281-402d-98fd-7d467de2be83") },
                    { new Guid("9d15e1bc-2441-47dd-ad2c-2e90609303d7"), (short)4, "Course0", new Guid("f3acc840-3869-4c6c-9089-368d02fa3f8e"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("5cd39e5d-c346-4003-bdcf-d7f34572e67f"), (short)1, "Course72", new Guid("6b107f46-46e2-4aca-ae01-a384b0d64a00"), new Guid("ed1486d0-4af1-449f-882e-93b5bc021952") },
                    { new Guid("29f32872-397a-4b8b-9fa8-c2bdcfc0080a"), (short)1, "Course0", new Guid("6b107f46-46e2-4aca-ae01-a384b0d64a00"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("016421b4-7e9c-49be-8b67-98721d92a176"), (short)4, "Course71", new Guid("4833707f-1cef-4669-97ab-ddded2a3422a"), new Guid("70ebd0f8-7890-43df-9cce-ceeabc3afca3") },
                    { new Guid("aa58ff95-862f-4109-891b-68eafe04431c"), (short)1, "Course0", new Guid("4833707f-1cef-4669-97ab-ddded2a3422a"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("80f69817-196b-4745-a39b-64b7b35a0769"), (short)3, "Course70", new Guid("8da7984a-6afa-45f0-87ac-36aa60384975"), new Guid("a07c095e-f185-4765-958b-121530f33152") },
                    { new Guid("8353c06d-df6e-4c6a-8bdb-cb7b09dbc90c"), (short)0, "Course0", new Guid("8da7984a-6afa-45f0-87ac-36aa60384975"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("a25fe166-e698-4b65-bea1-37c8b7c715b0"), (short)0, "Course69", new Guid("31d1d97d-2694-4cdf-a1d5-0c3e386f072a"), new Guid("8a4e5172-587a-4f9a-a024-fa1a78aac605") },
                    { new Guid("5b312f9b-6b60-4f1b-a3b1-2d556f844bb1"), (short)0, "Course0", new Guid("31d1d97d-2694-4cdf-a1d5-0c3e386f072a"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("d266acb9-3218-4bbc-afc6-2d9f226fade2"), (short)0, "Course68", new Guid("260a5d56-6f38-43ee-b545-33dd4f88cccc"), new Guid("4bc31229-4343-493d-94ba-f19b12c1369e") },
                    { new Guid("6dfc4960-7927-435f-b91b-bf09ab1f9328"), (short)0, "Course0", new Guid("260a5d56-6f38-43ee-b545-33dd4f88cccc"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("5521205e-2361-4eea-8f8c-11a49db55f93"), (short)0, "Course67", new Guid("ec58bf3c-46fa-42a7-a277-e789f35aa6bd"), new Guid("4a2d65f4-7aa3-4350-83f3-35994bbcb0d9") },
                    { new Guid("80b840f4-4605-4e7c-bb55-faa3d9b9e5f7"), (short)3, "Course0", new Guid("ec58bf3c-46fa-42a7-a277-e789f35aa6bd"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("087fbade-5581-4c40-83b6-4e7bd895fa19"), (short)5, "Course66", new Guid("95bef003-e624-4a2c-b353-abd991f97c9d"), new Guid("d45a85ca-e996-416a-b2d8-606426c8a15a") },
                    { new Guid("133e7f50-27b7-44fa-807b-23c63225625c"), (short)2, "Course0", new Guid("95bef003-e624-4a2c-b353-abd991f97c9d"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("154e509b-cb61-4403-b79e-1d48e7439cd4"), (short)1, "Course65", new Guid("edfe5fec-2e28-470d-a752-528e295a7a1d"), new Guid("71fbe949-8b66-4ee4-b52b-3c5370663ef6") },
                    { new Guid("25e5eb70-0e5b-4cc4-be97-de9be3ead1db"), (short)5, "Course0", new Guid("35c1baf9-0879-40b6-b538-5b59f815e8c2"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("98cd6517-8da6-4adb-86a3-49ebbd40befc"), (short)1, "Course74", new Guid("35c1baf9-0879-40b6-b538-5b59f815e8c2"), new Guid("c4a5a9d7-7554-4f06-9602-178bba9fb90f") }
                });

            migrationBuilder.InsertData(
                table: "OptionalCourses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("c6669080-5b52-4ba5-ab72-fc443b7e17db"), (short)1, "Course0", new Guid("bd932240-c2f0-4585-ae4b-578c673c95ee"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("d84d288a-790b-4ccc-bb2c-2e29c1c6bd2c"), (short)1, "Course75", new Guid("bd932240-c2f0-4585-ae4b-578c673c95ee"), new Guid("92b3dc88-fead-4a45-aba3-4aeae5dbec80") },
                    { new Guid("715def3d-62d2-4410-b784-047cd212b69b"), (short)3, "Course84", new Guid("ef4de7e3-ff4f-472f-90db-1dd4522b68c0"), new Guid("07ed323a-f925-4a9a-bcfa-cbfa4333a7b1") },
                    { new Guid("249ee45e-f0ba-426e-9f8c-bbb3c63ab97a"), (short)5, "Course0", new Guid("ef4de7e3-ff4f-472f-90db-1dd4522b68c0"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("1b8bb530-6e87-449f-a190-d563c355c82b"), (short)3, "Course83", new Guid("cf575b9b-0435-4db6-8a44-045bc22e6c3f"), new Guid("f7e5f018-9a10-4752-9db7-83a5ca102f64") },
                    { new Guid("3fe7b8a8-0168-4030-83f6-49c8db35f75c"), (short)5, "Course0", new Guid("cf575b9b-0435-4db6-8a44-045bc22e6c3f"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("21b3ef11-f820-4b6f-8afa-65eef230ee51"), (short)4, "Course82", new Guid("6543866f-3fb6-4d73-b99d-a914c389d363"), new Guid("0529f9b9-58d2-4049-ad74-15f95b12b9cf") },
                    { new Guid("865092cc-634c-4e1e-be71-e7cb01d2c366"), (short)3, "Course0", new Guid("6543866f-3fb6-4d73-b99d-a914c389d363"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("fc2f7832-1f28-491e-abe5-88020dd791d0"), (short)0, "Course81", new Guid("e2ee5fd1-dd4f-4079-a88d-fd45ac37094e"), new Guid("271a7c7b-38db-467b-a441-d5f44884446b") },
                    { new Guid("f002bdb2-bf9b-4763-b5e8-2874519bb205"), (short)4, "Course0", new Guid("e2ee5fd1-dd4f-4079-a88d-fd45ac37094e"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("bb65a903-1af4-4fc5-899d-7b5f87b8e0fb"), (short)4, "Course0", new Guid("edfe5fec-2e28-470d-a752-528e295a7a1d"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("92496c02-d2ce-49b9-992d-849c62aa8bcd"), (short)5, "Course80", new Guid("90740841-d602-4469-a39e-e2971ff1f366"), new Guid("0f3a6be6-d338-4180-9f66-12eea50cc59b") },
                    { new Guid("2fd91ec7-1bf2-4493-a903-57aee151d8ce"), (short)4, "Course79", new Guid("ed288f86-5f81-487f-a090-280ca0dfac4e"), new Guid("1766f994-8239-4121-b06d-ad7564b3bfc6") },
                    { new Guid("68bd3c71-aedc-4bd2-89e5-b15ffe2768f1"), (short)3, "Course0", new Guid("ed288f86-5f81-487f-a090-280ca0dfac4e"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("73f3634b-e667-43c3-9265-7c51974c2eec"), (short)2, "Course78", new Guid("be6619cc-a2d5-4765-814d-9b2feee87b89"), new Guid("2d18691c-989d-416d-a354-29be08ce9df1") },
                    { new Guid("61920e8f-218f-4ae8-8b34-357d99bf075a"), (short)0, "Course0", new Guid("be6619cc-a2d5-4765-814d-9b2feee87b89"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("7f12113a-954b-4f5c-94ca-dc05f4a84f8c"), (short)5, "Course77", new Guid("a90d92b7-bb0c-49b0-9a76-a384554d2856"), new Guid("d3d71917-ddd3-40d3-9ba2-c2d1827161e5") },
                    { new Guid("008395bf-b69e-417f-ac48-e932d157b3ca"), (short)4, "Course0", new Guid("a90d92b7-bb0c-49b0-9a76-a384554d2856"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("ccb8805c-ba55-46f0-a1cd-5b88f9d7d42e"), (short)2, "Course76", new Guid("fb665d42-4b97-40cc-b2cd-53ddf9f111a8"), new Guid("a906fee8-00ee-4be0-aa58-fc3469ded86a") },
                    { new Guid("c9f2055a-8c36-4f39-a6b2-c84f6fae52b8"), (short)2, "Course0", new Guid("fb665d42-4b97-40cc-b2cd-53ddf9f111a8"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("b8d83a52-bc04-4c6c-bb5b-8782a5e47e0f"), (short)2, "Course0", new Guid("90740841-d602-4469-a39e-e2971ff1f366"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("aaf43734-fca0-4d0e-902b-1154df94e7d9"), (short)5, "Course64", new Guid("369aba17-6ac2-4c10-9f1a-110ca5d4fa3c"), new Guid("c8258a3d-48f8-4eac-b14e-18ced7b5618e") },
                    { new Guid("8b159519-74ad-4a08-8aa6-73fba452c90b"), (short)2, "Course0", new Guid("369aba17-6ac2-4c10-9f1a-110ca5d4fa3c"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("cb27e7e6-aa5d-499a-9f3f-5e81072e031f"), (short)3, "Course63", new Guid("edcdf2d2-e581-4950-b51c-d56b0fd95a74"), new Guid("105a879d-9688-41fc-85f0-a8743376ac65") },
                    { new Guid("cc08422d-0c86-491a-be25-1d52e3e17f80"), (short)1, "Course0", new Guid("51d323aa-078d-4376-b325-0a32fda1b988"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("819a134b-53ad-4a52-94dc-7a3a050023cb"), (short)4, "Course51", new Guid("de9b8934-ea96-4bff-bf45-e910ed1e9603"), new Guid("68b80fce-73ac-4d0a-8df7-929dde1bad2b") },
                    { new Guid("6b3c473f-2af6-458b-82aa-a63d7675042a"), (short)1, "Course0", new Guid("de9b8934-ea96-4bff-bf45-e910ed1e9603"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("4b323d51-3630-4102-b621-e718adfcd0dc"), (short)2, "Course50", new Guid("c904906c-036e-4feb-8775-92c3d78524df"), new Guid("a6a34e96-0ca8-49d8-a157-d49457805cae") },
                    { new Guid("50070cf2-3bc3-4bbb-997e-c55665caa885"), (short)3, "Course0", new Guid("c904906c-036e-4feb-8775-92c3d78524df"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("bf2d1567-a9e3-4d83-906c-e816dea8b82e"), (short)4, "Course49", new Guid("1589bfb4-5aae-44bb-84c8-fd7a265c73be"), new Guid("2b8b30bd-1ff4-4f45-81e7-92d191fae001") },
                    { new Guid("93bab3b4-7584-4602-9e92-9e28e42c516d"), (short)3, "Course0", new Guid("1589bfb4-5aae-44bb-84c8-fd7a265c73be"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("882a8345-0e3d-4c3d-b73c-7e4b33fa347d"), (short)1, "Course48", new Guid("5a2feda2-ecce-428d-8a90-c8eebab44fc9"), new Guid("adbec3db-e798-4b59-a8a1-3ef0c251f642") },
                    { new Guid("438d5885-e14d-40f8-b971-bfa6269384fe"), (short)3, "Course52", new Guid("51d323aa-078d-4376-b325-0a32fda1b988"), new Guid("a5da19b2-60d3-4a47-aa17-6a9bb34f6923") },
                    { new Guid("fbd5061b-ba1b-4769-88b6-4bd7c86496c3"), (short)1, "Course0", new Guid("5a2feda2-ecce-428d-8a90-c8eebab44fc9"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("07cca817-a307-4d4f-a581-8fd0655d1ef1"), (short)1, "Course0", new Guid("1f6234b3-22c7-474d-a894-77013b7832eb"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("e0b72032-ee1f-40ac-b097-0d77b1105c50"), (short)1, "Course46", new Guid("fd7bf6f3-64b3-4f02-b1ad-6fd62014be98"), new Guid("501d7bb4-8a43-4591-ba6f-19ea8a68a32d") },
                    { new Guid("bb2f068d-c50a-47b8-8f02-f5b2b07d1730"), (short)2, "Course0", new Guid("fd7bf6f3-64b3-4f02-b1ad-6fd62014be98"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("c80015d5-8f76-4d9c-99b1-d6f05aeb6b5a"), (short)3, "Course45", new Guid("33ab0796-72e9-4709-8e75-4560d3609e38"), new Guid("2a164668-67e3-4a12-b8a1-af89e56f1a14") },
                    { new Guid("47d1e729-a710-40f3-8f8e-23fe5be8bfba"), (short)0, "Course0", new Guid("33ab0796-72e9-4709-8e75-4560d3609e38"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("75c659ae-ff9a-45a8-8c16-321fad42a407"), (short)4, "Course44", new Guid("feecd83c-4205-49ce-ba72-610ff9124065"), new Guid("0fe90da4-1897-46a6-a2e8-5326e2ad84d8") },
                    { new Guid("6a495201-43da-45a9-b6a0-d9cb2a8bd177"), (short)5, "Course0", new Guid("feecd83c-4205-49ce-ba72-610ff9124065"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("3e1e6a08-e05e-4d14-b20f-2d9e3abb2725"), (short)3, "Course43", new Guid("b72b47d3-75c7-4543-9afc-5fd2000145d5"), new Guid("f695bb45-0fcc-4233-b615-69daac6c3ac7") }
                });

            migrationBuilder.InsertData(
                table: "OptionalCourses",
                columns: new[] { "Id", "Credits", "Name", "SemesterId", "TeacherId" },
                values: new object[,]
                {
                    { new Guid("41532518-4fa1-49e9-a3d9-104489605c57"), (short)1, "Course47", new Guid("1f6234b3-22c7-474d-a894-77013b7832eb"), new Guid("8c7fd48c-4b7c-4b23-a1eb-7b91ac817ded") },
                    { new Guid("510ced57-020f-46f9-ae29-e5f709e0c472"), (short)2, "Course42", new Guid("081cc945-5a01-4975-b6e6-387f6ac3ece8"), new Guid("6cc73e31-6f80-4272-82bf-eb0a1325aeb4") },
                    { new Guid("17c5e005-e058-4ebe-94d9-c71513cdc323"), (short)5, "Course0", new Guid("cedd27c4-267a-40f2-a0f0-87ca80472d9d"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("a2a2bbd5-9856-4853-85a1-a0335a914c51"), (short)4, "Course0", new Guid("d766e40b-ed6b-4423-bc83-5b5d3403bb22"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("87b4531d-f517-4526-a4f6-f1533fbadda5"), (short)4, "Course0", new Guid("edcdf2d2-e581-4950-b51c-d56b0fd95a74"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("b71d389e-4a1b-4aa8-bc75-fce91dc72b75"), (short)5, "Course62", new Guid("ad4fbc81-e4bc-4c85-8fdf-7a8c6028c1e5"), new Guid("ed739eb3-57d3-4d4d-9fa3-1ad130210c41") },
                    { new Guid("eff4d6f1-21f6-4ad6-9eb0-fcb61efb2503"), (short)0, "Course0", new Guid("ad4fbc81-e4bc-4c85-8fdf-7a8c6028c1e5"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("d93df0f1-e9f0-417f-9138-7882ff8dc149"), (short)1, "Course61", new Guid("d2f6096b-44fe-4ab3-a7f5-448275ba3bbd"), new Guid("7b4542fb-e33d-46d2-aada-0d7a91ac04b4") },
                    { new Guid("8858a0c6-d766-40fc-9902-7aa534b94e0e"), (short)2, "Course0", new Guid("d2f6096b-44fe-4ab3-a7f5-448275ba3bbd"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("bec7fb43-da2f-49eb-ae6c-a10dfb918c76"), (short)0, "Course60", new Guid("5425e4e3-1934-4b3b-b611-06d871ec6076"), new Guid("b7e178a9-8cfe-4c9c-aeab-dc77f9f2de35") },
                    { new Guid("c79e8906-0f1e-49ae-94e8-583659d18091"), (short)0, "Course0", new Guid("5425e4e3-1934-4b3b-b611-06d871ec6076"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("a2d65cbe-ec1d-4f08-a256-69dfe1a88344"), (short)2, "Course59", new Guid("1df224db-50d8-48cc-aa8c-c27dd0831dd4"), new Guid("14ea1798-d8e8-4752-833b-931135f3cc46") },
                    { new Guid("2ead0d13-d76a-4586-ad39-d44c270071fb"), (short)1, "Course0", new Guid("5c174f74-51b8-420b-9b46-cfee6b0c20bd"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("ca775796-ee54-4823-8330-e2c2e788972d"), (short)4, "Course0", new Guid("1df224db-50d8-48cc-aa8c-c27dd0831dd4"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("cba547dd-2538-4744-86c9-e79581ee6a9d"), (short)3, "Course0", new Guid("f53b3b9f-6302-4971-89d4-9ece92d50fb7"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("d0769db5-f32d-4849-bb41-508044f728ec"), (short)3, "Course57", new Guid("9b7a403a-58e4-42e3-9cb9-b753a068065b"), new Guid("00539901-185f-4490-9481-1d072c53c697") },
                    { new Guid("bd05e09b-a27a-48c8-a0e6-8aa160228224"), (short)4, "Course0", new Guid("9b7a403a-58e4-42e3-9cb9-b753a068065b"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("0ead21a1-16a1-465e-9dd8-a78561623e51"), (short)0, "Course56", new Guid("cc1b153f-e74a-4f09-8511-0f5036167df4"), new Guid("0a2bec6b-65e9-4c34-8fa8-eb3a98e94d6c") },
                    { new Guid("8f40c9f4-f9ab-4e03-b617-08f2ebd28757"), (short)0, "Course0", new Guid("cc1b153f-e74a-4f09-8511-0f5036167df4"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("a4a5dc48-8490-4dee-bf40-eaf8d2872ef9"), (short)5, "Course55", new Guid("84f9da08-1b22-4d9f-aa30-b448d1aa3734"), new Guid("3789d0c1-a469-45be-ae4a-383778d9e884") },
                    { new Guid("0f72a948-165a-4709-8fcd-39c1822da025"), (short)5, "Course0", new Guid("84f9da08-1b22-4d9f-aa30-b448d1aa3734"), new Guid("4980d02c-f24f-4c88-a77a-3134167c62c3") },
                    { new Guid("56cef3f2-a3f7-4682-8620-e556dfb6dd99"), (short)5, "Course54", new Guid("d766e40b-ed6b-4423-bc83-5b5d3403bb22"), new Guid("cb80fe9b-1a1d-4214-bb57-2e630f55f6e9") },
                    { new Guid("bff9a56d-eadd-4e24-8366-b0b2bd4888bc"), (short)3, "Course58", new Guid("f53b3b9f-6302-4971-89d4-9ece92d50fb7"), new Guid("c02be181-5f7c-4685-89ee-d0b4b1c3dea0") },
                    { new Guid("5b497979-393e-4989-b7b6-af7eb3373c9a"), (short)5, "Course107", new Guid("5c174f74-51b8-420b-9b46-cfee6b0c20bd"), new Guid("5a91c10d-b6e0-4886-9ff9-10107fcb6761") }
                });

            migrationBuilder.InsertData(
                table: "StudyContracts",
                columns: new[] { "Id", "GroupId", "OptionalCourseId", "SignedAt", "StudentId", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("f0e9d735-116a-498a-9aab-709b82002b10"), new Guid("c8c439f9-fec6-46e3-8ecf-8d7686b2b6ef"), new Guid("b176b53e-7c91-4de1-8ba7-1f8f138b618f"), 1647781930L, new Guid("864835ed-983c-47ab-9fa4-74182f9a7efd"), null },
                    { new Guid("0267d7ef-c0e1-468b-813d-ed03ee55e043"), new Guid("ce17a767-e08c-49d1-9e2f-991193f5ecf1"), new Guid("9d15e1bc-2441-47dd-ad2c-2e90609303d7"), 1647781930L, new Guid("8354d94a-b9bf-44f3-8bbd-34577523110c"), null },
                    { new Guid("2be7d5af-7aa4-4da0-8fb1-16713109456a"), new Guid("595fea42-a7b8-4ff0-9fd5-53e1bf7da959"), new Guid("5cd39e5d-c346-4003-bdcf-d7f34572e67f"), 1647781930L, new Guid("bb062a85-d596-4716-9036-8ec40fadd48b"), null },
                    { new Guid("b66a88ab-a7aa-4908-9c1c-03ff7e20fefe"), new Guid("ce17a767-e08c-49d1-9e2f-991193f5ecf1"), new Guid("29f32872-397a-4b8b-9fa8-c2bdcfc0080a"), 1647781930L, new Guid("777997a9-cea2-467e-8ddd-9e3ae5efcc12"), null },
                    { new Guid("82c31461-b0fe-4ba9-ae9b-d2bafce5918e"), new Guid("05508eec-4671-4411-80dd-3a8d423a8074"), new Guid("29f32872-397a-4b8b-9fa8-c2bdcfc0080a"), 1647781930L, new Guid("f33f4675-e4f2-413e-ad20-ed7e12d356d4"), null },
                    { new Guid("9192517c-f55d-4b61-9b77-562b27bb7f62"), new Guid("e34365c9-032c-4e84-88ae-642af91fa4bd"), new Guid("016421b4-7e9c-49be-8b67-98721d92a176"), 1647781930L, new Guid("bfef2ba1-75ed-4f47-9ba5-f2c7b2712cac"), null },
                    { new Guid("01910777-8938-4b9b-befa-26cb87a36d74"), new Guid("c4a928c7-211e-4ca5-b71e-e06f41a2349f"), new Guid("016421b4-7e9c-49be-8b67-98721d92a176"), 1647781930L, new Guid("9f635dbe-b5e1-4930-9d12-671306eb2b52"), null },
                    { new Guid("94bf0cf0-9820-4cb2-a859-ebcc344caf15"), new Guid("7c03f659-1041-4079-9386-c22129f27f6c"), new Guid("aa58ff95-862f-4109-891b-68eafe04431c"), 1647781930L, new Guid("fca9dbb9-c681-43c4-8d37-c0d97fb00ea4"), null },
                    { new Guid("d87fd192-ac11-4811-8b9b-1605d7d47c78"), new Guid("05508eec-4671-4411-80dd-3a8d423a8074"), new Guid("9d15e1bc-2441-47dd-ad2c-2e90609303d7"), 1647781930L, new Guid("1016fe8a-e137-4922-89d6-34d12f3483d6"), null },
                    { new Guid("50f15997-4197-41ae-af0c-029962f7d1df"), new Guid("c4a928c7-211e-4ca5-b71e-e06f41a2349f"), new Guid("80f69817-196b-4745-a39b-64b7b35a0769"), 1647781930L, new Guid("718b3471-a7c9-4ae5-b6a2-166c1b6f330f"), null },
                    { new Guid("d8fbdf13-6c00-40a1-ac74-093a33e479fe"), new Guid("7c03f659-1041-4079-9386-c22129f27f6c"), new Guid("8353c06d-df6e-4c6a-8bdb-cb7b09dbc90c"), 1647781930L, new Guid("fb27ce38-3b9c-4dd6-abad-b62c7b45dc1f"), null },
                    { new Guid("8cec8d66-604b-4388-973a-5a61995c877d"), new Guid("9e3a7b0d-8af2-44a1-a51b-a639a35064c7"), new Guid("a25fe166-e698-4b65-bea1-37c8b7c715b0"), 1647781930L, new Guid("b8030296-ce82-429e-808a-79366f01888b"), null },
                    { new Guid("2baf4625-6bb0-4de8-b689-ce658a70ab46"), new Guid("888ec51d-cb31-4088-9eb9-e76d95e146a8"), new Guid("5b312f9b-6b60-4f1b-a3b1-2d556f844bb1"), 1647781930L, new Guid("2b3e04f2-89e1-461a-aa13-fdc1e4924b35"), null },
                    { new Guid("71faa7e0-4f1a-47c4-b71c-37c8e20255cb"), new Guid("cca100c2-2c9b-48d3-94db-2d480c9cecb8"), new Guid("5b312f9b-6b60-4f1b-a3b1-2d556f844bb1"), 1647781930L, new Guid("14890cdf-16be-4c9b-a898-10a6e7e5d16e"), null },
                    { new Guid("58e41cbc-4623-4a79-9dff-9bdc33ea3381"), new Guid("9e3a7b0d-8af2-44a1-a51b-a639a35064c7"), new Guid("d266acb9-3218-4bbc-afc6-2d9f226fade2"), 1647781930L, new Guid("87b51cef-f381-4f81-be94-f26b10c5547a"), null },
                    { new Guid("ece22f16-53e6-439e-91af-4de7b5700eba"), new Guid("cca100c2-2c9b-48d3-94db-2d480c9cecb8"), new Guid("6dfc4960-7927-435f-b91b-bf09ab1f9328"), 1647781930L, new Guid("3f6b1bf9-9275-4816-bcc7-416100ca32ce"), null },
                    { new Guid("618c77c5-97f4-49b9-8833-4f7bf51c17f7"), new Guid("888ec51d-cb31-4088-9eb9-e76d95e146a8"), new Guid("6dfc4960-7927-435f-b91b-bf09ab1f9328"), 1647781930L, new Guid("7a67f2b0-2b07-4922-af6d-b561ce84017f"), null },
                    { new Guid("d4a13f82-3366-420c-9baa-badd41b12710"), new Guid("e34365c9-032c-4e84-88ae-642af91fa4bd"), new Guid("80f69817-196b-4745-a39b-64b7b35a0769"), 1647781930L, new Guid("ea9b6355-8e01-4f09-9191-a0f8ca9c651c"), null },
                    { new Guid("06d279f9-a7bf-4044-a91d-448d41b1d8f0"), new Guid("595fea42-a7b8-4ff0-9fd5-53e1bf7da959"), new Guid("a682bf19-2d8e-4ec4-837f-db2b93e7dc60"), 1647781930L, new Guid("952441a7-cf1f-4a4a-988f-91388efc4aac"), null },
                    { new Guid("32767656-b6b5-42ca-a367-6ce7bcfa8f99"), new Guid("78f6b406-99f2-4f23-9a19-7796212e4c62"), new Guid("25e5eb70-0e5b-4cc4-be97-de9be3ead1db"), 1647781930L, new Guid("8a4c5196-13ba-465f-a83f-418ad25fd9c6"), null },
                    { new Guid("d181e247-66a1-4262-8f36-37ff9774f571"), new Guid("8594eee3-4bc5-4e51-8322-78fb4012fc15"), new Guid("98cd6517-8da6-4adb-86a3-49ebbd40befc"), 1647781930L, new Guid("9d5d424c-c240-44e5-babd-d2f251db44bd"), null },
                    { new Guid("adff89e2-29bb-4dd7-ac36-b6b2ee28aba9"), new Guid("7bd7673e-6f03-48b5-8cea-8581429ed37b"), new Guid("b8d83a52-bc04-4c6c-bb5b-8782a5e47e0f"), 1647781930L, new Guid("341f6fb4-9b6c-4fc1-a184-fdf0cc488288"), null },
                    { new Guid("af9760d3-8cb8-444d-9dfe-01c1d75fee10"), new Guid("1b35b476-0eff-4957-8217-1170dd4e1b62"), new Guid("2fd91ec7-1bf2-4493-a903-57aee151d8ce"), 1647781930L, new Guid("69ad9026-f844-4512-952d-98703052c385"), null },
                    { new Guid("5747a5d4-ccf4-4c26-bad9-c6fa598d2904"), new Guid("fb7b85a0-7668-40e3-a588-896fc24922ac"), new Guid("2fd91ec7-1bf2-4493-a903-57aee151d8ce"), 1647781930L, new Guid("d86f7859-ac80-4845-917e-1cdb92bc8647"), null },
                    { new Guid("62c9dcb0-a3ae-481b-891a-9b8f1f5ac21d"), new Guid("fed1807c-4b6c-47bc-a93a-595eea8ebb05"), new Guid("68bd3c71-aedc-4bd2-89e5-b15ffe2768f1"), 1647781930L, new Guid("4d8e230c-a9db-4671-8879-64740666635e"), null },
                    { new Guid("505fe0fb-85fc-4a5f-95c9-c41d2bab2ad6"), new Guid("fb7b85a0-7668-40e3-a588-896fc24922ac"), new Guid("73f3634b-e667-43c3-9265-7c51974c2eec"), 1647781930L, new Guid("463087fb-4b76-4cf7-b5e0-d4c5b470f82d"), null },
                    { new Guid("523c69d6-7c90-4b68-b255-69ad07f8019c"), new Guid("1b35b476-0eff-4957-8217-1170dd4e1b62"), new Guid("73f3634b-e667-43c3-9265-7c51974c2eec"), 1647781930L, new Guid("ec8355e1-51fb-45c1-a4ef-b2abcaab690e"), null },
                    { new Guid("8eba289b-b238-4a17-b62b-0913d6c378c8"), new Guid("fed1807c-4b6c-47bc-a93a-595eea8ebb05"), new Guid("61920e8f-218f-4ae8-8b34-357d99bf075a"), 1647781930L, new Guid("097ce2db-8946-42b8-b991-765c9521f934"), null },
                    { new Guid("a1552e4b-f0a6-4eec-b81b-243efeb55b1b"), new Guid("7632dd87-0e4c-4b77-af0d-530348b4b743"), new Guid("7f12113a-954b-4f5c-94ca-dc05f4a84f8c"), 1647781930L, new Guid("fdf7cc8f-841d-43d9-be0d-002200118890"), null },
                    { new Guid("ba6fdcbc-d55f-4dcf-a5cc-8d973ab836a0"), new Guid("14aa362e-33a1-4a38-a2de-04f4e61b3250"), new Guid("008395bf-b69e-417f-ac48-e932d157b3ca"), 1647781930L, new Guid("2fee2389-4171-469b-ba54-6ff0c86f3081"), null },
                    { new Guid("0ca5874f-a1d4-46f4-b238-fb3010b315eb"), new Guid("f9224c6e-0e08-4ef0-b121-a243afcef991"), new Guid("008395bf-b69e-417f-ac48-e932d157b3ca"), 1647781930L, new Guid("13077e2f-d755-4755-9f7f-2acf479f447f"), null },
                    { new Guid("749f84b7-169f-421e-b9e7-02293df961c9"), new Guid("7632dd87-0e4c-4b77-af0d-530348b4b743"), new Guid("ccb8805c-ba55-46f0-a1cd-5b88f9d7d42e"), 1647781930L, new Guid("aeefe73b-d430-4c86-9446-5b40b07e9040"), null },
                    { new Guid("c4072415-d668-4cd5-9b8e-5a8f32d9cbeb"), new Guid("f9224c6e-0e08-4ef0-b121-a243afcef991"), new Guid("c9f2055a-8c36-4f39-a6b2-c84f6fae52b8"), 1647781930L, new Guid("0e1dac2a-3686-4a8a-add6-d62ee1282082"), null },
                    { new Guid("7a0dc502-9d43-4112-9882-744493456471"), new Guid("14aa362e-33a1-4a38-a2de-04f4e61b3250"), new Guid("c9f2055a-8c36-4f39-a6b2-c84f6fae52b8"), 1647781930L, new Guid("88f1f6ee-3ae1-41e3-a71b-f7d3353eb0ea"), null },
                    { new Guid("19746dd4-c702-40d9-8fcd-3615cbc6c58a"), new Guid("8594eee3-4bc5-4e51-8322-78fb4012fc15"), new Guid("d84d288a-790b-4ccc-bb2c-2e29c1c6bd2c"), 1647781930L, new Guid("5ac7564f-c06a-4f1a-acef-86f6ff9631ac"), null },
                    { new Guid("ccce842a-4543-4bc2-8a81-eec2d96f720d"), new Guid("b5c2f921-b844-4a72-90e1-ec7acf272325"), new Guid("d84d288a-790b-4ccc-bb2c-2e29c1c6bd2c"), 1647781930L, new Guid("5653e140-a7c1-4f81-bb3d-d1106305200a"), null },
                    { new Guid("12d416bb-1018-4c1e-a20d-822dd83b0d86"), new Guid("78f6b406-99f2-4f23-9a19-7796212e4c62"), new Guid("c6669080-5b52-4ba5-ab72-fc443b7e17db"), 1647781930L, new Guid("0c221012-5710-4be9-a5f7-051b4059275c"), null },
                    { new Guid("2cc0a96c-d445-4122-a71b-1ef99f912003"), new Guid("b5c2f921-b844-4a72-90e1-ec7acf272325"), new Guid("98cd6517-8da6-4adb-86a3-49ebbd40befc"), 1647781930L, new Guid("65412f63-e74f-48d3-ae3f-6ed20700b7cf"), null },
                    { new Guid("fab0aa95-ca46-42d5-afa7-8b408e8a28cb"), new Guid("12aaba2b-95f1-4275-b0c0-37b81a587e4e"), new Guid("5521205e-2361-4eea-8f8c-11a49db55f93"), 1647781930L, new Guid("30f79060-316f-407b-8d04-aff0d3aa7933"), null },
                    { new Guid("7216812a-bb1f-4f77-9bdc-4d54cbc18438"), new Guid("bdc2f38a-ab1b-4244-a5fa-55fee555809d"), new Guid("5521205e-2361-4eea-8f8c-11a49db55f93"), 1647781930L, new Guid("e570d899-3729-4c6e-a91b-ebcbf1a65655"), null },
                    { new Guid("45661d01-0cac-4cf8-9d5f-15158489b161"), new Guid("15d1c55b-ef0e-478c-984c-081f79e4b108"), new Guid("80b840f4-4605-4e7c-bb55-faa3d9b9e5f7"), 1647781930L, new Guid("e83709f8-62cd-4a9a-af06-8e4d847ebdf5"), null },
                    { new Guid("eb06b78b-ee20-4980-a82a-c5a4e68a8e02"), new Guid("bdc2f38a-ab1b-4244-a5fa-55fee555809d"), new Guid("087fbade-5581-4c40-83b6-4e7bd895fa19"), 1647781930L, new Guid("fb2e4fdc-22b4-481c-b7e1-4ebf7b6fec94"), null }
                });

            migrationBuilder.InsertData(
                table: "StudyContracts",
                columns: new[] { "Id", "GroupId", "OptionalCourseId", "SignedAt", "StudentId", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("9699886c-7e8e-45de-a962-34ec304d9a5f"), new Guid("2ace079e-1c49-4507-b25c-d46033f55c5f"), new Guid("a2d65cbe-ec1d-4f08-a256-69dfe1a88344"), 1647781930L, new Guid("c52d524f-dd0e-4e1c-9d18-e04e4841c8e3"), null },
                    { new Guid("470d8a86-6cf3-4544-8aa9-c925d04edb3d"), new Guid("1c2646f0-6411-41d2-8046-52f96d8210c8"), new Guid("a2d65cbe-ec1d-4f08-a256-69dfe1a88344"), 1647781930L, new Guid("76770a32-b4e0-4299-8fe6-142312594dec"), null },
                    { new Guid("204cf4cd-7ec4-4e69-b7f8-0b84db56a34e"), new Guid("1b35b476-0eff-4957-8217-1170dd4e1b62"), new Guid("ca775796-ee54-4823-8330-e2c2e788972d"), 1647781930L, new Guid("955fb4f9-f43f-4c90-884f-661e61ac2176"), null },
                    { new Guid("b05f48c8-6eb7-487f-8a76-702ee9f70d97"), new Guid("c49f6795-dc10-4f1f-ae36-18a1128b3b6f"), new Guid("ca775796-ee54-4823-8330-e2c2e788972d"), 1647781930L, new Guid("955fb4f9-f43f-4c90-884f-661e61ac2176"), null },
                    { new Guid("b04bc7ba-47bb-4af6-9828-3d738845b638"), new Guid("1c2646f0-6411-41d2-8046-52f96d8210c8"), new Guid("bff9a56d-eadd-4e24-8366-b0b2bd4888bc"), 1647781930L, new Guid("db090111-fde3-4835-86a2-15394f2e21aa"), null },
                    { new Guid("a04c9471-623d-46b9-b823-3defcebb9973"), new Guid("2ace079e-1c49-4507-b25c-d46033f55c5f"), new Guid("bff9a56d-eadd-4e24-8366-b0b2bd4888bc"), 1647781930L, new Guid("0b0b66b9-5365-490d-980b-e77543d0e7f8"), null },
                    { new Guid("5c105357-90da-4047-8a6c-5a5f1fe1c17f"), new Guid("c49f6795-dc10-4f1f-ae36-18a1128b3b6f"), new Guid("cba547dd-2538-4744-86c9-e79581ee6a9d"), 1647781930L, new Guid("1be7ad0c-995e-4ced-8bd8-7a21fb31efcf"), null },
                    { new Guid("7ddda83c-4691-4ce3-af8c-de3834f8695f"), new Guid("2b4397bf-27ad-4a04-9ad9-4aa3fc2d5acf"), new Guid("d0769db5-f32d-4849-bb41-508044f728ec"), 1647781930L, new Guid("5027f098-c201-44d5-a86e-ba5b0fd5fe06"), null },
                    { new Guid("5764983a-8659-4530-ae51-e67dc59a0d6c"), new Guid("033a9e62-4ebb-430f-a806-c4fa1c4c0363"), new Guid("bd05e09b-a27a-48c8-a0e6-8aa160228224"), 1647781930L, new Guid("1c2ac9c7-29c2-430f-8b20-49d4884e345a"), null },
                    { new Guid("a0b05077-8bfa-43a8-89c7-365ae75a6786"), new Guid("7190f968-35d6-453e-8810-1d43994e9063"), new Guid("bd05e09b-a27a-48c8-a0e6-8aa160228224"), 1647781930L, new Guid("a4f9dcdd-70c1-47b4-aac0-7d5c3e211977"), null },
                    { new Guid("160bab12-bdd5-4876-9dd0-f4b2b1c0c832"), new Guid("2b4397bf-27ad-4a04-9ad9-4aa3fc2d5acf"), new Guid("0ead21a1-16a1-465e-9dd8-a78561623e51"), 1647781930L, new Guid("dec162df-07e1-4a73-9469-c7339c202f6c"), null },
                    { new Guid("fa8b429a-9a24-4c17-8dde-4d6bb836ce88"), new Guid("7190f968-35d6-453e-8810-1d43994e9063"), new Guid("8f40c9f4-f9ab-4e03-b617-08f2ebd28757"), 1647781930L, new Guid("1ff6bb01-adf5-4687-8c7a-4f39cac64e51"), null },
                    { new Guid("54d4220c-7470-4033-a7d2-11dbdebb515a"), new Guid("033a9e62-4ebb-430f-a806-c4fa1c4c0363"), new Guid("8f40c9f4-f9ab-4e03-b617-08f2ebd28757"), 1647781930L, new Guid("ee3ee571-892c-4fc2-aca1-823e1fcd1b23"), null },
                    { new Guid("1d0f5415-5fac-4569-ad9d-81efde4f073a"), new Guid("135f2f04-61b8-4720-ac05-1b64dbe7f1b5"), new Guid("a4a5dc48-8490-4dee-bf40-eaf8d2872ef9"), 1647781930L, new Guid("514b3aa0-f29c-434f-b70b-8d1bfab24d6e"), null },
                    { new Guid("1836ad7a-5c30-4a4d-b1cd-a0c2e72bc735"), new Guid("51098ce2-4748-4d12-bddb-ba4050b0b895"), new Guid("a4a5dc48-8490-4dee-bf40-eaf8d2872ef9"), 1647781930L, new Guid("503cdcf5-b606-49fa-a8db-042c6b3fa9b0"), null },
                    { new Guid("95d20c9f-cf31-4891-9052-2e3af65a03a3"), new Guid("4e213769-744f-4d00-8ab7-9f089ddce22f"), new Guid("0f72a948-165a-4709-8fcd-39c1822da025"), 1647781930L, new Guid("847fdbea-4a6c-42bf-b267-2a5e6aded89e"), null },
                    { new Guid("edb82142-bcc6-429b-bdc9-3ec01457e862"), new Guid("51098ce2-4748-4d12-bddb-ba4050b0b895"), new Guid("56cef3f2-a3f7-4682-8620-e556dfb6dd99"), 1647781930L, new Guid("70c98e16-c838-4299-86fb-e3c3a804e650"), null },
                    { new Guid("c92340bf-0506-4d25-bf6b-6303b26bebf3"), new Guid("818986ca-f56f-40c3-a552-0184ed7e3f69"), new Guid("c79e8906-0f1e-49ae-94e8-583659d18091"), 1647781930L, new Guid("23f78dad-ca3d-4aff-a610-7764a650205c"), null },
                    { new Guid("92475b40-b419-46bf-8ea8-ef0bb5400dbb"), new Guid("b37f671b-a4f2-48c5-88c9-22d955f6eda4"), new Guid("b8d83a52-bc04-4c6c-bb5b-8782a5e47e0f"), 1647781930L, new Guid("6a0d3f2a-744f-4937-98d8-856059e9b941"), null },
                    { new Guid("7b0253a8-480e-4043-a7fb-470007af6fcc"), new Guid("fcded791-01a5-4c89-b04b-fffba2c87b67"), new Guid("c79e8906-0f1e-49ae-94e8-583659d18091"), 1647781930L, new Guid("5e12cb7d-e2e7-4d52-b3e0-41c045b5ccd6"), null },
                    { new Guid("75ae87dd-a5f9-42d8-a0c9-8635a27ad12d"), new Guid("fcded791-01a5-4c89-b04b-fffba2c87b67"), new Guid("8858a0c6-d766-40fc-9902-7aa534b94e0e"), 1647781930L, new Guid("37566277-11bd-45c6-95ef-b8c207ef98dd"), null },
                    { new Guid("95ab62c7-2266-405c-9e94-b0193b8887e7"), new Guid("12aaba2b-95f1-4275-b0c0-37b81a587e4e"), new Guid("087fbade-5581-4c40-83b6-4e7bd895fa19"), 1647781930L, new Guid("39b97487-2694-4ffd-a0b5-07aa0798be6c"), null },
                    { new Guid("0faeb2a5-57c8-4ed6-a690-26accb330997"), new Guid("36d304c9-c5d3-4fe7-b57e-cfe7a6c9a10e"), new Guid("133e7f50-27b7-44fa-807b-23c63225625c"), 1647781930L, new Guid("b392d44a-8521-4389-a1cb-8d8161e5485e"), null },
                    { new Guid("ac4d8a18-f4ec-4080-a7c7-b15142571a57"), new Guid("15d1c55b-ef0e-478c-984c-081f79e4b108"), new Guid("133e7f50-27b7-44fa-807b-23c63225625c"), 1647781930L, new Guid("b392d44a-8521-4389-a1cb-8d8161e5485e"), null },
                    { new Guid("56dd84f9-28f8-4e4e-adbd-137bc11be3dc"), new Guid("8535f5bf-8ab3-48a4-96b4-61894cbae6ee"), new Guid("154e509b-cb61-4403-b79e-1d48e7439cd4"), 1647781930L, new Guid("cd239fb6-62a9-4a8f-8051-b3074bc1e3e7"), null },
                    { new Guid("6e679189-bd1e-49ca-bdd9-77be23a02ac0"), new Guid("26f18793-341a-41c1-b301-2297fbcd4dc3"), new Guid("bb65a903-1af4-4fc5-899d-7b5f87b8e0fb"), 1647781930L, new Guid("d80ac3cd-0cac-4312-a12f-01af46a6152a"), null },
                    { new Guid("6e5bd418-5263-4508-8576-521b3051a487"), new Guid("a8b426db-93b9-465a-8cc6-ce1b84af535b"), new Guid("bb65a903-1af4-4fc5-899d-7b5f87b8e0fb"), 1647781930L, new Guid("9bb96f6a-452d-4af4-b820-4c4d53089018"), null },
                    { new Guid("8b85eb71-5787-4a9a-8618-792bcb84d3ad"), new Guid("8535f5bf-8ab3-48a4-96b4-61894cbae6ee"), new Guid("aaf43734-fca0-4d0e-902b-1154df94e7d9"), 1647781930L, new Guid("6ab839d1-a272-489c-9f2c-38da55d9a097"), null },
                    { new Guid("032cbc79-a049-46fa-9fe0-84de11023b99"), new Guid("a8b426db-93b9-465a-8cc6-ce1b84af535b"), new Guid("8b159519-74ad-4a08-8aa6-73fba452c90b"), 1647781930L, new Guid("28028785-a9b3-46cf-b60d-fad21fc6cbc8"), null },
                    { new Guid("9ba1b393-4ead-4804-ba7e-23ff370ed1e6"), new Guid("26f18793-341a-41c1-b301-2297fbcd4dc3"), new Guid("8b159519-74ad-4a08-8aa6-73fba452c90b"), 1647781930L, new Guid("51fdf115-e2e1-4598-bf8d-7e9ffb23307a"), null },
                    { new Guid("77f33480-daa0-40ee-b7d8-babfc623c288"), new Guid("3f02cd7e-cb65-48ce-aa03-8cf188ff1b45"), new Guid("cb27e7e6-aa5d-499a-9f3f-5e81072e031f"), 1647781930L, new Guid("0c4522ba-625b-424c-aaa9-2cb0db789b0e"), null },
                    { new Guid("b40cd480-ed95-4779-80a0-f35e67054179"), new Guid("83e76342-10af-41fa-a505-c7baf7c4435f"), new Guid("cb27e7e6-aa5d-499a-9f3f-5e81072e031f"), 1647781930L, new Guid("7f518d29-60ad-4aa9-be1c-3dc5676b38f7"), null },
                    { new Guid("823a8b6f-fe2b-4bee-94a9-9bb8f093e05f"), new Guid("1867367b-629b-4def-bf8b-f133cfd4a07a"), new Guid("87b4531d-f517-4526-a4f6-f1533fbadda5"), 1647781930L, new Guid("3925e9f5-cc86-4bba-aa83-ebe94ddce1f7"), null },
                    { new Guid("c9d3e87e-e711-4a97-9680-e61b796e68b3"), new Guid("83e76342-10af-41fa-a505-c7baf7c4435f"), new Guid("b71d389e-4a1b-4aa8-bc75-fce91dc72b75"), 1647781930L, new Guid("9dee2159-dc20-4746-a707-5cc08ad56f6c"), null },
                    { new Guid("1185fbd9-d51e-42a5-a924-2541ae8b4693"), new Guid("3f02cd7e-cb65-48ce-aa03-8cf188ff1b45"), new Guid("b71d389e-4a1b-4aa8-bc75-fce91dc72b75"), 1647781930L, new Guid("0130e8bf-7265-4191-824b-02f042815014"), null },
                    { new Guid("2f10be14-0797-48a2-a9ca-6fe8eeb12d28"), new Guid("1867367b-629b-4def-bf8b-f133cfd4a07a"), new Guid("eff4d6f1-21f6-4ad6-9eb0-fcb61efb2503"), 1647781930L, new Guid("8b17d139-38ab-494b-8bf8-8a235fb019ce"), null },
                    { new Guid("ebc02b36-d09a-48ad-b4ee-0504f549a0d7"), new Guid("8bb35be2-552b-4f99-b872-b7cefae7c5d6"), new Guid("d93df0f1-e9f0-417f-9138-7882ff8dc149"), 1647781930L, new Guid("abe7cc15-e681-48e4-8033-18a482ed1910"), null },
                    { new Guid("b383591c-eca5-4ccd-a718-b2459258be34"), new Guid("818986ca-f56f-40c3-a552-0184ed7e3f69"), new Guid("8858a0c6-d766-40fc-9902-7aa534b94e0e"), 1647781930L, new Guid("e8311585-2529-44f5-ad94-03245d319ff8"), null },
                    { new Guid("346f7aba-5034-45ab-92a5-8792b30cea45"), new Guid("8bb35be2-552b-4f99-b872-b7cefae7c5d6"), new Guid("bec7fb43-da2f-49eb-ae6c-a10dfb918c76"), 1647781930L, new Guid("136d741a-295a-4a95-9d94-cf8515406e11"), null },
                    { new Guid("7972a31d-31ee-47c3-b229-70570fb5958c"), new Guid("135f2f04-61b8-4720-ac05-1b64dbe7f1b5"), new Guid("56cef3f2-a3f7-4682-8620-e556dfb6dd99"), 1647781930L, new Guid("26890b54-e6eb-49b3-82cf-3cf959ab419a"), null },
                    { new Guid("e9f266a6-e19c-4a2f-85f9-f07ec47be593"), new Guid("5a2f8a43-9669-4e1d-a867-c3fe5b7ed8c5"), new Guid("92496c02-d2ce-49b9-992d-849c62aa8bcd"), 1647781930L, new Guid("013f8663-4b57-46a0-af8a-c8fb6c25b58c"), null },
                    { new Guid("49bb55c1-fffa-4d73-bca4-dd9a546aaa60"), new Guid("7bd7673e-6f03-48b5-8cea-8581429ed37b"), new Guid("f002bdb2-bf9b-4763-b5e8-2874519bb205"), 1647781930L, new Guid("865a9719-9115-4af1-a32d-52f4b5c41aac"), null }
                });

            migrationBuilder.InsertData(
                table: "StudyContracts",
                columns: new[] { "Id", "GroupId", "OptionalCourseId", "SignedAt", "StudentId", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("4d5c2eec-999d-4edd-8c61-0257e614b8cd"), new Guid("72c05b7f-6193-47b3-9b31-4a26b56f9af0"), new Guid("4611f390-6837-45a7-85cc-8fef2d96d1a3"), 1647781930L, new Guid("092118b5-82c2-426f-ae63-f572f71f2d97"), null },
                    { new Guid("556988e9-9b0e-4c98-affd-daca35b56803"), new Guid("a779b198-04a5-4a11-8b7d-4d4783e95c71"), new Guid("4611f390-6837-45a7-85cc-8fef2d96d1a3"), 1647781930L, new Guid("4f625f37-6d29-4969-9796-05f3d93733db"), null },
                    { new Guid("088e5972-7b16-46bd-8236-53bc273a469b"), new Guid("ae8d4134-b21e-4249-aa4c-2a404f841697"), new Guid("09ace841-cab4-402b-8f9a-5a3514da14ef"), 1647781930L, new Guid("e1e25103-0537-4986-99c1-876f28de6751"), null },
                    { new Guid("739722ee-4c6e-4f36-8270-41564b9198bb"), new Guid("9e81d458-b5bd-4aa4-aabd-7127f2dc2eb6"), new Guid("09ace841-cab4-402b-8f9a-5a3514da14ef"), 1647781930L, new Guid("2667a758-41a7-4f2f-bd61-6b2121f9fd4f"), null },
                    { new Guid("1cf138a9-501e-40fb-99f4-cb82e166227e"), new Guid("dbb15cef-ae49-4fd3-a7c7-017d65c39c18"), new Guid("98e62f08-dd08-445f-bf4d-3f6c73c22b79"), 1647781930L, new Guid("06033bdc-8cc2-413b-9979-47b70caa4463"), null },
                    { new Guid("bf452d47-85b4-4a7f-990b-64030c58111f"), new Guid("9e81d458-b5bd-4aa4-aabd-7127f2dc2eb6"), new Guid("e3f0783a-b285-4c03-8915-f62462c6f03b"), 1647781930L, new Guid("d6d71a77-f07c-42ff-89a1-668acae606d2"), null },
                    { new Guid("afc1f063-3be4-453f-b606-c4b1731cb2c1"), new Guid("ae8d4134-b21e-4249-aa4c-2a404f841697"), new Guid("e3f0783a-b285-4c03-8915-f62462c6f03b"), 1647781930L, new Guid("b999311e-2b35-4b8c-8fae-2398c06f7dd3"), null },
                    { new Guid("96e041d6-78de-4fe9-9a4e-56a052c5e8c7"), new Guid("a9eda55d-8654-49ea-9043-dd884393d546"), new Guid("bcd8be92-8bf1-49ef-8ca2-8cfbb6935532"), 1647781930L, new Guid("5b8db878-675f-4854-ab23-e623ec26efc7"), null },
                    { new Guid("c3ba1cd3-5bf5-44e1-b1b2-17c1b8f0afcb"), new Guid("dbb15cef-ae49-4fd3-a7c7-017d65c39c18"), new Guid("c28e10d1-7484-4747-b3f6-030fa9996509"), 1647781930L, new Guid("594bf687-59fe-4832-b96b-01a6372eaa97"), null },
                    { new Guid("ad32f824-3874-45c8-9cc4-d9fe722c761a"), new Guid("71731171-39df-4f99-b43c-8259ad66d333"), new Guid("962c1bdd-ae6a-4529-970c-29413d3c7178"), 1647781930L, new Guid("a64ea290-fc9c-43ab-8112-24e0fe230e45"), null },
                    { new Guid("e3dc4514-8575-4ea3-9ced-f77e36ee0dfe"), new Guid("36d304c9-c5d3-4fe7-b57e-cfe7a6c9a10e"), new Guid("962c1bdd-ae6a-4529-970c-29413d3c7178"), 1647781930L, new Guid("29772d53-f49f-4a11-b808-d51237e1e700"), null },
                    { new Guid("e17f8eca-c71a-44b9-bf60-c76feb887b19"), new Guid("33fa5ad4-ca1f-4bbd-90d4-073836ed62f0"), new Guid("00427450-8189-4f75-9e30-41c0d5ae5768"), 1647781930L, new Guid("970239f2-226b-43fa-8628-cabdf415b58a"), null },
                    { new Guid("dac264fc-e2e7-41be-9607-4fd674b4276e"), new Guid("36d304c9-c5d3-4fe7-b57e-cfe7a6c9a10e"), new Guid("1de9546b-82a3-4fc5-9708-b9939a52bdbe"), 1647781930L, new Guid("f3251bb7-b9cf-4911-95c2-2ee3d3ae0179"), null },
                    { new Guid("4f82d5e8-68dd-46b0-90b6-f5328f27e6b6"), new Guid("71731171-39df-4f99-b43c-8259ad66d333"), new Guid("1de9546b-82a3-4fc5-9708-b9939a52bdbe"), 1647781930L, new Guid("5f802300-59fe-4265-9e8e-97aa329de809"), null },
                    { new Guid("103f6640-f0ef-444b-9069-7d2120c896a6"), new Guid("0791a613-7bff-4126-9efb-0a2b50fdaedb"), new Guid("2c113018-1fc5-48c8-88d9-6faf89248fa2"), 1647781930L, new Guid("c8dd57b0-b5bb-4c7f-8f6a-0cffd5b88eab"), null },
                    { new Guid("ee4570a7-2437-4f25-8404-452cdb933737"), new Guid("e80d0250-becd-40ad-b385-5f5e8fc6a64d"), new Guid("2c113018-1fc5-48c8-88d9-6faf89248fa2"), 1647781930L, new Guid("87c7ee17-2764-4dc8-86dc-bc5d459dcff8"), null },
                    { new Guid("fae2b3e1-3cd8-4b3a-998b-f93f0ec8b535"), new Guid("33fa5ad4-ca1f-4bbd-90d4-073836ed62f0"), new Guid("063b8743-8896-4222-8104-cccb1b09ca24"), 1647781930L, new Guid("2305358d-1f58-4179-a22f-5e467fc91058"), null },
                    { new Guid("2f8a8901-240b-4a49-ba94-cc40cd683114"), new Guid("72c05b7f-6193-47b3-9b31-4a26b56f9af0"), new Guid("29439911-2153-469a-bb26-abd115367f7c"), 1647781930L, new Guid("7f939a55-7ec9-454a-838e-947c141f3f0b"), null },
                    { new Guid("2809cce3-ca16-45e1-9dc5-978a027ff1b4"), new Guid("fd69bb20-cb9e-4106-b0e6-ee34db0791ff"), new Guid("29439911-2153-469a-bb26-abd115367f7c"), 1647781930L, new Guid("7f939a55-7ec9-454a-838e-947c141f3f0b"), null },
                    { new Guid("da942c6f-4d0b-4d46-ba8b-c7c57b02cb58"), new Guid("a779b198-04a5-4a11-8b7d-4d4783e95c71"), new Guid("29439911-2153-469a-bb26-abd115367f7c"), 1647781930L, new Guid("0ad4bc5c-bfae-41aa-9f10-5549e3fc81bc"), null },
                    { new Guid("d93753e6-e2cc-43e2-a912-9f547abfe3b8"), new Guid("7b997601-d826-4450-86f0-c967552a9996"), new Guid("2ead0d13-d76a-4586-ad39-d44c270071fb"), 1647781930L, new Guid("d7eac763-0bd3-4811-a9f3-9111e8592eb3"), null },
                    { new Guid("beee6ac8-6511-4d66-9040-b26735de9b81"), new Guid("a8181894-5d83-4333-a385-51133d82a7b2"), new Guid("6ae2f873-7839-4533-9c69-99a14b6f7f1d"), 1647781930L, new Guid("9811d264-e14b-45e1-85cc-6d600ed41192"), null },
                    { new Guid("4489fdbd-ca29-4297-b55a-043e6d43417f"), new Guid("3ba7f2cf-03a8-4040-831f-c63c37ccaedb"), new Guid("6ae2f873-7839-4533-9c69-99a14b6f7f1d"), 1647781930L, new Guid("e1c1167c-2743-4960-bac2-ffe944a0ba1b"), null },
                    { new Guid("a0803a5d-7724-4549-8f25-e1ca4361e39f"), new Guid("7b997601-d826-4450-86f0-c967552a9996"), new Guid("f5a00626-51fb-4e08-b0b4-03bc4c5800a0"), 1647781930L, new Guid("61b7b406-e691-461e-9388-630ea6c15249"), null },
                    { new Guid("0ee49daf-caa0-4d58-921b-1537d1e92d18"), new Guid("804f34de-ba1c-49f3-9077-27e3f4810fc3"), new Guid("639eec63-db14-46c1-b0b0-25fc7edac3bc"), 1647781930L, new Guid("432b123c-7650-4ad9-b4a9-4126b47b838a"), null },
                    { new Guid("dc2e38c2-ecb0-4c6f-ae23-3c0de3c02d3d"), new Guid("fc8f87d1-4b73-4ece-899e-94dee6ec4a06"), new Guid("c55391dd-a1bc-4a57-8c76-a45b26e558ba"), 1647781930L, new Guid("dc584618-166d-4f96-8ab1-4527abdc85ce"), null },
                    { new Guid("4bcb91c5-5c37-4d3c-91ad-901fecdac9e7"), new Guid("4ea8b217-d008-4236-966f-a3ee467691dc"), new Guid("c55391dd-a1bc-4a57-8c76-a45b26e558ba"), 1647781930L, new Guid("dbf91b18-0a45-4e59-a116-93a6792cd012"), null },
                    { new Guid("b59cc493-3098-477d-a86e-64ce94c5a3a9"), new Guid("804f34de-ba1c-49f3-9077-27e3f4810fc3"), new Guid("69e7d901-dca5-4fc3-bbeb-3a1d0240e5f5"), 1647781930L, new Guid("342aebf0-6d60-42e8-8c35-1f241c86ff5a"), null },
                    { new Guid("597a23b3-df7b-469f-937f-741a15a753d3"), new Guid("4ea8b217-d008-4236-966f-a3ee467691dc"), new Guid("ecd0186d-34d6-4a44-bd14-9f8047d47c8b"), 1647781930L, new Guid("38282870-8e13-4d78-a50e-151e15d193e6"), null },
                    { new Guid("41dbc771-9c7a-420b-a63e-a62ce1c26d9d"), new Guid("fc8f87d1-4b73-4ece-899e-94dee6ec4a06"), new Guid("ecd0186d-34d6-4a44-bd14-9f8047d47c8b"), 1647781930L, new Guid("5f7f1bc6-bbfd-4a14-8ac2-8ae7d3757a3b"), null },
                    { new Guid("f11cc46b-aff7-4141-9caf-fcc5b0a88ebf"), new Guid("c3413bb7-f127-4455-8dc5-07c3d0d4448b"), new Guid("2477bca4-8a5b-4a7e-ba8b-bbce44ed621f"), 1647781930L, new Guid("3abb006c-9e8a-4aa9-ad5a-04d7530b67d5"), null },
                    { new Guid("dd22680e-2cd1-4457-b250-c47828f9d288"), new Guid("ff3de86a-c58f-408e-8148-75bc9286a3d9"), new Guid("2477bca4-8a5b-4a7e-ba8b-bbce44ed621f"), 1647781930L, new Guid("3db660ce-c4f8-4fda-8c70-9d105fd3fcee"), null },
                    { new Guid("848c6683-0ce8-44a6-9257-13a0935b0f6e"), new Guid("89d1983a-4b37-4bbe-a9c1-1122c72b4295"), new Guid("8b8dca1c-33a6-48f2-b71e-f72a162aed06"), 1647781930L, new Guid("4dde0d15-b580-4c9e-8487-cc25b592b9b4"), null },
                    { new Guid("16a45629-e4d0-4879-9e7a-0fcbcebb1025"), new Guid("ff3de86a-c58f-408e-8148-75bc9286a3d9"), new Guid("f0158a3a-2298-450e-9e5f-c8b849c0d8df"), 1647781930L, new Guid("c4ddbdf2-a7d9-40f7-9de8-33656c930bcb"), null },
                    { new Guid("7901a230-f7bf-4549-9ecc-a519e09d8832"), new Guid("c3413bb7-f127-4455-8dc5-07c3d0d4448b"), new Guid("f0158a3a-2298-450e-9e5f-c8b849c0d8df"), 1647781930L, new Guid("13ed3d8c-73cc-491f-9929-93fb87dc8f54"), null },
                    { new Guid("8fdda445-ba61-489d-96e9-f529b380f159"), new Guid("89d1983a-4b37-4bbe-a9c1-1122c72b4295"), new Guid("9694b9b4-1684-4bef-92c2-ab84a262bba5"), 1647781930L, new Guid("9ef5b13a-4ea0-48c9-9883-3c7bfd0bb6ae"), null },
                    { new Guid("8247af05-a5e5-423a-88c9-50fd3968a42c"), new Guid("a9eda55d-8654-49ea-9043-dd884393d546"), new Guid("6836446e-af51-4b58-a1c5-48b9c2d47cd3"), 1647781930L, new Guid("2d0f8025-5996-4660-b7eb-20e59b755322"), null },
                    { new Guid("bb69ea6a-1480-4aa5-8cc9-b4de4f1dadae"), new Guid("186c5903-4efc-4b31-bbc2-e919b9bdc54c"), new Guid("a917e7ff-5397-47f8-a9e5-6122160a88d9"), 1647781930L, new Guid("3cb8198f-c176-4315-a194-63c46aec4833"), null },
                    { new Guid("6cfaf31d-2b0b-4d76-ab1a-7949ddbbf64b"), new Guid("e80d0250-becd-40ad-b385-5f5e8fc6a64d"), new Guid("b4518f8f-f3f7-4ecd-b65e-83fc933967f6"), 1647781930L, new Guid("da13e3ce-e667-4275-b1f8-f2dcd875fa80"), null },
                    { new Guid("b3f6a6d0-f9bd-45db-888f-f3a9f66b5057"), new Guid("0791a613-7bff-4126-9efb-0a2b50fdaedb"), new Guid("b4518f8f-f3f7-4ecd-b65e-83fc933967f6"), 1647781930L, new Guid("ffce7b9f-a013-4c2d-8e41-395c4c5845f6"), null },
                    { new Guid("b6cab0c6-74c3-411d-b387-3428e193360a"), new Guid("186c5903-4efc-4b31-bbc2-e919b9bdc54c"), new Guid("0fc0ebef-b91e-4c1a-b2c1-bb94c3fc7756"), 1647781930L, new Guid("ea45c5f5-58b3-4307-8ffb-40ff51923401"), null },
                    { new Guid("d6b7b829-b510-4c44-8d3f-983be2d1c8c4"), new Guid("b92365a8-758a-4b92-bcbd-d2533b01d134"), new Guid("f7c409a0-49f6-403d-b747-840a4e33698d"), 1647781930L, new Guid("8c08748d-5061-481b-ba1f-9c1f74b21a73"), null }
                });

            migrationBuilder.InsertData(
                table: "StudyContracts",
                columns: new[] { "Id", "GroupId", "OptionalCourseId", "SignedAt", "StudentId", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("8e944e53-119d-44bf-b9dd-dbf2067d0892"), new Guid("32f5c383-18b1-4c1d-b8a0-9f863a6479f9"), new Guid("206abe8f-f54c-45fb-9881-6c1f223e39b5"), 1647781930L, new Guid("67d6e05a-4023-4715-9bc5-0f5fa18a8acc"), null },
                    { new Guid("73ce2665-682c-4681-a30a-93d90bd27f0f"), new Guid("ee4ad2e3-792f-4c49-9920-cd00516f67b9"), new Guid("206abe8f-f54c-45fb-9881-6c1f223e39b5"), 1647781930L, new Guid("ab6434e1-e0f0-4fe8-bce0-04899751ff73"), null },
                    { new Guid("608afb7e-42c3-4c94-a83b-f33837ca6ddf"), new Guid("b92365a8-758a-4b92-bcbd-d2533b01d134"), new Guid("d55a7b46-0918-43af-8bb2-d3edeb0c6cbc"), 1647781930L, new Guid("59070f1c-d1e7-4023-a58d-18874734ab3a"), null },
                    { new Guid("bbdc349e-8759-439a-9ea7-45a1a472dc9e"), new Guid("faaa30df-1354-4bc2-a9c3-13eeaa4ab270"), new Guid("34f431ef-4cae-42a2-a2fa-3ddb7d87ad7f"), 1647781930L, new Guid("3df895dc-321d-4fae-897d-6b0ff9fd4db4"), null },
                    { new Guid("f280d07a-b03e-41ca-a2a9-45c0a1c2eca6"), new Guid("d7d7914a-c951-4f3b-b5ca-39c90d6c0bae"), new Guid("a5c04128-75f3-4d19-a9a0-7a4577aa02ef"), 1647781930L, new Guid("a0365af9-d3d6-4528-9779-93017a645143"), null },
                    { new Guid("15a10cbd-7091-472c-8bf3-7d45083e1dea"), new Guid("c489763f-1c11-4368-bea4-607f23193514"), new Guid("a5c04128-75f3-4d19-a9a0-7a4577aa02ef"), 1647781930L, new Guid("be2d873b-0c79-4bde-b1f4-d35143b07d6a"), null },
                    { new Guid("ff005b32-0fb6-4e9a-8ecd-fe5e6831a6fd"), new Guid("faaa30df-1354-4bc2-a9c3-13eeaa4ab270"), new Guid("715def3d-62d2-4410-b784-047cd212b69b"), 1647781930L, new Guid("27e719d4-cb33-49db-a096-3fcb00ab5638"), null },
                    { new Guid("061bab2c-6c60-4242-b7f2-2be5b466496f"), new Guid("c489763f-1c11-4368-bea4-607f23193514"), new Guid("249ee45e-f0ba-426e-9f8c-bbb3c63ab97a"), 1647781930L, new Guid("1d2c3013-a1eb-4185-8dd4-6aebe9516962"), null },
                    { new Guid("df6c140b-5e88-41be-abc5-de6399eaadb2"), new Guid("d7d7914a-c951-4f3b-b5ca-39c90d6c0bae"), new Guid("249ee45e-f0ba-426e-9f8c-bbb3c63ab97a"), 1647781930L, new Guid("38685ac5-15b1-4f8b-9c1a-061d09450c67"), null },
                    { new Guid("f50c0d9e-81b2-4655-ac30-14a5899f7dcd"), new Guid("0f99cbc9-1a7b-43ab-af23-81e929ecda9d"), new Guid("1b8bb530-6e87-449f-a190-d563c355c82b"), 1647781930L, new Guid("b54c2649-b3e6-46f0-9695-a20ec1738fb1"), null },
                    { new Guid("92fff47f-543f-48bf-a9a7-0e51571ea37d"), new Guid("e2d43aba-f61d-4141-b2a4-9d100d67eefe"), new Guid("1b8bb530-6e87-449f-a190-d563c355c82b"), 1647781930L, new Guid("987966cd-caf4-4960-b37b-3c6bf1b89888"), null },
                    { new Guid("4fe805c5-4723-42f2-b40a-c6d1a4b8cedf"), new Guid("1b0c2b9c-7727-4a37-b84c-684e3049f5f1"), new Guid("3fe7b8a8-0168-4030-83f6-49c8db35f75c"), 1647781930L, new Guid("42bb4201-6c1d-4c88-b802-997973f3c978"), null },
                    { new Guid("78531e83-1561-43cd-88ed-75b1b7e4379f"), new Guid("e2d43aba-f61d-4141-b2a4-9d100d67eefe"), new Guid("21b3ef11-f820-4b6f-8afa-65eef230ee51"), 1647781930L, new Guid("cc36c48c-7795-46ad-8d29-950da22bcd48"), null },
                    { new Guid("886355e9-236a-47f8-b1e4-d4cea1022448"), new Guid("0f99cbc9-1a7b-43ab-af23-81e929ecda9d"), new Guid("21b3ef11-f820-4b6f-8afa-65eef230ee51"), 1647781930L, new Guid("727b8bd1-c77a-4540-96d5-713dfdcb4398"), null },
                    { new Guid("6cc43822-566b-4dab-883d-a532fa4f3cfc"), new Guid("1b0c2b9c-7727-4a37-b84c-684e3049f5f1"), new Guid("865092cc-634c-4e1e-be71-e7cb01d2c366"), 1647781930L, new Guid("fb8aaa98-d82f-400f-bf8c-0af6af0fea5c"), null },
                    { new Guid("530fff96-7bd0-4240-9a5c-70622ff11174"), new Guid("5a2f8a43-9669-4e1d-a867-c3fe5b7ed8c5"), new Guid("fc2f7832-1f28-491e-abe5-88020dd791d0"), 1647781930L, new Guid("3969aed8-c985-4dab-9fa6-8ba71ea85cfa"), null },
                    { new Guid("7f2ffdc7-6a57-410d-8b5a-0215c9561c52"), new Guid("32f5c383-18b1-4c1d-b8a0-9f863a6479f9"), new Guid("5c8cb8a8-02f0-4842-8981-a7bc9d6999ec"), 1647781930L, new Guid("83c8473f-2064-468d-8de3-30d552fce6fe"), null },
                    { new Guid("bda8f967-f094-4d7b-9bce-9e7d4b3d7f4c"), new Guid("b37f671b-a4f2-48c5-88c9-22d955f6eda4"), new Guid("f002bdb2-bf9b-4763-b5e8-2874519bb205"), 1647781930L, new Guid("46b22d75-cb5d-48c6-b394-378bde695691"), null },
                    { new Guid("06741ced-5cbd-4472-81fd-e30621a64289"), new Guid("ee4ad2e3-792f-4c49-9920-cd00516f67b9"), new Guid("5c8cb8a8-02f0-4842-8981-a7bc9d6999ec"), 1647781930L, new Guid("4998e75e-99ef-414b-b8aa-0d9851941e98"), null },
                    { new Guid("60f65e2d-86ca-41b5-9cdc-68070c80ae78"), new Guid("c8c0ca4f-6734-425b-9a9e-db84ba01eb46"), new Guid("35733407-4aa4-4159-9fdb-16c4fa9eaaab"), 1647781930L, new Guid("a40bde53-1a7a-4e33-a73e-af65ee77bd76"), null },
                    { new Guid("3c30bcec-4c93-453c-8a6a-cb3ead09435f"), new Guid("cd2e3863-e10f-4456-90a1-bb7a908b1c7b"), new Guid("2ed121a3-afb9-4b0d-81be-6c6d01c0864f"), 1647781930L, new Guid("a9aa0b7e-f85f-406b-b6e0-688b0a2c756f"), null },
                    { new Guid("186d87bf-beaa-4411-a3c8-d5dd40760af2"), new Guid("9f27beef-982a-45ea-8ca2-7096a7b3927b"), new Guid("4b8210ff-3f07-4635-9606-f161a30ce4e5"), 1647781930L, new Guid("ef08e474-7578-419b-ac6b-83392842dd51"), null },
                    { new Guid("c6fb4409-3f52-4dc6-9807-77a9a1d1cb53"), new Guid("dc1c36b3-dea5-46d5-a014-33cf018ea978"), new Guid("4b8210ff-3f07-4635-9606-f161a30ce4e5"), 1647781930L, new Guid("863ed0d2-93ec-4c81-b767-bfd4628afebd"), null },
                    { new Guid("f1447afd-d78f-4841-b890-3a83ca9628cc"), new Guid("cd2e3863-e10f-4456-90a1-bb7a908b1c7b"), new Guid("b3ec53e9-f86e-40ed-8e57-740ecd73847b"), 1647781930L, new Guid("b652343f-a958-450e-a265-25805b225b57"), null },
                    { new Guid("cc7d09ce-6eb6-43c0-bf13-8017cb360ff7"), new Guid("664314c5-7eac-4f78-a52d-b3cf51711e2a"), new Guid("7b59a691-aea5-480c-b871-0a189d560fd9"), 1647781930L, new Guid("d35c7242-f9b6-4bc9-9b0c-9b6fc3c75d92"), null },
                    { new Guid("d6a5b141-c9eb-4fea-a7cc-65b863b0f9e9"), new Guid("dc1c36b3-dea5-46d5-a014-33cf018ea978"), new Guid("7b59a691-aea5-480c-b871-0a189d560fd9"), 1647781930L, new Guid("d35c7242-f9b6-4bc9-9b0c-9b6fc3c75d92"), null },
                    { new Guid("cb9b0dd6-3fb0-4bab-acc1-2e6f0495ddad"), new Guid("9f27beef-982a-45ea-8ca2-7096a7b3927b"), new Guid("7b59a691-aea5-480c-b871-0a189d560fd9"), 1647781930L, new Guid("01c22997-99b4-43bd-9330-76f98d09a137"), null },
                    { new Guid("c500afc9-24c0-4a1e-9e72-246a7b2b713a"), new Guid("266e0323-415e-4c4d-9423-46391f5bf26c"), new Guid("f153eb48-30dc-45a5-a50a-a76f90146629"), 1647781930L, new Guid("92d84e5e-87ed-4ea0-a828-fea94d00fa5a"), null },
                    { new Guid("9df2a316-bae1-4181-b1fc-418d5efae16f"), new Guid("2a6e29ca-6ea1-41fd-97bc-404eb791b965"), new Guid("f153eb48-30dc-45a5-a50a-a76f90146629"), 1647781930L, new Guid("8d50fa94-dd14-4f89-ade5-77de4e179397"), null },
                    { new Guid("f94a9ac9-d754-4011-a5b3-f047ae6b281a"), new Guid("614095b5-392a-4879-9a13-c519a2a93732"), new Guid("2e7858da-f950-4300-9c0d-f24f355425ce"), 1647781930L, new Guid("9ce042d1-daf4-4e30-a404-7ce187a25c7c"), null },
                    { new Guid("54e2b281-2090-4691-97d1-e64976db716e"), new Guid("2a6e29ca-6ea1-41fd-97bc-404eb791b965"), new Guid("6ea7b5f0-1ce3-4d13-8553-1a0ca94b0fa0"), 1647781930L, new Guid("5778d25a-58ba-4d52-bb81-443bf5197cf1"), null },
                    { new Guid("ea7af7e1-d93a-4d4e-b28b-d53b4c51439e"), new Guid("266e0323-415e-4c4d-9423-46391f5bf26c"), new Guid("6ea7b5f0-1ce3-4d13-8553-1a0ca94b0fa0"), 1647781930L, new Guid("84aa42e6-6afe-41c9-b59c-def2a9e99ab6"), null },
                    { new Guid("d313cd67-ef59-4bed-9ca9-5baeac8bc50c"), new Guid("614095b5-392a-4879-9a13-c519a2a93732"), new Guid("301c46cb-4303-4dd3-8703-133dfd3e51b4"), 1647781930L, new Guid("226a90ab-88ca-4c07-8821-c57d057e188e"), null },
                    { new Guid("10a7bf45-0ad2-49ab-8afa-1e15d4ee592a"), new Guid("2cbc2e49-ba23-4a22-87b3-fc7ab7dea5f7"), new Guid("8291530a-b29c-49da-8223-aeb6affaf435"), 1647781930L, new Guid("3ea12ca8-8743-45cd-9015-48fa186aca1a"), null },
                    { new Guid("d4fbbb37-ba62-4dba-90a0-c73740805bf9"), new Guid("e8f25d3f-996d-4f95-a814-8d739303df87"), new Guid("8c936da8-ab92-40ae-8c20-c798a40b5289"), 1647781930L, new Guid("3a029cb5-7d86-443c-83a5-53ee63e13ae6"), null },
                    { new Guid("3299c670-876d-4c32-9ae4-b714712bd701"), new Guid("c8c0ca4f-6734-425b-9a9e-db84ba01eb46"), new Guid("8c936da8-ab92-40ae-8c20-c798a40b5289"), 1647781930L, new Guid("f4e0b2d0-bdac-4053-a2c9-e5a175d2146e"), null },
                    { new Guid("c3f4b731-e506-4ea3-9606-221860d6f1d9"), new Guid("2cbc2e49-ba23-4a22-87b3-fc7ab7dea5f7"), new Guid("ba1a5454-c798-4c8d-85b1-28a058ea90cc"), 1647781930L, new Guid("7f47cfd9-dc83-4cc3-a421-b2774d0e2ae1"), null },
                    { new Guid("b87a60ce-4c2a-4ddd-8ff6-e6d57816c4f6"), new Guid("e8f25d3f-996d-4f95-a814-8d739303df87"), new Guid("35733407-4aa4-4159-9fdb-16c4fa9eaaab"), 1647781930L, new Guid("18c3c341-23fd-4e47-9381-eaf90370bb99"), null },
                    { new Guid("a2b4fcb5-da2e-4c18-9b75-549b91cae6c1"), new Guid("a8181894-5d83-4333-a385-51133d82a7b2"), new Guid("5b497979-393e-4989-b7b6-af7eb3373c9a"), 1647781930L, new Guid("a5b17a71-d528-468f-9874-36e2d816f8d6"), null },
                    { new Guid("88fb112a-6e69-402f-a879-6a66ff0a63c1"), new Guid("4e213769-744f-4d00-8ab7-9f089ddce22f"), new Guid("a2a2bbd5-9856-4853-85a1-a0335a914c51"), 1647781930L, new Guid("35e6a6d2-8f49-446b-aeaf-4e0258e15f82"), null },
                    { new Guid("3a7847ff-f5aa-43c2-8583-480d33ec2468"), new Guid("ba1fe61e-bc87-4f3e-b09d-f795e2f01b23"), new Guid("17c5e005-e058-4ebe-94d9-c71513cdc323"), 1647781930L, new Guid("dbe00385-6825-43b5-b976-8d98e6e8e000"), null },
                    { new Guid("fc5f59e1-6de6-4efd-bcc2-41c5ef1e8695"), new Guid("50beb0ab-0353-4f95-9e7d-1dd5c19f604e"), new Guid("76678ebc-7d16-43e2-91e4-506fe036cdd3"), 1647781930L, new Guid("8d0e976e-7510-4594-9e04-6e3f53de7148"), null }
                });

            migrationBuilder.InsertData(
                table: "StudyContracts",
                columns: new[] { "Id", "GroupId", "OptionalCourseId", "SignedAt", "StudentId", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("31601679-b6fe-4e5d-a421-c3dcbb8d1b6f"), new Guid("35d46cd2-70e0-4173-b1a2-424034674091"), new Guid("ca879c35-6f91-4d67-8a75-04a8de820413"), 1647781930L, new Guid("5553abad-f7aa-4637-9511-0d36f191e4df"), null },
                    { new Guid("da43484f-a485-43de-8b2e-0a0853d1e5a2"), new Guid("3eec704d-8929-4ea3-a4f6-49f2ac2c455f"), new Guid("ca879c35-6f91-4d67-8a75-04a8de820413"), 1647781930L, new Guid("bf68980c-e4cd-44a6-a5d2-474793c2c1d2"), null },
                    { new Guid("0ef54135-e044-4ec0-842d-879291eb2d59"), new Guid("50beb0ab-0353-4f95-9e7d-1dd5c19f604e"), new Guid("7173d661-233a-4cb0-91c6-7d491ac80c8e"), 1647781930L, new Guid("a843baa3-ada5-4cdb-b8bf-c60200748133"), null },
                    { new Guid("bef6f1f1-c364-4070-b851-fe7e9adb7fde"), new Guid("2628f674-b7c6-4e80-9c09-54028f2657b9"), new Guid("fd6ed403-6843-4349-afd5-2c056b59558d"), 1647781930L, new Guid("3527f188-5244-478d-99f3-3d5503678796"), null },
                    { new Guid("876e84b4-8322-4fb3-bdea-b841aadaae97"), new Guid("70802b04-96df-4eb8-9ee1-8e23848b66a3"), new Guid("0097aef2-e173-470d-aea8-a93bae9a4ca4"), 1647781930L, new Guid("8d5f5622-bab3-425a-bf90-d9af92c9310e"), null },
                    { new Guid("c1f5865c-61bc-4396-ba73-e6180762af32"), new Guid("62c03594-53ef-467f-b6df-5b21d90166de"), new Guid("0097aef2-e173-470d-aea8-a93bae9a4ca4"), 1647781930L, new Guid("99b21604-e6db-45a3-8902-1dbd9bea7400"), null },
                    { new Guid("0cf76fd3-199e-4b19-a9c4-cb336aa6dd46"), new Guid("35d46cd2-70e0-4173-b1a2-424034674091"), new Guid("38f49376-2d5a-4f08-85f0-7f016df57d00"), 1647781930L, new Guid("d1642386-4878-4964-87d5-0f5fa4d0c98e"), null },
                    { new Guid("57f8035d-4ff9-42c7-baaa-e9a0b92dce14"), new Guid("2628f674-b7c6-4e80-9c09-54028f2657b9"), new Guid("ad51ad64-3415-4f4c-a55d-15322ab17bf0"), 1647781930L, new Guid("7a142833-c5de-45ff-ae44-fdf6da5c681b"), null },
                    { new Guid("3f7ed1bf-bd50-4544-a862-e7ef1830f8e0"), new Guid("70802b04-96df-4eb8-9ee1-8e23848b66a3"), new Guid("1fbaf758-1543-4c85-ba4f-474139743635"), 1647781930L, new Guid("953ecf4a-f36f-4b05-9723-5129140836de"), null },
                    { new Guid("c31cd2bf-a2c5-48bc-9bfa-3dba33bd1432"), new Guid("ad8e56e6-8471-4c96-a531-4c796a0e702d"), new Guid("28e969a2-4bbb-4ae4-bfa5-9553923ca11d"), 1647781930L, new Guid("2ea92a17-9605-4e8d-bd3b-61465a47ffe8"), null },
                    { new Guid("aa4a6d51-1e78-4403-b0a2-922f60247ab5"), new Guid("1bd75d0a-0299-46cc-958d-2fc185657c76"), new Guid("28e969a2-4bbb-4ae4-bfa5-9553923ca11d"), 1647781930L, new Guid("8e565ee7-d587-4aa5-b01f-989367e86395"), null },
                    { new Guid("f6ad32e6-8a6f-473b-b656-30f74605cd5e"), new Guid("a1c2b1ef-cd24-4235-ad6b-19b551ac3d13"), new Guid("e230faaa-c81e-4586-9be8-d9e28b31765e"), 1647781930L, new Guid("68f5d54b-8f01-4734-a280-7bc37d59d478"), null },
                    { new Guid("d342e3be-3f2f-4789-9951-2c20c540fc89"), new Guid("1bd75d0a-0299-46cc-958d-2fc185657c76"), new Guid("c6cf7793-f455-4005-99cf-f641d8728ba2"), 1647781930L, new Guid("a9e3f6f6-0150-4470-9ca9-92a95d4c8dd8"), null },
                    { new Guid("3aa3951b-d174-459e-ac90-5910248333f4"), new Guid("ad8e56e6-8471-4c96-a531-4c796a0e702d"), new Guid("c6cf7793-f455-4005-99cf-f641d8728ba2"), 1647781930L, new Guid("7d948772-69b8-41f8-85e0-adf5532b5ea9"), null },
                    { new Guid("22366fee-1e25-4b69-a07c-b9c53c304aba"), new Guid("a1c2b1ef-cd24-4235-ad6b-19b551ac3d13"), new Guid("d650dc11-73cc-475e-acb2-536ac96217fa"), 1647781930L, new Guid("db1851fa-28b4-4912-a35b-3610c0e774f6"), null },
                    { new Guid("a87707ad-4518-42dc-95f2-4077df7d7672"), new Guid("62c03594-53ef-467f-b6df-5b21d90166de"), new Guid("1fbaf758-1543-4c85-ba4f-474139743635"), 1647781930L, new Guid("b096de2c-c80c-4f21-8221-7e9a55c9d585"), null },
                    { new Guid("54d02b5f-bb31-40fa-850a-6da5c4a14f13"), new Guid("3eec704d-8929-4ea3-a4f6-49f2ac2c455f"), new Guid("38f49376-2d5a-4f08-85f0-7f016df57d00"), 1647781930L, new Guid("add5b217-1bb0-403b-a709-be9f01140f5e"), null },
                    { new Guid("20efa157-026c-449d-82fe-29a6ea096eea"), new Guid("4756c00d-959e-4f41-afc8-f06351adc6b2"), new Guid("0fd08e6c-0007-4ca4-8634-65851d64b77e"), 1647781930L, new Guid("073f6e0c-eb54-42f3-bb6f-008afd69404c"), null },
                    { new Guid("b63bfa9a-119f-4f98-a3ac-2215208eb84e"), new Guid("f6c174a4-4209-4940-ad16-1b669ec2284f"), new Guid("0fd08e6c-0007-4ca4-8634-65851d64b77e"), 1647781930L, new Guid("e1930e3d-90f4-4176-a376-8d1fb8100629"), null },
                    { new Guid("af2e3ea4-1484-415e-a882-19ba5776c218"), new Guid("12e10ea6-e7ef-408f-90a6-bf30946b19a5"), new Guid("5d1c8d14-69b1-4846-827e-8b405c3d04fc"), 1647781930L, new Guid("4e3e9429-5c50-4c20-95b7-6a8fedbfb2da"), null },
                    { new Guid("2e5bf85a-afd8-4761-a031-b830358af653"), new Guid("fd69bb20-cb9e-4106-b0e6-ee34db0791ff"), new Guid("6735721d-cd78-4b9f-8e7a-f2e5c69ca744"), 1647781930L, new Guid("7c17fb27-b47a-4edd-91de-688e407e5460"), null },
                    { new Guid("8114ed3d-3300-430d-8b29-729ef55e116e"), new Guid("f9e261b5-a13f-4d01-9c66-d7e82ff462e2"), new Guid("6735721d-cd78-4b9f-8e7a-f2e5c69ca744"), 1647781930L, new Guid("f1eca1a9-96f4-42bc-b47c-daead5a449fd"), null },
                    { new Guid("50f8c315-5569-4306-aca8-3ea37a1861c5"), new Guid("12e10ea6-e7ef-408f-90a6-bf30946b19a5"), new Guid("8b955a3e-0e98-4f76-b03c-f302b619bd75"), 1647781930L, new Guid("45502922-a8d2-4ed0-acd3-e91c795cd85a"), null },
                    { new Guid("b1639d6e-ab6e-472a-8ca9-7eb72b3a6a5b"), new Guid("09040555-410f-4bda-9ada-8558a462e97e"), new Guid("a8ca35d8-bddc-4347-9a54-2b7e9e6a835b"), 1647781930L, new Guid("74a645cf-4626-4325-8dee-dbc380528ae6"), null },
                    { new Guid("10883016-48fb-45b5-abe9-bd5210ac30b5"), new Guid("f9e261b5-a13f-4d01-9c66-d7e82ff462e2"), new Guid("a8ca35d8-bddc-4347-9a54-2b7e9e6a835b"), 1647781930L, new Guid("74a645cf-4626-4325-8dee-dbc380528ae6"), null },
                    { new Guid("5724a79e-3236-4293-bc73-d40b24df77d3"), new Guid("fd69bb20-cb9e-4106-b0e6-ee34db0791ff"), new Guid("a8ca35d8-bddc-4347-9a54-2b7e9e6a835b"), 1647781930L, new Guid("05ee30ee-8b11-4d3e-af76-a485857c3b9a"), null },
                    { new Guid("9feec437-fc9d-4297-a49b-73c29f18a577"), new Guid("52ecc930-85d6-463a-a34a-73da73ef4ba8"), new Guid("ce84b3aa-9f71-412c-b7a5-4d23b4e11537"), 1647781930L, new Guid("723ab0be-a73a-4611-a8fc-2c8ce51b1be5"), null },
                    { new Guid("27ea4c66-fb1a-4451-8c35-9467043d4081"), new Guid("672c1ad4-1d47-4595-a9e2-608b07043052"), new Guid("ce84b3aa-9f71-412c-b7a5-4d23b4e11537"), 1647781930L, new Guid("4de0f0f5-0763-4385-9c12-f6a190d13554"), null },
                    { new Guid("8e09ee14-0083-43d1-9394-782248793f5c"), new Guid("9be8ba28-35fb-4476-83c7-1fca0147ef78"), new Guid("30492c2b-6156-4680-a7f1-966300dbd148"), 1647781930L, new Guid("5a2c668f-251c-46e6-8d42-be806abfb858"), null },
                    { new Guid("966a0cf0-a6a8-49f1-a64c-088d4399224c"), new Guid("672c1ad4-1d47-4595-a9e2-608b07043052"), new Guid("ce394b92-27c7-42c4-9115-cadbf73ec318"), 1647781930L, new Guid("83322174-7e4f-494a-b115-27daf6d6e6e1"), null },
                    { new Guid("d5036ab1-efdd-410e-bef1-7ef6d112db0b"), new Guid("52ecc930-85d6-463a-a34a-73da73ef4ba8"), new Guid("ce394b92-27c7-42c4-9115-cadbf73ec318"), 1647781930L, new Guid("739cfc78-e082-4f19-9777-5cf8bded81a8"), null },
                    { new Guid("581ff896-26b9-46e6-9443-18dde74419c0"), new Guid("9be8ba28-35fb-4476-83c7-1fca0147ef78"), new Guid("e7a43b47-50f8-4560-a785-3b16ec77e177"), 1647781930L, new Guid("b51ad3a0-635a-4d13-a6fc-edf8fd21fbc2"), null },
                    { new Guid("2edf1ea2-fe47-459c-88f0-7c24b5be1453"), new Guid("9d90c050-8de4-4ddd-9fc2-4aad78a61815"), new Guid("9eab98d3-22b2-4338-8ad1-d0857fe26a9a"), 1647781930L, new Guid("8cd82215-d2fa-4bf4-85ec-f9f515f5d2c1"), null },
                    { new Guid("fb75ad8f-603a-4144-860a-2bde48373fc8"), new Guid("4756c00d-959e-4f41-afc8-f06351adc6b2"), new Guid("8e326157-995c-47ff-91bd-8131ba2d21c1"), 1647781930L, new Guid("bfd7054d-299f-4e52-a521-8fb6acfa857f"), null },
                    { new Guid("295c765a-f464-40b2-a063-17930bc3187c"), new Guid("f6c174a4-4209-4940-ad16-1b669ec2284f"), new Guid("8e326157-995c-47ff-91bd-8131ba2d21c1"), 1647781930L, new Guid("93d1065f-7022-4671-b78a-13752eba08cd"), null },
                    { new Guid("cd443956-8df6-43f3-ac93-ad32102e91fe"), new Guid("9d90c050-8de4-4ddd-9fc2-4aad78a61815"), new Guid("dfd106c3-688a-4ec7-a310-472a011cb35e"), 1647781930L, new Guid("0df20739-b873-4ad0-9537-5d7aa1dd2fa1"), null },
                    { new Guid("75eb538c-d714-411f-ba8c-c17a840bc862"), new Guid("069868c9-0137-4182-bccc-cfca73bbb88d"), new Guid("b8cc9c8d-673c-4f7f-95cb-06af185cfa43"), 1647781930L, new Guid("196422ec-3dfa-409d-902a-172d2384d9e1"), null },
                    { new Guid("6956e6e6-b893-487a-ae02-1e7aff965cce"), new Guid("664314c5-7eac-4f78-a52d-b3cf51711e2a"), new Guid("9c5c96a8-99c2-4d2a-9fbb-d3fd3f70c558"), 1647781930L, new Guid("82be3127-ceef-4a1d-9480-bc114fc05137"), null },
                    { new Guid("0b41331a-50b7-4c94-bc99-1761d05875af"), new Guid("12ca3e24-9594-4ce7-b436-b11c95f56dd9"), new Guid("9c5c96a8-99c2-4d2a-9fbb-d3fd3f70c558"), 1647781930L, new Guid("6eb6a595-aa87-42ba-81b4-30ad94f1eb9a"), null },
                    { new Guid("94c26287-bf5b-4cbd-b4df-121f45f2098a"), new Guid("069868c9-0137-4182-bccc-cfca73bbb88d"), new Guid("969f76fb-fd4a-416b-b940-697bd7034fa7"), 1647781930L, new Guid("a5a596fa-2419-45a8-b1c8-16d399e326b4"), null },
                    { new Guid("34bd03b6-afe4-4d82-971f-bed66a9ad6f0"), new Guid("a2375428-70b5-4dcb-9e98-efa5b49ed258"), new Guid("cf3ed867-c9c5-489b-a22f-49d8e9abb95a"), 1647781930L, new Guid("4032b233-6023-43f0-a1f1-2c0941eaedd7"), null },
                    { new Guid("1e9c7576-df80-47f4-bdca-76ee48fc253e"), new Guid("6a924de5-af45-426c-88f1-7662cb537318"), new Guid("cf3ed867-c9c5-489b-a22f-49d8e9abb95a"), 1647781930L, new Guid("330b8fd4-506d-4eb5-b9b4-9f8abde2f0bf"), null }
                });

            migrationBuilder.InsertData(
                table: "StudyContracts",
                columns: new[] { "Id", "GroupId", "OptionalCourseId", "SignedAt", "StudentId", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("a23bbe78-a3f8-400c-836c-2ae49f99a221"), new Guid("c69ece68-2e7a-4458-a87e-3d251c5a9020"), new Guid("bb05a410-124f-43a2-8706-e1c5b3948d51"), 1647781930L, new Guid("87a8f497-6a15-4f69-9094-66adcd3b13b2"), null },
                    { new Guid("468e3a7a-9c32-42d2-8957-f41071caf577"), new Guid("6a924de5-af45-426c-88f1-7662cb537318"), new Guid("30f28f6e-8ea3-4365-97bd-24dc3b0b9688"), 1647781930L, new Guid("b6b2b206-598d-41e3-b410-4c3acf449735"), null },
                    { new Guid("9c7bb5b6-b6bc-44bf-9f18-16e717678599"), new Guid("a2375428-70b5-4dcb-9e98-efa5b49ed258"), new Guid("30f28f6e-8ea3-4365-97bd-24dc3b0b9688"), 1647781930L, new Guid("0979c688-52ae-4b59-9d3e-e9bde3e9b348"), null },
                    { new Guid("6d724bd7-63ca-474a-80a1-d5ce5a3aa826"), new Guid("7a53c558-199e-4143-945c-55faf57280dd"), new Guid("67f94c49-3db1-4041-a13c-d8a30bbf3bd0"), 1647781930L, new Guid("70d9f5de-f8fe-469e-aa65-68f5e659dd84"), null },
                    { new Guid("57f6eca8-0933-4b95-bb95-37dcf76bbf9c"), new Guid("6732bca1-e313-4fab-9cb3-071f97cb3446"), new Guid("67f94c49-3db1-4041-a13c-d8a30bbf3bd0"), 1647781930L, new Guid("cb885879-5935-4d4a-b938-13a5b6fc15ab"), null },
                    { new Guid("1157539a-864e-4103-afcb-68d683f99592"), new Guid("9b5c73cf-a6d3-4e3e-ace5-7324e7c0dc20"), new Guid("a95e201b-f7b0-43df-83e9-7c5e944f8b16"), 1647781930L, new Guid("3f40c9db-1d84-4673-b8b0-73fc6ea7d248"), null },
                    { new Guid("bfe0fcbb-175c-45dd-b9c6-8edcb0520491"), new Guid("6732bca1-e313-4fab-9cb3-071f97cb3446"), new Guid("9790264e-3bd7-4d2b-8ecd-95a61253d84c"), 1647781930L, new Guid("e49c781a-6856-47a2-a206-3fd03874608f"), null },
                    { new Guid("8c46a392-a101-42ef-992a-4691cdc2c2e7"), new Guid("7a53c558-199e-4143-945c-55faf57280dd"), new Guid("9790264e-3bd7-4d2b-8ecd-95a61253d84c"), 1647781930L, new Guid("412348ff-091f-4345-971b-b4b83f86b151"), null },
                    { new Guid("5d9009e9-ef87-40f0-9a17-e51755a5136b"), new Guid("9b5c73cf-a6d3-4e3e-ace5-7324e7c0dc20"), new Guid("700883ab-0b2a-404f-bbdd-879908916d60"), 1647781930L, new Guid("13087178-68d4-40a7-b444-83a46657a477"), null },
                    { new Guid("c12d0e89-774b-452e-8152-3018a8893ad0"), new Guid("fe7c25aa-4333-418f-9d15-f75e316f6a67"), new Guid("01e149bf-a905-4910-819d-b759443a9667"), 1647781930L, new Guid("ee45c3f3-05b8-4f14-8c3b-d1bfcd715390"), null },
                    { new Guid("d1b33f47-f285-427b-a221-d7400cfa8830"), new Guid("c8c439f9-fec6-46e3-8ecf-8d7686b2b6ef"), new Guid("96aaff7d-9226-4d85-ac21-5dd04c3f106b"), 1647781930L, new Guid("537c0fe6-3df0-49a2-a6ad-12b44b8a25c0"), null },
                    { new Guid("f41cb2c8-7d9f-4f31-b0f8-d8a375f7d66f"), new Guid("83dd507d-4b6e-4f2a-beb8-dfc4e83afd72"), new Guid("96aaff7d-9226-4d85-ac21-5dd04c3f106b"), 1647781930L, new Guid("f4e54ad5-484d-4ce5-8a18-b26b4d0113c4"), null },
                    { new Guid("293e0d0d-257f-4372-9f29-2637874ddccc"), new Guid("fe7c25aa-4333-418f-9d15-f75e316f6a67"), new Guid("6835ec29-7d43-485a-b778-63df211acfd2"), 1647781930L, new Guid("9cc8c670-bb4d-4fdd-9f81-8cee91a8cb9f"), null },
                    { new Guid("19a471af-30aa-46d5-a589-b9456d136d46"), new Guid("83dd507d-4b6e-4f2a-beb8-dfc4e83afd72"), new Guid("b176b53e-7c91-4de1-8ba7-1f8f138b618f"), 1647781930L, new Guid("664befdf-b645-4d8c-aa73-d14496869eba"), null },
                    { new Guid("da550062-d26f-4598-bfbe-910db5e696a8"), new Guid("5b8fcc6f-4f37-4415-9402-fef2ce053475"), new Guid("b176b53e-7c91-4de1-8ba7-1f8f138b618f"), 1647781930L, new Guid("864835ed-983c-47ab-9fa4-74182f9a7efd"), null },
                    { new Guid("fe8b13fb-1925-4f8d-9fb8-5048b54480a4"), new Guid("c69ece68-2e7a-4458-a87e-3d251c5a9020"), new Guid("751fea05-1fdd-4aba-b833-5f513edd9c5e"), 1647781930L, new Guid("ffb1dd7b-95c3-434d-b85a-1a3ea6abe788"), null },
                    { new Guid("d33e5350-5607-4f5e-bcf3-54b6e1c93d1c"), new Guid("0c206d70-9233-4fff-9643-2fdaf6a4e9d7"), new Guid("12c5c906-bf3c-4906-80dd-610cfa151004"), 1647781930L, new Guid("73daa1b1-1887-4bd9-a347-0933e0acc910"), null },
                    { new Guid("bde13a21-9cd3-448d-a355-c19938abc3ab"), new Guid("b46bce9b-d46b-40ce-9048-042c8349e723"), new Guid("1b7d8fb7-0f81-411e-b500-497e1a661e93"), 1647781930L, new Guid("102ab3b0-919e-48b0-9fb1-925aa313869d"), null },
                    { new Guid("7c9589e5-12a6-45c0-bd27-654f0f3713bf"), new Guid("65f797cf-3428-4826-8468-536c801ad57b"), new Guid("e38d492a-cb2e-4ab7-95a8-9133d16753d4"), 1647781930L, new Guid("f2febae9-35f3-4b86-b3b3-b1e1ecb4e861"), null },
                    { new Guid("5271bfaf-8390-456f-b8cb-c76e734d4286"), new Guid("12ca3e24-9594-4ce7-b436-b11c95f56dd9"), new Guid("67ef47f5-ca22-4192-887d-2a1a90b230ae"), 1647781930L, new Guid("b88e69ab-96b0-4c31-875b-87db21c52748"), null },
                    { new Guid("8c792bd6-b398-4cf2-bcfc-faced955ed44"), new Guid("664314c5-7eac-4f78-a52d-b3cf51711e2a"), new Guid("67ef47f5-ca22-4192-887d-2a1a90b230ae"), 1647781930L, new Guid("671ecf27-fde4-4e5f-97d2-77b23cc5f9ea"), null },
                    { new Guid("1e4253d7-f5de-4894-b35b-3e59af6ec442"), new Guid("36907eec-b95c-4ff7-83cb-c29dd0475900"), new Guid("d5d42cfa-9d5e-4917-91bd-bd1578f774e1"), 1647781930L, new Guid("8728511e-ea06-44a5-b0c9-e80a114c10c0"), null },
                    { new Guid("4e7c3c7d-9e88-4a78-b4ce-1d299ace02fb"), new Guid("fd13fa20-be8c-4bbc-8400-efef49011b36"), new Guid("d5d42cfa-9d5e-4917-91bd-bd1578f774e1"), 1647781930L, new Guid("58501e6f-7c91-4691-a51a-0949d17b75fd"), null },
                    { new Guid("d70b2933-6c3a-4732-8d6a-96bc248a9ec3"), new Guid("b0c7235d-ac5e-4b10-b830-503d7045b047"), new Guid("896ac401-17e8-42de-812a-64613bfc15e0"), 1647781930L, new Guid("2ab25825-0066-4d1e-9098-aaea358c0632"), null },
                    { new Guid("5c7056b7-21a6-4d59-950b-f5664cb0fe91"), new Guid("fd13fa20-be8c-4bbc-8400-efef49011b36"), new Guid("81059acd-7b27-493c-8bbf-e2dc408013a9"), 1647781930L, new Guid("ede3806c-24b2-4caf-974b-20b608430d61"), null },
                    { new Guid("c6b6cf4c-86ec-4667-a14a-d379f371bf41"), new Guid("36907eec-b95c-4ff7-83cb-c29dd0475900"), new Guid("81059acd-7b27-493c-8bbf-e2dc408013a9"), 1647781930L, new Guid("0896c167-f916-4364-9665-5a96c4ecbc35"), null },
                    { new Guid("b9549d2b-da88-4557-8336-18167af264ec"), new Guid("b0c7235d-ac5e-4b10-b830-503d7045b047"), new Guid("999ea8b7-c728-4992-9f4d-4764383f02a0"), 1647781930L, new Guid("299d52f7-3535-4cef-b79c-13424f94beba"), null },
                    { new Guid("895e0a42-6663-401e-8cbc-de9fbf02449e"), new Guid("d46cffa2-3d58-4f86-81d8-dd72462e84f4"), new Guid("6e58b18a-b7d5-459c-a3bd-fa31e8f6d792"), 1647781930L, new Guid("c1addc98-abc7-4493-a562-633a1e719f77"), null },
                    { new Guid("17545c37-b4aa-45f7-9269-bffd9d386f45"), new Guid("e62ac446-7db4-4c2d-ac0e-a8484318e883"), new Guid("f0a30ae4-29a6-4244-8758-9f9666c8f5f8"), 1647781930L, new Guid("034205a1-5249-47f4-8951-61cbf368b5dc"), null },
                    { new Guid("7d729c93-d903-4304-aafd-6c484b96db13"), new Guid("0afd0499-eb84-48dc-8da6-39f88384d9f4"), new Guid("f0a30ae4-29a6-4244-8758-9f9666c8f5f8"), 1647781930L, new Guid("df3878bb-d580-4e33-bfd4-d031c9e8f752"), null },
                    { new Guid("f1d789b2-89a3-44f9-b2b2-b79945228341"), new Guid("d46cffa2-3d58-4f86-81d8-dd72462e84f4"), new Guid("daa5a389-753f-49df-ae73-3e18df435ead"), 1647781930L, new Guid("7b10af2a-5c2f-4cce-a94c-f70bdef294d9"), null },
                    { new Guid("871e0618-9935-4ded-8567-2451456fe08f"), new Guid("0afd0499-eb84-48dc-8da6-39f88384d9f4"), new Guid("e62a9428-cb16-48f0-b466-5eeaf9e61054"), 1647781930L, new Guid("6dee2159-93c5-4840-b02c-0a60d268f282"), null },
                    { new Guid("ac606e5f-7daf-448e-a383-64565beb6652"), new Guid("e62ac446-7db4-4c2d-ac0e-a8484318e883"), new Guid("e62a9428-cb16-48f0-b466-5eeaf9e61054"), 1647781930L, new Guid("7ce79836-fb94-479a-926b-8435573f2418"), null },
                    { new Guid("9b8663c0-882f-478c-a989-1d41e3b543ae"), new Guid("d80dbc67-9640-4654-a154-8291acf9c042"), new Guid("1fd1773b-3374-416e-bfe7-a95df88e7d36"), 1647781930L, new Guid("839f9d3b-e785-4b39-8130-33ac35670340"), null },
                    { new Guid("82f98dd3-6d7e-47fc-ac3c-ae91b1180d39"), new Guid("65f797cf-3428-4826-8468-536c801ad57b"), new Guid("1fd1773b-3374-416e-bfe7-a95df88e7d36"), 1647781930L, new Guid("416ec3a4-399a-47ca-b4b4-d91f2cb91d2b"), null },
                    { new Guid("c4c192e2-cd16-445c-abe7-264cd88f1417"), new Guid("b46bce9b-d46b-40ce-9048-042c8349e723"), new Guid("f255a1ba-2d4c-4997-b5f9-a9d2bacd2717"), 1647781930L, new Guid("7b6b190b-375a-42d0-b035-9ae590e89083"), null },
                    { new Guid("31082928-5c05-4f8b-913b-599d114e49c9"), new Guid("d80dbc67-9640-4654-a154-8291acf9c042"), new Guid("e38d492a-cb2e-4ab7-95a8-9133d16753d4"), 1647781930L, new Guid("9c540e22-43ad-4ce9-9ecb-b2dbc96dd528"), null },
                    { new Guid("c98a2ecd-c57d-4571-80f0-eab0aee28c28"), new Guid("c7791c66-63f5-4afe-b85e-a455db16fe30"), new Guid("1e0cc69a-0479-4b70-99fb-c4f4e377b6e9"), 1647781930L, new Guid("d649f312-18aa-4508-b497-6da80a0aa84b"), null },
                    { new Guid("4effb330-8344-4a58-9b84-1fed26458b65"), new Guid("ad9afa02-5847-4752-b687-1b6ff0966b98"), new Guid("c37f77ba-35b7-4f64-8609-770636f6d97d"), 1647781930L, new Guid("68501085-da2e-4cae-a58e-425c25f1ebc2"), null },
                    { new Guid("48902b60-8682-43c8-8936-224aa174b79f"), new Guid("0c206d70-9233-4fff-9643-2fdaf6a4e9d7"), new Guid("76329fd5-8908-440a-89f0-4bbdd3cbfaf3"), 1647781930L, new Guid("8816b4ed-b512-4ce6-8bee-540a69ed5763"), null },
                    { new Guid("53725c7b-1703-40c8-8c0c-47f9c45d5f79"), new Guid("963510d6-9a57-425d-a3ee-f0fd130b77ad"), new Guid("bb2f068d-c50a-47b8-8f02-f5b2b07d1730"), 1647781930L, new Guid("1dad04fc-3a6a-422a-a9ed-cde3e9de3243"), null },
                    { new Guid("e6dd6b3e-e407-4cfe-b46d-ee785ff19c0b"), new Guid("61098e44-87fc-4376-990b-a4dd33662844"), new Guid("c80015d5-8f76-4d9c-99b1-d6f05aeb6b5a"), 1647781930L, new Guid("e6fdc458-a365-4d6b-9302-1dcd1ff0b3bb"), null }
                });

            migrationBuilder.InsertData(
                table: "StudyContracts",
                columns: new[] { "Id", "GroupId", "OptionalCourseId", "SignedAt", "StudentId", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("aea8ee96-75b7-49b0-af27-1df08c64e133"), new Guid("a0a65ae6-0fa8-4c45-93dc-bba19e92251a"), new Guid("47d1e729-a710-40f3-8f8e-23fe5be8bfba"), 1647781930L, new Guid("02c2ba64-0eab-4371-8720-2f648fb24cd2"), null },
                    { new Guid("23eca5f2-533e-45ed-8ebe-38276dd87fb1"), new Guid("f6cb6f78-ce0f-467b-91e1-a9ebc4a09a89"), new Guid("47d1e729-a710-40f3-8f8e-23fe5be8bfba"), 1647781930L, new Guid("d44bdecf-2774-4ba7-82fb-dc73ef88301e"), null },
                    { new Guid("7fc0eadd-27ce-40dc-8590-decc6d627adf"), new Guid("61098e44-87fc-4376-990b-a4dd33662844"), new Guid("75c659ae-ff9a-45a8-8c16-321fad42a407"), 1647781930L, new Guid("bd20d12e-7af3-451e-a1e8-a8c6a79a612c"), null },
                    { new Guid("da144256-8146-47ff-8d5b-41f6cff65fc4"), new Guid("f6cb6f78-ce0f-467b-91e1-a9ebc4a09a89"), new Guid("6a495201-43da-45a9-b6a0-d9cb2a8bd177"), 1647781930L, new Guid("9b8a47c8-541e-4f12-b475-bda37c711a63"), null },
                    { new Guid("b972177f-a5fa-4f74-8df0-31e229a8358a"), new Guid("a0a65ae6-0fa8-4c45-93dc-bba19e92251a"), new Guid("6a495201-43da-45a9-b6a0-d9cb2a8bd177"), 1647781930L, new Guid("9ddc7694-8886-4342-9e35-e30f49b914a6"), null },
                    { new Guid("ac222288-9843-4302-b3c9-b5f6f278ae02"), new Guid("dabd9a7f-01ef-49ff-830a-63c6b3d8c206"), new Guid("e0b72032-ee1f-40ac-b097-0d77b1105c50"), 1647781930L, new Guid("ec9022c9-d5d9-4fe8-b6e9-0bb8b761a2c7"), null },
                    { new Guid("7ce541a4-6a52-413f-8fe7-6e71b3ced078"), new Guid("328aea8e-09df-48b8-9e30-3674e7f72dc1"), new Guid("3e1e6a08-e05e-4d14-b20f-2d9e3abb2725"), 1647781930L, new Guid("d1122ea9-142a-495c-8e86-a0ce3908e68f"), null },
                    { new Guid("0d3e8aff-8bfb-4423-a6c4-287af001ff9c"), new Guid("deed5e6e-a5f7-48d8-8b72-e0fcabaa0183"), new Guid("add9b43c-f713-4aac-8f28-4b64997d1d70"), 1647781930L, new Guid("b3ace2d3-eb4b-4228-bd0c-a7140dafc193"), null },
                    { new Guid("f88870e8-7068-4e23-b854-c80c5ba30758"), new Guid("3fd4e98d-1e7e-43ba-9e74-4bdd5ec2e9b4"), new Guid("510ced57-020f-46f9-ae29-e5f709e0c472"), 1647781930L, new Guid("d8e37b87-a231-4d24-82c0-54f2e0fcbb40"), null },
                    { new Guid("8e4f38a7-1036-46d8-b75d-e84bb7c7e1b2"), new Guid("328aea8e-09df-48b8-9e30-3674e7f72dc1"), new Guid("510ced57-020f-46f9-ae29-e5f709e0c472"), 1647781930L, new Guid("1b3b9a22-c256-4471-8356-fa51c2330f45"), null },
                    { new Guid("797ec72b-5764-4490-a508-0a038883e6ef"), new Guid("deed5e6e-a5f7-48d8-8b72-e0fcabaa0183"), new Guid("c15371b4-a255-4dd8-91ed-afb91fea8b74"), 1647781930L, new Guid("c068f017-9340-4626-9e26-38a2afac6cc4"), null },
                    { new Guid("ca986419-25c1-4f31-b7ef-1015014bfa52"), new Guid("cdebe47b-21f6-4230-bf3f-fb87eafbae23"), new Guid("6f44f636-7779-4ef6-882f-6b327fcccf14"), 1647781930L, new Guid("73136877-d126-41a6-b9b1-2a647037f4c6"), null },
                    { new Guid("d2e0cf1f-6b3b-4aaf-95f9-1637a7fca651"), new Guid("953ae21d-20d8-4e1e-bc3a-e8451f6245f9"), new Guid("327470e1-e9eb-466d-a388-5fa859aab073"), 1647781930L, new Guid("104286ed-bef5-4225-aa2a-ce23cc959565"), null },
                    { new Guid("7d3d8e71-cd6a-406e-9bea-50aa9f279895"), new Guid("8a0a3916-5a0d-4af8-9ba2-77c1488b57a0"), new Guid("327470e1-e9eb-466d-a388-5fa859aab073"), 1647781930L, new Guid("1782d872-4343-4121-a74a-b8d9f4de521a"), null },
                    { new Guid("7d171c64-2199-4433-8149-38549cce693d"), new Guid("3fd4e98d-1e7e-43ba-9e74-4bdd5ec2e9b4"), new Guid("3e1e6a08-e05e-4d14-b20f-2d9e3abb2725"), 1647781930L, new Guid("1c937154-b733-436c-a8f6-894e21eb44c7"), null },
                    { new Guid("cb900380-0cce-4e78-9c8e-245634531855"), new Guid("b8e83370-a520-488c-a567-ec7a913ffed7"), new Guid("e0b72032-ee1f-40ac-b097-0d77b1105c50"), 1647781930L, new Guid("b0e76f2b-23f7-4c86-80e0-3893b50b360f"), null },
                    { new Guid("8249ebda-45f4-4443-9b1d-5e8473bf6b92"), new Guid("963510d6-9a57-425d-a3ee-f0fd130b77ad"), new Guid("07cca817-a307-4d4f-a581-8fd0655d1ef1"), 1647781930L, new Guid("99ddf014-1e00-44cf-b50c-f310e9c7a578"), null },
                    { new Guid("1f9d0bd1-89ab-4bdf-8d1f-ced06ce1e8b8"), new Guid("b8e83370-a520-488c-a567-ec7a913ffed7"), new Guid("41532518-4fa1-49e9-a3d9-104489605c57"), 1647781930L, new Guid("fa0f5fea-3047-4228-aaf3-78fb56f629d9"), null },
                    { new Guid("1cc798a2-0428-4716-a6c4-25bbe1521206"), new Guid("b543253e-a791-4fd6-b0cb-c8730e6c2311"), new Guid("17c5e005-e058-4ebe-94d9-c71513cdc323"), 1647781930L, new Guid("614a8376-606e-40a3-9b5e-756a635cc0b9"), null },
                    { new Guid("3c42d516-6a02-4741-aafb-8df986c69ea7"), new Guid("c7791c66-63f5-4afe-b85e-a455db16fe30"), new Guid("438d5885-e14d-40f8-b971-bfa6269384fe"), 1647781930L, new Guid("3dbe9795-2646-4328-b8da-116461317c7a"), null },
                    { new Guid("f5dc4949-4ea5-4009-9648-9a30091919a7"), new Guid("b543253e-a791-4fd6-b0cb-c8730e6c2311"), new Guid("cc08422d-0c86-491a-be25-1d52e3e17f80"), 1647781930L, new Guid("b7dd3531-470d-4fa2-981a-013623b45c39"), null },
                    { new Guid("4ad418c9-f258-4ce9-adca-679e90e22d14"), new Guid("ba1fe61e-bc87-4f3e-b09d-f795e2f01b23"), new Guid("cc08422d-0c86-491a-be25-1d52e3e17f80"), 1647781930L, new Guid("941284c7-92a1-4031-adac-632f2740aa19"), null },
                    { new Guid("2219aff6-23cb-4ae3-9981-ce0736d65483"), new Guid("53e919b5-1242-4a46-8cdb-0eb506db5312"), new Guid("819a134b-53ad-4a52-94dc-7a3a050023cb"), 1647781930L, new Guid("c6fb3335-b3d2-4549-b4ea-189a5da3888c"), null },
                    { new Guid("a59c9a6a-c937-42d5-9b92-d2bc23cbad96"), new Guid("09040555-410f-4bda-9ada-8558a462e97e"), new Guid("819a134b-53ad-4a52-94dc-7a3a050023cb"), 1647781930L, new Guid("dabab4a3-4996-48ae-8f84-158d11dddad1"), null },
                    { new Guid("15ae4080-ea58-4dea-a662-878534ccfd44"), new Guid("cc163017-0796-4e63-afe6-ed96f935ea2f"), new Guid("6b3c473f-2af6-458b-82aa-a63d7675042a"), 1647781930L, new Guid("2fbaff75-b3d7-4446-a9ee-1a4f57821abc"), null },
                    { new Guid("3dd64988-c108-48de-bbdf-045db1004003"), new Guid("09040555-410f-4bda-9ada-8558a462e97e"), new Guid("4b323d51-3630-4102-b621-e718adfcd0dc"), 1647781930L, new Guid("6092dfbd-a8dc-43a9-b594-45344f3981cb"), null },
                    { new Guid("fa75211c-fc05-43a0-8ce8-33688db8c032"), new Guid("53e919b5-1242-4a46-8cdb-0eb506db5312"), new Guid("4b323d51-3630-4102-b621-e718adfcd0dc"), 1647781930L, new Guid("f2e22ec6-9ed7-4589-9e91-1a533a0ea55e"), null },
                    { new Guid("4e11bd6b-0fa3-418b-8804-5eb28da23993"), new Guid("cc163017-0796-4e63-afe6-ed96f935ea2f"), new Guid("50070cf2-3bc3-4bbb-997e-c55665caa885"), 1647781930L, new Guid("84e9b211-30f7-4da1-bd76-dda8b1ea93fa"), null },
                    { new Guid("5a069de2-624b-480c-b007-321938ee7045"), new Guid("59c8db82-1bd5-4d52-82b9-de1534336c8e"), new Guid("bf2d1567-a9e3-4d83-906c-e816dea8b82e"), 1647781930L, new Guid("49fd54da-83d4-488d-bff6-4ce4f5de6369"), null },
                    { new Guid("06df63a6-5f46-4579-a5c2-36d4d9f38451"), new Guid("dc723434-f040-4705-b7fe-a0ec875165fb"), new Guid("93bab3b4-7584-4602-9e92-9e28e42c516d"), 1647781930L, new Guid("4a70ac57-6eee-461a-b9c4-ecaed19de418"), null },
                    { new Guid("30b024ff-a4b4-4116-8589-1b4922cf3459"), new Guid("6d4d9195-dbc2-42ba-8b2b-02b4b7b5d7a2"), new Guid("93bab3b4-7584-4602-9e92-9e28e42c516d"), 1647781930L, new Guid("f670ee20-cfec-489f-b6ba-2e43907d9bc1"), null },
                    { new Guid("f34b7011-93f3-46bf-baa2-40cd0e9e85f1"), new Guid("59c8db82-1bd5-4d52-82b9-de1534336c8e"), new Guid("882a8345-0e3d-4c3d-b73c-7e4b33fa347d"), 1647781930L, new Guid("b649f119-26be-4457-a1c5-f371f099324a"), null },
                    { new Guid("4bab6e7c-b9cf-47b0-b9ee-babbdc8c5fc7"), new Guid("6d4d9195-dbc2-42ba-8b2b-02b4b7b5d7a2"), new Guid("fbd5061b-ba1b-4769-88b6-4bd7c86496c3"), 1647781930L, new Guid("ee16b62b-de15-4957-a929-868772ca9c56"), null },
                    { new Guid("616d7650-ce54-434e-a23b-d2bb331eadac"), new Guid("dc723434-f040-4705-b7fe-a0ec875165fb"), new Guid("fbd5061b-ba1b-4769-88b6-4bd7c86496c3"), 1647781930L, new Guid("7760094a-f97f-4d90-964e-4bead3c6548a"), null },
                    { new Guid("ff2492cd-8d4b-4952-aec3-465cd078cd0e"), new Guid("dabd9a7f-01ef-49ff-830a-63c6b3d8c206"), new Guid("41532518-4fa1-49e9-a3d9-104489605c57"), 1647781930L, new Guid("e42d1d91-c378-4444-b1d6-ce8853879377"), null },
                    { new Guid("b06d2ba4-c03d-420f-b38e-dda5c1367c88"), new Guid("cdebe47b-21f6-4230-bf3f-fb87eafbae23"), new Guid("f5abbe2c-2466-4143-9011-c0f97d06fcf7"), 1647781930L, new Guid("5dbcd666-8455-4b6d-b151-f7b63f5b9a41"), null },
                    { new Guid("e2f647c9-9477-4477-a45e-f51bfa3ef936"), new Guid("8a0a3916-5a0d-4af8-9ba2-77c1488b57a0"), new Guid("f1f87f7b-c672-4aa6-9339-31327d56e589"), 1647781930L, new Guid("cbcfe3d0-78dd-4cd0-b0fe-48aa4381baff"), null },
                    { new Guid("c2bbb06f-00bd-4de8-824e-72e72e251d1a"), new Guid("953ae21d-20d8-4e1e-bc3a-e8451f6245f9"), new Guid("f1f87f7b-c672-4aa6-9339-31327d56e589"), 1647781930L, new Guid("a2c2a7ad-527d-4d3e-9f82-bad53d4a25c9"), null },
                    { new Guid("ff2fe3c6-e14b-45ed-90f1-2f29e3f743f9"), new Guid("3337d734-c60c-4db4-b380-4558552e3d9d"), new Guid("9c54d910-07a8-4aed-ba07-90eccb1f1e05"), 1647781930L, new Guid("4a135aca-13a7-40f1-8a06-a7c6feb5a86f"), null },
                    { new Guid("fbee5c37-fee9-4f52-a3b0-d11fbf6ab088"), new Guid("299963dc-f175-496b-ab6a-688774dce4f4"), new Guid("482e8325-1986-4c5f-8260-781f9ed4318d"), 1647781930L, new Guid("2e5be4c6-013a-4d61-bb77-54bd64d52d59"), null },
                    { new Guid("d3dd0a99-cec1-4e42-890f-b945c4bbcc9e"), new Guid("e90a85f5-89b8-4c83-bf15-ba04cd1c13bb"), new Guid("61002e77-9dd2-4126-ae98-98c631891fa0"), 1647781930L, new Guid("e685708f-ea4b-4f04-8391-d00c91fbacd8"), null },
                    { new Guid("54d2f219-2778-4d4d-a5a5-92b872f7c06b"), new Guid("e3375ee7-6cc6-4b66-955b-b4688d965fdb"), new Guid("61002e77-9dd2-4126-ae98-98c631891fa0"), 1647781930L, new Guid("069dbe85-ca34-4a06-8e55-3f7babeab277"), null }
                });

            migrationBuilder.InsertData(
                table: "StudyContracts",
                columns: new[] { "Id", "GroupId", "OptionalCourseId", "SignedAt", "StudentId", "StudyYearId" },
                values: new object[,]
                {
                    { new Guid("7fe7b69a-e94d-4baa-a67f-cefbf1d1aa0b"), new Guid("5b8fcc6f-4f37-4415-9402-fef2ce053475"), new Guid("8f37800a-9b09-4f31-875f-9509d3c72aca"), 1647781930L, new Guid("e3cca282-eb69-43e5-a639-80746e532af4"), null },
                    { new Guid("818cb4d3-8f1a-45c9-9239-8d784f749030"), new Guid("6aaf1a9b-37f5-42e9-acd9-8faa5ba78618"), new Guid("8f37800a-9b09-4f31-875f-9509d3c72aca"), 1647781930L, new Guid("1f42d139-f2c7-4498-8f98-50ff212865b4"), null },
                    { new Guid("9619b53a-f869-43e8-9b71-77e3cff3bfb2"), new Guid("e9d2e865-c44e-424a-8444-8cc309733527"), new Guid("36ae2d8e-7ac3-4007-bfec-de10689502ae"), 1647781930L, new Guid("16490c8e-804e-4bb7-b27b-9eacccb56751"), null },
                    { new Guid("0f619b0a-f5f8-4c0f-8aca-773c3164d5ff"), new Guid("6aaf1a9b-37f5-42e9-acd9-8faa5ba78618"), new Guid("8eff2996-22b0-44a7-8e4e-e77715b91532"), 1647781930L, new Guid("fc6579c5-99e4-4a47-828c-59eae285a105"), null },
                    { new Guid("d74edc4d-dc66-41fd-af23-6bef4c7536e6"), new Guid("5b8fcc6f-4f37-4415-9402-fef2ce053475"), new Guid("8eff2996-22b0-44a7-8e4e-e77715b91532"), 1647781930L, new Guid("e6ab51f7-3efb-433f-94c4-686be78ec13c"), null },
                    { new Guid("345cc503-4188-4f1b-9098-60a11b8342ec"), new Guid("e9d2e865-c44e-424a-8444-8cc309733527"), new Guid("a881f091-5c20-4fcc-bdd6-fd820c482bc3"), 1647781930L, new Guid("a2d251f7-5129-406a-a6b4-c1e4c996eb9f"), null },
                    { new Guid("6d1fc893-4663-478d-9194-a6b52e1e81ba"), new Guid("18f725d5-fca7-4b62-b3d1-a5d5b50fff66"), new Guid("22c2943c-8ba3-4965-866c-4b4266ac5995"), 1647781930L, new Guid("1c6e3c16-ca7f-4350-9a40-30483ad2378a"), null },
                    { new Guid("4c0f1183-9359-495b-978a-bbbe2f115236"), new Guid("c2ab2780-dc6a-4a34-be5a-2aaf91bc9efd"), new Guid("a9fc3faa-9252-46f4-9a4f-8185417f58a5"), 1647781930L, new Guid("f3d7e5b3-91a7-4091-b1d4-70d977015a97"), null },
                    { new Guid("9db13154-90d9-45fd-a7fd-c92f0523719c"), new Guid("263dfaf9-823b-4360-a8bd-7696728de44e"), new Guid("a9fc3faa-9252-46f4-9a4f-8185417f58a5"), 1647781930L, new Guid("7777f4f1-9471-4e7b-86a7-02793fdd5f12"), null },
                    { new Guid("c000c370-d464-4d2a-94ae-21cc5b53c98f"), new Guid("18f725d5-fca7-4b62-b3d1-a5d5b50fff66"), new Guid("da7374f4-9c06-472e-a617-32c423a22cb0"), 1647781930L, new Guid("b28b0111-9144-4e2e-9607-85a3ee198caa"), null },
                    { new Guid("f3aca269-2845-4e6c-a7a4-207e60ae4600"), new Guid("263dfaf9-823b-4360-a8bd-7696728de44e"), new Guid("ecc38925-a001-4768-a433-6d36197fd0fb"), 1647781930L, new Guid("acdaa934-2f77-4a09-8636-940a3e799fa9"), null },
                    { new Guid("2d7b4686-fc50-40d0-b35e-5d3d6736bbaf"), new Guid("c2ab2780-dc6a-4a34-be5a-2aaf91bc9efd"), new Guid("ecc38925-a001-4768-a433-6d36197fd0fb"), 1647781930L, new Guid("99958972-fb6c-41f1-bdcc-3d2239061506"), null },
                    { new Guid("7dc6ee2c-311d-48f2-8ae1-418b8c4637fc"), new Guid("ad9afa02-5847-4752-b687-1b6ff0966b98"), new Guid("c7ee94a8-1727-4f09-a8c7-abe1f3a0538f"), 1647781930L, new Guid("71cbeeee-1bf5-407b-8dd8-36e62fde3a79"), null },
                    { new Guid("90a0cfd3-1132-42fb-ae51-784407607914"), new Guid("d2633a36-09c1-48bc-af67-5bd305e6a54f"), new Guid("c7ee94a8-1727-4f09-a8c7-abe1f3a0538f"), 1647781930L, new Guid("72343ca2-81ec-4197-845d-9eb2abec963a"), null },
                    { new Guid("c4e48442-4caa-4d9e-a93f-aafde154e812"), new Guid("e90a85f5-89b8-4c83-bf15-ba04cd1c13bb"), new Guid("89bfefe7-37cb-4e9d-99d1-80d383c491fb"), 1647781930L, new Guid("4b5534b7-7816-4258-a054-ac2e4b14cd99"), null },
                    { new Guid("cfec9090-86b9-45be-9b8e-85c43023f7fe"), new Guid("d2633a36-09c1-48bc-af67-5bd305e6a54f"), new Guid("c37f77ba-35b7-4f64-8609-770636f6d97d"), 1647781930L, new Guid("657d11eb-d104-4856-a54f-3ae5037b06f0"), null },
                    { new Guid("38f5bac9-0c50-4311-bd7e-b0b77ae011ff"), new Guid("bdc2f38a-ab1b-4244-a5fa-55fee555809d"), new Guid("89bfefe7-37cb-4e9d-99d1-80d383c491fb"), 1647781930L, new Guid("4b5534b7-7816-4258-a054-ac2e4b14cd99"), null },
                    { new Guid("73fdfa32-1b78-4d71-a198-1c0f654ea73c"), new Guid("299963dc-f175-496b-ab6a-688774dce4f4"), new Guid("8b080705-3b5b-4fe1-933f-f815fdbfb0b4"), 1647781930L, new Guid("b9ac4919-78e7-4730-9b53-626e37a8c7dc"), null },
                    { new Guid("7fadcdf8-27f7-455b-9783-f43b9dc3b209"), new Guid("4fe6eac9-23a0-48c1-90f7-82f5d574bddb"), new Guid("9c54d910-07a8-4aed-ba07-90eccb1f1e05"), 1647781930L, new Guid("f39f58a5-66a3-48d5-a8c4-c759c9381daf"), null },
                    { new Guid("96fd5962-7130-4ffe-9ea4-8bef5f574786"), new Guid("838615c9-174a-4fc5-9374-35f14ae2748b"), new Guid("0baf744a-56bb-4d47-84b8-a9b6667ae6b3"), 1647781930L, new Guid("70c6f552-ad16-4f08-b6c4-6dc4e333ed88"), null },
                    { new Guid("55ffdf8d-02a7-4b95-8360-ab4e83b3ba3c"), new Guid("4fe6eac9-23a0-48c1-90f7-82f5d574bddb"), new Guid("257474ee-eef9-4ff6-a783-997e8851b579"), 1647781930L, new Guid("39924560-12c6-45db-90bd-9c645ffc68ef"), null },
                    { new Guid("04e4b2cf-1c27-45f6-9265-52900e5c8334"), new Guid("3337d734-c60c-4db4-b380-4558552e3d9d"), new Guid("257474ee-eef9-4ff6-a783-997e8851b579"), 1647781930L, new Guid("edd6ca17-b15a-42dc-9d58-19b3f1f758fe"), null },
                    { new Guid("3c3c9f69-4355-4970-aff1-cf7d7f2245bb"), new Guid("838615c9-174a-4fc5-9374-35f14ae2748b"), new Guid("ba589761-e059-4c2f-a29e-9cadd11cf75c"), 1647781930L, new Guid("498890aa-b2d9-4f17-9655-296668070b73"), null },
                    { new Guid("2991c0d0-ccb3-4cc2-a422-22a3bea743d7"), new Guid("fb811689-f1c5-4efe-8ee0-900892697acc"), new Guid("27e2a2e3-39ad-4b1d-b250-15b9dfe9fc35"), 1647781930L, new Guid("0a048c60-3802-45b2-b31b-a3ad5366e0d3"), null },
                    { new Guid("30591134-c571-4198-ab64-9a5e5014209e"), new Guid("8ae457fb-d6b5-4326-9269-7485c2066b65"), new Guid("06b5f55b-846a-497c-aa80-3ac96537152a"), 1647781930L, new Guid("abb4e237-62c7-44e9-ac45-00e6a3c9fea9"), null },
                    { new Guid("a8fa83e9-f1ba-4ce6-9f5c-01e879672abe"), new Guid("a045fbe8-2653-4c69-81f4-a8f796c7892d"), new Guid("06b5f55b-846a-497c-aa80-3ac96537152a"), 1647781930L, new Guid("71ad4df6-ad99-45a5-9eee-147afda9ad20"), null },
                    { new Guid("927f3669-d876-4387-a2cb-41126d66de9f"), new Guid("fb811689-f1c5-4efe-8ee0-900892697acc"), new Guid("b5364a53-48ef-47ed-a431-fcbeeb8235d2"), 1647781930L, new Guid("b5433351-d2fd-4189-b61f-cad1bc745503"), null },
                    { new Guid("656d83fd-d80a-4aca-8483-3361af562300"), new Guid("a045fbe8-2653-4c69-81f4-a8f796c7892d"), new Guid("ad8ff214-5498-413f-a52c-9941ab792a51"), 1647781930L, new Guid("6fff1278-42d4-4156-ba25-09613d2a09af"), null },
                    { new Guid("01782fef-2f66-4bc8-b647-4e772eb9bcde"), new Guid("8ae457fb-d6b5-4326-9269-7485c2066b65"), new Guid("ad8ff214-5498-413f-a52c-9941ab792a51"), 1647781930L, new Guid("44268b05-2ef3-431c-84d1-1a19ba42b983"), null },
                    { new Guid("e585b605-db43-4b95-a76c-70a03b6671ee"), new Guid("45a2fd61-ac20-4364-a661-1501a67fbd4c"), new Guid("878d8a55-6623-4dac-b0f6-bb2f30805bc5"), 1647781930L, new Guid("029687cd-540a-4e29-9928-70bdec6bf879"), null },
                    { new Guid("c48be524-d963-4969-bdfd-2d64d7a89c28"), new Guid("dcbac3e0-12ec-4c29-9850-f9d1c58c4c00"), new Guid("878d8a55-6623-4dac-b0f6-bb2f30805bc5"), 1647781930L, new Guid("7b2bed68-61b5-4257-a9bc-a224a85b0906"), null },
                    { new Guid("50d398bf-c5a3-4717-95ba-e77687bbfe45"), new Guid("54ab9302-9169-4841-8640-507d0795f9ed"), new Guid("69955edd-46b2-4dce-9956-f806aed6aca2"), 1647781930L, new Guid("7e430a2b-32bc-4e9b-b879-745ab1aef3a9"), null },
                    { new Guid("5eb316d7-a6d0-485b-8cd9-cca996f1ac6d"), new Guid("dcbac3e0-12ec-4c29-9850-f9d1c58c4c00"), new Guid("4c311789-cc2c-45f9-9dc4-2415ce6d200e"), 1647781930L, new Guid("68306c6b-2c57-495c-a51e-ac45f7e88ca5"), null },
                    { new Guid("0953479d-6739-491b-b2dd-fe36d39bf16a"), new Guid("45a2fd61-ac20-4364-a661-1501a67fbd4c"), new Guid("4c311789-cc2c-45f9-9dc4-2415ce6d200e"), 1647781930L, new Guid("46b3b7cf-e3b0-470b-b93e-35719a67d3da"), null },
                    { new Guid("af25f7ec-64d4-420e-ba62-ba52f1f954d4"), new Guid("54ab9302-9169-4841-8640-507d0795f9ed"), new Guid("48ded944-cc48-4c76-8a09-99b67455b739"), 1647781930L, new Guid("c9c42e84-25a8-413a-bfd8-b0fc618e15d5"), null },
                    { new Guid("9caf420a-e436-4867-ae75-0196a6aa9a09"), new Guid("e3375ee7-6cc6-4b66-955b-b4688d965fdb"), new Guid("89bfefe7-37cb-4e9d-99d1-80d383c491fb"), 1647781930L, new Guid("e8063d35-47ed-4f4f-b395-84668d31e1a6"), null },
                    { new Guid("dea7fc04-fee1-4223-9812-b470da7c13d8"), new Guid("3ba7f2cf-03a8-4040-831f-c63c37ccaedb"), new Guid("5b497979-393e-4989-b7b6-af7eb3373c9a"), 1647781930L, new Guid("15990e24-7a24-4428-9daa-dc7e94cf8746"), null }
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
