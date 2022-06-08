using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keep_Calm_Learn_CSHARP.Models
{
    internal class Student
    {
        public Student()
        {
            this.Teachers = new List<Teacher>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey(nameof(Teacher))]
        public int TeacherId { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
