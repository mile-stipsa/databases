using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neo4jClient;
using Neo4jClient.Cypher;
using Neo4jBasket.Entiteti;
using Neo4jBasket.Forme;

namespace Neo4jBasket
{
    public partial class BasketballApp : Form
    {
        private GraphClient client;

        public BasketballApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "stellarosa");
            try
            {
                client.Connect();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            ucitajTimove();
        }

        private void ucitajTimove()
       {
            List<Tim> timovi = client.Cypher.Match("(n:Klub)").Return(n=>n.As<Tim>()).Results.ToList();
            dgvTimovi.DataSource = timovi;
        }

        private void dgvTimovi_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Tim tim = (Tim)dgvTimovi.SelectedRows[0].DataBoundItem;
            KlubFormacs a = new KlubFormacs(tim.ime);
            a.client = client;
            if(a.ShowDialog()==DialogResult.OK)
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

                Dostignuca a = new Dostignuca(tim.ime);
                a.client = client;

                if(a.ShowDialog()==DialogResult.OK)
                {
                    a.Show();
                }
                a.Close();
               
            }
        }

       
    }
}
