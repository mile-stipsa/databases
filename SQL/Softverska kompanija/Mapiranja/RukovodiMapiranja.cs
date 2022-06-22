using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Softverska_kompanija.Entiteti;
using System.Threading.Tasks;

namespace Softverska_kompanija.Mapiranja
{
    public class RukovodiMapiranja : ClassMap<Rukovodi>
    {
        public RukovodiMapiranja()
        {
            Table("RUKOVODI");


            Id(x => x.RukovodiID, "RUKOVODIID").GeneratedBy.TriggerIdentity();

            Map(x => x.Pocetak, "POCETAK");
            Map(x => x.Kraj, "KRAJ");

            References(x => x.StarijiProjektant).Column("IDZAPOSLJENOG").LazyLoad();
            References(x => x.Projekat).Column("IDPROJEKTA").LazyLoad();
            
        }
    }
}
