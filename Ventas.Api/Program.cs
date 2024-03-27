using Ventas.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using Ventas.Infraestructure.Dao;
using Ventas.Infraestructure.Interfaces;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<VentasContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("VentasContext")));

// Add services to the container.

builder.Services.AddControllers();
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

app.Run();
