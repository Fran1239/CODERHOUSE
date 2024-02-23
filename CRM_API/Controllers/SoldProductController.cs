using CRM_DAL.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoldProductController : Controller
    {
        private SoldProductService soldProductData;

        public SoldProductController()
        {
            this.soldProductData = new SoldProductService();
        }

        [HttpGet]
        public async Task<IActionResult> CreateSoldProduct()
        {
            return Ok();
        }
    }
}
