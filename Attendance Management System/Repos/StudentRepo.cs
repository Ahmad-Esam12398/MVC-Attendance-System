using Attendance_Management_System.Data;
using Attendance_Management_System.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security;

namespace Attendance_Management_System.Repos
{
    public class StudentRepo : IStudentRepo
    {
        IitiContext db;
        public StudentRepo(IitiContext _db)
        {
            db = _db;
        }

        public void CreatePermission(Permission permission)
        {
           db.Permissions.Add(permission);
           // db.SaveChanges();
        }

        public void DeletePermission(string stdID,DateTime permissionDate)
        {
            var permission=PermissionDetails(stdID,permissionDate);
            db.Permissions.Remove(permission);
        }

        public List<Attendance> Get_Student_Attendances_By_Id(string stdID)
        {
            throw new NotImplementedException();
        }

        public List<Permission> Get_Student_Permissions_By_Id(string StdID)
        {
            return db.Permissions.Where(x=>x.StudentId==StdID).ToList();
        }

        public Permission PermissionDetails(string stdID, DateTime permissionDate)
        {
            return db.Permissions.Where(x => x.StudentId == stdID && x.DateCreated == permissionDate).FirstOrDefault();
        }


            public void UpdatePermission(Permission permission)
        {
            var permission_In_Data=db.Permissions.FirstOrDefault(p=>p.StudentId==permission.StudentId&&p.DateCreated==permission.DateCreated);
            if (permission_In_Data != null)
            {
                permission_In_Data.BodyOfDescription = permission.BodyOfDescription;
                permission_In_Data.Reason = permission.Reason;
            }
            
        }
    }
}
