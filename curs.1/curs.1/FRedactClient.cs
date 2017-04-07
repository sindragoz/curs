﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curs._1
{
    public partial class FRedactClient : Form
    {
        public FRedactClient()
        {
            InitializeComponent();
        }

        public FRedactClient(Client client)
        {
            InitializeComponent();
            textBox1.Text = client.full_name;
            textBox2.Text = client.phone_number;
            textBox3.Text = client.company;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
