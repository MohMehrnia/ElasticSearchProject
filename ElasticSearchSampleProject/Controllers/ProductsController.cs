using ElasticSearchSampleProject.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ElasticSearchSampleProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IProductService productService) : ControllerBase
    {
        [HttpGet("search")]
        public async Task<IActionResult> SearchProducts([FromQuery] string term)
        {
            var results = await productService.IndexProductsAsync(term);
            return Ok(results);
        }
    }
}