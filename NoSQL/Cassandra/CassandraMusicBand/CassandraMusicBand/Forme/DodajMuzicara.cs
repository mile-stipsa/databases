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
    public partial class DodajMuzicara : Form
    {
        private String bendID;
        public DodajMuzicara(String bend)
        {
            InitializeComponent();
            bendID = bend;
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DataProvider.dodajMuzicara(txtIme.Text, txtPrezime.Text, txtNadimak.Text, txtInstrument.Text, bendID))
            {
                MessageBox.Show("Uspesno dodat muzicar!");
                this.Close();
            }
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            if(txtIme.Text!=String.Empty&&txtPrezime.Text!=String.Empty&&txtNadimak.Text!=String.Empty&&txtInstrument.Text!=String.Empty)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void txtIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }
    }
}
