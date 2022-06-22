using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CassandraMusicBand.Forme
{
    public partial class DodajKoncert : Form
    {
        private String bendID;

        public DodajKoncert(String bend)
        {
            InitializeComponent();
            bendID = bend;
            btnDodaj.Enabled = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(DataProvider.dodajKoncert(txtGrad.Text,txtDatum.Text,bendID))
            {
                MessageBox.Show("Uspesno ste dodali koncert!");
                this.Close();
            }
        }

        private void txtGrad_TextChanged(object sender, EventArgs e)
        {
            if(txtDatum.Text!=String.Empty&&txtGrad.Text!=String.Empty)
            {
                btnDodaj.Enabled = true;
            }
            else
            {
                btnDodaj.Enabled = false;
            }
        }

        private void txtDatum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&!e.KeyChar.Equals('.');
        }

        private void txtGrad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) &&  !char.IsLetter(e.KeyChar);
        }

    }
}
