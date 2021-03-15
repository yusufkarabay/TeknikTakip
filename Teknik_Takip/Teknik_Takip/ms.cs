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
    public partial class ms : Form
    {
        public ms()
        {
            InitializeComponent();
        }

        SqlCommand komut;
        SqlDataAdapter da;
        SqlConnection baglanti = new SqlConnection(@"Server=192.168.1.254;Database=Teknik_TakipDb;User Id=yusufkarabay;Password=Kobe+kobe1;");
        void Listele()
        {
            SqlConnection baglanti = new SqlConnection(@"Server=192.168.1.254;Database=Teknik_TakipDb;User Id=yusufkarabay;Password=Kobe+kobe1;");

            baglanti.Open();
            da = new SqlDataAdapter("Select *From envarter", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.label1.Text = datetime.ToShortDateString();
        }

        private void ms_Load(object sender, EventArgs e)
        {
            label2.Text = Program.Ad_Soyad;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            et myForm = new et();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Server=192.168.1.254;Database=Teknik_TakipDb;User Id=yusufkarabay;Password=Kobe+kobe1;");

            baglanti.Open();
            da = new SqlDataAdapter("Select *From envarter where Malzeme_Id like'" + textBox1.Text + "%'", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
            // Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string malzemeid = textBox1.Text.Trim();
            if (malzemeid.Length == 0)
            {
                MessageBox.Show("Malzeme ID giriniz.");
                textBox1.Clear();
                textBox1.Focus();
                return;
            }
            string sorgu = "Delete From envarter Where Malzeme_Id=@Malzeme_Id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Malzeme_Id", dataGridView1.CurrentRow.Cells[0].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            textBox1.Clear();
            textBox1.Focus();
            baglanti.Close();
            Listele();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3_Click((object)sender, (EventArgs)e);
            }
        }

        private void ms_KeyUp(object sender, KeyEventArgs e)
        {

           
        }
    }
}
