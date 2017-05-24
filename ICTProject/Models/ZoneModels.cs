using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ICTProject.Models
{
    public class ZoneModels : ApplicationDbContext
    {
        public ZoneModels()
        {

        }
        public DbSet<Zone> Zones { get; set; }
    }

    public class Zone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Director { get; set; }
        public string Goal { get; set; }
    }
}