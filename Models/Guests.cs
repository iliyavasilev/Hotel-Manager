using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Reservation_Manager.Models
{
    public class Guests
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EMail { get; set; }
        public bool Adult { get; set; }
    }
}