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
    public partial class DodajTrenera : Form
    {

        public GraphClient client;
        private String nazivTima;
        public Trener trener;

        public DodajTrenera(String naziv)
        {
            InitializeComponent();
            nazivTima = naziv;
            trener = new Trener();
            btnDodaj.Enabled = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            trener.ime = txtIme.Text;
            trener.prezime = txtPrezime.Text;
            trener.godinarod = txtGodina.Text;

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("ime", trener.ime);
            queryDict.Add("prezime", trener.prezime);
            queryDict.Add("godinarod", trener.godinarod);

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Trener {ime:'" + trener.ime
                                                            + "', prezime:'" + trener.prezime + "', godinarod:'" + trener.godinarod
                                                            + "'}) return n",
                                                            queryDict, CypherResultMode.Set);
            ((IRawGraphClient)client).ExecuteCypher(query);

            client.Cypher.Match("(trener1:Trener), (klub1:Klub)")
                 .Where((Trener trener1) => trener.ime == trener1.ime).AndWhere((Trener trener1) => trener.prezime == trener1.prezime).AndWhere((Tim klub1) => klub1.ime == nazivTima)
                 .Create("(trener1)-[:Trenira]->(klub1)")
                 .ExecuteWithoutResults();
            this.Close();
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            if(txtGodina.Text!=String.Empty&&txtIme.Text!=String.Empty&&txtPrezime.Text!=String.Empty)
            {
                btnDodaj.Enabled = true;
            }
            else
            {
                btnDodaj.Enabled = false;
            }
        }

        private void txtIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }

        private void txtGodina_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
