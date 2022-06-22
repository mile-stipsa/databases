using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softverska_kompanija.Entiteti
{
    public class Angazovani
    {
        public virtual int AngazovaniID { get; set; }
        public virtual DateTime Pocetak { get; set; }
        public virtual DateTime? Kraj { get; set; }

        public virtual Zaposleni Programer { get; set; }
        public virtual SoftverskiProjekat Projekat { get; set; }
    }
}
