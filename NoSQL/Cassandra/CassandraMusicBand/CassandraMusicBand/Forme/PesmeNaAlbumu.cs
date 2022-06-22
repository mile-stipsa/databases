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

namespace CassandraMusicBand.Forme
{
    public partial class PesmeNaAlbumu : Form
    {
        private String albumID;
        private String bendID;
        private String datum;

        public PesmeNaAlbumu(String albID,String dat,String bend)
        {
            InitializeComponent();
            albumID = albID;
            bendID = bend;
            datum = dat;
        }

        private void PesmeNaAlbumu_Load(object sender, EventArgs e)
        {
            List<Pesma> pesme = DataProvider.VratiPesme(albumID);
            dgvPesme.DataSource = pesme;
            dgvPesme.Columns["AlbumID"].Visible = false;
            dgvPesme.Columns["PesmaID"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dodaj_pesmu a = new Dodaj_pesmu(albumID,datum,bendID);
            if (a.ShowDialog() == DialogResult.OK)
            {
                a.Show();
            }
            a.Close();
            PesmeNaAlbumu_Load(sender, e);
        }
    }
}
