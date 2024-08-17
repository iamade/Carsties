using System.Text.Json;
using MongoDB.Driver;
using MongoDB.Entities;
using SearchService.Models;
using SearchService.Services;

namespace SearchService.Data
{
    public class DbInitializer
    {
        public static async Task InitDb(WebApplication app)
        {
            //Create the connection string
await DB.InitAsync("SearchDb", MongoClientSettings
    .FromConnectionString(app.Configuration.GetConnectionString("MongoDbConnection")));

//Creates the Index
await DB.Index<Item>()
    .Key(x => x.Make, KeyType.Text)
    .Key(x => x.Model, KeyType.Text)
    .Key(x => x.Color, KeyType.Text)
    .CreateAsync();

    var count = await DB.CountAsync<Item>();

    using var scope = app.Services.CreateScope();

    var httpClient = scope.ServiceProvider.GetRequiredService<AuctionSvcHttpClient>();

    var items = await httpClient.GetItemsForSearchDb();

    Console.WriteLine(items.Count + " returned from the auction Service");

    if (items.Count > 0) await DB.SaveAsync(items);

    /***
    Used to add data from json file
    */   
    // if(count == 0)
    // {
    //     Console.WriteLine("No data - will attempt to send");

    //     var itemData = await File.ReadAllTextAsync("Data/auctions.json");

    //     var options = new JsonSerializerOptions{ PropertyNameCaseInsensitive = true};

    //     var items = JsonSerializer.Deserialize<List<Item>>(itemData, options);

    //     await DB.SaveAsync(items);
    // }
        }
    }
}