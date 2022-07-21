using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopeeFoodBE.BLL.IServices;

namespace ShopeeFoodBE.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _icategoryservice;
        public CategoryController(ICategoryService icategoryservice)
        {
            _icategoryservice = icategoryservice;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategory()
        {
            var category = await _icategoryservice.GetAllCategory();
            return Ok(category);
        }
    }
}
