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
   

    public partial class Giris : Form
    {

        public static class Kullanicilar
        {
            public static
            string
            Kullanici_Adi
            { get; set; }
            public static
            string
            Sifre
            { get; set; }
            public static
            string
            Ad
            { get; set; }
            public static
            string
            Soyad
            { get; set; }
        }

        public Giris()
        {
            InitializeComponent();
        }

        public static string kullaniciadi;
        SqlCommand komut;
        SqlDataAdapter da;

        SqlConnection baglanti = new SqlConnection(@"Server=192.168.1.254;Database=Teknik_TakipDb;User Id=yusufkarabay;Password=Kobe+kobe1;");
        private void button1_Click(object sender, EventArgs e)
        {
       


            string kullaniciAdi = Kullanici_Adi_Textbox.Text.Trim();
            if (kullaniciAdi.Length == 0)
            {
                MessageBox.Show("Kullanıcı adınızı girmediniz.");
                Kullanici_Adi_Textbox.Clear();
                Kullanici_Adi_Textbox.Focus();
                return;
            }

            string parola = Parola_Textbox.Text.Trim();
            if (parola.Length == 0)
            {
                MessageBox.Show("Parolanızı girmediniz.");
                Parola_Textbox.Clear();
                Parola_Textbox.Focus();
                return;
            }
           
            SqlCommand komut = new SqlCommand("Select * from personel Where Kullanici_Adi=@Kullanici_Adi and Sifre=@Sifre", baglanti);
            komut.Parameters.AddWithValue("@Kullanici_Adi", Kullanici_Adi_Textbox.Text);
            komut.Parameters.AddWithValue("@Sifre", Parola_Textbox.Text);
            baglanti.Open();
            SqlDataReader oku = komut.ExecuteReader();
        
           
            if (oku.Read())

            {
              
             Program.Ad_Soyad = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                Program.Personel_Id = oku["TC"].ToString();
               
                Secim_Ekrani myForm = new Secim_Ekrani();
                this.Hide();
                myForm.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Bilgileriniz Hatalı Lütfen Tekrar Deneyin");
            }
            baglanti.Close();
         

        }
        
        private void Tarih_Label_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.Tarih_Label.Text = datetime.ToShortDateString();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            {
                
                if (checkBox1.Checked)
                {
                  
                    Parola_Textbox.PasswordChar = '\0';
                }
               
                else
                {
                    Parola_Textbox.PasswordChar = '*';
                }
            }
        }

        private void Parola_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pk myForm = new pk();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            su myForm = new su();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void Kullanici_Adi_Textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click((object)sender, (EventArgs)e);
            }
        }

        private void Giris_Buton_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
