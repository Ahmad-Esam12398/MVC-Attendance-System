using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Attendance_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class correctingObjectsaccordingtoroles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Students where Id in (5, 3, 1);");
            migrationBuilder.Sql("insert into Instructors(Id) values (3);");
            migrationBuilder.Sql("insert into Supervisors(Id, SupTrackId) values(3, 1);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Instructors where Id = 3;");
            migrationBuilder.Sql("delete from Supervisors where Id = 3;");
        }
    }
}
