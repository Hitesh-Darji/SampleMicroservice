using Microsoft.EntityFrameworkCore;
using SampleMicroservice.UserManagement.Api.Extensions.Middleware;
using SampleMicroservice.UserManagement.Application;
using SampleMicroservice.UserManagement.Infrastructure;
using SampleMicroservice.UserManagement.Infrastructure.Contexts;
using SampleMicroservice.UserManagement.Infrastructure.Seeder;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<UserDbContext>
    (options => options.UseNpgsql(builder.Configuration.GetConnectionString("MyAppConnection")));

builder.Services.AddInjectionPersistence();
builder.Services.AddInjectionApplication();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var seeder = scope.ServiceProvider.GetRequiredService<UserDbSeeder>();
    seeder?.Seed().Wait();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseMiddleware<ExceptionMiddleware>();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
