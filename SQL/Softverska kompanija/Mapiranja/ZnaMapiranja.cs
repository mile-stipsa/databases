using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Softverska_kompanija.Entiteti;
using System.Threading.Tasks;

namespace Softverska_kompanija.Mapiranja
{
    public class ZnaMapiranja : ClassMap<Zna>
    {
        public ZnaMapiranja()
        {

            Table("ZNA");

            Id(x => x.ZnaID, "ZNAID").GeneratedBy.TriggerIdentity();

            References(x => x.Programer).Column("IDZAPOSLJENOG").LazyLoad();
            References(x => x.ImeProgramskogJezika).Column("IDPROGRAMSKOGJEZIKA").LazyLoad();

        }
    }
}
