﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class ContactInformationModel
    {
        [Key]
        public int ContactInformationID { get; set; }
        public string? InstagramLink { get; set; }
        public string? FacebookLink { get; set; }
        public string? lınkedinLink { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber01 { get; set; }
        public string? PhoneNumber02 { get; set; }
        public string? Address { get; set; }
    }
}
