using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string? Image { get; set; }
        public string? Thumbnail { get; set; }
        public string? Text { get; set; }
        public Category CategoryID { get; set; }
        public Category Category { get; set; }
        public double? Price { get; set; }
        public string? ProductWebSite { get; set; }
        public bool Status { get; set; }

    }
}
