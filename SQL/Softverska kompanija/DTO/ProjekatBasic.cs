using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Softverska_kompanija.Entiteti;
using System.Threading.Tasks;

namespace Softverska_kompanija.DTO
{
    public class ProjekatBasic
    {
        public int IDProjekta { get; set; }
        public DateTime VremePocetka { get; set; }
        public DateTime? VremeZavrsetka { get; set; }

        public ProjekatBasic()
        {

        }

        public ProjekatBasic(SoftverskiProjekat P)
        {
            this.IDProjekta = P.IDProjekta;
            this.VremePocetka = P.VremePocetka;
            this.VremeZavrsetka = P.VremeZavrsetka;
        }
    }
}
