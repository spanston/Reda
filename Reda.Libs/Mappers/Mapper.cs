using Reda.Contracts;
using Reda.Libs.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Reda.Libs.Mappers
{
    public class Mapper : IMapper
    {
        public IEnumerable<ListResponse> ToItemListContract(IEnumerable<ListDb> lists)
        {
            return lists.Select(ToItemListContract);
        }
        public ListResponse ToItemListContract(ListDb list)
        {
            return new ListResponse
            {
                ItemListName = list.ItemListName,
                ItemListId = list.ItemListId

            };
        }
    }

}
