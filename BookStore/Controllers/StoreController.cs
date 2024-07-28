using BookStore.BLL.Services.Store;
using BookStore.DTO.StoreDto;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers;

public class StoreController : BaseController
{
    private IStoreService _storeService;
    public StoreController(IStoreService storeService)
    {
        _storeService = storeService;
    }

    [HttpPost("get-by-id")]
    public async Task GetById(long id)
    {
        await _storeService.GetById(id);
    }
    [HttpPost("create")]
    public async Task Add(AddStoreDto dto)
    {
        await _storeService.Add(dto);
    }
    [HttpPost("update")]
    public async Task Update(UpdateStoreDto dto)
    {
        await _storeService.Update(dto);
    }
    [HttpPost("delete")]
    public async Task Delete(long id)
    {
        await _storeService.Delete(id);
    }
}
