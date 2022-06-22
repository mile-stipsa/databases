using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Softverska_kompanija.Entiteti;
using System.Threading.Tasks;

namespace Softverska_kompanija.Mapiranja
{
    public class TelefonMapiranja : ClassMap<Telefon>
    {
        public TelefonMapiranja()
        {
            Table("TELEFON");

            Id(x => x.TelefonID, "IDTELEFON").GeneratedBy.TriggerIdentity();

            Map(x => x.BrojTelefona,"TELEFON");

            References(x => x.Zaposleni).Column("IDZAPOSLJENOG").LazyLoad();

        }
    }
}
