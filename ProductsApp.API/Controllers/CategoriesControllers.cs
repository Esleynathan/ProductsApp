using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductsApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesControllers : ControllerBase
    {

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }


    }
}
