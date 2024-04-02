# MVC-Examination-System

AttendanceTimeTrackingSystem
│   README.md
│
└───src
│   └───AttendanceTimeTrackingSystem
│       │   Startup.cs
│       │   Program.cs
│       │   appsettings.json
│       │   ...
│       │
│       └───Controllers
│       │       HomeController.cs
│       │       StudentController.cs
│       │       EmployeeController.cs
│       │       InstructorController.cs
│       │       ...
│       │
│       └───Models
│       │       Student.cs
│       │       Employee.cs
│       │       Instructor.cs
│       │       Permission.cs
│       │       Schedule.cs
│       │       ...
│       │
│       └───Views
│       │   └───Home
│       │   │       Index.cshtml
│       │   │       ...
│       │   │
│       │   └───Student
│       │   │       Index.cshtml
│       │   │       ...
│       │   │
│       │   └───Employee
│       │   │       Index.cshtml
│       │   │       ...
│       │   │
│       │   └───Instructor
│       │   │       Index.cshtml
│       │   │       ...
│       │   │
│       │   │   _Layout.cshtml
│       │   │   _ViewImports.cshtml
│       │   │   _ViewStart.cshtml
│       │   │
│       │   └───Shared
│       │           _Header.cshtml
│       │           _Footer.cshtml
│       │           ...
│       │
│       └───Data
│       │   │   ApplicationDbContext.cs
│       │   │
│       │   └───Migrations
│       │           ...
│       │
│       └───wwwroot
│       │   │   site.css
│       │   │   script.js
│       │   │   ...
│       │
│       └───Utilities
│           │   ExcelHelper.cs
│           │   ...
│   
└───docs
│   │   SystemDesign.docx
│   │   DatabaseSchema.png
│   │   ...
│   
└───tests
    │   AttendanceTests.cs
    │   EmployeeTests.cs
    │   StudentTests.cs
    │   ...
