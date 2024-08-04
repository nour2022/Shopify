using Shopify.Models;

namespace Shopify.Components.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category> categories { get; set; }
        void LoadCategories();
    }
}
