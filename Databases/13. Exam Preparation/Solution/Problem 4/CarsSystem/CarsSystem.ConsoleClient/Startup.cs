using CarsSystem.Data;
using CarsSystem.Data.Migrations;
using System.Data.Entity;
using System.Linq;

namespace CarsSystem.ConsoleClient
{
    public class Startup
    {
        static void Main()
        {
            // Code First
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CarsDbContext, Configuration>());

            // For testing 
            //Database.SetInitializer(new DropCreateDatabaseAlways<CarsDbContext>());
            /* Testing for code first
            var db = new CarsDbContext();

            db.Cars.Count();
            */

            // Json Import

            JsonCarImporter.Import();
        }
    }
}
