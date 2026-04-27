namespace WinFormsApp1
{
    partial class YatirimTanimlamaDetay
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
            Durum = new DataGridViewTextBoxColumn();
            Proje = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Ilce = new DataGridViewTextBoxColumn();
            Koy = new DataGridViewTextBoxColumn();
            Birim = new DataGridViewTextBoxColumn();
            Imalat = new DataGridViewTextBoxColumn();
            Miktar = new DataGridViewTextBoxColumn();
            Yil = new DataGridViewTextBoxColumn();
            Program = new DataGridViewTextBoxColumn();
            Sil = new DataGridViewButtonColumn();
            Duzenle = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnEkProgram = new Button();
            button1 = new Button();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Durum, Proje, ID, Ilce, Koy, Birim, Imalat, Miktar, Yil, Program, Sil, Duzenle });
            dataGridView1.GridColor = SystemColors.HotTrack;
            dataGridView1.Location = new Point(8, 69);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1829, 872);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Durum
            // 
            Durum.DataPropertyName = "YatirimDurumu";
            Durum.HeaderText = "Durum";
            Durum.MinimumWidth = 8;
            Durum.Name = "Durum";
            Durum.ReadOnly = true;
            // 
            // Proje
            // 
            Proje.DataPropertyName = "Proje";
            Proje.HeaderText = "Proje";
            Proje.MinimumWidth = 8;
            Proje.Name = "Proje";
            Proje.ReadOnly = true;
            Proje.Visible = false;
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
            // Ilce
            // 
            Ilce.DataPropertyName = "Ilce";
            Ilce.HeaderText = "İlçe";
            Ilce.MinimumWidth = 8;
            Ilce.Name = "Ilce";
            Ilce.ReadOnly = true;
            // 
            // Koy
            // 
            Koy.DataPropertyName = "Koy";
            Koy.HeaderText = "Köy / Köyler ";
            Koy.MinimumWidth = 8;
            Koy.Name = "Koy";
            Koy.ReadOnly = true;
            // 
            // Birim
            // 
            Birim.DataPropertyName = "Birim";
            Birim.HeaderText = "Birim";
            Birim.MinimumWidth = 8;
            Birim.Name = "Birim";
            Birim.ReadOnly = true;
            // 
            // Imalat
            // 
            Imalat.DataPropertyName = "Imalat";
            Imalat.HeaderText = "İmalat";
            Imalat.MinimumWidth = 8;
            Imalat.Name = "Imalat";
            Imalat.ReadOnly = true;
            // 
            // Miktar
            // 
            Miktar.DataPropertyName = "Miktar";
            Miktar.HeaderText = "Miktar";
            Miktar.MinimumWidth = 8;
            Miktar.Name = "Miktar";
            Miktar.ReadOnly = true;
            // 
            // Yil
            // 
            Yil.DataPropertyName = "Yil";
            Yil.HeaderText = "Yıl";
            Yil.MinimumWidth = 8;
            Yil.Name = "Yil";
            Yil.ReadOnly = true;
            // 
            // Program
            // 
            Program.DataPropertyName = "Program";
            Program.HeaderText = "Program";
            Program.MinimumWidth = 8;
            Program.Name = "Program";
            Program.ReadOnly = true;
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
            // Duzenle
            // 
            Duzenle.HeaderText = "Düzenle";
            Duzenle.MinimumWidth = 8;
            Duzenle.Name = "Duzenle";
            Duzenle.ReadOnly = true;
            Duzenle.Text = "Düzenle";
            Duzenle.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(31, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 3;
            label1.Text = "Yıl :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(150, 14);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 4;
            label2.Text = "Kaynak :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(208, 17);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 17);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 6;
            // 
            // btnEkProgram
            // 
            btnEkProgram.BackColor = Color.IndianRed;
            btnEkProgram.Location = new Point(315, 14);
            btnEkProgram.Margin = new Padding(2);
            btnEkProgram.Name = "btnEkProgram";
            btnEkProgram.Size = new Size(111, 29);
            btnEkProgram.TabIndex = 7;
            btnEkProgram.Text = "Program Ekle";
            btnEkProgram.UseVisualStyleBackColor = false;
            btnEkProgram.Click += btnEkProgram_Click;
            // 
            // button1
            // 
            button1.Location = new Point(474, 13);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(102, 30);
            button1.TabIndex = 8;
            button1.Text = "PDF Aktar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // YatirimTanimlamaDetay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1924, 1061);
            Controls.Add(button1);
            Controls.Add(btnEkProgram);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "YatirimTanimlamaDetay";
            Text = "YatirimTanimlamaDetay";
            WindowState = FormWindowState.Maximized;
            FormClosing += YatirimTanimlamaDetay_FormClosing;
            Load += YatirimTanimlamaDetay_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnEkProgram;
        private DataGridViewTextBoxColumn Durum;
        private DataGridViewTextBoxColumn Proje;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Ilce;
        private DataGridViewTextBoxColumn Koy;
        private DataGridViewTextBoxColumn Birim;
        private DataGridViewTextBoxColumn Imalat;
        private DataGridViewTextBoxColumn Miktar;
        private DataGridViewTextBoxColumn Yil;
        private DataGridViewTextBoxColumn Program;
        private DataGridViewButtonColumn Sil;
        private DataGridViewButtonColumn Duzenle;
        private Button button1;
    }
}