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
    public partial class DodajPevaca : Form
    {
        private String bendID;
        public DodajPevaca(String bend)
        {
            InitializeComponent();
            bendID = bend;
            btnDodaj.Enabled = false;
        }

        private void DodajPevaca_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(DataProvider.dodajPevaca(txtIme.Text,txtPrezime.Text,txtNadimak.Text,bendID))
            {
                MessageBox.Show("Uspesno ste dodali pevaca");
            }
            this.Close();
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            if(txtIme.Text!=String.Empty&&txtPrezime.Text!=String.Empty&&txtNadimak.Text!=String.Empty)
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
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }
    }
}
