namespace Teknik_Takip
{
    partial class Giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Giris_Buton = new System.Windows.Forms.Button();
            this.Kullanici_Adi_Textbox = new System.Windows.Forms.TextBox();
            this.Parola_Textbox = new System.Windows.Forms.TextBox();
            this.Tarih_Label = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nobet_TeslimTableAdapter1 = new Teknik_Takip.Teknik_TakipDbDataSetTableAdapters.Nobet_TeslimTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Giris_Buton
            // 
            this.Giris_Buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(162)))), ((int)(((byte)(214)))));
            this.Giris_Buton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Giris_Buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Giris_Buton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Giris_Buton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Giris_Buton.Location = new System.Drawing.Point(76, 394);
            this.Giris_Buton.Name = "Giris_Buton";
            this.Giris_Buton.Size = new System.Drawing.Size(250, 33);
            this.Giris_Buton.TabIndex = 3;
            this.Giris_Buton.Text = "Giriş";
            this.Giris_Buton.UseVisualStyleBackColor = false;
            this.Giris_Buton.Click += new System.EventHandler(this.button1_Click);
            this.Giris_Buton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Giris_Buton_KeyDown);
            // 
            // Kullanici_Adi_Textbox
            // 
            this.Kullanici_Adi_Textbox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Kullanici_Adi_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Kullanici_Adi_Textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kullanici_Adi_Textbox.ForeColor = System.Drawing.Color.White;
            this.Kullanici_Adi_Textbox.HideSelection = false;
            this.Kullanici_Adi_Textbox.Location = new System.Drawing.Point(105, 276);
            this.Kullanici_Adi_Textbox.Name = "Kullanici_Adi_Textbox";
            this.Kullanici_Adi_Textbox.Size = new System.Drawing.Size(144, 16);
            this.Kullanici_Adi_Textbox.TabIndex = 1;
            this.Kullanici_Adi_Textbox.TabStop = false;
            this.Kullanici_Adi_Textbox.Text = "Kullanıcı Adı";
            this.Kullanici_Adi_Textbox.Click += new System.EventHandler(this.Kullanici_Adi_Textbox_Click);
            this.Kullanici_Adi_Textbox.TextChanged += new System.EventHandler(this.Kullanici_Adi_Textbox_TextChanged);
            this.Kullanici_Adi_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Kullanici_Adi_Textbox_KeyDown);
            // 
            // Parola_Textbox
            // 
            this.Parola_Textbox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Parola_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Parola_Textbox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Parola_Textbox.ForeColor = System.Drawing.Color.White;
            this.Parola_Textbox.HideSelection = false;
            this.Parola_Textbox.Location = new System.Drawing.Point(105, 331);
            this.Parola_Textbox.Name = "Parola_Textbox";
            this.Parola_Textbox.PasswordChar = '*';
            this.Parola_Textbox.Size = new System.Drawing.Size(144, 14);
            this.Parola_Textbox.TabIndex = 2;
            this.Parola_Textbox.TabStop = false;
            this.Parola_Textbox.Text = "parola";
            this.Parola_Textbox.Click += new System.EventHandler(this.Parola_Textbox_Click);
            this.Parola_Textbox.TextChanged += new System.EventHandler(this.Parola_Textbox_TextChanged);
            this.Parola_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Kullanici_Adi_Textbox_KeyDown);
            // 
            // Tarih_Label
            // 
            this.Tarih_Label.AutoSize = true;
            this.Tarih_Label.BackColor = System.Drawing.Color.Transparent;
            this.Tarih_Label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tarih_Label.ForeColor = System.Drawing.Color.White;
            this.Tarih_Label.Location = new System.Drawing.Point(327, 9);
            this.Tarih_Label.Name = "Tarih_Label";
            this.Tarih_Label.Size = new System.Drawing.Size(49, 16);
            this.Tarih_Label.TabIndex = 9;
            this.Tarih_Label.Text = "label3";
            this.Tarih_Label.Click += new System.EventHandler(this.Tarih_Label_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(76, 367);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 21);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(76, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kayıt Ol";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Şifremi Unuttum";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nobet_TeslimTableAdapter1
            // 
            this.nobet_TeslimTableAdapter1.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 57;
            this.button3.Text = "kapat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(76, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 1);
            this.panel1.TabIndex = 59;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(76, 351);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 60;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Teknik_Takip.Properties.Resources.lock_16;
            this.pictureBox3.Location = new System.Drawing.Point(76, 329);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.TabIndex = 60;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Teknik_Takip.Properties.Resources.user_16;
            this.pictureBox2.Location = new System.Drawing.Point(76, 274);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(76, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(400, 552);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Tarih_Label);
            this.Controls.Add(this.Parola_Textbox);
            this.Controls.Add(this.Kullanici_Adi_Textbox);
            this.Controls.Add(this.Giris_Buton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox Parola_Textbox;
        private System.Windows.Forms.TextBox Kullanici_Adi_Textbox;
        private System.Windows.Forms.Label Tarih_Label;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Giris_Buton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Teknik_TakipDbDataSetTableAdapters.Nobet_TeslimTableAdapter nobet_TeslimTableAdapter1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
    }
}

