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
    public partial class nt : Form
    {
        public nt()
        {
            InitializeComponent();
        }
        SqlCommand komut;
        SqlDataAdapter da;
        SqlConnection baglanti = new SqlConnection(@"Server=192.168.1.254;Database=Teknik_TakipDb;User Id=yusufkarabay;Password=Kobe+kobe1;");
        DataTable dtbl_yapilacaklar = new DataTable();
        DataTable dtbl_gecmis = new DataTable();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nt_Load(object sender, EventArgs e)
        {
            label2.Text = Program.Ad_Soyad;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.label1.Text = datetime.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Secim_Ekrani myForm = new Secim_Ekrani();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            string boskayityapilan = giris_bilgisi.Text.Trim();
            if (boskayityapilan.Length == 0)
            {
                MessageBox.Show("Boş Kayıt Girilemez.");
                giris_bilgisi.Clear();
                giris_bilgisi.Focus();
                return;
            }
            {
                string sorgu = "Insert into Nobet_Teslim (Kullanici_Adi,Note) values (@Kullanici_Adi,@Note)";
                komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@Kullanici_Adi", Program.Ad_Soyad);
                komut.Parameters.AddWithValue("@Note", giris_bilgisi.Text);  

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Eklendi");
                giris_bilgisi.Clear();
                giris_bilgisi.Focus();
            }
        }

        private void oku_Click(object sender, EventArgs e)
        {
            dtbl_gecmis.Clear();
            baglanti.Open();    
            da = new SqlDataAdapter("Select * from Nobet_Teslim where Note_Zamani like'"+dateTimePicker1.Value.ToString("yyyy-MM-dd")+"' ", baglanti);
            da.Fill(dtbl_gecmis);
            dataGridView1.DataSource = dtbl_gecmis;
            baglanti.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string boskayityapilaacak = textBox1.Text.Trim();
            if (boskayityapilaacak.Length == 0)
            {
                MessageBox.Show("Boş Kayıt Girilemez.");
                textBox1.Clear();
                textBox1.Focus();
                return;
            }
            string sorgu = "Insert into N_Yapilacak (Kullanici_Adi,Yapilacak_Note) values (@Kullanici_Adi,@Yapilacak_Note)";
            komut = new SqlCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("@Kullanici_Adi", Program.Ad_Soyad);
            komut.Parameters.AddWithValue("@Yapilacak_Note", textBox1.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İş Eklendi");
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dtbl_yapilacaklar.Clear();
            baglanti.Open();
            da = new SqlDataAdapter("Select * from N_Yapilacak where Note_Zamani like'" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "' ", baglanti);

            da.Fill(dtbl_yapilacaklar);
            dataGridView2.DataSource = dtbl_yapilacaklar;
            baglanti.Close();
        }

        private void giris_bilgisi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Kaydet_Click((object)sender, (EventArgs)e);
            }
        }

     

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click((object)sender, (EventArgs)e);
            }
        }

        private void nt_KeyUp(object sender, KeyEventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
