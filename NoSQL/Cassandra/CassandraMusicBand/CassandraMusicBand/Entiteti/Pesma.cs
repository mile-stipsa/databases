using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraMusicBand.Entiteti
{
    public class Pesma
    {
        public String AlbumID { get; set; }
        public String PesmaID { get; set; }
        public String naziv { get; set; }
        public String trajanje { get; set; }
        public String datumizlaska { get; set; }
    }
}
