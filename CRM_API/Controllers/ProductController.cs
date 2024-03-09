using CRM_DAL.Database;
using CRM_DAL.DTO.Prouct_DTO;
using CRM_DAL.DTO.User_DTO;
using CRM_DAL.Models;
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

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] ProductWriteDTO product)
        {
            var isNameTaken = await productData.IsNameTaken(product.Names);
            if (isNameTaken)
            {
                return BadRequest("NAME_ALREADY_EXISTS");
            }

            var response = await productData.LoadProduct(product);

            if (!response)
            {
                return BadRequest("FAIL_CREATING_PRODUCT");
            }
            return Ok("SUCCESSFULLY_PRODUCT_CREATION");
        }

    

    }
}
     