using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApp.Models;
using DemoApp.ViewModel;
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

        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public ViewResult Index()
        {
            HomeIndexViewModel homeIndexViewModel = new HomeIndexViewModel()
            {
                Employee = employeeList.GetEmployee(1),
                PageTitle = "Index"

            };
            return View(homeIndexViewModel);
        }

        public ViewResult Details()
        {
            var model= employeeList.GetAllEmployees();
            return View(model);

        }
    }
}