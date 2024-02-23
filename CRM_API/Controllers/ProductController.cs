using CRM_DAL.DTO.User_DTO;
using CRM_DAL.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private ProductService productData;

        public ProductController()
        {
            this.productData = new ProductService();
        }

        [HttpGet]
        public async Task<IActionResult> CreateProduct()
        {
            return Ok();
        }


    }
}
     