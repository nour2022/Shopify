using Shopify.Models;

namespace Shopify.Components.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        void LoadProducts();
        string GetPrice(int id);
    }
}
