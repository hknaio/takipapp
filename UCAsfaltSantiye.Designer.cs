namespace WinFormsApp1
{
    partial class UCAsfaltSantiye
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
            label1 = new Label();
            btnEkle = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Tarih = new DataGridViewTextBoxColumn();
            Ilce = new DataGridViewTextBoxColumn();
            IlceId = new DataGridViewTextBoxColumn();
            Koy = new DataGridViewTextBoxColumn();
            KoyId = new DataGridViewTextBoxColumn();
            Mezra = new DataGridViewTextBoxColumn();
            MezraId = new DataGridViewTextBoxColumn();
            Ton = new DataGridViewTextBoxColumn();
            Sil = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(312, 15);
            label1.Name = "label1";
            label1.Size = new Size(76, 30);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.GradientActiveCaption;
            btnEkle.Image = YatirimTakip.Properties.Resources.icons8_add_642;
            btnEkle.Location = new Point(16, 15);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(290, 94);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "Asfalt Şantiye Ekle";
            btnEkle.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Tarih, Ilce, IlceId, Koy, KoyId, Mezra, MezraId, Ton, Sil });
            dataGridView1.Location = new Point(16, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1265, 530);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
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
            // Tarih
            // 
            Tarih.DataPropertyName = "Tarih";
            Tarih.HeaderText = "Tarih";
            Tarih.MinimumWidth = 8;
            Tarih.Name = "Tarih";
            Tarih.ReadOnly = true;
            Tarih.Width = 150;
            // 
            // Ilce
            // 
            Ilce.DataPropertyName = "Ilce";
            Ilce.HeaderText = "İlçe";
            Ilce.MinimumWidth = 8;
            Ilce.Name = "Ilce";
            Ilce.ReadOnly = true;
            Ilce.Width = 150;
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
            // Koy
            // 
            Koy.DataPropertyName = "Koy";
            Koy.HeaderText = "Köy";
            Koy.MinimumWidth = 8;
            Koy.Name = "Koy";
            Koy.ReadOnly = true;
            Koy.Width = 150;
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
            // Mezra
            // 
            Mezra.DataPropertyName = "Mezra";
            Mezra.HeaderText = "Mezra";
            Mezra.MinimumWidth = 8;
            Mezra.Name = "Mezra";
            Mezra.ReadOnly = true;
            Mezra.Width = 150;
            // 
            // MezraId
            // 
            MezraId.DataPropertyName = "MezraId";
            MezraId.HeaderText = "MezraId";
            MezraId.MinimumWidth = 8;
            MezraId.Name = "MezraId";
            MezraId.ReadOnly = true;
            MezraId.Visible = false;
            MezraId.Width = 150;
            // 
            // Ton
            // 
            Ton.DataPropertyName = "Ton";
            Ton.HeaderText = "Ton";
            Ton.MinimumWidth = 8;
            Ton.Name = "Ton";
            Ton.ReadOnly = true;
            Ton.Width = 150;
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
            // UCAsfaltSantiye
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(label1);
            Controls.Add(btnEkle);
            Controls.Add(dataGridView1);
            Name = "UCAsfaltSantiye";
            Size = new Size(1296, 661);
            Load += UCAsfaltSantiye_Load;
            Leave += UCAsfaltSantiye_Leave;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEkle;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Tarih;
        private DataGridViewTextBoxColumn Ilce;
        private DataGridViewTextBoxColumn IlceId;
        private DataGridViewTextBoxColumn Koy;
        private DataGridViewTextBoxColumn KoyId;
        private DataGridViewTextBoxColumn Mezra;
        private DataGridViewTextBoxColumn MezraId;
        private DataGridViewTextBoxColumn Ton;
        private DataGridViewButtonColumn Sil;
    }
}
