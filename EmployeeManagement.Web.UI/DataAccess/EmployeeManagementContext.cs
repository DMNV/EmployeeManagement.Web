using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using EmployeeManagement.Web.UI.Models;

namespace EmployeeManagement.Web.UI.DataAccess
{
    public class EmployeeManagementContext : DbContext
    {
        public DbSet<Employee> EmployeeDbSet { get; set; }
        public DbSet<County> CountyDbSet { get; set; }
        public DbSet<City> CityDbSet { get; set; }
        public DbSet<Salary> SalaryDbSet { get; set; }

        public EmployeeManagementContext():base("EmployeeManagementContext")
        {
               
        }
    }
}