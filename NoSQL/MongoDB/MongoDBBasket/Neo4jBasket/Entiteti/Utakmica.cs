using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDBBasket.Entiteti
{
    public class Utakmica
    {
      
        public ObjectId Id { get; set; }
        public String rezultat { get; set; }

        public MongoDBRef tim1 { get; set; }
        public MongoDBRef tim2 { get; set; }

       
    }
}
