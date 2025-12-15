namespace WinFormsApp1
{
    partial class RprProgram
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
            cmbKaynak = new ComboBox();
            btnGetir = new Button();
            dataGridView1 = new DataGridView();
            Ilce = new DataGridViewTextBoxColumn();
            ToplamProgram = new DataGridViewTextBoxColumn();
            DevamEden = new DataGridViewTextBoxColumn();
            DevamEdenEk = new DataGridViewTextBoxColumn();
            Biten = new DataGridViewTextBoxColumn();
            BitenEk = new DataGridViewTextBoxColumn();
            Baslamamis = new DataGridViewTextBoxColumn();
            BaslamamisEk = new DataGridViewTextBoxColumn();
            button1 = new Button();
            cmbYil = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 15);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Kaynak :";
            // 
            // cmbKaynak
            // 
            cmbKaynak.FormattingEnabled = true;
            cmbKaynak.Items.AddRange(new object[] { "İl Özel İdaresi", "KÖYDES", "İlbank", "Diğer" });
            cmbKaynak.Location = new Point(91, 13);
            cmbKaynak.Margin = new Padding(2, 2, 2, 2);
            cmbKaynak.Name = "cmbKaynak";
            cmbKaynak.Size = new Size(129, 23);
            cmbKaynak.TabIndex = 1;
            // 
            // btnGetir
            // 
            btnGetir.Location = new Point(372, 12);
            btnGetir.Margin = new Padding(2, 2, 2, 2);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(94, 20);
            btnGetir.TabIndex = 2;
            btnGetir.Text = "Getir";
            btnGetir.UseVisualStyleBackColor = true;
            btnGetir.Click += btnGetir_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Ilce, ToplamProgram, DevamEden, DevamEdenEk, Biten, BitenEk, Baslamamis, BaslamamisEk });
            dataGridView1.Location = new Point(27, 64);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(690, 306);
            dataGridView1.TabIndex = 3;
            // 
            // Ilce
            // 
            Ilce.DataPropertyName = "Ilce";
            Ilce.HeaderText = "İlçe";
            Ilce.MinimumWidth = 8;
            Ilce.Name = "Ilce";
            Ilce.ReadOnly = true;
            // 
            // ToplamProgram
            // 
            ToplamProgram.DataPropertyName = "ToplamIs";
            ToplamProgram.HeaderText = "Toplam Program";
            ToplamProgram.MinimumWidth = 8;
            ToplamProgram.Name = "ToplamProgram";
            ToplamProgram.ReadOnly = true;
            // 
            // DevamEden
            // 
            DevamEden.DataPropertyName = "DevamEden";
            DevamEden.HeaderText = "Devam Eden";
            DevamEden.MinimumWidth = 8;
            DevamEden.Name = "DevamEden";
            DevamEden.ReadOnly = true;
            // 
            // DevamEdenEk
            // 
            DevamEdenEk.DataPropertyName = "DevamEdenEk";
            DevamEdenEk.HeaderText = "Devam Eden Ek";
            DevamEdenEk.MinimumWidth = 8;
            DevamEdenEk.Name = "DevamEdenEk";
            DevamEdenEk.ReadOnly = true;
            // 
            // Biten
            // 
            Biten.DataPropertyName = "Biten";
            Biten.HeaderText = "Biten";
            Biten.MinimumWidth = 8;
            Biten.Name = "Biten";
            Biten.ReadOnly = true;
            // 
            // BitenEk
            // 
            BitenEk.DataPropertyName = "BitenEk";
            BitenEk.HeaderText = "Biten Ek";
            BitenEk.MinimumWidth = 8;
            BitenEk.Name = "BitenEk";
            BitenEk.ReadOnly = true;
            // 
            // Baslamamis
            // 
            Baslamamis.DataPropertyName = "Baslamamis";
            Baslamamis.HeaderText = "Başlamamış";
            Baslamamis.MinimumWidth = 8;
            Baslamamis.Name = "Baslamamis";
            Baslamamis.ReadOnly = true;
            // 
            // BaslamamisEk
            // 
            BaslamamisEk.DataPropertyName = "BaslamamisEk";
            BaslamamisEk.HeaderText = "Başlamamış Ek";
            BaslamamisEk.MinimumWidth = 8;
            BaslamamisEk.Name = "BaslamamisEk";
            BaslamamisEk.ReadOnly = true;
            // 
            // button1
            // 
            button1.Location = new Point(488, 12);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(102, 20);
            button1.TabIndex = 4;
            button1.Text = "Excele Aktar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmbYil
            // 
            cmbYil.FormattingEnabled = true;
            cmbYil.Items.AddRange(new object[] { "2024", "2025", "2026", "2027", "2028", "2029", "2030" });
            cmbYil.Location = new Point(233, 13);
            cmbYil.Margin = new Padding(2, 2, 2, 2);
            cmbYil.Name = "cmbYil";
            cmbYil.Size = new Size(129, 23);
            cmbYil.TabIndex = 48;
            // 
            // RprProgram
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 377);
            Controls.Add(cmbYil);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(btnGetir);
            Controls.Add(cmbKaynak);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "RprProgram";
            Text = "Program Raporu";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbKaynak;
        private Button btnGetir;
        private DataGridView dataGridView1;
        private Button button1;
        private ComboBox cmbYil;
        private DataGridViewTextBoxColumn Ilce;
        private DataGridViewTextBoxColumn ToplamProgram;
        private DataGridViewTextBoxColumn DevamEden;
        private DataGridViewTextBoxColumn DevamEdenEk;
        private DataGridViewTextBoxColumn Biten;
        private DataGridViewTextBoxColumn BitenEk;
        private DataGridViewTextBoxColumn Baslamamis;
        private DataGridViewTextBoxColumn BaslamamisEk;
    }
}