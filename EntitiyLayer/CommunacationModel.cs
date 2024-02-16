using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class CommunacationModel
    {
        [Key]
        public int CommunacationID { get; set; }
        public string? Image { get; set; }
        public string? Title { get; set; }
        public string? ShortText { get; set; }
        public string? Icon { get; set; }
    }
}
