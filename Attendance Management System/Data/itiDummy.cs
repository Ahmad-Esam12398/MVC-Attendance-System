using Attendance_Management_System.Models;

namespace Attendance_Management_System.Data
{
    public class itiDummy : IitiContext
    {
        public List<Student> students { get; set; }

        public itiDummy()
        {
            Seed();
        }
        private void Seed()
        {
            students = new List<Student>()
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
                },
                new Student()
                {
                    Id = "4",
                    UserName = "Omar",
                    Email = "omar@example.com",
                    Phone = "01015328933",
                    Password = "12345678",
                    Faculty = "Engineering",
                },
                                new Student()
                {
                    Id = "5",
                    UserName = "Ahmad",
                    Email = "Ahmad.esam1231998@gmail.com",
                    Phone = "01015328933",
                    Password = "12345678",
                    Faculty = "Engineering",
                },
                new Student()
                {
                    Id = "6",
                    UserName = "Mohamed",
                    Email = "mohamed@example.com",
                    Phone = "01015328933",
                    Password = "12345678",
                    Faculty = "Engineering",
                },
                new Student()
                {
                    Id = "7",
                    UserName = "Ali",
                    Email = "ali@ali.com",
                    Phone = "01015328933",
                    Password = "12345678",
                    Faculty = "Engineering",
                },
                new Student()
                {
                    Id = "8",
                    UserName = "Omar",
                    Email = "omar@example.com",
                    Phone = "01015328933",
                    Password = "12345678",
                    Faculty = "Engineering",
                },
                                new Student()
                {
                    Id = "9",
                    UserName = "Ahmad",
                    Email = "Ahmad.esam1231998@gmail.com",
                    Phone = "01015328933",
                    Password = "12345678",
                    Faculty = "Engineering",
                },
                new Student()
                {
                    Id = "10",
                    UserName = "Mohamed",
                    Email = "mohamed@example.com",
                    Phone = "01015328933",
                    Password = "12345678",
                    Faculty = "Engineering",
                },
                new Student()
                {
                    Id = "11",
                    UserName = "Ali",
                    Email = "ali@ali.com",
                    Phone = "01015328933",
                    Password = "12345678",
                    Faculty = "Engineering",
                },
                new Student()
                {
                    Id = "12",
                    UserName = "Omar",
                    Email = "omar@example.com",
                    Phone = "01015328933",
                    Password = "12345678",
                    Faculty = "Engineering",
                },
                                new Student()
                {
                    Id = "13",
                    UserName = "Ahmad",
                    Email = "Ahmad.esam1231998@gmail.com",
                    Phone = "01015328933",
                    Password = "12345678",
                    Faculty = "Engineering",
                },
                new Student()
                {
                    Id = "14",
                    UserName = "Mohamed",
                    Email = "mohamed@example.com",
                    Phone = "01015328933",
                    Password = "12345678",
                    Faculty = "Engineering",
                },
                new Student()
                {
                    Id = "15",
                    UserName = "Ali",
                    Email = "ali@ali.com",
                    Phone = "01015328933",
                    Password = "12345678",
                    Faculty = "Engineering",
                },
                new Student()
                {
                    Id = "16",
                    UserName = "Omar",
                    Email = "omar@example.com",
                    Phone = "01015328933",
                    Password = "12345678",
                    Faculty = "Engineering",
                },
            };
        }
    }
}
