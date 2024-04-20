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
        #region instructor
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
        #endregion
        #region intake
        public async Task<IActionResult> IntakeIndex()
        {
            var intakes = await AdminRepo.GetAllIntakes();
            return View(intakes);
        }

        public async Task<IActionResult> IntakeDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var intake = await AdminRepo.GetIntakeById(id.Value);
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
        public async Task<IActionResult> CreateIntake([Bind("Id,Number,StartDate,EndDate")] Intake intake)
        {
            if (ModelState.IsValid)
            {
                await AdminRepo.AddIntake(intake);
                return RedirectToAction(nameof(IntakeIndex));
            }
            return View(intake);
        }

        public async Task<IActionResult> EditIntake(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var intake = await AdminRepo.GetIntakeById(id.Value);
            if (intake == null)
            {
                return NotFound();
            }
            return View(intake);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditIntake(int id, [Bind("Id,Number,StartDate,EndDate")] Intake intake)
        {
            if (id != intake.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await AdminRepo.UpdateIntake(intake);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await AdminRepo.IntakeExists(intake.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IntakeIndex));
            }
            return View(intake);
        }

        public async Task<IActionResult> DeleteIntake(int id)
        {
            var intake = await AdminRepo.GetIntakeById(id);
            if (intake == null)
            {
                return NotFound();
            }

            return View(intake);
        }

        [HttpPost, ActionName("DeleteIntake")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteIntakeConfirmed(int id)
        {
            var intake = await AdminRepo.GetIntakeById(id);
            if (intake == null)
            {
                return NotFound();
            }

            bool hasTracks = await AdminRepo.IntakeHasTracks(id);
            if (hasTracks)
            {
                TempData["DeleteErrorMessage"] = "This intake cannot be deleted because it has associated tracks.";
                return RedirectToAction(nameof(IntakeIndex));
            }

            // Remove the intake from the database
            await AdminRepo.DeleteIntake(id);

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


            bool hasTracks = await AdminRepo.ProgramHasTracks(id);
            if (hasTracks)
            {
                TempData["DeleteErrorMessage"] = "This program cannot be deleted because it has associated tracks.";
                return RedirectToAction(nameof(ProgramIndex));
            }

            program.IsActive = false;
            await AdminRepo.UpdateProgram(program);

            return RedirectToAction(nameof(ProgramIndex));
        }



        #endregion


        #region tracks
        public async Task<IActionResult> TrackIndex()
        {
            var tracks = await AdminRepo.GetAllTracks();
            return View(tracks);
        }

        public async Task<IActionResult> TrackDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var track = await AdminRepo.GetTrackById(id.Value);
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
        public async Task<IActionResult> CreateTrack([Bind("Id,Name,ProgramId,SupervisorId,IsActive")] Track track)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await AdminRepo.AddTrack(track);
                    return RedirectToAction(nameof(TrackIndex));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "An error occurred while saving the track. Please try again.");
                    // Log the exception for debugging purposes
                    // logger.LogError(ex, "Error occurred while saving track");
                }
            }
            return View(track);
        }

        public async Task<IActionResult> EditTrack(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var track = await AdminRepo.GetTrackById(id.Value);
            if (track == null)
            {
                return NotFound();
            }
            return View(track);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditTrack(int id, [Bind("Id,Name,ProgramId,SupervisorId,IsActive")] Track track)
        {
            if (id != track.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await AdminRepo.UpdateTrack(track);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await AdminRepo.TrackExists(track.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(TrackIndex));
            }
            return View(track);
        }

        public async Task<IActionResult> DeleteTrack(int id)
        {
            var track = await AdminRepo.GetTrackById(id);
            if (track == null)
            {
                return NotFound();
            }

            return View(track);
        }

        [HttpPost, ActionName("DeleteTrack")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteTrackConfirmed(int id)
        {
            var track = await AdminRepo.GetTrackById(id);
            if (track == null)
            {
                return NotFound();
            }

            bool hasStudents = await AdminRepo.TrackHasStudents(id);
            if (hasStudents)
            {
                TempData["DeleteErrorMessage"] = "This track cannot be deleted because it has associated students.";
                return RedirectToAction(nameof(TrackIndex));
            }

            track.IsActive = false;
            await AdminRepo.UpdateTrack(track);

            return RedirectToAction(nameof(TrackIndex));
        }

        #endregion


    }
}


