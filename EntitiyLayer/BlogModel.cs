using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class BlogModel
    {
        [Key]
        public int? BlogID { get; set; }
        public string? Title{ get; set; }
        public string? Text { get; set; }
        public string? ShortText { get; set; }
        public string? Image { get; set; }
        public string? Thumbnail { get; set; }
        public DateTime? ReleaseDate { get; set; }
    }
}
