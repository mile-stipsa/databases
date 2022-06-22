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
    public partial class DodajMenadzera : Form
    {
        private String bendID;
        public DodajMenadzera(String bend)
        {
            InitializeComponent();
            bendID = bend;
            btnDodaj.Enabled = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(DataProvider.dodajMenadzera(txtIme.Text,txtPrezime.Text,txtBroj.Text,txtEmail.Text,bendID))
            {
                MessageBox.Show("Uspesno ste dodali menadzera");
                this.Close();
            }
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            if (txtIme.Text != String.Empty && txtPrezime.Text != String.Empty && txtEmail.Text != String.Empty && txtBroj.Text != String.Empty && txtEmail.Text.Contains("@")&&txtEmail.Text.Contains(".com"))
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
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBroj_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !e.KeyChar.Equals('-');
        }

    }
}
