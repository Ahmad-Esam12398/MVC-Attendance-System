using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Attendance_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class AddingAccountsForeachRoleandpermissionsseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
            //migrationBuilder.Sql("update Users set Gender = 'M' where Id > 5");
            //migrationBuilder.Sql("update UsersRoles set RoleId = 1 where UserId = 5;");
            //migrationBuilder.Sql("update UsersRoles set RoleId = 2 where UserId = 3;");
            //migrationBuilder.Sql("insert into UsersRoles(RoleId, UserId) values(3, 3);");
            //migrationBuilder.Sql("update UsersRoles set RoleId = 4 where UserId = 6;");
            //migrationBuilder.Sql("update UsersRoles set RoleId = 5 where UserId = 1;");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 20), 1 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 20, 5, 36, 14, 735, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 20), 2 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 20, 5, 36, 14, 735, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 20), 3 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 20, 5, 36, 14, 735, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 20), 4 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 20, 5, 36, 14, 735, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 20), 5 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 20, 5, 36, 14, 735, DateTimeKind.Local).AddTicks(9715));
            //migrationBuilder.Sql("update UsersRoles set RoleId = 6 where UserId = 5;");
            //migrationBuilder.Sql("update UsersRoles set RoleId = 6 where UserId = 3;");
            //migrationBuilder.Sql("delete from UsersRoles where UserId = 3 and RoleId = 3");
            //migrationBuilder.Sql("update UsersRoles set RoleId = 6 where UserId = 6;");
            //migrationBuilder.Sql("update UsersRoles set RoleId = 6 where UserId = 1;");
        }
    }
}
