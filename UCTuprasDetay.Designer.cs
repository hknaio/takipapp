namespace WinFormsApp1
{
    partial class UCTuprasDetay
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
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Tur = new DataGridViewTextBoxColumn();
            Tarih = new DataGridViewTextBoxColumn();
            SiparisNo = new DataGridViewTextBoxColumn();
            TuprasNet = new DataGridViewTextBoxColumn();
            OzelIdareNet = new DataGridViewTextBoxColumn();
            TartimNo = new DataGridViewTextBoxColumn();
            Fark = new DataGridViewTextBoxColumn();
            Sil = new DataGridViewButtonColumn();
            btnEkle = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Tur, Tarih, SiparisNo, TuprasNet, OzelIdareNet, TartimNo, Fark, Sil });
            dataGridView1.Location = new Point(32, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1265, 530);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
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
            // Tur
            // 
            Tur.DataPropertyName = "Tur";
            Tur.HeaderText = "Tür";
            Tur.MinimumWidth = 8;
            Tur.Name = "Tur";
            Tur.ReadOnly = true;
            // 
            // Tarih
            // 
            Tarih.DataPropertyName = "Tarih";
            Tarih.HeaderText = "Tarih";
            Tarih.MinimumWidth = 8;
            Tarih.Name = "Tarih";
            Tarih.ReadOnly = true;
            // 
            // SiparisNo
            // 
            SiparisNo.DataPropertyName = "SiparisNo";
            SiparisNo.HeaderText = "Sipariş No";
            SiparisNo.MinimumWidth = 8;
            SiparisNo.Name = "SiparisNo";
            SiparisNo.ReadOnly = true;
            // 
            // TuprasNet
            // 
            TuprasNet.DataPropertyName = "TuprasNet";
            TuprasNet.HeaderText = "Tüpraş Net";
            TuprasNet.MinimumWidth = 8;
            TuprasNet.Name = "TuprasNet";
            TuprasNet.ReadOnly = true;
            // 
            // OzelIdareNet
            // 
            OzelIdareNet.DataPropertyName = "IlOzelNet";
            OzelIdareNet.HeaderText = "Özel İdare Net";
            OzelIdareNet.MinimumWidth = 8;
            OzelIdareNet.Name = "OzelIdareNet";
            OzelIdareNet.ReadOnly = true;
            // 
            // TartimNo
            // 
            TartimNo.DataPropertyName = "TartimNo";
            TartimNo.HeaderText = "Tartım No";
            TartimNo.MinimumWidth = 8;
            TartimNo.Name = "TartimNo";
            TartimNo.ReadOnly = true;
            // 
            // Fark
            // 
            Fark.DataPropertyName = "Fark";
            Fark.HeaderText = "Fark";
            Fark.MinimumWidth = 8;
            Fark.Name = "Fark";
            Fark.ReadOnly = true;
            // 
            // Sil
            // 
            Sil.HeaderText = "Sil";
            Sil.MinimumWidth = 8;
            Sil.Name = "Sil";
            Sil.ReadOnly = true;
            Sil.Text = "Sil";
            Sil.UseColumnTextForButtonValue = true;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.GradientActiveCaption;
            btnEkle.Image = YatirimTakip.Properties.Resources.icons8_add_642;
            btnEkle.Location = new Point(32, 3);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(292, 94);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Malzeme Alımı Ekle";
            btnEkle.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(330, 3);
            label1.Name = "label1";
            label1.Size = new Size(76, 30);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // UCTuprasDetay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(label1);
            Controls.Add(btnEkle);
            Controls.Add(dataGridView1);
            Name = "UCTuprasDetay";
            Size = new Size(1329, 715);
            Load += UCTuprasDetay_Load;
            Leave += UCTuprasDetay_Leave;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnEkle;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Tur;
        private DataGridViewTextBoxColumn Tarih;
        private DataGridViewTextBoxColumn SiparisNo;
        private DataGridViewTextBoxColumn TuprasNet;
        private DataGridViewTextBoxColumn OzelIdareNet;
        private DataGridViewTextBoxColumn TartimNo;
        private DataGridViewTextBoxColumn Fark;
        private DataGridViewButtonColumn Sil;
        private Label label1;
    }
}
