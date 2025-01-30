using ProductsApp.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddRouting(config => config.LowercaseUrls = true);
builder.Services.AddSwaggerConfig();

var app = builder.Build();

app.UseSwaggerConfig();

app.UseAuthorization();

app.MapControllers();

app.Run();
