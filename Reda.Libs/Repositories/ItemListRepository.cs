using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
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
        public async Task<IEnumerable<ListDb>> GetUserItemLists(string userId)
        {
            var config = new DynamoDBOperationConfig
            {
                QueryFilter = new List<ScanCondition>
                {
                    new ScanCondition("UserId", ScanOperator.Equal, userId),
                    new ScanCondition("TypeId", ScanOperator.BeginsWith, "List")
                }
            };
            return await _context.QueryAsync<ListDb>(userId, config).GetRemainingAsync();
        }

    }
}