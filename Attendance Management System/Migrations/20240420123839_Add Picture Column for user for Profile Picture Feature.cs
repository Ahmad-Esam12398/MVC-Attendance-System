using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Attendance_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class AddPictureColumnforuserforProfilePictureFeature : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Picture",
                table: "Users",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 20), 1 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 20, 14, 38, 33, 445, DateTimeKind.Local).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 20), 2 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 20, 14, 38, 33, 445, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 20), 3 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 20, 14, 38, 33, 445, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 20), 4 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 20, 14, 38, 33, 445, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 20), 5 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 20, 14, 38, 33, 445, DateTimeKind.Local).AddTicks(7349));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 20), 1 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 20, 6, 0, 17, 135, DateTimeKind.Local).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 20), 2 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 20, 6, 0, 17, 135, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 20), 3 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 20, 6, 0, 17, 135, DateTimeKind.Local).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 20), 4 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 20, 6, 0, 17, 135, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 20), 5 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 20, 6, 0, 17, 135, DateTimeKind.Local).AddTicks(4067));
        }
    }
}
