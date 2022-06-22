using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Softverska_kompanija.Entiteti;
using System.Threading.Tasks;

namespace Softverska_kompanija.Mapiranja
{
    public class ProgramskiJezikMapiranja : ClassMap<ProgramskiJezik>
    {
        public ProgramskiJezikMapiranja()
        {

            Table("PROGRAMSKIJEZIK");

            Id(x => x.IDProgramskogJezika, "IDPROGRAMSKOGJEZIKA").GeneratedBy.TriggerIdentity();

            Map(x => x.ImeProgramskogJezika, "IMEPROGRAMSKOGJEZIKA");

            HasMany(x => x.Zna).KeyColumn("IDPROGRAMSKOGJEZIKA").Cascade.All().Inverse();

        }
    }
}
