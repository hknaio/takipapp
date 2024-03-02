namespace WinFormsApp1
{
    partial class SpiralBoruTanimlama
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCap = new MaskedTextBox();
            txtBirim = new TextBox();
            txtStok = new MaskedTextBox();
            dataGridView1 = new DataGridView();
            btnEkle = new Button();
            ID = new DataGridViewTextBoxColumn();
            Cap = new DataGridViewTextBoxColumn();
            Birim = new DataGridViewTextBoxColumn();
            MiktarGuncelle = new DataGridViewButtonColumn();
            Sil = new DataGridViewButtonColumn();
            StokMiktar = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 29);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 0;
            label1.Text = "Çap :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(372, 29);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 1;
            label2.Text = "Birim :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(672, 29);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 2;
            label3.Text = "Stok Miktar :";
            // 
            // txtCap
            // 
            txtCap.Location = new Point(88, 29);
            txtCap.Name = "txtCap";
            txtCap.Size = new Size(150, 31);
            txtCap.TabIndex = 3;
            // 
            // txtBirim
            // 
            txtBirim.Location = new Point(439, 26);
            txtBirim.Name = "txtBirim";
            txtBirim.Size = new Size(150, 31);
            txtBirim.TabIndex = 4;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(789, 29);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(150, 31);
            txtStok.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Cap, Birim, MiktarGuncelle, Sil, StokMiktar });
            dataGridView1.Location = new Point(88, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(751, 423);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(994, 28);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(153, 39);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "Listeye Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
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
            // Cap
            // 
            Cap.DataPropertyName = "Cap";
            Cap.HeaderText = "Cap";
            Cap.MinimumWidth = 8;
            Cap.Name = "Cap";
            Cap.ReadOnly = true;
            Cap.Width = 150;
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
            // MiktarGuncelle
            // 
            MiktarGuncelle.HeaderText = "Miktar Güncelle";
            MiktarGuncelle.MinimumWidth = 8;
            MiktarGuncelle.Name = "MiktarGuncelle";
            MiktarGuncelle.ReadOnly = true;
            MiktarGuncelle.Text = "Güncelle";
            MiktarGuncelle.UseColumnTextForButtonValue = true;
            MiktarGuncelle.Width = 150;
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
            // StokMiktar
            // 
            StokMiktar.DataPropertyName = "StokMiktar";
            dataGridViewCellStyle1.NullValue = "00";
            StokMiktar.DefaultCellStyle = dataGridViewCellStyle1;
            StokMiktar.HeaderText = "Stok Miktar";
            StokMiktar.MinimumWidth = 8;
            StokMiktar.Name = "StokMiktar";
            StokMiktar.ReadOnly = true;
            StokMiktar.SortMode = DataGridViewColumnSortMode.NotSortable;
            StokMiktar.Width = 150;
            // 
            // SpiralBoruTanimlama
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 589);
            Controls.Add(btnEkle);
            Controls.Add(dataGridView1);
            Controls.Add(txtStok);
            Controls.Add(txtBirim);
            Controls.Add(txtCap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SpiralBoruTanimlama";
            Text = "SpiralBoruTanimlama";
            FormClosing += SpiralBoruTanimlama_FormClosing;
            Load += SpiralBoruTanimlama_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private MaskedTextBox txtCap;
        private TextBox txtBirim;
        private MaskedTextBox txtStok;
        private DataGridView dataGridView1;
        private Button btnEkle;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Cap;
        private DataGridViewTextBoxColumn Birim;
        private DataGridViewTextBoxColumn StokMiktar;
        private DataGridViewButtonColumn MiktarGuncelle;
        private DataGridViewButtonColumn Sil;
    }
}