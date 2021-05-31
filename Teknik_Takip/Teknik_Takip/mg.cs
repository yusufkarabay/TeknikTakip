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
    public partial class mg : Form
    {
        public mg()
        {
            InitializeComponent();
        }
        SqlCommand komut;
        SqlDataAdapter da,de,du;
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
        private void button1_Click(object sender, EventArgs e)
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
           // this.label2.Text = datetime.ToShortDateString();
        }

        private void mg_Load(object sender, EventArgs e)
        {

          //  label1.Text = Program.Ad_Soyad;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "Update envarter Set  Malzeme_adi=@Malzeme_adi,Malzeme_Miktari=@Malzeme_Miktari where Malzeme_Id=@Malzeme_Id ";
            komut = new SqlCommand(sorgu, baglanti);

         
            komut.Parameters.AddWithValue("@Malzeme_adi", textBox2.Text);
            komut.Parameters.AddWithValue("@Malzeme_Miktari", textBox3.Text);
            komut.Parameters.AddWithValue("@Malzeme_Id", textBox1.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme başarılı");

            textBox1.Clear();
            textBox1.Focus();

            textBox2.Clear();
            textBox2.Focus();

            textBox3.Clear();
            textBox3.Focus();

            Listele();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
             
                SqlConnection baglanti = new SqlConnection(@"Server=192.168.1.254;Database=Teknik_TakipDb;User Id=yusufkarabay;Password=Kobe+kobe1;");

                baglanti.Open();
                da = new SqlDataAdapter("Select *From envarter where Malzeme_Id like'" + textBox4.Text + "%'", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
                textBox4.Clear();
                textBox4.Focus();
            }
            if (radioButton2.Checked == true)
            {
              
                SqlConnection baglanti = new SqlConnection(@"Server=192.168.1.254;Database=Teknik_TakipDb;User Id=yusufkarabay;Password=Kobe+kobe1;");

                baglanti.Open();
              //  da = new SqlDataAdapter("Select *From envarter where Malzeme_adi like'" + textBox5.Text + "%'", baglanti);

                da = new SqlDataAdapter("Select *From envarter where Malzeme_adi like'%" + textBox5.Text + "'", baglanti);
                de = new SqlDataAdapter("Select *From envarter where Malzeme_adi like'" + textBox5.Text + "%'", baglanti);
                du = new SqlDataAdapter("Select *From envarter where Malzeme_adi like'%" + textBox5.Text + "%'", baglanti);
                DataTable tablo = new DataTable();
                de.Fill(tablo);
                du.Fill(tablo);
                da.Fill(tablo);
              
                dataGridView1.DataSource = tablo;
                baglanti.Close();
                textBox5.Clear();
                textBox5.Focus();
            }

            /* SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-2HGP1UG;Initial Catalog=Teknik_TakipDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

             baglanti.Open();
             da = new SqlDataAdapter("Select *From envarter where Malzeme_Id like'" + textBox4.Text + "%'", baglanti);
             DataTable tablo = new DataTable();
             da.Fill(tablo);
             dataGridView1.DataSource = tablo;
             baglanti.Close();
             textBox4.Clear();
             textBox4.Focus();*/


            // Listele();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
          
    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3_Click((object)sender, (EventArgs)e);
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3_Click((object)sender, (EventArgs)e);
            }
        }

        private void mg_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
