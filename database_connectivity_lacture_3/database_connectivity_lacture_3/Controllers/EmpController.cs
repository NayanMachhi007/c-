using database_connectivity_lacture_3.Data;
using database_connectivity_lacture_3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace database_connectivity_lacture_3.Controllers
{
    public class EmpController : Controller
    {
        private readonly DataContext _dataContext;

        public EmpController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            var data = _dataContext.employees.ToList();
            return View(data);
        }


        [HttpGet]
        public IActionResult empadd()
        {

           
            return View();
        }


        [HttpPost]

        public IActionResult empadd(EmployeeModel emps)
        {
            EmployeeMst employeeMst = new EmployeeMst()
            {
                id = emps.Id,
                name = emps.Name,
            };


            _dataContext.employees.Add(employeeMst);
            _dataContext.SaveChanges();

            return RedirectToAction("index");

        }




        [HttpGet]
        public IActionResult empedit(int id)
        {
           var data= _dataContext.employees.Find(id);
            return View(data);
        }


        [HttpPost]
        public IActionResult empedit(EmployeeMst emp)
        {

            _dataContext.employees.Update(emp);
            _dataContext.SaveChanges();

            return RedirectToAction("empedit");

        }


    }
}
