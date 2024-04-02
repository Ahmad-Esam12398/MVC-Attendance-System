using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Attendance_Management_System.Models
{
    public class Intake
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProgramId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        //navigation
        [ForeignKey("ProgramId")]
        public ITIProgram Program { get; set; }
       
    }
}
