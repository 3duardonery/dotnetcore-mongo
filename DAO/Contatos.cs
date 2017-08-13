using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace testapi
{
    public class Contatos
    {
       public ObjectId _id {get; set;}
       [BsonElement("nome")]
       public String Nome;
       [BsonElement("email")]       
       public String Email {get; set;}
       [BsonElement("fone")]
       public String Telefone {get; set;}

       
    }
}