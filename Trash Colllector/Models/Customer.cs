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
        public string firstName { get; set; }
        [DisplayName("First Name")]
        public string lastName { get; set; }
        [DisplayName("Last Name")]
        public string address { get; set; }
        [DisplayName("Address")]
        public string state { get; set; }
        [DisplayName("State")]

        public int zipCode { get; set; }
        [DisplayName("Zip Code")]

        public string pickUpDay { get; set; }
        [DisplayName("Weekly Pick Up Day")]

        public double balance { get; set; }
        [DisplayName("Balance Owed")]

        public string oneTimePickUp { get; set; }
        [DisplayName("One Time Pick UP Day")]



        [ForeignKey("IdentityUser")]

        public string IndentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }


    }
}
