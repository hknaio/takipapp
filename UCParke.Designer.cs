namespace WinFormsApp1
{
    partial class UCParke
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
            btnEkle = new Button();
            btnParkeStok = new Button();
            dataGridView1 = new DataGridView();
            Miktar = new DataGridViewTextBoxColumn();
            Koy = new DataGridViewTextBoxColumn();
            TalepEden = new DataGridViewTextBoxColumn();
            GidisTarihi = new DataGridViewTextBoxColumn();
            AracPlakasi = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            StokGuncelle = new DataGridViewButtonColumn();
            ParkeBordurTip = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(44, 19);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(152, 94);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Parke İşi Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnParkeStok
            // 
            btnParkeStok.Location = new Point(243, 19);
            btnParkeStok.Name = "btnParkeStok";
            btnParkeStok.Size = new Size(146, 94);
            btnParkeStok.TabIndex = 1;
            btnParkeStok.Text = "Parke Stok";
            btnParkeStok.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Miktar, Koy, TalepEden, GidisTarihi, AracPlakasi, ID, StokGuncelle, ParkeBordurTip });
            dataGridView1.Location = new Point(44, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1265, 530);
            dataGridView1.TabIndex = 2;
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
            // Koy
            // 
            Koy.DataPropertyName = "KoyAdi";
            Koy.HeaderText = "Köy";
            Koy.MinimumWidth = 8;
            Koy.Name = "Koy";
            Koy.ReadOnly = true;
            Koy.Width = 150;
            // 
            // TalepEden
            // 
            TalepEden.DataPropertyName = "TalepEden";
            TalepEden.HeaderText = "Talep Eden";
            TalepEden.MinimumWidth = 8;
            TalepEden.Name = "TalepEden";
            TalepEden.ReadOnly = true;
            TalepEden.Width = 150;
            // 
            // GidisTarihi
            // 
            GidisTarihi.DataPropertyName = "GidisTarihi";
            GidisTarihi.HeaderText = "GidisTarihi";
            GidisTarihi.MinimumWidth = 8;
            GidisTarihi.Name = "GidisTarihi";
            GidisTarihi.ReadOnly = true;
            GidisTarihi.Width = 150;
            // 
            // AracPlakasi
            // 
            AracPlakasi.DataPropertyName = "AracPlakasi";
            AracPlakasi.HeaderText = "Araç Plaka";
            AracPlakasi.MinimumWidth = 8;
            AracPlakasi.Name = "AracPlakasi";
            AracPlakasi.ReadOnly = true;
            AracPlakasi.Width = 150;
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
            // StokGuncelle
            // 
            StokGuncelle.HeaderText = "Stok Güncelle";
            StokGuncelle.MinimumWidth = 8;
            StokGuncelle.Name = "StokGuncelle";
            StokGuncelle.ReadOnly = true;
            StokGuncelle.Resizable = DataGridViewTriState.True;
            StokGuncelle.SortMode = DataGridViewColumnSortMode.Automatic;
            StokGuncelle.Width = 150;
            // 
            // ParkeBordurTip
            // 
            ParkeBordurTip.DataPropertyName = "ParkeBordurTip";
            ParkeBordurTip.HeaderText = "ParkeBordurTip";
            ParkeBordurTip.MinimumWidth = 8;
            ParkeBordurTip.Name = "ParkeBordurTip";
            ParkeBordurTip.ReadOnly = true;
            ParkeBordurTip.Visible = false;
            ParkeBordurTip.Width = 150;
            // 
            // UCParke
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(btnParkeStok);
            Controls.Add(btnEkle);
            Name = "UCParke";
            Size = new Size(1309, 652);
            Load += UCParke_Load;
            Leave += UCParke_Leave;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEkle;
        private Button btnParkeStok;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Miktar;
        private DataGridViewTextBoxColumn Koy;
        private DataGridViewTextBoxColumn TalepEden;
        private DataGridViewTextBoxColumn GidisTarihi;
        private DataGridViewTextBoxColumn AracPlakasi;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewButtonColumn StokGuncelle;
        private DataGridViewTextBoxColumn ParkeBordurTip;
    }
}
