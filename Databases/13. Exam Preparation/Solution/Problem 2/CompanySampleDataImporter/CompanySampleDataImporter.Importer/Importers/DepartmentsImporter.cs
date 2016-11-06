using System;
using System.IO;

using CompanySampleDataImporter.Data;

namespace CompanySampleDataImporter.Importer.Importers
{
    public class DepartmentsImporter : IImporter
    {
        private const int NumberOfDepartments = 1000; 

        public Action<CompanyEntities, TextWriter> Get
        {
            get
            {
                return (db, tr) =>
                {
                    for (int i = 0; i < NumberOfDepartments; i++)
                    {
                        db.Departments.Add(new Department
                        {
                            Name = RandomGenerator.GetRandomString(10, 50)                            
                        });

                        if (i % 10 == 0)
                        {
                            tr.Write('.');
                        }

                        if (i % 100 == 0)
                        {
                            db.SaveChanges();
                            db.Dispose();
                            db = new CompanyEntities();
                        }
                    }

                    db.SaveChanges();
                };
            }
        }

        public string Message
        {
            get
            {
                return $"Importing departments";
            }
        }

        public int Order
        {
            get
            {
                return 1;
            }
        }
    }
}
