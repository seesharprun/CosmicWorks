namespace CosmicWorks.Generator.DataSource;

public interface ICosmosContext
{
    Task SeedDataAsync<T>(string connectionString, string databaseName, string containerName, IEnumerable<T> items, Action<string> onCreated, params string[] partitionKeyPaths);
}