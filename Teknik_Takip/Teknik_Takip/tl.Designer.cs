namespace Teknik_Takip
{
    partial class tl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tl));
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Malzeme_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Malzeme_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Malzeme_Miktari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Olusturulma_Zamani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Olusturan_Personel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(162)))), ((int)(((byte)(214)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(475, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dışa Aktar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Malzeme_Id,
            this.Malzeme_adi,
            this.Malzeme_Miktari,
            this.Olusturulma_Zamani,
            this.Olusturan_Personel});
            this.dataGridView1.Location = new System.Drawing.Point(13, 49);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(999, 393);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // Malzeme_Id
            // 
            this.Malzeme_Id.DataPropertyName = "Malzeme_Id";
            this.Malzeme_Id.HeaderText = "Malzeme ID";
            this.Malzeme_Id.Name = "Malzeme_Id";
            // 
            // Malzeme_adi
            // 
            this.Malzeme_adi.DataPropertyName = "Malzeme_adi";
            this.Malzeme_adi.HeaderText = "Malzeme Adı";
            this.Malzeme_adi.Name = "Malzeme_adi";
            // 
            // Malzeme_Miktari
            // 
            this.Malzeme_Miktari.DataPropertyName = "Malzeme_Miktari";
            this.Malzeme_Miktari.HeaderText = "Malzeme Miktarı";
            this.Malzeme_Miktari.Name = "Malzeme_Miktari";
            // 
            // Olusturulma_Zamani
            // 
            this.Olusturulma_Zamani.DataPropertyName = "Olusturulma_Zamani";
            this.Olusturulma_Zamani.HeaderText = "Kayıt Zamanı";
            this.Olusturulma_Zamani.Name = "Olusturulma_Zamani";
            // 
            // Olusturan_Personel
            // 
            this.Olusturan_Personel.DataPropertyName = "Olusturan_Personel";
            this.Olusturan_Personel.HeaderText = "Kayıt Yapan Personel";
            this.Olusturan_Personel.Name = "Olusturan_Personel";
            // 
            // tl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 609);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "tl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tümünü Listele";
            this.Load += new System.EventHandler(this.tl_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tl_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malzeme_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malzeme_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malzeme_Miktari;
        private System.Windows.Forms.DataGridViewTextBoxColumn Olusturulma_Zamani;
        private System.Windows.Forms.DataGridViewTextBoxColumn Olusturan_Personel;
    }
}