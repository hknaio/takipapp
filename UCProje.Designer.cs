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
            Adi = new DataGridViewTextBoxColumn();
            Aciklama = new DataGridViewTextBoxColumn();
            YaklasikMaliyet = new DataGridViewTextBoxColumn();
            SozlesmeBedeli = new DataGridViewTextBoxColumn();
            ProjeDurumu = new DataGridViewTextBoxColumn();
            Yuklenici = new DataGridViewTextBoxColumn();
            Sil = new DataGridViewButtonColumn();
            Uygulama = new DataGridViewButtonColumn();
            ID = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnNewProject
            // 
            btnNewProject.Location = new Point(0, 0);
            btnNewProject.Name = "btnNewProject";
            btnNewProject.Size = new Size(201, 60);
            btnNewProject.TabIndex = 0;
            btnNewProject.Text = "Yeni Proje Ekle";
            btnNewProject.UseVisualStyleBackColor = true;
            btnNewProject.Click += btnNewProject_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Adi, Aciklama, YaklasikMaliyet, SozlesmeBedeli, ProjeDurumu, Yuklenici, Sil, Uygulama, ID });
            dataGridView1.Location = new Point(3, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridView1.Size = new Size(1390, 575);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // Adi
            // 
            Adi.DataPropertyName = "Adi";
            Adi.HeaderText = "Adı";
            Adi.MinimumWidth = 8;
            Adi.Name = "Adi";
            Adi.ReadOnly = true;
            Adi.Width = 150;
            // 
            // Aciklama
            // 
            Aciklama.DataPropertyName = "Aciklama";
            Aciklama.HeaderText = "Açıklama";
            Aciklama.MinimumWidth = 8;
            Aciklama.Name = "Aciklama";
            Aciklama.ReadOnly = true;
            Aciklama.Width = 150;
            // 
            // YaklasikMaliyet
            // 
            YaklasikMaliyet.DataPropertyName = "YaklasikMaliyet";
            YaklasikMaliyet.HeaderText = "Yaklaşık Maliyet";
            YaklasikMaliyet.MinimumWidth = 8;
            YaklasikMaliyet.Name = "YaklasikMaliyet";
            YaklasikMaliyet.ReadOnly = true;
            YaklasikMaliyet.Width = 150;
            // 
            // SozlesmeBedeli
            // 
            SozlesmeBedeli.DataPropertyName = "SozlesmeBedeli";
            SozlesmeBedeli.HeaderText = "Sözleşme Bedeli";
            SozlesmeBedeli.MinimumWidth = 8;
            SozlesmeBedeli.Name = "SozlesmeBedeli";
            SozlesmeBedeli.ReadOnly = true;
            SozlesmeBedeli.Width = 150;
            // 
            // ProjeDurumu
            // 
            ProjeDurumu.DataPropertyName = "ProjeDurumu";
            ProjeDurumu.HeaderText = "ProjeDurumu";
            ProjeDurumu.MinimumWidth = 8;
            ProjeDurumu.Name = "ProjeDurumu";
            ProjeDurumu.ReadOnly = true;
            ProjeDurumu.Width = 150;
            // 
            // Yuklenici
            // 
            Yuklenici.DataPropertyName = "Yuklenici";
            Yuklenici.HeaderText = "Yüklenici";
            Yuklenici.MinimumWidth = 8;
            Yuklenici.Name = "Yuklenici";
            Yuklenici.ReadOnly = true;
            Yuklenici.Width = 150;
            // 
            // Sil
            // 
            Sil.DataPropertyName = "Sil";
            Sil.HeaderText = "Sil";
            Sil.MinimumWidth = 8;
            Sil.Name = "Sil";
            Sil.ReadOnly = true;
            Sil.Resizable = DataGridViewTriState.True;
            Sil.SortMode = DataGridViewColumnSortMode.Automatic;
            Sil.Text = "Sil";
            Sil.UseColumnTextForButtonValue = true;
            Sil.Width = 150;
            // 
            // Uygulama
            // 
            Uygulama.DataPropertyName = "Uygulama";
            Uygulama.HeaderText = "Uygulama";
            Uygulama.MinimumWidth = 8;
            Uygulama.Name = "Uygulama";
            Uygulama.ReadOnly = true;
            Uygulama.Text = "Uygulama";
            Uygulama.UseColumnTextForButtonValue = true;
            Uygulama.Width = 150;
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
            Size = new Size(1396, 644);
            Load += UCProje_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNewProject;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Adi;
        private DataGridViewTextBoxColumn Aciklama;
        private DataGridViewTextBoxColumn YaklasikMaliyet;
        private DataGridViewTextBoxColumn SozlesmeBedeli;
        private DataGridViewTextBoxColumn ProjeDurumu;
        private DataGridViewTextBoxColumn Yuklenici;
        private DataGridViewButtonColumn Sil;
        private DataGridViewButtonColumn Uygulama;
        private DataGridViewTextBoxColumn ID;
    }
}
