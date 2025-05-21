using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SrinidhiQuickComProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet("GetAllCategories")]

        public void GetAllCategories()
        {

        }
    }
}
