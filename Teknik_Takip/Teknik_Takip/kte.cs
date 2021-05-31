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
    public partial class kte : Form
    {
        public kte()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Server=192.168.1.254;Database=Teknik_TakipDb;User Id=yusufkarabay;Password=Kobe+kobe1;");
        SqlCommand komut;
        SqlDataAdapter da;
        void Listele()
        {
            SqlConnection baglanti = new SqlConnection(@"Server=192.168.1.254;Database=Teknik_TakipDb;User Id=yusufkarabay;Password=Kobe+kobe1;");

            baglanti.Open();
            da = new SqlDataAdapter("Select *From kart", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            mkt myForm = new mkt();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void kte_Load(object sender, EventArgs e)
        {
            baglanti.Open();
          
            SqlCommand cmd = new SqlCommand("Select Kart_Id From kart", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Kart_Id"]);
            }




            //label2.Text = Program.Ad_Soyad;
            timer1.Start();
            baglanti.Close();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
          //  this.label1.Text = datetime.ToShortDateString();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kartsecimi;
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("kart Seçiniz");

                comboBox1.Focus();
                return;
            }
            string sorgu = "Delete From kart Where Kart_Id=@Kart_Id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Kart_Id", comboBox1.SelectedItem);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kart Teslim Alındı");
            comboBox1.SelectedItem = null;
      

            baglanti.Open();
            da = new SqlDataAdapter("Select *From kart", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();


        }

        private void kte_KeyUp(object sender, KeyEventArgs e)
        {

           
        }
    }
}
