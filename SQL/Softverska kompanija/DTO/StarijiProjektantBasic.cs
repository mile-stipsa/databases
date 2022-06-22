using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Softverska_kompanija.Entiteti;
using System.Threading.Tasks;

namespace Softverska_kompanija.DTO
{
    public class StarijiProjektantBasic
    {
        public int IDZaposljenog { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public long JMBG { get; set; }
        public string Grad { get; set; }
        public string NazivUlica { get; set; }
        public int BrojKuce { get; set; }


        public StarijiProjektantBasic()
        {

        }

        public StarijiProjektantBasic(Zaposleni SP)
        {
            this.IDZaposljenog = SP.IDZaposljenog;
            this.Ime = SP.Ime;
            this.Prezime = SP.Prezime;
            this.JMBG = SP.JMBG;
            this.Grad = SP.Grad;
            this.NazivUlica = SP.NazivUlica;
            this.BrojKuce = SP.BrojKuce;
        }
    }
}
