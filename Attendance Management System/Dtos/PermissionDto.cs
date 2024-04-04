using Attendance_Management_System.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Attendance_Management_System.Dtos
{
   
    public class PermissionDto
    {
        public int Id { get; set; }

        public string studentId { get; set; }

        public string Date { get; set; }

        public string StudentName { get; set; }

        public string? Message { get; set; }
        public string? Status { get; set; }
        public PermissionDto()
        {

        }
        public PermissionDto(Permission permission )
        {
            Id = permission.ID;
            studentId = permission.StudentId;
            Date = ConvertDate(permission.Date);
            StudentName = permission.Student.UserName;
            Message = permission.BodyOfDescription;
            Status = permission.Status.ToString();
        }
        public string ConvertDate(DateOnly date)
        {
            return date.ToString("yyyy-MM-dd");
        
        }

    }
}
