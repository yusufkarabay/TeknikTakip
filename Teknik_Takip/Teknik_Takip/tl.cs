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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using static iTextSharp.text.Font;



namespace Teknik_Takip
{

  
    public partial class tl : Form
    {
        public tl()
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

        private void tl_Load(object sender, EventArgs e)
        {
            label2.Text = Program.Ad_Soyad;
            timer1.Start();
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            et myForm = new et();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void exportgridpdf(DataGridView dgw, string filname)
        {
             BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.NOT_EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
           // pdftable.AddCell(new Phrase("ğüşıöç ĞÜŞİÖÇ", fontNormal));

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //başlık
            foreach (DataGridViewColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
                
            }
            //datarow
            foreach (DataGridViewRow row in dgw.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                   // pdftable.AddCell(new Phrase("ğüşıöç ĞÜŞİÖÇ", iTextSharp.text.Font.NORMAL);
                }
            }
            var savefieldialoge = new SaveFileDialog();
            savefieldialoge.FileName = filname;
            savefieldialoge.DefaultExt = ".pdf";
            if (savefieldialoge.ShowDialog() == DialogResult.OK)
            {

                using (FileStream stream = new FileStream(savefieldialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);

                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();

                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            exportgridpdf(dataGridView1, "malzeme listesi");

     
        }

        private void tl_KeyUp(object sender, KeyEventArgs e)
        {
        
        }
    }


}
