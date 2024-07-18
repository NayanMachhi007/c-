using database_task_21_05_2024.Data;
using Microsoft.AspNetCore.Mvc;

namespace database_task_21_05_2024.Controllers
{
    public class ServicesController : Controller
    {
        private readonly DataContext _dataContext;

        public ServicesController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            var Data = _dataContext.servicesMsts.ToList();
            return View(Data);
        }
    }
}
