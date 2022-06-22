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
    public partial class DodajTelefonForma : Form
    {
        int id = 0;
        public DodajTelefonForma(int ID)
        {
            InitializeComponent();
            id = ID;
            btnDodaj.Enabled = false;
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !e.KeyChar.Equals('-');
        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefon.Text != String.Empty)
                btnDodaj.Enabled = true;
            else
                btnDodaj.Enabled = false;
        }

        private void DodajTelefonForma_Load(object sender, EventArgs e)
        {
            if (this.Text == "Dodaj telefon zaposlenome")
            {
                List<TelefonBasic> telefoni = DTOManager.UcitajTelefoneZaposlenog(id);
                if(telefoni.Count!=0)
                    dgvTelefoni.DataSource = telefoni;
                else
                    dgvTelefoni.DataSource = null;
            }
            else
            {
                List<STelefonBasic> telefoni = DTOManager.UcitajTelefoneSaradnika(id);
                if(telefoni.Count!=0)
                    dgvTelefoni.DataSource = telefoni;
                else
                    dgvTelefoni.DataSource = null;
            }

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (this.Text == "Dodaj telefon zaposlenome")
            {
                TelefonBasic telefon = new TelefonBasic();
                telefon.BrojTelefona = txtTelefon.Text;
                DTOManager.DodajTelefon(id, telefon);
            }
            else
            {
                STelefonBasic telefon = new STelefonBasic();
                telefon.BrojTelefona = txtTelefon.Text;
                DTOManager.DodajSTelefon(id, telefon);
            }
            DodajTelefonForma_Load(sender, e);
        }

        private void dgvTelefoni_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.Text == "Dodatj telefon zaposlenome")
            {
                TelefonBasic tel = (TelefonBasic)dgvTelefoni.SelectedRows[0].DataBoundItem;
                DTOManager.ObrisiTelefon(tel.TelefonID);
            }
            else
            {
                STelefonBasic tel = (STelefonBasic)dgvTelefoni.SelectedRows[0].DataBoundItem;
                DTOManager.ObrisiSTelefon(tel.TelefonID);
            }
            DodajTelefonForma_Load(sender, e);
        }
    }
}
