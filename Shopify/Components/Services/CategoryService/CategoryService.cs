using Shopify.Data;
using Shopify.Models;

namespace Shopify.Components.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly ShopifyDBContext dBContext;

        public CategoryService(ShopifyDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
        public List<Category> categories { get; set ; } = new List<Category>();

        public void LoadCategories()
        {
            categories = dBContext.Categories.ToList();
        }
    }
}
