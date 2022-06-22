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
    public partial class DodajUtakmicu : Form
    {

        public GraphClient client;
        private String nazivTima;
        public DodajUtakmicu(String naziv)
        {
            InitializeComponent();
            nazivTima=naziv;
            btnDodaj.Enabled = false;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dodajUtakmicu()
        {
            Utakmica a=new Utakmica();
            a.rezultat = txtRezultat.Text;

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("rezultat", a.rezultat);

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Utakmica {rezultat:'" + a.rezultat
                                                            + "'}) return n",
                                                            queryDict, CypherResultMode.Set);
            ((IRawGraphClient)client).ExecuteCypher(query);

            client.Cypher.Match("(utakmica:Utakmica), (klub1:Klub)")
                 .Where((Utakmica utakmica) => utakmica.rezultat == a.rezultat).AndWhere((Tim klub1) => klub1.ime == nazivTima)
                 .Create("(utakmica)-[:Tim1]->(klub1)")
                 .ExecuteWithoutResults();

            Dictionary<string, object> queryDict1 = new Dictionary<string, object>();
            queryDict1.Add("ime", txtProtivnik.Text);

            var query1 = new Neo4jClient.Cypher.CypherQuery("start n=node(*) match (n)-[r:Trenira]->(m) where m.ime =~ {ime} return n",
                                                          queryDict1, CypherResultMode.Set);

            Tim tim = ((IRawGraphClient)client).ExecuteGetCypherResults<Tim>(query1).FirstOrDefault();

            if(tim==null)
            {
                KreirajKlub b= new KreirajKlub(txtProtivnik.Text);
                b.client = client;

                if(b.ShowDialog()==DialogResult.OK)
                {
                    b.Show();
                }
                b.Close();
            }

            client.Cypher.Match("(utakmica:Utakmica), (klub1:Klub)")
                .Where((Utakmica utakmica) => utakmica.rezultat == a.rezultat).AndWhere((Tim klub1) => klub1.ime == txtProtivnik.Text)
                .Create("(utakmica)-[:Tim2]->(klub1)")
                .ExecuteWithoutResults();

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            dodajUtakmicu();
            this.Close();
        }

        private void txtProtivnik_TextChanged(object sender, EventArgs e)
        {
            if(txtProtivnik.Text!=String.Empty&&txtRezultat.Text!=String.Empty&&txtRezultat.Text.Contains(":"))
            {
                btnDodaj.Enabled = true;
            }
            else
            {
                btnDodaj.Enabled = false;
            }
        }

        private void txtRezultat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !e.KeyChar.Equals(':');
        }

        private void txtProtivnik_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)&&!char.IsSeparator(e.KeyChar);
        }
    }
}
