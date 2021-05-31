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
    public partial class frmSpeisen : Form
    {
        internal static frmSpeisen frmspeisen;
        public frmSpeisen()
        {
            frmspeisen = this;
            InitializeComponent();
        }

        private void frmSpeisen_Load(object sender, EventArgs e)
        {

        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (this.Text.Equals("Speise hinzufügen"))
            {
                Speise s = new Speise();
                s.SpeiseID = Convert.ToInt32(txtSpeiseID.Text);
                s.Name = txtName.Text;
                s.Preis = Convert.ToInt16(txtPreis.Text);
                s.Speiseart = Convert.ToChar(comboBox1.Text);
                s.Bildpfad = textBildpfad.Text;
                Form1.f1.speisenListe.Add(s);
            }
            else
            {
                foreach (Speise s in Form1.f1.speisenListe)
                {
                    if (s.SpeiseID == Convert.ToInt32(txtSpeiseID.Text))
                    {
                        s.SpeiseID = Convert.ToInt32(txtSpeiseID.Text);
                        s.Name = txtName.Text;
                        s.Preis = Convert.ToInt16(txtPreis.Text);
                        s.Speiseart = Convert.ToChar(comboBox1.Text);
                        s.Bildpfad = textBildpfad.Text;
                        break;
                    }
                }
            }
            this.Close();
        }
    }
}
