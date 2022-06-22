using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Softverska_kompanija.DTO;

namespace Softverska_kompanija
{
    public partial class StarijiProjektantForma : Form
    {
        private int ID;
        private String ime;
        private String prezime;

        public StarijiProjektantForma(int id,String ime,String prezime)
        {
            InitializeComponent();
            dgvProjekti.BackgroundColor = Color.White;
            this.ime = ime;
            this.prezime = prezime;
            this.ID = id;
            this.Text =this.Text+": "+ this.ime + " " + this.prezime;
        }

        private void StarijiProjektantForma_Load(object sender, EventArgs e)
        {

            List<FirmaPRBasic> projekti = DTOManager.rukovodiProjektima(ID);
            if(projekti.Count!=0)
                dgvProjekti.DataSource=projekti;
            else
                dgvProjekti.DataSource = null;
        }

       

        private void dgvProjekti_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FirmaPRBasic firma = (FirmaPRBasic)dgvProjekti.SelectedRows[0].DataBoundItem;
            ZaposleniNaProjektu a = new ZaposleniNaProjektu(firma.IDProjekta);
            a.Text += " " + "programeri";

            this.Hide();
            if (a.ShowDialog() == DialogResult.OK)
            {
                a.Show();
            }
            this.Show();
        }
    }
}
