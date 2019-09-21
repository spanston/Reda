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
        private readonly IMapper _mapper;

        public RedaService(IItemListRepository itemListRepository, IMapper mapper)
        {
            _itemListRepository = itemListRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ListsResponse>> GetAllListsFromDatabase()
        {
            var response = await _itemListRepository.GetAllItemLists();

            return _mapper.ToItemListContract(response);
        }

    }
}