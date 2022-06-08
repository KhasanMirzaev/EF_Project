using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keep_Calm_Learn_CSHARP.Models
{
    [Table("Staffs")]
    internal class Staff
    {
        [Column("id")]
        public int id { get; set; }

        [Column("firstname")]
        public string firstname { get; set; }

        [Column("lastname")]
        public string lastname { get; set; }

        [Column("age")]
        public int age { get; set; }

        [Column("email")]
        public string email { get; set; }
        public virtual Address Address { get; set; }
    }
}
