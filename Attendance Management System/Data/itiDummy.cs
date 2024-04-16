using Attendance_Management_System.Models;
using System;
using System.Collections.Generic;

namespace Attendance_Management_System.Data
{
    public class itiDummy : IitiContext
    {
        public List<Student> students { get; set; }
        public List<ITIProgram> programs { get; set; }
        public List<Intake> intakes { get; set; }
        public List<Track> tracks { get; set; }
        public List<Instructor> instructors { get; set; }
        public List<Supervisor> supervisors { get; set; } 

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

            tracks = new List<Track>()
            {
                new Track()
                {
                    Id = 1,
                    Name = "PD",
                    IsActive = true,
                    ProgramId = 1,
                    SupervisorId = "1",
                    Schedules = new List<Schedule>()
                    {
                        // Add schedules for the PD track
                    },
                    Students = new List<Student>()
                    {
                        // Add students enrolled in the PD track
                       students[0]
                    }
                },
                new Track()
                {
                    Id = 2,
                    Name = "SD",
                    IsActive = false,
                    ProgramId = 1,
                    SupervisorId = "1",
                    Schedules = new List<Schedule>()
                    {
                        // Add schedules for the SD track
                    },
                    Students = new List<Student>()
                    {
                        // Add students enrolled in the SD track
                    }
                }
            };


            // Fill in the data for each property

            //supervisors.Add(new Supervisor()
            //{
            //    Id = "1",
            //    UserName = "Nadia",
            //    Email = "nadia@yahoo.com",
            //    Password = "password", // Fill in a password
            //    Phone = "0123456789", // Fill in a phone number
            //    Track = tracks[0],

            //});
            intakes = new List<Intake>()
            {
                new Intake()
                {
                    Id = 1,
                    Name = "43",
                    ProgramId = 1,
                    StartDate = DateTime.Now, // Fill in a start date
                    EndDate = DateTime.Now.AddMonths(9), // Fill in an end date
                },
                new Intake()
                {
                    Id = 2,
                    Name = "44",
                    ProgramId = 1,
                    StartDate = DateTime.Now, // Fill in a start date
                    EndDate = DateTime.Now.AddMonths(4), // Fill in an end date
                }
            };

            programs = new List<ITIProgram>()
            {
                new ITIProgram()
                {
                    Id = 1,
                    Name = "9-months",
                    Description = "9-months ITI Program", // Fill in a description
                    Tracks = new List<Track>()
                    {
                        tracks[0],tracks[1]

                    },
                    Intakes = new List<Intake>()
                    {
                        intakes[0]
                    }
                },
                new ITIProgram()
                {
                    Id = 2,
                    Name = "4-months",
                    Description = "4-months ITI Program", // Fill in a description
                    Tracks = new List<Track>()
                    {
                        tracks[0],tracks[1]

                    },
                    Intakes = new List<Intake>()
                    {
                        intakes[0]
                    }
                }
            };



            instructors = new List<Instructor>()
            {
                new Instructor()
                {
                    Id = "2",
                    UserName = "Aymen",
                    Email = "aymen@example.com",
                    Password = "password", // Fill in a password
                    Phone = "0123456789", // Fill in a phone number
                    Tracks = new List<Track>()
                    {
                        tracks[0]
                    }
                }
            };

            supervisors = new List<Supervisor>()
            {
                new Supervisor()
                {
                    Id = "1",
                    UserName = "Nadia",
                    Email = "nadia@yahoo.com",
                    Password = "password", // Fill in a password
                    Phone = "0123456789", // Fill in a phone number
                    Track=tracks[0],

                }
            };



            // You can continue adding more data for other classes as needed
        }
    }
}

     /*    
        }
    }
}*/
