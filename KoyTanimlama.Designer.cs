namespace WinFormsApp1
{
    partial class KoyTanimlama
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
            label1 = new Label();
            cmbIlce = new ComboBox();
            label2 = new Label();
            txtKoy = new TextBox();
            btnEkle = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            No = new DataGridViewTextBoxColumn();
            Adi = new DataGridViewTextBoxColumn();
            Ilce = new DataGridViewTextBoxColumn();
            Sil = new DataGridViewButtonColumn();
            btnKoyleriGetir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 31);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 0;
            label1.Text = "İlçe :";
            // 
            // cmbIlce
            // 
            cmbIlce.FormattingEnabled = true;
            cmbIlce.Location = new Point(91, 28);
            cmbIlce.Name = "cmbIlce";
            cmbIlce.Size = new Size(182, 33);
            cmbIlce.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(312, 31);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 2;
            label2.Text = "Köy Adı :";
            // 
            // txtKoy
            // 
            txtKoy.Location = new Point(406, 30);
            txtKoy.Name = "txtKoy";
            txtKoy.Size = new Size(298, 31);
            txtKoy.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(525, 85);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(179, 47);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Sisteme Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, No, Adi, Ilce, Sil });
            dataGridView1.Location = new Point(38, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1258, 530);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.RowPostPaint += dataGridView1_RowPostPaint;
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
            // No
            // 
            No.HeaderText = "No";
            No.MinimumWidth = 8;
            No.Name = "No";
            No.ReadOnly = true;
            No.Width = 150;
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
            // Ilce
            // 
            Ilce.DataPropertyName = "Ilce";
            Ilce.HeaderText = "İlçe ";
            Ilce.MinimumWidth = 8;
            Ilce.Name = "Ilce";
            Ilce.ReadOnly = true;
            Ilce.Resizable = DataGridViewTriState.True;
            Ilce.Width = 150;
            // 
            // Sil
            // 
            Sil.HeaderText = "Sil";
            Sil.MinimumWidth = 8;
            Sil.Name = "Sil";
            Sil.ReadOnly = true;
            Sil.Text = "Listeden Sil";
            Sil.UseColumnTextForButtonValue = true;
            Sil.Width = 150;
            // 
            // btnKoyleriGetir
            // 
            btnKoyleriGetir.Location = new Point(91, 85);
            btnKoyleriGetir.Name = "btnKoyleriGetir";
            btnKoyleriGetir.Size = new Size(182, 47);
            btnKoyleriGetir.TabIndex = 6;
            btnKoyleriGetir.Text = "İlçe Köylerini Getir";
            btnKoyleriGetir.UseVisualStyleBackColor = true;
            btnKoyleriGetir.Click += btnKoyleriGetir_Click;
            // 
            // KoyTanimlama
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 699);
            Controls.Add(btnKoyleriGetir);
            Controls.Add(dataGridView1);
            Controls.Add(btnEkle);
            Controls.Add(txtKoy);
            Controls.Add(label2);
            Controls.Add(cmbIlce);
            Controls.Add(label1);
            Name = "KoyTanimlama";
            Text = "Köy Tanımlama";
            FormClosing += KoyTanimlama_FormClosing;
            Load += KoyTanimlama_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbIlce;
        private Label label2;
        private TextBox txtKoy;
        private Button btnEkle;
        private DataGridView dataGridView1;
        private Button btnKoyleriGetir;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Adi;
        private DataGridViewTextBoxColumn Ilce;
        private DataGridViewButtonColumn Sil;
    }
}