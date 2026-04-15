namespace YatirimTakip
{
    partial class PersonelTanimlama
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
            txtAdi = new TextBox();
            label1 = new Label();
            txtSoyadi = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmbBirim = new ComboBox();
            cmbRol = new ComboBox();
            label4 = new Label();
            chkIlce = new CheckedListBox();
            label5 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Isim = new DataGridViewTextBoxColumn();
            Soyisim = new DataGridViewTextBoxColumn();
            Birim = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            KullaniciAdi = new DataGridViewTextBoxColumn();
            Ilceler = new DataGridViewTextBoxColumn();
            btnSil = new DataGridViewButtonColumn();
            Guncelle = new DataGridViewButtonColumn();
            ID = new DataGridViewTextBoxColumn();
            lblPageInfo = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(77, 24);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(223, 31);
            txtAdi.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 29);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 7;
            label1.Text = "Adı :";
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(444, 26);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(223, 31);
            txtSoyadi.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 30);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 9;
            label2.Text = "Soyadı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(720, 27);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 11;
            label3.Text = "Birim :";
            // 
            // cmbBirim
            // 
            cmbBirim.FormattingEnabled = true;
            cmbBirim.Items.AddRange(new object[] { "Yol ve Ulaşım Hizmetleri", "Tarımsal Hizmetler", "Su ve Kanalizasyon Hizmetleri", "Yönetim", "Operatör", "Destek Hizmetler", "Kültür ve Sosyal İşler" });
            cmbBirim.Location = new Point(787, 26);
            cmbBirim.Name = "cmbBirim";
            cmbBirim.Size = new Size(305, 33);
            cmbBirim.TabIndex = 12;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Admin", "Yol", "Asfalt", "Sanat", "Su", "Tarımsal", "Rapor", "Operatör", "Destek", "Kültür" });
            cmbRol.Location = new Point(77, 91);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(223, 33);
            cmbRol.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 94);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 14;
            label4.Text = "Rol :";
            // 
            // chkIlce
            // 
            chkIlce.FormattingEnabled = true;
            chkIlce.Location = new Point(444, 94);
            chkIlce.Name = "chkIlce";
            chkIlce.Size = new Size(320, 200);
            chkIlce.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(363, 94);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 19;
            label5.Text = "İlçeler :";
            // 
            // button1
            // 
            button1.Location = new Point(865, 241);
            button1.Name = "button1";
            button1.Size = new Size(127, 53);
            button1.TabIndex = 20;
            button1.Text = "Listeye Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Isim, Soyisim, Birim, Rol, Password, KullaniciAdi, Ilceler, btnSil, Guncelle, ID });
            dataGridView1.Location = new Point(23, 315);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1427, 601);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // Isim
            // 
            Isim.DataPropertyName = "Isim";
            Isim.HeaderText = "Isim";
            Isim.MinimumWidth = 8;
            Isim.Name = "Isim";
            Isim.ReadOnly = true;
            // 
            // Soyisim
            // 
            Soyisim.DataPropertyName = "Soyisim";
            Soyisim.HeaderText = "Soyisim";
            Soyisim.MinimumWidth = 8;
            Soyisim.Name = "Soyisim";
            Soyisim.ReadOnly = true;
            // 
            // Birim
            // 
            Birim.DataPropertyName = "Birim";
            Birim.HeaderText = "Birim";
            Birim.MinimumWidth = 8;
            Birim.Name = "Birim";
            Birim.ReadOnly = true;
            // 
            // Rol
            // 
            Rol.DataPropertyName = "Role";
            Rol.HeaderText = "Rol";
            Rol.MinimumWidth = 8;
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            // 
            // Password
            // 
            Password.DataPropertyName = "Password";
            Password.HeaderText = "Password";
            Password.MinimumWidth = 8;
            Password.Name = "Password";
            Password.ReadOnly = true;
            Password.Visible = false;
            // 
            // KullaniciAdi
            // 
            KullaniciAdi.DataPropertyName = "Username";
            KullaniciAdi.HeaderText = "Kullanıcı Adı";
            KullaniciAdi.MinimumWidth = 8;
            KullaniciAdi.Name = "KullaniciAdi";
            KullaniciAdi.ReadOnly = true;
            // 
            // Ilceler
            // 
            Ilceler.DataPropertyName = "Ilceler";
            Ilceler.HeaderText = "İlçeler";
            Ilceler.MinimumWidth = 8;
            Ilceler.Name = "Ilceler";
            Ilceler.ReadOnly = true;
            // 
            // btnSil
            // 
            btnSil.HeaderText = "Sil";
            btnSil.MinimumWidth = 8;
            btnSil.Name = "btnSil";
            btnSil.ReadOnly = true;
            btnSil.Text = "Listeden Sil";
            btnSil.UseColumnTextForButtonValue = true;
            // 
            // Guncelle
            // 
            Guncelle.HeaderText = "Güncelle";
            Guncelle.MinimumWidth = 8;
            Guncelle.Name = "Guncelle";
            Guncelle.ReadOnly = true;
            Guncelle.Text = "Güncelle";
            Guncelle.UseColumnTextForButtonValue = true;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // lblPageInfo
            // 
            lblPageInfo.AutoSize = true;
            lblPageInfo.Location = new Point(536, 936);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(59, 25);
            lblPageInfo.TabIndex = 22;
            lblPageInfo.Text = "label6";
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(409, 932);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(112, 34);
            btnPrevious.TabIndex = 23;
            btnPrevious.Text = "Önceki";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click_1;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(601, 931);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(112, 34);
            btnNext.TabIndex = 24;
            btnNext.Text = "Sonraki";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click_1;
            // 
            // PersonelTanimlama
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1462, 980);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(lblPageInfo);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(chkIlce);
            Controls.Add(label4);
            Controls.Add(cmbRol);
            Controls.Add(cmbBirim);
            Controls.Add(label3);
            Controls.Add(txtSoyadi);
            Controls.Add(label2);
            Controls.Add(txtAdi);
            Controls.Add(label1);
            Name = "PersonelTanimlama";
            Text = "Personel Tanımlama";
            FormClosing += PersonelTanimlama_FormClosing;
            Load += PersonelTanimlama_Load;
            Leave += PersonelTanimlama_Leave;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAdi;
        private Label label1;
        private TextBox txtSoyadi;
        private Label label2;
        private Label label3;
        private ComboBox cmbBirim;
        private ComboBox cmbRol;
        private Label label4;
        private CheckedListBox chkIlce;
        private Label label5;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Isim;
        private DataGridViewTextBoxColumn Soyisim;
        private DataGridViewTextBoxColumn Birim;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn KullaniciAdi;
        private DataGridViewTextBoxColumn Ilceler;
        private DataGridViewButtonColumn btnSil;
        private DataGridViewButtonColumn Guncelle;
        private DataGridViewTextBoxColumn ID;
        private Label lblPageInfo;
        private Button btnPrevious;
        private Button btnNext;
    }
}