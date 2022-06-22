using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softverska_kompanija.Entiteti
{
    public class SpoljniSaradnik
    {
        public virtual int IDSaradnika { get; set; }
        public virtual string SIme { get; set; }
        public virtual string SPrezime { get; set; }
        public virtual IList<STelefon> Telefoni { get; set; }

        public virtual Zaposleni AngazovanOd { get; set; }

        public SpoljniSaradnik()
        {
            Telefoni = new List<STelefon>();
        }

    }
}
