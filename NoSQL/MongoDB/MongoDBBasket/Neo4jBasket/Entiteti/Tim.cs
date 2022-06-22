using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDBBasket.Entiteti
{
    public class Tim
    {
     
        public ObjectId Id { get; set; }
        public String ime { get; set; }
        public String grad { get; set; }
        public String dvorana { get; set; }


        public MongoDBRef trener { get; set; }
        public List<MongoDBRef> utakmice { get; set; }
        public List<MongoDBRef> igra { get; set; }
        public List<MongoDBRef> dostignuca { get; set; }

        public Tim()
        {
            utakmice = new List<MongoDBRef>();
            igra = new List<MongoDBRef>();
            dostignuca = new List<MongoDBRef>();
        }

    }
}
