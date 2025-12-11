using Ordering.API;
using Ordering.API.Extentions;
using Ordering.Application;
using Ordering.Infrastructure;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiServices()
    .AddApplicationServices()
    .AddInfrastructureServices(builder.Configuration);

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    await app.InitialiseDatabaseAsync();
}
app.Run();
