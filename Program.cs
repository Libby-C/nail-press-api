using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL; 

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<NailPressDb>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("NailPressDb")));


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
