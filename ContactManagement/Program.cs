using ContactManagement.Application.Service;
using ContactManagement.Infraestructure.Data.Context;
using ContactManagement.Infraestructure.Repository;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
                         b => b.MigrationsAssembly("ContactManagement.Infraestructure")));
//Repository
builder.Services.AddScoped<IUserContactManagementRepository, UserContactManagementRepository>();

//Service
builder.Services.AddScoped<IUserContactManagementService, UserContactManagementService>();

// Add Validator
//builder.Services.AddScoped<IValidator<Contact>, ContactValidator>();

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
