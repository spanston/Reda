using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reda.Contracts;
using Reda.Services;

namespace Reda.Controllers
{
    [Route("itemlists")]
    public class ItemController : Controller
    {
        private readonly IRedaService _redaService;

        public ItemController(IRedaService redaService)
        {
            _redaService = redaService;
        }

        [HttpGet]
        public async Task<IEnumerable<ListResponse>> GetAllListsFromDataBase()
        {
            var results = await _redaService.GetAllListsFromDatabase();

            return results;
        }

        [HttpGet]
        [Route("{userId}/{itemListId}")]
        public async Task<ListResponse> GetItemList(string userId, string itemListId)
        {
            var result = await _redaService.GetItemList(userId, itemListId);

            return result;

        }
    }
}