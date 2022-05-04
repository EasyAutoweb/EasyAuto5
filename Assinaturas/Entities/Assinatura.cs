using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace Assinaturas.Entities
{
    public class Assinatura
    {
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string UsuarioId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string AssinaturaTipoId { get; set; }
        public decimal Valor { get; set; }
        public string Nome { get; set; }
    }
}
