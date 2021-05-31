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
    public partial class zimmetteki_kartal : Form
    {
        public zimmetteki_kartal()
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
            da = new SqlDataAdapter("Select *From kart_zimmet", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void zimmetteki_kartal_Load(object sender, EventArgs e)
        {

          //  dataGridView1.Refresh();
            baglanti.Open();

            SqlCommand cmd = new SqlCommand("Select Karti_Alan_Personel From kart_zimmet", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Karti_Alan_Personel"]);
            }




            baglanti.Close();
            //label2.Text = Program.Ad_Soyad;
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kart_zimmet myForm = new kart_zimmet();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            //this.label1.Text = datetime.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kartsecimi;
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Kart Seçiniz");

                comboBox1.Focus();
                return;
            }
            string sorgu = "Delete From kart_zimmet Where Karti_Alan_Personel=@Karti_Alan_Personel";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Karti_Alan_Personel", comboBox1.SelectedItem);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kart Teslim Alındı");
            comboBox1.SelectedItem = null;


            baglanti.Open();
            da = new SqlDataAdapter("Select *From kart_zimmet", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
