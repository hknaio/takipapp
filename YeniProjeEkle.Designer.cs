namespace WinFormsApp1
{
    partial class YeniProjeEkle
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
            txtProjeAdi = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            KoyAdi = new DataGridViewTextBoxColumn();
            ImalatTuru = new DataGridViewTextBoxColumn();
            Miktar = new DataGridViewTextBoxColumn();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 40);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 0;
            label1.Text = "Proje Adı : ";
            // 
            // txtProjeAdi
            // 
            txtProjeAdi.Location = new Point(178, 40);
            txtProjeAdi.Name = "txtProjeAdi";
            txtProjeAdi.Size = new Size(304, 31);
            txtProjeAdi.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 99);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 3;
            label3.Text = "Açıklama :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(178, 96);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(505, 70);
            textBox1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { KoyAdi, ImalatTuru, Miktar });
            dataGridView1.Location = new Point(33, 279);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(715, 287);
            dataGridView1.TabIndex = 11;
            // 
            // KoyAdi
            // 
            KoyAdi.HeaderText = "Köy Adı";
            KoyAdi.MinimumWidth = 8;
            KoyAdi.Name = "KoyAdi";
            KoyAdi.ReadOnly = true;
            KoyAdi.Width = 150;
            // 
            // ImalatTuru
            // 
            ImalatTuru.HeaderText = "İmalat Türü";
            ImalatTuru.MinimumWidth = 8;
            ImalatTuru.Name = "ImalatTuru";
            ImalatTuru.ReadOnly = true;
            ImalatTuru.Width = 150;
            // 
            // Miktar
            // 
            Miktar.HeaderText = "Miktar";
            Miktar.MinimumWidth = 8;
            Miktar.Name = "Miktar";
            Miktar.ReadOnly = true;
            Miktar.Width = 150;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 221);
            label2.Name = "label2";
            label2.Size = new Size(171, 25);
            label2.TabIndex = 12;
            label2.Text = "Yatırım Programları :";
            // 
            // button1
            // 
            button1.Location = new Point(239, 221);
            button1.Name = "button1";
            button1.Size = new Size(165, 34);
            button1.TabIndex = 13;
            button1.Text = "Listeden Seç";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(479, 606);
            button2.Name = "button2";
            button2.Size = new Size(121, 51);
            button2.TabIndex = 14;
            button2.Text = "Kaydet";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(627, 606);
            button3.Name = "button3";
            button3.Size = new Size(121, 51);
            button3.TabIndex = 15;
            button3.Text = "İptal";
            button3.UseVisualStyleBackColor = true;
            // 
            // YeniProjeEkle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 669);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(txtProjeAdi);
            Controls.Add(label1);
            Name = "YeniProjeEkle";
            Text = "Yeni Proje Ekle";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProjeAdi;
        private Label label3;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn KoyAdi;
        private DataGridViewTextBoxColumn ImalatTuru;
        private DataGridViewTextBoxColumn Miktar;
    }
}