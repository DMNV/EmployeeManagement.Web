using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeManagement.Web.UI.Models;

namespace EmployeeManagement.Web.UI.ViewModels
{
    public class EmployeeViewModel
    {
        public List<Employee> EmployeeList { get; set; }
        public List<Salary> SalaryList { get; set; }
        public List<County> CountyList { get; set; }
        public List<City> CityList { get; set; }

        public Employee Employee { get; set; }

        public SelectList CountySelectList { get; set; }
        public SelectList CitySelectList { get; set; }
        public SelectList SalarySelectList { get; set; }

    }
}