using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CassandraMusicBand.Forme
{
    public partial class PromeniIme : Form
    {
        private String BendID;
        public PromeniIme(String id)
        {
            InitializeComponent();
            BendID = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(DataProvider.updateBend(txtIme.Text,BendID))
            {
                MessageBox.Show("Uspesno ste promenili ime benda!");
                this.Close();
            }
        }
    }
}
