using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi_lacture_4.Data;

namespace webapi_lacture_4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
       public List<Master> masters()
        {
            List<Master> list = new List<Master>()
            {
                new Master(){ Id = 1, Name = "Nayan" , Description = "Hi i'm Nayan"}
            };
            return list;
        }
     
    }

    
}
