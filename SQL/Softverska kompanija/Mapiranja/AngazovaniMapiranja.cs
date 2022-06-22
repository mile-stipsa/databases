using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Softverska_kompanija.Entiteti;
using System.Threading.Tasks;

namespace Softverska_kompanija.Mapiranja
{
    public class AngazovaniMapiranja : ClassMap<Angazovani>
    {
        public AngazovaniMapiranja()
        {

            Table("ANGAZOVANI");


            Id(x => x.AngazovaniID, "ANGAZOVANIID").GeneratedBy.TriggerIdentity();

            Map(x => x.Pocetak, "POCETAK");
            Map(x => x.Kraj, "KRAJ");

            References(x => x.Programer).Column("IDZAPOSLJENOG").LazyLoad();
            References(x => x.Projekat).Column("IDPROJEKTA").LazyLoad();

           
        }
    }
}
