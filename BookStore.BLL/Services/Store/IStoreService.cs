using Ardalis.Result;
using BookStore.DTO.StoreDto;

namespace BookStore.BLL.Services.Store;
public interface IStoreService
{
    public Task<Result<ICollection<BookStore.DAL.Models.Store>>> GetAll();
    public Task<Result<BookStore.DAL.Models.Store>> GetById(long id);
    public Task<> Add(AddStoreDto dto);
    public Task<> Update(UpdateStoreDto dto);
    public Task<> Delete(long id);
}
