namespace WinFormsApp1
{
    partial class YatirimUygulama
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label8 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            dataGridView2 = new DataGridView();
            No = new DataGridViewTextBoxColumn();
            HakedisMiktari = new DataGridViewTextBoxColumn();
            textBox3 = new TextBox();
            label9 = new Label();
            textBox4 = new TextBox();
            KoyAdi = new DataGridViewTextBoxColumn();
            ImalatTuru = new DataGridViewTextBoxColumn();
            YaklasikMaliyet = new DataGridViewTextBoxColumn();
            Yuklenici = new DataGridViewTextBoxColumn();
            Miktar = new DataGridViewTextBoxColumn();
            Uygulama = new DataGridViewTextBoxColumn();
            IhaleDurum = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { KoyAdi, ImalatTuru, YaklasikMaliyet, Yuklenici, Miktar, Uygulama, IhaleDurum });
            dataGridView1.Location = new Point(29, 487);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1120, 298);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 459);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 1;
            label1.Text = "Program Listesi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(14, 21);
            label2.Name = "label2";
            label2.Size = new Size(88, 32);
            label2.TabIndex = 2;
            label2.Text = "Proje1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(383, 21);
            label3.Name = "label3";
            label3.Size = new Size(133, 32);
            label3.TabIndex = 3;
            label3.Text = "630000,00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(173, 21);
            label4.Name = "label4";
            label4.Size = new Size(204, 32);
            label4.TabIndex = 4;
            label4.Text = "Sözleşme Bedeli:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(14, 71);
            label5.Name = "label5";
            label5.Size = new Size(155, 25);
            label5.TabIndex = 5;
            label5.Text = "Geçici Kabul Tarihi:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(175, 66);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(12, 126);
            label6.Name = "label6";
            label6.Size = new Size(151, 25);
            label6.TabIndex = 7;
            label6.Text = "Kesin Kabul Tarihi:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(175, 120);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(593, 66);
            label7.Name = "label7";
            label7.Size = new Size(86, 25);
            label7.TabIndex = 9;
            label7.Text = "Durumu :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Devam Ediyor", "Bitti", "Sonuçlandı" });
            comboBox1.Location = new Point(685, 63);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(593, 125);
            label8.Name = "label8";
            label8.Size = new Size(92, 25);
            label8.TabIndex = 11;
            label8.Text = "Açıklama :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(683, 127);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 89);
            textBox1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(723, 800);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 13;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(883, 800);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 14;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 30);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "0,00";
            textBox2.Size = new Size(62, 31);
            textBox2.TabIndex = 17;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button3.Location = new Point(227, 30);
            button3.Name = "button3";
            button3.Size = new Size(62, 57);
            button3.TabIndex = 18;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button4.Location = new Point(295, 30);
            button4.Name = "button4";
            button4.Size = new Size(66, 57);
            button4.TabIndex = 19;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Location = new Point(29, 229);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(600, 227);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hakediş Listesi";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { No, HakedisMiktari });
            dataGridView2.Location = new Point(6, 107);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(493, 114);
            dataGridView2.TabIndex = 21;
            // 
            // No
            // 
            No.HeaderText = "Hakediş";
            No.MinimumWidth = 8;
            No.Name = "No";
            No.ReadOnly = true;
            No.Width = 150;
            // 
            // HakedisMiktari
            // 
            HakedisMiktari.HeaderText = "Hakediş Miktarı";
            HakedisMiktari.MinimumWidth = 8;
            HakedisMiktari.Name = "HakedisMiktari";
            HakedisMiktari.ReadOnly = true;
            HakedisMiktari.Width = 150;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 30);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(130, 31);
            textBox3.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 176);
            label9.Name = "label9";
            label9.Size = new Size(119, 25);
            label9.TabIndex = 21;
            label9.Text = "Bitum Bedeli :";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(175, 176);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "0,00";
            textBox4.Size = new Size(300, 31);
            textBox4.TabIndex = 22;
            // 
            // KoyAdi
            // 
            KoyAdi.HeaderText = "Köy Adi ";
            KoyAdi.MinimumWidth = 8;
            KoyAdi.Name = "KoyAdi";
            KoyAdi.Width = 150;
            // 
            // ImalatTuru
            // 
            ImalatTuru.HeaderText = "İmalat Türü";
            ImalatTuru.MinimumWidth = 8;
            ImalatTuru.Name = "ImalatTuru";
            ImalatTuru.Width = 150;
            // 
            // YaklasikMaliyet
            // 
            YaklasikMaliyet.HeaderText = "YaklasikMaliyet";
            YaklasikMaliyet.MinimumWidth = 8;
            YaklasikMaliyet.Name = "YaklasikMaliyet";
            YaklasikMaliyet.Width = 150;
            // 
            // Yuklenici
            // 
            Yuklenici.HeaderText = "Yüklenici";
            Yuklenici.MinimumWidth = 8;
            Yuklenici.Name = "Yuklenici";
            Yuklenici.Width = 150;
            // 
            // Miktar
            // 
            Miktar.HeaderText = "Miktar";
            Miktar.MinimumWidth = 8;
            Miktar.Name = "Miktar";
            Miktar.Width = 150;
            // 
            // Uygulama
            // 
            Uygulama.HeaderText = "Uygulama";
            Uygulama.MinimumWidth = 8;
            Uygulama.Name = "Uygulama";
            Uygulama.Width = 150;
            // 
            // IhaleDurum
            // 
            IhaleDurum.HeaderText = "İhale Edildi";
            IhaleDurum.MinimumWidth = 8;
            IhaleDurum.Name = "IhaleDurum";
            IhaleDurum.Resizable = DataGridViewTriState.True;
            IhaleDurum.SortMode = DataGridViewColumnSortMode.Automatic;
            IhaleDurum.Width = 150;
            // 
            // YatirimUygulama
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 860);
            Controls.Add(textBox4);
            Controls.Add(label9);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(dateTimePicker2);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "YatirimUygulama";
            Text = "Yatırım Proje Uygulama";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private Label label7;
        private ComboBox comboBox1;
        private Label label8;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private Button button3;
        private Button button4;
        private GroupBox groupBox1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn HakedisMiktari;
        private TextBox textBox3;
        private Label label9;
        private TextBox textBox4;
        private DataGridViewTextBoxColumn KoyAdi;
        private DataGridViewTextBoxColumn ImalatTuru;
        private DataGridViewTextBoxColumn YaklasikMaliyet;
        private DataGridViewTextBoxColumn Yuklenici;
        private DataGridViewTextBoxColumn Miktar;
        private DataGridViewTextBoxColumn Uygulama;
        private DataGridViewCheckBoxColumn IhaleDurum;
    }
}