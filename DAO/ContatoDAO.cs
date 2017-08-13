using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using MongoDB.Bson;
using MongoDB.Driver;

namespace testapi
{
    public class ContatoDAO
    {
        List<Contatos> lista = new List<Contatos>();
        public ContatoDAO()
        {
            /*lista.Add(new Contatos(){
                Nome = "Eduardo", 
                Email = "edu.nery@gmail.com",
                Telefone = new String[]{"991540594", "32354601"}.ToString()
                });
                lista.Add(new Contatos(){
                Nome = "Teste", 
                Email = "edu.nery@gmail.com",
                Telefone = new String[]{"991540594", "32354601"}.ToString()
                });
                lista.Add(new Contatos(){
                Nome = "Nery", 
                Email = "edu.nery@gmail.com",
                Telefone = new String[]{"991540594", "32354601"}.ToString()
                });*/
        }

        public String Nomes()
        {            
            return new ConnectionManager().Contatos();
        }

        public Contatos FindName(String nome)
        {
            return lista.Find(x => x.Nome == nome);
        }

        public String Id(int id)
        {
            
            return JsonConvert.SerializeObject(lista.ElementAt(id));
        }
    }
}