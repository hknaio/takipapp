namespace WinFormsApp1
{
    partial class YatirimUygulama
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
            label2 = new Label();
            label5 = new Label();
            dtpGeciciKabul = new DateTimePicker();
            label6 = new Label();
            dtpKesinKabul = new DateTimePicker();
            label7 = new Label();
            cmbDurum = new ComboBox();
            label8 = new Label();
            txtAciklama = new TextBox();
            btnKaydet = new Button();
            button2 = new Button();
            txtHakedisMiktar = new TextBox();
            btnHakedisEkle = new Button();
            groupBox1 = new GroupBox();
            dataGridView2 = new DataGridView();
            No = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            HakedisMiktari = new DataGridViewTextBoxColumn();
            Sil = new DataGridViewButtonColumn();
            txtHakedis = new TextBox();
            label9 = new Label();
            label3 = new Label();
            dtpIseBaslama = new DateTimePicker();
            dtpBitisTarihi = new DateTimePicker();
            label4 = new Label();
            txtSure = new MaskedTextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtYuklenici = new TextBox();
            txtSozlesmeBedeli = new MaskedTextBox();
            label14 = new Label();
            lblToplamHakedis = new Label();
            label15 = new Label();
            lblHakedisTahakkuk = new Label();
            dataGridView1 = new DataGridView();
            Ilce = new DataGridViewTextBoxColumn();
            ProgramId = new DataGridViewTextBoxColumn();
            Uygulama = new DataGridViewTextBoxColumn();
            UygulamaEkle = new DataGridViewButtonColumn();
            YaklasikMaliyet = new DataGridViewTextBoxColumn();
            MaliyetButton = new DataGridViewButtonColumn();
            Koy = new DataGridViewTextBoxColumn();
            Birim = new DataGridViewTextBoxColumn();
            Imalat = new DataGridViewTextBoxColumn();
            Miktar = new DataGridViewTextBoxColumn();
            Yil = new DataGridViewTextBoxColumn();
            YatirimDurumu = new DataGridViewTextBoxColumn();
            Proje = new DataGridViewTextBoxColumn();
            Kaynak = new DataGridViewTextBoxColumn();
            ProjedenCikar = new DataGridViewButtonColumn();
            btnYeniProgram = new Button();
            btnTarihleriSifirla = new Button();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            btnOnceSil = new Button();
            btnOnceFotoKaydet = new Button();
            btnOncesiGuncelle = new Button();
            groupBox3 = new GroupBox();
            btnSonraSil = new Button();
            btnSonraKaydet = new Button();
            btnSonraGuncelle = new Button();
            pictureBox2 = new PictureBox();
            label19 = new Label();
            btnDosyaEkle = new Button();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 292);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 1;
            label1.Text = "Program Listesi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(8, 5);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 2;
            label2.Text = "Proje Adı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(3, 104);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 5;
            label5.Text = "Geçici Kabul Tarihi:";
            // 
            // dtpGeciciKabul
            // 
            dtpGeciciKabul.Location = new Point(136, 104);
            dtpGeciciKabul.Margin = new Padding(2, 2, 2, 2);
            dtpGeciciKabul.Name = "dtpGeciciKabul";
            dtpGeciciKabul.Size = new Size(211, 23);
            dtpGeciciKabul.TabIndex = 6;
            dtpGeciciKabul.ValueChanged += dtpGeciciKabul_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(6, 133);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 7;
            label6.Text = "Kesin Kabul Tarihi:";
            // 
            // dtpKesinKabul
            // 
            dtpKesinKabul.Enabled = false;
            dtpKesinKabul.Location = new Point(136, 133);
            dtpKesinKabul.Margin = new Padding(2, 2, 2, 2);
            dtpKesinKabul.Name = "dtpKesinKabul";
            dtpKesinKabul.Size = new Size(211, 23);
            dtpKesinKabul.TabIndex = 8;
            dtpKesinKabul.ValueChanged += dtpKesinKabul_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(376, 107);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 9;
            label7.Text = "Durumu :";
            // 
            // cmbDurum
            // 
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Location = new Point(461, 107);
            cmbDurum.Margin = new Padding(2, 2, 2, 2);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(210, 23);
            cmbDurum.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(376, 140);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 11;
            label8.Text = "Açıklama :";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(461, 140);
            txtAciklama.Margin = new Padding(2, 2, 2, 2);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(220, 55);
            txtAciklama.TabIndex = 12;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(1312, 648);
            btnKaydet.Margin = new Padding(2, 2, 2, 2);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(90, 41);
            btnKaydet.TabIndex = 13;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1437, 648);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(94, 41);
            button2.TabIndex = 14;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtHakedisMiktar
            // 
            txtHakedisMiktar.Location = new Point(162, 18);
            txtHakedisMiktar.Margin = new Padding(2, 2, 2, 2);
            txtHakedisMiktar.Name = "txtHakedisMiktar";
            txtHakedisMiktar.PlaceholderText = "0,00";
            txtHakedisMiktar.Size = new Size(101, 23);
            txtHakedisMiktar.TabIndex = 17;
            txtHakedisMiktar.Leave += txtHakedisMiktar_Leave;
            // 
            // btnHakedisEkle
            // 
            btnHakedisEkle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnHakedisEkle.Location = new Point(275, 18);
            btnHakedisEkle.Margin = new Padding(2, 2, 2, 2);
            btnHakedisEkle.Name = "btnHakedisEkle";
            btnHakedisEkle.Size = new Size(43, 34);
            btnHakedisEkle.TabIndex = 18;
            btnHakedisEkle.Text = "+";
            btnHakedisEkle.UseVisualStyleBackColor = true;
            btnHakedisEkle.Click += btnHakedisEkle_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Controls.Add(txtHakedis);
            groupBox1.Controls.Add(txtHakedisMiktar);
            groupBox1.Controls.Add(btnHakedisEkle);
            groupBox1.Location = new Point(691, 10);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(391, 206);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hakediş Listesi";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { No, ID, HakedisMiktari, Sil });
            dataGridView2.Location = new Point(4, 64);
            dataGridView2.Margin = new Padding(2, 2, 2, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(345, 139);
            dataGridView2.TabIndex = 21;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // No
            // 
            No.DataPropertyName = "Adi";
            No.HeaderText = "Hakediş";
            No.MinimumWidth = 8;
            No.Name = "No";
            No.ReadOnly = true;
            No.Width = 150;
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
            // HakedisMiktari
            // 
            HakedisMiktari.DataPropertyName = "Miktar";
            HakedisMiktari.HeaderText = "Hakediş Miktarı";
            HakedisMiktari.MinimumWidth = 8;
            HakedisMiktari.Name = "HakedisMiktari";
            HakedisMiktari.ReadOnly = true;
            HakedisMiktari.Width = 150;
            // 
            // Sil
            // 
            Sil.HeaderText = "Sil";
            Sil.MinimumWidth = 8;
            Sil.Name = "Sil";
            Sil.ReadOnly = true;
            Sil.Text = "Sil";
            Sil.UseColumnTextForButtonValue = true;
            Sil.Width = 150;
            // 
            // txtHakedis
            // 
            txtHakedis.Location = new Point(4, 18);
            txtHakedis.Margin = new Padding(2, 2, 2, 2);
            txtHakedis.Name = "txtHakedis";
            txtHakedis.Size = new Size(142, 23);
            txtHakedis.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 201);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(97, 15);
            label9.TabIndex = 21;
            label9.Text = "Sözleşme Bedeli :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 35);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 23;
            label3.Text = "İşe Başlama Tarihi :";
            // 
            // dtpIseBaslama
            // 
            dtpIseBaslama.Location = new Point(136, 35);
            dtpIseBaslama.Margin = new Padding(2, 2, 2, 2);
            dtpIseBaslama.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dtpIseBaslama.Name = "dtpIseBaslama";
            dtpIseBaslama.Size = new Size(211, 23);
            dtpIseBaslama.TabIndex = 24;
            dtpIseBaslama.Value = new DateTime(2024, 9, 11, 0, 0, 0, 0);
            dtpIseBaslama.ValueChanged += dtpIseBaslama_ValueChanged;
            // 
            // dtpBitisTarihi
            // 
            dtpBitisTarihi.Enabled = false;
            dtpBitisTarihi.Location = new Point(136, 69);
            dtpBitisTarihi.Margin = new Padding(2, 2, 2, 2);
            dtpBitisTarihi.Name = "dtpBitisTarihi";
            dtpBitisTarihi.Size = new Size(211, 23);
            dtpBitisTarihi.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 69);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 26;
            label4.Text = "İş Bitiş Tarihi :";
            // 
            // txtSure
            // 
            txtSure.Location = new Point(461, 35);
            txtSure.Margin = new Padding(2, 2, 2, 2);
            txtSure.Name = "txtSure";
            txtSure.Size = new Size(106, 23);
            txtSure.TabIndex = 27;
            txtSure.TextChanged += txtSure_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(376, 35);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(69, 15);
            label10.TabIndex = 28;
            label10.Text = "Süre (Gün) :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(376, 72);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 29;
            label11.Text = "Yüklenici :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 230);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(96, 15);
            label12.TabIndex = 31;
            label12.Text = "Yaklaşık Maliyet :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label13.Location = new Point(136, 227);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(40, 20);
            label13.TabIndex = 32;
            label13.Text = "00,0";
            // 
            // txtYuklenici
            // 
            txtYuklenici.Location = new Point(461, 70);
            txtYuklenici.Margin = new Padding(2, 2, 2, 2);
            txtYuklenici.Name = "txtYuklenici";
            txtYuklenici.Size = new Size(210, 23);
            txtYuklenici.TabIndex = 33;
            // 
            // txtSozlesmeBedeli
            // 
            txtSozlesmeBedeli.Location = new Point(136, 197);
            txtSozlesmeBedeli.Margin = new Padding(2, 2, 2, 2);
            txtSozlesmeBedeli.Name = "txtSozlesmeBedeli";
            txtSozlesmeBedeli.Size = new Size(211, 23);
            txtSozlesmeBedeli.TabIndex = 34;
            txtSozlesmeBedeli.Leave += txtSozlesmeBedeli_Leave;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(8, 258);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(100, 15);
            label14.TabIndex = 35;
            label14.Text = "Hakediş Toplamı :";
            // 
            // lblToplamHakedis
            // 
            lblToplamHakedis.AutoSize = true;
            lblToplamHakedis.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblToplamHakedis.Location = new Point(136, 255);
            lblToplamHakedis.Margin = new Padding(2, 0, 2, 0);
            lblToplamHakedis.Name = "lblToplamHakedis";
            lblToplamHakedis.Size = new Size(40, 20);
            lblToplamHakedis.TabIndex = 36;
            lblToplamHakedis.Text = "00,0";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(279, 260);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(107, 15);
            label15.TabIndex = 37;
            label15.Text = "Hakediş Tahakkuk :";
            // 
            // lblHakedisTahakkuk
            // 
            lblHakedisTahakkuk.AutoSize = true;
            lblHakedisTahakkuk.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblHakedisTahakkuk.Location = new Point(396, 258);
            lblHakedisTahakkuk.Margin = new Padding(2, 0, 2, 0);
            lblHakedisTahakkuk.Name = "lblHakedisTahakkuk";
            lblHakedisTahakkuk.Size = new Size(40, 20);
            lblHakedisTahakkuk.TabIndex = 38;
            lblHakedisTahakkuk.Text = "00,0";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Ilce, ProgramId, Uygulama, UygulamaEkle, YaklasikMaliyet, MaliyetButton, Koy, Birim, Imalat, Miktar, Yil, YatirimDurumu, Proje, Kaynak, ProjedenCikar });
            dataGridView1.Location = new Point(27, 356);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(1252, 242);
            dataGridView1.TabIndex = 39;
            dataGridView1.CellClick += dataGridView1_CellClick;
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
            // ProgramId
            // 
            ProgramId.DataPropertyName = "ID";
            ProgramId.HeaderText = "ID";
            ProgramId.MinimumWidth = 8;
            ProgramId.Name = "ProgramId";
            ProgramId.ReadOnly = true;
            ProgramId.Visible = false;
            ProgramId.Width = 150;
            // 
            // Uygulama
            // 
            Uygulama.DataPropertyName = "Uygulama";
            Uygulama.HeaderText = "Uygulama";
            Uygulama.MinimumWidth = 8;
            Uygulama.Name = "Uygulama";
            Uygulama.ReadOnly = true;
            Uygulama.Width = 150;
            // 
            // UygulamaEkle
            // 
            UygulamaEkle.HeaderText = "Uygulama Ekle";
            UygulamaEkle.MinimumWidth = 8;
            UygulamaEkle.Name = "UygulamaEkle";
            UygulamaEkle.Text = "Uygulama Ekle";
            UygulamaEkle.UseColumnTextForButtonValue = true;
            UygulamaEkle.Width = 150;
            // 
            // YaklasikMaliyet
            // 
            YaklasikMaliyet.DataPropertyName = "YaklasikMaliyet";
            YaklasikMaliyet.HeaderText = "YaklasikMaliyet";
            YaklasikMaliyet.MinimumWidth = 8;
            YaklasikMaliyet.Name = "YaklasikMaliyet";
            YaklasikMaliyet.ReadOnly = true;
            YaklasikMaliyet.Width = 150;
            // 
            // MaliyetButton
            // 
            MaliyetButton.HeaderText = "Maliyet Ekle";
            MaliyetButton.MinimumWidth = 8;
            MaliyetButton.Name = "MaliyetButton";
            MaliyetButton.Text = "Maliyet Ekle";
            MaliyetButton.UseColumnTextForButtonValue = true;
            MaliyetButton.Width = 150;
            // 
            // Koy
            // 
            Koy.DataPropertyName = "Koy";
            Koy.HeaderText = "Koy";
            Koy.MinimumWidth = 8;
            Koy.Name = "Koy";
            Koy.ReadOnly = true;
            Koy.Width = 150;
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
            // Imalat
            // 
            Imalat.DataPropertyName = "Imalat";
            Imalat.HeaderText = "Imalat";
            Imalat.MinimumWidth = 8;
            Imalat.Name = "Imalat";
            Imalat.ReadOnly = true;
            Imalat.Width = 150;
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
            // YatirimDurumu
            // 
            YatirimDurumu.DataPropertyName = "YatirimDurumu";
            YatirimDurumu.HeaderText = "Durum";
            YatirimDurumu.MinimumWidth = 8;
            YatirimDurumu.Name = "YatirimDurumu";
            YatirimDurumu.ReadOnly = true;
            YatirimDurumu.Width = 150;
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
            // Kaynak
            // 
            Kaynak.DataPropertyName = "Kaynak";
            Kaynak.HeaderText = "Kaynak";
            Kaynak.MinimumWidth = 8;
            Kaynak.Name = "Kaynak";
            Kaynak.ReadOnly = true;
            Kaynak.Width = 150;
            // 
            // ProjedenCikar
            // 
            ProjedenCikar.HeaderText = "Projeden Çıkar";
            ProjedenCikar.MinimumWidth = 8;
            ProjedenCikar.Name = "ProjedenCikar";
            ProjedenCikar.Text = "Projeden Çıkar";
            ProjedenCikar.UseColumnTextForButtonValue = true;
            ProjedenCikar.Width = 150;
            // 
            // btnYeniProgram
            // 
            btnYeniProgram.Location = new Point(122, 283);
            btnYeniProgram.Margin = new Padding(2, 2, 2, 2);
            btnYeniProgram.Name = "btnYeniProgram";
            btnYeniProgram.Size = new Size(113, 27);
            btnYeniProgram.TabIndex = 40;
            btnYeniProgram.Text = "Program Ekle";
            btnYeniProgram.UseVisualStyleBackColor = true;
            btnYeniProgram.Click += btnYeniProgram_Click;
            // 
            // btnTarihleriSifirla
            // 
            btnTarihleriSifirla.Location = new Point(136, 161);
            btnTarihleriSifirla.Margin = new Padding(2, 2, 2, 2);
            btnTarihleriSifirla.Name = "btnTarihleriSifirla";
            btnTarihleriSifirla.Size = new Size(99, 26);
            btnTarihleriSifirla.TabIndex = 41;
            btnTarihleriSifirla.Text = "Tarihleri Sıfırla";
            btnTarihleriSifirla.UseVisualStyleBackColor = true;
            btnTarihleriSifirla.Click += btnTarihleriSifirla_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label16.Location = new Point(246, 227);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(18, 20);
            label16.TabIndex = 42;
            label16.Text = "₺";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label17.Location = new Point(246, 255);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(18, 20);
            label17.TabIndex = 43;
            label17.Text = "₺";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label18.Location = new Point(499, 258);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(18, 20);
            label18.TabIndex = 44;
            label18.Text = "₺";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(5, 20);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(496, 192);
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnOnceSil);
            groupBox2.Controls.Add(btnOnceFotoKaydet);
            groupBox2.Controls.Add(btnOncesiGuncelle);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(1303, 13);
            groupBox2.Margin = new Padding(2, 2, 2, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 2, 2, 2);
            groupBox2.Size = new Size(505, 260);
            groupBox2.TabIndex = 46;
            groupBox2.TabStop = false;
            groupBox2.Text = "Öncesi";
            // 
            // btnOnceSil
            // 
            btnOnceSil.Location = new Point(264, 217);
            btnOnceSil.Margin = new Padding(2, 2, 2, 2);
            btnOnceSil.Name = "btnOnceSil";
            btnOnceSil.Size = new Size(94, 28);
            btnOnceSil.TabIndex = 48;
            btnOnceSil.Text = "Foto Sil";
            btnOnceSil.UseVisualStyleBackColor = true;
            btnOnceSil.Click += btnOnceSil_Click;
            // 
            // btnOnceFotoKaydet
            // 
            btnOnceFotoKaydet.Location = new Point(134, 217);
            btnOnceFotoKaydet.Margin = new Padding(2, 2, 2, 2);
            btnOnceFotoKaydet.Name = "btnOnceFotoKaydet";
            btnOnceFotoKaydet.Size = new Size(94, 28);
            btnOnceFotoKaydet.TabIndex = 47;
            btnOnceFotoKaydet.Text = "Foto Kaydet";
            btnOnceFotoKaydet.UseVisualStyleBackColor = true;
            btnOnceFotoKaydet.Click += btnOnceFotoKaydet_Click;
            // 
            // btnOncesiGuncelle
            // 
            btnOncesiGuncelle.Location = new Point(9, 217);
            btnOncesiGuncelle.Margin = new Padding(2, 2, 2, 2);
            btnOncesiGuncelle.Name = "btnOncesiGuncelle";
            btnOncesiGuncelle.Size = new Size(90, 27);
            btnOncesiGuncelle.TabIndex = 46;
            btnOncesiGuncelle.Text = "Foto Güncelle";
            btnOncesiGuncelle.UseVisualStyleBackColor = true;
            btnOncesiGuncelle.Click += btnOncesiGuncelle_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnSonraSil);
            groupBox3.Controls.Add(btnSonraKaydet);
            groupBox3.Controls.Add(btnSonraGuncelle);
            groupBox3.Controls.Add(pictureBox2);
            groupBox3.Location = new Point(1303, 283);
            groupBox3.Margin = new Padding(2, 2, 2, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2, 2, 2, 2);
            groupBox3.Size = new Size(501, 336);
            groupBox3.TabIndex = 47;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sonrası";
            // 
            // btnSonraSil
            // 
            btnSonraSil.Location = new Point(264, 301);
            btnSonraSil.Margin = new Padding(2, 2, 2, 2);
            btnSonraSil.Name = "btnSonraSil";
            btnSonraSil.Size = new Size(94, 28);
            btnSonraSil.TabIndex = 48;
            btnSonraSil.Text = "Foto Sil";
            btnSonraSil.UseVisualStyleBackColor = true;
            btnSonraSil.Click += btnSonraSil_Click;
            // 
            // btnSonraKaydet
            // 
            btnSonraKaydet.Location = new Point(134, 297);
            btnSonraKaydet.Margin = new Padding(2, 2, 2, 2);
            btnSonraKaydet.Name = "btnSonraKaydet";
            btnSonraKaydet.Size = new Size(94, 35);
            btnSonraKaydet.TabIndex = 47;
            btnSonraKaydet.Text = "Foto Kaydet";
            btnSonraKaydet.UseVisualStyleBackColor = true;
            btnSonraKaydet.Click += btnSonraKaydet_Click;
            // 
            // btnSonraGuncelle
            // 
            btnSonraGuncelle.Location = new Point(9, 297);
            btnSonraGuncelle.Margin = new Padding(2, 2, 2, 2);
            btnSonraGuncelle.Name = "btnSonraGuncelle";
            btnSonraGuncelle.Size = new Size(90, 35);
            btnSonraGuncelle.TabIndex = 46;
            btnSonraGuncelle.Text = "Foto Güncelle";
            btnSonraGuncelle.UseVisualStyleBackColor = true;
            btnSonraGuncelle.Click += btnSonraGuncelle_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(9, 18);
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(488, 273);
            pictureBox2.TabIndex = 45;
            pictureBox2.TabStop = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F);
            label19.Location = new Point(384, 218);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(75, 15);
            label19.TabIndex = 48;
            label19.Text = "Proje Dosya :";
            // 
            // btnDosyaEkle
            // 
            btnDosyaEkle.Location = new Point(469, 215);
            btnDosyaEkle.Margin = new Padding(2, 2, 2, 2);
            btnDosyaEkle.Name = "btnDosyaEkle";
            btnDosyaEkle.Size = new Size(78, 34);
            btnDosyaEkle.TabIndex = 49;
            btnDosyaEkle.Text = "Dosya Ekle";
            btnDosyaEkle.UseVisualStyleBackColor = true;
            btnDosyaEkle.Click += btnDosyaEkle_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(565, 250);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(75, 15);
            linkLabel1.TabIndex = 50;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Dosyayı Indir";
            linkLabel1.Visible = false;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.Location = new Point(568, 215);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(102, 34);
            button1.TabIndex = 51;
            button1.Text = "Dosyalar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // YatirimUygulama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1562, 808);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(btnDosyaEkle);
            Controls.Add(label19);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(btnTarihleriSifirla);
            Controls.Add(btnYeniProgram);
            Controls.Add(dataGridView1);
            Controls.Add(lblHakedisTahakkuk);
            Controls.Add(label15);
            Controls.Add(lblToplamHakedis);
            Controls.Add(label14);
            Controls.Add(txtSozlesmeBedeli);
            Controls.Add(txtYuklenici);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtSure);
            Controls.Add(label4);
            Controls.Add(dtpBitisTarihi);
            Controls.Add(dtpIseBaslama);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(btnKaydet);
            Controls.Add(txtAciklama);
            Controls.Add(label8);
            Controls.Add(cmbDurum);
            Controls.Add(label7);
            Controls.Add(dtpKesinKabul);
            Controls.Add(label6);
            Controls.Add(dtpGeciciKabul);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "YatirimUygulama";
            Text = "Yatırım Proje Uygulama";
            WindowState = FormWindowState.Maximized;
            FormClosing += YatirimUygulama_FormClosing;
            Load += YatirimUygulama_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label5;
        private DateTimePicker dtpGeciciKabul;
        private Label label6;
        private DateTimePicker dtpKesinKabul;
        private Label label7;
        private ComboBox cmbDurum;
        private Label label8;
        private TextBox txtAciklama;
        private Button btnKaydet;
        private Button button2;
        private TextBox txtHakedisMiktar;
        private Button btnHakedisEkle;
        private GroupBox groupBox1;
        private DataGridView dataGridView2;
        private TextBox txtHakedis;
        private Label label9;
        private Label label3;
        private DateTimePicker dtpIseBaslama;
        private DateTimePicker dtpBitisTarihi;
        private Label label4;
        private MaskedTextBox txtSure;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtYuklenici;
        private MaskedTextBox txtSozlesmeBedeli;
        private Label label14;
        private Label lblToplamHakedis;
        private Label label15;
        private Label lblHakedisTahakkuk;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HakedisMiktari;
        private DataGridViewButtonColumn Sil;
        private DataGridView dataGridView1;
        private Button btnYeniProgram;
        private DataGridViewTextBoxColumn Ilce;
        private DataGridViewTextBoxColumn ProgramId;
        private DataGridViewTextBoxColumn Uygulama;
        private DataGridViewButtonColumn UygulamaEkle;
        private DataGridViewTextBoxColumn YaklasikMaliyet;
        private DataGridViewButtonColumn MaliyetButton;
        private DataGridViewTextBoxColumn Koy;
        private DataGridViewTextBoxColumn Birim;
        private DataGridViewTextBoxColumn Imalat;
        private DataGridViewTextBoxColumn Miktar;
        private DataGridViewTextBoxColumn Yil;
        private DataGridViewTextBoxColumn YatirimDurumu;
        private DataGridViewTextBoxColumn Proje;
        private DataGridViewTextBoxColumn Kaynak;
        private DataGridViewButtonColumn ProjedenCikar;
        private Button btnTarihleriSifirla;
        private Label label16;
        private Label label17;
        private Label label18;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private Button btnOncesiGuncelle;
        private Button btnOnceFotoKaydet;
        private GroupBox groupBox3;
        private Button btnSonraKaydet;
        private Button btnSonraGuncelle;
        private PictureBox pictureBox2;
        private Label label19;
        private Button btnDosyaEkle;
        private LinkLabel linkLabel1;
        private Button button1;
        private Button btnOnceSil;
        private Button btnSonraSil;
    }
}