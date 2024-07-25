using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers;

public class BookStore : BaseController
{
    [HttpPost("create")]
    public async Task Create(int dto)
    {

    }
}
