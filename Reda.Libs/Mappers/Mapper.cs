using Reda.Contracts;
using Reda.Libs.Models;
using System.Collections.Generic;
using System.Linq;

namespace Reda.Libs.Mappers
{
    public class Mapper : IMapper
    {
        public IEnumerable<ListsResponse> ToItemListContract(IEnumerable<ItemsDb> lists)
        {
            return lists.Select(ToItemListContract);
        }
        public ListsResponse ToItemListContract(ItemsDb list)
        {
            return new ListsResponse
            {
                ListName = list.ItemListName,
                TypeId = list.TypeId
            };
        }

        public IEnumerable<ItemsResponse> ToItemsContract(IEnumerable<ItemsDb> lists)
        {
            return lists.Select(ToItemsContract);
        }
        public ItemsResponse ToItemsContract(ItemsDb list)
        {
            return new ItemsResponse
            {
                ItemListName = list.ItemListName,
                TypeId = list.TypeId,
                ItemCategory = list.ItemCategory,
                ItemName = list.ItemName,
                DateRemoved = list.DateRemoved,
                DueAt = list.DueAt,
                IsDone = list.Isdone
            };
        }

        public ItemsDb ToItemDbModel(string userId, AddingItemRequest addingItemRequest)
        {
            return new ItemsDb
            {
                UserId = addingItemRequest.userId,
                TypeId = addingItemRequest.TypeId,
                ItemName = addingItemRequest.ItemName,
                ItemListName = addingItemRequest.ItemListName,
                ItemCategory = addingItemRequest.ItemCategory,
                Isdone = addingItemRequest.IsDone,
                DateRemoved = addingItemRequest.DateRemoved,
                DueAt = addingItemRequest.DueAt
            };
        }
    }

}
