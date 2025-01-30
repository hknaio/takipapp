namespace WinFormsApp1
{
    partial class YeniProjeEkleSu
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
            label1 = new Label();
            txtProjeAdi = new TextBox();
            label3 = new Label();
            txtAciklama = new TextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            Koy = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Ilce = new DataGridViewTextBoxColumn();
            Imalat = new DataGridViewTextBoxColumn();
            Birim = new DataGridViewTextBoxColumn();
            Uygulama = new DataGridViewTextBoxColumn();
            YaklasikMaliyet = new DataGridViewTextBoxColumn();
            Proje = new DataGridViewTextBoxColumn();
            Miktar = new DataGridViewTextBoxColumn();
            Yil = new DataGridViewTextBoxColumn();
            Kaynak = new DataGridViewTextBoxColumn();
            YatirimDurumu = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 40);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 0;
            label1.Text = "Proje Adı : ";
            // 
            // txtProjeAdi
            // 
            txtProjeAdi.Location = new Point(178, 40);
            txtProjeAdi.Name = "txtProjeAdi";
            txtProjeAdi.Size = new Size(304, 31);
            txtProjeAdi.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 99);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 3;
            label3.Text = "Açıklama :";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(178, 96);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(505, 70);
            txtAciklama.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Koy, ID, Ilce, Imalat, Birim, Uygulama, YaklasikMaliyet, Proje, Miktar, Yil, Kaynak, YatirimDurumu });
            dataGridView1.Location = new Point(33, 279);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1347, 287);
            dataGridView1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 221);
            label2.Name = "label2";
            label2.Size = new Size(171, 25);
            label2.TabIndex = 12;
            label2.Text = "Yatırım Programları :";
            // 
            // button1
            // 
            button1.Location = new Point(239, 221);
            button1.Name = "button1";
            button1.Size = new Size(165, 34);
            button1.TabIndex = 13;
            button1.Text = "Listeden Seç";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(479, 606);
            button2.Name = "button2";
            button2.Size = new Size(121, 51);
            button2.TabIndex = 14;
            button2.Text = "Kaydet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(627, 606);
            button3.Name = "button3";
            button3.Size = new Size(121, 51);
            button3.TabIndex = 15;
            button3.Text = "İptal";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Koy
            // 
            Koy.DataPropertyName = "Koy";
            Koy.HeaderText = "Köy Adı";
            Koy.MinimumWidth = 8;
            Koy.Name = "Koy";
            Koy.ReadOnly = true;
            Koy.Width = 150;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            ID.Width = 150;
            // 
            // Ilce
            // 
            Ilce.DataPropertyName = "Ilce";
            Ilce.HeaderText = "Ilce";
            Ilce.MinimumWidth = 8;
            Ilce.Name = "Ilce";
            Ilce.ReadOnly = true;
            Ilce.Width = 150;
            // 
            // Imalat
            // 
            Imalat.DataPropertyName = "Imalat";
            Imalat.HeaderText = "İmalat Türü";
            Imalat.MinimumWidth = 8;
            Imalat.Name = "Imalat";
            Imalat.ReadOnly = true;
            Imalat.Width = 150;
            // 
            // Birim
            // 
            Birim.DataPropertyName = "Birim";
            Birim.HeaderText = "Birim";
            Birim.MinimumWidth = 8;
            Birim.Name = "Birim";
            Birim.ReadOnly = true;
            Birim.Width = 150;
            // 
            // Uygulama
            // 
            Uygulama.DataPropertyName = "Uygulama";
            Uygulama.HeaderText = "Uygulama";
            Uygulama.MinimumWidth = 8;
            Uygulama.Name = "Uygulama";
            Uygulama.ReadOnly = true;
            Uygulama.Visible = false;
            Uygulama.Width = 150;
            // 
            // YaklasikMaliyet
            // 
            YaklasikMaliyet.DataPropertyName = "YaklasikMaliyet";
            YaklasikMaliyet.HeaderText = "YaklasikMaliyet";
            YaklasikMaliyet.MinimumWidth = 8;
            YaklasikMaliyet.Name = "YaklasikMaliyet";
            YaklasikMaliyet.ReadOnly = true;
            YaklasikMaliyet.Visible = false;
            YaklasikMaliyet.Width = 150;
            // 
            // Proje
            // 
            Proje.DataPropertyName = "Proje";
            Proje.HeaderText = "Proje";
            Proje.MinimumWidth = 8;
            Proje.Name = "Proje";
            Proje.ReadOnly = true;
            Proje.Visible = false;
            Proje.Width = 150;
            // 
            // Miktar
            // 
            Miktar.DataPropertyName = "Miktar";
            Miktar.HeaderText = "Miktar";
            Miktar.MinimumWidth = 8;
            Miktar.Name = "Miktar";
            Miktar.ReadOnly = true;
            Miktar.Width = 150;
            // 
            // Yil
            // 
            Yil.DataPropertyName = "Yil";
            Yil.HeaderText = "Yil";
            Yil.MinimumWidth = 8;
            Yil.Name = "Yil";
            Yil.ReadOnly = true;
            Yil.Width = 150;
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
            // YatirimDurumu
            // 
            YatirimDurumu.DataPropertyName = "YatirimDurumu";
            YatirimDurumu.HeaderText = "Durum";
            YatirimDurumu.MinimumWidth = 8;
            YatirimDurumu.Name = "YatirimDurumu";
            YatirimDurumu.ReadOnly = true;
            YatirimDurumu.Width = 150;
            // 
            // YeniProjeEkle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1392, 669);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(txtAciklama);
            Controls.Add(label3);
            Controls.Add(txtProjeAdi);
            Controls.Add(label1);
            Name = "YeniProjeEkle";
            Text = "Yeni Proje Ekle";
            FormClosing += YeniProjeEkleSu_FormClosing;
            Load += YeniProjeEkleSu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProjeAdi;
        private Label label3;
        private TextBox txtAciklama;
        private DataGridView dataGridView1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn Koy;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Ilce;
        private DataGridViewTextBoxColumn Imalat;
        private DataGridViewTextBoxColumn Birim;
        private DataGridViewTextBoxColumn Uygulama;
        private DataGridViewTextBoxColumn YaklasikMaliyet;
        private DataGridViewTextBoxColumn Proje;
        private DataGridViewTextBoxColumn Miktar;
        private DataGridViewTextBoxColumn Yil;
        private DataGridViewTextBoxColumn Kaynak;
        private DataGridViewTextBoxColumn YatirimDurumu;
    }
}