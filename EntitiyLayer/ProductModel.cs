using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class ProductModel
    {
        [Key]
        public int ProductID { get; set; }
        public string? Image { get; set; }
        public string? Thumbnail { get; set; }
        public string? Text { get; set; }
        public int CategoryID { get; set; }
        public CategoryModel Category { get; set; }
        public double? Price { get; set; }
        public string? ProductWebSite { get; set; }
        public bool Status { get; set; }

    }
}
