using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using NHibernate;
using Softverska_kompanija.Entiteti;
using System.Threading.Tasks;

namespace Softverska_kompanija.Mapiranja
{
    public class ZaposleniMapiranja : ClassMap<Zaposleni>
    {
        public ZaposleniMapiranja()
        {

            Table("ZAPOSLENI");


            Id(x => x.IDZaposljenog, "IDZAPOSLJENOG").GeneratedBy.TriggerIdentity();


            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.JMBG, "JMBG");
            Map(x => x.BrojKuce, "BROJKUCE");
            Map(x => x.Grad, "GRAD");
            Map(x => x.NazivUlica, "NAZIVULICE");


           
            HasMany(x => x.Telefoni).KeyColumn("IDZAPOSLJENOG").Cascade.All().Inverse();


          
         
        }
    }


    public class ProgramerMapiranja : SubclassMap<Programer>
    {
        public ProgramerMapiranja()
        {
            Table("PROGRAMER");

            KeyColumn("IDZAPOSLJENOG");

            HasMany(x => x.AngazujeSaradnike).KeyColumn("IDZAPOSLJENOG").Cascade.All().Inverse();
            HasMany(x => x.AngazovaniProgramer).KeyColumn("IDZAPOSLJENOG").Cascade.All().Inverse();

            HasMany(x => x.ZnaProgramskiJezik).KeyColumn("IDZAPOSLJENOG").Cascade.All().Inverse();


        }
    }

    public class StarijiProjektantMapiranja : SubclassMap<StarijiProjektant>
    {
        public StarijiProjektantMapiranja()
        {
            Table("STARIJIPROJEKTANT");

            KeyColumn("IDZAPOSLJENOG");

            HasMany(x => x.RukovodiProjektima).KeyColumn("IDZAPOSLJENOG").Cascade.All().Inverse();

           
        }
    }
}
