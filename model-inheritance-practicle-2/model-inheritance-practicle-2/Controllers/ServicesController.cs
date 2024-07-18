using Microsoft.AspNetCore.Mvc;
using model_inheritance_practicle_2.Data;
using model_inheritance_practicle_2.Models;
using model_inheritance_practicle_2.Repositories;

namespace model_inheritance_practicle_2.Controllers
{
    public class ServicesController : Controller
    {
        private readonly DataContext _datacontext;
        private readonly ServiceRepositories _servicerepo;

        public ServicesController(DataContext datacontext)
        {
            _datacontext = datacontext;
            _servicerepo = new ServiceRepositories(_datacontext);
        }

        public IActionResult Index()
        {

            ServiceModelList serviceModelList = new ServiceModelList();
            serviceModelList.serviceList = _servicerepo.Services();

            return View(serviceModelList);
        }
        [HttpPost]
        public IActionResult serviceadd(ServiceModelList service)
        {

            _servicerepo.Serviceadd(service);

            return RedirectToAction("Index");
        }
    }
}
