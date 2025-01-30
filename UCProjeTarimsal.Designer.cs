namespace WinFormsApp1
{
    partial class UCProjeTarimsal
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            btnNewProject = new Button();
            dataGridView1 = new DataGridView();
            Adi = new DataGridViewTextBoxColumn();
            Aciklama = new DataGridViewTextBoxColumn();
            YaklasikMaliyet = new DataGridViewTextBoxColumn();
            SozlesmeBedeli = new DataGridViewTextBoxColumn();
            ProjeDurumu = new DataGridViewTextBoxColumn();
            Yuklenici = new DataGridViewTextBoxColumn();
            GeciciKabulTarihi = new DataGridViewTextBoxColumn();
            KesinKabulTarihi = new DataGridViewTextBoxColumn();
            Sil = new DataGridViewButtonColumn();
            Uygulama = new DataGridViewButtonColumn();
            ID = new DataGridViewTextBoxColumn();
            btnGetir = new Button();
            label2 = new Label();
            cmbIlce = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnNewProject
            // 
            btnNewProject.BackColor = SystemColors.GradientActiveCaption;
            btnNewProject.BackgroundImageLayout = ImageLayout.Center;
            btnNewProject.Image = YatirimTakip.Properties.Resources.icons8_add_64;
            btnNewProject.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewProject.Location = new Point(0, 0);
            btnNewProject.Name = "btnNewProject";
            btnNewProject.Size = new Size(307, 69);
            btnNewProject.TabIndex = 0;
            btnNewProject.Text = "Yeni Proje Ekle";
            btnNewProject.UseVisualStyleBackColor = false;
            btnNewProject.Click += btnNewProject_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Adi, Aciklama, YaklasikMaliyet, SozlesmeBedeli, ProjeDurumu, Yuklenici, GeciciKabulTarihi, KesinKabulTarihi, Sil, Uygulama, ID });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(3, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridView1.Size = new Size(1401, 594);
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
            // 
            // Aciklama
            // 
            Aciklama.DataPropertyName = "Aciklama";
            Aciklama.HeaderText = "Açıklama";
            Aciklama.MinimumWidth = 8;
            Aciklama.Name = "Aciklama";
            Aciklama.ReadOnly = true;
            // 
            // YaklasikMaliyet
            // 
            YaklasikMaliyet.DataPropertyName = "YaklasikMaliyet";
            YaklasikMaliyet.HeaderText = "Yaklaşık Maliyet";
            YaklasikMaliyet.MinimumWidth = 8;
            YaklasikMaliyet.Name = "YaklasikMaliyet";
            YaklasikMaliyet.ReadOnly = true;
            // 
            // SozlesmeBedeli
            // 
            SozlesmeBedeli.DataPropertyName = "SozlesmeBedeli";
            SozlesmeBedeli.HeaderText = "Sözleşme Bedeli";
            SozlesmeBedeli.MinimumWidth = 8;
            SozlesmeBedeli.Name = "SozlesmeBedeli";
            SozlesmeBedeli.ReadOnly = true;
            // 
            // ProjeDurumu
            // 
            ProjeDurumu.DataPropertyName = "ProjeDurumu";
            ProjeDurumu.HeaderText = "Durumu";
            ProjeDurumu.MinimumWidth = 8;
            ProjeDurumu.Name = "ProjeDurumu";
            ProjeDurumu.ReadOnly = true;
            // 
            // Yuklenici
            // 
            Yuklenici.DataPropertyName = "Yuklenici";
            Yuklenici.HeaderText = "Yüklenici";
            Yuklenici.MinimumWidth = 8;
            Yuklenici.Name = "Yuklenici";
            Yuklenici.ReadOnly = true;
            // 
            // GeciciKabulTarihi
            // 
            GeciciKabulTarihi.DataPropertyName = "GeciciKabulTarihi";
            GeciciKabulTarihi.HeaderText = "Geçici Kabul Tarihi";
            GeciciKabulTarihi.MinimumWidth = 8;
            GeciciKabulTarihi.Name = "GeciciKabulTarihi";
            GeciciKabulTarihi.ReadOnly = true;
            // 
            // KesinKabulTarihi
            // 
            KesinKabulTarihi.DataPropertyName = "KesinKabulTarihi";
            KesinKabulTarihi.HeaderText = "Kesin Kabul Tarihi";
            KesinKabulTarihi.MinimumWidth = 8;
            KesinKabulTarihi.Name = "KesinKabulTarihi";
            KesinKabulTarihi.ReadOnly = true;
            // 
            // Sil
            // 
            Sil.DataPropertyName = "Sil";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.Tomato;
            dataGridViewCellStyle6.ForeColor = Color.White;
            Sil.DefaultCellStyle = dataGridViewCellStyle6;
            Sil.FlatStyle = FlatStyle.Flat;
            Sil.HeaderText = "Sil";
            Sil.MinimumWidth = 8;
            Sil.Name = "Sil";
            Sil.ReadOnly = true;
            Sil.Resizable = DataGridViewTriState.True;
            Sil.SortMode = DataGridViewColumnSortMode.Automatic;
            Sil.Text = "Sil";
            Sil.UseColumnTextForButtonValue = true;
            // 
            // Uygulama
            // 
            Uygulama.DataPropertyName = "Uygulama";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.LimeGreen;
            dataGridViewCellStyle7.ForeColor = Color.White;
            Uygulama.DefaultCellStyle = dataGridViewCellStyle7;
            Uygulama.FlatStyle = FlatStyle.Flat;
            Uygulama.HeaderText = "Uygulama";
            Uygulama.MinimumWidth = 8;
            Uygulama.Name = "Uygulama";
            Uygulama.ReadOnly = true;
            Uygulama.Text = "Uygulama";
            Uygulama.UseColumnTextForButtonValue = true;
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
            // btnGetir
            // 
            btnGetir.Location = new Point(867, 14);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(179, 41);
            btnGetir.TabIndex = 59;
            btnGetir.Text = "Getir";
            btnGetir.UseVisualStyleBackColor = true;
            btnGetir.Click += btnGetir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(430, 22);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 58;
            label2.Text = "İlçe : ";
            // 
            // cmbIlce
            // 
            cmbIlce.FormattingEnabled = true;
            cmbIlce.Items.AddRange(new object[] { "--" });
            cmbIlce.Location = new Point(508, 19);
            cmbIlce.Name = "cmbIlce";
            cmbIlce.Size = new Size(300, 33);
            cmbIlce.TabIndex = 57;
            // 
            // UCProjeTarimsal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(btnGetir);
            Controls.Add(label2);
            Controls.Add(cmbIlce);
            Controls.Add(dataGridView1);
            Controls.Add(btnNewProject);
            Name = "UCProjeTarimsal";
            Size = new Size(1411, 667);
            Load += UCProjeTarimsal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private DataGridViewTextBoxColumn GeciciKabulTarihi;
        private DataGridViewTextBoxColumn KesinKabulTarihi;
        private DataGridViewButtonColumn Sil;
        private DataGridViewButtonColumn Uygulama;
        private DataGridViewTextBoxColumn ID;
        private Button btnGetir;
        private Label label2;
        private ComboBox cmbIlce;
    }
}
