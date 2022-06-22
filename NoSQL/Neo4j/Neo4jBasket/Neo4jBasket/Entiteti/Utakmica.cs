using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo4jBasket.Entiteti
{
    public class Utakmica
    {
      
        public String rezultat { get; set; }

        public String tim1 { get; set; }
        public String tim2 { get; set; }
        public List<Igrac> igraci { get; set; }
    }
}
