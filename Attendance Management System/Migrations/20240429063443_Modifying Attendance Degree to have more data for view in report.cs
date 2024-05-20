using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Attendance_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class ModifyingAttendanceDegreetohavemoredataforviewinreport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AbsenceWithPermission",
                table: "AttendanceDegrees",
                newName: "twenty");

            migrationBuilder.AddColumn<int>(
                name: "Fifteen",
                table: "AttendanceDegrees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Five",
                table: "AttendanceDegrees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Let",
                table: "AttendanceDegrees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReducedDueToAbsenceWithPermission",
                table: "AttendanceDegrees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ten",
                table: "AttendanceDegrees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TwentFive",
                table: "AttendanceDegrees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WithPermission",
                table: "AttendanceDegrees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WithoutPermission",
                table: "AttendanceDegrees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateOnly(2024, 4, 29));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateOnly(2024, 4, 30));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fifteen",
                table: "AttendanceDegrees");

            migrationBuilder.DropColumn(
                name: "Five",
                table: "AttendanceDegrees");

            migrationBuilder.DropColumn(
                name: "Let",
                table: "AttendanceDegrees");

            migrationBuilder.DropColumn(
                name: "ReducedDueToAbsenceWithPermission",
                table: "AttendanceDegrees");

            migrationBuilder.DropColumn(
                name: "Ten",
                table: "AttendanceDegrees");

            migrationBuilder.DropColumn(
                name: "TwentFive",
                table: "AttendanceDegrees");

            migrationBuilder.DropColumn(
                name: "WithPermission",
                table: "AttendanceDegrees");

            migrationBuilder.DropColumn(
                name: "WithoutPermission",
                table: "AttendanceDegrees");

            migrationBuilder.RenameColumn(
                name: "twenty",
                table: "AttendanceDegrees",
                newName: "AbsenceWithPermission");

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateOnly(2024, 4, 20));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateOnly(2024, 4, 21));
        }
    }
}
