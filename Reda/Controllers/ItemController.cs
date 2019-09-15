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
        public async Task<IEnumerable<ListsResponse>> GetAllListsFromDataBase()
        {
            var results = await _redaService.GetAllListsFromDatabase();

            return results;
        }
    }
}