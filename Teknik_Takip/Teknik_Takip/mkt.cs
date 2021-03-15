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
    public partial class mkt : Form
    {
        public mkt()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Server=192.168.1.254;Database=Teknik_TakipDb;User Id=yusufkarabay;Password=Kobe+kobe1;");
        SqlCommand komut;
        SqlDataAdapter da;
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.label1.Text = datetime.ToShortDateString();
            this.label7.Text = datetime.ToShortDateString();
        }

        private void mkt_Load(object sender, EventArgs e)
        {
            label2.Text = Program.Ad_Soyad;
            label5.Text = Program.Ad_Soyad;
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Secim_Ekrani myForm = new Secim_Ekrani();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kte myForm = new kte();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        bool durum;
        void tekrar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kart where Kart_Id=@Kart_Id", baglanti);
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
            string misafirkartno = textBox1.Text.Trim();
            if (misafirkartno.Length == 0)
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
                string sorgu = "Insert into kart (Kart_Id,Karti_Veren_Personel,Karti_Alan_Personel) values (@Kart_Id,@Karti_Veren_Personel,@Karti_Alan_Personel)";
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

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click((object)sender, (EventArgs)e);
            }
        }

        private void textBox1_ImeModeChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click((object)sender, (EventArgs)e);
            }
        }

        private void mkt_KeyUp(object sender, KeyEventArgs e)
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
