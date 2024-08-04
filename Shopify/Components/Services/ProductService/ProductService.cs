using Shopify.Data;
using Shopify.Models;

namespace Shopify.Components.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ShopifyDBContext dBContext;

        public List<Product> Products { get ; set; } = new List<Product>();
        public ProductService(ShopifyDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public string GetPrice(int id)
        {
           
                if (Products[id-1].discount > 0)
                    return Convert.ToString(Products[id-1].Price - (Products[id].Price * Products[id].discount));
                return Convert.ToString(Products[id-1].Price);
            
        }

        public void LoadProducts()
        {
            
        Products = dBContext.Products.ToList();
    }
    }
}
