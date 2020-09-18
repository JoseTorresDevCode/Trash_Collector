using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trash_Colllector.Models
{
    public class Employee
    {
        [Key]
        public int employeeId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
