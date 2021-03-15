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
    public partial class su : Form
    {
        public su()
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

        private void su_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e) {

            string kimlikno = textBox1.Text;
            kimlikno = kimlikno.Trim();
            if (kimlikno.Length != 11)
            {
                MessageBox.Show("TC Kimlik Numaranızı eksik girdiniz!\nLütfen tekrar deneyin.");
                textBox1.Clear();
                textBox1.Focus();
                return;
            }

            string kullaniciAdi = textBox4.Text.Trim();
            if(kullaniciAdi.Length == 0)
            {
                MessageBox.Show("Kullanıcı adınızı girmediniz.");
                textBox4.Clear();
                textBox4.Focus();
                return;
            }

            string onaykodu = textBox2.Text.Trim();
            if (onaykodu.Length == 0)
            {
                MessageBox.Show("Onay kodunuzu girmediniz.");
                textBox2.Clear();
                textBox2.Focus();
                return;
            }

            string sifre = textBox5.Text.Trim();
            if (sifre.Length == 0)
            {
                MessageBox.Show("Onay kodunuzu girmediniz.");
                textBox5.Clear();
                textBox5.Focus();
                return;
            }

            komut = new SqlCommand("select * from personel where sifre_reset_kodu = @onaykodu", baglanti);
            komut.Parameters.AddWithValue("@onaykodu", textBox2.Text);
            baglanti.Open();

            SqlDataReader rd = komut.ExecuteReader();
            if(rd.HasRows == false)
            {
                baglanti.Close();
                MessageBox.Show("Onay kodunuz hatalı");
                return;
            }

            baglanti.Close();

            string sorgu = "Update personel Set Sifre=@sifre where TC=@TC and Kullanici_adi=@Kullanici_adi and sifre_reset_kodu = @onaykodu";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@sifre", textBox5.Text);
            komut.Parameters.AddWithValue("@TC", textBox1.Text);
            komut.Parameters.AddWithValue("@Kullanici_adi", textBox4.Text);
            komut.Parameters.AddWithValue("@onaykodu", textBox2.Text);
            baglanti.Open();
            int affectedRows = komut.ExecuteNonQuery();
            if(affectedRows == 0)
            {
                baglanti.Close();
                MessageBox.Show("Girdiğiniz bilgilerle herhangi bir şifre güncelleme işlemi yapılamadı.");
                return;
            }

            baglanti.Close();

            MessageBox.Show("Şifreniz güncellendi. Yeniden giriş yapabilirsiniz.");
            Giris g = new Giris();
            g.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ok myForm = new ok();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
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

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
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

        private void su_KeyUp(object sender, KeyEventArgs e)
        {
         
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
    }

 }
