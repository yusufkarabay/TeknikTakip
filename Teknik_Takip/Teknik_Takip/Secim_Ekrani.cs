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
    public partial class Secim_Ekrani : Form
    {
        public Secim_Ekrani()
        {
            InitializeComponent();
        }

        public string KullaniciAdSoyad;
        SqlConnection baglanti = new SqlConnection(@"Server=192.168.1.254;Database=Teknik_TakipDb;User Id=yusufkarabay;Password=Kobe+kobe1;");
        private void button1_Click(object sender, EventArgs e)
        {
            nt myForm = new nt();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            et myForm = new et();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mkt myForm = new mkt();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void Jenarator_Calısma_Zamani_Buton_Click(object sender, EventArgs e)
        {
            jcz myForm = new jcz();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void Secim_Ekrani_Load(object sender, EventArgs e)
        {
            Personel_Label.Text = Program.Ad_Soyad;
                timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.Tarih_Label.Text = datetime.ToShortDateString();
        }

        private void Personel_Label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Bakim_Ekrani myForm = new Bakim_Ekrani();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            kt myForm = new kt();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            kart_zimmet myForm = new kart_zimmet();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
    }
    

