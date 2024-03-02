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
            Ilce = new DataGridViewTextBoxColumn();
            Koy = new DataGridViewTextBoxColumn();
            Birim = new DataGridViewTextBoxColumn();
            Imalat = new DataGridViewTextBoxColumn();
            Miktar = new DataGridViewTextBoxColumn();
            Yil = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Durum, Ilce, Koy, Birim, Imalat, Miktar, Yil });
            dataGridView1.GridColor = SystemColors.HotTrack;
            dataGridView1.Location = new Point(12, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1337, 604);
            dataGridView1.TabIndex = 2;
            // 
            // Durum
            // 
            Durum.DataPropertyName = "YatirimDurumu";
            Durum.HeaderText = "Durum";
            Durum.MinimumWidth = 8;
            Durum.Name = "Durum";
            Durum.ReadOnly = true;
            Durum.Width = 150;
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
            // Koy
            // 
            Koy.DataPropertyName = "Koy";
            Koy.HeaderText = "Köy / Köyler ";
            Koy.MinimumWidth = 8;
            Koy.Name = "Koy";
            Koy.ReadOnly = true;
            Koy.Width = 150;
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
            // Imalat
            // 
            Imalat.DataPropertyName = "Imalat";
            Imalat.HeaderText = "İmalat";
            Imalat.MinimumWidth = 8;
            Imalat.Name = "Imalat";
            Imalat.ReadOnly = true;
            Imalat.Width = 150;
            // 
            // Miktar
            // 
            Miktar.DataPropertyName = "Miktar";
            Miktar.HeaderText = "Miktar";
            Miktar.MinimumWidth = 8;
            Miktar.Name = "Miktar";
            Miktar.ReadOnly = true;
            Miktar.Width = 150;
            // 
            // Yil
            // 
            Yil.DataPropertyName = "Yil";
            Yil.HeaderText = "Yıl";
            Yil.MinimumWidth = 8;
            Yil.Name = "Yil";
            Yil.ReadOnly = true;
            Yil.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(44, 24);
            label1.Name = "label1";
            label1.Size = new Size(50, 30);
            label1.TabIndex = 3;
            label1.Text = "Yıl :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(214, 24);
            label2.Name = "label2";
            label2.Size = new Size(100, 30);
            label2.TabIndex = 4;
            label2.Text = "Kaynak :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(297, 29);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 29);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 6;
            // 
            // YatirimTanimlamaDetay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1361, 731);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "YatirimTanimlamaDetay";
            Text = "YatirimTanimlamaDetay";
            FormClosing += YatirimTanimlamaDetay_FormClosing;
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
        private DataGridViewTextBoxColumn Durum;
        private DataGridViewTextBoxColumn Ilce;
        private DataGridViewTextBoxColumn Koy;
        private DataGridViewTextBoxColumn Birim;
        private DataGridViewTextBoxColumn Imalat;
        private DataGridViewTextBoxColumn Miktar;
        private DataGridViewTextBoxColumn Yil;
    }
}