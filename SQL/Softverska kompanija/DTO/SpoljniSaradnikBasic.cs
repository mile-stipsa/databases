using System;
using System.Collections.Generic;
using System.Linq;
using Softverska_kompanija.Entiteti;
using System.Text;
using System.Threading.Tasks;

namespace Softverska_kompanija.DTO
{
    public class SpoljniSaradnikBasic
    {
        public int IDSaradnika { get; set; }
        public string SIme { get; set; }
        public string SPrezime { get; set; }

        public SpoljniSaradnikBasic()
        {
        }
        public SpoljniSaradnikBasic(SpoljniSaradnik a)
        {
            this.IDSaradnika = a.IDSaradnika;
            this.SIme = a.SIme;
            this.SPrezime = a.SPrezime;
        }
    }
}
