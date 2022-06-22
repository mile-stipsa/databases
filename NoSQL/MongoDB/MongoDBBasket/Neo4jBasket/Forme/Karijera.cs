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
    public partial class Karijera : Form
    {
        private ObjectId igr;

        public Karijera(ObjectId igr)
        {
            InitializeComponent();
            this.igr = igr;
        }

        private void Karijera_Load(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Basket");

            var collection = database.GetCollection<Igrac>("igrac");
            Igrac igrac = collection.FindOneByIdAs<Igrac>(igr);

            List<Tim> timovi = new List<Tim>();

            foreach (MongoDBRef re in igrac.igrao)
            {
                Tim tim = database.FetchDBRefAs<Tim>(re);
                timovi.Add(tim);
            }

            dgvTimovi.DataSource = timovi;

            dgvTimovi.Columns["Id"].Visible = false;
            dgvTimovi.Columns["trener"].Visible = false;

            List<Statistika> statistike = new List<Statistika>();

            foreach (MongoDBRef re in igrac.statistika)
            {
                Statistika stat = database.FetchDBRefAs<Statistika>(re);
                statistike.Add(stat);
            }

            dgvStatistika.DataSource = statistike;
            dgvStatistika.Columns["Id"].Visible = false;
            dgvStatistika.Columns["igrac"].Visible = false;
            dgvStatistika.Columns["utakmica"].Visible = false;


        }
    }
}
