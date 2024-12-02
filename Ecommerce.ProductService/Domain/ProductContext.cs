using Microsoft.EntityFrameworkCore;

namespace Ecommerce.ProductService.Domain
{
 public class ProductContext(DbContextOptions<ProductContext> options) : DbContext(options)
 {
  public DbSet<Product> Products
  { get; set; } = null!;
 }
}
