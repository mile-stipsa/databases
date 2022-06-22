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
    public partial class Dostignuca : Form
    {
        private ObjectId IDtima;

        public Dostignuca(ObjectId id)
        {
            InitializeComponent();
            IDtima = id;
           
        }

        private void Dostignuca_Load(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Basket");

            var collection = database.GetCollection("tim");

           
            Tim tim = collection.FindOneByIdAs<Tim>(IDtima);
         
            List<Godina> godine = new List<Godina>();

            foreach(MongoDBRef re in tim.dostignuca)
            {
                Godina god = database.FetchDBRefAs<Godina>(re);
                godine.Add(god);
            }

            dgvEvroligaPobednik.DataSource = godine;
            dgvEvroligaPobednik.Columns["Id"].Visible = false;
            dgvEvroligaPobednik.Columns["tim"].Visible = false;
        }

        private void btnEvroligaPobednik_Click(object sender, EventArgs e)
        {
            DodajDostignuce a = new DodajDostignuce(IDtima);
            a.Text = "Pobednik Evrolige";

            if(a.ShowDialog()==DialogResult.OK)
            {
                a.Show();
            }
            a.Close();
            Dostignuca_Load(sender, e);
        }

        private void btnEvroligaVicesampion_Click(object sender, EventArgs e)
        {
            DodajDostignuce a = new DodajDostignuce(IDtima);
            a.Text = "Vicesampion Evrolige";
           

            if (a.ShowDialog() == DialogResult.OK)
            {
                a.Show();
            }
            a.Close();
            Dostignuca_Load(sender, e);
        }

        private void btnEvrokupPobednik_Click(object sender, EventArgs e)
        {
            DodajDostignuce a = new DodajDostignuce(IDtima);
            a.Text = "Pobednik Evrokupa";
           

            if (a.ShowDialog() == DialogResult.OK)
            {
                a.Show();
            }
            a.Close();

            Dostignuca_Load(sender, e);
        }
    }
}
