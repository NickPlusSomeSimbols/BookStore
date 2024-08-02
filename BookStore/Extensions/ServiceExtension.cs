using BookStore.BLL.Services.Store;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Extensions;

public static class ServiceExtension
{
    public static void AddCustomServices(this IServiceCollection services)
    {
        services.AddScoped<IStoreService, StoreService>();
    }
}
