namespace WinFormsApp1
{
    partial class UCProje
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
            btnNewProject = new Button();
            dataGridView1 = new DataGridView();
            Proje = new DataGridViewTextBoxColumn();
            Miktar = new DataGridViewTextBoxColumn();
            YaklasikMaliyet = new DataGridViewTextBoxColumn();
            Aciklama = new DataGridViewTextBoxColumn();
            Durum = new DataGridViewTextBoxColumn();
            Duzenle = new DataGridViewButtonColumn();
            Uygulama = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnNewProject
            // 
            btnNewProject.Location = new Point(0, 0);
            btnNewProject.Name = "btnNewProject";
            btnNewProject.Size = new Size(160, 60);
            btnNewProject.TabIndex = 0;
            btnNewProject.Text = "Yeni Proje Ekle";
            btnNewProject.UseVisualStyleBackColor = true;
            btnNewProject.Click += btnNewProject_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Proje, Miktar, YaklasikMaliyet, Aciklama, Durum, Duzenle, Uygulama });
            dataGridView1.Location = new Point(3, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1093, 575);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Proje
            // 
            Proje.HeaderText = "Proje Adı";
            Proje.MinimumWidth = 8;
            Proje.Name = "Proje";
            Proje.Width = 150;
            // 
            // Miktar
            // 
            Miktar.HeaderText = "Miktar";
            Miktar.MinimumWidth = 8;
            Miktar.Name = "Miktar";
            Miktar.Width = 150;
            // 
            // YaklasikMaliyet
            // 
            YaklasikMaliyet.HeaderText = "Yaklaşık Maliyet";
            YaklasikMaliyet.MinimumWidth = 8;
            YaklasikMaliyet.Name = "YaklasikMaliyet";
            YaklasikMaliyet.Width = 150;
            // 
            // Aciklama
            // 
            Aciklama.HeaderText = "Açıklama ";
            Aciklama.MinimumWidth = 8;
            Aciklama.Name = "Aciklama";
            Aciklama.Width = 150;
            // 
            // Durum
            // 
            Durum.HeaderText = "Durum";
            Durum.MinimumWidth = 8;
            Durum.Name = "Durum";
            Durum.Width = 150;
            // 
            // Duzenle
            // 
            Duzenle.HeaderText = "Düzenle";
            Duzenle.MinimumWidth = 8;
            Duzenle.Name = "Duzenle";
            Duzenle.Width = 150;
            // 
            // Uygulama
            // 
            Uygulama.HeaderText = "Uygulama İşlemleri";
            Uygulama.MinimumWidth = 8;
            Uygulama.Name = "Uygulama";
            Uygulama.Width = 150;
            // 
            // UCProje
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(dataGridView1);
            Controls.Add(btnNewProject);
            Name = "UCProje";
            Size = new Size(1099, 644);
            Load += UCProje_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNewProject;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Proje;
        private DataGridViewTextBoxColumn Miktar;
        private DataGridViewTextBoxColumn YaklasikMaliyet;
        private DataGridViewTextBoxColumn Aciklama;
        private DataGridViewTextBoxColumn Durum;
        private DataGridViewButtonColumn Duzenle;
        private DataGridViewButtonColumn Uygulama;
    }
}
