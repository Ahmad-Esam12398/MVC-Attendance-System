using Attendance_Management_System.Models;

namespace Attendance_Management_System.Data
{
    public class itiDummy : IitiContext
    {
        public List<Student> students { get; set; }
        public List<Track> Tracks { get; set; }
        public List<ITIProgram> Programs { get; set; }
        public itiDummy()
        {
            Seed();
        }
        #region Seed Initial Data
        private void Seed()
        {
            #region Programs
            Programs = new List<ITIProgram>()
            {
                new ITIProgram()
                {
                    Id = 1,
                    Name = "PTP",
                    Description = "Professional Training Program",
                    IsActive = true,
                },
                new ITIProgram()
                {
                    Id = 2,
                    Name = "ITP",
                    Description = "Intensive Training Program",
                    IsActive = true,
                },
                new ITIProgram()
                {
                    Id = 3,
                    Name = "LDP",
                    Description = "Leadership Development Program",
                    IsActive = true,
                },
                new ITIProgram()
                {
                    Id = 4,
                    Name = "ST",
                    Description = "Summer Training",
                    IsActive = true,
                }
            };
            #endregion
            #region Tracks
            Tracks = new List<Track>()
            {
                new Track()
                {
                    Id = 1,
                    Name = "PD",
                    IsActive = true,
                    Program = Programs[0]
                },
                new Track()
                {
                    Id = 2,
                    Name = "OS",
                    IsActive = true,
                    Program = Programs[0]
                },
                new Track()
                {
                    Id = 3,
                    Name = "AI",
                    IsActive = true,
                    Program = Programs[1]
                },
                new Track()
                {
                    Id = 4,
                    Name = "MERN",
                    IsActive = true,
                    Program = Programs[1]
                },
                new Track()
                {
                    Id = 5,
                    Name = "MEAN",
                    IsActive = true,
                    Program = Programs[1]
                },
            };
            #endregion
            #region Students
            students = new List<Student>()
            {
                new Student()
                {
                    Id = "29803121600573",
                    UserName = "AhmadEsam",
                    Email = "Ahmad.esam1231998@gmail.com",
                    Phone = "01015328933",
                    Gender = 'M',
                    Password = "12345678",
                    University = "Mansoura",
                    Faculty = "Engineering",
                    Track = Tracks[0]
                },
                new Student()
                {
                    Id = "29803151800654",
                    UserName = "AliEmad",
                    Email = "ali@example.com",
                    Phone = "01115328933",
                    Gender = 'M',
                    Password = "12345678",
                    University = "Mansoura",
                    Faculty = "CS",
                    Track = Tracks[0]
                },
                new Student()
                {
                    Id = "32006485523654",
                    UserName = "AhmedAbdallah",
                    Email = "AhmadL3swy@example.com",
                    Phone = "01215328933",
                    Gender = 'M',
                    Password = "12345678",
                    University = "Cairo",
                    Faculty = "Engineering",
                    Track = Tracks[0]
                },
                new Student()
                {
                    Id = "42557896652148",
                    UserName = "Raheek",
                    Email = "Raheek@gmail.com",
                    Phone = "01015328933",
                    Gender = 'F',
                    Password = "12345678",
                    University = "AinShams",
                    Faculty = "Engineering",
                    Track = Tracks[1]
                },
                new Student()
                {
                    Id = "53665485772015",
                    UserName = "Nada",
                    Email = "Nada@yahoo.com",
                    Phone = "01015328933",
                    Gender = 'F',
                    Password = "12345678",
                    University = "Tanta",
                    Faculty = "CS",
                    Track = Tracks[1]
                }
            };
            #region randomize students data
            List<string> Universities = new List<string> { "Mansoura", "Tanta", "Cairo", "AinShams", "Zagazig" };
            List<string> Faculties = new List<string> { "Engineering", "CS", "IS", "Accounting" };
            List<char> Genders = new List<char> { 'M', 'F' };
            List<char> Digits = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            Random random = new Random();
            char[] id = new char[14];
            for (int i = 6; i < 100; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    if (j == 0)
                    {
                        id[j] = Digits[random.Next(1, 9)];
                    }
                    else
                    {
                        id[j] = Digits[random.Next(0, 9)];
                    }

                }
                students.Add(new Student()
                {
                    Id = new string(id),
                    UserName = "Student" + i,
                    Email = "Student" + i + "@example.com",
                    Phone = "01015328933",
                    Gender = Genders[random.Next(Genders.Count)],
                    Password = "12345678",
                    University = Universities[random.Next(Universities.Count)],
                    Faculty = Faculties[random.Next(Faculties.Count)],
                    Track = Tracks[random.Next(Tracks.Count)]
                });
            }
            #endregion
            #endregion
        }
        #endregion
    }
}
