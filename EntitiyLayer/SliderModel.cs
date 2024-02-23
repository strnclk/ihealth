using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class SliderModel
    {
        [Key]
        public int SliderID { get; set; }
        public string? SliderImageOne { get; set; }
        public string? SliderImageTwo { get; set; }
        public string? SliderImageThree { get; set; }
        public string? Row { get; set; }
        public bool Status { get; set; }
    }
}
