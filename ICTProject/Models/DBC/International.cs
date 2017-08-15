using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ICTProject.Models.DBC
{
    public class Internationals
    {
        [Key]
        public int InternationalId { get; set; }
        public string Continent { get; set; }
    }
}