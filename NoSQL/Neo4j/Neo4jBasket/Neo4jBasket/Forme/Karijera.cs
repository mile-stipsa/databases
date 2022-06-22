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
    public partial class Karijera : Form
    {
        public GraphClient client;
        private Igrac igrac;
        public Karijera(Igrac igr)
        {
            InitializeComponent();
            igrac = igr;
        }

        private void Karijera_Load(object sender, EventArgs e)
        {
            Dictionary<string, object> queryDict2 = new Dictionary<string, object>();
            queryDict2.Add("ime", igrac.ime);
            queryDict2.Add("prezime", igrac.prezime);
            var query3 = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[r:Igrao]->(m) where n.ime =~ {ime} AND n.prezime =~ {prezime} return m",
                                                     queryDict2, CypherResultMode.Set);
            List<Tim> tim2 = ((IRawGraphClient)client).ExecuteGetCypherResults<Tim>(query3).ToList();

            dgvTimovi.DataSource = tim2;

            var query2 = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[r:Ucinak]->(m) where n.ime =~ {ime} AND n.prezime =~ {prezime} return m",
                                                     queryDict2, CypherResultMode.Set);
            List<Statistika> stat = ((IRawGraphClient)client).ExecuteGetCypherResults<Statistika>(query2).ToList();

            dgvStatistika.DataSource = stat;
        }
    }
}
