using CRM_DAL.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : Controller
    {
        private SalesService salesData;

        public SaleController()
        {
            this.salesData = new SalesService();
        }

        [HttpGet]
        public async Task<IActionResult> CreateSale()
        {
            return Ok();
        }
    }
}
