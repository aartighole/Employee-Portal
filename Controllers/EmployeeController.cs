using EmployeePortal.DAL;
using EmployeePortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePortal.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public EmployeeController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IActionResult CreateEmployee()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult CreateEmployee(Employee_new emp) //MethodOverloading
        {
            if (ModelState.IsValid)
            {
                _applicationDbContext.Add(emp);
                _applicationDbContext.SaveChanges();

                return RedirectToAction("GetEmployee", "Home");
            }
             return View(emp);
        }


        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            //LINQ Query
            var emp = _applicationDbContext.Employees.FirstOrDefault(x => x.Id == id);
            if (emp == null)
            {
                return NotFound();
            }

            return View(emp);
        }

        [HttpPost]
        public IActionResult Edit(Employee_new emp)
        {
            if (ModelState.IsValid)
            {
                _applicationDbContext.Update(emp);
                _applicationDbContext.SaveChanges();
                return RedirectToAction("GetEmployee", "Home");
            }

                return View(emp);
        }

        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            //LINQ Query
            var emp = _applicationDbContext.Employees.FirstOrDefault(x => x.Id == id);
            if (emp == null)
            {
                return NotFound();
            }

            return View(emp);
        }

        [HttpPost]
        public IActionResult Delete(Employee_new emp)
        {
            if (ModelState.IsValid)
            {
                _applicationDbContext.Remove(emp);
                _applicationDbContext.SaveChanges();
                return RedirectToAction("GetEmployee", "Home");
            }

            return View(emp);
        }

    }
}
