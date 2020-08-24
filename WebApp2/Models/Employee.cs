﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp2.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public DateTime OntimeCreted { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }
        public string Mobile { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public Department Department { get; set; }

        public string DirectManager { get; set; }
    }
}
