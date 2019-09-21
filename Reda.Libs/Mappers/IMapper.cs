using Reda.Contracts;
using Reda.Libs.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reda.Libs.Mappers
{
    public interface IMapper
    {
        IEnumerable<ListsResponse> ToItemListContract(IEnumerable<ItemsDb> lists);
        ListsResponse ToItemListContract(ItemsDb lists);
        ItemsResponse ToItemsContract(ItemsDb list);
        IEnumerable<ItemsResponse> ToItemsContract(IEnumerable<ItemsDb> lists);
        ItemsDb ToItemDbModel(string userId, AddingItemRequest addingItemRequest);
    }
}
