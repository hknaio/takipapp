namespace WinFormsApp1
{
    partial class UCPurEmanet
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Tarih = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            IlceId = new DataGridViewTextBoxColumn();
            KoyId = new DataGridViewTextBoxColumn();
            ImalatId = new DataGridViewTextBoxColumn();
            Ilce = new DataGridViewTextBoxColumn();
            Koy = new DataGridViewTextBoxColumn();
            Imalat = new DataGridViewTextBoxColumn();
            Cins = new DataGridViewTextBoxColumn();
            Birim = new DataGridViewTextBoxColumn();
            Miktar = new DataGridViewTextBoxColumn();
            BirimFiyat = new DataGridViewTextBoxColumn();
            Tutar = new DataGridViewTextBoxColumn();
            Sil = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(236, 48);
            button1.TabIndex = 0;
            button1.Text = "Pür Emanet Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Tarih, ID, IlceId, KoyId, ImalatId, Ilce, Koy, Imalat, Cins, Birim, Miktar, BirimFiyat, Tutar, Sil });
            dataGridView1.Location = new Point(3, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1320, 646);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // Tarih
            // 
            Tarih.DataPropertyName = "Tarih";
            Tarih.HeaderText = "Tarih";
            Tarih.MinimumWidth = 8;
            Tarih.Name = "Tarih";
            Tarih.ReadOnly = true;
            Tarih.Resizable = DataGridViewTriState.True;
            Tarih.SortMode = DataGridViewColumnSortMode.NotSortable;
            Tarih.Width = 150;
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
            // IlceId
            // 
            IlceId.DataPropertyName = "IlceId";
            IlceId.HeaderText = "IlceId";
            IlceId.MinimumWidth = 8;
            IlceId.Name = "IlceId";
            IlceId.ReadOnly = true;
            IlceId.Visible = false;
            IlceId.Width = 150;
            // 
            // KoyId
            // 
            KoyId.DataPropertyName = "KoyId";
            KoyId.HeaderText = "KoyId";
            KoyId.MinimumWidth = 8;
            KoyId.Name = "KoyId";
            KoyId.ReadOnly = true;
            KoyId.Visible = false;
            KoyId.Width = 150;
            // 
            // ImalatId
            // 
            ImalatId.DataPropertyName = "ImalatId";
            ImalatId.HeaderText = "ImalatId";
            ImalatId.MinimumWidth = 8;
            ImalatId.Name = "ImalatId";
            ImalatId.ReadOnly = true;
            ImalatId.Visible = false;
            ImalatId.Width = 150;
            // 
            // Ilce
            // 
            Ilce.DataPropertyName = "Ilce";
            Ilce.HeaderText = "İlçe";
            Ilce.MinimumWidth = 8;
            Ilce.Name = "Ilce";
            Ilce.ReadOnly = true;
            Ilce.SortMode = DataGridViewColumnSortMode.NotSortable;
            Ilce.Width = 150;
            // 
            // Koy
            // 
            Koy.DataPropertyName = "Koy";
            Koy.HeaderText = "Köy";
            Koy.MinimumWidth = 8;
            Koy.Name = "Koy";
            Koy.ReadOnly = true;
            Koy.SortMode = DataGridViewColumnSortMode.NotSortable;
            Koy.Width = 150;
            // 
            // Imalat
            // 
            Imalat.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Imalat.DataPropertyName = "Imalat";
            Imalat.HeaderText = "İmalat";
            Imalat.MinimumWidth = 8;
            Imalat.Name = "Imalat";
            Imalat.ReadOnly = true;
            Imalat.SortMode = DataGridViewColumnSortMode.NotSortable;
            Imalat.Width = 67;
            // 
            // Cins
            // 
            Cins.DataPropertyName = "Cins";
            Cins.HeaderText = "Cins";
            Cins.MinimumWidth = 8;
            Cins.Name = "Cins";
            Cins.ReadOnly = true;
            Cins.SortMode = DataGridViewColumnSortMode.NotSortable;
            Cins.Width = 70;
            // 
            // Birim
            // 
            Birim.DataPropertyName = "Birim";
            Birim.HeaderText = "Birim";
            Birim.MinimumWidth = 8;
            Birim.Name = "Birim";
            Birim.ReadOnly = true;
            Birim.SortMode = DataGridViewColumnSortMode.NotSortable;
            Birim.Width = 90;
            // 
            // Miktar
            // 
            Miktar.DataPropertyName = "Miktar";
            Miktar.HeaderText = "Miktar";
            Miktar.MinimumWidth = 8;
            Miktar.Name = "Miktar";
            Miktar.ReadOnly = true;
            Miktar.SortMode = DataGridViewColumnSortMode.NotSortable;
            Miktar.Width = 90;
            // 
            // BirimFiyat
            // 
            BirimFiyat.DataPropertyName = "BirimFiyat";
            BirimFiyat.HeaderText = "Birim Fiyat";
            BirimFiyat.MinimumWidth = 8;
            BirimFiyat.Name = "BirimFiyat";
            BirimFiyat.ReadOnly = true;
            BirimFiyat.SortMode = DataGridViewColumnSortMode.NotSortable;
            BirimFiyat.Width = 150;
            // 
            // Tutar
            // 
            Tutar.DataPropertyName = "Tutar";
            Tutar.HeaderText = "Tutar";
            Tutar.MinimumWidth = 8;
            Tutar.Name = "Tutar";
            Tutar.ReadOnly = true;
            Tutar.SortMode = DataGridViewColumnSortMode.NotSortable;
            Tutar.Width = 150;
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
            // UCPurEmanet
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "UCPurEmanet";
            Size = new Size(1326, 706);
            Load += UCPurEmanet_Load;
            Leave += UCPurEmanet_Leave;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Tarih;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn IlceId;
        private DataGridViewTextBoxColumn KoyId;
        private DataGridViewTextBoxColumn ImalatId;
        private DataGridViewTextBoxColumn Ilce;
        private DataGridViewTextBoxColumn Koy;
        private DataGridViewTextBoxColumn Imalat;
        private DataGridViewTextBoxColumn Cins;
        private DataGridViewTextBoxColumn Birim;
        private DataGridViewTextBoxColumn Miktar;
        private DataGridViewTextBoxColumn BirimFiyat;
        private DataGridViewTextBoxColumn Tutar;
        private DataGridViewButtonColumn Sil;
    }
}
