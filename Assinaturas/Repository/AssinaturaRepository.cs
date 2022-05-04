using System;
using System.Collections.Generic;
using System.Linq;
using Assinaturas.Context;
using Assinaturas.Entities;
using Assinaturas.Repository.Interface;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Assinaturas.Repository
{
    public class AssinaturaRepository : IAssinaturaRepository
    {
        private MongoDbContext dbContext = new MongoDbContext();

        public void AdicionarAssinatura(Assinatura assinatura)
        {
            dbContext.Assinaturas.InsertOne(assinatura);
        }

        public void AtualizarAssinatura(Assinatura assinatura)
        {
            dbContext.Assinaturas.ReplaceOne(x => x.Id == assinatura.Id, assinatura);
        }

        public Assinatura BuscarAssinatura(string id)
        {
            return dbContext.Assinaturas.Find(x => x.Id == id).FirstOrDefault();
        }

        public List<Assinatura> BuscarTodasAssinaturas()
        {
            return dbContext.Assinaturas.Find(x => true).ToList();
        }

        public void RemoverAssinatura(string id)
        {
            dbContext.Assinaturas.DeleteOne(x => x.Id == id);
        }
    }
}
