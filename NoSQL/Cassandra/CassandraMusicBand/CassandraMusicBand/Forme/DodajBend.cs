using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CassandraMusicBand.Entiteti;
using CassandraMusicBand.Konekcija;

namespace CassandraMusicBand.Forme
{
    public partial class DodajBend : Form
    {
        public DodajBend()
        {
            InitializeComponent();
            btnDodaj.Enabled = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (DataProvider.DodajBend(txtIme.Text, txtStil.Text, txtDatum.Text))
            {
                MessageBox.Show("Uspesno dodat bend!");
            }
            this.Close();
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            if(txtIme.Text!=String.Empty&&txtDatum.Text!=String.Empty&&txtStil.Text!=String.Empty)
            {
                btnDodaj.Enabled = true;
            }
            else
            {
                btnDodaj.Enabled = false;
            }
        }

        private void txtIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !e.KeyChar.Equals('-');
        }

        private void txtDatum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !e.KeyChar.Equals('.');
        }

        private void txtStil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }

    }
}
