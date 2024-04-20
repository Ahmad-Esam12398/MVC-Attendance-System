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
            
                db.Programs.Add(program);
                await db.SaveChangesAsync();
            
          
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
           
            return await db.Tracks.AnyAsync(t => t.ProgramId == programId);
        }
        public async Task<bool> ProgramExists(int id) 
        {
            return await db.Programs.AnyAsync(p => p.Id == id);
        }
        #endregion

        #region track

        public async Task<List<Track>> GetAllTracks()
        {
            return await db.Tracks.Where(t => t.IsActive).ToListAsync();
        }

        public async Task<Track> GetTrackById(int id)
        {
            return await db.Tracks.FindAsync(id);
        }

        public async Task AddTrack(Track track)
        {
            db.Tracks.Add(track);
            await db.SaveChangesAsync();
        }

        public async Task UpdateTrack(Track track)
        {
            db.Entry(track).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async Task DeleteTrack(int id)
        {
            var track = await db.Tracks.FindAsync(id);
            db.Tracks.Remove(track);
            await db.SaveChangesAsync();
        }

        public async Task<bool> TrackExists(int id)
        {
            return await db.Tracks.AnyAsync(t => t.Id == id);
        }

        public async Task<bool> TrackHasStudents(int trackId)
        {
            return await db.Students.AnyAsync(s => s.TrackID == trackId);
        }

        #endregion
        #region intake
        public async Task<List<Intake>> GetAllIntakes()
        {
            return await db.Intake.ToListAsync();
        }

        public async Task<Intake> GetIntakeById(int id)
        {
            return await db.Intake.FindAsync(id);
        }

        public async Task AddIntake(Intake intake)
        {
            db.Intake.Add(intake);
            await db.SaveChangesAsync();
        }

        public async Task UpdateIntake(Intake intake)
        {
            db.Entry(intake).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async Task DeleteIntake(int id)
        {
            var intake = await db.Intake.FindAsync(id);
            db.Intake.Remove(intake);
            await db.SaveChangesAsync();
        }

        public async Task<bool> IntakeExists(int id)
        {
            return await db.Intake.AnyAsync(i => i.Id == id);
        }

        public async Task<bool> IntakeHasTracks(int intakeId)
        {
            return await db.TrackIntakes.AnyAsync(ti => ti.IntakeId == intakeId);
        }
        #endregion



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