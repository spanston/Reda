using Reda.Contracts;
using Reda.Libs.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reda.Libs.Mappers
{
    public interface IMapper
    {
        IEnumerable<ListsResponse> ToItemListContract(IEnumerable<ListDb> lists);
        ListsResponse ToItemListContract(ListDb lists);
    }
}
