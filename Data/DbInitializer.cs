using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proiect_MPA.Models;
namespace Proiect_MPA.Data
{
    public class DbInitializer
    {
        public static void Initialize(MagazinContext context)
        {
            context.Database.EnsureCreated();
            if (context.Employees.Any())
            {
                return; // BD a fost creata anterior
            }
            var employees = new Employee[]
            {
new Employee{Name="Popescu Maria",Adress="Cluj-Napoca, strada Aurel Vlaicu, numarul 4 ",Salary="2500 lei"},
new Employee{Name="Popa Florin",Adress="Cluj-Napoca, Nicolae Balcescu, numarul 2 ",Salary="2100 lei"},
new Employee{Name="Marinescu Iulia", Adress="Cluj-Napoca, strada Horea, numarul 5 ",Salary="2700 lei"},
            };
            foreach (Employee s in employees)
            {
                context.Employees.Add(s);
            }
            context.SaveChanges();
            var products = new Product[]
            {
new Product{ProductID=1050,Name="Paine",Price=Decimal.Parse("4")},
new Product{ProductID=1045,Name="Faina",Price=Decimal.Parse("5")},
new Product{ProductID=1040,Name="Zahar",Price=Decimal.Parse("3")},
            };
            foreach (Product c in products)
            {
                context.Products.Add(c);
            }
            context.SaveChanges();
            var stores = new Store[]
            {
new Store{EmployeeID=1,ProductID=1050},
new Store{EmployeeID=3,ProductID=1045},
new Store{EmployeeID=1,ProductID=1040},
new Store{EmployeeID=2,ProductID=1050},
            };
            foreach (Store e in stores)
            {
                context.Stores.Add(e);
            }
            context.SaveChanges();
        }
    }
}