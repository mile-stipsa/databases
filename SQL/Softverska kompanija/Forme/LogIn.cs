using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using NHibernate;
using Softverska_kompanija.Entiteti;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Softverska_kompanija.DTO;

namespace Softverska_kompanija
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            btnPrijava.Enabled = false;
            btnPrijava.BackColor = Color.SlateGray;
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            String ime = txtIme.Text;
            String prezime = txtPrezime.Text;
            long JMBG = long.Parse(txtJMBG.Text);
            if (ime == "admin" && prezime == "admin" && JMBG == 1234)
            {

                AdministratorForma a = new AdministratorForma();
                this.Hide();
                if (a.ShowDialog() == DialogResult.OK)
                {
                    a.Show();
                }
                Osvezi();
                this.Show();
                return;
            }
            Zaposleni z = Prijava(ime, prezime, JMBG);

            if (z != null)
            {
                if (z.GetType() == typeof(StarijiProjektant))
                {

                    StarijiProjektantForma a = new StarijiProjektantForma(z.IDZaposljenog, z.Ime, z.Prezime);
                    this.Hide();
                    if (a.ShowDialog() == DialogResult.OK)
                    {
                        a.Show();
                    }
                    Osvezi();
                    this.Show();
                    return;
                }
                else if (z.GetType() == typeof(Programer))
                {
                    ProgramerForma a = new ProgramerForma(z.IDZaposljenog, z.Ime, z.Prezime);
                    this.Hide();
                    if (a.ShowDialog() == DialogResult.OK)
                    {
                        a.Show();
                    }
                    Osvezi();
                    this.Show();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Neuspesna prijava,pokusajte ponovo", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }


        private Zaposleni Prijava(String I, String P, long JMBG1)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                Zaposleni zaposleni = s.QueryOver<Zaposleni>().Where(x => x.Ime == I).Where(x => x.Prezime == P).Where(x => x.JMBG == JMBG1).SingleOrDefault();
                return zaposleni;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                s.Close();
            }
          
        }

        private void txtIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar)&&!char.IsControl(e.KeyChar);
        }

        private void txtJMBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            if (txtIme.Text != String.Empty && txtPrezime.Text != String.Empty && txtJMBG.Text != String.Empty)
            {
                btnPrijava.Enabled = true;
                btnPrijava.BackColor = Color.Black;
            }
            else
            {
                btnPrijava.Enabled = false;
                btnPrijava.BackColor = Color.SlateGray;
            }
        }
        private void Osvezi()
        {
            txtIme.Text = String.Empty;
            txtJMBG.Text = String.Empty;
            txtPrezime.Text = String.Empty;
        }
    }
}
