using Ardalis.Result;
using BookStore.DTO.StoreDto;

namespace BookStore.BLL.Services.Store;
public interface IStoreService
{
    public Task<Result<ICollection<StoreDto>>> GetAll();
    public Task<Result<StoreDto>> GetById(long id);
    public Task<Result<StoreDto>> Add(AddStoreDto dto);
    public Task<Result<StoreDto>> Update(UpdateStoreDto dto);
    public Task<Result<StoreDto>> Delete(long id);
}
