﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerializacionXML obj1 = new SerializacionXML();
            obj1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EncriptacionArchivos obj2 = new EncriptacionArchivos();
            obj2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reflection obj3 = new Reflection();
            obj3.Show();
        }
    }
}
