using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trash_Colllector.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
        public string pickUpDay { get; set; }

    }
}
