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
        public Form1()
        {
            InitializeComponent();
        }
        #region Variable
        ListViewItem lvItem;
        internal List<Speise> speisenListe;


        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
            listView2.FullRowSelect = true;
        }


        #region Methoden


        #endregion

        private void zutatenHnizufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void speiseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void speiseHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void einlesenSpeise()
        {
            listView1.Items.Clear();
            for (int i = 0; i < speisenListe.Count; i++)
            {
                
                
                    lvItem = new ListViewItem();
                    lvItem.ImageIndex = i;
                    lvItem.SubItems.Add(speisenListe[i].SpeiseID.ToString());
                    lvItem.SubItems.Add(speisenListe[i].Name);
                    lvItem.SubItems.Add(speisenListe[i].Preis.ToString());
                    lvItem.SubItems.Add(speisenListe[i].Speiseart.ToString());
                    lvItem.SubItems.Add(speisenListe[i].Bildpfad);
                    listView1.Items.Add(lvItem);
                
            }
        }

           
        }
}
