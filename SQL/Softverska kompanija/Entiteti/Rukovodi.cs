using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softverska_kompanija.Entiteti
{
    public class Rukovodi
    {
        public virtual int RukovodiID { get; set; }
        public virtual DateTime Pocetak { get; set; }
        public virtual DateTime? Kraj { get; set; }

        public virtual Zaposleni StarijiProjektant { get; set; }
        public virtual SoftverskiProjekat Projekat { get; set; }
    }
}
