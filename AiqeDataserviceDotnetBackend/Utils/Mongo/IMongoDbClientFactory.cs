using MongoDB.Driver;

namespace AiqeDataserviceDotnetBackend.Utils.Mongo;

public interface IMongoDbClientFactory
{
    IMongoClient GetClient();

    IMongoCollection<T> GetCollection<T>(string collection);
}