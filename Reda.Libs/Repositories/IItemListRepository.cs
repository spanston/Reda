using Reda.Libs.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Reda.Libs.Repositories
{
    public interface IItemListRepository
    {
       Task<IEnumerable<ItemsDb>> GetAllItemLists();
        Task<IEnumerable<ItemsDb>> GetUserItemLists(string userId);
        Task<IEnumerable<ItemsDb>> GetListContent(string listId);
    }
}
