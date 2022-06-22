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

namespace MongoDBBasket.Forme
{
    public partial class DodajIgraca : Form
    {

        private ObjectId IDTima;

        public DodajIgraca(ObjectId id)
        {
            InitializeComponent();
            IDTima = id;
            btnDodaj.Enabled = false;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dodajIgraca()
        {

            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Basket");

            var collection = database.GetCollection<Tim>("tim");
            var collectionPlayer = database.GetCollection<Igrac>("igrac");
            Tim tim = collection.FindOneByIdAs<Tim>(IDTima);

            var query = Query.And(Query.EQ("ime", txtIme.Text), Query.EQ("prezime", txtPrezime.Text));
            Igrac a=collectionPlayer.FindOneAs<Igrac>(query);



            if (a == null)
            {
                a = new Igrac();
                a.ime = txtIme.Text;
                a.prezime = txtPrezime.Text;
                a.godinarod = txtGodina.Text;
                a.pozicija = txtPozicija.Text;
                a.visina = txtVisina.Text;
                a.igra = new MongoDBRef("tim", tim.Id);
                collectionPlayer.Insert(a);
                tim.igra.Add(new MongoDBRef("igrac", a.Id));

                collection.Save(tim);
            }
            else
            {
                if (a.igra == null)
                {
                    a.igra = new MongoDBRef("tim", tim.Id);
                    collectionPlayer.Save(a);
                    tim.igra.Add(new MongoDBRef("igrac", a.Id));

                    collection.Save(tim);
                }
                else
                {
                    MessageBox.Show("Igrac ima angazman!");
                }
            }

           
           
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            dodajIgraca();
            this.Close();
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            if(txtGodina.Text!=String.Empty&&txtIme.Text!=String.Empty&&txtPozicija.Text!=String.Empty&&txtPrezime.Text!=String.Empty&&txtVisina.Text!=String.Empty)
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
