using Reda.Contracts;
using Reda.Libs.Mappers;
using Reda.Libs.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reda.Services
{
    public class RedaService : IRedaService
    {
        private readonly IItemListRepository _itemListRepository;
        private readonly IMapper _map;

        public RedaService(IItemListRepository itemListRepository, IMapper map)
        {
            _itemListRepository = itemListRepository;
            _map = map;
        }

        public async Task<IEnumerable<ListResponse>> GetAllListsFromDatabase()
        {
            var response = await _itemListRepository.GetAllItemLists();

            return _map.ToItemListContract(response);
        }

        public async Task<ListResponse> GetItemList(string userId, string itemListId)
        {
            var response = await _itemListRepository.GetItemList(userId, itemListId);

            return _map.ToItemListContract(response);
        }

    }
}