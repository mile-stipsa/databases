using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace MongoDBBasket.Entiteti
{
    public class Igrac
    {
        public ObjectId Id { get; set; }
        public String ime { get; set; }
        public String prezime { get; set; }
        public String godinarod { get; set; }
        public String pozicija { get; set; }
        public String visina { get; set; }

        public MongoDBRef igra { get; set; }

        public List<MongoDBRef> statistika { get; set; }
        public List<MongoDBRef> igrao { get; set; }

        public Igrac()
        {
            statistika = new List<MongoDBRef>();
            igrao = new List<MongoDBRef>();
        }
    }
}
