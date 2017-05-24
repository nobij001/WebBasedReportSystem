namespace ICTProject.Migrations.DBC
{
    using Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ICTProject.Data.DbcContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\DBC";
        }

        protected override void Seed(ICTProject.Data.DbcContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
           // context.Zones.AddOrUpdate(
           //     z => new { z.Id, z.ZoneName }, TestData.getZones().ToArray());
            //context.SaveChanges();
//
 //           context.Regions.AddOrUpdate(
  //              r => new { r.Id, r.RegionName, r.RegionManager }, TestData.getRegions(context).ToArray());
        }
    }
}
