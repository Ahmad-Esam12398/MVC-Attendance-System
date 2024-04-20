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
        IEnumerable<Track> GetTracks();

     
        Track GetTrackById(int id);

        
        void InsertTrack(Track track);

      
        void UpdateTrack(Track track);

        void DeleteTrack(int id);
        #endregion

        #region intake
        void InsertIntake(Intake intake); // C

        IEnumerable<Intake> GetIntakes(); // R

        Intake GetIntakeByID(int IntakeId); // R

        void UpdateIntake(Intake intake); //U

        void DeleteIntake(int IntakeId); //D
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
