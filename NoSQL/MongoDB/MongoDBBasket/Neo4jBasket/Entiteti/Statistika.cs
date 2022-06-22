using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDBBasket.Entiteti
{
    public class Statistika
    {
        public ObjectId Id { get; set; }
        public String procenat1 { get; set; }
        public String procenat2 { get; set; }
        public String procenat3 { get; set; }
        public String skokovi { get; set; }
        public String indeks { get; set; }

        public MongoDBRef igrac { get; set; }
        public MongoDBRef utakmica { get; set; }
    }
}
