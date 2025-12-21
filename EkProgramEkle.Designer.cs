namespace WinFormsApp1
{
    partial class EkProgramEkle
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
            cmbIlce = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cmbImalat = new ComboBox();
            label4 = new Label();
            txtMiktar = new TextBox();
            lblYil = new Label();
            lblKaynak = new Label();
            label5 = new Label();
            label6 = new Label();
            btnKaydet = new Button();
            cmbBirim = new ComboBox();
            label7 = new Label();
            cmbKoy = new ComboBox();
            cmbProgram = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "İlçe :";
            // 
            // cmbIlce
            // 
            cmbIlce.FormattingEnabled = true;
            cmbIlce.Location = new Point(102, 18);
            cmbIlce.Margin = new Padding(2);
            cmbIlce.Name = "cmbIlce";
            cmbIlce.Size = new Size(143, 23);
            cmbIlce.TabIndex = 1;
            cmbIlce.SelectedIndexChanged += cmbIlce_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 20);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "Köy :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 58);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 4;
            label3.Text = "İmalat :";
            // 
            // cmbImalat
            // 
            cmbImalat.FormattingEnabled = true;
            cmbImalat.Location = new Point(102, 56);
            cmbImalat.Margin = new Padding(2);
            cmbImalat.Name = "cmbImalat";
            cmbImalat.Size = new Size(143, 23);
            cmbImalat.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(292, 58);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 6;
            label4.Text = "Miktar :";
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(358, 56);
            txtMiktar.Margin = new Padding(2);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(120, 23);
            txtMiktar.TabIndex = 7;
            // 
            // lblYil
            // 
            lblYil.AutoSize = true;
            lblYil.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblYil.Location = new Point(102, 125);
            lblYil.Margin = new Padding(2, 0, 2, 0);
            lblYil.Name = "lblYil";
            lblYil.Size = new Size(51, 20);
            lblYil.TabIndex = 8;
            lblYil.Text = "label5";
            // 
            // lblKaynak
            // 
            lblKaynak.AutoSize = true;
            lblKaynak.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblKaynak.Location = new Point(358, 125);
            lblKaynak.Margin = new Padding(2, 0, 2, 0);
            lblKaynak.Name = "lblKaynak";
            lblKaynak.Size = new Size(51, 20);
            lblKaynak.TabIndex = 9;
            lblKaynak.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 128);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 10;
            label5.Text = "Yıl :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(292, 125);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 11;
            label6.Text = "Kaynak :";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(299, 190);
            btnKaydet.Margin = new Padding(2);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(99, 38);
            btnKaydet.TabIndex = 12;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // cmbBirim
            // 
            cmbBirim.FormattingEnabled = true;
            cmbBirim.Items.AddRange(new object[] { "Yol ve Ulaşım Hizmetleri", "Tarımsal Hizmetler", "Su ve Kanalizasyon Hizmetleri" });
            cmbBirim.Location = new Point(102, 90);
            cmbBirim.Margin = new Padding(2);
            cmbBirim.Name = "cmbBirim";
            cmbBirim.Size = new Size(215, 23);
            cmbBirim.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 95);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 27;
            label7.Text = "Müdürlük :";
            // 
            // cmbKoy
            // 
            cmbKoy.FormattingEnabled = true;
            cmbKoy.Location = new Point(349, 17);
            cmbKoy.Margin = new Padding(2);
            cmbKoy.Name = "cmbKoy";
            cmbKoy.Size = new Size(211, 23);
            cmbKoy.TabIndex = 52;
            // 
            // cmbProgram
            // 
            cmbProgram.FormattingEnabled = true;
            cmbProgram.Items.AddRange(new object[] { "Ana Program", "Ek Program" });
            cmbProgram.Location = new Point(357, 90);
            cmbProgram.Name = "cmbProgram";
            cmbProgram.Size = new Size(121, 23);
            cmbProgram.TabIndex = 53;
            // 
            // EkProgramEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 307);
            Controls.Add(cmbProgram);
            Controls.Add(cmbKoy);
            Controls.Add(label7);
            Controls.Add(cmbBirim);
            Controls.Add(btnKaydet);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblKaynak);
            Controls.Add(lblYil);
            Controls.Add(txtMiktar);
            Controls.Add(label4);
            Controls.Add(cmbImalat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbIlce);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "EkProgramEkle";
            Text = "Program Ekle";
            FormClosing += EkProgramEkle_FormClosing;
            Load += EkProgramEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbIlce;
        private Label label2;
        private Label label3;
        private ComboBox cmbImalat;
        private Label label4;
        private TextBox txtMiktar;
        private Label lblYil;
        private Label lblKaynak;
        private Label label5;
        private Label label6;
        private Button btnKaydet;
        private ComboBox cmbBirim;
        private Label label7;
        private ComboBox cmbKoy;
        private ComboBox cmbProgram;
    }
}