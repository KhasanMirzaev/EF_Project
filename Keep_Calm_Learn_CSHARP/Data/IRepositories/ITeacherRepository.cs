using Keep_Calm_Learn_CSHARP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keep_Calm_Learn_CSHARP.Data.IRepositories
{
    internal interface ITeacherRepository
    {
        Teacher Create(Teacher teacher);
        IEnumerable<Teacher> GetAll();
        Teacher Get(int id);
        bool Delete(int id);
        Teacher Update(int id, Teacher teacher);
    }
}
