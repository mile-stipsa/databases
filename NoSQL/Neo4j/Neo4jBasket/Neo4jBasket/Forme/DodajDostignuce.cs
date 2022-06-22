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
    public partial class DodajDostignuce : Form
    {
        public GraphClient client;
        private String nazivTima;

        public DodajDostignuce(String naziv)
        {
            InitializeComponent();
            nazivTima = naziv;
            btnDodaj.Enabled = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Godina a = new Godina();
            a.godina = textBox1.Text;

            if(this.Text=="Pobednik Evrolige")
            {

                Dictionary<string, object> queryDict1 = new Dictionary<string, object>();
                queryDict1.Add("godina", a.godina);
                var query1 = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[r:Evroliga]->(m) where m.godina =~ {godina} return m",
                                                          queryDict1, CypherResultMode.Set);

                Godina god = ((IRawGraphClient)client).ExecuteGetCypherResults<Godina>(query1).FirstOrDefault();

                if (god == null)
                {
                    var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Godina {godina:'" + a.godina
                                                            + "'}) return n",
                                                            queryDict1, CypherResultMode.Set);
                    ((IRawGraphClient)client).ExecuteCypher(query);
                }

                client.Cypher.Match("(godina:Godina), (klub1:Klub)")
                    .Where((Godina godina) => godina.godina == a.godina).AndWhere((Tim klub1) => klub1.ime == nazivTima)
                    .Create("(godina)<-[:Evroliga]-(klub1)")
                    .ExecuteWithoutResults();
            }
            else
            {
                if(this.Text=="Vicesampion Evrolige")
                {
                    Dictionary<string, object> queryDict1 = new Dictionary<string, object>();
                    queryDict1.Add("godina", a.godina);
                    var query1 = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[r:Evroliga]->(m) where m.godina =~ {godina} return m",
                                                              queryDict1, CypherResultMode.Set);

                    Godina god = ((IRawGraphClient)client).ExecuteGetCypherResults<Godina>(query1).FirstOrDefault();

                    if (god == null)
                    {
                        var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Godina {godina:'" + a.godina
                                                                + "'}) return n",
                                                                queryDict1, CypherResultMode.Set);
                        ((IRawGraphClient)client).ExecuteCypher(query);
                    }

                    client.Cypher.Match("(godina:Godina), (klub1:Klub)")
                        .Where((Godina godina) => godina.godina == a.godina).AndWhere((Tim klub1) => klub1.ime == nazivTima)
                        .Create("(godina)<-[:Vicesampion]-(klub1)")
                        .ExecuteWithoutResults();
                }
                else
                {
                    Dictionary<string, object> queryDict1 = new Dictionary<string, object>();
                    queryDict1.Add("godina", a.godina);
                    var query1 = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[r:Evroliga]->(m) where m.godina =~ {godina} return m",
                                                              queryDict1, CypherResultMode.Set);

                    Godina god = ((IRawGraphClient)client).ExecuteGetCypherResults<Godina>(query1).FirstOrDefault();

                    if (god == null)
                    {
                        var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Godina {godina:'" + a.godina
                                                                + "'}) return n",
                                                                queryDict1, CypherResultMode.Set);
                        ((IRawGraphClient)client).ExecuteCypher(query);
                    }

                    client.Cypher.Match("(godina:Godina), (klub1:Klub)")
                        .Where((Godina godina) => godina.godina == a.godina).AndWhere((Tim klub1) => klub1.ime == nazivTima)
                        .Create("(godina)<-[:Evrokup]-(klub1)")
                        .ExecuteWithoutResults();
                }
            }
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                btnDodaj.Enabled = true;
            }
            else
            {
                btnDodaj.Enabled = false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
