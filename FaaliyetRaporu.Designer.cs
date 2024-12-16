namespace WinFormsApp1
{
    partial class FaaliyetRaporu
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            cmbYil = new ComboBox();
            btnGetir = new Button();
            button1 = new Button();
            Ilce = new DataGridViewTextBoxColumn();
            IsAdet = new DataGridViewTextBoxColumn();
            Kat1 = new DataGridViewTextBoxColumn();
            Kat2 = new DataGridViewTextBoxColumn();
            BSK = new DataGridViewTextBoxColumn();
            AsfaltOnarim = new DataGridViewTextBoxColumn();
            KilitliParke = new DataGridViewTextBoxColumn();
            Stabilize = new DataGridViewTextBoxColumn();
            YolOnarim = new DataGridViewTextBoxColumn();
            Menfez = new DataGridViewTextBoxColumn();
            Istinat = new DataGridViewTextBoxColumn();
            Kopru = new DataGridViewTextBoxColumn();
            Reglaj = new DataGridViewTextBoxColumn();
            Kar = new DataGridViewTextBoxColumn();
            Beton = new DataGridViewTextBoxColumn();
            YeniYol = new DataGridViewTextBoxColumn();
            Spiral = new DataGridViewTextBoxColumn();
            Icme = new DataGridViewTextBoxColumn();
            Tarimsal = new DataGridViewTextBoxColumn();
            Kaya = new DataGridViewTextBoxColumn();
            Diger = new DataGridViewTextBoxColumn();
            Miktar = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Ilce, IsAdet, Kat1, Kat2, BSK, AsfaltOnarim, KilitliParke, Stabilize, YolOnarim, Menfez, Istinat, Kopru, Reglaj, Kar, Beton, YeniYol, Spiral, Icme, Tarimsal, Kaya, Diger, Miktar });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(27, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(1885, 843);
            dataGridView1.TabIndex = 44;
            // 
            // cmbYil
            // 
            cmbYil.FormattingEnabled = true;
            cmbYil.Items.AddRange(new object[] { "2022", "2023", "2024", "2025", "2026" });
            cmbYil.Location = new Point(27, 22);
            cmbYil.Name = "cmbYil";
            cmbYil.Size = new Size(182, 33);
            cmbYil.TabIndex = 47;
            // 
            // btnGetir
            // 
            btnGetir.Location = new Point(286, 17);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(179, 41);
            btnGetir.TabIndex = 46;
            btnGetir.Text = "Rapor Getir";
            btnGetir.UseVisualStyleBackColor = true;
            btnGetir.Click += btnGetir_Click;
            // 
            // button1
            // 
            button1.Location = new Point(691, 20);
            button1.Name = "button1";
            button1.Size = new Size(146, 34);
            button1.TabIndex = 48;
            button1.Text = "PDF Aktar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Ilce
            // 
            Ilce.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Ilce.DataPropertyName = "Ilce";
            Ilce.HeaderText = "İlçe";
            Ilce.MinimumWidth = 8;
            Ilce.Name = "Ilce";
            Ilce.ReadOnly = true;
            // 
            // IsAdet
            // 
            IsAdet.DataPropertyName = "IsAdet";
            IsAdet.HeaderText = "Adet";
            IsAdet.MinimumWidth = 8;
            IsAdet.Name = "IsAdet";
            IsAdet.ReadOnly = true;
            // 
            // Kat1
            // 
            Kat1.DataPropertyName = "kat1";
            Kat1.HeaderText = "1.Kat (km)";
            Kat1.MinimumWidth = 8;
            Kat1.Name = "Kat1";
            Kat1.ReadOnly = true;
            // 
            // Kat2
            // 
            Kat2.DataPropertyName = "kat2";
            Kat2.HeaderText = "2.Kat (km)";
            Kat2.MinimumWidth = 8;
            Kat2.Name = "Kat2";
            Kat2.ReadOnly = true;
            // 
            // BSK
            // 
            BSK.DataPropertyName = "bsk";
            BSK.HeaderText = "BSK (km)";
            BSK.MinimumWidth = 8;
            BSK.Name = "BSK";
            BSK.ReadOnly = true;
            // 
            // AsfaltOnarim
            // 
            AsfaltOnarim.DataPropertyName = "asfaltOnarim";
            AsfaltOnarim.HeaderText = "Asf. Onarım (km)";
            AsfaltOnarim.MinimumWidth = 8;
            AsfaltOnarim.Name = "AsfaltOnarim";
            AsfaltOnarim.ReadOnly = true;
            // 
            // KilitliParke
            // 
            KilitliParke.DataPropertyName = "kilitliParke";
            KilitliParke.HeaderText = "Kilitli Parke (m2)";
            KilitliParke.MinimumWidth = 8;
            KilitliParke.Name = "KilitliParke";
            KilitliParke.ReadOnly = true;
            // 
            // Stabilize
            // 
            Stabilize.DataPropertyName = "stabilize";
            Stabilize.HeaderText = "Stabilize (km)";
            Stabilize.MinimumWidth = 10;
            Stabilize.Name = "Stabilize";
            Stabilize.ReadOnly = true;
            // 
            // YolOnarim
            // 
            YolOnarim.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            YolOnarim.DataPropertyName = "yolOnarim";
            YolOnarim.HeaderText = "Yol Onarım (km)";
            YolOnarim.MinimumWidth = 8;
            YolOnarim.Name = "YolOnarim";
            YolOnarim.ReadOnly = true;
            // 
            // Menfez
            // 
            Menfez.DataPropertyName = "menfez";
            Menfez.HeaderText = "Menfez (ad)";
            Menfez.MinimumWidth = 8;
            Menfez.Name = "Menfez";
            Menfez.ReadOnly = true;
            // 
            // Istinat
            // 
            Istinat.DataPropertyName = "istinat";
            Istinat.HeaderText = "Istinat (mt)";
            Istinat.MinimumWidth = 8;
            Istinat.Name = "Istinat";
            Istinat.ReadOnly = true;
            // 
            // Kopru
            // 
            Kopru.DataPropertyName = "kopru";
            Kopru.HeaderText = "Köprü (ad)";
            Kopru.MinimumWidth = 8;
            Kopru.Name = "Kopru";
            Kopru.ReadOnly = true;
            // 
            // Reglaj
            // 
            Reglaj.DataPropertyName = "reglaj";
            Reglaj.HeaderText = "Reglaj (km)";
            Reglaj.MinimumWidth = 8;
            Reglaj.Name = "Reglaj";
            Reglaj.ReadOnly = true;
            // 
            // Kar
            // 
            Kar.DataPropertyName = "kar";
            Kar.HeaderText = "Kar (km)";
            Kar.MinimumWidth = 8;
            Kar.Name = "Kar";
            Kar.ReadOnly = true;
            // 
            // Beton
            // 
            Beton.DataPropertyName = "beton";
            Beton.HeaderText = "Beton";
            Beton.MinimumWidth = 8;
            Beton.Name = "Beton";
            Beton.ReadOnly = true;
            Beton.Visible = false;
            // 
            // YeniYol
            // 
            YeniYol.DataPropertyName = "yeniYol";
            YeniYol.HeaderText = "Yeni Yol (km)";
            YeniYol.MinimumWidth = 8;
            YeniYol.Name = "YeniYol";
            YeniYol.ReadOnly = true;
            // 
            // Spiral
            // 
            Spiral.DataPropertyName = "spiral";
            Spiral.HeaderText = "Spiral Boru (mt)";
            Spiral.MinimumWidth = 8;
            Spiral.Name = "Spiral";
            Spiral.ReadOnly = true;
            // 
            // Icme
            // 
            Icme.DataPropertyName = "icme";
            Icme.HeaderText = "İçme Suyu (saat)";
            Icme.MinimumWidth = 8;
            Icme.Name = "Icme";
            Icme.ReadOnly = true;
            // 
            // Tarimsal
            // 
            Tarimsal.DataPropertyName = "tarim";
            Tarimsal.HeaderText = "Tarımsal Sulama (saat)";
            Tarimsal.MinimumWidth = 8;
            Tarimsal.Name = "Tarimsal";
            Tarimsal.ReadOnly = true;
            // 
            // Kaya
            // 
            Kaya.DataPropertyName = "kaya";
            Kaya.HeaderText = "Kaya Tahkimat (ton)";
            Kaya.MinimumWidth = 8;
            Kaya.Name = "Kaya";
            Kaya.ReadOnly = true;
            // 
            // Diger
            // 
            Diger.DataPropertyName = "diger";
            Diger.HeaderText = "Çevre Düzenleme (saat)";
            Diger.MinimumWidth = 8;
            Diger.Name = "Diger";
            Diger.ReadOnly = true;
            // 
            // Miktar
            // 
            Miktar.DataPropertyName = "miktar";
            Miktar.HeaderText = "Miktar (tl)";
            Miktar.MinimumWidth = 8;
            Miktar.Name = "Miktar";
            Miktar.ReadOnly = true;
            // 
            // FaaliyetRaporu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 943);
            Controls.Add(button1);
            Controls.Add(cmbYil);
            Controls.Add(btnGetir);
            Controls.Add(dataGridView1);
            Name = "FaaliyetRaporu";
            Text = "Faaliyet Raporu";
            FormClosing += FaaliyetRaporu_FormClosing;
            Load += FaaliyetRaporu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cmbYil;
        private Button btnGetir;
        private Button button1;
        private DataGridViewTextBoxColumn Koruge;
        private DataGridViewTextBoxColumn Ilce;
        private DataGridViewTextBoxColumn IsAdet;
        private DataGridViewTextBoxColumn Kat1;
        private DataGridViewTextBoxColumn Kat2;
        private DataGridViewTextBoxColumn BSK;
        private DataGridViewTextBoxColumn AsfaltOnarim;
        private DataGridViewTextBoxColumn KilitliParke;
        private DataGridViewTextBoxColumn Stabilize;
        private DataGridViewTextBoxColumn YolOnarim;
        private DataGridViewTextBoxColumn Menfez;
        private DataGridViewTextBoxColumn Istinat;
        private DataGridViewTextBoxColumn Kopru;
        private DataGridViewTextBoxColumn Reglaj;
        private DataGridViewTextBoxColumn Kar;
        private DataGridViewTextBoxColumn Beton;
        private DataGridViewTextBoxColumn YeniYol;
        private DataGridViewTextBoxColumn Spiral;
        private DataGridViewTextBoxColumn Icme;
        private DataGridViewTextBoxColumn Tarimsal;
        private DataGridViewTextBoxColumn Kaya;
        private DataGridViewTextBoxColumn Diger;
        private DataGridViewTextBoxColumn Miktar;
    }
}