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

namespace SpeisePlan_Linhart_Gebauer.Forms
{
    public partial class frmSpeisen : Form
    {
        internal static frmSpeisen frmSpeise;
        public frmSpeisen()
        {
            InitializeComponent();
            frmSpeise = this;
        }


        private void Speisen_Load(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       
    }
}
