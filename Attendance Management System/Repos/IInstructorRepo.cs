using Attendance_Management_System.Models;

namespace Attendance_Management_System.Repos
{
    public interface IInstructorRepo
    {
        void AcceptPermission(int id);
        void RefusePermission(int id);
        List<Permission> getAllPermissions();
        public void RefusePermissionsNotToday();
        public List<Permission> getPendingPermissionsByTrackID(int TrackID);
        List<Schedule> getSchedulesByTrackID(int TrackID);
        void AddSchedule(Schedule Schedule);
        void DeleteSchedule(int id);
        void UpdateSchedule(Schedule schedule);


    }
}
