using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Attendance_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class makingcolumnforprofilepicture : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Supervisor_Instructors_Id",
                table: "Supervisor");

            migrationBuilder.DropForeignKey(
                name: "FK_Supervisor_Tracks_SupTrackId",
                table: "Supervisor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Supervisor",
                table: "Supervisor");

            migrationBuilder.RenameTable(
                name: "Supervisor",
                newName: "Supervisors");

            migrationBuilder.RenameIndex(
                name: "IX_Supervisor_SupTrackId",
                table: "Supervisors",
                newName: "IX_Supervisors_SupTrackId");

            migrationBuilder.AddColumn<byte[]>(
                name: "Picture",
                table: "Users",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AbsenceWithPermission",
                table: "AttendanceDegrees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Supervisors",
                table: "Supervisors",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 20), 1 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 20, 19, 19, 53, 894, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 20), 2 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 20, 19, 19, 53, 894, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 20), 3 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 20, 19, 19, 53, 894, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 20), 4 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 20, 19, 19, 53, 894, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumns: new[] { "Date", "StudentId" },
                keyValues: new object[] { new DateOnly(2024, 4, 20), 5 },
                column: "DateCreated",
                value: new DateTime(2024, 4, 20, 19, 19, 53, 894, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.AddForeignKey(
                name: "FK_Supervisors_Instructors_Id",
                table: "Supervisors",
                column: "Id",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Supervisors_Tracks_SupTrackId",
                table: "Supervisors",
                column: "SupTrackId",
                principalTable: "Tracks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Supervisors_Instructors_Id",
                table: "Supervisors");

            migrationBuilder.DropForeignKey(
                name: "FK_Supervisors_Tracks_SupTrackId",
                table: "Supervisors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Supervisors",
                table: "Supervisors");

            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AbsenceWithPermission",
                table: "AttendanceDegrees");

            migrationBuilder.RenameTable(
                name: "Supervisors",
                newName: "Supervisor");

            migrationBuilder.RenameIndex(
                name: "IX_Supervisors_SupTrackId",
                table: "Supervisor",
                newName: "IX_Supervisor_SupTrackId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Supervisor",
                table: "Supervisor",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Supervisor_Instructors_Id",
                table: "Supervisor",
                column: "Id",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Supervisor_Tracks_SupTrackId",
                table: "Supervisor",
                column: "SupTrackId",
                principalTable: "Tracks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
