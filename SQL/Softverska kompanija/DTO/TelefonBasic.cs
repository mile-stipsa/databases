using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Softverska_kompanija.Entiteti;
using System.Threading.Tasks;

namespace Softverska_kompanija.DTO
{
    public class TelefonBasic
    {
        public int TelefonID { get; set; }
        public String BrojTelefona { get; set; }

        public TelefonBasic()
        {
        }

        public TelefonBasic(Telefon t)
        {
            this.TelefonID = t.TelefonID;
            this.BrojTelefona = t.BrojTelefona;
        }
    }

    
}
