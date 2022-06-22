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
    public partial class BendForma : Form
    {
        private String bendID;
        private String menadzerID;

        public BendForma(String bend)
        {
            InitializeComponent();
            bendID = bend;
            menadzerID = "";

        }

        private void BendForma_Load(object sender, EventArgs e)
        {
            Bend bend = DataProvider.VratiBend(bendID);
            label1.Text = "Naziv benda: " + bend.ime;
            label2.Text = "Stil: " + bend.stil;

            List<Muzicar> muzicari = DataProvider.VratiMuzicare(bendID);
            dgvMuzicari.DataSource = muzicari;
            dgvMuzicari.Columns["BendID"].Visible = false;
            dgvMuzicari.Columns["MuzicarID"].Visible = false;

            List<Pevac> pevaci = DataProvider.VratiPevace(bendID);
            dgvPevaci.DataSource = pevaci;
            dgvPevaci.Columns["PevacID"].Visible = false;
            dgvPevaci.Columns["BendID"].Visible = false;

            List<Album> albumi = DataProvider.VratiAlbume(bendID);
            dgvAlbumi.DataSource = albumi;
            dgvAlbumi.Columns["AlbumID"].Visible = false;
            dgvAlbumi.Columns["BendID"].Visible = false;

            List<Koncert> koncerti = DataProvider.VratiKoncerte(bendID);
            dataGridView1.DataSource = koncerti;
            dataGridView1.Columns["BendID"].Visible = false;
            dataGridView1.Columns["KoncertID"].Visible = false;

            Menadzer menadzer = DataProvider.VratiMenadzera(bendID);
            if(menadzer.MenadzerID!=null)
            {
                label7.Text = "Ime: " + menadzer.ime;
                label8.Text = "Prezime: " + menadzer.prezime;
                menadzerID = menadzer.MenadzerID;
                btnDodajMenadzera.Enabled = false;
                btnOtpustiMenadzera.Enabled = true;
            }
            else
            {
                label7.Text = "Ime: ";
                label8.Text = "Prezime: ";
                menadzerID =string.Empty;
                btnDodajMenadzera.Enabled = true;
                btnOtpustiMenadzera.Enabled = false;
            }
        }

        private void btnObrisiMuzicara_Click(object sender, EventArgs e)
        {
            if(dgvMuzicari.SelectedRows.Count!=0)
            {
                Muzicar muz = (Muzicar)(dgvMuzicari.SelectedRows[0].DataBoundItem);
                if(DataProvider.obrisiMuzicara(muz.MuzicarID))
                {
                    MessageBox.Show("Uspesno ste obrisali muzicara");
                }
                BendForma_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Niste selektovali muzicara!");
            }
        }

        private void btnOtpustiPevaca_Click(object sender, EventArgs e)
        {
            if (dgvPevaci.SelectedRows.Count != 0)
            {
                Pevac pevac = (Pevac)(dgvPevaci.SelectedRows[0].DataBoundItem);
                if(DataProvider.obrisiPevaca(pevac.PevacID))
                {
                    MessageBox.Show("Uspesno ste obrisali pevaca");
                }
                BendForma_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Niste selektovali pevaca!");
            }
        }

        private void btnOtpustiMenadzera_Click(object sender, EventArgs e)
        {
           if(DataProvider.obrisiMenadzera(menadzerID))
            {
                MessageBox.Show("Uspesno ste obrisali menadzera");
            }
            BendForma_Load(sender, e);
        }

        private void btnDodajMuzicara_Click(object sender, EventArgs e)
        {
            DodajMuzicara a = new DodajMuzicara(bendID);
            if (a.ShowDialog() == DialogResult.OK)
            {
                a.Show();
            }
            a.Close();
            BendForma_Load(sender, e);
        }

        private void btnDodajPevaca_Click(object sender, EventArgs e)
        {
            DodajPevaca a = new DodajPevaca(bendID);
            if (a.ShowDialog() == DialogResult.OK)
            {
                a.Show();
            }
            a.Close();
            BendForma_Load(sender, e);
        }

        private void btnDodajAlbum_Click(object sender, EventArgs e)
        {
            DodajAlbum a = new DodajAlbum(bendID);
            if (a.ShowDialog() == DialogResult.OK)
            {
                a.Show();
            }
            a.Close();
            BendForma_Load(sender, e);
        }

        private void btnDodajMenadzera_Click(object sender, EventArgs e)
        {
            DodajMenadzera a = new DodajMenadzera(bendID);
            if (a.ShowDialog() == DialogResult.OK)
            {
                a.Show();
            }
            a.Close();
            BendForma_Load(sender, e);
        }

        private void btnDodajKoncert_Click(object sender, EventArgs e)
        {
            DodajKoncert a = new DodajKoncert(bendID);
            if (a.ShowDialog() == DialogResult.OK)
            {
                a.Show();
            }
            a.Close();
            BendForma_Load(sender, e);
        }

        private void dgvAlbumi_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvAlbumi.SelectedRows.Count != 0)
            {
                Album alb = (Album)(dgvAlbumi.SelectedRows[0].DataBoundItem);

                PesmeNaAlbumu a = new PesmeNaAlbumu(alb.AlbumID,alb.datumizlaska,bendID);
                if(a.ShowDialog()==DialogResult.OK)
                {
                    a.Show();
                }
                a.Close();
            }
            else
            {
                MessageBox.Show("Niste izabrali album");
            }
            BendForma_Load(sender, e);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PromeniIme a = new PromeniIme(bendID);

            if(a.ShowDialog()==DialogResult.OK)
            {
                a.Show();
            }
            a.Close();
            BendForma_Load(sender, e);
        }

    }
}
