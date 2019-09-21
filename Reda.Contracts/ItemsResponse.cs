using System;
using System.Collections.Generic;
using System.Text;

namespace Reda.Contracts
{
    public class ItemsResponse
    {
        public string ItemListName { get; set; }
        public string TypeId { get; set; }
        public string ItemCategory { get; set; }
        public string ItemName { get; set; }
        public string DateRemoved { get; set; }
        public string DueAt { get; set; }
        public string IsDone { get; set; }        

    }
}
