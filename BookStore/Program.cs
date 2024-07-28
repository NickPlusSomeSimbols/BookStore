using BookStore.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCustomServices();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

var configuration = builder.Configuration.AddJsonFile("appsetting.json");
/*var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json",);*/

builder.Services.AddDbContextFactory<BookStoreDbContext>(
        options =>
            options.UseNpgsql(builder.Configuration["ConnectionStrings:Default"]));

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoint =>
{
    endpoint.MapControllers();
});

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1.0");
        options.RoutePrefix = "";
    });
}


app.Run();
