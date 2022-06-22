using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softverska_kompanija.Entiteti
{
    public class ProgramskiJezik
    {
        public virtual int IDProgramskogJezika { get; set; }
        public virtual string ImeProgramskogJezika { get; set; }


        public virtual IList<Zna> Zna { get; set; }

        public ProgramskiJezik()
        {
            Zna = new List<Zna>();
        }
    }
}
