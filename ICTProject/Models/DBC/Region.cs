using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ICTProject.Models.DBC
{
    public class Region
    {
        [Key]
        public int RegionId { get; set; }
        public string RegionName { get; set; }
        public string RegionManager { get; set; }
        
        public Zone ZoneId { get; set; }
    }
}