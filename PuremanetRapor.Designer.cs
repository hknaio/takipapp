namespace YatirimTakip
{
    partial class PuremanetRapor
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
            Imalat = new DataGridViewTextBoxColumn();
            Tarih = new DataGridViewTextBoxColumn();
            Uygulama = new DataGridViewTextBoxColumn();
            Harcama = new DataGridViewTextBoxColumn();
            label1 = new Label();
            cmbYil = new ComboBox();
            cmbIlce = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            cmbKoy = new ComboBox();
            button1 = new Button();
            btnGetir = new Button();
            label3 = new Label();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { KoyMezra, Imalat, Tarih, Uygulama, Harcama });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(20, 59);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(1244, 434);
            dataGridView1.TabIndex = 46;
            // 
            // KoyMezra
            // 
            KoyMezra.DataPropertyName = "koyMezra";
            KoyMezra.HeaderText = "Köy / Mezra";
            KoyMezra.MinimumWidth = 8;
            KoyMezra.Name = "KoyMezra";
            KoyMezra.ReadOnly = true;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 55;
            label1.Text = "Yıl :";
            // 
            // cmbYil
            // 
            cmbYil.FormattingEnabled = true;
            cmbYil.Items.AddRange(new object[] { "2024", "2025", "2026", "2027", "2028", "2029", "2030" });
            cmbYil.Location = new Point(55, 20);
            cmbYil.Margin = new Padding(2, 2, 2, 2);
            cmbYil.Name = "cmbYil";
            cmbYil.Size = new Size(129, 23);
            cmbYil.TabIndex = 54;
            // 
            // cmbIlce
            // 
            cmbIlce.FormattingEnabled = true;
            cmbIlce.Items.AddRange(new object[] { "--" });
            cmbIlce.Location = new Point(265, 20);
            cmbIlce.Margin = new Padding(2, 2, 2, 2);
            cmbIlce.Name = "cmbIlce";
            cmbIlce.Size = new Size(148, 23);
            cmbIlce.TabIndex = 57;
            cmbIlce.SelectedIndexChanged += cmbIlce_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 22);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 56;
            label2.Text = "İlçe : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(449, 22);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 59;
            label4.Text = "Köy : ";
            // 
            // cmbKoy
            // 
            cmbKoy.FormattingEnabled = true;
            cmbKoy.Items.AddRange(new object[] { "Hepsi" });
            cmbKoy.Location = new Point(493, 20);
            cmbKoy.Margin = new Padding(2, 2, 2, 2);
            cmbKoy.Name = "cmbKoy";
            cmbKoy.Size = new Size(211, 23);
            cmbKoy.TabIndex = 58;
            // 
            // button1
            // 
            button1.Location = new Point(1155, 20);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(102, 20);
            button1.TabIndex = 61;
            button1.Text = "Excele Aktar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnGetir
            // 
            btnGetir.Location = new Point(1026, 19);
            btnGetir.Margin = new Padding(2, 2, 2, 2);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(125, 25);
            btnGetir.TabIndex = 60;
            btnGetir.Text = "Rapor Getir";
            btnGetir.UseVisualStyleBackColor = true;
            btnGetir.Click += btnGetir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(713, 22);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 63;
            label3.Text = "İmalat :";
            // 
            // cmbImalat
            // 
            cmbImalat.FormattingEnabled = true;
            cmbImalat.Items.AddRange(new object[] { "Hepsi" });
            cmbImalat.Location = new Point(774, 20);
            cmbImalat.Margin = new Padding(2, 2, 2, 2);
            cmbImalat.Name = "cmbImalat";
            cmbImalat.Size = new Size(211, 23);
            cmbImalat.TabIndex = 62;
            // 
            // PuremanetRapor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 526);
            Controls.Add(label3);
            Controls.Add(cmbImalat);
            Controls.Add(button1);
            Controls.Add(btnGetir);
            Controls.Add(label4);
            Controls.Add(cmbKoy);
            Controls.Add(cmbIlce);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbYil);
            Controls.Add(dataGridView1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "PuremanetRapor";
            Text = "Püremanet Rapor";
            FormClosing += PuremanetRapor_FormClosing;
            Load += PuremanetRapor_Load;
            Leave += PuremanetRapor_Leave;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn KoyMezra;
        private DataGridViewTextBoxColumn Imalat;
        private DataGridViewTextBoxColumn Tarih;
        private DataGridViewTextBoxColumn Uygulama;
        private DataGridViewTextBoxColumn Harcama;
        private Label label1;
        private ComboBox cmbYil;
        private ComboBox cmbIlce;
        private Label label2;
        private Label label4;
        private ComboBox cmbKoy;
        private Button button1;
        private Button btnGetir;
        private Label label3;
        private ComboBox cmbImalat;
    }
}