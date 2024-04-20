using Attendance_Management_System.Models;

namespace Attendance_Management_System.Repos
{
    public interface IInstructorRepo
    {
        void AcceptPermission(int id);
        void RefusePermission(int id);
        List<Permission> getAllPermissions();
        void RefusePermissionsNotToday();
        Task<List<Permission>> GetPendingPermissionsByTrackID(int trackID);
        List<Schedule> getSchedulesByTrackID(int TrackID);
        void AddSchedule(Schedule Schedule,int trackId);
        void DeleteSchedule(int id);
        void UpdateSchedule(Schedule schedule);
        void AddScheduleEvent(ScheduleEvent Schedule);
        void DeleteScheduleEvent(int id);
        void UpdateScheduleEvent(ScheduleEvent schedule);
        User GetCurrentUser();
        Task AddDummyInstructors();
        List<Student> getStudentsByTrackID(int trackID);
        void DeleteStudent(int id);
        Task AddStudent(Student student, int trackID);
        Task EditStudent(Student student);
        List<ScheduleEvent> getSchedulesEventsByScheduleId(int id);
    }
}
