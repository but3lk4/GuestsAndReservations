﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using GuestAndReservations.Models;

namespace GuestAndReservations.Dtos
{
    public class GuestDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string SurName { get; set; }
        [Required]
        public string EMail { get; set; }
        [Required]
        public int ID { get; set; }

        public DateTime? DateOfBirth { get; set; }
        public int ZipCode { get; set; }

        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

    }
}