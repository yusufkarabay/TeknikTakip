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
using ZXing;

namespace Teknik_Takip
{
    public partial class et : Form
    {
        public et()
        {
            InitializeComponent();
        }

        SqlCommand komut;
        SqlDataAdapter da;
        SqlConnection baglanti = new SqlConnection(@"Server=192.168.1.254;Database=Teknik_TakipDb;User Id=yusufkarabay;Password=Kobe+kobe1;");

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
           // this.Tarih_Label.Text = datetime.ToShortDateString();
        }

        private void et_Load(object sender, EventArgs e)
        {
            //Personel_Label.Text = Program.Ad_Soyad;
            timer1.Start();
        }

        private void AnaMenu_Buton_Click(object sender, EventArgs e)
        {
            
            Secim_Ekrani myForm = new Secim_Ekrani();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void Ekle_Buton_Click(object sender, EventArgs e)
        {
            string malzemeid = MalzemeID_Textbox.Text.Trim();
            if (malzemeid.Length == 0)
            {
                MessageBox.Show("Malzeme ID giriniz.");
                MalzemeID_Textbox.Clear();
                MalzemeID_Textbox.Focus();
                return;
            }
            string malemeadi = MalzemeAdi_Textbox.Text.Trim();
            if (malemeadi.Length == 0)
            {
                MessageBox.Show("Malzeme adını giriniz.");
                MalzemeAdi_Textbox.Clear();
                MalzemeAdi_Textbox.Focus();
                return;
            }
            string malzememiktari = textBox1.Text.Trim();
            if (malzememiktari.Length == 0)
            {
                MessageBox.Show("Malzeme miktarını giriniz.");
                textBox1.Clear();
                textBox1.Focus();
                return;
            }

            string sorgu = "Insert into envarter (Malzeme_Id,Malzeme_adi,Malzeme_Miktari,Olusturan_Personel) values (@Malzeme_Id,@Malzeme_adi,@Malzeme_Miktari,@Olusturan_Personel)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Malzeme_Id", (MalzemeID_Textbox.Text));
            komut.Parameters.AddWithValue("@Malzeme_adi", MalzemeAdi_Textbox.Text);
            komut.Parameters.AddWithValue("@Malzeme_Miktari", textBox1.Text);            
            komut.Parameters.AddWithValue("@Olusturan_Personel", Program.Ad_Soyad);
            baglanti.Open();
            komut.ExecuteNonQuery();

        
            baglanti.Close();
            MalzemeID_Textbox.Clear();
            MalzemeID_Textbox.Focus();

            MalzemeAdi_Textbox.Clear();
            MalzemeAdi_Textbox.Focus();

            textBox1.Clear();
            textBox1.Focus();
            MessageBox.Show("Kayıt Başarılı");
           
        }

        private void Malzeme_Silme_Ekrani_Gidis_Click(object sender, EventArgs e)
        {
            ms myForm = new ms();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mg myForm = new mg();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void Stok_Sorgulama_Ekrani_Gidis_Buton_Click(object sender, EventArgs e)
        {
            mss myForm = new mss();
            FormGetir(myForm);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tl myForm = new tl();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void MalzemeMiktari_Textbox_TextChanged(object sender, EventArgs e)
        {

        }
     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Ekle_Buton_Click((object)sender, (EventArgs)e);
            }
        }

        private void MalzemeID_Textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Ekle_Buton_Click((object)sender, (EventArgs)e);
            }
        }

        private void MalzemeAdi_Textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Ekle_Buton_Click((object)sender, (EventArgs)e);
            }
        }

        private void AnaMenu_Buton_KeyDown(object sender, KeyEventArgs e)
        {
            

        }

        private void AnaMenu_Buton_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void et_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void et_KeyUp(object sender, KeyEventArgs e)
        {

         

        }

        private void Tarih_Label_Click(object sender, EventArgs e)
        {

        }

        private void Ekle_Buton_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
