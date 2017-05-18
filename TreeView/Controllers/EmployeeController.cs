using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreeView.Models;
//using InterviewTask.Models;
namespace TreeView.Controllers
{
	public class EmployeeController : Controller
	{
        public static readonly List<Employee> _Employees = new List<Employee>{
            new Employee {Id=1,Name="Mohamed",ManagerId=null},
            new Employee {Id=2,Name="Ahmed",ManagerId=1},
            new Employee {Id=3,Name="Hossam",ManagerId=2},
            new Employee {Id=4,Name="Ossama",ManagerId=1},
            new Employee {Id=5,Name="Hafez",ManagerId=7},
            new Employee {Id=6,Name="Mostafa",ManagerId=3},
            new Employee {Id=7,Name="Saad",ManagerId=2},
        };
		//
		// GET: /Employee/
		public ActionResult Index()
		{
            EmployeesViewModel empsVM = new EmployeesViewModel {Employees=_Employees };
			return View(empsVM);
			
		}
	}
}