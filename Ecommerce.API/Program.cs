using Microsoft.AspNetCore.Authentication.Certificate;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

internal class Program
{
 private static void Main(string[] args)
 {
  var builder = WebApplication.CreateBuilder(args);
  builder.Configuration.AddJsonFile("infraestructure/ocelot.json", false, true);
  // Add services to the container.

  builder.Services.AddOcelot();
  //builder.Services.AddControllers();
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

  app.UseOcelot().Wait();

  app.Run();
 }
}