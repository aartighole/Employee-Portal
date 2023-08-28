using EmployeePortal.DAL;
using EmployeePortal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmployeePortal.Controllers
{
    public class HomeController: Controller
    {
       /* private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/

        private readonly ApplicationDbContext _applicationDbContext;
        public HomeController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegisterEmployee()
        {
            return View();
        }
        public IActionResult GetEmployee() //to display retrieve info from our "employees" Table 
        {
            var employeeList = _applicationDbContext.Employees.ToList();//OR you can write following way too
           // IEnumerable<Employee_new> employeeList = _applicationDbContext.Employees; 
            
            return View(employeeList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {   
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}