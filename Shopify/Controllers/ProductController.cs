using Microsoft.AspNetCore.Mvc;
using Shopify.Components.Services.CategoryService;
using Shopify.Components.Services.ProductService;

namespace Shopify.Controllers
{
    public class ProductController : Controller
    {
        public IProductService ProductService { get; }
        public ProductController(IProductService productService)
        {
            ProductService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(ProductService.Products.ToList());

        }
    }
}
