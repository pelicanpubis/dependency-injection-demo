using Microsoft.EntityFrameworkCore;
using RepositoryPatternDemo.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//1. Hämta connection string
string? connectionString = builder.Configuration.GetConnectionString("DbConnection");


//2. Lägga till databasen i Dependency injection container
//SOLID PROGRAMMING PRINCIPLES, DETTA ÄR D:T I SOLID, DEPENDENCY INVERSION PRINCIPLE
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

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
