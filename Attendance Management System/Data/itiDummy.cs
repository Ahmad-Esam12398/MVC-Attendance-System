using Attendance_Management_System.Models;

namespace Attendance_Management_System.Data
{
    public class itiDummy : IitiContext
    {
        List<User> users { get; set;}
        itiDummy()
        {
            Seed();
        }
        private void Seed()
        {
            users = new List<User>()
            {
                new Student()
                {
                    Id = "1",
                    UserName = "Ahmad",
                    Email = "Ahmad.esam1231998@gmail.com",
                    Phone = "01015328933",
                    Password = "12345678",
                    Faculty = "Engineering",
                },
                new Student()
                {
                    Id = "2",
                    UserName = "Mohamed",
                    Email = "mohamed@example.com",
                    Phone = "01015328933",
                    Password = "12345678",
                    Faculty = "Engineering",
                },
                new Student()
                {
                    Id = "3",
                    UserName = "Ali",
                    Email = "ali@ali.com",
                    Phone = "01015328933",
                    Password = "12345678",
                    Faculty = "Engineering",
                }

            };
        }
    }
}
