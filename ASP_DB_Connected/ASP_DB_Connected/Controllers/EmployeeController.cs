using ASP_DB_Connected.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASP_DB_Connected.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> employee = new List<Employee>{
                new Employee() { Id = 1, FirstName = "John", LastName = "Irvin" } ,
                new Employee() { Id = 2, FirstName = "Steve",  LastName = "Stivenson" } ,
                new Employee() { Id = 3, FirstName = "Bill",  LastName = "Brown" } ,
                new Employee() { Id = 4, FirstName = "Ram" , LastName = "Richardson" } ,
                new Employee() { Id = 5, FirstName = "Ron" , LastName = "Piterson" } ,
                new Employee() { Id = 4, FirstName = "Chris" , LastName = "Tven" } ,
                new Employee() { Id = 4, FirstName = "Rob" , LastName = "Ford" } };
            ViewBag.MyBag = "Employee Form";
            return View(employee);
        }
    }
}
