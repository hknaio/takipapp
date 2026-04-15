namespace WinFormsApp1
{
    partial class ImalatTanimlama
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
            Isim = new DataGridViewTextBoxColumn();
            Cins = new DataGridViewTextBoxColumn();
            Mudurluk = new DataGridViewTextBoxColumn();
            Birim = new DataGridViewTextBoxColumn();
            BirimFiyat = new DataGridViewTextBoxColumn();
            FiyatGecerlilikTarihi = new DataGridViewTextBoxColumn();
            btnSil = new DataGridViewButtonColumn();
            ID = new DataGridViewTextBoxColumn();
            FiyatGuncelle = new DataGridViewButtonColumn();
            TarihListesi = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            txtAdi = new TextBox();
            txtBirim = new TextBox();
            txtCins = new TextBox();
            txtBirimFiyat = new MaskedTextBox();
            dtpBaslangic = new DateTimePicker();
            label5 = new Label();
            cmbMudurluk = new ComboBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Isim, Cins, Mudurluk, Birim, BirimFiyat, FiyatGecerlilikTarihi, btnSil, ID, FiyatGuncelle, TarihListesi });
            dataGridView1.Location = new Point(8, 112);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1433, 633);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Isim
            // 
            Isim.DataPropertyName = "Isim";
            Isim.HeaderText = "İsim";
            Isim.MinimumWidth = 8;
            Isim.Name = "Isim";
            Isim.ReadOnly = true;
            Isim.Width = 150;
            // 
            // Cins
            // 
            Cins.DataPropertyName = "Cins";
            Cins.HeaderText = "Cins";
            Cins.MinimumWidth = 8;
            Cins.Name = "Cins";
            Cins.ReadOnly = true;
            Cins.Width = 150;
            // 
            // Mudurluk
            // 
            Mudurluk.DataPropertyName = "Mudurluk";
            Mudurluk.HeaderText = "Müdürlük";
            Mudurluk.MinimumWidth = 8;
            Mudurluk.Name = "Mudurluk";
            Mudurluk.ReadOnly = true;
            Mudurluk.Width = 150;
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
            // BirimFiyat
            // 
            BirimFiyat.DataPropertyName = "BirimFiyat";
            BirimFiyat.HeaderText = "Birim Fiyat";
            BirimFiyat.MinimumWidth = 8;
            BirimFiyat.Name = "BirimFiyat";
            BirimFiyat.ReadOnly = true;
            BirimFiyat.Width = 150;
            // 
            // FiyatGecerlilikTarihi
            // 
            FiyatGecerlilikTarihi.DataPropertyName = "FiyatGecerlilikBaslangicTarihi";
            FiyatGecerlilikTarihi.HeaderText = "Fiyat Geçerlilik Başlangıç Tarihi";
            FiyatGecerlilikTarihi.MinimumWidth = 8;
            FiyatGecerlilikTarihi.Name = "FiyatGecerlilikTarihi";
            FiyatGecerlilikTarihi.ReadOnly = true;
            FiyatGecerlilikTarihi.Width = 150;
            // 
            // btnSil
            // 
            btnSil.HeaderText = "Sil";
            btnSil.MinimumWidth = 8;
            btnSil.Name = "btnSil";
            btnSil.ReadOnly = true;
            btnSil.Text = "Listeden Sil";
            btnSil.UseColumnTextForButtonValue = true;
            btnSil.Width = 150;
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
            // FiyatGuncelle
            // 
            FiyatGuncelle.HeaderText = "Birim Fiyat Güncelle";
            FiyatGuncelle.MinimumWidth = 8;
            FiyatGuncelle.Name = "FiyatGuncelle";
            FiyatGuncelle.ReadOnly = true;
            FiyatGuncelle.Text = "Fiyat Güncelle";
            FiyatGuncelle.UseColumnTextForButtonValue = true;
            FiyatGuncelle.Width = 150;
            // 
            // TarihListesi
            // 
            TarihListesi.DataPropertyName = "TarihListesi";
            TarihListesi.HeaderText = "TarihListesi";
            TarihListesi.MinimumWidth = 8;
            TarihListesi.Name = "TarihListesi";
            TarihListesi.ReadOnly = true;
            TarihListesi.Visible = false;
            TarihListesi.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 33);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "Birim Fiyatı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(226, 5);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Cinsi :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 34);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 4;
            label4.Text = "Birim :";
            // 
            // button1
            // 
            button1.Location = new Point(503, 70);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(89, 32);
            button1.TabIndex = 5;
            button1.Text = "Listeye Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(53, 7);
            txtAdi.Margin = new Padding(2, 2, 2, 2);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(157, 23);
            txtAdi.TabIndex = 6;
            // 
            // txtBirim
            // 
            txtBirim.Location = new Point(53, 34);
            txtBirim.Margin = new Padding(2, 2, 2, 2);
            txtBirim.Name = "txtBirim";
            txtBirim.Size = new Size(157, 23);
            txtBirim.TabIndex = 8;
            // 
            // txtCins
            // 
            txtCins.Location = new Point(305, 7);
            txtCins.Margin = new Padding(2, 2, 2, 2);
            txtCins.Name = "txtCins";
            txtCins.Size = new Size(157, 23);
            txtCins.TabIndex = 9;
            // 
            // txtBirimFiyat
            // 
            txtBirimFiyat.Location = new Point(305, 35);
            txtBirimFiyat.Margin = new Padding(2, 2, 2, 2);
            txtBirimFiyat.Name = "txtBirimFiyat";
            txtBirimFiyat.Size = new Size(157, 23);
            txtBirimFiyat.TabIndex = 10;
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Location = new Point(267, 70);
            dtpBaslangic.Margin = new Padding(2, 2, 2, 2);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(196, 23);
            dtpBaslangic.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 70);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(173, 15);
            label5.TabIndex = 12;
            label5.Text = "Fiyat Geçerlilik Başlangıç Tarihi :";
            // 
            // cmbMudurluk
            // 
            cmbMudurluk.FormattingEnabled = true;
            cmbMudurluk.Items.AddRange(new object[] { "Yol ve Ulaşım Hizmetleri", "Tarımsal Hizmetler", "Su ve Kanalizasyon Hizmetleri", "Destek Hizmetler", "Kültür ve Sosyal İşler" });
            cmbMudurluk.Location = new Point(570, 7);
            cmbMudurluk.Margin = new Padding(2, 2, 2, 2);
            cmbMudurluk.Name = "cmbMudurluk";
            cmbMudurluk.Size = new Size(215, 23);
            cmbMudurluk.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(498, 8);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 13;
            label6.Text = "Mudurluk :";
            // 
            // ImalatTanimlama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1452, 756);
            Controls.Add(cmbMudurluk);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtpBaslangic);
            Controls.Add(txtBirimFiyat);
            Controls.Add(txtCins);
            Controls.Add(txtBirim);
            Controls.Add(txtAdi);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ImalatTanimlama";
            Text = "İmalat Tanımlama";
            FormClosing += ImalatTanimlama_FormClosing;
            Load += ImalatTanimlama_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ImalatAdi;
        private DataGridViewTextBoxColumn ImalatCinsi;
        private DataGridViewButtonColumn Sil;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox txtAdi;
        private TextBox txtBirim;
        private TextBox txtCins;
        private MaskedTextBox txtBirimFiyat;
        private DateTimePicker dtpBaslangic;
        private Label label5;
        private ComboBox cmbMudurluk;
        private Label label6;
        private DataGridViewTextBoxColumn Isim;
        private DataGridViewTextBoxColumn Cins;
        private DataGridViewTextBoxColumn Mudurluk;
        private DataGridViewTextBoxColumn Birim;
        private DataGridViewTextBoxColumn BirimFiyat;
        private DataGridViewTextBoxColumn FiyatGecerlilikTarihi;
        private DataGridViewButtonColumn btnSil;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewButtonColumn FiyatGuncelle;
        private DataGridViewTextBoxColumn TarihListesi;
    }
}