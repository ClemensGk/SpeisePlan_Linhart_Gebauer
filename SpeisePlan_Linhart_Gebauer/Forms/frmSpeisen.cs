﻿using System;
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
    }
}
