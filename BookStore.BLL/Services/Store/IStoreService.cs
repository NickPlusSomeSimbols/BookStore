using BookStore.DTO.StoreDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BLL.Services.Store;
public interface IStoreService
{
    public Task<IAsyncResult> GetAll();
    public Task<IAsyncResult> GetById(long id);
    public Task<IAsyncResult> Add(AddStoreDto dto);
    public Task<IAsyncResult> Update(UpdateStoreDto dto);
    public Task<IAsyncResult> Delete(long id);
}
