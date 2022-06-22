using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Softverska_kompanija.DTO;

namespace Softverska_kompanija
{
    public partial class ZaposleniKojiNisuNaProjektu : Form
    {
        private int ID;
        public ZaposleniKojiNisuNaProjektu(int id)
        {
            InitializeComponent();
            ID = id;
            
        }
        
        private void dgvZaposleni_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.Text == "Neangazovani programeri")
            {
                ProgramerBasic programer = (ProgramerBasic)dgvZaposleni.SelectedRows[0].DataBoundItem;
                DTOManager.AngazujProgrameraNaProjektu(ID, programer.IDZaposljenog);
            }
            else
            {
                StarijiProjektantBasic programer = (StarijiProjektantBasic)dgvZaposleni.SelectedRows[0].DataBoundItem;
                DTOManager.AngazujProjektantaNaProjektu(ID, programer.IDZaposljenog);
            }
            ZaposleniKojiNisuNaProjektu_Load(sender, e);
        }

        private void ZaposleniKojiNisuNaProjektu_Load(object sender, EventArgs e)
        {
            if (this.Text == "Neangazovani programeri")
            {
                List<ProgramerBasic> programeri = DTOManager.UcitajNeangazovaneProgramere(ID);
                if(programeri.Count!=0)
                    dgvZaposleni.DataSource = programeri;
                else
                    dgvZaposleni.DataSource = null;
            }
            else
            {
                List<StarijiProjektantBasic> projektanti = DTOManager.UcitajNeangazovaneProjektante(ID);
                if(projektanti.Count!=0)
                    dgvZaposleni.DataSource = projektanti;
                else
                    dgvZaposleni.DataSource = null;
            }
        }
    }
}
