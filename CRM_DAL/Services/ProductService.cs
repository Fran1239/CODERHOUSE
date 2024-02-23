using CRM_DAL.Database;
using CRM_DAL.DTO.Prouct_DTO;
using CRM_DAL.Models;
using System.Diagnostics;
using static Azure.Core.HttpHeader;

namespace CRM_DAL.Services
{
    public class ProductService
    {
        private readonly CoderContext _coderContext;

        public ProductService()
        {
            _coderContext = new CoderContext();
        }

        //Metodos:
        //obtenerproducto
        //listarproducto
        //crearproducto
        //modifiicarproducto
        //eliminarproducto
        public async Task<bool> CreateProduct(ProductWriteDTO productWrite)
        {
            try
            {
                Product newProduct = new Product();

                newProduct.Names = productWrite.Names;
                newProduct.Stock = productWrite.Stock;
                newProduct.Descriptions = productWrite.Descriptions;
                newProduct.Prices = productWrite.Prices;
                newProduct.SalePrices = productWrite.SalePrices;

                _coderContext.Products.Add(newProduct);
                await _coderContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}