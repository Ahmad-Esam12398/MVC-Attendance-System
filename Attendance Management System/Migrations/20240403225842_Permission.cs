using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Attendance_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class Permission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_Student_StudentId",
                table: "Attendance");

            migrationBuilder.DropForeignKey(
                name: "FK_InstructorTrack_Instructor_InstructorsId",
                table: "InstructorTrack");

            migrationBuilder.DropForeignKey(
                name: "FK_Intake_ITIProgram_ProgramId",
                table: "Intake");

            migrationBuilder.DropForeignKey(
                name: "FK_Permission_Student_StudentId",
                table: "Permission");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Intake_IntakeID",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Tracks_TrackID",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_ITIProgram_ProgramId",
                table: "Tracks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Permission",
                table: "Permission");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ITIProgram",
                table: "ITIProgram");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Intake",
                table: "Intake");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attendance",
                table: "Attendance");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "Permission",
                newName: "Permissions");

            migrationBuilder.RenameTable(
                name: "ITIProgram",
                newName: "ItiPrograms");

            migrationBuilder.RenameTable(
                name: "Intake",
                newName: "Intakes");

            migrationBuilder.RenameTable(
                name: "Instructor",
                newName: "Instructors");

            migrationBuilder.RenameTable(
                name: "Attendance",
                newName: "Attendances");

            migrationBuilder.RenameIndex(
                name: "IX_Student_TrackID",
                table: "Students",
                newName: "IX_Students_TrackID");

            migrationBuilder.RenameIndex(
                name: "IX_Student_IntakeID",
                table: "Students",
                newName: "IX_Students_IntakeID");

            migrationBuilder.RenameIndex(
                name: "IX_Permission_StudentId",
                table: "Permissions",
                newName: "IX_Permissions_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Intake_ProgramId",
                table: "Intakes",
                newName: "IX_Intakes_ProgramId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendance_StudentId",
                table: "Attendances",
                newName: "IX_Attendances_StudentId");

            migrationBuilder.AddColumn<DateOnly>(
                name: "Date",
                table: "Permissions",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<int>(
                name: "trackId",
                table: "Permissions",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Permissions",
                table: "Permissions",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItiPrograms",
                table: "ItiPrograms",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Intakes",
                table: "Intakes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attendances",
                table: "Attendances",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<char>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttendanceDegrees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceDegrees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    JobTitle = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<char>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Students_StudentId",
                table: "Attendances",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InstructorTrack_Instructors_InstructorsId",
                table: "InstructorTrack",
                column: "InstructorsId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Intakes_ItiPrograms_ProgramId",
                table: "Intakes",
                column: "ProgramId",
                principalTable: "ItiPrograms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_Students_StudentId",
                table: "Permissions",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Intakes_IntakeID",
                table: "Students",
                column: "IntakeID",
                principalTable: "Intakes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Tracks_TrackID",
                table: "Students",
                column: "TrackID",
                principalTable: "Tracks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_ItiPrograms_ProgramId",
                table: "Tracks",
                column: "ProgramId",
                principalTable: "ItiPrograms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Students_StudentId",
                table: "Attendances");

            migrationBuilder.DropForeignKey(
                name: "FK_InstructorTrack_Instructors_InstructorsId",
                table: "InstructorTrack");

            migrationBuilder.DropForeignKey(
                name: "FK_Intakes_ItiPrograms_ProgramId",
                table: "Intakes");

            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_Students_StudentId",
                table: "Permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Intakes_IntakeID",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Tracks_TrackID",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_ItiPrograms_ProgramId",
                table: "Tracks");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "AttendanceDegrees");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Permissions",
                table: "Permissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItiPrograms",
                table: "ItiPrograms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Intakes",
                table: "Intakes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attendances",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "trackId",
                table: "Permissions");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "Permissions",
                newName: "Permission");

            migrationBuilder.RenameTable(
                name: "ItiPrograms",
                newName: "ITIProgram");

            migrationBuilder.RenameTable(
                name: "Intakes",
                newName: "Intake");

            migrationBuilder.RenameTable(
                name: "Instructors",
                newName: "Instructor");

            migrationBuilder.RenameTable(
                name: "Attendances",
                newName: "Attendance");

            migrationBuilder.RenameIndex(
                name: "IX_Students_TrackID",
                table: "Student",
                newName: "IX_Student_TrackID");

            migrationBuilder.RenameIndex(
                name: "IX_Students_IntakeID",
                table: "Student",
                newName: "IX_Student_IntakeID");

            migrationBuilder.RenameIndex(
                name: "IX_Permissions_StudentId",
                table: "Permission",
                newName: "IX_Permission_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Intakes_ProgramId",
                table: "Intake",
                newName: "IX_Intake_ProgramId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendances_StudentId",
                table: "Attendance",
                newName: "IX_Attendance_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Permission",
                table: "Permission",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ITIProgram",
                table: "ITIProgram",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Intake",
                table: "Intake",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attendance",
                table: "Attendance",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_Student_StudentId",
                table: "Attendance",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InstructorTrack_Instructor_InstructorsId",
                table: "InstructorTrack",
                column: "InstructorsId",
                principalTable: "Instructor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Intake_ITIProgram_ProgramId",
                table: "Intake",
                column: "ProgramId",
                principalTable: "ITIProgram",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Permission_Student_StudentId",
                table: "Permission",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Intake_IntakeID",
                table: "Student",
                column: "IntakeID",
                principalTable: "Intake",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Tracks_TrackID",
                table: "Student",
                column: "TrackID",
                principalTable: "Tracks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_ITIProgram_ProgramId",
                table: "Tracks",
                column: "ProgramId",
                principalTable: "ITIProgram",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
