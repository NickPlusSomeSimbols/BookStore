using Ardalis.Result;
using BookStore.DAL.Models;
using BookStore.DTO.StoreDto;

namespace BookStore.BLL.Services.StoreService;
public interface IStoreService
{
    public Task<Result<ICollection<Store>>> GetAll();
    public Task<Result<Store>> GetById(long id);
    public Task<Result<Store>> Add(AddStoreDto dto);
    public Task<Result<Store>> Update(UpdateStoreDto dto);
    public Task<Result<long>> Delete(long id);
}
