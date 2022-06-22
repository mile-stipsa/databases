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

namespace MongoDBBasket
{
    public partial class BasketballApp : Form
    {
        

        public BasketballApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            ucitajTimove();
            dgvTimovi.Columns["Id"].Visible = false;
            dgvTimovi.Columns["trener"].Visible = false;
        }

        private void ucitajTimove()
       {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Basket");

            var collection = database.GetCollection<Tim>("tim");

            MongoCursor<Tim> timovi = collection.FindAll();

            dgvTimovi.DataSource = timovi.ToList<Tim>();
        }

        private void dgvTimovi_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Tim tim = (Tim)dgvTimovi.SelectedRows[0].DataBoundItem;
            KlubFormacs a = new KlubFormacs(tim.Id);
           
            if (a.ShowDialog() == DialogResult.OK)
            {
                a.Show();
            }
            a.Close();
            Form1_Load(sender, e);
        }

        private void btnDostignuca_Click(object sender, EventArgs e)
        {
            if (dgvTimovi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nije selektovan tim");
            }
            else
            {
                Tim tim = (Tim)dgvTimovi.SelectedRows[0].DataBoundItem;

                Dostignuca a = new Dostignuca(tim.Id);
                

                if (a.ShowDialog() == DialogResult.OK)
                {
                    a.Show();
                }
                a.Close();

            }
        }


    }
}
