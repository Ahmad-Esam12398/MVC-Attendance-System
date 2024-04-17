using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Attendance_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Intake",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<byte>(type: "tinyint", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intake", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Programs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ProgramId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tracks_Programs_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "Programs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    SupTrackId = table.Column<int>(type: "int", nullable: true),
                    University = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Faculty = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Specialization = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    GraduationYear = table.Column<int>(type: "int", nullable: true),
                    TrackID = table.Column<int>(type: "int", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Tracks_SupTrackId",
                        column: x => x.SupTrackId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Tracks_TrackID",
                        column: x => x.TrackID,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    StartTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    EndTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    TrackId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_Tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrackIntakes",
                columns: table => new
                {
                    IntakeId = table.Column<int>(type: "int", nullable: false),
                    TrackId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackIntakes", x => new { x.TrackId, x.IntakeId });
                    table.ForeignKey(
                        name: "FK_TrackIntakes_Intake_IntakeId",
                        column: x => x.IntakeId,
                        principalTable: "Intake",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrackIntakes_Tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AttendanceDegrees",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    UntilDate = table.Column<DateOnly>(type: "date", nullable: false),
                    AbscenceDays = table.Column<int>(type: "int", nullable: false),
                    AttendanceDegrees = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceDegrees", x => new { x.StudentId, x.UntilDate });
                    table.ForeignKey(
                        name: "FK_AttendanceDegrees_AspNetUsers_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Time_in = table.Column<TimeOnly>(type: "time", nullable: true),
                    Time_out = table.Column<TimeOnly>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendances_AspNetUsers_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BodyOfDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => new { x.StudentId, x.Date });
                    table.ForeignKey(
                        name: "FK_Permissions_AspNetUsers_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleEvents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ScheduleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduleEvents_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Intake",
                columns: new[] { "Id", "EndDate", "Number", "StartDate" },
                values: new object[] { 1, new DateOnly(2024, 9, 1), (byte)44, new DateOnly(2023, 9, 1) });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "Id", "Description", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, "Professional Training Program", true, "PTP" },
                    { 2, "Intensive Training Program", true, "ITP" },
                    { 3, "Leadership Development Program", true, "LDP" },
                    { 4, "Summer Training", true, "ST" }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "IsActive", "Name", "ProgramId" },
                values: new object[,]
                {
                    { 1, true, "PD", 1 },
                    { 2, true, "OS", 1 },
                    { 3, true, "AI", 2 },
                    { 4, true, "MERN", 2 },
                    { 5, true, "MEAN", 2 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Faculty", "Gender", "GraduationYear", "LockoutEnabled", "LockoutEnd", "NationalId", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Specialization", "TrackID", "TwoFactorEnabled", "University", "UserName", "UserType" },
                values: new object[,]
                {
                    { -99, 0, "110a76d7-94ad-4837-b6bb-7327c4af0d5a", "Student99@example.com", false, "Accounting", "F", 0, false, null, "50068550263440", null, null, "12345678", null, "01015328933", null, false, null, null, 1, false, "Tanta", "Student99", "Student" },
                    { -98, 0, "d7547560-07fb-430a-b95d-884252d8c9ff", "Student98@example.com", false, "IS", "F", 0, false, null, "27237780042578", null, null, "12345678", null, "01015328933", null, false, null, null, 1, false, "Mansoura", "Student98", "Student" },
                    { -97, 0, "34a5c1fa-42f4-4e4d-b84f-8ad1a48f35d4", "Student97@example.com", false, "CS", "F", 0, false, null, "38044140244762", null, null, "12345678", null, "01015328933", null, false, null, null, 5, false, "Mansoura", "Student97", "Student" },
                    { -96, 0, "57cbfb65-c1cc-4cbc-979d-8b1aa8437cc7", "Student96@example.com", false, "Accounting", "M", 0, false, null, "41051554563425", null, null, "12345678", null, "01015328933", null, false, null, null, 3, false, "Cairo", "Student96", "Student" },
                    { -95, 0, "9051374e-1966-4791-b29a-b7bd524b478f", "Student95@example.com", false, "Accounting", "F", 0, false, null, "73581618011036", null, null, "12345678", null, "01015328933", null, false, null, null, 2, false, "Tanta", "Student95", "Student" },
                    { -94, 0, "276ae676-5164-44f7-aa82-03a41529dbc5", "Student94@example.com", false, "Engineering", "F", 0, false, null, "37267184045852", null, null, "12345678", null, "01015328933", null, false, null, null, 4, false, "Zagazig", "Student94", "Student" },
                    { -93, 0, "a5292c9e-6286-4aa3-bd01-878a22fa0d84", "Student93@example.com", false, "CS", "M", 0, false, null, "15855610187674", null, null, "12345678", null, "01015328933", null, false, null, null, 3, false, "Tanta", "Student93", "Student" },
                    { -92, 0, "bdc42f67-aedf-47b1-b842-46a131d4a3a4", "Student92@example.com", false, "CS", "F", 0, false, null, "76264338526145", null, null, "12345678", null, "01015328933", null, false, null, null, 5, false, "Zagazig", "Student92", "Student" },
                    { -91, 0, "37c341d7-d9c5-4ceb-8517-ac307e97488d", "Student91@example.com", false, "CS", "F", 0, false, null, "10865705810863", null, null, "12345678", null, "01015328933", null, false, null, null, 5, false, "AinShams", "Student91", "Student" },
                    { -90, 0, "5805a6f0-8746-429f-9ce8-bbeb01631ea9", "Student90@example.com", false, "CS", "F", 0, false, null, "47617434115722", null, null, "12345678", null, "01015328933", null, false, null, null, 1, false, "Cairo", "Student90", "Student" },
                    { -89, 0, "74dbcc49-90b2-40ea-8338-1ad79e020b83", "Student89@example.com", false, "IS", "F", 0, false, null, "82707007212264", null, null, "12345678", null, "01015328933", null, false, null, null, 2, false, "Zagazig", "Student89", "Student" },
                    { -88, 0, "9edc48d3-2fdf-4988-a7cd-78b92d7c5de0", "Student88@example.com", false, "Accounting", "F", 0, false, null, "80545378528232", null, null, "12345678", null, "01015328933", null, false, null, null, 2, false, "AinShams", "Student88", "Student" },
                    { -87, 0, "11eea0b2-c286-453c-afac-d737d8abb8dd", "Student87@example.com", false, "Engineering", "F", 0, false, null, "72761126747010", null, null, "12345678", null, "01015328933", null, false, null, null, 2, false, "Cairo", "Student87", "Student" },
                    { -86, 0, "d31aafc3-cf18-403d-bb02-f77e6f912ef9", "Student86@example.com", false, "CS", "F", 0, false, null, "81465655088388", null, null, "12345678", null, "01015328933", null, false, null, null, 3, false, "Cairo", "Student86", "Student" },
                    { -85, 0, "e6bd372e-6365-4fb2-a009-eeafdfceecfa", "Student85@example.com", false, "IS", "F", 0, false, null, "42634347542543", null, null, "12345678", null, "01015328933", null, false, null, null, 1, false, "Zagazig", "Student85", "Student" },
                    { -84, 0, "ef7ac279-48f3-49d0-97e5-b0c8e917bff8", "Student84@example.com", false, "Engineering", "M", 0, false, null, "73453610135632", null, null, "12345678", null, "01015328933", null, false, null, null, 4, false, "Tanta", "Student84", "Student" },
                    { -83, 0, "75e6ca67-49c1-4b78-a306-0845365bd7c4", "Student83@example.com", false, "CS", "M", 0, false, null, "85274762788282", null, null, "12345678", null, "01015328933", null, false, null, null, 5, false, "Mansoura", "Student83", "Student" },
                    { -82, 0, "6cdbdeb4-2796-40bd-b98d-435728affe97", "Student82@example.com", false, "CS", "F", 0, false, null, "87705361587745", null, null, "12345678", null, "01015328933", null, false, null, null, 1, false, "AinShams", "Student82", "Student" },
                    { -81, 0, "39456615-d4fa-4ddd-a2d2-e9b770bb6def", "Student81@example.com", false, "Accounting", "F", 0, false, null, "44617665285235", null, null, "12345678", null, "01015328933", null, false, null, null, 3, false, "Zagazig", "Student81", "Student" },
                    { -80, 0, "945d9d3a-0122-479c-abd8-864e1c6dbe86", "Student80@example.com", false, "Accounting", "F", 0, false, null, "31087706465446", null, null, "12345678", null, "01015328933", null, false, null, null, 4, false, "Zagazig", "Student80", "Student" },
                    { -79, 0, "9bb729b2-a206-4dc7-acea-0015d8beaa56", "Student79@example.com", false, "CS", "F", 0, false, null, "20428307024158", null, null, "12345678", null, "01015328933", null, false, null, null, 5, false, "Mansoura", "Student79", "Student" },
                    { -78, 0, "86dd6de3-0dfe-4b4b-b024-19777d6d6a01", "Student78@example.com", false, "Accounting", "M", 0, false, null, "78554016845345", null, null, "12345678", null, "01015328933", null, false, null, null, 3, false, "Mansoura", "Student78", "Student" },
                    { -77, 0, "04f6715d-28e7-4637-bab8-742d2a43d4cd", "Student77@example.com", false, "CS", "F", 0, false, null, "10325027285624", null, null, "12345678", null, "01015328933", null, false, null, null, 3, false, "Zagazig", "Student77", "Student" },
                    { -76, 0, "e2ced79d-ad10-434e-b730-1a05ad15422c", "Student76@example.com", false, "CS", "M", 0, false, null, "45534877723463", null, null, "12345678", null, "01015328933", null, false, null, null, 4, false, "Mansoura", "Student76", "Student" },
                    { -75, 0, "fae94e96-0938-4a5c-ab37-873be345b559", "Student75@example.com", false, "Accounting", "M", 0, false, null, "48320311750734", null, null, "12345678", null, "01015328933", null, false, null, null, 5, false, "Cairo", "Student75", "Student" },
                    { -74, 0, "db43fe5a-06be-4a90-9532-44db8a50a1d8", "Student74@example.com", false, "IS", "M", 0, false, null, "34023730230345", null, null, "12345678", null, "01015328933", null, false, null, null, 4, false, "Tanta", "Student74", "Student" },
                    { -73, 0, "b557a129-ea5c-464c-b129-54c0ba90737a", "Student73@example.com", false, "CS", "M", 0, false, null, "55038527516385", null, null, "12345678", null, "01015328933", null, false, null, null, 3, false, "Mansoura", "Student73", "Student" },
                    { -72, 0, "89fa3af2-b218-45b0-b109-f2065945671a", "Student72@example.com", false, "Engineering", "F", 0, false, null, "73451630738286", null, null, "12345678", null, "01015328933", null, false, null, null, 1, false, "AinShams", "Student72", "Student" },
                    { -71, 0, "e843b299-bbca-4246-ae63-e5cbf99f401a", "Student71@example.com", false, "Accounting", "F", 0, false, null, "64063758075573", null, null, "12345678", null, "01015328933", null, false, null, null, 2, false, "Zagazig", "Student71", "Student" },
                    { -70, 0, "4949830e-9eb7-4bf2-9446-bb4725a264b9", "Student70@example.com", false, "CS", "M", 0, false, null, "47548111676683", null, null, "12345678", null, "01015328933", null, false, null, null, 5, false, "Tanta", "Student70", "Student" },
                    { -69, 0, "0d4d0ea2-13b9-48a0-aeed-5df00f35057e", "Student69@example.com", false, "Accounting", "F", 0, false, null, "75301581167010", null, null, "12345678", null, "01015328933", null, false, null, null, 5, false, "AinShams", "Student69", "Student" },
                    { -68, 0, "a85a160b-f6ad-451b-9e02-dd8a8e6f2eab", "Student68@example.com", false, "IS", "F", 0, false, null, "28022427481273", null, null, "12345678", null, "01015328933", null, false, null, null, 3, false, "Cairo", "Student68", "Student" },
                    { -67, 0, "d3ef4a3b-7e1c-4277-8bf6-acb57852a943", "Student67@example.com", false, "IS", "M", 0, false, null, "60504185162175", null, null, "12345678", null, "01015328933", null, false, null, null, 5, false, "AinShams", "Student67", "Student" },
                    { -66, 0, "310dacfd-cb2f-42e2-923a-7fc704821a05", "Student66@example.com", false, "IS", "F", 0, false, null, "16623845864830", null, null, "12345678", null, "01015328933", null, false, null, null, 2, false, "Cairo", "Student66", "Student" },
                    { -65, 0, "128985bf-2967-4fba-967e-f1e20c56ffa5", "Student65@example.com", false, "Accounting", "F", 0, false, null, "45616316460851", null, null, "12345678", null, "01015328933", null, false, null, null, 2, false, "Mansoura", "Student65", "Student" },
                    { -64, 0, "9a410e5e-e7a6-4bd9-8f30-894f25aa4e82", "Student64@example.com", false, "Accounting", "F", 0, false, null, "76351057685135", null, null, "12345678", null, "01015328933", null, false, null, null, 5, false, "Zagazig", "Student64", "Student" },
                    { -63, 0, "3d3757e6-e8f4-476d-8c88-359925d3da24", "Student63@example.com", false, "Engineering", "M", 0, false, null, "30716660503613", null, null, "12345678", null, "01015328933", null, false, null, null, 2, false, "Mansoura", "Student63", "Student" },
                    { -62, 0, "44eb0ab0-d1ee-408e-ac33-f13f46029774", "Student62@example.com", false, "CS", "F", 0, false, null, "44733585688141", null, null, "12345678", null, "01015328933", null, false, null, null, 5, false, "Cairo", "Student62", "Student" },
                    { -61, 0, "6d317253-abf9-43cd-9a89-c26ab16a661a", "Student61@example.com", false, "CS", "M", 0, false, null, "82243628673562", null, null, "12345678", null, "01015328933", null, false, null, null, 2, false, "Tanta", "Student61", "Student" },
                    { -60, 0, "934f8699-6c41-46cc-b9d6-a91100778e89", "Student60@example.com", false, "IS", "F", 0, false, null, "68765423451100", null, null, "12345678", null, "01015328933", null, false, null, null, 4, false, "Mansoura", "Student60", "Student" },
                    { -59, 0, "66672a4b-a6e5-41dc-9927-e487f4acadf3", "Student59@example.com", false, "Accounting", "M", 0, false, null, "14201516600415", null, null, "12345678", null, "01015328933", null, false, null, null, 4, false, "Tanta", "Student59", "Student" },
                    { -58, 0, "9d884995-ae4d-45f0-b8fa-f2f02d919e18", "Student58@example.com", false, "Accounting", "F", 0, false, null, "46428640176805", null, null, "12345678", null, "01015328933", null, false, null, null, 1, false, "Mansoura", "Student58", "Student" },
                    { -57, 0, "9619aa92-458c-4a60-9486-3ce79b77a805", "Student57@example.com", false, "IS", "F", 0, false, null, "36453740650614", null, null, "12345678", null, "01015328933", null, false, null, null, 4, false, "Cairo", "Student57", "Student" },
                    { -56, 0, "52d4d0d8-c996-4a56-8ec0-dc591657ae44", "Student56@example.com", false, "Accounting", "F", 0, false, null, "30454142752513", null, null, "12345678", null, "01015328933", null, false, null, null, 1, false, "Zagazig", "Student56", "Student" },
                    { -55, 0, "38c4a038-a125-4938-ba7b-b1c188266035", "Student55@example.com", false, "Engineering", "F", 0, false, null, "47054253486726", null, null, "12345678", null, "01015328933", null, false, null, null, 5, false, "AinShams", "Student55", "Student" },
                    { -54, 0, "21c9d4a1-dafc-4140-af7b-10156c015cbb", "Student54@example.com", false, "IS", "M", 0, false, null, "41888516237178", null, null, "12345678", null, "01015328933", null, false, null, null, 1, false, "Mansoura", "Student54", "Student" },
                    { -53, 0, "41a42ec4-414e-461f-8be8-8c3d23d30b7a", "Student53@example.com", false, "IS", "F", 0, false, null, "50373453665374", null, null, "12345678", null, "01015328933", null, false, null, null, 5, false, "Zagazig", "Student53", "Student" },
                    { -52, 0, "e0bc482b-0ca8-4a2a-bcba-670e85b56133", "Student52@example.com", false, "IS", "F", 0, false, null, "72410484042673", null, null, "12345678", null, "01015328933", null, false, null, null, 1, false, "Zagazig", "Student52", "Student" },
                    { -51, 0, "4da93b10-dc9e-4b7f-b55e-4b25ecc18cb6", "Student51@example.com", false, "CS", "F", 0, false, null, "42072255468885", null, null, "12345678", null, "01015328933", null, false, null, null, 2, false, "Mansoura", "Student51", "Student" },
                    { -50, 0, "0df628b6-071a-4f35-b024-b726e6906b8e", "Student50@example.com", false, "CS", "M", 0, false, null, "23744045725573", null, null, "12345678", null, "01015328933", null, false, null, null, 4, false, "Mansoura", "Student50", "Student" },
                    { -49, 0, "b948e93e-2f8a-470d-9638-7d9d06de4187", "Student49@example.com", false, "Accounting", "F", 0, false, null, "21178508872305", null, null, "12345678", null, "01015328933", null, false, null, null, 3, false, "Cairo", "Student49", "Student" },
                    { -48, 0, "873cdf87-f17c-49b4-a22c-31b6d74f740c", "Student48@example.com", false, "Accounting", "F", 0, false, null, "83781531448875", null, null, "12345678", null, "01015328933", null, false, null, null, 1, false, "Mansoura", "Student48", "Student" },
                    { -47, 0, "89fc34a8-e72b-4937-9be9-a5164078207f", "Student47@example.com", false, "Accounting", "M", 0, false, null, "63880647112776", null, null, "12345678", null, "01015328933", null, false, null, null, 1, false, "Zagazig", "Student47", "Student" },
                    { -46, 0, "be5b647a-a0b1-4b2f-b7a5-34dcfa377ae9", "Student46@example.com", false, "Accounting", "F", 0, false, null, "72783707360586", null, null, "12345678", null, "01015328933", null, false, null, null, 5, false, "AinShams", "Student46", "Student" },
                    { -45, 0, "e83009f8-5ee0-4da8-b60c-51070715fb13", "Student45@example.com", false, "CS", "M", 0, false, null, "55880657353468", null, null, "12345678", null, "01015328933", null, false, null, null, 1, false, "Cairo", "Student45", "Student" },
                    { -44, 0, "45218ed7-b414-4cf3-a3cf-ffbb84ec4a34", "Student44@example.com", false, "IS", "F", 0, false, null, "48413402720642", null, null, "12345678", null, "01015328933", null, false, null, null, 5, false, "AinShams", "Student44", "Student" },
                    { -43, 0, "03dc226d-10d1-4500-9620-e52f451fdb3b", "Student43@example.com", false, "CS", "M", 0, false, null, "76216121832152", null, null, "12345678", null, "01015328933", null, false, null, null, 1, false, "Mansoura", "Student43", "Student" },
                    { -42, 0, "520e3f2d-b858-4fe2-9604-26edd8f71513", "Student42@example.com", false, "Accounting", "F", 0, false, null, "86447431124571", null, null, "12345678", null, "01015328933", null, false, null, null, 3, false, "Zagazig", "Student42", "Student" },
                    { -41, 0, "83ac8b6a-eee4-4db4-b5b5-c4eb0dee7fb6", "Student41@example.com", false, "CS", "M", 0, false, null, "72606021400256", null, null, "12345678", null, "01015328933", null, false, null, null, 2, false, "Mansoura", "Student41", "Student" },
                    { -40, 0, "3887c4fe-c26c-4203-a703-fcd9966920e3", "Student40@example.com", false, "Engineering", "M", 0, false, null, "74584733522503", null, null, "12345678", null, "01015328933", null, false, null, null, 3, false, "Mansoura", "Student40", "Student" },
                    { -39, 0, "f78fff17-3583-45e5-8012-91788dceba1a", "Student39@example.com", false, "Engineering", "M", 0, false, null, "63685476406342", null, null, "12345678", null, "01015328933", null, false, null, null, 1, false, "Tanta", "Student39", "Student" },
                    { -38, 0, "fcbc05d1-8ea9-4af6-a7dc-ed28a64b19dd", "Student38@example.com", false, "CS", "F", 0, false, null, "17743222438407", null, null, "12345678", null, "01015328933", null, false, null, null, 3, false, "Zagazig", "Student38", "Student" },
                    { -37, 0, "4b14781c-9a39-4a00-9a96-a5c90994ea4e", "Student37@example.com", false, "Accounting", "F", 0, false, null, "67775125873605", null, null, "12345678", null, "01015328933", null, false, null, null, 4, false, "AinShams", "Student37", "Student" },
                    { -36, 0, "02ed4b35-f02b-4f6f-a0f9-8fdc87d270b0", "Student36@example.com", false, "IS", "M", 0, false, null, "67210040144287", null, null, "12345678", null, "01015328933", null, false, null, null, 2, false, "AinShams", "Student36", "Student" },
                    { -35, 0, "09a1a3ba-25de-44bb-89a0-f2a9ba61a95a", "Student35@example.com", false, "Accounting", "F", 0, false, null, "17472362562632", null, null, "12345678", null, "01015328933", null, false, null, null, 5, false, "Mansoura", "Student35", "Student" },
                    { -34, 0, "ce40020d-2c0e-4ff2-a270-3fc0e168f4dd", "Student34@example.com", false, "IS", "M", 0, false, null, "46534215762354", null, null, "12345678", null, "01015328933", null, false, null, null, 2, false, "AinShams", "Student34", "Student" },
                    { -33, 0, "4c51b1e6-3f7b-47b4-b7b1-bdcdd71c0d35", "Student33@example.com", false, "CS", "F", 0, false, null, "46005414746115", null, null, "12345678", null, "01015328933", null, false, null, null, 1, false, "Mansoura", "Student33", "Student" },
                    { -32, 0, "f2b6a454-5b29-4405-be11-1ebfa38e4d98", "Student32@example.com", false, "Engineering", "M", 0, false, null, "11351058640303", null, null, "12345678", null, "01015328933", null, false, null, null, 3, false, "Cairo", "Student32", "Student" },
                    { -31, 0, "3615fef1-0753-4613-93cc-6718d3580fc3", "Student31@example.com", false, "IS", "F", 0, false, null, "88540867572132", null, null, "12345678", null, "01015328933", null, false, null, null, 3, false, "Mansoura", "Student31", "Student" },
                    { -30, 0, "e006c3bc-1c0a-4325-8bf4-736ef31e6ac6", "Student30@example.com", false, "CS", "F", 0, false, null, "46004682057674", null, null, "12345678", null, "01015328933", null, false, null, null, 1, false, "Zagazig", "Student30", "Student" },
                    { -29, 0, "17d17868-5033-4d91-aabd-f436ee6536d6", "Student29@example.com", false, "Engineering", "M", 0, false, null, "17732166622482", null, null, "12345678", null, "01015328933", null, false, null, null, 1, false, "Tanta", "Student29", "Student" },
                    { -28, 0, "a6a874c2-bbb2-4965-9b54-44a8e4800486", "Student28@example.com", false, "CS", "M", 0, false, null, "80680474834688", null, null, "12345678", null, "01015328933", null, false, null, null, 2, false, "Cairo", "Student28", "Student" },
                    { -27, 0, "37730b13-e8e0-4a78-87da-093f182e285f", "Student27@example.com", false, "IS", "M", 0, false, null, "11322446317308", null, null, "12345678", null, "01015328933", null, false, null, null, 2, false, "Cairo", "Student27", "Student" },
                    { -26, 0, "cc4dbe11-6529-4d00-89f0-2cf973f7a8b0", "Student26@example.com", false, "Engineering", "M", 0, false, null, "65258367772484", null, null, "12345678", null, "01015328933", null, false, null, null, 4, false, "Cairo", "Student26", "Student" },
                    { -25, 0, "5f021ff3-6183-49b8-8d01-3522c5edeea7", "Student25@example.com", false, "IS", "F", 0, false, null, "21504851245201", null, null, "12345678", null, "01015328933", null, false, null, null, 3, false, "Tanta", "Student25", "Student" },
                    { -24, 0, "4bcdf4e0-b54c-453d-83b1-17ee712cdf42", "Student24@example.com", false, "IS", "M", 0, false, null, "85804573742362", null, null, "12345678", null, "01015328933", null, false, null, null, 3, false, "AinShams", "Student24", "Student" },
                    { -23, 0, "e044b5c4-9c97-44db-bffb-65f9ad6ecdd4", "Student23@example.com", false, "Accounting", "F", 0, false, null, "11677327755101", null, null, "12345678", null, "01015328933", null, false, null, null, 1, false, "Zagazig", "Student23", "Student" },
                    { -22, 0, "5e3bdf5c-7132-456a-aa85-a25fc6b3f809", "Student22@example.com", false, "Engineering", "M", 0, false, null, "40171326572242", null, null, "12345678", null, "01015328933", null, false, null, null, 1, false, "Mansoura", "Student22", "Student" },
                    { -21, 0, "ee775de4-1e84-4425-9a25-adef324e9cfc", "Student21@example.com", false, "Accounting", "F", 0, false, null, "57410022075708", null, null, "12345678", null, "01015328933", null, false, null, null, 1, false, "Mansoura", "Student21", "Student" },
                    { -20, 0, "4e27eac3-367e-428f-af83-e2a3582a52cd", "Student20@example.com", false, "CS", "M", 0, false, null, "17047300757634", null, null, "12345678", null, "01015328933", null, false, null, null, 3, false, "Mansoura", "Student20", "Student" },
                    { -19, 0, "f5f9e1d3-530f-4801-9bbc-4d083b6beba1", "Student19@example.com", false, "CS", "M", 0, false, null, "48546016711153", null, null, "12345678", null, "01015328933", null, false, null, null, 4, false, "AinShams", "Student19", "Student" },
                    { -18, 0, "ba3033bb-8a6a-4aab-9950-6d8e3cd9749f", "Student18@example.com", false, "Accounting", "M", 0, false, null, "66855801502138", null, null, "12345678", null, "01015328933", null, false, null, null, 1, false, "Mansoura", "Student18", "Student" },
                    { -17, 0, "6367af3b-4da6-4afa-a143-22dc925d6ec2", "Student17@example.com", false, "IS", "F", 0, false, null, "15442217872600", null, null, "12345678", null, "01015328933", null, false, null, null, 5, false, "Zagazig", "Student17", "Student" },
                    { -16, 0, "f193e72c-1fef-454e-93c2-44b80da43dc3", "Student16@example.com", false, "IS", "M", 0, false, null, "62641558874076", null, null, "12345678", null, "01015328933", null, false, null, null, 3, false, "AinShams", "Student16", "Student" },
                    { -15, 0, "3d3d0af9-4339-46fa-8620-4efd42e4f0a6", "Student15@example.com", false, "CS", "F", 0, false, null, "55226441081742", null, null, "12345678", null, "01015328933", null, false, null, null, 3, false, "AinShams", "Student15", "Student" },
                    { -14, 0, "2cf629f3-f3ef-4ea7-a2ce-cac82a54d137", "Student14@example.com", false, "Accounting", "F", 0, false, null, "78303426781615", null, null, "12345678", null, "01015328933", null, false, null, null, 5, false, "Cairo", "Student14", "Student" },
                    { -13, 0, "01b48cae-923b-444b-8dbb-8fd189f0d699", "Student13@example.com", false, "Engineering", "F", 0, false, null, "20457484611674", null, null, "12345678", null, "01015328933", null, false, null, null, 5, false, "Zagazig", "Student13", "Student" },
                    { -12, 0, "961e0ac5-28cb-46fc-9d0d-094292526df1", "Student12@example.com", false, "Engineering", "F", 0, false, null, "33536027428315", null, null, "12345678", null, "01015328933", null, false, null, null, 1, false, "Cairo", "Student12", "Student" },
                    { -11, 0, "dd5af255-42c8-47ab-b403-9451c131dd34", "Student11@example.com", false, "Engineering", "F", 0, false, null, "15480364335762", null, null, "12345678", null, "01015328933", null, false, null, null, 5, false, "Cairo", "Student11", "Student" },
                    { -10, 0, "4b0aef9d-d57b-4131-a0f8-6aceb42715b5", "Student10@example.com", false, "IS", "M", 0, false, null, "30875051756223", null, null, "12345678", null, "01015328933", null, false, null, null, 1, false, "Tanta", "Student10", "Student" },
                    { -9, 0, "b1ce0515-8675-4806-931c-32d28bbe80fd", "Student9@example.com", false, "CS", "F", 0, false, null, "32377826321151", null, null, "12345678", null, "01015328933", null, false, null, null, 4, false, "Cairo", "Student9", "Student" },
                    { -8, 0, "fcf2b33a-f3b8-415c-8aa6-740d11619dd4", "Student8@example.com", false, "IS", "M", 0, false, null, "27167036567854", null, null, "12345678", null, "01015328933", null, false, null, null, 5, false, "AinShams", "Student8", "Student" },
                    { -7, 0, "70b0bee9-e61e-4472-8683-7c0a9194f3c7", "Student7@example.com", false, "Accounting", "M", 0, false, null, "12755678773788", null, null, "12345678", null, "01015328933", null, false, null, null, 2, false, "Cairo", "Student7", "Student" },
                    { -6, 0, "2459830f-6bd8-4746-8c74-1a77dd100d7d", "Student6@example.com", false, "CS", "M", 0, false, null, "13140316248888", null, null, "12345678", null, "01015328933", null, false, null, null, 1, false, "AinShams", "Student6", "Student" },
                    { -5, 0, "25fcfb6d-90fe-407e-9063-8cfa244ec334", "Nada@yahoo.com", false, "CS", "F", 0, false, null, "53665485772015", null, null, "12345678", null, "01015328933", null, false, null, null, 3, false, "Tanta", "Nada", "Student" },
                    { -4, 0, "b88cb9b6-00e3-4487-b23f-b688bcae56a2", "Raheek@gmail.com", false, "Engineering", "F", 0, false, null, "42557896652148", null, null, "12345678", null, "01015328933", null, false, null, null, 2, false, "AinShams", "Raheek", "Student" },
                    { -3, 0, "c343c942-287b-4aed-899f-cbf0545054a2", "AhmadL3swy@example.com", false, "Engineering", "M", 0, false, null, "32006485523654", null, null, "12345678", null, "01215328933", null, false, null, null, 2, false, "Cairo", "AhmedAbdallah", "Student" },
                    { -2, 0, "2d12dee1-f6ac-4bd2-bb90-34ee4e69f935", "ali@example.com", false, "CS", "M", 0, false, null, "29803151800654", null, null, "12345678", null, "01115328933", null, false, null, null, 1, false, "Mansoura", "AliEmad", "Student" },
                    { -1, 0, "ee96fa08-ad01-4e4a-a17f-db39ca8ac264", "Ahmad.esam1231998@gmail.com", false, "Engineering", "M", 0, false, null, "29803121600573", null, null, "12345678", null, "01015328933", null, false, null, null, 1, false, "Mansoura", "AhmadEsam", "Student" }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Date", "EndTime", "StartTime", "TrackId" },
                values: new object[,]
                {
                    { 1, new DateOnly(2024, 4, 16), new TimeOnly(22, 0, 0), new TimeOnly(9, 0, 0), 1 },
                    { 2, new DateOnly(2024, 4, 17), new TimeOnly(22, 0, 0), new TimeOnly(11, 0, 0), 2 }
                });

            migrationBuilder.InsertData(
                table: "TrackIntakes",
                columns: new[] { "IntakeId", "TrackId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_NationalId",
                table: "AspNetUsers",
                column: "NationalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SupTrackId",
                table: "AspNetUsers",
                column: "SupTrackId",
                unique: true,
                filter: "[SupTrackId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TrackID",
                table: "AspNetUsers",
                column: "TrackID");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_StudentId",
                table: "Attendances",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleEvents_ScheduleId",
                table: "ScheduleEvents",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_TrackId",
                table: "Schedules",
                column: "TrackId");

            migrationBuilder.CreateIndex(
                name: "IX_TrackIntakes_IntakeId",
                table: "TrackIntakes",
                column: "IntakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_ProgramId",
                table: "Tracks",
                column: "ProgramId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AttendanceDegrees");

            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "ScheduleEvents");

            migrationBuilder.DropTable(
                name: "TrackIntakes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Intake");

            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "Programs");
        }
    }
}
