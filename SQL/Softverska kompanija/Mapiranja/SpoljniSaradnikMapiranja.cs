using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Softverska_kompanija.Entiteti;
using System.Threading.Tasks;

namespace Softverska_kompanija.Mapiranja
{
    public class SpoljniSaradnikMapiranja : ClassMap<SpoljniSaradnik>
    {
        public SpoljniSaradnikMapiranja()
        {

            Table("SPOLJNISARADNIK");


            Id(x => x.IDSaradnika, "IDSARADNIKA").GeneratedBy.TriggerIdentity();


            Map(x => x.SIme, "SIME");
            Map(x => x.SPrezime, "SPREZIME");

            HasMany(x => x.Telefoni).KeyColumn("IDSARADNIKA").Cascade.All().Inverse();

            References(x => x.AngazovanOd).Column("IDZAPOSLJENOG").LazyLoad();
           
        }
    }
}
