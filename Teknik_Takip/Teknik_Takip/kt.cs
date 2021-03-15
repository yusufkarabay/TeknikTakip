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
    public partial class kt : Form
    {
        public kt()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Server=192.168.1.254;Database=Teknik_TakipDb;User Id=yusufkarabay;Password=Kobe+kobe1;");

        SqlCommand komut;
        SqlDataAdapter da, de, du;

        private void kt_Load(object sender, EventArgs e)
        {
            label4.Text = Program.Ad_Soyad;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.label3.Text = datetime.ToShortDateString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Secim_Ekrani myForm = new Secim_Ekrani();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kulaklikta myForm = new kulaklikta();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string kulaklikid = textBox2.Text.Trim();
            if (kulaklikid.Length == 0)
            {
                MessageBox.Show("Kulaklık Seri No giriniz.");
                textBox2.Clear();
                textBox2.Focus();
                return;
            }
            string kulaklik_sahibi = textBox1.Text.Trim();
            if (kulaklik_sahibi.Length == 0)
            {
                MessageBox.Show("Alacak Kişinin adını Giriniz.");
                textBox1.Clear();
                textBox1.Focus();
                return;
            }
            string kulaklik_durumu = textBox3.Text.Trim();
            if (kulaklik_durumu.Length == 0)
            {
                MessageBox.Show("Kulaklık Durumu Giriniz.");
                textBox3.Clear();
                textBox3.Focus();
                return;
            }


            string sorgu = "Insert into kulaklik (kulaklik_sahibi,kulaklik_seriNo,Olusturan_Personel,kulaklik_durumu) values (@kulaklik_sahibi,@kulaklik_seriNo,@Olusturan_Personel,@kulaklik_durumu)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kulaklik_sahibi", (textBox1.Text));
            komut.Parameters.AddWithValue("@kulaklik_seriNo", textBox2.Text);
                   komut.Parameters.AddWithValue("@Olusturan_Personel", Program.Ad_Soyad);
            komut.Parameters.AddWithValue("@kulaklik_durumu", textBox3.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();


            baglanti.Close();
            textBox1.Clear();
            textBox1.Focus();
            
            textBox2.Clear();
            textBox2.Focus();
            textBox3.Clear();
            textBox3.Focus();

            MessageBox.Show("Kayıt Başarılı");
        }
    }
}
