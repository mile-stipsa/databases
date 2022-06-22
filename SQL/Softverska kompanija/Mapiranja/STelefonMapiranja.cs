using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Softverska_kompanija.Entiteti;
using System.Threading.Tasks;

namespace Softverska_kompanija.Mapiranja
{
    public class STelefonMapiranja : ClassMap<STelefon>
    {
        public STelefonMapiranja()
        {

            Table("STELEFON");

            Id(x => x.TelefonID, "IDSTELEFON").GeneratedBy.TriggerIdentity();

            Map(x => x.BrojTelefona,"STELEFON");

            References(x => x.Saradnik).Column("IDSARADNIKA").LazyLoad() ;

        }
    }
}
