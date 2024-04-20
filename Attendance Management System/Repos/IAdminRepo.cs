using Attendance_Management_System.Models;

namespace Attendance_Management_System.Repos
{
    public interface IAdminRepo
    {
        #region program
        Task<List<ITIProgram>> GetAllPrograms();
        Task<ITIProgram> GetProgramById(int id);
        Task AddProgram(ITIProgram program);
        Task UpdateProgram(ITIProgram program);
        Task DeleteProgram(int id);
        Task<bool> ProgramExists(int id);
        Task<bool> ProgramHasTracks(int programId);
        #endregion


        #region track
        Task<List<Track>> GetAllTracks();
        Task<Track> GetTrackById(int id);
        Task AddTrack(Track track);
        Task UpdateTrack(Track track);
        Task DeleteTrack(int id);
        Task<bool> TrackExists(int id);
        Task<bool> TrackHasStudents(int trackId);
        #endregion

        #region intake
        Task<List<Intake>> GetAllIntakes();
        Task<Intake> GetIntakeById(int id);
        Task AddIntake(Intake intake);
        Task UpdateIntake(Intake intake);
        Task DeleteIntake(int id);
        Task<bool> IntakeExists(int id);
        Task<bool> IntakeHasTracks(int intakeId);
        #endregion


        IEnumerable<Instructor> GetInstructors();
        Instructor GetInstructorById(int id);
        void InsertInstructor(Instructor instructor);
        void UpdateInstructor(Instructor instructor);
        void DeleteInstructor(int id);

        User GetCurrentUser();
        Task AddDummy();
    }
}
