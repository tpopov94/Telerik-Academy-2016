using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanySampleDataImporter.Data;

namespace CompanySampleDataImporter.Importer.Importers
{
    public class EmployeesImporter : IImporter
    {
        private const int NumberOfEmployees = 5000;

        public Action<CompanyEntities, TextWriter> Get
        {
            get
            {
                return (db, tr) =>
                {
                    var departmentsId = db.Departments
                        .Select(d => d.Id)
                        .ToList();

                    for (int i = 0; i < NumberOfEmployees; i++)
                    {
                        var randomDepartment = RandomGenerator.GetRandomNumber(0, departmentsId.Count - 1);

                        var randomDepartmentId = departmentsId[randomDepartment];

                        db.Employees.Add(new Employee
                        {
                            FIrstName = RandomGenerator.GetRandomString(5, 20),
                            LastName = RandomGenerator.GetRandomString(5, 20),
                            YearSalary = RandomGenerator.GetRandomNumber(50000, 200000),
                            DepartmentId = randomDepartmentId
                        });

                        if (i % 10 == 0)
                        {
                            tr.Write(".");
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
                return $"Importing employees";
            }
        }

        public int Order
        {
            get
            {
                return 2;
            }
        }
    }
}
