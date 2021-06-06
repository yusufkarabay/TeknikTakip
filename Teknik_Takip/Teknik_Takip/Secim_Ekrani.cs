using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

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


        public void FormGetir(Form frm)
        {
            panel2.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(frm);
            frm.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            position(Nobet_Teslim_Buton);
            nt myForm = new nt();
            FormGetir(myForm);
            SidePanel.Visible = true;
            panel3.Visible = false;


        }


        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;

            et myForm = new et();
            FormGetir(myForm);
            position(Envarter_Takip_Buton);


            button4.Visible = false;
            button6.Visible = false;

            SidePanel.Visible = true;

            Stok_Sorgulama_Ekrani_Gidis_Buton.Visible = true;
            Malzeme_Silme_Ekrani_Gidis.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button7.Visible = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            mkt myForm = new mkt();
            FormGetir(myForm);
            position(Misafir_Kart_Takip_Buton);
            SidePanel.Visible = true;


            panel3.Visible = true;

            button4.Visible = true;
            button6.Visible = false;
            button7.Visible = false;

            Stok_Sorgulama_Ekrani_Gidis_Buton.Visible = false;
            Malzeme_Silme_Ekrani_Gidis.Visible = false;
            button1.Visible = false;
            button2.Visible = false;

        }

        private void Jenarator_Calısma_Zamani_Buton_Click(object sender, EventArgs e)
        {
            jcz myForm = new jcz();
            FormGetir(myForm);
            position(Jenarator_Calısma_Zamani_Buton);
            SidePanel.Visible = true;
            panel3.Visible = false;

        }
        private void position(Button b)
        {
            SidePanel.Location = new Point(b.Location.X - SidePanel.Width, b.Location.Y);
        }

        private void Secim_Ekrani_Load(object sender, EventArgs e)
        {
         
                Personel_Label.Text = Program.Ad_Soyad;
                timer1.Start();
                  SidePanel.Visible = false;
                 panel3.Visible = false;
                 
            button4.Visible = false;
            //panel1.Location = new Point(Nobet_Teslim_Buton.Location.X-panel1.Width, Nobet_Teslim_Buton.Location.Y);

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
            FormGetir(myForm);
            position(bakim_ekrani_buton);
            SidePanel.Visible = true;
            panel3.Visible = false;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            kt myForm = new kt();
            FormGetir(myForm);
            position(kulaklik_teslim_buton);
            SidePanel.Visible = true;
            panel3.Visible = true;
            button6.Visible = true;

            button4.Visible = false;

            Stok_Sorgulama_Ekrani_Gidis_Buton.Visible = false;
            Malzeme_Silme_Ekrani_Gidis.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button7.Visible = false;



        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            kart_zimmet myForm = new kart_zimmet();
            FormGetir(myForm);
            position(kart_zimmet_buton);
            SidePanel.Visible = true;
            


            panel3.Visible = true;
            button4.Visible = false;
            button6.Visible = false;
            button7.Visible = true;

            Stok_Sorgulama_Ekrani_Gidis_Buton.Visible = false;
            Malzeme_Silme_Ekrani_Gidis.Visible = false;
            button1.Visible = false;
            button2.Visible = false;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Stok_Sorgulama_Ekrani_Gidis_Buton_Click(object sender, EventArgs e)
        {
            
            mss myForm = new mss();
            FormGetir(myForm);            
            SidePanel.Visible = true;
        }

        private void Malzeme_Silme_Ekrani_Gidis_Click(object sender, EventArgs e)
        {
            ms myForm = new ms();
            FormGetir(myForm);
            SidePanel.Visible = true;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            mg myForm = new mg();
            FormGetir(myForm);
            SidePanel.Visible = true;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            tl myForm = new tl();
            FormGetir(myForm);
            SidePanel.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            kte myForm = new kte();
            FormGetir(myForm);
            SidePanel.Visible = true;
            button4.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kulaklikta myForm = new kulaklikta();
            FormGetir(myForm);
            SidePanel.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            zimmetteki_kartal myForm = new zimmetteki_kartal();
            FormGetir(myForm);
            SidePanel.Visible = true;
        }
    }
    }
    

