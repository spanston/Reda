using System;
using System.Collections.Generic;
using System.Text;

namespace Reda.Contracts
{
    public class AddingItemRequest
    {
        public string userId { get; set; }
        public string ItemListName { get; set; }
        public string TypeId { get; set; }
        public string ItemCategory { get; set; }
        public string ItemName { get; set; }
        public string DateRemoved { get; set; }
        public string DueAt { get; set; }
        public string IsDone { get; set; }
    }
}
