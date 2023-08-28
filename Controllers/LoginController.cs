using EmployeePortal.DAL;
using EmployeePortal.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;

namespace EmployeePortal.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public LoginController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult AuthenticateUser()
        //{
        //    var users = _applicationDbContext.LoginDetails;
        //    return null;
        //    //return RedirectToAction("Home", "Index");
        //}

        [HttpPost]
        public IActionResult AuthenticateUser(Login login)
        {
            var log = _applicationDbContext.LoginDetails
                .Where(x => x.Email == login.Email && x.Password == login.Password)
                .FirstOrDefault();

            if (log == null)
            {
                return Unauthorized("Login Failed");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }



}
