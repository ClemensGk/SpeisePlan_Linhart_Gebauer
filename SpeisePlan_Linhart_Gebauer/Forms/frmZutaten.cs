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
    }
}
