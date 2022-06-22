using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softverska_kompanija.Entiteti
{
    public class SoftverskiProjekat
    {
        public virtual int IDProjekta { get; set; }
        public virtual DateTime VremePocetka { get; set; }
        public virtual DateTime? VremeZavrsetka { get; set; }
        public virtual SoftverskiProjekat Vrati { get { return this; } }


        public virtual IList<Angazovani> AngazovaniProgramerNaProjektu { get; set; }
       

        public SoftverskiProjekat()
        {
            AngazovaniProgramerNaProjektu = new List<Angazovani>();
        }
    }

    public class ProjekatKojiSeRazvijaUFirmi : SoftverskiProjekat
    {
        public virtual IList<Rukovodi> AngazovaniSPNaProjektu { get; set; }


        public ProjekatKojiSeRazvijaUFirmi()
        {
            AngazovaniSPNaProjektu = new List<Rukovodi>();
        }

    }

    public class Outsourcing : SoftverskiProjekat
    {
        public virtual string ImeFirme { get; set; }
        public virtual string NazivUlice { get; set; }
        public virtual string Grad { get; set; }
        public virtual int Broj { get; set; }

        

    }
}
