namespace WinFormsApp1
{
    partial class UCGidenMalzeme
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
            Evsaf = new DataGridViewTextBoxColumn();
            Personel = new DataGridViewTextBoxColumn();
            Yer = new DataGridViewTextBoxColumn();
            Tarih = new DataGridViewTextBoxColumn();
            Sil = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(399, 25);
            label1.Name = "label1";
            label1.Size = new Size(76, 30);
            label1.TabIndex = 11;
            label1.Text = "label1";
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.GradientActiveCaption;
            btnEkle.Image = YatirimTakip.Properties.Resources.icons8_add_641;
            btnEkle.Location = new Point(14, 16);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(319, 94);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "Giden Malzeme Ekle";
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Evsaf, Personel, Yer, Tarih, Sil });
            dataGridView1.Location = new Point(14, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1265, 530);
            dataGridView1.TabIndex = 9;
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
            ID.Width = 150;
            // 
            // Evsaf
            // 
            Evsaf.DataPropertyName = "Evsaf";
            Evsaf.HeaderText = "Malzeme Evsaf";
            Evsaf.MinimumWidth = 8;
            Evsaf.Name = "Evsaf";
            Evsaf.ReadOnly = true;
            Evsaf.Width = 150;
            // 
            // Personel
            // 
            Personel.DataPropertyName = "Personel";
            Personel.HeaderText = "Talimat Veren";
            Personel.MinimumWidth = 8;
            Personel.Name = "Personel";
            Personel.ReadOnly = true;
            Personel.Width = 150;
            // 
            // Yer
            // 
            Yer.DataPropertyName = "Yer";
            Yer.HeaderText = "Gittiği Yer";
            Yer.MinimumWidth = 8;
            Yer.Name = "Yer";
            Yer.ReadOnly = true;
            Yer.Width = 150;
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
            // UCGidenMalzeme
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(label1);
            Controls.Add(btnEkle);
            Controls.Add(dataGridView1);
            Name = "UCGidenMalzeme";
            Size = new Size(1308, 727);
            Load += UCGidenMalzeme_Load;
            Leave += UCGidenMalzeme_Leave;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEkle;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Evsaf;
        private DataGridViewTextBoxColumn Personel;
        private DataGridViewTextBoxColumn Yer;
        private DataGridViewTextBoxColumn Tarih;
        private DataGridViewButtonColumn Sil;
    }
}
