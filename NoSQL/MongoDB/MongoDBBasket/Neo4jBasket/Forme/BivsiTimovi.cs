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
    public partial class BivsiTimovi : Form
    {
        private ObjectId trener;

        public BivsiTimovi(ObjectId tr)
        {
            InitializeComponent();
            trener = tr;
        }

        private void BivsiTimovi_Load(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Basket");

            var collection = database.GetCollection<Trener>("trener");
            Trener tr = collection.FindOneByIdAs<Trener>(trener);

            List<Tim> timovi = new List<Tim>();

            foreach(MongoDBRef re in tr.trenirao)
            {
                Tim tim = database.FetchDBRefAs<Tim>(re);
                timovi.Add(tim);
            }

            dataGridView1.DataSource = timovi;

            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["trener"].Visible = false;
            
        }
    }
}
