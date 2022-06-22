using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo4jBasket.Entiteti
{
    public class Igrac
    {
        
        public String ime { get; set; }
        public String prezime { get; set; }
        public String godinarod { get; set; }
        public String pozicija { get; set; }
        public String visina { get; set; }

        public List<Tim> igrao { get; set; }
        public List<Statistika> ucinak { get; set; }
    }
}
