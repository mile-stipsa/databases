using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDBBasket.Entiteti
{
    public class Trener
    {
       
        public ObjectId Id { get; set; }
        public String ime { get; set; }
        public String prezime { get; set; }
        public String godinarod { get; set; }

        public MongoDBRef trenira { get; set; }
        public List<MongoDBRef> trenirao { get; set; }

        public Trener()
        {
            trenirao = new List<MongoDBRef>();
        }
    }
}
