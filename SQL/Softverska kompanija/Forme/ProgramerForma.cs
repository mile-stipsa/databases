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
    public partial class ProgramerForma : Form
    {
        private int ID;
        private String ime;
        private String prezime;

        public ProgramerForma(int ID,String ime,String prezime)
        {
            InitializeComponent();
            this.ID = ID;
            this.ime = ime;
            this.prezime = prezime;
            this.Text = this.Text+": "+this.ime + " " + this.prezime;
            
        }

        private void ProgramerForma_Load(object sender, EventArgs e)
        {
            List<ProjekatBasic> projekti = DTOManager.projektiZaposlenog(ID);
            List<SpoljniSaradnikBasic> saradnici = DTOManager.saradniciZaposlenog(ID);
            if (projekti.Count != 0 && saradnici.Count != 0)
            {
                dgvProjekti.DataSource = projekti;
                dgvSaradnici.DataSource = saradnici;
            }
            else
            {
                dgvProjekti.DataSource = null;
                dgvSaradnici.DataSource = null;
            }
        }

        private void btnOtpusti_Click(object sender, EventArgs e)
        {
            SpoljniSaradnikBasic pr = (SpoljniSaradnikBasic)dgvSaradnici.SelectedRows[0].DataBoundItem;
            DTOManager.ObrisiSaradnika(pr.IDSaradnika);
            ProgramerForma_Load(sender, e);
        }

        private void btnAngazuj_Click(object sender, EventArgs e)
        {
            AngazujSaradnikeForma a = new AngazujSaradnikeForma(ID);
            this.Hide();
            if (a.ShowDialog() == DialogResult.OK)
                a.Show();
            this.Show();
            ProgramerForma_Load(sender, e);
        }

        private void dgvSaradnici_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SpoljniSaradnikBasic sar = (SpoljniSaradnikBasic)dgvSaradnici.SelectedRows[0].DataBoundItem;
            DodajTelefonForma a = new DodajTelefonForma(sar.IDSaradnika);
            this.Hide();
            if (a.ShowDialog() == DialogResult.OK)
            {
                a.Show();
            }
            this.Show();
        }
    }
}
