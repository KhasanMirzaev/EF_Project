using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keep_Calm_Learn_CSHARP.Models
{
    internal class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Home { get; set; }
        [ForeignKey(nameof(Staff))]
        public int StaffId { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
