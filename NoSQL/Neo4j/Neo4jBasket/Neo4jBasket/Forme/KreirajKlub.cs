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
    public partial class KreirajKlub : Form
    {
        public GraphClient client;
        private String nazivTima;

        public KreirajKlub(String naziv)
        {
            InitializeComponent();
            nazivTima = naziv;
            btnDodaj.Enabled = false;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Tim a = new Tim();
            a.ime = nazivTima;
            a.grad = txtGrad.Text;
            a.dvorana = txtDvorana.Text;

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("ime", a.ime);
            queryDict.Add("grad", a.grad);
            queryDict.Add("dvorana", a.dvorana);

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Klub {ime:'" + a.ime +"', grad:'"+a.grad+"', dvorana:'"+a.dvorana
                                                            + "'}) return n",
                                                            queryDict, CypherResultMode.Set);
            ((IRawGraphClient)client).ExecuteCypher(query);

            this.Close();
        }

        private void txtDvorana_TextChanged(object sender, EventArgs e)
        {
            if(txtDvorana.Text!=String.Empty&&txtGrad.Text!=String.Empty)
            {
                btnDodaj.Enabled = true;
            }
            else
            {
                btnDodaj.Enabled = false;
            }
        }

        private void txtDvorana_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)&&!char.IsSeparator(e.KeyChar);
        }
    }
}
