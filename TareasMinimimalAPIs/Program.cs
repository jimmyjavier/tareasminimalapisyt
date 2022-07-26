using Microsoft.EntityFrameworkCore;
using TareasMinimimalAPIs.Data;
using TareasMinimimalAPIs.Helpers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<TareasContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("tareaDb")));

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

await app.ConfigurarMigraciones();

app.Run();

