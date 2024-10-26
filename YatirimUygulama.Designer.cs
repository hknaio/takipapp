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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 487);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 1;
            label1.Text = "Program Listesi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(120, 32);
            label2.TabIndex = 2;
            label2.Text = "Proje Adı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(4, 173);
            label5.Name = "label5";
            label5.Size = new Size(155, 25);
            label5.TabIndex = 5;
            label5.Text = "Geçici Kabul Tarihi:";
            // 
            // dtpGeciciKabul
            // 
            dtpGeciciKabul.Location = new Point(194, 173);
            dtpGeciciKabul.Name = "dtpGeciciKabul";
            dtpGeciciKabul.Size = new Size(300, 31);
            dtpGeciciKabul.TabIndex = 6;
            dtpGeciciKabul.ValueChanged += dtpGeciciKabul_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(8, 221);
            label6.Name = "label6";
            label6.Size = new Size(151, 25);
            label6.TabIndex = 7;
            label6.Text = "Kesin Kabul Tarihi:";
            // 
            // dtpKesinKabul
            // 
            dtpKesinKabul.Enabled = false;
            dtpKesinKabul.Location = new Point(194, 221);
            dtpKesinKabul.Name = "dtpKesinKabul";
            dtpKesinKabul.Size = new Size(300, 31);
            dtpKesinKabul.TabIndex = 8;
            dtpKesinKabul.ValueChanged += dtpKesinKabul_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(537, 178);
            label7.Name = "label7";
            label7.Size = new Size(86, 25);
            label7.TabIndex = 9;
            label7.Text = "Durumu :";
            // 
            // cmbDurum
            // 
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Location = new Point(658, 178);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(299, 33);
            cmbDurum.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(537, 233);
            label8.Name = "label8";
            label8.Size = new Size(92, 25);
            label8.TabIndex = 11;
            label8.Text = "Açıklama :";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(658, 233);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(312, 89);
            txtAciklama.TabIndex = 12;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(743, 935);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(112, 34);
            btnKaydet.TabIndex = 13;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // button2
            // 
            button2.Location = new Point(958, 935);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 14;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtHakedisMiktar
            // 
            txtHakedisMiktar.Location = new Point(231, 30);
            txtHakedisMiktar.Name = "txtHakedisMiktar";
            txtHakedisMiktar.PlaceholderText = "0,00";
            txtHakedisMiktar.Size = new Size(142, 31);
            txtHakedisMiktar.TabIndex = 17;
            txtHakedisMiktar.Leave += txtHakedisMiktar_Leave;
            // 
            // btnHakedisEkle
            // 
            btnHakedisEkle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnHakedisEkle.Location = new Point(393, 30);
            btnHakedisEkle.Name = "btnHakedisEkle";
            btnHakedisEkle.Size = new Size(62, 57);
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
            groupBox1.Location = new Point(990, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(559, 344);
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
            dataGridView2.Location = new Point(6, 107);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(493, 231);
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
            txtHakedis.Location = new Point(6, 30);
            txtHakedis.Name = "txtHakedis";
            txtHakedis.Size = new Size(201, 31);
            txtHakedis.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 335);
            label9.Name = "label9";
            label9.Size = new Size(148, 25);
            label9.TabIndex = 21;
            label9.Text = "Sözleşme Bedeli :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 59);
            label3.Name = "label3";
            label3.Size = new Size(158, 25);
            label3.TabIndex = 23;
            label3.Text = "İşe Başlama Tarihi :";
            // 
            // dtpIseBaslama
            // 
            dtpIseBaslama.Location = new Point(194, 59);
            dtpIseBaslama.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dtpIseBaslama.Name = "dtpIseBaslama";
            dtpIseBaslama.Size = new Size(300, 31);
            dtpIseBaslama.TabIndex = 24;
            dtpIseBaslama.Value = new DateTime(2024, 9, 11, 0, 0, 0, 0);
            dtpIseBaslama.ValueChanged += dtpIseBaslama_ValueChanged;
            // 
            // dtpBitisTarihi
            // 
            dtpBitisTarihi.Enabled = false;
            dtpBitisTarihi.Location = new Point(194, 115);
            dtpBitisTarihi.Name = "dtpBitisTarihi";
            dtpBitisTarihi.Size = new Size(300, 31);
            dtpBitisTarihi.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 115);
            label4.Name = "label4";
            label4.Size = new Size(116, 25);
            label4.TabIndex = 26;
            label4.Text = "İş Bitiş Tarihi :";
            // 
            // txtSure
            // 
            txtSure.Location = new Point(658, 59);
            txtSure.Name = "txtSure";
            txtSure.Size = new Size(150, 31);
            txtSure.TabIndex = 27;
            txtSure.TextChanged += txtSure_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(537, 59);
            label10.Name = "label10";
            label10.Size = new Size(103, 25);
            label10.TabIndex = 28;
            label10.Text = "Süre (Gün) :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(537, 120);
            label11.Name = "label11";
            label11.Size = new Size(89, 25);
            label11.TabIndex = 29;
            label11.Text = "Yüklenici :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 383);
            label12.Name = "label12";
            label12.Size = new Size(143, 25);
            label12.TabIndex = 31;
            label12.Text = "Yaklaşık Maliyet :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label13.Location = new Point(194, 378);
            label13.Name = "label13";
            label13.Size = new Size(58, 30);
            label13.TabIndex = 32;
            label13.Text = "00,0";
            // 
            // txtYuklenici
            // 
            txtYuklenici.Location = new Point(658, 117);
            txtYuklenici.Name = "txtYuklenici";
            txtYuklenici.Size = new Size(299, 31);
            txtYuklenici.TabIndex = 33;
            // 
            // txtSozlesmeBedeli
            // 
            txtSozlesmeBedeli.Location = new Point(194, 329);
            txtSozlesmeBedeli.Name = "txtSozlesmeBedeli";
            txtSozlesmeBedeli.Size = new Size(300, 31);
            txtSozlesmeBedeli.TabIndex = 34;
            txtSozlesmeBedeli.Leave += txtSozlesmeBedeli_Leave;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 430);
            label14.Name = "label14";
            label14.Size = new Size(151, 25);
            label14.TabIndex = 35;
            label14.Text = "Hakediş Toplamı :";
            // 
            // lblToplamHakedis
            // 
            lblToplamHakedis.AutoSize = true;
            lblToplamHakedis.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblToplamHakedis.Location = new Point(194, 425);
            lblToplamHakedis.Name = "lblToplamHakedis";
            lblToplamHakedis.Size = new Size(58, 30);
            lblToplamHakedis.TabIndex = 36;
            lblToplamHakedis.Text = "00,0";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(398, 434);
            label15.Name = "label15";
            label15.Size = new Size(161, 25);
            label15.TabIndex = 37;
            label15.Text = "Hakediş Tahakkuk :";
            // 
            // lblHakedisTahakkuk
            // 
            lblHakedisTahakkuk.AutoSize = true;
            lblHakedisTahakkuk.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblHakedisTahakkuk.Location = new Point(565, 430);
            lblHakedisTahakkuk.Name = "lblHakedisTahakkuk";
            lblHakedisTahakkuk.Size = new Size(58, 30);
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
            dataGridView1.Location = new Point(26, 525);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(1852, 404);
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
            btnYeniProgram.Location = new Point(175, 471);
            btnYeniProgram.Name = "btnYeniProgram";
            btnYeniProgram.Size = new Size(161, 45);
            btnYeniProgram.TabIndex = 40;
            btnYeniProgram.Text = "Program Ekle";
            btnYeniProgram.UseVisualStyleBackColor = true;
            btnYeniProgram.Click += btnYeniProgram_Click;
            // 
            // btnTarihleriSifirla
            // 
            btnTarihleriSifirla.Location = new Point(194, 268);
            btnTarihleriSifirla.Name = "btnTarihleriSifirla";
            btnTarihleriSifirla.Size = new Size(142, 44);
            btnTarihleriSifirla.TabIndex = 41;
            btnTarihleriSifirla.Text = "Tarihleri Sıfırla";
            btnTarihleriSifirla.UseVisualStyleBackColor = true;
            btnTarihleriSifirla.Click += btnTarihleriSifirla_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label16.Location = new Point(352, 378);
            label16.Name = "label16";
            label16.Size = new Size(26, 30);
            label16.TabIndex = 42;
            label16.Text = "₺";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label17.Location = new Point(352, 425);
            label17.Name = "label17";
            label17.Size = new Size(26, 30);
            label17.TabIndex = 43;
            label17.Text = "₺";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label18.Location = new Point(713, 430);
            label18.Name = "label18";
            label18.Size = new Size(26, 30);
            label18.TabIndex = 44;
            label18.Text = "₺";
            // 
            // YatirimUygulama
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1890, 1050);
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
            Name = "YatirimUygulama";
            Text = "Yatırım Proje Uygulama";
            WindowState = FormWindowState.Maximized;
            FormClosing += YatirimUygulama_FormClosing;
            Load += YatirimUygulama_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}