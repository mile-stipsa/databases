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
    public partial class ZaposleniNaProjektu : Form
    {
        private int ID;
        public ZaposleniNaProjektu(int id)
        {
            InitializeComponent();
            this.ID = id;
        }

        private void ZaposleniNaProjektu_Load(object sender, EventArgs e)
        {

            if (this.Text == "Angazovani programeri")
            {
                List<ProgramerBasic> lista = DTOManager.zaposlenProgramerNaProjektu(ID);
                if (lista.Count != 0)
                    dgvZaposleni.DataSource = lista;
                else
                    dgvZaposleni.DataSource = null;
            }
            else
            {
                List<StarijiProjektantBasic> lista = DTOManager.ZaposlenProjektantNaProjektu(ID);
                if (lista.Count != 0)
                    dgvZaposleni.DataSource = lista;
                else
                    dgvZaposleni.DataSource = null;
            }
           
        }

       

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            ZaposleniKojiNisuNaProjektu a = new ZaposleniKojiNisuNaProjektu(ID);
            this.Hide();
            if (this.Text == "Angazovani programeri")
            {
                a.Text = a.Text + " " + "programeri";
            }
            else
            {
                a.Text = a.Text + " " + "projektanti";
            }
            if (a.ShowDialog() == DialogResult.OK)
                a.Show();
            this.Show();
                       
            ZaposleniNaProjektu_Load(sender, e);
        }

        private void btnOtpusti_Click(object sender, EventArgs e)
        {

            if (this.Text == "Angazovani programeri")
            {
                ProgramerBasic pr = (ProgramerBasic)dgvZaposleni.SelectedRows[0].DataBoundItem;
                DTOManager.OtpustiProgrameraSaProjekta(pr.IDZaposljenog, ID);
            }
            else
            {
                StarijiProjektantBasic pr = (StarijiProjektantBasic)dgvZaposleni.SelectedRows[0].DataBoundItem;

                DTOManager.OtpustiProjektantaSaProjekta(pr.IDZaposljenog, ID);
            }
            
            ZaposleniNaProjektu_Load(sender, e);
        }
    }
}
