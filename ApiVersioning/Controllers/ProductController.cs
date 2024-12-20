using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers
{
    [ApiController]
    [ApiVersion(1)]
    [ApiVersion(2)]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private static readonly string[] ProductsV1 = new[]
        {
            "Car", "Phone", "Plane"
        };

        private static readonly string[] ProductsV2 = new[]
        {
            "Desk", "Chair", "Book"
        };

        [MapToApiVersion(1)]
        [HttpGet("Products")]
        public IEnumerable<string> Get()
        {
            return ProductsV1.ToList();

        }

        [MapToApiVersion(2)]
        [HttpGet("Products")]
        public IEnumerable<string> GetV2()
        {
            return ProductsV2.ToList();
        }
    }
}
