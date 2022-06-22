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

namespace Neo4jBasket.Forme
{
    public partial class Dostignuca : Form
    {
        public GraphClient client;
        private String nazivTima;
        public Dostignuca(String naziv)
        {
            InitializeComponent();
            nazivTima = naziv;
        }

        private void Dostignuca_Load(object sender, EventArgs e)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("ime", nazivTima);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[r:Evroliga]->(m) where n.ime =~ {ime} return m",
                                                          queryDict, CypherResultMode.Set);

            List<Godina> godina1 = ((IRawGraphClient)client).ExecuteGetCypherResults<Godina>(query).ToList();
            dgvEvroligaPobednik.DataSource = godina1;

            var query1 = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[r:Vicesampion]->(m) where n.ime =~ {ime} return m",
                                                         queryDict, CypherResultMode.Set);

            List<Godina> godina2= ((IRawGraphClient)client).ExecuteGetCypherResults<Godina>(query1).ToList();
            dgvEvroligaVicesampion.DataSource = godina2;

            var query2 = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[r:Evrokup]->(m) where n.ime =~ {ime} return m",
                                                         queryDict, CypherResultMode.Set);

            List<Godina> godina3 = ((IRawGraphClient)client).ExecuteGetCypherResults<Godina>(query2).ToList();
            dgvEvrokupPobednik.DataSource = godina3;
        }

        private void btnEvroligaPobednik_Click(object sender, EventArgs e)
        {
            DodajDostignuce a = new DodajDostignuce(nazivTima);
            a.Text = "Pobednik Evrolige";
            a.client = client;

            if(a.ShowDialog()==DialogResult.OK)
            {
                a.Show();
            }
            a.Close();
            Dostignuca_Load(sender, e);
        }

        private void btnEvroligaVicesampion_Click(object sender, EventArgs e)
        {
            DodajDostignuce a = new DodajDostignuce(nazivTima);
            a.Text = "Vicesampion Evrolige";
            a.client = client;

            if (a.ShowDialog() == DialogResult.OK)
            {
                a.Show();
            }
            a.Close();
            Dostignuca_Load(sender, e);
        }

        private void btnEvrokupPobednik_Click(object sender, EventArgs e)
        {
            DodajDostignuce a = new DodajDostignuce(nazivTima);
            a.Text = "Pobednik Evrokupa";
            a.client = client;

            if (a.ShowDialog() == DialogResult.OK)
            {
                a.Show();
            }
            a.Close();

            Dostignuca_Load(sender, e);
        }
    }
}
