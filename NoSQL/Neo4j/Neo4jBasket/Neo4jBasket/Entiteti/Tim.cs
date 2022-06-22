using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo4jBasket.Entiteti
{
    public class Tim
    {
     
        public String ime { get; set; }
        public String grad { get; set; }
        public String dvorana { get; set; }

        public List<Igrac> igra { get; set; }
        public List<Godina> dostignuca { get; set; }
    }
}
