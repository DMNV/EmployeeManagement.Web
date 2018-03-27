namespace EmployeeManagement.Web.UI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using EmployeeManagement.Web.UI.DataAccess;
    using EmployeeManagement.Web.UI.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeManagementContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(EmployeeManagementContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.EmployeeDbSet.AddOrUpdate(e => e.Name,
                new Employee { Name = "Nadeera", Address = "Ruwanwella", CityId = 1, ContactNo = 0719138280, CountyId = 1, Email = "nadeer@gmail.com"},
                new Employee { Name = "Ruwan", Address = "Colombo", CityId = 1, ContactNo = 0719138280, CountyId = 1, Email = "nadeer@gmail.com" }
                //,
                //new Employee { Name = "Ruwan", Address = "Colombo", CityId = 1, ContactNo = 0719138280, CountyId = 1, Email = "nadeer@gmail.com", SalaryId = 1 }
                );

            context.SalaryDbSet.AddOrUpdate(e => e.Amount,
               new Salary { Amount = 10000M, Discription = "normal" }
               //,
               //new Salary { Amount = 20000M, Discription = "normal" },
               //new Salary { Amount = 30000M, Discription = "normal" },
               //new Salary { Amount = 40000M, Discription = "normal" }
               );

            context.CountyDbSet.AddOrUpdate(e => e.Name,
               new County { Name = "Sri Lanks" }
               //,
               //new County { Name = "India" },
               //new County { Name = "USA" }
               );

            context.CityDbSet.AddOrUpdate(e => e.Name,
              new City { Name = "Kandy" }
              //,
              //new City { Name = "Kegall" },
              //new City { Name = "Londan" },
              //new City { Name = "Dilli" },
              //new City { Name = "Malee" }
              );

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
