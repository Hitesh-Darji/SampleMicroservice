using Microsoft.EntityFrameworkCore;
using SampleMicroservice.OrderManagement.Application;
using SampleMicroservice.OrderManagement.Infrastructure;
using SampleMicroservice.OrderManagement.Infrastructure.Contexts;
using SampleMicroservice.OrderManagement.Infrastructure.Seeder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<OrderDbContext>
    (options => options.UseNpgsql(builder.Configuration.GetConnectionString("MyAppConnection")));

builder.Services.AddInjectionPersistence();
builder.Services.AddInjectionApplication();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var seeder = scope.ServiceProvider.GetRequiredService<OrderDbSeeder>();
    seeder?.Seed().Wait();
}

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
