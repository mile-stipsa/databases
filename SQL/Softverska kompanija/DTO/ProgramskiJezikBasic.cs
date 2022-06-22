using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Softverska_kompanija.Entiteti;
using System.Threading.Tasks;

namespace Softverska_kompanija.DTO
{
    public class ProgramskiJezikBasic
    {
        public int IDProgramskogJezika { get; set; }
        public string ImeProgramskogJezika { get; set; }

        
        public ProgramskiJezikBasic()
        {

        }

        public ProgramskiJezikBasic(ProgramskiJezik PJ)
        {
            this.IDProgramskogJezika = PJ.IDProgramskogJezika;
            this.ImeProgramskogJezika = PJ.ImeProgramskogJezika;
     
        }

    }
}
