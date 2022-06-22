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
    public partial class Dodaj_pesmu : Form
    {
        private String albumID;
        private String bendID;
        private String datum;

        public Dodaj_pesmu(String album,String dtm,String bnd)
        {
            InitializeComponent();
            albumID = album;
            bendID = bnd;
            datum = dtm;
            btnDodaj.Enabled = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (DataProvider.dodajPesmu(txtNaziv.Text, txtTrajanje.Text, datum, albumID))
            {
                DataProvider.updateAlbum(albumID, DataProvider.brojPesama2.ToString(), bendID);
                MessageBox.Show("Uspesno ste dodali pesmu na albumu!");
                this.Close();
            }
        }

        private void txtTrajanje_TextChanged(object sender, EventArgs e)
        {
            if(txtNaziv.Text!=String.Empty && txtTrajanje.Text!=String.Empty)
            {
                btnDodaj.Enabled = true;
            }
            else
            {
                btnDodaj.Enabled = false;
            }
        }

        private void txtNaziv_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txtTrajanje_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !e.KeyChar.Equals(':')&&!char.IsControl(e.KeyChar);
        }

    }
}
