using backend_v1.DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Conecction with SQL Server Express


const string CONNECTIONNAME = "BackDb";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);

// Add Context
builder.Services.AddDbContext<BackDbContext>(options => options.UseSqlServer(connectionString));


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
