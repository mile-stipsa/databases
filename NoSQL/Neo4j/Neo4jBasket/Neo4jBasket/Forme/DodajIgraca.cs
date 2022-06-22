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

namespace Neo4jBasket.Forme
{
    public partial class DodajIgraca : Form
    {

        public GraphClient client;
        private String nazivTima;

        public DodajIgraca(String naziv)
        {
            InitializeComponent();
            nazivTima = naziv;
            btnDodaj.Enabled = false;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dodajIgraca()
        {
            Igrac a = new Igrac();

            a.ime = txtIme.Text;
            a.prezime = txtPrezime.Text;
            a.godinarod = txtGodina.Text;
            a.pozicija = txtPozicija.Text;
            a.visina = txtVisina.Text;

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("ime", a.ime);
            queryDict.Add("prezime", a.prezime);
            queryDict.Add("visina", a.visina);
            queryDict.Add("pozicija", a.pozicija);
            queryDict.Add("godinarod", a.godinarod);

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Igrac {ime:'" + a.ime
                                                            + "', prezime:'" + a.prezime + "', godinarod:'" + a.godinarod
                                                            + "', pozicija:'" + a.pozicija+"', visina:'"+a.visina
                                                            + "'}) return n",
                                                            queryDict, CypherResultMode.Set);
           ((IRawGraphClient)client).ExecuteCypher(query);

            client.Cypher.Match("(igrac1:Igrac), (klub1:Klub)")
                 .Where((Igrac igrac1) => a.ime == igrac1.ime).AndWhere((Igrac igrac1) => a.prezime == igrac1.prezime).AndWhere((Tim klub1) => klub1.ime == nazivTima)
                 .Create("(igrac1)<-[:Igra]-(klub1)")
                 .ExecuteWithoutResults();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            dodajIgraca();
            this.Close();
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            if(txtGodina.Text!=String.Empty&&txtIme.Text!=String.Empty&&txtPozicija.Text!=String.Empty&&txtPrezime.Text!=String.Empty&&txtVisina.Text!=String.Empty)
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
