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
            dataGridView1 = new DataGridView();
            KoyAdi = new DataGridViewTextBoxColumn();
            ImalatTuru = new DataGridViewTextBoxColumn();
            YaklasikMaliyet = new DataGridViewTextBoxColumn();
            Miktar = new DataGridViewTextBoxColumn();
            Uygulama = new DataGridViewTextBoxColumn();
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
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            dataGridView2 = new DataGridView();
            No = new DataGridViewTextBoxColumn();
            HakedisMiktari = new DataGridViewTextBoxColumn();
            textBox3 = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { KoyAdi, ImalatTuru, YaklasikMaliyet, Miktar, Uygulama });
            dataGridView1.Location = new Point(15, 443);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1501, 456);
            dataGridView1.TabIndex = 0;
            // 
            // KoyAdi
            // 
            KoyAdi.HeaderText = "Köy Adi ";
            KoyAdi.MinimumWidth = 8;
            KoyAdi.Name = "KoyAdi";
            KoyAdi.Width = 150;
            // 
            // ImalatTuru
            // 
            ImalatTuru.HeaderText = "İmalat Türü";
            ImalatTuru.MinimumWidth = 8;
            ImalatTuru.Name = "ImalatTuru";
            ImalatTuru.Width = 150;
            // 
            // YaklasikMaliyet
            // 
            YaklasikMaliyet.HeaderText = "YaklasikMaliyet";
            YaklasikMaliyet.MinimumWidth = 8;
            YaklasikMaliyet.Name = "YaklasikMaliyet";
            YaklasikMaliyet.Width = 150;
            // 
            // Miktar
            // 
            Miktar.HeaderText = "Miktar";
            Miktar.MinimumWidth = 8;
            Miktar.Name = "Miktar";
            Miktar.Width = 150;
            // 
            // Uygulama
            // 
            Uygulama.HeaderText = "Uygulama";
            Uygulama.MinimumWidth = 8;
            Uygulama.Name = "Uygulama";
            Uygulama.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 404);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 1;
            label1.Text = "Program Listesi";
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
            cmbDurum.Items.AddRange(new object[] { "Devam Ediyor", "Geçici Kabul Yapıldı", "Kesin Kabul Yapıldı", "Bitti", "Sonuçlandı" });
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
            // button1
            // 
            button1.Location = new Point(732, 935);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 13;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(936, 935);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 14;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 30);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "0,00";
            textBox2.Size = new Size(62, 31);
            textBox2.TabIndex = 17;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button3.Location = new Point(227, 30);
            button3.Name = "button3";
            button3.Size = new Size(62, 57);
            button3.TabIndex = 18;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button4.Location = new Point(295, 30);
            button4.Name = "button4";
            button4.Size = new Size(66, 57);
            button4.TabIndex = 19;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
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
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { No, HakedisMiktari });
            dataGridView2.Location = new Point(6, 107);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(493, 231);
            dataGridView2.TabIndex = 21;
            // 
            // No
            // 
            No.HeaderText = "Hakediş";
            No.MinimumWidth = 8;
            No.Name = "No";
            No.ReadOnly = true;
            No.Width = 150;
            // 
            // HakedisMiktari
            // 
            HakedisMiktari.HeaderText = "Hakediş Miktarı";
            HakedisMiktari.MinimumWidth = 8;
            HakedisMiktari.Name = "HakedisMiktari";
            HakedisMiktari.ReadOnly = true;
            HakedisMiktari.Width = 150;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 30);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(130, 31);
            textBox3.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 282);
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
            dtpIseBaslama.Value = new DateTime(1970, 1, 1, 21, 47, 0, 0);
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
            label12.Location = new Point(12, 337);
            label12.Name = "label12";
            label12.Size = new Size(143, 25);
            label12.TabIndex = 31;
            label12.Text = "Yaklaşık Maliyet :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label13.Location = new Point(194, 333);
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
            txtSozlesmeBedeli.Location = new Point(194, 282);
            txtSozlesmeBedeli.Name = "txtSozlesmeBedeli";
            txtSozlesmeBedeli.Size = new Size(300, 31);
            txtSozlesmeBedeli.TabIndex = 34;
            txtSozlesmeBedeli.Leave += txtSozlesmeBedeli_Leave;
            // 
            // YatirimUygulama
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1561, 1050);
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
            Controls.Add(button1);
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
            Controls.Add(dataGridView1);
            Name = "YatirimUygulama";
            Text = "Yatırım Proje Uygulama";
            WindowState = FormWindowState.Maximized;
            FormClosing += YatirimUygulama_FormClosing;
            Load += YatirimUygulama_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
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
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private Button button3;
        private Button button4;
        private GroupBox groupBox1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn HakedisMiktari;
        private TextBox textBox3;
        private Label label9;
        private Label label3;
        private DateTimePicker dtpIseBaslama;
        private DateTimePicker dtpBitisTarihi;
        private Label label4;
        private MaskedTextBox txtSure;
        private Label label10;
        private Label label11;
        private DataGridViewTextBoxColumn KoyAdi;
        private DataGridViewTextBoxColumn ImalatTuru;
        private DataGridViewTextBoxColumn YaklasikMaliyet;
        private DataGridViewTextBoxColumn Miktar;
        private DataGridViewTextBoxColumn Uygulama;
        private Label label12;
        private Label label13;
        private TextBox txtYuklenici;
        private MaskedTextBox txtSozlesmeBedeli;
    }
}