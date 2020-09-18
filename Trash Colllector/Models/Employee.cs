using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("IdentityUser")]

        public string IndentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
