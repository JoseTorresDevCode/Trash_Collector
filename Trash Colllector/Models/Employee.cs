using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trash_Colllector.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        
        public string firstName { get; set; }
        [DisplayName("First Name")]
        public string lastName { get; set; }
        [DisplayName("Last Name")]
        public string zipCode { get; set; }

        [ForeignKey("IdentityUser")]

        public string IndentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
