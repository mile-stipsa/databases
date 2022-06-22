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
    public partial class AngazujSaradnikeForma : Form
    {
        private int ID;
        public AngazujSaradnikeForma(int id)
        {
            InitializeComponent();
            btnDodaj.Enabled = false;
            this.ID = id;
        }

        private void txtIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            if (txtIme.Text != String.Empty && txtPrezime.Text != String.Empty)
                btnDodaj.Enabled = true;
            else
                btnDodaj.Enabled = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            SpoljniSaradnikBasic ss = new SpoljniSaradnikBasic();
            ss.SIme = txtIme.Text;
            ss.SPrezime = txtPrezime.Text;
            DTOManager.DodajSpoljnogSaradnika(ID, ss);
            Osvezi();

        }

        private void Osvezi()
        {
            txtIme.Text = String.Empty;
            txtPrezime.Text = String.Empty;
        }

        private void btnDodajTelefon_Click(object sender, EventArgs e)
        {
            DodajTelefonForma a = new DodajTelefonForma(ID);
            a.Text = a.Text + " " + "saradniku";
            this.Hide();
            if (a.ShowDialog() == DialogResult.OK)
                a.Show();
            this.Show();
        }
    }
}
