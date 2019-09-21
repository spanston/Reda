using Reda.Contracts;
using Reda.Libs.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Reda.Libs.Mappers
{
    public class Mapper : IMapper
    {
        public IEnumerable<ListsResponse> ToItemListContract(IEnumerable<ListDb> lists)
        {
            return lists.Select(ToItemListContract);
        }
        public ListsResponse ToItemListContract(ListDb list)
        {
            return new ListsResponse
            {
                ListName = list.ItemListName
            };
        }
    }

}
