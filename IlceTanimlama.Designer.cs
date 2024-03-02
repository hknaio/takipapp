namespace WinFormsApp1
{
    partial class IlceTanimlama
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
            txtAdi = new TextBox();
            btnEkle = new Button();
            dataGridView1 = new DataGridView();
            Adi = new DataGridViewTextBoxColumn();
            Koyler = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            btnSil = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 37);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 0;
            label1.Text = "Adı :";
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(98, 37);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(150, 31);
            txtAdi.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(311, 32);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(120, 41);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Sisteme Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Adi, Koyler, ID, btnSil });
            dataGridView1.Location = new Point(98, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(305, 294);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Adi
            // 
            Adi.DataPropertyName = "Adi";
            Adi.HeaderText = "Adi";
            Adi.MinimumWidth = 8;
            Adi.Name = "Adi";
            Adi.ReadOnly = true;
            Adi.Width = 75;
            // 
            // Koyler
            // 
            Koyler.DataPropertyName = "Koyler";
            Koyler.HeaderText = "Koyler";
            Koyler.MinimumWidth = 8;
            Koyler.Name = "Koyler";
            Koyler.ReadOnly = true;
            Koyler.Visible = false;
            Koyler.Width = 97;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            ID.Width = 66;
            // 
            // btnSil
            // 
            btnSil.HeaderText = "Sil";
            btnSil.MinimumWidth = 8;
            btnSil.Name = "btnSil";
            btnSil.ReadOnly = true;
            btnSil.Text = "Listeden Sil";
            btnSil.UseColumnTextForButtonValue = true;
            btnSil.Width = 36;
            // 
            // IlceTanimlama
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 416);
            Controls.Add(dataGridView1);
            Controls.Add(btnEkle);
            Controls.Add(txtAdi);
            Controls.Add(label1);
            Name = "IlceTanimlama";
            Text = "IlceTanimlama";
            FormClosing += IlceTanimlama_FormClosing;
            Load += IlceTanimlama_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAdi;
        private Button btnEkle;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Adi;
        private DataGridViewTextBoxColumn Koyler;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewButtonColumn btnSil;
    }
}