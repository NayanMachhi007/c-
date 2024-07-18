using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class empController : ControllerBase
    {
        [HttpGet]
        public List<Tabletemp> tabletemps()
        {
            List<Tabletemp> emp = new List<Tabletemp>() {
                new Tabletemp(){no = 1 , name = "nayan" , address = "contact" , contact  = "97645"}
                           };
            return emp;
        }

    }
}
