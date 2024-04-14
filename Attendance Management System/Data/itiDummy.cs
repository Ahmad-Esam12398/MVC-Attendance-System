using Attendance_Management_System.Models;

namespace Attendance_Management_System.Data
{
    public class itiDummy : IitiContext
    {
        public List<Student> Students { get; set; }
        public List<Track> Tracks { get; set; }
        public List<ITIProgram> Programs { get; set; }
        
      public List<Permission> Permissions { get; set; }
        public List<Schedule> Schedules { get; set; }
        public List<Attendance> Attendances { get; set; }
        // ********** Added List Of Permissions ********** //
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
                    Program = Programs[0],
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
            
            Students = new List<Student>()
            {
                new Student()
                {
                    ID = 1,
                    NationalId = "29803121600573",
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
                    ID = 2,
                    NationalId = "29803151800654",
                    UserName = "AliEmad",
                    Email = "ali@example.com",
                    Phone = "01115328933",
                    Gender = 'M',
                    Password = "12345678",
                    University = "Mansoura",
                    Faculty = "CS",
                    Track = Tracks[0],
                    TrackID=1
                },
                new Student()
                {
                    ID = 3,
                    NationalId = "32006485523654",
                    UserName = "AhmedAbdallah",
                    Email = "AhmadL3swy@example.com",
                    Phone = "01215328933",
                    Gender = 'M',
                    Password = "12345678",
                    University = "Cairo",
                    Faculty = "Engineering",
                    Track = Tracks[0],
                    TrackID=1,

                },
                new Student()
                {
                    ID = 4,
                    NationalId = "42557896652148",
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
                    ID = 5,
                    NationalId = "53665485772015",
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
                Students.Add(new Student()
                {
                    ID = i,
                    NationalId = new string(id),
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

            #region Permission
            Permissions = [
                
                new Permission { 
                    StudentId= 2 ,
                    Reason="Latance",
                    BodyOfDescription="متاخر فى المواصلات ",
                    DateCreated= new DateTime(2024,3,2,8,40,10),
                    Student= Students[1],
                    Status=Models.PermissionStatus.Refused


                },
            new Permission {
                    StudentId= 2 ,
                    Reason="illness",
                    BodyOfDescription="تعبان فى البيت عندى دور برد ",
                    DateCreated= new DateTime(2024,3,5,5,11,12),
                    Student= Students[1],
                    Status=Models.PermissionStatus.Accepted


                }
            ]; 
            #endregion


            #region Schedule
            Schedules = new List<Schedule>()
            {
                new Schedule()
                {
                    Id = 1,
                    Date = DateOnly.FromDateTime(DateTime.Now),
                    StartTime = TimeOnly.Parse("09:00"),
                    EndTime = TimeOnly.Parse("20:00"),
                    Track = Tracks[0],
                    TrackId= 1
                },
                new Schedule()
                {
                    Id = 2,
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)),
                    StartTime = TimeOnly.Parse("11:00"),
                    EndTime = TimeOnly.Parse("20:00"),
                    Track = Tracks[1],

                }
            };
            Tracks[0].Students = Students.Where(s => s.Track == Tracks[0]).ToList();
            Tracks[1].Students = Students.Where(s => s.Track == Tracks[1]).ToList();




            #region Schedule for test attendance
            List<DateOnly> datesForTrack0 = new List<DateOnly>
{
    new DateOnly(2024, 3, 2),   // March 2, 2024 - Saturday
    new DateOnly(2024, 3, 3),   // March 3, 2024 - Sunday
    new DateOnly(2024, 3, 4),   // March 4, 2024 - Monday
    new DateOnly(2024, 3, 5),   // March 5, 2024 - Tuesday
    new DateOnly(2024, 3, 6),   // March 6, 2024 - Wednesday
    new DateOnly(2024, 3, 7),   // March 7, 2024 - Thursday
    new DateOnly(2024, 3, 9),   // March 9, 2024 - Saturday
    new DateOnly(2024, 3, 10),  // March 10, 2024 - Sunday
    new DateOnly(2024, 3, 11),  // March 11, 2024 - Monday
    new DateOnly(2024, 3, 12),  // March 12, 2024 - Tuesday
    new DateOnly(2024, 3, 13),  // March 13, 2024 - Wednesday
    new DateOnly(2024, 3, 14)   // March 14, 2024 - Thursday
};

            // Loop through the dates and create Schedule objects for Track[0]
            foreach (var date in datesForTrack0)
            {
                Schedule schedule = new Schedule
                {
                    Id = Schedules.Count + 1, // Assign a unique ID
                    Date = date,
                    StartTime = TimeOnly.Parse("09:00"), // Assuming the start time is 09:00
                    EndTime = TimeOnly.Parse("20:00"),   // Assuming the end time is 22:00
                    Track = Tracks[0], // Assuming Tracks is the array containing tracks
                    TrackId=1
                };

                // Add the schedule to the list
                Schedules.Add(schedule);
            }

            #endregion

            #endregion

            #region Attendance
            Attendances = [new Attendance() {
                StudentId = 1,
                Student = Students[0],
                Date= new DateOnly(2024, 3, 2),
                Time_in = new TimeOnly(9, 2),
                Time_out = new TimeOnly(20, 0)
            }];
           

            foreach (var item in datesForTrack0)
            {
                if (item == new DateOnly(2024, 3, 2) || item == new DateOnly(2024, 3, 5)) continue;
                Attendance attendance = new Attendance()
                {
                    
                    StudentId = 2,
                    Student = Students[1],
                    Date = item,
                    Time_in = new TimeOnly(9, 2),
                    Time_out = new TimeOnly(20, 0)
                };
                Attendances.Add(attendance);

            }

            #endregion
            // ********** Added Permissions ********** //
            #region Permissions
            Permissions.Add(new Permission()
            {

                Reason = "Late",
                BodyOfDescription = "I was late because of the traffic",
                Status = PermissionStatus.Pending,
                StudentId = 1,
                DateCreated = new DateTime(2024, 4, 3),
                Student = Students[0]

            });
            Permissions.Add(new Permission()
            {

                Reason = "Sick",
                BodyOfDescription = "I was sick",
                Status = PermissionStatus.Pending,
                StudentId = 2,
                DateCreated = new DateTime(2024, 4, 13),
                Student = Students[1]
            });

            Permissions.Add(new Permission()
            {

                Reason = "Late",
                BodyOfDescription = "I was late because of the traffic",
                Status = PermissionStatus.Pending,
                StudentId = 3,
                DateCreated = new DateTime(2024, 4, 4),
                Student = Students[2]
            });
            #endregion

        }
        #endregion
    }
}