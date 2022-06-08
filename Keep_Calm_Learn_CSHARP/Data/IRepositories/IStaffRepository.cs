using Keep_Calm_Learn_CSHARP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keep_Calm_Learn_CSHARP.Data.IRepositories
{
    internal interface IStaffRepository
    {
        Staff Create (Staff staff);
        IEnumerable<Staff> GetAll ();
        Staff Get (int id);
        bool Delete (int id);
        Staff Update(int id, Staff staff);
    }
}
