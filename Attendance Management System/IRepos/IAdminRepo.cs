using Attendance_Management_System.Models;

namespace Attendance_Management_System.IRepos
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
        Task<Dictionary<int, string>> GetProgramNames(List<int> programIds);


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

        #region instructor
        Task<List<Instructor>> GetAllInstructors();
        Task<Instructor> GetInstructorById(int id);
        Task AddInstructor(Instructor instructor);
        Task UpdateInstructor(Instructor instructor);
        Task DeleteInstructor(int id);
        Task<bool> InstructorExists(int id);
        #endregion

        User GetCurrentUser();
        Task AddDummy();
    }
}
