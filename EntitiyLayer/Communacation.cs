using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Communacation
    {
        [Key]
        public int ID { get; set; }
        public string? Image { get; set; }
        public string? Title { get; set; }
        public string? ShortText { get; set; }
        public string? Icon { get; set; }
    }
}
