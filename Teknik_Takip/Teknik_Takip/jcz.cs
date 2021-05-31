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
    public partial class jcz : Form
    {
        public jcz()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Server=192.168.1.254;Database=Teknik_TakipDb;User Id=yusufkarabay;Password=Kobe+kobe1;");
        private void jcz_Load(object sender, EventArgs e)
        {
            toplam_zamani_oku();
            //label2.Text = Program.Ad_Soyad;
            timer1.Start();
        }
        void toplam_zamani_oku()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select p.Ad, p.Soyad, j.*, datediff(day, Olusturma_Zamani, GETDATE()) as 'gun_farki' FROM jenerator j inner join personel p on p.TC = j.Personel_Id", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            int tcz = 0;
            int son1ay = 0;
            int son3ay = 0;
            int son6ay = 0;
            int sifirlanmamisToplam = 0;

            while(oku.Read())
            {
                int calz = 0;
                int gunfarki = 0;
                bool silinmismi = false;

                calz = int.Parse(oku["Calisma_Zamani"].ToString());
                gunfarki = int.Parse(oku["gun_farki"].ToString());
                silinmismi = bool.Parse(oku["Silindi"].ToString());

                if(calz == 9999)
                {
                    label9.Text = oku["Ad"].ToString() + " " + oku["Soyad"].ToString();
                    label3.Text = DateTime.Parse(oku["Olusturma_Zamani"].ToString()).ToString("dd.MM.yyyy");
                    continue;
                }

                tcz += calz;

                if (gunfarki <= 30) son1ay += calz;
                if (gunfarki <= 90) son3ay += calz;
                if (gunfarki <= 180) son6ay += calz;
                if (silinmismi == false) sifirlanmamisToplam += calz;
            }

            baglanti.Close();

            label14.Text = son1ay.ToString();
            label15.Text = son3ay.ToString();
            label16.Text = son6ay.ToString();
            label17.Text = tcz.ToString();
            label7.Text = sifirlanmamisToplam.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
           //this.Tarih_Label.Text = datetime.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Secim_Ekrani myForm = new Secim_Ekrani();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into jenerator(Personel_Id, Calisma_Zamani) values (@personelId, @calismaZamani)", baglanti);
            komut.Parameters.AddWithValue("@personelId", Program.Personel_Id);
            komut.Parameters.AddWithValue("@calismaZamani", 9999);
            komut.ExecuteNonQuery();

            komut = new SqlCommand("update jenerator set Silindi = 1", baglanti);

            int affectedRows = komut.ExecuteNonQuery();
            baglanti.Close();

            if (affectedRows > 0)
            {
                toplam_zamani_oku();
                MessageBox.Show("Sayaç sıfırlandı.");
            }
            DateTime datetime = DateTime.Now;
            this.label3.Text = datetime.ToString("MMMM dd, yyyy");
            label9.Text = Program.Ad_Soyad;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Çalışma Zamanı Girilmedi");
                return;
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into jenerator(Personel_Id, Calisma_Zamani) values (@personelId, @calismaZamani)", baglanti);
            komut.Parameters.AddWithValue("@personelId", Program.Personel_Id);
            komut.Parameters.AddWithValue("@calismaZamani", int.Parse(textBox1.Text));

            int affectedRows = komut.ExecuteNonQuery();
            baglanti.Close();


            if (affectedRows > 0)
            {
                toplam_zamani_oku();
                MessageBox.Show("Kayıt eklendi");
            }
            textBox1.Clear();
            textBox1.Focus();

           
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click((object)sender, (EventArgs)e);
            }
        }

        private void jcz_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_ImeModeChanged(object sender, EventArgs e)
        {

        }
    }
}
