using ArtistSystem.Data;
using ArtistSystem.Data.Migrations;
using ArtistSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtistSystem.ConsoleClient
{
    public class Startup
    {
        public static void Main()
        {
            // To be able to use the Configuration.cs class
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ArtistsDbContext, Configuration>());

            var db = new ArtistsDbContext();

            var artist = new Artist
            {
                Name = "Rammstein",
                IsGroup = true,
                Members = 6
            };

            db.Artists.Add(artist);
            db.SaveChanges();

            Console.WriteLine(db.Artists.Count());
        }
    }
}
