﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibu
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("FiBu'yu tercih ettiğin için teşekkürler");
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
                            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FiBo onu bırakmadığın için çok sevindi.Yeni film seçebilirsin! ");
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
