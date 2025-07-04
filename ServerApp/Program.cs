using ServerApp.Services;
using Microsoft.AspNetCore.ResponseCompression;
var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddCors(o => o.AddPolicy("AllowBlazorClient", p =>
        p.WithOrigins("http://localhost:5273").AllowAnyHeader().AllowAnyMethod()))

    .AddResponseCompression(opts =>
    {
        opts.EnableForHttps = true;
    });

var app = builder.Build();

app.UseResponseCompression();
app.UseCors("AllowBlazorClient");

var getProductsEndpoint = app.MapGet("/api/productlist", () =>
    Results.Ok(ProductService.GetProducts())
);

app.Run();