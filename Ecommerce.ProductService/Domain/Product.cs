﻿namespace Ecommerce.ProductService.Domain
{
 public class Product
 {
 public int Id { get; set; }
 public required string Name { get; set; }
 public required string Description { get; set; }
 public required decimal Price { get; set; }
 public bool HasStock { get; set; }
 }
}
