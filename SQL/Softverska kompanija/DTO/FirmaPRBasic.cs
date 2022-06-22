using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Softverska_kompanija.Entiteti;
using System.Threading.Tasks;

namespace Softverska_kompanija.DTO
{
    public class FirmaPRBasic:ProjekatBasic
    {
      
        public FirmaPRBasic():base()
        {
         
        }

        public FirmaPRBasic(SoftverskiProjekat P) : base(P)
        {

        }

    }
}
