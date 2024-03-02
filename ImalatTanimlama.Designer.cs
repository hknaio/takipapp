namespace WinFormsApp1
{
    partial class ImalatTanimlama
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
            ID = new DataGridViewTextBoxColumn();
            Isim = new DataGridViewTextBoxColumn();
            Cins = new DataGridViewTextBoxColumn();
            Birim = new DataGridViewTextBoxColumn();
            BirimFiyat = new DataGridViewTextBoxColumn();
            btnSil = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            txtAdi = new TextBox();
            txtBirim = new TextBox();
            txtCins = new TextBox();
            txtBirimFiyat = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Isim, Cins, Birim, BirimFiyat, btnSil });
            dataGridView1.Location = new Point(12, 133);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(879, 294);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
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
            // Isim
            // 
            Isim.DataPropertyName = "Isim";
            Isim.HeaderText = "İsim";
            Isim.MinimumWidth = 8;
            Isim.Name = "Isim";
            Isim.ReadOnly = true;
            Isim.Width = 150;
            // 
            // Cins
            // 
            Cins.DataPropertyName = "Cins";
            Cins.HeaderText = "Cins";
            Cins.MinimumWidth = 8;
            Cins.Name = "Cins";
            Cins.ReadOnly = true;
            Cins.Width = 150;
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
            // BirimFiyat
            // 
            BirimFiyat.DataPropertyName = "BirimFiyat";
            BirimFiyat.HeaderText = "Birim Fiyat";
            BirimFiyat.MinimumWidth = 8;
            BirimFiyat.Name = "BirimFiyat";
            BirimFiyat.ReadOnly = true;
            BirimFiyat.Width = 150;
            // 
            // btnSil
            // 
            btnSil.HeaderText = "Sil";
            btnSil.MinimumWidth = 8;
            btnSil.Name = "btnSil";
            btnSil.ReadOnly = true;
            btnSil.Text = "Listeden Sil";
            btnSil.UseColumnTextForButtonValue = true;
            btnSil.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 18);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 1;
            label1.Text = "Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 55);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 2;
            label2.Text = "Birim Fiyatı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 9);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 3;
            label3.Text = "Cinsi :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 57);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 4;
            label4.Text = "Birim :";
            // 
            // button1
            // 
            button1.Location = new Point(680, 55);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Listeye Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(76, 12);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(223, 31);
            txtAdi.TabIndex = 6;
            // 
            // txtBirim
            // 
            txtBirim.Location = new Point(76, 57);
            txtBirim.Name = "txtBirim";
            txtBirim.Size = new Size(223, 31);
            txtBirim.TabIndex = 8;
            // 
            // txtCins
            // 
            txtCins.Location = new Point(436, 12);
            txtCins.Name = "txtCins";
            txtCins.Size = new Size(223, 31);
            txtCins.TabIndex = 9;
            // 
            // txtBirimFiyat
            // 
            txtBirimFiyat.Location = new Point(436, 58);
            txtBirimFiyat.Name = "txtBirimFiyat";
            txtBirimFiyat.Size = new Size(223, 31);
            txtBirimFiyat.TabIndex = 10;
            // 
            // ImalatTanimlama
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 464);
            Controls.Add(txtBirimFiyat);
            Controls.Add(txtCins);
            Controls.Add(txtBirim);
            Controls.Add(txtAdi);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "ImalatTanimlama";
            Text = "İmalat Tanımlama";
            FormClosing += ImalatTanimlama_FormClosing;
            Load += ImalatTanimlama_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ImalatAdi;
        private DataGridViewTextBoxColumn ImalatCinsi;
        private DataGridViewButtonColumn Sil;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox txtAdi;
        private TextBox txtBirim;
        private TextBox txtCins;
        private MaskedTextBox txtBirimFiyat;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Isim;
        private DataGridViewTextBoxColumn Cins;
        private DataGridViewTextBoxColumn Birim;
        private DataGridViewTextBoxColumn BirimFiyat;
        private DataGridViewButtonColumn btnSil;
    }
}