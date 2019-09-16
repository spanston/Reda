using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Reda.Libs.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Reda.Libs.Repositories
{
    public class ItemListRepository : IItemListRepository
    {
        private readonly DynamoDBContext _context;

        public ItemListRepository(IAmazonDynamoDB dynamoDBClient)
        {
            _context = new DynamoDBContext(dynamoDBClient);
        }

        public async Task<IEnumerable<ListDb>> GetAllItemLists()
        {
            return await _context.ScanAsync<ListDb>(new List<ScanCondition>()).GetRemainingAsync();
        }

        public async Task<ListDb> GetItemList(string userId, string itemListId)
        {
            return await _context.LoadAsync<ListDb>(userId, itemListId);
        }


    }
}