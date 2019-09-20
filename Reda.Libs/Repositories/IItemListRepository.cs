using Reda.Libs.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Reda.Libs.Repositories
{
    public interface IItemListRepository
    {
       Task<IEnumerable<ListDb>> GetAllItemLists();
        Task<IEnumerable<ListDb>> GetUserItemLists(string userId);
    }
}
