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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Variable
        ListViewItem lvItem;


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
    }
}
