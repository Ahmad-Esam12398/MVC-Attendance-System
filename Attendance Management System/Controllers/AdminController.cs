using Attendance_Management_System.Models;
using Attendance_Management_System.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Attendance_Management_System.Controllers
{
    public class AdminController : Controller
    {
        IAdminRepo AdminRepo;
       
        public AdminController(IAdminRepo _AdminRepo)
        {
            AdminRepo = _AdminRepo;
        }


        public IActionResult Index()
        {
            ViewData["IsAdmin"] = false;
            //AdminRepo.AddDummy();
            // Get Current User
            var user = AdminRepo.GetCurrentUser();
            if (user == null)
            {
                return Redirect("/Identity/Account/Login");

            }
            if (user is not Admin)
            {
                return RedirectToAction("Index", "Home");
            }
            if (user is Admin)
            {
                ViewData["IsAdmin"] = true;
            }
            ViewData["Name"] = user.UserName;
            return View();
        }

        public IActionResult InstructorIndex()
        {
            var instructors = AdminRepo.GetInstructors();
            return View(instructors);
        }

      
        public IActionResult InstructorDetails(int id)
        {
            var instructor = AdminRepo.GetInstructorById(id);
            if (instructor == null)
            {
                return NotFound();
            }
            return View(instructor);
        }

       
        public IActionResult CreateInstructor()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateInstructor(Instructor instructor)
        {
            if (ModelState.IsValid)
            {
                AdminRepo.InsertInstructor(instructor);
                return RedirectToAction(nameof(InstructorIndex));
            }
            return View(instructor);
        }

      
        public IActionResult EditInstructor(int id)
        {
            var instructor = AdminRepo.GetInstructorById(id);
            if (instructor == null)
            {
                return NotFound();
            }
            return View(instructor);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditInstructor(int id, Instructor instructor)
        {
            if (id != instructor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                AdminRepo.UpdateInstructor(instructor);
                return RedirectToAction(nameof(InstructorIndex));
            }

            return View(instructor);
        }

       
        public IActionResult DeleteInstructor(int id)
        {
            var instructor = AdminRepo.GetInstructorById(id);
            if (instructor == null)
            {
                return NotFound();
            }

            return View(instructor);
        }

       
        [HttpPost, ActionName("DeleteInstructor")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            AdminRepo.DeleteInstructor(id);
            return RedirectToAction(nameof(InstructorIndex));
        }
        #region intake
        public IActionResult IntakeIndex()
        {
            var intakes = AdminRepo.GetIntakes();
            return View(intakes);
        }
        public IActionResult IntakeDetails(int id)
        {
            var intake = AdminRepo.GetIntakeByID(id);
            if (intake == null)
            {
                return NotFound();
            }
            return View(intake);
        }
        public IActionResult CreateIntake()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateIntake(Intake intake)
        {
            if (ModelState.IsValid)
            {
                AdminRepo.InsertIntake(intake);
                return RedirectToAction(nameof(IntakeIndex));
            }
            return View(intake);
        }

        public IActionResult EditIntake(int id)
        {
            var intake = AdminRepo.GetIntakeByID(id);
            if (intake == null)
            {
                return NotFound();
            }
            return View(intake);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditIntake(int id, Intake intake)
        {
            if (id != intake.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                AdminRepo.UpdateIntake(intake);
                TempData["EditSuccessMessage"] = "Intake updated successfully!";
                return RedirectToAction("IntakeIndex");
            }

            return View(intake);
        }
        public IActionResult DeleteIntake(int id)
        {
            var intake = AdminRepo.GetIntakeByID(id);
            if (intake == null)
            {
                return NotFound();
            }

            return View(intake);
        }

        [HttpPost, ActionName("DeleteIntake")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteIntakeConfirmed(int id)
        {
            AdminRepo.DeleteIntake(id);
            return RedirectToAction(nameof(IntakeIndex));
        }
        #endregion
        #region program

        public async Task<IActionResult> ProgramIndex()
        {
            var programs = await AdminRepo.GetAllPrograms();
            return View(programs);
        }

        public async Task<IActionResult> ProgramDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var program = await AdminRepo.GetProgramById(id.Value);
            if (program == null)
            {
                return NotFound();
            }

            return View(program);
        }

        public IActionResult CreateProgram()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProgram([Bind("Id,Name,Description,IsActive")] ITIProgram program)
        {
            if (ModelState.IsValid)
            {
                await AdminRepo.AddProgram(program);
                return RedirectToAction(nameof(ProgramIndex));
            }
            return View(program);
        }

        public async Task<IActionResult> EditProgram(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var program = await AdminRepo.GetProgramById(id.Value);
            if (program == null)
            {
                return NotFound();
            }
            return View(program);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProgram(int id, [Bind("Id,Name,Description,IsActive")] ITIProgram program)
        {
            if (id != program.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await AdminRepo.UpdateProgram(program);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await AdminRepo.ProgramExists(program.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ProgramIndex));
            }
            return View(program);
        }

        public async Task<IActionResult> DeleteProgram(int id)
        {
            var program = await AdminRepo.GetProgramById(id);
            if (program == null)
            {
                return NotFound();
            }

            return View(program);
        }

        [HttpPost, ActionName("DeleteProgram")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> DeleteProgramConfirmed(int id)
        {
            var program = await AdminRepo.GetProgramById(id);
            if (program == null)
            {
                return NotFound();
            }

            // Check if the program has associated tracks
            bool hasTracks = await AdminRepo.ProgramHasTracks(id);
            if (hasTracks)
            {
                TempData["DeleteErrorMessage"] = "This program cannot be deleted because it has associated tracks.";
                return RedirectToAction(nameof(ProgramIndex));
            }

            // Update the program IsActive property to false (inactive)
            program.IsActive = false;
            await AdminRepo.UpdateProgram(program);

            return RedirectToAction(nameof(ProgramIndex));
        }



        #endregion


        #region tracks
        public IActionResult TrackIndex()
        {
            var tracks = AdminRepo.GetTracks();
            return View(tracks);
        }

       
        public IActionResult TrackDetails(int id)
        {
            var track = AdminRepo.GetTrackById(id);
            if (track == null)
            {
                return NotFound();
            }

            return View(track);
        }

       
        public IActionResult CreateTrack()
        {
            return View();
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateTrack(Track track)
        {
            if (ModelState.IsValid)
            {
                AdminRepo.InsertTrack(track);
                return RedirectToAction(nameof(TrackIndex));
            }
            return View(track);
        }

     
        public IActionResult EditTrack(int id)
        {
            var track = AdminRepo.GetTrackById(id);
            if (track == null)
            {
                return NotFound();
            }
            return View(track);
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditTrack(int id, Track track)
        {
            if (id != track.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                AdminRepo.UpdateTrack(track);
                return RedirectToAction(nameof(TrackIndex));
            }
            return View(track);
        }

      
       public IActionResult DeleteTrack(int id)
        {
            var track = AdminRepo.GetTrackById(id);
            if (track == null)
            {
                return NotFound();
            }

            return View(track);
        }

        
        [HttpPost, ActionName("DeleteTrack")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteTrackConfirmed(int id)
        {
           var track = AdminRepo.GetTrackById(id);
          if (track == null)
            {
                return NotFound();
            }

       
            bool hasStudents = track.Students.Any();

            if (hasStudents)
            {
                
                TempData["ErrorMessage"] = "Cannot delete the track because it has students.";
                return RedirectToAction(nameof(TrackIndex));
            }
            else
            {
                
                AdminRepo.DeleteTrack(id);
                return RedirectToAction(nameof(TrackIndex));
            }
        }
    }
    #endregion


}


