using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Newtonsoft.Json;
using CarsSystem.ConsoleClient.Model;
using CarsSystem.Models;
using CarsSystem.Data;

namespace CarsSystem.ConsoleClient
{
    public static class JsonCarImporter
    {
        private const string JsonFilePathFormat = "/JsonFiles/data.{0}.json";

        public static void Import()
        {
            // Path to directory where the .dll are stored + files 
            var carsToAdd = Directory
                .GetFiles(Directory.GetCurrentDirectory() + "/DataJsonFiles/")
                .Where(f => f.EndsWith(".json"))
                .Select(f => File.ReadAllText(f))
                .SelectMany(str => JsonConvert.DeserializeObject<IEnumerable<JsonCarModel>>(str))
                .ToList();

            // Cities and manufacturers are unique
            var addedCities = new HashSet<string>();
            var addedManufacturers = new HashSet<string>();

            var addedCars = 0;
            var db = new CarsDbContext();

            Console.WriteLine("Adding Cars");
            foreach (var car in carsToAdd)
            {
                if (!addedCities.Contains(car.Dealer.City))
                {
                    var city = new City
                    {
                        Name = car.Dealer.City
                    };

                    db.Cities.Add(city);
                    db.SaveChanges();
                    
                    addedCities.Add(car.Dealer.City);
                }
                
                var manufacturer = car.ManufacturerName;

                if (!addedManufacturers.Contains(manufacturer))
                {
                    var newManufacturer = new Manufacturer
                    {
                        Name = manufacturer
                    };

                    addedManufacturers.Add(manufacturer);

                    db.Manufacturers.Add(newManufacturer);
                    db.SaveChanges();
                }

                // Oother non unique values
                var dealerToAdd = new Dealer
                {
                    Name = car.Dealer.Name
                };

                // Asking the base is slow but dont have other idea
                var dbCity = db.Cities
                    .FirstOrDefault(c => c.Name == car.Dealer.City);
                dealerToAdd.Cities.Add(dbCity);

                var dbManufacturer = db.Manufacturers
                    .FirstOrDefault(m => m.Name == car.ManufacturerName);

                var carToAdd = new Car
                {
                    Manufacturer = dbManufacturer,
                    Dealer = dealerToAdd,
                    Model = car.Model,
                    Price = car.Price,
                    Transmission = (TransimissionType)car.TransmissionType,
                    Year = car.Year

                };

                db.Cars.Add(carToAdd);

                if (addedCars % 100 == 0)
                {
                    Console.Write(".");
                    db.SaveChanges();
                    db.Dispose();
                    db = new CarsDbContext();
                    db.Configuration.AutoDetectChangesEnabled = false;
                }

                addedCars++;
            }

            db.SaveChanges();
            db.Configuration.AutoDetectChangesEnabled = true;
        }
    }
}
