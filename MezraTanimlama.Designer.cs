namespace WinFormsApp1
{
    partial class MezraTanimlama
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
            btnEkle = new Button();
            txtMezra = new TextBox();
            label2 = new Label();
            cmbKoy = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Adi = new DataGridViewTextBoxColumn();
            Koy = new DataGridViewTextBoxColumn();
            Sil = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(417, 91);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(159, 34);
            btnEkle.TabIndex = 9;
            btnEkle.Text = "Sisteme Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtMezra
            // 
            txtMezra.Location = new Point(417, 38);
            txtMezra.Name = "txtMezra";
            txtMezra.Size = new Size(298, 31);
            txtMezra.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 38);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 7;
            label2.Text = "Mezra Adı :";
            // 
            // cmbKoy
            // 
            cmbKoy.FormattingEnabled = true;
            cmbKoy.Location = new Point(89, 35);
            cmbKoy.Name = "cmbKoy";
            cmbKoy.Size = new Size(182, 33);
            cmbKoy.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 38);
            label1.Name = "label1";
            label1.Size = new Size(51, 25);
            label1.TabIndex = 5;
            label1.Text = "Köy :";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Adi, Koy, Sil });
            dataGridView1.Location = new Point(30, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(469, 477);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
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
            // Adi
            // 
            Adi.DataPropertyName = "Adi";
            Adi.HeaderText = "Adı";
            Adi.MinimumWidth = 8;
            Adi.Name = "Adi";
            Adi.ReadOnly = true;
            Adi.Width = 150;
            // 
            // Koy
            // 
            Koy.DataPropertyName = "Koy";
            Koy.HeaderText = "Köy";
            Koy.MinimumWidth = 8;
            Koy.Name = "Koy";
            Koy.ReadOnly = true;
            Koy.Resizable = DataGridViewTriState.True;
            Koy.Width = 150;
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
            // MezraTanimlama
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 656);
            Controls.Add(dataGridView1);
            Controls.Add(btnEkle);
            Controls.Add(txtMezra);
            Controls.Add(label2);
            Controls.Add(cmbKoy);
            Controls.Add(label1);
            Name = "MezraTanimlama";
            Text = "Mezra Tanımlama";
            FormClosing += MezraTanimlama_FormClosing;
            Load += MezraTanimlama_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private TextBox txtMezra;
        private Label label2;
        private ComboBox cmbKoy;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Adi;
        private DataGridViewTextBoxColumn Koy;
        private DataGridViewButtonColumn Sil;
    }
}