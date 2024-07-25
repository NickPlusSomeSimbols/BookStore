using BookStore.BLL.Services.Store;

namespace BookStore.Extensions;

public static class ServiceExtension
{
    public static void AddCustomServices(this IServiceCollection services)
    {
        services.AddScoped<IStoreService, StoreService>();
    }
}
