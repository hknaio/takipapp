namespace WinFormsApp1
{
    partial class UCAsfaltDokum
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            Ilce = new DataGridViewTextBoxColumn();
            Koy = new DataGridViewTextBoxColumn();
            Imalat = new DataGridViewTextBoxColumn();
            Miktar = new DataGridViewTextBoxColumn();
            Uygulama = new DataGridViewTextBoxColumn();
            Dokum = new DataGridViewTextBoxColumn();
            ProgramId = new DataGridViewTextBoxColumn();
            YaklasikMaliyet = new DataGridViewTextBoxColumn();
            Kaynak = new DataGridViewTextBoxColumn();
            YatirimDurumu = new DataGridViewTextBoxColumn();
            Proje = new DataGridViewTextBoxColumn();
            Birim = new DataGridViewTextBoxColumn();
            Yil = new DataGridViewTextBoxColumn();
            Program = new DataGridViewTextBoxColumn();
            AsfaltDokum = new DataGridViewButtonColumn();
            cmbIlce = new ComboBox();
            label2 = new Label();
            cmbKaynak = new ComboBox();
            label1 = new Label();
            btnGetir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Ilce, Koy, Imalat, Miktar, Uygulama, Dokum, ProgramId, YaklasikMaliyet, Kaynak, YatirimDurumu, Proje, Birim, Yil, Program, AsfaltDokum });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Location = new Point(13, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(1460, 435);
            dataGridView1.TabIndex = 41;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
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
            // Koy
            // 
            Koy.DataPropertyName = "Koy";
            Koy.HeaderText = "Koy";
            Koy.MinimumWidth = 8;
            Koy.Name = "Koy";
            Koy.ReadOnly = true;
            Koy.Width = 150;
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
            Miktar.HeaderText = "Miktar (Program)";
            Miktar.MinimumWidth = 8;
            Miktar.Name = "Miktar";
            Miktar.ReadOnly = true;
            Miktar.Width = 150;
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
            // Dokum
            // 
            Dokum.DataPropertyName = "Dokum";
            Dokum.HeaderText = "Döküm Mesafe (km)";
            Dokum.MinimumWidth = 8;
            Dokum.Name = "Dokum";
            Dokum.ReadOnly = true;
            Dokum.Width = 150;
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
            // YaklasikMaliyet
            // 
            YaklasikMaliyet.DataPropertyName = "YaklasikMaliyet";
            YaklasikMaliyet.HeaderText = "Oransal Tahakkuk";
            YaklasikMaliyet.MinimumWidth = 8;
            YaklasikMaliyet.Name = "YaklasikMaliyet";
            YaklasikMaliyet.ReadOnly = true;
            YaklasikMaliyet.Visible = false;
            YaklasikMaliyet.Width = 150;
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
            // Birim
            // 
            Birim.DataPropertyName = "Birim";
            Birim.HeaderText = "Birim";
            Birim.MinimumWidth = 8;
            Birim.Name = "Birim";
            Birim.ReadOnly = true;
            Birim.Visible = false;
            Birim.Width = 150;
            // 
            // Yil
            // 
            Yil.DataPropertyName = "Yil";
            Yil.HeaderText = "Yil";
            Yil.MinimumWidth = 8;
            Yil.Name = "Yil";
            Yil.ReadOnly = true;
            Yil.Visible = false;
            Yil.Width = 150;
            // 
            // Program
            // 
            Program.DataPropertyName = "Program";
            Program.HeaderText = "Program";
            Program.MinimumWidth = 8;
            Program.Name = "Program";
            Program.ReadOnly = true;
            Program.Visible = false;
            Program.Width = 150;
            // 
            // AsfaltDokum
            // 
            AsfaltDokum.DataPropertyName = "AsfaltDokum";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LimeGreen;
            dataGridViewCellStyle2.ForeColor = Color.White;
            AsfaltDokum.DefaultCellStyle = dataGridViewCellStyle2;
            AsfaltDokum.FlatStyle = FlatStyle.Flat;
            AsfaltDokum.HeaderText = "Asfalt Döküm";
            AsfaltDokum.MinimumWidth = 8;
            AsfaltDokum.Name = "AsfaltDokum";
            AsfaltDokum.ReadOnly = true;
            AsfaltDokum.Text = "Asfalt Döküm";
            AsfaltDokum.UseColumnTextForButtonValue = true;
            AsfaltDokum.Width = 200;
            // 
            // cmbIlce
            // 
            cmbIlce.FormattingEnabled = true;
            cmbIlce.Items.AddRange(new object[] { "--" });
            cmbIlce.Location = new Point(105, 43);
            cmbIlce.Name = "cmbIlce";
            cmbIlce.Size = new Size(300, 33);
            cmbIlce.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 46);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 52;
            label2.Text = "İlçe : ";
            // 
            // cmbKaynak
            // 
            cmbKaynak.FormattingEnabled = true;
            cmbKaynak.Items.AddRange(new object[] { "Hepsi", "İl Özel İdaresi", "KÖYDES", "İlbank", "Diğer" });
            cmbKaynak.Location = new Point(613, 43);
            cmbKaynak.Name = "cmbKaynak";
            cmbKaynak.Size = new Size(182, 33);
            cmbKaynak.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(480, 46);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 54;
            label1.Text = "Kaynak :";
            // 
            // btnGetir
            // 
            btnGetir.Location = new Point(926, 38);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(179, 41);
            btnGetir.TabIndex = 55;
            btnGetir.Text = "Getir";
            btnGetir.UseVisualStyleBackColor = true;
            btnGetir.Click += btnGetir_Click;
            // 
            // UCAsfaltDokum
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnGetir);
            Controls.Add(label1);
            Controls.Add(cmbKaynak);
            Controls.Add(label2);
            Controls.Add(cmbIlce);
            Controls.Add(dataGridView1);
            Name = "UCAsfaltDokum";
            Size = new Size(1579, 806);
            Load += UCAsfaltDokum_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Ilce;
        private DataGridViewTextBoxColumn Koy;
        private DataGridViewTextBoxColumn Imalat;
        private DataGridViewTextBoxColumn Miktar;
        private DataGridViewTextBoxColumn Uygulama;
        private DataGridViewTextBoxColumn Dokum;
        private DataGridViewTextBoxColumn ProgramId;
        private DataGridViewTextBoxColumn YaklasikMaliyet;
        private DataGridViewTextBoxColumn Kaynak;
        private DataGridViewTextBoxColumn YatirimDurumu;
        private DataGridViewTextBoxColumn Proje;
        private DataGridViewTextBoxColumn Birim;
        private DataGridViewTextBoxColumn Yil;
        private DataGridViewTextBoxColumn Program;
        private DataGridViewButtonColumn AsfaltDokum;
        private ComboBox cmbIlce;
        private Label label2;
        private ComboBox cmbKaynak;
        private Label label1;
        private Button btnGetir;
    }
}
