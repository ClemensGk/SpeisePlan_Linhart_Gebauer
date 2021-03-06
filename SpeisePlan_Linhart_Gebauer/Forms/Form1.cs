using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Security.Cryptography;


namespace SpeisePlan_Linhart_Gebauer
{
    public partial class Form1 : Form
    {
        internal static Form1 f1;
        public Form1()
        {
            f1 = this;
            InitializeComponent();
        }
        #region Variable
        ListViewItem lvItem;
        internal List<Speise> speisenListe= new List<Speise>();
        internal XmlSerializer serializerSpeisen;

        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            speisenListe = new List<Speise>();

            listView1.FullRowSelect = true;
            listView2.FullRowSelect = true;

            // speisenListe.Add(new Speise(3, "Stück", 4, Convert.ToChar("H"), "\\images\\default.jpg"));
            //deserialisierenSpeise();
            einlesenSpeise();
        }


        #region Methoden


        internal void serialisierenSpeisen()
        {

            try
            {
                serializerSpeisen = new XmlSerializer(speisenListe.GetType());
                FileStream fs = new FileStream("Speiseliste.xml", FileMode.Create, FileAccess.Write, FileShare.None);
                serializerSpeisen.Serialize(fs, speisenListe);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Serialisierender der Speisen: " + ex.Message);
            }

        }

        internal void deserialisierenSpeise()
        {
            try
            {
                FileStream fs = new FileStream("Speiseliste.xml", FileMode.Open, FileAccess.Read, FileShare.None);
                speisenListe = (List<Speise>)serializerSpeisen.Deserialize(fs);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Deserialisierender der Speise: " + ex.Message);
            }
        }

        #endregion

        private void zutatenHnizufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hinzufuegenZutaten();

        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void speiseHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hinzufuegenSpeise();
        }

        private void einlesenSpeise()
        {

            showImages();
            listView2.Items.Clear();
            for (int i = 0; i < speisenListe.Count; i++)
            {
                    lvItem = new ListViewItem(speisenListe[i].SpeiseID.ToString());
                    lvItem.ImageIndex = i;
                    lvItem.SubItems.Add(speisenListe[i].Name);
                    lvItem.SubItems.Add(speisenListe[i].Preis.ToString());
                    lvItem.SubItems.Add(speisenListe[i].Speiseart.ToString());
                    lvItem.SubItems.Add(speisenListe[i].Bildpfad);
                    listView2.Items.Add(lvItem);
                
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public void hinzufuegenZutaten()
        {
            frmZutaten frmzutaten = new frmZutaten();
            frmzutaten.Text = "Zutat hinzufügen";
            
            frmzutaten.ShowDialog();
            //einlesenZutat();
        }

        public void hinzufuegenSpeise()
        {
            frmSpeisen frmspeisen = new frmSpeisen();
            frmspeisen.Text = "Speise hinzufügen";
            frmspeisen.txtSpeiseID.Text = Speise.Autonum.ToString();
            frmspeisen.ShowDialog();
            einlesenSpeise();
        }

        public void anzeigenZutatenliste()
        {
            frmZutatenliste frmzutatenliste = new frmZutatenliste();
            frmzutatenliste.Text = "Zutatenliste";
            frmzutatenliste.ShowDialog();
            //einlesenZutatenliste
        }

        private void anzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            anzeigenZutatenliste();
        }

        private void speiseBearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie eine Speise aus!");
                return;
            }
            frmSpeisen frmSp = new frmSpeisen();
            frmSp.Text = "Speise bearbeiten";
            lvItem = listView2.SelectedItems[0];
            frmSp.txtSpeiseID.Text = lvItem.SubItems[1].Text;
            frmSp.txtName.Text = lvItem.SubItems[2].Text;
            frmSp.txtPreis.Text = lvItem.SubItems[3].Text;
            frmSp.comboBox1.Text = lvItem.SubItems[4].Text;
            frmSp.txtBildpfad.Text = lvItem.SubItems[5].Text;
            frmSp.ShowDialog();
            einlesenSpeise();
        }

        private void speiseEntfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bitte wählen sie eine Speise aus!");
                return;
            }
            int inde;
            lvItem = listView2.SelectedItems[0];
            inde = lvItem.Index;

            DialogResult antwort = MessageBox.Show("Wollen Sie diese Speise wirklich löschen?", "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (antwort == DialogResult.Yes)
            {
                speisenListe.RemoveAt(inde);
                einlesenSpeise();
            }
        }


        internal void showImages()
        {
            ImageList bilderListe = new ImageList();
            bilderListe.ColorDepth = ColorDepth.Depth32Bit; //damit Bilder nicht so pixelig
            bilderListe.ImageSize = new System.Drawing.Size(32, 32);
            bilderListe.Images.Clear();

            foreach (Speise s in speisenListe)
            {
                try
                {
                    bilderListe.Images.Add(Image.FromFile(s.Bildpfad));
                }
                catch
                {
                    bilderListe.Images.Add(Image.FromFile(Application.StartupPath + "\\images\\default.jpg"));
                    continue; //???
                }
               listView1.SmallImageList = bilderListe;
               
            }

            listView1.SmallImageList = bilderListe;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialisierenSpeisen();
        }
    }
}
