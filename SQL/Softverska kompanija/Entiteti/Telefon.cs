using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softverska_kompanija.Entiteti
{
    public class Telefon
    {
        public virtual int TelefonID { get; set; }
        public virtual String BrojTelefona { get; set; }
        public virtual Zaposleni Zaposleni { get; set; }
    }
}
