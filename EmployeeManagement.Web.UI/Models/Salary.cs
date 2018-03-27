using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace EmployeeManagement.Web.UI.Models
{
   
    [Table("Salary")]
    public class Salary
    {
        [Key]
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Discription { get; set; }
    }
}
