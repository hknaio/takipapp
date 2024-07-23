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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Adi, Koyler, ID, btnSil });
            dataGridView1.Location = new Point(98, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(548, 573);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Adi
            // 
            Adi.DataPropertyName = "Adi";
            Adi.HeaderText = "Adı";
            Adi.MinimumWidth = 8;
            Adi.Name = "Adi";
            Adi.ReadOnly = true;
            // 
            // Koyler
            // 
            Koyler.DataPropertyName = "Koyler";
            Koyler.HeaderText = "Koyler";
            Koyler.MinimumWidth = 8;
            Koyler.Name = "Koyler";
            Koyler.ReadOnly = true;
            Koyler.Visible = false;
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
            // btnSil
            // 
            btnSil.HeaderText = "Sil";
            btnSil.MinimumWidth = 8;
            btnSil.Name = "btnSil";
            btnSil.ReadOnly = true;
            btnSil.Text = "Listeden Sil";
            btnSil.UseColumnTextForButtonValue = true;
            // 
            // IlceTanimlama
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 680);
            Controls.Add(dataGridView1);
            Controls.Add(btnEkle);
            Controls.Add(txtAdi);
            Controls.Add(label1);
            Name = "IlceTanimlama";
            Text = "İlçe Tanımlama";
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