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
    public partial class BivsiTimovi : Form
    {
        public GraphClient client;
        private Trener trener;

        public BivsiTimovi(Trener tr)
        {
            InitializeComponent();
            trener = tr;
        }

        private void BivsiTimovi_Load(object sender, EventArgs e)
        {

            Dictionary<string, object> queryDict2 = new Dictionary<string, object>();
            queryDict2.Add("ime", trener.ime);
            queryDict2.Add("prezime", trener.prezime);
            var query3 = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[r:Trenirao]->(m) where n.ime =~ {ime} AND n.prezime =~ {prezime} return m",
                                                     queryDict2, CypherResultMode.Set);
            List<Tim> tim2 = ((IRawGraphClient)client).ExecuteGetCypherResults<Tim>(query3).ToList();

            dataGridView1.DataSource = tim2;
        }
    }
}
