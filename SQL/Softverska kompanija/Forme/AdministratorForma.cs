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
    public partial class AdministratorForma : Form
    {
        public AdministratorForma()
        {
            InitializeComponent();
        }

        private void AdministratorForma_Load(object sender, EventArgs e)
        {
            List<ProgramerBasic> programeri = DTOManager.UcitajSveProgramere();
            if(programeri.Count!=0)
                dgvProgrameri.DataSource = programeri;
            else
                dgvProgrameri.DataSource = null;

            List<StarijiProjektantBasic> projektanti = DTOManager.UcitajSveProjektante();
            if(projektanti.Count!=0)
                dgvProjektanti.DataSource = projektanti;
            else
                dgvProjektanti.DataSource = null;

            List<ProjekatBasic> projekti = DTOManager.UcitajSveProjekte();
            if(projekti.Count!=0)
                dgvProjekti.DataSource = projekti;
            else
                dgvProjekti.DataSource = null;
        }

        private void btnObrisiProgramera_Click(object sender, EventArgs e)
        {
            ProgramerBasic pr = (ProgramerBasic)dgvProgrameri.SelectedRows[0].DataBoundItem;

            DTOManager.ObrisiProgramera(pr.IDZaposljenog);
            AdministratorForma_Load(sender, e);
        }

        

        private void btnDodajProjektanta_Click(object sender, EventArgs e)
        {
            DodajZaposlenogForma a = new DodajZaposlenogForma();
            a.Text = "Dodajte novog projektanta";
            this.Hide();
            if (a.ShowDialog() == DialogResult.OK)
            {
                a.Show();

            }
            this.Show();
            AdministratorForma_Load(sender, e);
        }

        private void btnObrisiProjektanta_Click(object sender, EventArgs e)
        {

            StarijiProjektantBasic pr = (StarijiProjektantBasic)dgvProjektanti.SelectedRows[0].DataBoundItem;

            DTOManager.ObrisiProjektanta(pr.IDZaposljenog);
            AdministratorForma_Load(sender, e);
        }

        private void btnDodajProgramera_Click(object sender, EventArgs e)
        {
            DodajZaposlenogForma a = new DodajZaposlenogForma();
            a.Text = "Dodajte novog programera";
            this.Hide();
            if (a.ShowDialog() == DialogResult.OK)
            {
                a.Show();

            }
            this.Show();
            AdministratorForma_Load(sender, e);
        }

        private void btnZavrsi_Click(object sender, EventArgs e)
        {
            ProjekatBasic proj = (ProjekatBasic)dgvProjekti.SelectedRows[0].DataBoundItem;

            DTOManager.ZavrsiProjekat(proj.IDProjekta);
            AdministratorForma_Load(sender, e);
        }

        private void btnDodajProjekat_Click(object sender, EventArgs e)
        {
            if (cxbFirma.Checked)
                DTOManager.DodajProjekat(0);
            else
                DTOManager.DodajProjekat(1);
            AdministratorForma_Load(sender, e);
        }

        private void dgvProgrameri_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ProgramerBasic prog = (ProgramerBasic)dgvProgrameri.SelectedRows[0].DataBoundItem;
            DodajZaposlenogForma a = new DodajZaposlenogForma(prog);
            a.Text = "Azuriraj programera";
            this.Hide();
            if (a.ShowDialog() == DialogResult.OK)
            {
                a.Show();

            }
            this.Show();
            AdministratorForma_Load(sender, e);
        }

        private void dgvProjektanti_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            StarijiProjektantBasic proj = (StarijiProjektantBasic)dgvProjektanti.SelectedRows[0].DataBoundItem;
            DodajZaposlenogForma a = new DodajZaposlenogForma(proj);
            a.Text = "Azuriraj starijeg projektanta";
            this.Hide();
            if (a.ShowDialog() == DialogResult.OK)
            {
                a.Show();

            }
            this.Show();
            AdministratorForma_Load(sender, e);
        }

        private void dgvProjekti_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ProjekatBasic proj = (ProjekatBasic)dgvProjekti.SelectedRows[0].DataBoundItem;
            ZaposleniNaProjektu a = new ZaposleniNaProjektu(proj.IDProjekta);
            a.Text = a.Text + " projektanti";
            this.Hide();
            if (a.ShowDialog() == DialogResult.OK)
                a.Show();
            this.Show();


        }

      

        private void cxbFirma_Click(object sender, EventArgs e)
        {
            if (cxbOutsourcing.Checked == true)
            {
                cxbOutsourcing.Checked = false;
                cxbFirma.Checked = true;
            }
           
        }

        private void cxbOutsourcing_Click(object sender, EventArgs e)
        {
            if (cxbFirma.Checked == true)
            {
                cxbFirma.Checked = false;
                cxbOutsourcing.Checked = true;
            }
           
        }
    }
}
