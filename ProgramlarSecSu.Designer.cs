namespace WinFormsApp1
{
    partial class ProgramlarSecSu
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
            cmbYil = new ComboBox();
            label2 = new Label();
            cmbKaynak = new ComboBox();
            btnGetir = new Button();
            dataGridView1 = new DataGridView();
            Ilce = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Uygulama = new DataGridViewTextBoxColumn();
            Koy = new DataGridViewTextBoxColumn();
            Birim = new DataGridViewTextBoxColumn();
            Imalat = new DataGridViewTextBoxColumn();
            Miktar = new DataGridViewTextBoxColumn();
            YaklasikMaliyet = new DataGridViewTextBoxColumn();
            Yil = new DataGridViewTextBoxColumn();
            YatirimDurumu = new DataGridViewTextBoxColumn();
            Proje = new DataGridViewTextBoxColumn();
            Kaynak = new DataGridViewTextBoxColumn();
            Sec = new DataGridViewCheckBoxColumn();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 41);
            label1.Name = "label1";
            label1.Size = new Size(39, 25);
            label1.TabIndex = 0;
            label1.Text = "Yıl :";
            // 
            // cmbYil
            // 
            cmbYil.FormattingEnabled = true;
            cmbYil.Items.AddRange(new object[] { "2023", "2024", "2025", "2026" });
            cmbYil.Location = new Point(137, 38);
            cmbYil.Name = "cmbYil";
            cmbYil.Size = new Size(182, 33);
            cmbYil.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(372, 41);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 2;
            label2.Text = "Program Kaynağı :";
            // 
            // cmbKaynak
            // 
            cmbKaynak.FormattingEnabled = true;
            cmbKaynak.Items.AddRange(new object[] { "İl Özel İdaresi", "KÖYDES", "İlbank", "Diğer" });
            cmbKaynak.Location = new Point(553, 38);
            cmbKaynak.Name = "cmbKaynak";
            cmbKaynak.Size = new Size(182, 33);
            cmbKaynak.TabIndex = 3;
            // 
            // btnGetir
            // 
            btnGetir.Location = new Point(787, 36);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(165, 35);
            btnGetir.TabIndex = 4;
            btnGetir.Text = "Programı Getir";
            btnGetir.UseVisualStyleBackColor = true;
            btnGetir.Click += btnGetir_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Ilce, ID, Uygulama, Koy, Birim, Imalat, Miktar, YaklasikMaliyet, Yil, YatirimDurumu, Proje, Kaynak, Sec });
            dataGridView1.Location = new Point(12, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(1408, 707);
            dataGridView1.TabIndex = 5;
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
            // Sec
            // 
            Sec.HeaderText = "Sec";
            Sec.MinimumWidth = 8;
            Sec.Name = "Sec";
            Sec.Width = 150;
            // 
            // button1
            // 
            button1.Location = new Point(637, 851);
            button1.Name = "button1";
            button1.Size = new Size(149, 63);
            button1.TabIndex = 6;
            button1.Text = "Seçilenleri Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(841, 851);
            button2.Name = "button2";
            button2.Size = new Size(130, 63);
            button2.TabIndex = 7;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ProgramlarSec
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1432, 926);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(btnGetir);
            Controls.Add(cmbKaynak);
            Controls.Add(label2);
            Controls.Add(cmbYil);
            Controls.Add(label1);
            Name = "ProgramlarSec";
            Text = "ProgramlarSec";
            Load += ProgramlarSecSu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbYil;
        private Label label2;
        private ComboBox cmbKaynak;
        private Button btnGetir;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn Ilce;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Uygulama;
        private DataGridViewTextBoxColumn Koy;
        private DataGridViewTextBoxColumn Birim;
        private DataGridViewTextBoxColumn Imalat;
        private DataGridViewTextBoxColumn Miktar;
        private DataGridViewTextBoxColumn YaklasikMaliyet;
        private DataGridViewTextBoxColumn Yil;
        private DataGridViewTextBoxColumn YatirimDurumu;
        private DataGridViewTextBoxColumn Proje;
        private DataGridViewTextBoxColumn Kaynak;
        private DataGridViewCheckBoxColumn Sec;
    }
}