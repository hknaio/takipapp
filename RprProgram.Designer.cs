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
            Biten = new DataGridViewTextBoxColumn();
            Baslamamis = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 25);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 0;
            label1.Text = "Kaynak :";
            // 
            // cmbKaynak
            // 
            cmbKaynak.FormattingEnabled = true;
            cmbKaynak.Items.AddRange(new object[] { "İl Özel İdaresi", "KÖYDES", "İlbank", "Diğer" });
            cmbKaynak.Location = new Point(156, 22);
            cmbKaynak.Name = "cmbKaynak";
            cmbKaynak.Size = new Size(182, 33);
            cmbKaynak.TabIndex = 1;
            // 
            // btnGetir
            // 
            btnGetir.Location = new Point(389, 21);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(134, 34);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Ilce, ToplamProgram, DevamEden, Biten, Baslamamis });
            dataGridView1.Location = new Point(39, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(986, 510);
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
            // Biten
            // 
            Biten.DataPropertyName = "Biten";
            Biten.HeaderText = "Biten";
            Biten.MinimumWidth = 8;
            Biten.Name = "Biten";
            Biten.ReadOnly = true;
            // 
            // Baslamamis
            // 
            Baslamamis.DataPropertyName = "Baslamamis";
            Baslamamis.HeaderText = "Başlamamış";
            Baslamamis.MinimumWidth = 8;
            Baslamamis.Name = "Baslamamis";
            Baslamamis.ReadOnly = true;
            // 
            // RprProgram
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 628);
            Controls.Add(dataGridView1);
            Controls.Add(btnGetir);
            Controls.Add(cmbKaynak);
            Controls.Add(label1);
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
        private DataGridViewTextBoxColumn Ilce;
        private DataGridViewTextBoxColumn ToplamProgram;
        private DataGridViewTextBoxColumn DevamEden;
        private DataGridViewTextBoxColumn Biten;
        private DataGridViewTextBoxColumn Baslamamis;
    }
}