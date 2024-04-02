namespace Attendance_Management_System.Models
{
    public abstract class User
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public char Gender { get; set; }
    }
}
