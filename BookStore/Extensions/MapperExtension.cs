using AutoMapper;
using BookStore.BLL.Services.Store;
using BookStore.DAL.Models;
using BookStore.DTO.StoreDto;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Extensions;

public static class MapperExtension
{
    public static void AddMapperExtension(this IServiceCollection services)
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Store, StoreDto>();
            cfg.CreateMap<StoreDto, Store>();
        });

        var mapper = config.CreateMapper();
        services.AddSingleton(mapper);
    }
}
