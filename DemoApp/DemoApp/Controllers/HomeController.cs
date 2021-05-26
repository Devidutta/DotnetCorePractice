using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository employeeList;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            employeeList = employeeRepository;
        }
        public JsonResult Index()
        {
            Employee employee= employeeList.GetEmployee(1);
            return Json(employee);
        }
    }
}