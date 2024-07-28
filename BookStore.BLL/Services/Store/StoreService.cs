using BookStore.DTO.StoreDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BLL.Services.Store;
public class StoreService : IStoreService
{
    public Task<IAsyncResult> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<IAsyncResult> GetById(long id)
    {
        throw new NotImplementedException();
    }
    public Task<IAsyncResult> Add(AddStoreDto dto)
    {
        throw new NotImplementedException();
    }
    public Task<IAsyncResult> Update(UpdateStoreDto dto)
    {
        throw new NotImplementedException();
    }
    public Task<IAsyncResult> Delete(long id)
    {
        throw new NotImplementedException();
    }
}
