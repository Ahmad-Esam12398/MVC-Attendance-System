namespace Attendance_Management_System.Models
{
    public abstract class User
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public virtual Student Student { get; set; }
        public virtual Instructor Instructor { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Admin Admin { get; set; }
        public virtual Supervisor Supervisor { get; set; }
    }
}
