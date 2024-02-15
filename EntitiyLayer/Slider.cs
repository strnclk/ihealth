using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Slider
    {
        [Key]
        public int ID { get; set; }
        public string? SliderImage { get; set; }
        public string? Row { get; set; }
        public bool Status { get; set; }
    }
}
