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
    public partial class DodajDostignuce : Form
    {
       
        private ObjectId IDTima;

        public DodajDostignuce(ObjectId id)
        {
            InitializeComponent();
            IDTima = id;
            btnDodaj.Enabled = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Basket");

            var collection = database.GetCollection("tim");
            var secCol = database.GetCollection("dostignuca");

           

            Tim tim = collection.FindOneByIdAs<Tim>(IDTima);
            Godina a = new Godina();
            a.godina = textBox1.Text;
            a.takmicenje = textBox2.Text;

            a.tim = new MongoDBRef("tim", tim.Id);

            secCol.Insert(a);

            tim.dostignuca.Add(new MongoDBRef("dostignuca", a.Id));
            collection.Save(tim);

            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                btnDodaj.Enabled = true;
            }
            else
            {
                btnDodaj.Enabled = false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
