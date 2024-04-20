using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Attendance_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class FixinitialPermission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 20), 1 });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 20), 2 });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 20), 3 });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 20), 4 });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 20), 5 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Date", "StudentId", "BodyOfDescription", "DateCreated", "ID", "Reason", "Status" },
                values: new object[,]
                {
                    { new DateOnly(2024, 4, 20), 1, "1", new DateTime(2024, 4, 20, 19, 19, 53, 894, DateTimeKind.Local).AddTicks(2184), 1, "1", 0 },
                    { new DateOnly(2024, 4, 20), 2, "2", new DateTime(2024, 4, 20, 19, 19, 53, 894, DateTimeKind.Local).AddTicks(2421), 2, "2", 0 },
                    { new DateOnly(2024, 4, 20), 3, "3", new DateTime(2024, 4, 20, 19, 19, 53, 894, DateTimeKind.Local).AddTicks(2427), 3, "3", 0 },
                    { new DateOnly(2024, 4, 20), 4, "4", new DateTime(2024, 4, 20, 19, 19, 53, 894, DateTimeKind.Local).AddTicks(2432), 4, "4", 0 },
                    { new DateOnly(2024, 4, 20), 5, "5", new DateTime(2024, 4, 20, 19, 19, 53, 894, DateTimeKind.Local).AddTicks(2437), 5, "5", 0 }
                });
        }
    }
}
