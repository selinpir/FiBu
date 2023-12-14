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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public double toplamTutar;
        public double fiyat;

        public double kartBakiyesi;
        private void Form3_Load(object sender, EventArgs e)
        {

            label8.Text = toplamTutar.ToString();

            label8.Text = fiyat.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ad soyad kontrol
            if (textBox2.Text == "") MessageBox.Show("Lütfen Ad Soyad Girin");


            if (maskedTextBox1.Text == "") MessageBox.Show("Lütfen Kart no Girin");
            // emaiil
            string email = textBox1.Text;

            if (IsEmailValid(email))
            {
                // Eğer e-posta geçerliyse başka bir alana aktarabilirsiniz
                textBox2.Text = email;
                MessageBox.Show("E-posta formatı doğru!");
            }
            else
            {
                MessageBox.Show("Geçersiz e-posta formatı!");
            }

            // Kart bakiyesini kontrol et
            if (string.IsNullOrWhiteSpace(textBox3.Text) || !double.TryParse(textBox3.Text, out kartBakiyesi) || kartBakiyesi < 0)
            {
                MessageBox.Show("Lütfen geçerli bir pozitif sayı girin!");
                return; // Geçersiz giriş durumunda fonksiyonu burada sonlandır
            }

            if (kartBakiyesi < fiyat)
            {
                // Ödeme tamamlanmadıysa Form5'i göster
                Form5 form5 = new Form5();
                form5.Show();
                this.Hide();
            }
            else
            {
                // Ödeme tamamlandıysa Form4'ü göster
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();
            }


        }
        private bool IsEmailValid(string email)
        {
            // Sadece @ sembolünün varlığını kontrol etmek için basit bir doğrulama
            return email.Contains("@");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();  
            form6.Show();
            this.Hide();
        }
    }
}
