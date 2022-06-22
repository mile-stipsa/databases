using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CassandraMusicBand.Forme;

namespace CassandraMusicBand.Forme
{
    public partial class DodajAlbum : Form
    {
        private String bendID;
        private String datum;

        public DodajAlbum(String bend)
        {
            InitializeComponent();
            bendID = bend;
            btnDodajPesmu.Enabled=false;
            btnDodajAlbum.Enabled = false;
        }

        private void btnDodajPesmu_Click(object sender, EventArgs e)
        {
            Dodaj_pesmu a = new Dodaj_pesmu(DataProvider.brojAlbuma.ToString(),datum,bendID);
            if (a.ShowDialog() == DialogResult.OK)
            {
                a.Show();
            }
            a.Close();
        }

        private void btnDodajAlbum_Click(object sender, EventArgs e)
        {
            if(DataProvider.dodajAlbum(txtNaziv.Text,txtDatum.Text,bendID))
            {
                datum = txtDatum.Text;
                MessageBox.Show("Uspesno ste dodali album, sad mozete dodati i pesme na tom albumu!");
                btnDodajPesmu.Enabled = true;
            }
        }

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {
            if(txtDatum.Text!=String.Empty&&txtNaziv.Text!=String.Empty)
            {
                btnDodajAlbum.Enabled = true;
            }
            else
            {
                btnDodajAlbum.Enabled = false;
            }
        }

        private void txtNaziv_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !e.KeyChar.Equals('-');
        }

        private void txtDatum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !e.KeyChar.Equals('.')&&!char.IsControl(e.KeyChar);
        }

    }
}
