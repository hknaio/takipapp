namespace YatirimTakip
{
    partial class MakineTanimlama
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
            txtPlaka = new TextBox();
            label1 = new Label();
            cmbTur = new ComboBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            lblPageInfo = new Label();
            Plaka = new DataGridViewTextBoxColumn();
            Turu = new DataGridViewTextBoxColumn();
            btnSil = new DataGridViewButtonColumn();
            ID = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtPlaka
            // 
            txtPlaka.Location = new Point(112, 35);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(223, 31);
            txtPlaka.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 37);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 9;
            label1.Text = "Plaka :";
            // 
            // cmbTur
            // 
            cmbTur.FormattingEnabled = true;
            cmbTur.Items.AddRange(new object[] { "Vinç", "Kamyon", "Silindir", "Kar Küreme" });
            cmbTur.Location = new Point(470, 32);
            cmbTur.Name = "cmbTur";
            cmbTur.Size = new Size(305, 33);
            cmbTur.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(384, 35);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 13;
            label3.Text = "Tür :";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Plaka, Turu, btnSil, ID });
            dataGridView1.Location = new Point(27, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1060, 647);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(852, 23);
            button1.Name = "button1";
            button1.Size = new Size(127, 53);
            button1.TabIndex = 23;
            button1.Text = "Listeye Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(519, 761);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(112, 34);
            btnNext.TabIndex = 27;
            btnNext.Text = "Sonraki";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(327, 762);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(112, 34);
            btnPrevious.TabIndex = 26;
            btnPrevious.Text = "Önceki";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // lblPageInfo
            // 
            lblPageInfo.AutoSize = true;
            lblPageInfo.Location = new Point(454, 766);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(59, 25);
            lblPageInfo.TabIndex = 25;
            lblPageInfo.Text = "label6";
            // 
            // Plaka
            // 
            Plaka.DataPropertyName = "Plaka";
            Plaka.HeaderText = "Plaka";
            Plaka.MinimumWidth = 8;
            Plaka.Name = "Plaka";
            Plaka.ReadOnly = true;
            // 
            // Turu
            // 
            Turu.DataPropertyName = "Turu";
            Turu.HeaderText = "Türü";
            Turu.MinimumWidth = 8;
            Turu.Name = "Turu";
            Turu.ReadOnly = true;
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
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // MakineTanimlama
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 804);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(lblPageInfo);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(cmbTur);
            Controls.Add(label3);
            Controls.Add(txtPlaka);
            Controls.Add(label1);
            Name = "MakineTanimlama";
            Text = "İş Makinesi Tanımlama";
            FormClosing += MakineTanimlama_FormClosing;
            Load += MakineTanimlama_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPlaka;
        private Label label1;
        private ComboBox cmbTur;
        private Label label3;
        private DataGridView dataGridView1;
        private Button button1;
        private Button btnNext;
        private Button btnPrevious;
        private Label lblPageInfo;
        private DataGridViewTextBoxColumn Plaka;
        private DataGridViewTextBoxColumn Turu;
        private DataGridViewButtonColumn btnSil;
        private DataGridViewTextBoxColumn ID;
    }
}