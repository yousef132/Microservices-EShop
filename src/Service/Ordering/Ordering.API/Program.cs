using Ordering.API;
using Ordering.API.Extentions;
using Ordering.Application;
using Ordering.Infrastructure;
var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddApplicationServices(builder.Configuration)
    .AddInfrastructureServices(builder.Configuration)
    .AddApiServices(builder.Configuration);

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    await app.InitialiseDatabaseAsync();
}
app.UseApiServices();
app.Run();
