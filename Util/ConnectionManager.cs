using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using MongoDB.Driver;
using MongoDB.Bson;
using Newtonsoft.Json;

namespace testapi
{
    public class ConnectionManager
    {
        private MongoClient _client;
        private MongoServer _server;
        private MongoDatabase _db;
        private List<Contatos> _lista;

        public ConnectionManager()
        {
            try{
                _client = new MongoClient("mongodb://127.0.0.1:27017");    
                _server = _client.GetServer();        
                _db = _server.GetDatabase("contatos");
            }
            catch(Exception exc)
            {
                Console.Write("Erro const: " + exc.Message);
            }
            //_lista = new List<Contatos>();
        }

        public String Contatos()
        {
            //var client = new MongoClient("mongodb://localhost:27017");
            String lista = "";
            try{
                var collection = _db.GetCollection<Contatos>("nomes").FindAll();
                return JsonConvert.SerializeObject(collection);
                //await collection.InsertOneAsync(new Person { Name = "Jack" });

                //var list = collection.FindAll();
                //lista = BsonDocument.Parse(JsonConvert.SerializeObject(list)).ToJson();
            }
            catch(Exception exc)
            {
                return "Erro resposta : " + exc.Message;
            }
                
            //return JsonConvert.SerializeObject(lista);
        }
    }
}