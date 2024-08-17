
using MongoDB.Entities;
using SearchService.Models;

namespace SearchService.Services
{
    public class AuctionSvcHttpClient
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _config;
        public AuctionSvcHttpClient(HttpClient httpClient, IConfiguration config)
        {
            _config = config;
            _httpClient = httpClient;
        }

        public async Task<List<Item>> GetItemsForSearchDb() 
        {
            var lastUpdated =  await DB.Find<Item, string>()
                .Sort(x => x.Descending(x => x.UpdateAt))
                .Project(x => x.UpdateAt.ToString())
                .ExecuteFirstAsync();

            return await _httpClient.GetFromJsonAsync<List<Item>>(_config["AuctionServiceUrl"] + "/api/auctions?date=" + lastUpdated);
        }
    }
}