namespace ArtistSystem.Data.Migrations
{
    using Models;
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<ArtistsDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.ContextKey = "ArtistSystem.Data.ArtistsDbContext";
        }

        protected override void Seed(ArtistsDbContext context)
        {
            // Artists are compared by name 
            context.Artists
                .AddOrUpdate(a => a.Name,
                new Artist
            {
                Name = "Lili Ivanova",
                IsGroup = false,
                Age = 200
            });
        }
    }
}
