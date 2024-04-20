using Attendance_Management_System.Data;
using Attendance_Management_System.Models;
using Humanizer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore; // Add this directive for Include method

using Microsoft.VisualStudio.Web.CodeGeneration.Design;
using System.Security.Claims;


namespace Attendance_Management_System.Repos
{
    public class AdminRepo : IAdminRepo
    {
        itiContext db;
        private readonly UserManager<User> _userManager;
        private readonly ClaimsPrincipal _userPrincipal; // Add a field to store the user principal

        public AdminRepo(itiContext _db, UserManager<User> userManager, ClaimsPrincipal userPrincipal)
        {
            db = _db;
            _userManager = userManager;
            _userPrincipal = userPrincipal; // Assign the user principal to the field

        }


        #region program
        public async Task<List<ITIProgram>> GetAllPrograms()
        {
            return await db.Programs.Where(p => p.IsActive).ToListAsync();
        }

        public async Task<ITIProgram> GetProgramById(int id)
        {
            return await db.Programs.FindAsync(id);
        }

        public async Task AddProgram(ITIProgram program)
        {
            try
            {
                db.Programs.Add(program);
                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                // For debugging purposes, you can also inspect 'ex' to see the specific error message
                throw; // Rethrow the exception to propagate it to the caller
            }
        }


        public async Task UpdateProgram(ITIProgram program)
        {
            db.Entry(program).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async Task DeleteProgram(int id)
        {
            var program = await db.Programs.FindAsync(id);
            db.Programs.Remove(program);
            await db.SaveChangesAsync();
        }
        public async Task<bool> ProgramHasTracks(int programId)
        {
            // Check if there are any tracks associated with the program
            return await db.Tracks.AnyAsync(t => t.ProgramId == programId);
        }
        public async Task<bool> ProgramExists(int id) // Implement ProgramExists method in AdminRepo
        {
            return await db.Programs.AnyAsync(p => p.Id == id);
        }
        #endregion

        #region track
        public void InsertTrack(Track track)
        {
            db.Tracks.Add(track);
        }
        public Track GetTrackById(int id)
        {
            #region test
            var trackRes = db.Tracks.FirstOrDefault(tr => tr.Id == id);
            var programm = db.Programs.FirstOrDefault(p => p.Id == trackRes.ProgramId);
            var supervisorr = db.Supervisors.FirstOrDefault(i => i.Id == trackRes.SupervisorId);
            trackRes.Program = programm;
            trackRes.Supervisor = supervisorr;
            return trackRes;
            #endregion
         //return db.Tracks.Include(track => track.Program).FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Track> GetTracks()
        {
            return db.Tracks.Where(t => t.IsActive).ToList();
        }
        

        public void UpdateTrack(Track track)
        {
            var existingTrack = db.Tracks.FirstOrDefault(t => t.Id == track.Id);

            if (existingTrack != null)
            {

                existingTrack.Name = track.Name;
                existingTrack.ProgramId = track.ProgramId;
                existingTrack.IsActive = track.IsActive;
                existingTrack.SupervisorId = track.SupervisorId;


                 db.SaveChanges();
            }
        }
        public void DeleteTrack(int id)
        {
            
            Track track = db.Tracks.FirstOrDefault(p => p.Id == id);

            if (track != null)
            {
                track.IsActive = false;
               db.SaveChanges();
            }
        }




        #endregion

        public void InsertIntake(Intake intake)
        {
            db.Intakes.Add(intake);
        }

        public IEnumerable<Intake> GetIntakes()
        {
            return db.Intakes.ToList();
        }

        public Intake GetIntakeByID(int IntakeId)
        {
            return db.Intakes.FirstOrDefault(i => i.Id == IntakeId);
        }

        public void UpdateIntake(Intake intake)
        {
            var existingIntake = db.Intakes.FirstOrDefault(i => i.Id == intake.Id);

            if (existingIntake != null)
            {

                existingIntake.Number = intake.Number;
                existingIntake.ProgramId = intake.ProgramId;
                existingIntake.StartDate = intake.StartDate;
                existingIntake.EndDate = intake.EndDate;

            }
        }
            
        

        public void DeleteIntake(int IntakeId)
        {
            Intake intake = db.Intakes.FirstOrDefault(i => i.Id == IntakeId) ;

            db.Intakes.Remove(intake);
        }

        public IEnumerable<Instructor> GetInstructors()
        {
            return db.Instructors.ToList();
        }

        public Instructor GetInstructorById(int id)
        {
            return db.Instructors.FirstOrDefault(i => i.Id == id);
        }

        public void InsertInstructor(Instructor instructor)
        {
            db.Instructors.Add(instructor);
            db.SaveChanges();
        }

        public void UpdateInstructor(Instructor instructor)
        {
           // db.instructors.Update(instructor);
         
            var existingInstructor = db.Instructors.FirstOrDefault(i => i.Id == instructor.Id);

            if (existingInstructor != null)
            {

                existingInstructor.UserName = instructor.UserName;
                existingInstructor.Email = instructor.Email;
                

            }
            db.SaveChanges();
        }

        public void DeleteInstructor(int id)
        {
            var instructor = db.Instructors.FirstOrDefault(i => i.Id == id);
            if (instructor != null)
            {
                db.Instructors.Remove(instructor);
                db.SaveChanges();
            }
        }
        public User GetCurrentUser()
        {
            return _userManager.GetUserAsync(_userPrincipal).Result; // Get the current user using the user principal
        }
        public async Task AddDummy()
        {

            await _userManager.CreateAsync(new Admin { UserName = "nada", NationalId = "1011", Email = "nada@gmail.com" }, "123456aA!");

        }


    }
}