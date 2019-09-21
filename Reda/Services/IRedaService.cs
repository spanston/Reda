using Reda.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reda.Services
{
    public interface IRedaService
    {
        Task<IEnumerable<ListsResponse>> GetAllListsFromDatabase();
    }
}
 