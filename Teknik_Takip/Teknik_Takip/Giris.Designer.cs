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
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Giris_Buton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Kullanici_Adi_Textbox = new System.Windows.Forms.TextBox();
            this.Parola_Textbox = new System.Windows.Forms.TextBox();
            this.Tarih_Label = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(89, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Giris_Buton
            // 
            this.Giris_Buton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Giris_Buton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Giris_Buton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Giris_Buton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Giris_Buton.Location = new System.Drawing.Point(179, 120);
            this.Giris_Buton.Name = "Giris_Buton";
            this.Giris_Buton.Size = new System.Drawing.Size(47, 26);
            this.Giris_Buton.TabIndex = 3;
            this.Giris_Buton.Text = "Giriş";
            this.Giris_Buton.UseVisualStyleBackColor = false;
            this.Giris_Buton.Click += new System.EventHandler(this.button1_Click);
            this.Giris_Buton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Giris_Buton_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(92, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Parola";
            // 
            // Kullanici_Adi_Textbox
            // 
            this.Kullanici_Adi_Textbox.Location = new System.Drawing.Point(160, 43);
            this.Kullanici_Adi_Textbox.Name = "Kullanici_Adi_Textbox";
            this.Kullanici_Adi_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Kullanici_Adi_Textbox.TabIndex = 1;
            this.Kullanici_Adi_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Kullanici_Adi_Textbox_KeyDown);
            // 
            // Parola_Textbox
            // 
            this.Parola_Textbox.Location = new System.Drawing.Point(160, 71);
            this.Parola_Textbox.Name = "Parola_Textbox";
            this.Parola_Textbox.PasswordChar = '*';
            this.Parola_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Parola_Textbox.TabIndex = 2;
            this.Parola_Textbox.TextChanged += new System.EventHandler(this.Parola_Textbox_TextChanged);
            this.Parola_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Kullanici_Adi_Textbox_KeyDown);
            // 
            // Tarih_Label
            // 
            this.Tarih_Label.AutoSize = true;
            this.Tarih_Label.BackColor = System.Drawing.Color.Transparent;
            this.Tarih_Label.Location = new System.Drawing.Point(240, 11);
            this.Tarih_Label.Name = "Tarih_Label";
            this.Tarih_Label.Size = new System.Drawing.Size(35, 13);
            this.Tarih_Label.TabIndex = 9;
            this.Tarih_Label.Text = "label3";
            this.Tarih_Label.Click += new System.EventHandler(this.Tarih_Label_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(160, 97);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
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
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.ForeColor = System.Drawing.Color.MediumBlue;
            this.button1.Location = new System.Drawing.Point(312, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kayıt Ol";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Şifremi Unuttum";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 212);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Tarih_Label);
            this.Controls.Add(this.Parola_Textbox);
            this.Controls.Add(this.Kullanici_Adi_Textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Giris_Buton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox Parola_Textbox;
        private System.Windows.Forms.TextBox Kullanici_Adi_Textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Tarih_Label;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Giris_Buton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

