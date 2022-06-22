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
    public partial class KlubFormacs : Form
    {
        private String nazivTima;
        public GraphClient client;
        private Trener tr;


        public KlubFormacs(String naziv)
        {
            InitializeComponent();
            nazivTima = naziv;
        }

        private void KlubFormacs_Load(object sender, EventArgs e)
        {
            lblIme.Text = "Ime:";
            lblPrezime.Text = "Prezime:";
            lblGodina.Text = "Godina rodjenja:";
            vratiIgrace(nazivTima);
            vratiTrenera(nazivTima);
            vratiUtakmice(nazivTima);
        }

        private void vratiIgrace(String naziv)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("ime", naziv);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[r:Igra]->(m) where n.ime =~ {ime} return m",
                                                          queryDict, CypherResultMode.Set);

           List<Igrac> igraci = ((IRawGraphClient)client).ExecuteGetCypherResults<Igrac>(query).ToList();
            dgvIgraci.DataSource = igraci;
        }

        private void vratiTrenera(String nazivTima)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("ime", nazivTima);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[r:Trenira]->(m) where m.ime =~ {ime} return n",
                                                          queryDict, CypherResultMode.Set);

            Trener trener = ((IRawGraphClient)client).ExecuteGetCypherResults<Trener>(query).FirstOrDefault();

            if(trener==null)
            {
                DodajTrenera a = new DodajTrenera(nazivTima);
                a.client = client;

                if(a.ShowDialog()==DialogResult.OK)
                {
                    a.Show();
                }
                a.Close();

                trener = a.trener;
            }
            tr = trener;

            lblIme.Text += " " + trener.ime;
            lblPrezime.Text += " " + trener.prezime;
            lblGodina.Text += " " + trener.godinarod;
        }

        private void vratiUtakmice(String nazivTima)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("ime", nazivTima);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[r:Tim1]->(m) where m.ime =~ {ime} return n",
                                                          queryDict, CypherResultMode.Set);
            List<Utakmica> utakmice = ((IRawGraphClient)client).ExecuteGetCypherResults<Utakmica>(query).ToList();
            foreach (Utakmica a in utakmice)
            {
                a.tim1 = nazivTima;

                Dictionary<string, object> queryDict1 = new Dictionary<string, object>();
                queryDict1.Add("rezultat", a.rezultat);
                var query2 = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[r:Tim2]->(m) where n.rezultat =~ {rezultat} return m",
                                                         queryDict1, CypherResultMode.Set);
               Tim tim2 = ((IRawGraphClient)client).ExecuteGetCypherResults<Tim>(query2).FirstOrDefault();

                a.tim2 = tim2.ime;

            }

            var query1 = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[r:Tim2]->(m) where m.ime =~ {ime} return n",
                                                         queryDict, CypherResultMode.Set);

            List<Utakmica> utakmice1 = ((IRawGraphClient)client).ExecuteGetCypherResults<Utakmica>(query1).ToList();

            foreach (Utakmica a in utakmice1)
            {
                a.tim2 = nazivTima;

                Dictionary<string, object> queryDict2 = new Dictionary<string, object>();
                queryDict2.Add("rezultat", a.rezultat);
                var query3 = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[r:Tim1]->(m) where n.rezultat =~ {rezultat} return m",
                                                         queryDict2, CypherResultMode.Set);
                Tim tim2 = ((IRawGraphClient)client).ExecuteGetCypherResults<Tim>(query3).FirstOrDefault();

                a.tim1 = tim2.ime;

            }

            utakmice.AddRange(utakmice1);

            dgvUtakmice.DataSource = utakmice;


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

                client.Cypher.OptionalMatch("(igrac1:Igrac)<-[r:Igra]-(klub:Klub)")
                 .Where((Igrac igrac1) => igrac.ime == igrac1.ime).AndWhere((Igrac igrac1) => igrac.prezime == igrac1.prezime)
                 .Delete("r")
                 .ExecuteWithoutResults();

                client.Cypher.Match("(igrac1:Igrac), (klub1:Klub)")
                .Where((Igrac igrac1) => igrac.ime == igrac1.ime).AndWhere((Igrac igrac1) => igrac.prezime == igrac1.prezime).AndWhere((Tim klub1) => klub1.ime == nazivTima)
                .Create("(igrac1)-[:Igrao]->(klub1)")
                .ExecuteWithoutResults();
            }

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            otpustiIgraca();
            KlubFormacs_Load(sender, e);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajIgraca a = new DodajIgraca(nazivTima);
            a.client = client;

            if (a.ShowDialog() == DialogResult.OK)
            {
                a.Show();
            }
            a.Close();

            KlubFormacs_Load(sender, e);
        }

        private void btnDodajUtakmicu_Click(object sender, EventArgs e)
        {
            DodajUtakmicu a = new DodajUtakmicu(nazivTima);
            a.client = client;

            if(a.ShowDialog()==DialogResult.OK)
            {
                a.Show();
            }
            a.Close();
            KlubFormacs_Load(sender, e);
        }

        private void btnTimovi_Click(object sender, EventArgs e)
        {
            BivsiTimovi a = new BivsiTimovi(tr);
            a.client = client;

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

                Karijera a = new Karijera(igrac);
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
