using Attendance_Management_System.Models;

namespace Attendance_Management_System.Repos
{
    public interface IInstructorRepo
    {
        void AcceptPermission(int id);
        void RefusePermission(int id);
        List<Permission> getAllPermissions();
        public void RefusePermissionsNotToday();
        public  Task<List<Permission>> GetPendingPermissionsByTrackID(int trackID);
        List<Schedule> getSchedulesByTrackID(int TrackID);
        void AddSchedule(Schedule Schedule);
        void DeleteSchedule(int id);
        void UpdateSchedule(Schedule schedule);

        User GetCurrentUser();
        Task AddDummyInstructors();
        List<Student> getStudentsByTrackID(int trackID);
        void DeleteStudent(int id);
        public  Task AddStudent(Student student, int trackID);
        public Task EditStudent(Student student);

    }
}
