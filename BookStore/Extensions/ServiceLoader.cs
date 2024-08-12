using AutoMapper;
using BookStore.BLL.Services.StoreService;
using BookStore.DAL.Models;
using BookStore.DTO.StoreDto;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Extensions;

public static class ServiceLoader
{
    public static void AddCustomServices(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(MapperExtension));
        
        services.AddScoped<IStoreService, StoreService>();
    }
}