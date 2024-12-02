namespace Ecommerce.ProductService.Domain
{
 public class ProductDTO
 {
  public int Id { get; set; }
  public required string Name { get; set; }
  public required string Description { get; set; }
  public required decimal Price { get; set; }
 }
}
