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
