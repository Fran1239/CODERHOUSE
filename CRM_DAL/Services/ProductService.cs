using CRM_DAL.Database;
using CRM_DAL.Models;

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
        public async Task<bool> CreateProduct(string nombre, int stock, string description, decimal prices, decimal saleprices)
        {
            try
            {
                Product newProduct = new Product();

                newProduct.Names = nombre;
                newProduct.Stock = stock;
                newProduct.Descriptions = description;
                newProduct.Prices = prices;
                newProduct.SalePrices = saleprices;

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