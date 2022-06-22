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
    public partial class DodajZaposlenogForma : Form
    {
        private int id=0;
        private ProgramerBasic programer;
        private StarijiProjektantBasic projektant;
        public DodajZaposlenogForma()
        {
            InitializeComponent();
            programer = new ProgramerBasic();
            projektant = new StarijiProjektantBasic();
            btnDodajZaposlenog.Enabled = false;
            btnTelefon.Enabled = provera();
        }

        public DodajZaposlenogForma(ProgramerBasic prog)
        {
            InitializeComponent();
            txtBroj.Text = prog.BrojKuce.ToString();
            txtGrad.Text = prog.Grad;
            txtIme.Text = prog.Ime;
            txtJMBG.Text = prog.JMBG.ToString();
            txtPrezime.Text = prog.Prezime;
            txtUlica.Text = prog.NazivUlica;
            btnDodajZaposlenog.Text = "Azuriraj programera";
            this.Text = "Azuriraj programera";
            programer = new ProgramerBasic();
            projektant = new StarijiProjektantBasic();
            id = prog.IDZaposljenog;
            btnTelefon.Enabled=provera();
        }

        public DodajZaposlenogForma(StarijiProjektantBasic proj)
        {
            InitializeComponent();
            txtBroj.Text = proj.BrojKuce.ToString();
            txtGrad.Text = proj.Grad;
            txtIme.Text = proj.Ime;
            txtJMBG.Text = proj.JMBG.ToString();
            txtPrezime.Text = proj.Prezime;
            txtUlica.Text = proj.NazivUlica;
            btnDodajZaposlenog.Text = "Azuriraj starijeg projektanta";
            this.Text = "Azuriraj starijeg projektanta";
            programer = new ProgramerBasic();
            projektant = new StarijiProjektantBasic();
            id = proj.IDZaposljenog;
            btnTelefon.Enabled = provera();
        }

        private void btnDodajZaposlenog_Click(object sender, EventArgs e)
        {
            if (this.Text == "Dodajte novog programera")
            {
                programer.Ime = txtIme.Text;
                programer.Prezime = txtPrezime.Text;
                programer.JMBG = long.Parse(txtJMBG.Text);
                programer.Grad = txtGrad.Text;
                programer.NazivUlica = txtUlica.Text;
                programer.BrojKuce = int.Parse(txtBroj.Text);
                DTOManager.DodajProgramera(programer);
                id = programer.IDZaposljenog;
                btnTelefon.Enabled = provera();
            }
            else if(this.Text == "Dodajte novog projektanta")
            {
                projektant.Ime = txtIme.Text;
                projektant.Prezime = txtPrezime.Text;
                projektant.JMBG = long.Parse(txtJMBG.Text);
                projektant.Grad = txtGrad.Text;
                projektant.NazivUlica = txtUlica.Text;
                projektant.BrojKuce = int.Parse(txtBroj.Text);
                DTOManager.DodajStarijegProjektanta(projektant);
                id = projektant.IDZaposljenog;
                btnTelefon.Enabled=provera();
            }
            else if(this.Text == "Azuriraj programera")
            {
                programer.Ime = txtIme.Text;
                programer.Prezime = txtPrezime.Text;
                programer.JMBG = long.Parse(txtJMBG.Text);
                programer.Grad = txtGrad.Text;
                programer.NazivUlica = txtUlica.Text;
                programer.BrojKuce = int.Parse(txtBroj.Text);
                DTOManager.AzurirajProgramera(programer,id);
            }
            else
            {
                projektant.Ime = txtIme.Text;
                projektant.Prezime = txtPrezime.Text;
                projektant.JMBG = long.Parse(txtJMBG.Text);
                projektant.Grad = txtGrad.Text;
                projektant.NazivUlica = txtUlica.Text;
                projektant.BrojKuce = int.Parse(txtBroj.Text);
                DTOManager.AzurirajStarijegProjektanta(projektant,id);
            }
            Osvezi();
        }

        private void txtIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBroj_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            if (txtIme.Text != String.Empty && txtPrezime.Text != String.Empty && txtJMBG.Text != String.Empty&&txtBroj.Text!=String.Empty&&txtGrad.Text!=String.Empty&&txtUlica.Text!=String.Empty)
            {
                btnDodajZaposlenog.Enabled = true;
               
            }
            else
            {
                btnDodajZaposlenog.Enabled = false;
                
            }
        }

        private void Osvezi()
        {

            txtBroj.Text = String.Empty;
            txtGrad.Text = String.Empty;
            txtIme.Text = String.Empty;
            txtJMBG.Text = String.Empty;
            txtPrezime.Text = String.Empty;
            txtUlica.Text = String.Empty;
        }

        private bool provera()
        {
            if (id != 0)
                return true;
            return false;
        }

        private void btnTelefon_Click(object sender, EventArgs e)
        {
            DodajTelefonForma a = new DodajTelefonForma(id);
            a.Text = a.Text + " " + "zaposlenom";
            this.Hide();
            if (a.ShowDialog() == DialogResult.OK)
                a.Show();
            this.Show();
        }
    }
}
