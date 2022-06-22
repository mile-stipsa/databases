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
    public partial class DodajTrenera : Form
    {

        public Trener tr;
        private ObjectId IDtima;

        public DodajTrenera(ObjectId id)
        {
            InitializeComponent();
            IDtima = id;
            tr = new Trener();
            btnDodaj.Enabled = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Basket");

            var collection = database.GetCollection<Tim>("tim");
            var collectionCoach = database.GetCollection<Trener>("trener");

            Tim tim = collection.FindOneByIdAs<Tim>(IDtima);

            Trener trener=new Trener();
            trener.ime = txtIme.Text;
            trener.prezime = txtPrezime.Text;
            trener.godinarod = txtGodina.Text;
            trener.trenira = new MongoDBRef("tim", tim.Id);
            tr = trener;

            collectionCoach.Insert(trener);

            tim.trener = new MongoDBRef("trener", trener.Id);

            collection.Save(tim);

 
            
            this.Close();
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            if(txtGodina.Text!=String.Empty&&txtIme.Text!=String.Empty&&txtPrezime.Text!=String.Empty)
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

        private void txtGodina_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
