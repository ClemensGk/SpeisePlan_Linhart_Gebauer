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
    public partial class frmZutatenliste : Form
    {
        internal static frmZutatenliste frmzutatenliste;
        public frmZutatenliste()
        {
            frmzutatenliste = this;
            InitializeComponent();
        }

        ListViewItem lvItemZ;
        internal List<Zutat> zutatenListe = new List<Zutat>();

        private void frmZutatenliste_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
            zutatenListe.Add(new Zutat(3, "Stück", "mehl", "c"));

            einlesenZutatenliste();
        }


        public void einlesenZutatenliste()
        {
            listView1.Items.Clear();
            foreach (Zutat z in zutatenListe)
            {

                lvItemZ = new ListViewItem(z.Menge.ToString()); ;
                lvItemZ.SubItems.Add(z.Einheit);
                lvItemZ.SubItems.Add(z.Bezeichnung);
                lvItemZ.SubItems.Add(z.Allergene);
                listView1.Items.Add(lvItemZ);

            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void zutatHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZutaten frmzutaten = new frmZutaten();
            frmzutaten.Text = "Zutat hinzufügen";
            frmzutaten.ShowDialog();
            //einlesenZutat();
        }
    }
}
