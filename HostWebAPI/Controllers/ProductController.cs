using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HostWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("list")]
        public IDictionary<int, string> Get()
        {
            IDictionary<int, string> list = new Dictionary<int, string>();
            list.Add(1, "IPhone");
            list.Add(2, "Laptop");
            list.Add(3, "Samsung TV");
            return list;
        }
    }
}
