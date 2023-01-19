using desafio_pmenoslab;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
    //.Configuration.SetBasePath(Directory.GetCurrentDirectory())
    //.AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true)
    //.AddEnvironmentVariables();


// Add services to the container.
    
builder.Services.AddControllers();

builder.Services.AddDbContext<Context>(
        options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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
