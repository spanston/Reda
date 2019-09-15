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
        public string ItemListId { get; set; }
        public string ItemListName { get; set; }
        public string dueAt { get; set; }
        public string isDone { get; set; }
        public string ItemCategory { get; set; }
        public string ItemCategoryId { get; set; }
        public string ItemCategoryName { get; set; }
        public string ItemDeletedDate { get; set; }
        public string ItemId { get; set; }
        public string ItemTitle  { get; set; }

    }
}
