using Ecommerce.ProductService.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.ProductService.Controllers
{
 [ApiController]
 [Route("[controller]")]
 public class ProductController(ILogger<ProductController> logger) : ControllerBase
 {
  private readonly ILogger<ProductController> _logger = logger;

  [HttpGet(Name = "GetProducts")]
  public IEnumerable<Product> Get()
  {
   return Enumerable.Range(1, 5).Select(index => new Product
   {
    Id = index,
    Description = $"Description-{index}",
    Name = $"Name-{index}",
    Price = 10,
   })
   .ToArray();
  }
 }
}
