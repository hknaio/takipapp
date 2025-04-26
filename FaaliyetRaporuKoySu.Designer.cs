namespace WinFormsApp1
{
    partial class FaaliyetRaporuKoySu
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            KoyMezra = new DataGridViewTextBoxColumn();
            Program = new DataGridViewTextBoxColumn();
            Imalat = new DataGridViewTextBoxColumn();
            Tarih = new DataGridViewTextBoxColumn();
            Uygulama = new DataGridViewTextBoxColumn();
            Harcama = new DataGridViewTextBoxColumn();
            cmbYil = new ComboBox();
            btnGetir = new Button();
            cmbIlce = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            cmbKoy = new ComboBox();
            label4 = new Label();
            cmbKaynak = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            cmbImalat = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { KoyMezra, Program, Imalat, Tarih, Uygulama, Harcama });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(9, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(1914, 723);
            dataGridView1.TabIndex = 45;
            // 
            // KoyMezra
            // 
            KoyMezra.DataPropertyName = "koyMezra";
            KoyMezra.HeaderText = "Köy / Mezra";
            KoyMezra.MinimumWidth = 8;
            KoyMezra.Name = "KoyMezra";
            KoyMezra.ReadOnly = true;
            // 
            // Program
            // 
            Program.DataPropertyName = "program";
            Program.HeaderText = "Program";
            Program.MinimumWidth = 8;
            Program.Name = "Program";
            Program.ReadOnly = true;
            // 
            // Imalat
            // 
            Imalat.DataPropertyName = "imalat";
            Imalat.HeaderText = "Imalat";
            Imalat.MinimumWidth = 8;
            Imalat.Name = "Imalat";
            Imalat.ReadOnly = true;
            // 
            // Tarih
            // 
            Tarih.DataPropertyName = "Tarih";
            Tarih.HeaderText = "Tarih";
            Tarih.MinimumWidth = 8;
            Tarih.Name = "Tarih";
            Tarih.ReadOnly = true;
            // 
            // Uygulama
            // 
            Uygulama.DataPropertyName = "miktarUygulama";
            Uygulama.HeaderText = "Uygulama Miktarı";
            Uygulama.MinimumWidth = 8;
            Uygulama.Name = "Uygulama";
            Uygulama.ReadOnly = true;
            // 
            // Harcama
            // 
            Harcama.DataPropertyName = "harcama";
            Harcama.HeaderText = "Harcama";
            Harcama.MinimumWidth = 8;
            Harcama.Name = "Harcama";
            Harcama.ReadOnly = true;
            // 
            // cmbYil
            // 
            cmbYil.FormattingEnabled = true;
            cmbYil.Items.AddRange(new object[] { "2022", "2023", "2024", "2025", "2026" });
            cmbYil.Location = new Point(64, 28);
            cmbYil.Name = "cmbYil";
            cmbYil.Size = new Size(182, 33);
            cmbYil.TabIndex = 49;
            // 
            // btnGetir
            // 
            btnGetir.Location = new Point(1501, 23);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(179, 41);
            btnGetir.TabIndex = 48;
            btnGetir.Text = "Rapor Getir";
            btnGetir.UseVisualStyleBackColor = true;
            btnGetir.Click += btnGetir_Click;
            // 
            // cmbIlce
            // 
            cmbIlce.FormattingEnabled = true;
            cmbIlce.Items.AddRange(new object[] { "--" });
            cmbIlce.Location = new Point(328, 28);
            cmbIlce.Name = "cmbIlce";
            cmbIlce.Size = new Size(210, 33);
            cmbIlce.TabIndex = 52;
            cmbIlce.SelectedIndexChanged += cmbIlce_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 31);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 51;
            label2.Text = "İlçe : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 31);
            label1.Name = "label1";
            label1.Size = new Size(39, 25);
            label1.TabIndex = 53;
            label1.Text = "Yıl :";
            // 
            // button1
            // 
            button1.Location = new Point(1686, 27);
            button1.Name = "button1";
            button1.Size = new Size(146, 34);
            button1.TabIndex = 54;
            button1.Text = "Excele Aktar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmbKoy
            // 
            cmbKoy.FormattingEnabled = true;
            cmbKoy.Items.AddRange(new object[] { "Hepsi" });
            cmbKoy.Location = new Point(616, 28);
            cmbKoy.Name = "cmbKoy";
            cmbKoy.Size = new Size(300, 33);
            cmbKoy.TabIndex = 56;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(554, 31);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 57;
            label4.Text = "Köy : ";
            // 
            // cmbKaynak
            // 
            cmbKaynak.FormattingEnabled = true;
            cmbKaynak.Items.AddRange(new object[] { "Hepsi", "İl Özel İdaresi", "KÖYDES", "İlbank", "Diğer" });
            cmbKaynak.Location = new Point(1011, 29);
            cmbKaynak.Name = "cmbKaynak";
            cmbKaynak.Size = new Size(182, 33);
            cmbKaynak.TabIndex = 59;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(937, 32);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 58;
            label3.Text = "Kaynak :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1199, 32);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 64;
            label5.Text = "İmalat :";
            // 
            // cmbImalat
            // 
            cmbImalat.FormattingEnabled = true;
            cmbImalat.Items.AddRange(new object[] { "Hepsi" });
            cmbImalat.Location = new Point(1275, 31);
            cmbImalat.Name = "cmbImalat";
            cmbImalat.Size = new Size(220, 33);
            cmbImalat.TabIndex = 65;
            // 
            // FaaliyetRaporuKoySu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 810);
            Controls.Add(cmbImalat);
            Controls.Add(label5);
            Controls.Add(cmbKaynak);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(cmbKoy);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(cmbIlce);
            Controls.Add(label2);
            Controls.Add(cmbYil);
            Controls.Add(btnGetir);
            Controls.Add(dataGridView1);
            Name = "FaaliyetRaporuKoySu";
            Text = "Faaliyet Raporu (Köy)";
            FormClosing += FaaliyetRaporuKoySu_FormClosing;
            Load += FaaliyetRaporuKoySu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cmbYil;
        private Button btnGetir;
        private ComboBox cmbIlce;
        private Label label2;
        private Label label1;
        private Button button1;
        private DataGridViewTextBoxColumn KoyMezra;
        private DataGridViewTextBoxColumn Program;
        private DataGridViewTextBoxColumn Imalat;
        private DataGridViewTextBoxColumn Tarih;
        private DataGridViewTextBoxColumn Uygulama;
        private DataGridViewTextBoxColumn Harcama;
        private ComboBox cmbKoy;
        private Label label4;
        private ComboBox cmbKaynak;
        private Label label3;
        private Label label5;
        private ComboBox cmbImalat;
    }
}