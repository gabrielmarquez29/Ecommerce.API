
using Ecommerce.ProductService.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Ecommerce.ProductService.Controllers;

namespace Ecommerce.ProductService
{
 public class Program
 {
  public static void Main(string[] args)
  {
   var builder = WebApplication.CreateBuilder(args);

   // Add services to the container.

   builder.Services.AddControllers();

   builder.Services.AddDbContext<ProductContext>(opt =>
    opt.UseInMemoryDatabase("ProductList"));

   // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
   builder.Services.AddEndpointsApiExplorer();
   builder.Services.AddSwaggerGen();

   var app = builder.Build();

   // Configure the HTTP request pipeline.
   if (app.Environment.IsDevelopment())
   {
    app.UseSwagger();
    app.UseSwaggerUI();
   }

   app.UseHttpsRedirection();

   app.UseAuthorization();


   app.MapControllers();

               app.MapProductEndpoints();

   app.Run();
  }
 }
}