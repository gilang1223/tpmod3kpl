﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpmod3
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                label1.Visible = true;
                label1.Text = textInput.Text;
        }

        private void textInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
