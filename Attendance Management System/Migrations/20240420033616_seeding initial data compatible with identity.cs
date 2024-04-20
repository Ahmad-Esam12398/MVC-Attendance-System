using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Attendance_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class seedinginitialdatacompatiblewithidentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Schedules",
                columns: new[] { "Id", "Date", "EndTime", "StartTime", "TrackId" },
                values: new object[,]
                {
                    { 1, new DateOnly(2024, 4, 20), new TimeOnly(22, 0, 0), new TimeOnly(9, 0, 0), 1 },
                    { 2, new DateOnly(2024, 4, 21), new TimeOnly(22, 0, 0), new TimeOnly(11, 0, 0), 2 }
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TrackIntakes",
                keyColumns: new[] { "IntakeId", "TrackId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "TrackIntakes",
                keyColumns: new[] { "IntakeId", "TrackId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "TrackIntakes",
                keyColumns: new[] { "IntakeId", "TrackId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "TrackIntakes",
                keyColumns: new[] { "IntakeId", "TrackId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "TrackIntakes",
                keyColumns: new[] { "IntakeId", "TrackId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "Intake",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
