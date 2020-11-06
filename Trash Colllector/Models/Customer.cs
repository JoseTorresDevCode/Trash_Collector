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
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Address")]
        public string Address { get; set; }

        public string City { get; set; }

        [DisplayName("State")]
        public string State { get; set; }

        [DisplayName("Zip Code")]
        public string ZipCode { get; set; }

        [DisplayName("Weekly Pick Up Day")]
        public DayOfWeek PickUpDay { get; set; }

        [DisplayName("Balance Owed")]
        public double Balance { get; set; }

        [DisplayName("One Time Pick Up Day")]
        public string OneTimePickUp { get; set; }
         
        [DisplayName("Confirmed Pickup")]
        public bool isConfirmed { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

        public double Lat { get; set; }
        public double Long { get; set; }
    }
}
