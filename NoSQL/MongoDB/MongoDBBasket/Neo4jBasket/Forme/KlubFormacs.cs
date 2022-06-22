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
    public partial class KlubFormacs : Form
    {
        private ObjectId IDTima;

        private Trener tr;


        public KlubFormacs(ObjectId id)
        {
            InitializeComponent();
            IDTima = id;
            tr = new Trener();
            dgvUtakmice.Columns.Add("Domacin", "Domacin");
            dgvUtakmice.Columns.Add("Gost", "Gost");
            dgvUtakmice.Columns.Add("Rezultat", "Rezultat");
        }

        private void KlubFormacs_Load(object sender, EventArgs e)
        {
            lblIme.Text = "Ime:";
            lblPrezime.Text = "Prezime:";
            lblGodina.Text = "Godina rodjenja:";
            vratiIgrace();
            vratiTrenera();
            vratiUtakmice();

            
        }

        private void vratiIgrace()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Basket");

            var collection = database.GetCollection<Tim>("tim");
            Tim tim = collection.FindOneByIdAs<Tim>(IDTima);

            List<Igrac> igraci = new List<Igrac>();

            foreach(MongoDBRef re in tim.igra)
            {
                Igrac igrac = database.FetchDBRefAs<Igrac>(re);
                igraci.Add(igrac);
            }

            dgvIgraci.DataSource = igraci;
            dgvIgraci.Columns["Id"].Visible = false;
            dgvIgraci.Columns["igra"].Visible = false;
        }

        private void vratiTrenera()
        {


            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Basket");

            var collection = database.GetCollection<Tim>("tim");
            Tim tim = collection.FindOneByIdAs<Tim>(IDTima);

            if (tim.trener == null)
            {
                DodajTrenera a = new DodajTrenera(IDTima);
           

                if (a.ShowDialog() == DialogResult.OK)
                {
                    a.Show();
                }
                a.Close();

                

                tr = a.tr;
            }
            else
            {
                Trener t = database.FetchDBRefAs<Trener>(tim.trener);
                tr = t;
            }
            

            lblIme.Text += " " + tr.ime;
            lblPrezime.Text += " " + tr.prezime;
            lblGodina.Text += " " + tr.godinarod;
        }

        private void vratiUtakmice()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var server = MongoServer.Create(connectionString);
            var database = server.GetDatabase("Basket");

            var collection = database.GetCollection<Tim>("tim");
            Tim tim = collection.FindOneByIdAs<Tim>(IDTima);

            dgvUtakmice.Rows.Clear();
           

            foreach (MongoDBRef re in tim.utakmice)
            {
                Utakmica utakmica = database.FetchDBRefAs<Utakmica>(re);

                Tim tim1 = database.FetchDBRefAs<Tim>(utakmica.tim1);
                Tim tim2 = database.FetchDBRefAs<Tim>(utakmica.tim2);

                String[] row = { tim1.ime, tim2.ime, utakmica.rezultat };

                dgvUtakmice.Rows.Add(row);

            }
           
        }

        private void otpustiIgraca()
        {
            if (dgvIgraci.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nije selektovan igrac!");
            }
            else
            {
                Igrac igrac = (Igrac)dgvIgraci.SelectedRows[0].DataBoundItem;

                var connectionString = "mongodb://localhost/?safe=true";
                var server = MongoServer.Create(connectionString);
                var database = server.GetDatabase("Basket");

                var collection = database.GetCollection<Igrac>("igrac");



                Tim tim = database.FetchDBRefAs<Tim>(igrac.igra);

                igrac.igra = null;
                igrac.igrao.Add(new MongoDBRef("tim", tim.Id));

                collection.Save(igrac);

                for (int i = 0; i < tim.igra.Count; i++)
                {
                    Igrac igr = database.FetchDBRefAs<Igrac>(tim.igra[i]);
                    if (igr.Id == igrac.Id)
                    {
                        tim.igra.RemoveAt(i);
                        break;
                    }
                }
                var collectionT = database.GetCollection<Tim>("tim");

                collectionT.Save(tim);
            }

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            otpustiIgraca();
            KlubFormacs_Load(sender, e);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajIgraca a = new DodajIgraca(IDTima);
           

            if (a.ShowDialog() == DialogResult.OK)
            {
                a.Show();
            }
            a.Close();

            KlubFormacs_Load(sender, e);
        }

        private void btnDodajUtakmicu_Click(object sender, EventArgs e)
        {
            DodajUtakmicu a = new DodajUtakmicu(IDTima);
            

            if(a.ShowDialog()==DialogResult.OK)
            {
                a.Show();
            }
            a.Close();
            KlubFormacs_Load(sender, e);
        }

        private void btnTimovi_Click(object sender, EventArgs e)
        {
            BivsiTimovi a = new BivsiTimovi(tr.Id);
           

            if(a.ShowDialog()==DialogResult.OK)
            {
                a.Show();
            }
            a.Close();
        }

        private void dgvIgraci_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (dgvIgraci.SelectedRows.Count == 0)
            {
                
                MessageBox.Show("Nije selektovan igrac!");
            }
            else
            {
                Igrac igrac = (Igrac)dgvIgraci.SelectedRows[0].DataBoundItem;

                Karijera a = new Karijera(igrac.Id);
                
                if(a.ShowDialog()==DialogResult.OK)
                {
                    a.Show();
                }
                a.Close();
            }
        }
    }
}
