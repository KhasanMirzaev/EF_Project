using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keep_Calm_Learn_CSHARP.Models
{
    internal class Teacher
    {
        public Teacher()
        {
            this.Students = new List<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        public List<Student> Students { get; set; }
    }
}
