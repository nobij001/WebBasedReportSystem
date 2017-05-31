using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICTProject.Models.DBC
{
    public class SdcDetails
    {
        public int SdcDetailsId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateAdded { get; set; }
        public int IsTeamCoordinator { get; set; }
        public int IsFullTime { get; set; }
        public Region RegionId { get; set; }
        public Zone ZoneId { get; set; }
    }
}