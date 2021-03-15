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
using System.Collections;
using System.Data.SqlClient;



namespace Teknik_Takip
{
    public partial class Bakim_Ekrani : Form
    {
        public Bakim_Ekrani()
        {
            InitializeComponent();
        }

        SqlCommand komut;
        SqlDataAdapter da;

        SqlConnection baglanti = new SqlConnection(@"Server=192.168.1.254;Database=Teknik_TakipDb;User Id=yusufkarabay;Password=Kobe+kobe1;");






        public static string hatirlatma = "Bu Bir Bakım Hatırlatmasıdır: " ;


        private void Kontrol_Ekrani_Load(object sender, EventArgs e)
        {


            Listele();
            Listele2();
            label1.Text = Program.Ad_Soyad;
            timer1.Start();

          /*  baglanti.Open();

         
            da = new SqlDataAdapter("Select *From bakim_email", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
            */




           /*  MailMessage ePosta = new MailMessage();
                    SmtpClient istemci = new SmtpClient();
                    istemci.Credentials = new System.Net.NetworkCredential("duzce112tekniktakip@gmail.com", "duzce112");
                    istemci.Port = 587;
                    istemci.Host = "smtp.gmail.com";
                    istemci.EnableSsl = true;

                    ePosta.To.Add(dataGridView1.CurrentRow.Cells[0].Value.ToString());        
                    ePosta.From = new MailAddress("duzce112tekniktakip@gmail.com");
                    ePosta.Subject = "Bakım Hatırlatması";
                    ePosta.Body = hatirlatma;
                    istemci.Send(ePosta);

                  baglanti.Close();*/
              
            
        }


        void Listele()
        {
            SqlConnection baglanti = new SqlConnection(@"Server=192.168.1.254;Database=Teknik_TakipDb;User Id=yusufkarabay;Password=Kobe+kobe1;");

            baglanti.Open();
            da = new SqlDataAdapter("Select email From bakim_email ", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        void Listele2()
        {
            SqlConnection baglanti = new SqlConnection(@"Server=192.168.1.254;Database=Teknik_TakipDb;User Id=yusufkarabay;Password=Kobe+kobe1;");

            baglanti.Open();
            da = new SqlDataAdapter("Select Bakim_Adi,son_bakim_tarihi,Bakim_tekrari,Ekleyen_Personel From Bakim ", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglanti.Close();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime datetime = DateTime.Now;
            this.label2.Text = datetime.ToShortDateString();
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
            string Bakım_Adi = textBox1.Text.Trim();
            if (Bakım_Adi.Length == 0)
            {
                MessageBox.Show("Bakım Adını Giriniz.");
                textBox1.Clear();
                textBox1.Focus();
                return;
            }
            string tekrar;
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Tekrar Zamanı Seçiniz");

                comboBox1.Focus();
                return;
            }
            string sorgu = "Insert into Bakim (Bakim_Adi,Bakim_tekrari,Ekleyen_Personel,son_bakim_tarihi) values (@Bakim_Adi,@Bakim_tekrari,@Ekleyen_Personel,@son_bakim_tarihi)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Bakim_Adi", textBox1.Text);        
            komut.Parameters.AddWithValue("@Bakim_tekrari", comboBox1.SelectedItem);
            komut.Parameters.AddWithValue("@son_bakim_tarihi", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@Ekleyen_Personel", Program.Ad_Soyad);

            baglanti.Open();
            komut.ExecuteNonQuery();


            baglanti.Close();
      

            textBox1.Clear();
            textBox1.Focus();

      
            MessageBox.Show("Kayıt Başarılı");





            Listele2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emailkayit = textBox2.Text.Trim();
            if (emailkayit.Length == 0)
            {
                MessageBox.Show("E-Mail Adresi  Giriniz.");
                textBox1.Clear();
                textBox1.Focus();
                return;
            }
            string sorgu = "Insert into bakim_email (email) values (@email)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@email", textBox2.Text);
          
            baglanti.Open();
            komut.ExecuteNonQuery();


            baglanti.Close();


            textBox2.Clear();
            textBox2.Focus();
              Listele();


            MessageBox.Show("Kayıt Başarılı");
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string malzemeid = textBox2.Text.Trim();
            if (malzemeid.Length == 0)
            {
                MessageBox.Show("Seçili E-Mail Yok");
                textBox2.Clear();
                textBox2.Focus();
                return;
            }
            string sorgu = "Delete From bakim_email Where email=@email";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@email", dataGridView1.CurrentRow.Cells[0].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            textBox2.Clear();
            textBox2.Focus();
            baglanti.Close();
            Listele();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string bakim_adi = textBox1.Text.Trim();
            if (bakim_adi.Length == 0)
            {
                MessageBox.Show("Seçili Bakım Yok");
                textBox1.Clear();
                textBox1.Focus();
                return;
            }
            string sorgu = "Delete From Bakim Where Bakim_Adi=@Bakim_Adi";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Bakim_Adi", dataGridView2.CurrentRow.Cells[0].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            textBox1.Clear();
            textBox1.Focus();
            baglanti.Close();
            Listele2();
        }
    }
}


