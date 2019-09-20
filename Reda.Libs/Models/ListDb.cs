using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reda.Libs.Models
{
    [DynamoDBTable("Items")]
    public class ListDb
    {
        [DynamoDBHashKey]
        public string UserId { get; set; }
        public string TypeId { get; set; }
        public string ItemListId { get; set; }
        public string DateRemoved { get; set; }
        public string DueAt { get; set; }
        public string Isdone { get; set; }
        public string ItemCategory { get; set; }
        public string ItemListName { get; set; }
        public string ItemName { get; set; }
        public string ItemCategoryName { get; set; }       

    }
}
