using ICTProject.Models.DBC;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ICTProject.Data
{
    public class DbcContext: DbContext
    {
        public DbcContext(): base("DefaultConnection")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Zone> Zones { get; set; }
        public DbSet<DailyData> DailyData { get; set; }
        public DbSet<SdcDetails> SdcDetails { get; set; }
        public DbSet<SdcNightly> SdcNightly { get; set; }
        public DbSet<Notices> Notices { get; set; }
        public DbSet<Internationals> International { get; set; }
        public DbSet<Positions> Positions { get; set; }
        public DbSet<PDTopics> PDTopics { get; set; }
    }
}