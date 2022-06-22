using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using MongoDBBasket.Entiteti;
using MongoDBBasket.Forme;

namespace MongoDBBasket.Forme
{
    public partial class KreirajKlub : Form
    {
        private String nazivTim;
        public Tim tim;

        public KreirajKlub(String naziv)
        {
            InitializeComponent();
            nazivTim = naziv;
            tim = new Tim();
            btnDodaj.Enabled = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            tim.ime = nazivTim;
            tim.grad = txtGrad.Text;
            tim.dvorana = txtDvorana.Text;

            this.Close();
        }

        private void txtDvorana_TextChanged(object sender, EventArgs e)
        {
            if(txtDvorana.Text!=String.Empty&&txtGrad.Text!=String.Empty)
            {
                btnDodaj.Enabled = true;
            }
            else
            {
                btnDodaj.Enabled = false;
            }
        }

        private void txtDvorana_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)&&!char.IsSeparator(e.KeyChar);
        }
    }
}
