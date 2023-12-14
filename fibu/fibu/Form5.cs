using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FiBo ödemeye devam etmek için seni götürüyor! ");
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Terminatör en yakın zamanda gelmeni istiyor.FiBu'yu tercih ettiğin için teşekkürler.");
            Application.Exit();
        }
    }
}
