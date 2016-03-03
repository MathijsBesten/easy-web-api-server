namespace Web_API2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using WEB_API2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WEB_API2.Models.WEB_API2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WEB_API2.Models.WEB_API2Context context)
        {
            context.Logs.AddOrUpdate(x => x.Id,
                new Log() { Id = 1, titel = "seed database", auteur = "Mathijs", gemaakt = DateTime.Now, verhaal="Database is seeded with this information", verwijderd = false}
                );
        }
    }
}
