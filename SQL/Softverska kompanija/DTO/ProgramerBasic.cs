using System;
using System.Collections.Generic;
using System.Linq;
using Softverska_kompanija.Entiteti;
using System.Text;
using System.Threading.Tasks;

namespace Softverska_kompanija.DTO
{
    public class ProgramerBasic
    {
        public int IDZaposljenog { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public long JMBG { get; set; }
        public string Grad { get; set; }
        public string NazivUlica { get; set; }
        public int BrojKuce { get; set; }
        

        public ProgramerBasic(Zaposleni o)
        {
            this.IDZaposljenog = o.IDZaposljenog;
            this.Ime = o.Ime;
            this.Prezime = o.Prezime;
            this.JMBG= o.JMBG;
            this.Grad = o.Grad;
            this.NazivUlica = o.NazivUlica;
            this.BrojKuce = o.BrojKuce;
            
        }

        public ProgramerBasic()
        {

        }
    }
}
