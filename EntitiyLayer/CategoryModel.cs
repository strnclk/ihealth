using Microsoft.CodeAnalysis.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class CategoryModel
    {
        [Key]
        public int CategoryID { get; set; }
        public string? Thumbnail { get; set; }
        public string? Image { get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }
        public string? ShortText { get; set; }
        public List<ProductModel>? Products { get; set; }
        public bool Status { get; set; }

    }
}
