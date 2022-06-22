using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Softverska_kompanija.Entiteti;
using System.Threading.Tasks;

namespace Softverska_kompanija.Mapiranja
{
    public class SoftverskiProjekatMapiranja : ClassMap<SoftverskiProjekat>
    {
        public SoftverskiProjekatMapiranja()
        {

            Table("SOFTVERSKIPROJEKAT");
            
            Id(x => x.IDProjekta, "IDPROJEKTA").GeneratedBy.TriggerIdentity();


            Map(x => x.VremePocetka, "VREMEPOCETKA");
            Map(x => x.VremeZavrsetka, "VREMEZAVRSETKA");

            HasMany(x => x.AngazovaniProgramerNaProjektu).KeyColumn("IDPROJEKTA").Cascade.All().Inverse();
       

        }
    }

    public class ProjekatKojiSeRazvijaUFirmiMapiranja : SubclassMap<ProjekatKojiSeRazvijaUFirmi>
    {
        public ProjekatKojiSeRazvijaUFirmiMapiranja()
        {
            Table("PROJEKATKOJISERAZVIJAUFIRMI");

            KeyColumn("IDPROJEKTA");

            HasMany(x => x.AngazovaniSPNaProjektu).KeyColumn("IDPROJEKTA").Cascade.All().Inverse();
        }

    }


    public class OutsourcingMapiranja : SubclassMap<Outsourcing>
    {
        public OutsourcingMapiranja()
        {

            Table("OUTSOURCING");

            KeyColumn("IDPROJEKTA");


            Map(x => x.ImeFirme, "IMEFIRME");
            Map(x => x.NazivUlice, "NAZIVULICE");
            Map(x => x.Grad, "GRAD");
            Map(x => x.Broj, "BROJ");

           
        }
    }
}
