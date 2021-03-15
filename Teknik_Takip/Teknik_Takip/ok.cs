using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Teknik_Takip
{
    public partial class ok : Form
    {
        public ok()
        {
            InitializeComponent();
        }
        SqlCommand komut;
        SqlDataAdapter da;
        SqlConnection baglanti = new SqlConnection(@"Server=192.168.1.254;Database=Teknik_TakipDb;User Id=yusufkarabay;Password=Kobe+kobe1;");


        public static string _OnayKodu = "";
      
        private void button1_Click(object sender, EventArgs e)
        {
            su myForm = new su();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void ok_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime datetime = DateTime.Now;
            this.label2.Text = datetime.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mail = textBox1.Text.Trim();
            if (mail.Length == 0)
            {
                MessageBox.Show("Mail Adresinizi Girmediniz.");
                textBox1.Clear();
                textBox1.Focus();
                return;
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from personel Where email=@email", baglanti);
            komut.Parameters.AddWithValue("@email", textBox1.Text);

            SqlDataReader oku = komut.ExecuteReader();
            if(oku.HasRows == false) {
                baglanti.Close();
                MessageBox.Show("Mail adresinizle eşleşen herhangi bir hesap bulunamadı.");
                return;
            }

            baglanti.Close();

            Random rastgele = new Random();
            string harfler = "ABCDEFGHIJKLMNOPRSTUVYZWX";
            _OnayKodu = "";
            for (int i = 0; i < 6; i++)
            {
                _OnayKodu += harfler[rastgele.Next(harfler.Length)];
            }

            baglanti.Open();
            komut = new SqlCommand("update personel set sifre_reset_kodu = @onaykodu where email=@email", baglanti);
            komut.Parameters.AddWithValue("@onaykodu", _OnayKodu);
            komut.Parameters.AddWithValue("@email", textBox1.Text);

            int affectedRows = komut.ExecuteNonQuery();
            if(affectedRows == 0) {
                baglanti.Close();
                MessageBox.Show("Onay kodu işlenemedi. Lütfen hizmet sağlayıcınızla iletişime geçin.");
                return;
            }

            baglanti.Close();

            MailMessage ePosta = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("duzce112tekniktakip@gmail.com","duzce112");
            istemci.Port = 587;
            istemci.Host= "smtp.gmail.com";
            istemci.EnableSsl = true;
            ePosta.To.Add(textBox1.Text); // kontrol edilecek
            ePosta.From = new MailAddress("duzce112tekniktakip@gmail.com");
            ePosta.Subject = "Onay Kodu";
            ePosta.Body = _OnayKodu;
            istemci.Send(ePosta);

            MessageBox.Show("Onay Kodu Gönderildi");
            textBox1.Clear();
            textBox1.Focus();

            su myForm = new su();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click((object)sender, (EventArgs)e);
            }
        }

        private void ok_KeyUp(object sender, KeyEventArgs e)
        {

            
        }
    }
}
