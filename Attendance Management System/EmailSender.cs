using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

namespace Attendance_Management_System
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // Implement email sending logic here
            return Task.CompletedTask; // Dummy implementation for testing
        }
    }
}
