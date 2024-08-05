using BookStore.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCustomServices();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

var config = builder.Configuration;

builder.Services.AddDbContext<BookStoreDbContext>(options =>
{
    options.UseNpgsql(config.GetConnectionString("Default"));
});

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoint =>
{
    endpoint.MapControllers();
});

if (app.Environment.IsDevelopment())
{
    app.UseSwagger(options =>
    {
        options.SerializeAsV2 = true;
    });
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1.0");
        options.RoutePrefix = "";

    });
}


app.Run();
