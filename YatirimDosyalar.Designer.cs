namespace YatirimTakip
{
    partial class YatirimDosyalar
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
            dataGridView1 = new DataGridView();
            DosyaAdi = new DataGridViewTextBoxColumn();
            Indir = new DataGridViewButtonColumn();
            Sil = new DataGridViewButtonColumn();
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
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DosyaAdi, Indir, Sil });
            dataGridView1.Location = new Point(22, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1004, 405);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // DosyaAdi
            // 
            DosyaAdi.HeaderText = "Dosya Adı";
            DosyaAdi.MinimumWidth = 8;
            DosyaAdi.Name = "DosyaAdi";
            DosyaAdi.ReadOnly = true;
            // 
            // Indir
            // 
            Indir.HeaderText = "İndir";
            Indir.MinimumWidth = 8;
            Indir.Name = "Indir";
            Indir.ReadOnly = true;
            Indir.Text = "Dosyayı İndir";
            Indir.ToolTipText = "Dosyayı İndir";
            Indir.UseColumnTextForButtonValue = true;
            // 
            // Sil
            // 
            Sil.HeaderText = "Sil";
            Sil.MinimumWidth = 8;
            Sil.Name = "Sil";
            Sil.ReadOnly = true;
            Sil.Text = "Dosyayı Sil";
            Sil.ToolTipText = "Dosyayı Sil";
            Sil.UseColumnTextForButtonValue = true;
            // 
            // YatirimDosyalar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 475);
            Controls.Add(dataGridView1);
            Name = "YatirimDosyalar";
            Text = "Yatırım Dosyalar";
            FormClosing += YatirimDosyalar_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn DosyaAdi;
        private DataGridViewButtonColumn Indir;
        private DataGridViewButtonColumn Sil;
    }
}