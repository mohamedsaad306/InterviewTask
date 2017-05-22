using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.ComponentModel;

namespace InterviewTask.Models
{
    public class Employee
    {
        
        public Guid ID { get; set; }
        public string Name { get; set; }
        public int ManagerId { get; set; }

        //public string Title { get; set; }
        //public string UserName { get; set; }
        //public string Password { get; set; }
        //public DateTime DateOfBirth { get; set; }
        //public int NumberOfChildren { get; set; }
    }
}
