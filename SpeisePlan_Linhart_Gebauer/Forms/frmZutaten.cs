using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeisePlan_Linhart_Gebauer
{
    public partial class frmZutaten : Form
    {
        internal static frmZutaten frmzutaten;
        public frmZutaten()
        {
            frmzutaten = this;
            InitializeComponent();
        }

        private void frmZutaten_Load(object sender, EventArgs e)
        {

        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (this.Text.Equals("Zutat hinzufügen"))
            {
                Zutat z = new Zutat(Convert.ToInt32(txtMenge.Text), txtEinheit.Text, txtBezeichnung.Text, txtAllergene.Text);
                frmZutatenliste.frmzutatenliste.zutatenListe.Add(z);
                txtMenge.Clear();
                txtEinheit.Clear();
                txtBezeichnung.Clear();
                txtAllergene.Clear();
                this.Close();
            }
            frmZutatenliste.frmzutatenliste.einlesenZutatenliste();
           
        }
    }
}
