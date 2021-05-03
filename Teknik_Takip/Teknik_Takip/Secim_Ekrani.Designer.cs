namespace Teknik_Takip
{
    partial class Secim_Ekrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Secim_Ekrani));
            this.Nobet_Teslim_Buton = new System.Windows.Forms.Button();
            this.Misafir_Kart_Takip_Buton = new System.Windows.Forms.Button();
            this.Envarter_Takip_Buton = new System.Windows.Forms.Button();
            this.Jenarator_Calısma_Zamani_Buton = new System.Windows.Forms.Button();
            this.Tarih_Label = new System.Windows.Forms.Label();
            this.Personel_Label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nobet_Teslim_Buton
            // 
            this.Nobet_Teslim_Buton.BackColor = System.Drawing.Color.DimGray;
            this.Nobet_Teslim_Buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nobet_Teslim_Buton.Location = new System.Drawing.Point(0, 57);
            this.Nobet_Teslim_Buton.Name = "Nobet_Teslim_Buton";
            this.Nobet_Teslim_Buton.Size = new System.Drawing.Size(180, 36);
            this.Nobet_Teslim_Buton.TabIndex = 1;
            this.Nobet_Teslim_Buton.Text = "Nöbet Teslim";
            this.Nobet_Teslim_Buton.UseVisualStyleBackColor = false;
            this.Nobet_Teslim_Buton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Misafir_Kart_Takip_Buton
            // 
            this.Misafir_Kart_Takip_Buton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Misafir_Kart_Takip_Buton.Location = new System.Drawing.Point(814, 160);
            this.Misafir_Kart_Takip_Buton.Name = "Misafir_Kart_Takip_Buton";
            this.Misafir_Kart_Takip_Buton.Size = new System.Drawing.Size(143, 23);
            this.Misafir_Kart_Takip_Buton.TabIndex = 3;
            this.Misafir_Kart_Takip_Buton.Text = "Misafir Kart Takip";
            this.Misafir_Kart_Takip_Buton.UseVisualStyleBackColor = false;
            this.Misafir_Kart_Takip_Buton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Envarter_Takip_Buton
            // 
            this.Envarter_Takip_Buton.BackColor = System.Drawing.Color.SkyBlue;
            this.Envarter_Takip_Buton.Location = new System.Drawing.Point(814, 113);
            this.Envarter_Takip_Buton.Name = "Envarter_Takip_Buton";
            this.Envarter_Takip_Buton.Size = new System.Drawing.Size(143, 25);
            this.Envarter_Takip_Buton.TabIndex = 2;
            this.Envarter_Takip_Buton.Text = "Envanter Takip";
            this.Envarter_Takip_Buton.UseVisualStyleBackColor = false;
            this.Envarter_Takip_Buton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Jenarator_Calısma_Zamani_Buton
            // 
            this.Jenarator_Calısma_Zamani_Buton.BackColor = System.Drawing.Color.DodgerBlue;
            this.Jenarator_Calısma_Zamani_Buton.Location = new System.Drawing.Point(814, 207);
            this.Jenarator_Calısma_Zamani_Buton.Name = "Jenarator_Calısma_Zamani_Buton";
            this.Jenarator_Calısma_Zamani_Buton.Size = new System.Drawing.Size(143, 23);
            this.Jenarator_Calısma_Zamani_Buton.TabIndex = 4;
            this.Jenarator_Calısma_Zamani_Buton.Text = "Jenaratör Çalışma Zamanı";
            this.Jenarator_Calısma_Zamani_Buton.UseVisualStyleBackColor = false;
            this.Jenarator_Calısma_Zamani_Buton.Click += new System.EventHandler(this.Jenarator_Calısma_Zamani_Buton_Click);
            // 
            // Tarih_Label
            // 
            this.Tarih_Label.AutoSize = true;
            this.Tarih_Label.BackColor = System.Drawing.Color.Transparent;
            this.Tarih_Label.Location = new System.Drawing.Point(890, 9);
            this.Tarih_Label.Name = "Tarih_Label";
            this.Tarih_Label.Size = new System.Drawing.Size(35, 13);
            this.Tarih_Label.TabIndex = 4;
            this.Tarih_Label.Text = "label1";
            // 
            // Personel_Label
            // 
            this.Personel_Label.AutoSize = true;
            this.Personel_Label.BackColor = System.Drawing.Color.Transparent;
            this.Personel_Label.Location = new System.Drawing.Point(757, 9);
            this.Personel_Label.Name = "Personel_Label";
            this.Personel_Label.Size = new System.Drawing.Size(35, 13);
            this.Personel_Label.TabIndex = 5;
            this.Personel_Label.Text = "label2";
            this.Personel_Label.Click += new System.EventHandler(this.Personel_Label_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.Location = new System.Drawing.Point(814, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Bakım Ekranı";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.Location = new System.Drawing.Point(814, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Kulaklık Teslim";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button3.Location = new System.Drawing.Point(814, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Kart Zimmet ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.Nobet_Teslim_Buton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 466);
            this.panel1.TabIndex = 9;
            // 
            // Secim_Ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Teknik_Takip.Properties.Resources._21;
            this.ClientSize = new System.Drawing.Size(958, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Personel_Label);
            this.Controls.Add(this.Tarih_Label);
            this.Controls.Add(this.Jenarator_Calısma_Zamani_Buton);
            this.Controls.Add(this.Envarter_Takip_Buton);
            this.Controls.Add(this.Misafir_Kart_Takip_Buton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Secim_Ekrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seçim Ekranı";
            this.Load += new System.EventHandler(this.Secim_Ekrani_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nobet_Teslim_Buton;
        private System.Windows.Forms.Button Misafir_Kart_Takip_Buton;
        private System.Windows.Forms.Button Envarter_Takip_Buton;
        private System.Windows.Forms.Button Jenarator_Calısma_Zamani_Buton;
        private System.Windows.Forms.Label Tarih_Label;
        private System.Windows.Forms.Label Personel_Label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
    }
}