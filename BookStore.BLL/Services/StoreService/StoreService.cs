using Ardalis.Result;
using AutoMapper;
using AutoMapper.Configuration.Annotations;
using BookStore.DAL.Models;
using BookStore.DTO.StoreDto;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BLL.Services.StoreService;
public class StoreService : IStoreService
{
    private BookStoreDbContext _db;
    private readonly IMapper _mapper;

    public StoreService(BookStoreDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public Task<Result<ICollection<Store>>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<Result<Store>> GetById(long id)
    {
        var store = await _db.Stores.FirstOrDefaultAsync(x => x.Id == id);

        if (store == null)
        {
            return Result.Error("No item with such id"); // TODO: change error handling
        }

        return store;
    }
    public async Task<Result<Store>> Add(AddStoreDto dto)
    {
        var store = new Store();
        var storage = new Storage();

        using (var transaction = await _db.Database.BeginTransactionAsync())
        {
            try
            {
                _db.Storages.Add(storage);
                await _db.SaveChangesAsync();

                store.Address = dto.Address;
                store.ChainId = dto.ChainId;
                store.CreationDate = DateTime.UtcNow;
                store.StorageId = storage.Id;
                
                _db.Stores.Add(store);
                await _db.SaveChangesAsync();

                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return Result.Error($"Rollback is called: {ex.Source}");
            }
        }

        return Result.Success(store);
    }
    public async Task<Result<Store>> Update(UpdateStoreDto dto)
    {
        var store = _db.Stores.FirstOrDefault(x => x.Id == dto.Id);

        if (store == null)
        {
            return Result.Error("No item with such id"); // TODO: change error handling
        }

        store.ModificationDate = DateTime.UtcNow;
        store.Address = dto.Address;

        await _db.SaveChangesAsync();

        return Result.Success(store);
    }

    public async Task<Result<long>> Delete(long id)
    {
        var store = _db.Stores.FirstOrDefault(x => x.Id == id);

        if (store == null)
        {
            return Result.Error("No item with such id"); // TODO: change error handling
        }

        store!.IsDeleted = true;
        await _db.SaveChangesAsync();

        return id;
    }
}
