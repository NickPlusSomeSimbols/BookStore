using Ardalis.Result;
using BookStore.BLL.Services.StoreService;
using BookStore.DAL.Models;
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
    public async Task<Result<Store>> GetById(long id)
    {
        return await _storeService.GetById(id);
    }
    [HttpPost("create")]
    public async Task<Result<Store>> Add(AddStoreDto dto)
    {
        return await _storeService.Add(dto);
    }
    [HttpPost("update")]
    public async Task<Result<Store>> Update(UpdateStoreDto dto)
    {
        return await _storeService.Update(dto);
    }
    [HttpPost("delete")]
    public async Task Delete(long id)
    {
        await _storeService.Delete(id);
    }
}
