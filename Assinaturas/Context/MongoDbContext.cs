using System;
using Assinaturas.Entities;
using MongoDB.Driver;

namespace Assinaturas.Context
{
    public class MongoDbContext
    {
        public static string ConnectionString { get; set; }
        public static string DatabaseName { get; set; }

        private IMongoDatabase _database { get; }

        public MongoDbContext()
        {
            try
            {
                MongoClientSettings settings = MongoClientSettings.FromConnectionString(ConnectionString);
                var mongoClient = new MongoClient(settings);
                
                _database = mongoClient.GetDatabase(DatabaseName);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar com o servidor.", ex);
            }
        }

        public IMongoCollection<Assinatura> Assinaturas
        {
            get
            {
                return _database.GetCollection<Assinatura>("Assinaturas");
            }
        }
    }
}
