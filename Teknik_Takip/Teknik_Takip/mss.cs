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
    public partial class mss : Form
    {
        public mss()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Server=192.168.1.254;Database=Teknik_TakipDb;User Id=yusufkarabay;Password=Kobe+kobe1;");

        SqlCommand komut;
        SqlDataAdapter da,de,du;

        void Listele()
        {
          
        }
        private void button2_Click(object sender, EventArgs e)
        {
            et myForm = new et();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            //this.label2.Text = datetime.ToShortDateString();
        }

        private void mss_Load(object sender, EventArgs e)
        {
          //  label1.Text = Program.Ad_Soyad;
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
                da = new SqlDataAdapter("Select *From envarter where Malzeme_Id like'" + textBox1.Text + "%'", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }
           else if (radioButton2.Checked == true)
            {
                textBox1.Clear();
                textBox1.Focus();
                SqlConnection baglanti = new SqlConnection(@"Server=192.168.1.254;Database=Teknik_TakipDb;User Id=yusufkarabay;Password=Kobe+kobe1;");

                baglanti.Open();
                da = new SqlDataAdapter("Select *From envarter where Malzeme_adi like'%" + textBox2.Text + "'", baglanti);
                de = new SqlDataAdapter("Select *From envarter where Malzeme_adi like'" + textBox2.Text + "%'", baglanti);
                du = new SqlDataAdapter("Select *From envarter where Malzeme_adi like'%" + textBox2.Text + "%'", baglanti);
                DataTable tablo = new DataTable();
                de.Fill(tablo);
                du.Fill(tablo);
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click((object)sender, (EventArgs)e);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click((object)sender, (EventArgs)e);
            }
        }

        private void mss_KeyUp(object sender, KeyEventArgs e)
        {

           
        }
    }
}
