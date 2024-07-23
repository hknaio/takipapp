namespace WinFormsApp1
{
    partial class YatirimTanimlama
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
            dataGridView1 = new DataGridView();
            Kaynak = new DataGridViewTextBoxColumn();
            Yil = new DataGridViewTextBoxColumn();
            Detay = new DataGridViewButtonColumn();
            Sil = new DataGridViewButtonColumn();
            label1 = new Label();
            btnEkle = new Button();
            label2 = new Label();
            label3 = new Label();
            cmbKaynak = new ComboBox();
            txtYil = new MaskedTextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Kaynak, Yil, Detay, Sil });
            dataGridView1.Location = new Point(22, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(608, 489);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Kaynak
            // 
            Kaynak.DataPropertyName = "Kaynak";
            Kaynak.HeaderText = "Kaynak";
            Kaynak.MinimumWidth = 8;
            Kaynak.Name = "Kaynak";
            Kaynak.ReadOnly = true;
            Kaynak.Width = 150;
            // 
            // Yil
            // 
            Yil.DataPropertyName = "Yil";
            Yil.HeaderText = "Yıl";
            Yil.MinimumWidth = 8;
            Yil.Name = "Yil";
            Yil.ReadOnly = true;
            Yil.Width = 150;
            // 
            // Detay
            // 
            Detay.HeaderText = "Detay";
            Detay.MinimumWidth = 8;
            Detay.Name = "Detay";
            Detay.ReadOnly = true;
            Detay.Text = "Program Detay";
            Detay.ToolTipText = "Program Detayı";
            Detay.UseColumnTextForButtonValue = true;
            Detay.Width = 150;
            // 
            // Sil
            // 
            Sil.HeaderText = "Sil";
            Sil.MinimumWidth = 8;
            Sil.Name = "Sil";
            Sil.ReadOnly = true;
            Sil.Text = "Sil";
            Sil.ToolTipText = "Sil";
            Sil.UseColumnTextForButtonValue = true;
            Sil.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(462, 29);
            label1.Name = "label1";
            label1.Size = new Size(19, 25);
            label1.TabIndex = 2;
            label1.Text = "-";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(659, 99);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(216, 34);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Sisteme Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 102);
            label2.Name = "label2";
            label2.Size = new Size(39, 25);
            label2.TabIndex = 5;
            label2.Text = "Yıl :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(279, 102);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 6;
            label3.Text = "Kaynak :";
            // 
            // cmbKaynak
            // 
            cmbKaynak.FormattingEnabled = true;
            cmbKaynak.Items.AddRange(new object[] { "İl Özel İdaresi", "KÖYDES", "İlbank", "Diğer" });
            cmbKaynak.Location = new Point(394, 99);
            cmbKaynak.Name = "cmbKaynak";
            cmbKaynak.Size = new Size(182, 33);
            cmbKaynak.TabIndex = 7;
            // 
            // txtYil
            // 
            txtYil.Location = new Point(67, 99);
            txtYil.Name = "txtYil";
            txtYil.Size = new Size(150, 31);
            txtYil.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(326, 29);
            label4.Name = "label4";
            label4.Size = new Size(130, 25);
            label4.TabIndex = 9;
            label4.Text = "Seçilen Dosya :";
            // 
            // YatirimTanimlama
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 658);
            Controls.Add(label4);
            Controls.Add(txtYil);
            Controls.Add(cmbKaynak);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnEkle);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "YatirimTanimlama";
            Text = "Yatırım  Programı Tanmlama";
            FormClosing += YatirimTanimlama_FormClosing;
            Load += YatirimTanimlama_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button btnEkle;
        private Label label2;
        private Label label3;
        private ComboBox cmbKaynak;
        private MaskedTextBox txtYil;
        private Label label4;
        private DataGridViewTextBoxColumn Kaynak;
        private DataGridViewTextBoxColumn Yil;
        private DataGridViewButtonColumn Detay;
        private DataGridViewButtonColumn Sil;
    }
}