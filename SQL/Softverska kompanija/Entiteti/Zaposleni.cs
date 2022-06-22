using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softverska_kompanija.Entiteti
{
    public class Zaposleni
    {
        public virtual int IDZaposljenog { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual long JMBG { get; set; }
        public virtual string Grad { get; set; }
        public virtual string NazivUlica { get; set; }
        public virtual int BrojKuce { get; set; }
        public virtual IList<Telefon> Telefoni { get; set; }

       
       


        public Zaposleni()
        {
            Telefoni = new List<Telefon>();
        }

    }
    public class Programer : Zaposleni
    {
        public virtual IList<Angazovani> AngazovaniProgramer { get; set; }
        public virtual IList<Zna> ZnaProgramskiJezik { get; set; }
        public virtual IList<SpoljniSaradnik> AngazujeSaradnike { get; set; }

        public Programer()
        {
            AngazovaniProgramer = new List<Angazovani>();
            ZnaProgramskiJezik = new List<Zna>();
            AngazujeSaradnike = new List<SpoljniSaradnik>();
        }
    }

    public class StarijiProjektant : Zaposleni
    {
        public virtual IList<Rukovodi> RukovodiProjektima { get; set; }

        public StarijiProjektant()
        {
            RukovodiProjektima = new List<Rukovodi>();
        }
    }
}
