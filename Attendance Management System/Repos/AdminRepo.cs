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
        public void DeleteProgram(int ProgramId)
        {
            ITIProgram program = db.Programs.FirstOrDefault(p => p.Id == ProgramId);

            db.Programs.Remove(program);

            db.SaveChanges();
        }



        public ITIProgram GetProgramByID(int ProgramId)
        {

            return db.Programs.FirstOrDefault(p => p.Id == ProgramId);
        }

        public IEnumerable<ITIProgram> GetPrograms()
        {
            return db.Programs.ToList();
        }

        public void InsertProgram(ITIProgram iprogram)
        {
            db.Programs.Add(iprogram);

            db.SaveChanges();
        }

        public void UpdateProgram(ITIProgram program)
        {

            var existingProgram = db.Programs.FirstOrDefault(p => p.Id == program.Id);

            if (existingProgram != null)
            {

                existingProgram.Name = program.Name;
                existingProgram.Description = program.Description;


                db.SaveChanges();
            }
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
        public async Task AddDummyInstructors()
        {

            await _userManager.CreateAsync(new Admin { UserName = "nada", NationalId = "1010", Email = "nada@gmail.com" }, "123456aA!");
            await _userManager.CreateAsync(new Supervisor { UserName = "salma", NationalId = "1011", Email = "salma@gmail.com", SupTrackId = 1 }, "123456aA!");

        }


    }
}