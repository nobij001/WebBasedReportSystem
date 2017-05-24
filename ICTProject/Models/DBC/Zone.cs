using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ICTProject.Models.DBC
{
    public class Zone
    {
        [Key]
        public int ZoneId { get; set; }
        public string ZoneName { get; set; }
        public string ZoneDirector { get; set; }
        public string ZoneGoal { get; set; }

        public List<Region> Region { get; set; }
    }
}