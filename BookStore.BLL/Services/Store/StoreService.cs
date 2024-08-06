using Ardalis.Result;
using AutoMapper;
using BookStore.DTO.StoreDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BLL.Services.Store;
public class StoreService : IStoreService
{
    private BookStoreDbContext _db;
    private readonly IMapper _mapper;

    public StoreService(BookStoreDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public Task<Result<ICollection<StoreDto>>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Result<StoreDto>> GetById(long id)
    {
        var store = _db.Stores.FirstOrDefault(s => s.Id == id);

        if (store == null)
        {
            throw new Exception("null"); // TODO:Exceptions
        }

        StoreDto storeDto = new()
        {
            Address = store.Address,
        };

        return ;    
    }
    public Task<Result<StoreDto>> Add(AddStoreDto dto)
    {
        throw new NotImplementedException();
    }
    public Task<Result<StoreDto>> Update(UpdateStoreDto dto)
    {
        throw new NotImplementedException();
    }
    public Task<Result<StoreDto>> Delete(long id)
    {
        throw new NotImplementedException();
    }
}
