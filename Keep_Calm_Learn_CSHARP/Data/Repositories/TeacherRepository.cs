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
    internal class TeacherRepository : ITeacherRepository
    {
        private AppDbContext appDbContext = new AppDbContext();
        //public TeacherRepository(AppDbContext appDbContext)
        //{
        //    this.appDbContext = appDbContext;   
        //}

        public Teacher Create(Teacher teacher)
        {
            var newTeacher = appDbContext.Teachers.Add(teacher);

            appDbContext.SaveChanges();

            return newTeacher.Entity;

        }

        public bool Delete(int id)
        {
            var teacher = appDbContext.Teachers.FirstOrDefault(p => p.Id == id);
            if (teacher == null)
                return false;

            appDbContext.Teachers.Remove(teacher);

            appDbContext.SaveChanges();

            return true;

        }

        public Teacher Get(int id)
        {
            return appDbContext.Teachers.Include(u => u.Students).FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Teacher> GetAll()
        {
            // .Include(u=>u.Address) ==> Include orqali "Teacher"ga "Address"ni ulab qo`y(degani ekan) 
            return appDbContext.Teachers.Include(u => u.Students);
        }

        public Teacher Update(int id, Teacher teacher)
        {
            var exitingTeacher = appDbContext.Teachers.FirstOrDefault(p => p.Id == id);

            if (exitingTeacher is null)
                return null;


            exitingTeacher.Name = teacher.Name;

            var editedTeacher = appDbContext.Teachers.Update(exitingTeacher);

            appDbContext.SaveChanges();

            return exitingTeacher;
        }
    }
}
