﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class DTOUser
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string UserName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string UserPicture { get; set; }


  

    }
}
