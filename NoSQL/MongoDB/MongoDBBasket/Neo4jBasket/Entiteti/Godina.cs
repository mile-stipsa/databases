using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace MongoDBBasket.Entiteti
{
    public class Godina
    {
        public ObjectId Id { get; set; }
        public String godina { get; set; }
        public String takmicenje { get; set; }

        public MongoDBRef tim { get; set; }

    }
}
