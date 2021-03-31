using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PROJETOMONGO.Models
{
    public class Produto
    {
        
        
        #region Propriedades

            [BsonId]    
            [BsonRepresentation(BsonType.ObjectId)]
            public string Id { get; set; }
            public string Descricao { get; set; }
            public decimal Preco { get; set; }

            public Fornecedor Fornecedor { get; set; }
       
        #endregion
   
    }
}