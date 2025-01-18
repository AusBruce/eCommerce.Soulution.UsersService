using eCommerce.Infrastructure;
using eCommerce.Core;

var builder = WebApplication.CreateBuilder(args);

//Add Infrastructure services
builder.Services.AddInfrastructure();
builder.Services.AddCore();


// Add controllers to the Service collection

builder.Services.AddControllers();

// Build web application
var app = builder.Build();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();   

app.Run();
