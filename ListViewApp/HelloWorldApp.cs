﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string name = "mithun";
            string roll = "ash1001028m";
            string uni = "nstu";
            string father = "BABUL";
            nameListBox.Items.Add(name + "  " + roll + "  " + uni + "  " + father);

        }
    }
}
