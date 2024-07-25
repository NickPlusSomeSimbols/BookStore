using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BLL.Services.Store;
public interface IStoreService
{
    public Task<IAsyncResult> GetAll();
    public Task<IAsyncResult> GetById();
    public Task<IAsyncResult> Add();
    public Task<IAsyncResult> Update();
    public Task<IAsyncResult> Delete();
}
