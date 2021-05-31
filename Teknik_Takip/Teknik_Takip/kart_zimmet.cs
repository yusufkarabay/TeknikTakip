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
    public partial class kart_zimmet : Form
    {
        public kart_zimmet()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Server=192.168.1.254;Database=Teknik_TakipDb;User Id=yusufkarabay;Password=Kobe+kobe1;");

        SqlCommand komut;
        SqlDataAdapter da, de, du;

        private void button3_Click(object sender, EventArgs e)
        {
            Secim_Ekrani myForm = new Secim_Ekrani();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
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
        bool durum;
        void tekrar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kart_zimmet where Kart_Id=@Kart_Id", baglanti);
            komut.Parameters.AddWithValue("@Kart_Id", textBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            baglanti.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {

            string kartno = textBox1.Text.Trim();
            if (kartno.Length == 0)
            {
                MessageBox.Show("Kart Numarasını giriniz.");
                textBox1.Clear();
                textBox1.Focus();
                return;
            }
            string karitalanpersonel = textBox2.Text.Trim();
            if (karitalanpersonel.Length == 0)
            {
                MessageBox.Show("Kartı Alacak Olan Personeli Giriniz.");
                textBox2.Clear();
                textBox2.Focus();
                return;
            }
            tekrar();
           
            if (durum == true)
            {
                string sorgu = "Insert into kart_zimmet (Kart_Id,Karti_Veren_Personel,Karti_Alan_Personel) values (@Kart_Id,@Karti_Veren_Personel,@Karti_Alan_Personel)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Kart_Id", textBox1.Text);
                komut.Parameters.AddWithValue("@Karti_Veren_Personel", Program.Ad_Soyad);
                komut.Parameters.AddWithValue("@Karti_Alan_Personel", textBox2.Text);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kart Verildi");
                textBox1.Clear();
                textBox1.Focus();

                textBox2.Clear();
                textBox2.Focus();

            }

            else
            {
                MessageBox.Show("Bu kart başka personelde görünmektedir");
                textBox1.Clear();
                textBox1.Focus();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zimmetteki_kartal myForm = new zimmetteki_kartal();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
           // this.label3.Text = datetime.ToShortDateString();
            this.label7.Text = datetime.ToShortDateString();
        }

        private void kart_zimmet_Load(object sender, EventArgs e)
        {

           
            label5.Text = Program.Ad_Soyad;
            timer1.Start();
            //label4.Text = Program.Ad_Soyad;
            timer1.Start();
        }
    }
}
