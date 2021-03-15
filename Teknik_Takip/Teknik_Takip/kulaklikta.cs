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
    public partial class kulaklikta : Form
    {
        public kulaklikta()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Server=192.168.1.254;Database=Teknik_TakipDb;User Id=yusufkarabay;Password=Kobe+kobe1;");

        SqlCommand komut;
        SqlDataAdapter da, de, du;
        void Listele()
        {
            SqlConnection baglanti = new SqlConnection(@"Server=192.168.1.254;Database=Teknik_TakipDb;User Id=yusufkarabay;Password=Kobe+kobe1;");

            baglanti.Open();
            da = new SqlDataAdapter("Select *From kulaklik", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kt myForm = new kt();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.label2.Text = datetime.ToShortDateString();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click((object)sender, (EventArgs)e);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click((object)sender, (EventArgs)e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kulaklikid = textBox1.Text.Trim();
            if (kulaklikid.Length == 0)
            {
                MessageBox.Show("Kulaklık Seri No Giriniz.");
                textBox1.Clear();
                textBox1.Focus();
                return;
            }
            string sorgu = "Delete From kulaklik Where kulaklik_seriNo=@kulaklik_seriNo";

            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kulaklik_seriNo", dataGridView1.CurrentRow.Cells[1].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            textBox1.Clear();
            textBox1.Focus();
            MessageBox.Show("Kulaklık Teslim Alındı.");
            baglanti.Close();
            Listele();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kulaklikta_Load(object sender, EventArgs e)
        {

            label1.Text = Program.Ad_Soyad;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox2.Clear();
                textBox2.Focus();
                SqlConnection baglanti = new SqlConnection(@"Server=192.168.1.254;Database=Teknik_TakipDb;User Id=yusufkarabay;Password=Kobe+kobe1;");

                baglanti.Open();
                da = new SqlDataAdapter("Select *From kulaklik where kulaklik_seriNo like'" + textBox1.Text + "%'", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }
            if (radioButton2.Checked == true)
            {
                textBox1.Clear();
                textBox1.Focus();
                SqlConnection baglanti = new SqlConnection(@"Server=192.168.1.254;Database=Teknik_TakipDb;User Id=yusufkarabay;Password=Kobe+kobe1;");

                baglanti.Open();
                da = new SqlDataAdapter("Select *From kulaklik where kulaklik_sahibi like'%" + textBox2.Text + "'", baglanti);
                de = new SqlDataAdapter("Select *From kulaklik where kulaklik_sahibi like'" + textBox2.Text + "%'", baglanti);
                du = new SqlDataAdapter("Select *From kulaklik where kulaklik_sahibi like'%" + textBox2.Text + "%'", baglanti);
                DataTable tablo = new DataTable();
                de.Fill(tablo);
                du.Fill(tablo);

                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }
        }
    }
}
