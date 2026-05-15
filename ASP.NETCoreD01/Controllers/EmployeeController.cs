using ASP.NETCoreD01.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreD01.Controllers
{
    public class EmployeeController : Controller
    {
        /*------------------------------------------------------------------*/
        // DataBase
        static List<Employee> employees = new List<Employee>()
        {
            new Employee { Id = 1, Name = "Ahmed", Age = 26 , Salary = 1234 },
            new Employee { Id = 2, Name = "Mohamed", Age = 36 , Salary = 2234 },
            new Employee { Id = 3, Name = "Sara", Age = 46 , Salary = 4234 },
            new Employee { Id = 4, Name = "Omar", Age = 25 , Salary = 5234 },
            new Employee { Id = 5, Name = "Ali", Age = 23 , Salary = 6234 },
            new Employee { Id = 6, Name = "Mai", Age = 36 , Salary = 7234 },
            new Employee { Id = 7, Name = "Ramy", Age = 49 , Salary = 8234 },
            new Employee { Id = 8, Name = "Hamada", Age = 18 , Salary = 9234 },
            new Employee { Id = 9, Name = "Hatem", Age = 26 , Salary = 10234 },
            new Employee { Id = 10, Name = "Osama", Age = 25 , Salary = 17234 },
        };
        /*------------------------------------------------------------------*/
        // Get All Employees
        public IActionResult GetAll()
        {
            return View(employees);
        }
        /*------------------------------------------------------------------*/
        // id = 1
        // Model Binding
        // Set empId
        // Get By Id
        //[Route("{empid:int}")]
        public IActionResult GetById(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }
        /*------------------------------------------------------------------*/
    }
}
