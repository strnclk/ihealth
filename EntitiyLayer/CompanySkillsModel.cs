using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class CompanySkillsModel
    {
        [Key]
        public int CompanyID { get; set; }
        public string? icon { get; set; }
        public int? ValueNumber { get; set; }
        public string? BackGround { get; set; }
        public bool Status { get; set; }
    }
}
