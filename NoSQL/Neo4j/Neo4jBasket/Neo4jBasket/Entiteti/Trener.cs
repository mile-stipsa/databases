using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo4jBasket.Entiteti
{
    public class Trener
    {
       
        public String ime { get; set; }
        public String prezime { get; set; }
        public String godinarod { get; set; }

        public Tim trenira { get; set; }
        public List<Tim> trenirao { get; set; }
    }
}
