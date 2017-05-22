using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TreeView.Models
{
    public class Employee
    {
         
        public int Id { get; set; }
        
        [Required]
        [Display(Name="Employee Name ")]
        public String Name { get; set; }
        public int? ManagerId { get; set; }

        
    }

    
}