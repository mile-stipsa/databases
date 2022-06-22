using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Softverska_kompanija.Entiteti;
using System.Threading.Tasks;

namespace Softverska_kompanija.DTO
{
    public class OutSourcingBasic:ProjekatBasic
    {
       
        public string ImeFirme { get; set; }
        public string NazivUlice { get; set; }
        public string Grad { get; set; }
        public int Broj { get; set; }


        public OutSourcingBasic():base()
        {
        }

        public OutSourcingBasic(Outsourcing o):base(o)
        {
            

            this.ImeFirme = o.ImeFirme;
            this.NazivUlice = o.NazivUlice;
            this.Grad = o.Grad;
            this.Broj = o.Broj;
        }

    }
}
