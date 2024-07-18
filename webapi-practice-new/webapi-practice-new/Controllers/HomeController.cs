using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi_practice_new.Data;

namespace webapi_practice_new.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public List<Master> Masters()
        {
            List<Master> list = new List<Master>()
            {
                new Master(){no = 1 , name ="nayan" , address= "Nayan" , javascript ="dg"}
            };
            return list;
        }
    }
}
