using Keep_Calm_Learn_CSHARP.Data.Context;
using Keep_Calm_Learn_CSHARP.Data.IRepositories;
using Keep_Calm_Learn_CSHARP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keep_Calm_Learn_CSHARP.Data.Repositories
{
    
    internal class StaffRepository : IStaffRepository
    {

        private AppDbContext appDbContext = new AppDbContext();
        //public StaffRepository(AppDbContext appDbContext)
        //{
        //    this.appDbContext = appDbContext;   
        //}

        public Staff Create(Staff staff)
        {
            var newStaff = appDbContext.Staffs.Add(staff);
            
            appDbContext.SaveChanges();

            return newStaff.Entity;
            
        }

        public bool Delete(int id)
        {
            var staff = appDbContext.Staffs.FirstOrDefault(p => p.id == id);
            if (staff == null)
                return false;

            appDbContext.Staffs.Remove(staff);

            appDbContext.SaveChanges();

            return true;

        }

        public Staff Get(int id)
        {
            // .Include(u=>u.Address) ==> Include orqali "Staff"ga "Address"ni ulab qo`y(degani ekan)
            return appDbContext.Staffs.Include(u => u.Address).FirstOrDefault(p => p.id == id);
        }

        public IEnumerable<Staff> GetAll()
        {
            // .Include(u=>u.Address) ==> Include orqali "Staff"ga "Address"ni ulab qo`y(degani ekan) 
            return appDbContext.Staffs.Include(u=>u.Address);
        }

        public Staff Update(int id, Staff staff)
        {
            var exitingStaff = appDbContext.Staffs.FirstOrDefault(p => p.id == id);

            if (exitingStaff is null)
                return null;


            exitingStaff.firstname = staff.firstname;
            exitingStaff.lastname = staff.lastname;
            exitingStaff.email = staff.email;
            exitingStaff.age = staff.age;

            var editedStaff = appDbContext.Staffs.Update(exitingStaff);

            appDbContext.SaveChanges();

            return exitingStaff;
        }
    }
}
