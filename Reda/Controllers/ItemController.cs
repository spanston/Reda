using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reda.Contracts;
using Reda.Services;

namespace Reda.Controllers
{
    [Route("reda")]
    public class ItemController : Controller
    {
        private readonly IRedaService _redaService;

        public ItemController(IRedaService redaService)
        {
            _redaService = redaService;
        }

        [HttpGet]
        public async Task<IEnumerable<ListsResponse>> GetAllListsFromDataBase()
        {
            var results = await _redaService.GetAllListsFromDatabase();

            return results;
        }

        [HttpGet]
        [Route("lists/{userId}")]
        public async Task<IEnumerable<ListsResponse>> GetUserItemLists(string userId)
        {
            var result = await _redaService.GetUserItemLists(userId);

            return result;
        }

        [HttpGet]
        [Route("itemlist/{listId}")]
        public async Task<IEnumerable<ItemsResponse>> GetListContent(string listId)
        {
            var result = await _redaService.GetListContent(listId);

            return result;
        }

        [HttpPost]
        [Route("itemlist/{userId}")]
        public async Task<IActionResult> AddItem(string userId, [FromBody] AddingItemRequest addingItemRequest)
        {
            await _redaService.AddItem(userId, addingItemRequest);

            return Ok();
        }
    }
}