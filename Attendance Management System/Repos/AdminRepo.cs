using Attendance_Management_System.Data;
using Attendance_Management_System.Models;
using Humanizer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore; // Add this directive for Include method

using Microsoft.VisualStudio.Web.CodeGeneration.Design;


namespace Attendance_Management_System.Repos
{
    public class AdminRepo : IAdminRepo
    {
        IitiContext db;
        public AdminRepo(IitiContext _db)
        {
            db = _db;
        }


        #region program
        public void DeleteProgram(int ProgramId)
        {
            ITIProgram program = db.programs.FirstOrDefault(p => p.Id == ProgramId);

            db.programs.Remove(program);

            // db.SaveChanges();
        }



        public ITIProgram GetProgramByID(int ProgramId)
        {

            return db.programs.FirstOrDefault(p => p.Id == ProgramId);
        }

        public IEnumerable<ITIProgram> GetPrograms()
        {
            return db.programs.ToList();
        }

        public void InsertProgram(ITIProgram iprogram)
        {
            db.programs.Add(iprogram);

            //db.SaveChanges();
        }

        public void UpdateProgram(ITIProgram program)
        {

            var existingProgram = db.programs.FirstOrDefault(p => p.Id == program.Id);

            if (existingProgram != null)
            {

                existingProgram.Name = program.Name;
                existingProgram.Description = program.Description;


                // db.SaveChanges();
            }
        }
        #endregion

        #region track
        public void InsertTrack(Track track)
        {
            db.tracks.Add(track);
        }
        public Track GetTrackById(int id)
        {
            #region test
            var trackRes = db.tracks.FirstOrDefault(tr => tr.Id == id);
            var programm = db.programs.FirstOrDefault(p => p.Id == trackRes.ProgramId);
            var supervisorr = db.instructors.FirstOrDefault(i => i.Id == trackRes.SupervisorId);
            trackRes.Program = programm;
            trackRes.Supervisor = supervisorr;
            return trackRes;
            #endregion
            //return db.tracks.Include(track => track.Program).FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Track> GetTracks()
        {
            return db.tracks.Where(t => t.IsActive).ToList();
        }
        

        public void UpdateTrack(Track track)
        {
            var existingTrack = db.tracks.FirstOrDefault(t => t.Id == track.Id);

            if (existingTrack != null)
            {

                existingTrack.Name = track.Name;
                existingTrack.ProgramId = track.ProgramId;
                existingTrack.IsActive = track.IsActive;
                existingTrack.SupervisorId = track.SupervisorId;


                // db.SaveChanges();
            }
        }
        public void DeleteTrack(int id)
        {
            
            Track track = db.tracks.FirstOrDefault(p => p.Id == id);

            if (track != null)
            {
                track.IsActive = false;
               // db.SaveChanges();
            }
        }




        #endregion

        public void InsertIntake(Intake intake)
        {
            db.intakes.Add(intake);
        }

        public IEnumerable<Intake> GetIntakes()
        {
            return db.intakes.ToList();
        }

        public Intake GetIntakeByID(int IntakeId)
        {
            return db.intakes.FirstOrDefault(i => i.Id == IntakeId);
        }

        public void UpdateIntake(Intake intake)
        {
            var existingIntake = db.intakes.FirstOrDefault(i => i.Id == intake.Id);

            if (existingIntake != null)
            {

                existingIntake.Name = intake.Name;
                existingIntake.ProgramId = intake.ProgramId;
                existingIntake.StartDate = intake.StartDate;
                existingIntake.EndDate = intake.EndDate;

            }
        }
            
        

        public void DeleteIntake(int IntakeId)
        {
            Intake intake = db.intakes.FirstOrDefault(i => i.Id == IntakeId) ;

            db.intakes.Remove(intake);
        }

        public IEnumerable<Instructor> GetInstructors()
        {
            return db.instructors.ToList();
        }

        public Instructor GetInstructorById(string id)
        {
            return db.instructors.FirstOrDefault(i => i.Id == id);
        }

        public void InsertInstructor(Instructor instructor)
        {
            db.instructors.Add(instructor);
            //db.SaveChanges();
        }

        public void UpdateInstructor(Instructor instructor)
        {
           // db.instructors.Update(instructor);
            //db.SaveChanges();
            var existingInstructor = db.instructors.FirstOrDefault(i => i.Id == instructor.Id);

            if (existingInstructor != null)
            {

                existingInstructor.UserName = instructor.UserName;
                existingInstructor.Email = instructor.Email;
                

            }
        }

        public void DeleteInstructor(string id)
        {
            var instructor = db.instructors.FirstOrDefault(i => i.Id == id);
            if (instructor != null)
            {
                db.instructors.Remove(instructor);
               // db.SaveChanges();
            }
        }
    }
}