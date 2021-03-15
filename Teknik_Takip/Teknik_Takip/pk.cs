using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Teknik_Takip
{
    public partial class pk : Form
    {
        public pk()
        {
            InitializeComponent();
        }
        SqlCommand komut;
        SqlDataAdapter da;
        SqlConnection baglanti = new SqlConnection(@"Server=192.168.1.254;Database=Teknik_TakipDb;User Id=yusufkarabay;Password=Kobe+kobe1;");

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.label1.Text = datetime.ToShortDateString();
        }

        private void pk_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giris myForm = new Giris();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string kimlikno = textBox1.Text;
            kimlikno = kimlikno.Trim();
            if (kimlikno.Length != 11)
            {
                MessageBox.Show("TC Kimlik Numaranızı eksik girdiniz!\nLütfen tekrar deneyin.");
                textBox1.Clear();
                textBox1.Focus();
                return;

            }
            string ad = textBox2.Text.Trim();
            if (ad.Length == 0)
            {
                MessageBox.Show("Adınızı giriniz.");
                textBox2.Clear();
                textBox2.Focus();
                return;
            }
            string soyad = textBox3.Text.Trim();
            if (soyad.Length == 0)
            {
                MessageBox.Show("Soyadınızı giriniz.");
                textBox3.Clear();
                textBox3.Focus();
                return;
            }
            string gorev ;
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Görev Seçiniz");
              
                comboBox1.Focus();
                return;
            }
            string kullaniciadi = textBox4.Text.Trim();
            if (kullaniciadi.Length == 0)
            {
                MessageBox.Show("Kullanıcı adınızı giriniz.");
                textBox4.Clear();
                textBox4.Focus();
                return;
            }
            string sifre = textBox5.Text.Trim();
            if (sifre.Length == 0)
            {
                MessageBox.Show("Sifrenizi giriniz.");
                textBox5.Clear();
                textBox5.Focus();
                return;
            }
            string email = textBox6.Text.Trim();
            if (email.Length == 0)
            {
                MessageBox.Show("Mail adresinizi giriniz.");
                textBox6.Clear();
                textBox6.Focus();
                return;
            }

            {
                string sorgu = "Insert into personel (TC,Ad,Soyad,Gorev,Sifre,Kullanici_Adi,email) values (@TC,@Ad,@Soyad,@Gorev,@Sifre,@Kullanici_Adi,@email)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@TC", textBox1.Text);
                komut.Parameters.AddWithValue("@Ad", textBox2.Text);
                komut.Parameters.AddWithValue("@Soyad", textBox3.Text);
                komut.Parameters.AddWithValue("@Gorev", comboBox1.Text);
                komut.Parameters.AddWithValue("@Sifre", textBox5.Text);
                komut.Parameters.AddWithValue("@Kullanici_Adi", textBox4.Text);
                komut.Parameters.AddWithValue("@email", textBox6.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                
                
                    
            }
            MessageBox.Show("Kayıt Başarılı");
            Giris myForm = new Giris();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click((object)sender, (EventArgs)e);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click((object)sender, (EventArgs)e);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click((object)sender, (EventArgs)e);
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click((object)sender, (EventArgs)e);
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click((object)sender, (EventArgs)e);
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click((object)sender, (EventArgs)e);
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click((object)sender, (EventArgs)e);
            }
        }

        private void pk_KeyUp(object sender, KeyEventArgs e)
        {

         
        }
    }
 
}
