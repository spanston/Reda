using Reda.Contracts;
using Reda.Libs.Mappers;
using Reda.Libs.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reda.Services
{
    public class RedaService : IRedaService
    {
        private readonly IItemListRepository _itemListRepository;
        private readonly IMapper _map;

        public RedaService(IItemListRepository itemListRepository, IMapper mapper)
        {
            _itemListRepository = itemListRepository;
            _map = mapper;
        }

        public async Task<IEnumerable<ListsResponse>> GetAllListsFromDatabase()
        {
            var response = await _itemListRepository.GetAllItemLists();

            return _map.ToItemListContract(response);
        }

        public async Task<IEnumerable<ListsResponse>> GetUserItemLists(string userId)
        {
            var response = await _itemListRepository.GetUserItemLists(userId);

            return _map.ToItemListContract(response);
        }
        
        public async Task<IEnumerable<ItemsResponse>> GetListContent(string listId)
        {
            var response = await _itemListRepository.GetListContent(listId);

            return _map.ToItemsContract(response);
        }

        public async Task AddItem(string userId, AddingItemRequest addingItemRequest)
        {
            var item =  _map.ToItemDbModel(userId, addingItemRequest);
            await _itemListRepository.AddItem(item);

            
        }
    }
}