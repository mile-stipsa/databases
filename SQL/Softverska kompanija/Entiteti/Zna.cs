using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softverska_kompanija.Entiteti
{
    public class Zna
    {
        public virtual int ZnaID { get; set; }

        public virtual Zaposleni Programer { get; set; }
        public virtual ProgramskiJezik ImeProgramskogJezika { get; set; }
    }
}
