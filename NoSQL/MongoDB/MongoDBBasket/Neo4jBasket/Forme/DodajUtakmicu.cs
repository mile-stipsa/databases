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
    public partial class DodajUtakmicu : Form
    {

        private ObjectId IDtima;

        public DodajUtakmicu(ObjectId id)
        {
            InitializeComponent();
            IDtima=id;
            btnDodaj.Enabled = false;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dodajUtakmicu()
        {

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Basket");

            var collection = database.GetCollection<Tim>("tim");
            var collectionGame = database.GetCollection<Utakmica>("utakmica");
            Tim tim = collection.FindOneByIdAs<Tim>(IDtima);

            Utakmica a=new Utakmica();
            a.rezultat = txtRezultat.Text;
            a.tim1 = new MongoDBRef("tim", tim.Id);

            var query = Query.EQ("ime", txtProtivnik.Text);
            Tim tim2 = collection.FindOneAs<Tim>(query);



            if (tim2 == null)
            {
                KreirajKlub b = new KreirajKlub(txtProtivnik.Text);

                if (b.ShowDialog() == DialogResult.OK)
                {
                    b.Show();
                }

                b.Close();

                tim2 = b.tim;
                collection.Insert(tim2);
            }

            a.tim2 = new MongoDBRef("tim", tim2.Id);
            collectionGame.Insert(a);
            tim2.utakmice.Add(new MongoDBRef("utakmica", a.Id));
            collection.Save(tim2);
            tim.utakmice.Add(new MongoDBRef("utakmica", a.Id));
            collection.Save(tim);
            

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            dodajUtakmicu();
            this.Close();
        }

        private void txtProtivnik_TextChanged(object sender, EventArgs e)
        {
            if(txtProtivnik.Text!=String.Empty&&txtRezultat.Text!=String.Empty&&txtRezultat.Text.Contains(":"))
            {
                btnDodaj.Enabled = true;
            }
            else
            {
                btnDodaj.Enabled = false;
            }
        }

        private void txtRezultat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !e.KeyChar.Equals(':');
        }

        private void txtProtivnik_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)&&!char.IsSeparator(e.KeyChar);
        }
    }
}
