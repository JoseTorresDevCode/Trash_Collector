﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
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
        public string lastName { get; set; }
        public string address { get; set; }
        public string state { get; set; }
        public int zipCode { get; set; }
        public string pickUpDay { get; set; }

        [ForeignKey("IdentityUser")]

        public string IndentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }


    }
}
