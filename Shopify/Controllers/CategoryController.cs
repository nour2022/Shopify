using Microsoft.AspNetCore.Mvc;
using Shopify.Components.Services.CategoryService;
using Shopify.Models;

namespace Shopify.Controllers
{
    public class CategoryController : ControllerBase
    {
        public CategoryController(ICategoryService categoryService)
        {
            CategoryService = categoryService;
        }

        public ICategoryService CategoryService { get; }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
           return Ok(CategoryService.categories.ToList());

        }
    }
}
