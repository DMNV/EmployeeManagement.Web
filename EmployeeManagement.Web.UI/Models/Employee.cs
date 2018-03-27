using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace EmployeeManagement.Web.UI.Models
{
   
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public virtual int CountyId { get; set; }

        [Required]
        public virtual int CityId { get; set; }

        [Required]
        public virtual int SalaryId { get; set; }

        public int ContactNo { get; set; }

        [EmailAddress]
        public string Email { get; set; }
       
        public virtual IList<County> Counties { get;set; }
        public virtual IList<City> Cities { get; set; }
        public virtual IList<Salary> Salaries { get; set; }

    }
}
