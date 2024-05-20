# Attendance/Time Tracking System

## Description

Attendance/Time Tracking System is a web application designed to simplify the process of monitoring students, employees, and instructors' check-in/out times. It provides a straightforward solution for businesses to manage attendance efficiently. The system supports various types of users, including students, instructors, employees, supervisors, and security personnel.

## Technologies Used

- ASP.NET Core MVC
- SQL Server
- Entity Framework Core (Code First)
- HTML
- JavaScript
- jQuery
- Bootstrap

![Screenshot 2024-05-20 103937](https://github.com/Ahmad-Esam12398/MVC-Attendance-System/assets/90632545/893fe34d-f321-41d0-a430-0384a559f035)
![Screenshot 2024-05-20 103913](https://github.com/Ahmad-Esam12398/MVC-Attendance-System/assets/90632545/84b78e10-53a9-4a55-978c-8c182e948fec)
![Screenshot 2024-05-20 103732](https://github.com/Ahmad-Esam12398/MVC-Attendance-System/assets/90632545/440d57f0-6f75-491d-ad05-d0403da1dc82)
![ProjectScreen](https://github.com/Ahmad-Esam12398/MVC-Attendance-System/assets/90632545/f3f2d436-0235-4cb9-90b9-9acb357b3b07)

## Main Features

1. **Registration**:
   - Register students, instructors, and employees.
   - Employees can be of type student affairs or security.

2. **User Management**:
   - Manage profiles for students, employees, and instructors.
   - Students can view their data and attendance.
   - Instructors can view their data.

3. **Student Management**:
   - Perform CRUD operations on student data.
   - Manage programs (PTP, ITP, ST), intakes, and tracks.
   - Each track can be active or inactive.

4. **Employee and Instructor Department Management**:
   - Perform CRUD operations on department data.
   - Assign a supervisor for each track from instructors.

5. **Permission Requests**:
   - Students can request permissions for being late or absent.
   - Permissions are accepted or rejected by track supervisors.

6. **Attendance Recording**:
   - Record daily attendance of students, including check-in and check-out times.

7. **Schedule Management**:
   - Track supervisors can record student schedules.
   - Utilize schedules and attendance records to identify late students, absent students, and students who attended on time.

## Installation and Usage

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/AttendanceTimeTrackingSystem.git
