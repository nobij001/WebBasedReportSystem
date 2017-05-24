using ICTProject.Models.DBC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICTProject.Data
{
    public class TestData
    {
        public static List<Zone> getZones()
        {
            List<Zone> zones = new List<Zone>()
            {
                new Zone()
                {
                    ZoneId = 1,
                    ZoneName = "Oceanic",
                    ZoneDirector = "Thomas Jackson",
                    ZoneGoal = "Testing Zone 1."
                },
                new Zone()
                {
                    ZoneId = 2,
                    ZoneName = "Indonesia",
                    ZoneDirector = "Ian Nobes",
                    ZoneGoal = "Testing Zone 2."
                },
                new Zone()
                {
                    ZoneId = 3,
                    ZoneName = "Europe",
                    ZoneDirector = "Jordan Nguyen",
                    ZoneGoal = "Testing Zone3."
                },
            };
            return zones;
        }
        public static List<Region> getRegions(DbcContext context)
        {
            List<Region> regions = new List<Region>() {
                new Region
                {
                    RegionId = 1,
                    RegionName = "Sydney",
                    RegionManager = "Thomas Jackson",
                    ZoneId = context.Zones.Find("Oceanic")
                },
                new Region
                {
                    RegionId = 2,
                    RegionName = "Adelaide",
                    RegionManager = "Ian Nobes",
                    ZoneId = context.Zones.Find("Oceanic")
                },
                new Region
                {
                    RegionId = 3,
                    RegionName = "Melbourne",
                    RegionManager = "Jordan Nguyen",
                    ZoneId = context.Zones.Find("Oceanic")
                },
            };
            return regions;
        }
    }
}