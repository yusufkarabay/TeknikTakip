namespace Teknik_Takip
{
    partial class et
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(et));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MalzemeID_Textbox = new System.Windows.Forms.TextBox();
            this.MalzemeAdi_Textbox = new System.Windows.Forms.TextBox();
            this.Ekle_Buton = new System.Windows.Forms.Button();
            this.Stok_Sorgulama_Ekrani_Gidis_Buton = new System.Windows.Forms.Button();
            this.Malzeme_Silme_Ekrani_Gidis = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(25, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Malzeme ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(25, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Malzeme Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(25, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Malzeme Miktarı";
            // 
            // MalzemeID_Textbox
            // 
            this.MalzemeID_Textbox.Location = new System.Drawing.Point(137, 79);
            this.MalzemeID_Textbox.Name = "MalzemeID_Textbox";
            this.MalzemeID_Textbox.Size = new System.Drawing.Size(167, 20);
            this.MalzemeID_Textbox.TabIndex = 1;
            this.MalzemeID_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MalzemeID_Textbox_KeyDown);
            // 
            // MalzemeAdi_Textbox
            // 
            this.MalzemeAdi_Textbox.Location = new System.Drawing.Point(137, 105);
            this.MalzemeAdi_Textbox.Name = "MalzemeAdi_Textbox";
            this.MalzemeAdi_Textbox.Size = new System.Drawing.Size(167, 20);
            this.MalzemeAdi_Textbox.TabIndex = 2;
            this.MalzemeAdi_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MalzemeAdi_Textbox_KeyDown);
            // 
            // Ekle_Buton
            // 
            this.Ekle_Buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Ekle_Buton.Location = new System.Drawing.Point(189, 175);
            this.Ekle_Buton.Name = "Ekle_Buton";
            this.Ekle_Buton.Size = new System.Drawing.Size(52, 22);
            this.Ekle_Buton.TabIndex = 4;
            this.Ekle_Buton.Text = "Ekle";
            this.Ekle_Buton.UseVisualStyleBackColor = false;
            this.Ekle_Buton.Click += new System.EventHandler(this.Ekle_Buton_Click);
            this.Ekle_Buton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ekle_Buton_KeyDown);
            // 
            // Stok_Sorgulama_Ekrani_Gidis_Buton
            // 
            this.Stok_Sorgulama_Ekrani_Gidis_Buton.BackColor = System.Drawing.Color.LightCoral;
            this.Stok_Sorgulama_Ekrani_Gidis_Buton.Location = new System.Drawing.Point(433, 74);
            this.Stok_Sorgulama_Ekrani_Gidis_Buton.Name = "Stok_Sorgulama_Ekrani_Gidis_Buton";
            this.Stok_Sorgulama_Ekrani_Gidis_Buton.Size = new System.Drawing.Size(159, 23);
            this.Stok_Sorgulama_Ekrani_Gidis_Buton.TabIndex = 5;
            this.Stok_Sorgulama_Ekrani_Gidis_Buton.Text = "Malzeme Stok Sorgulama";
            this.Stok_Sorgulama_Ekrani_Gidis_Buton.UseVisualStyleBackColor = false;
            this.Stok_Sorgulama_Ekrani_Gidis_Buton.Click += new System.EventHandler(this.Stok_Sorgulama_Ekrani_Gidis_Buton_Click);
            // 
            // Malzeme_Silme_Ekrani_Gidis
            // 
            this.Malzeme_Silme_Ekrani_Gidis.BackColor = System.Drawing.SystemColors.Highlight;
            this.Malzeme_Silme_Ekrani_Gidis.Location = new System.Drawing.Point(433, 116);
            this.Malzeme_Silme_Ekrani_Gidis.Name = "Malzeme_Silme_Ekrani_Gidis";
            this.Malzeme_Silme_Ekrani_Gidis.Size = new System.Drawing.Size(159, 23);
            this.Malzeme_Silme_Ekrani_Gidis.TabIndex = 6;
            this.Malzeme_Silme_Ekrani_Gidis.Text = "Malzeme Silme";
            this.Malzeme_Silme_Ekrani_Gidis.UseVisualStyleBackColor = false;
            this.Malzeme_Silme_Ekrani_Gidis.Click += new System.EventHandler(this.Malzeme_Silme_Ekrani_Gidis_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Location = new System.Drawing.Point(433, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Malzeme Güncelleme";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkKhaki;
            this.button2.Location = new System.Drawing.Point(433, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Tümünü Listele";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_1);
            // 
            // et
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 697);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Malzeme_Silme_Ekrani_Gidis);
            this.Controls.Add(this.Stok_Sorgulama_Ekrani_Gidis_Buton);
            this.Controls.Add(this.Ekle_Buton);
            this.Controls.Add(this.MalzemeAdi_Textbox);
            this.Controls.Add(this.MalzemeID_Textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "et";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envanter Takip";
            this.Load += new System.EventHandler(this.et_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.et_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.et_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MalzemeID_Textbox;
        private System.Windows.Forms.TextBox MalzemeAdi_Textbox;
        private System.Windows.Forms.Button Ekle_Buton;
        private System.Windows.Forms.Button Stok_Sorgulama_Ekrani_Gidis_Buton;
        private System.Windows.Forms.Button Malzeme_Silme_Ekrani_Gidis;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}