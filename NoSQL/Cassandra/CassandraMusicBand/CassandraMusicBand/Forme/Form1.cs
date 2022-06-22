using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CassandraMusicBand.Konekcija;
using CassandraMusicBand.Entiteti;
using CassandraMusicBand.Forme;
using Cassandra;

namespace CassandraMusicBand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Bend> bendovi = DataProvider.VratiBendove();
            
            dgvBendovi.DataSource = bendovi;
            dgvBendovi.Columns["BendID"].Visible = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajBend a = new DodajBend();
            
            if(a.ShowDialog()==DialogResult.OK)
            {
                a.Show();
            }
            a.Close();
            Form1_Load(sender, e);
        }

        private void dgvBendovi_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvBendovi.SelectedRows.Count != 0)
            {
                Bend bend = (Bend)dgvBendovi.SelectedRows[0].DataBoundItem;

                BendForma a = new BendForma(bend.BendID);
                if (a.ShowDialog() == DialogResult.OK)
                {
                    a.Show();
                }
                a.Close();
                Form1_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Niste izabrali bend!");
            }
        }
    }
}
