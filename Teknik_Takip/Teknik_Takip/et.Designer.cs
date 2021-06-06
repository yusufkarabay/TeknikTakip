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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(330, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Malzeme ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(330, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Malzeme Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(330, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Malzeme Miktarı";
            // 
            // MalzemeID_Textbox
            // 
            this.MalzemeID_Textbox.Location = new System.Drawing.Point(479, 174);
            this.MalzemeID_Textbox.Margin = new System.Windows.Forms.Padding(4);
            this.MalzemeID_Textbox.Name = "MalzemeID_Textbox";
            this.MalzemeID_Textbox.Size = new System.Drawing.Size(351, 23);
            this.MalzemeID_Textbox.TabIndex = 1;
            this.MalzemeID_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MalzemeID_Textbox_KeyDown);
            // 
            // MalzemeAdi_Textbox
            // 
            this.MalzemeAdi_Textbox.Location = new System.Drawing.Point(479, 206);
            this.MalzemeAdi_Textbox.Margin = new System.Windows.Forms.Padding(4);
            this.MalzemeAdi_Textbox.Name = "MalzemeAdi_Textbox";
            this.MalzemeAdi_Textbox.Size = new System.Drawing.Size(351, 23);
            this.MalzemeAdi_Textbox.TabIndex = 2;
            this.MalzemeAdi_Textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MalzemeAdi_Textbox_KeyDown);
            // 
            // Ekle_Buton
            // 
            this.Ekle_Buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(162)))), ((int)(((byte)(214)))));
            this.Ekle_Buton.FlatAppearance.BorderSize = 0;
            this.Ekle_Buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ekle_Buton.ForeColor = System.Drawing.SystemColors.Control;
            this.Ekle_Buton.Location = new System.Drawing.Point(589, 305);
            this.Ekle_Buton.Margin = new System.Windows.Forms.Padding(4);
            this.Ekle_Buton.Name = "Ekle_Buton";
            this.Ekle_Buton.Size = new System.Drawing.Size(69, 23);
            this.Ekle_Buton.TabIndex = 4;
            this.Ekle_Buton.Text = "Ekle";
            this.Ekle_Buton.UseVisualStyleBackColor = false;
            this.Ekle_Buton.Click += new System.EventHandler(this.Ekle_Buton_Click);
            this.Ekle_Buton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ekle_Buton_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(479, 246);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_1);
            // 
            // et
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 648);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Ekle_Buton);
            this.Controls.Add(this.MalzemeAdi_Textbox);
            this.Controls.Add(this.MalzemeID_Textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
    }
}