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
            txtKoy = new TextBox();
            label3 = new Label();
            cmbImalat = new ComboBox();
            label4 = new Label();
            txtMiktar = new TextBox();
            lblYil = new Label();
            lblKaynak = new Label();
            label5 = new Label();
            label6 = new Label();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 33);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 0;
            label1.Text = "İlçe :";
            // 
            // cmbIlce
            // 
            cmbIlce.FormattingEnabled = true;
            cmbIlce.Location = new Point(145, 30);
            cmbIlce.Name = "cmbIlce";
            cmbIlce.Size = new Size(202, 33);
            cmbIlce.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(417, 33);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 2;
            label2.Text = "Köy :";
            // 
            // txtKoy
            // 
            txtKoy.Location = new Point(512, 30);
            txtKoy.Name = "txtKoy";
            txtKoy.Size = new Size(343, 31);
            txtKoy.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 96);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 4;
            label3.Text = "İmalat :";
            // 
            // cmbImalat
            // 
            cmbImalat.FormattingEnabled = true;
            cmbImalat.Location = new Point(145, 93);
            cmbImalat.Name = "cmbImalat";
            cmbImalat.Size = new Size(202, 33);
            cmbImalat.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(417, 96);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 6;
            label4.Text = "Miktar :";
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(512, 93);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(170, 31);
            txtMiktar.TabIndex = 7;
            // 
            // lblYil
            // 
            lblYil.AutoSize = true;
            lblYil.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblYil.Location = new Point(145, 170);
            lblYil.Name = "lblYil";
            lblYil.Size = new Size(76, 30);
            lblYil.TabIndex = 8;
            lblYil.Text = "label5";
            // 
            // lblKaynak
            // 
            lblKaynak.AutoSize = true;
            lblKaynak.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblKaynak.Location = new Point(512, 170);
            lblKaynak.Name = "lblKaynak";
            lblKaynak.Size = new Size(76, 30);
            lblKaynak.TabIndex = 9;
            lblKaynak.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 174);
            label5.Name = "label5";
            label5.Size = new Size(39, 25);
            label5.TabIndex = 10;
            label5.Text = "Yıl :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(417, 170);
            label6.Name = "label6";
            label6.Size = new Size(77, 25);
            label6.TabIndex = 11;
            label6.Text = "Kaynak :";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(427, 259);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(142, 63);
            btnKaydet.TabIndex = 12;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // EkProgramEkle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 511);
            Controls.Add(btnKaydet);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblKaynak);
            Controls.Add(lblYil);
            Controls.Add(txtMiktar);
            Controls.Add(label4);
            Controls.Add(cmbImalat);
            Controls.Add(label3);
            Controls.Add(txtKoy);
            Controls.Add(label2);
            Controls.Add(cmbIlce);
            Controls.Add(label1);
            Name = "EkProgramEkle";
            Text = "Ek Program Ekle";
            FormClosing += EkProgramEkle_FormClosing;
            Load += EkProgramEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbIlce;
        private Label label2;
        private TextBox txtKoy;
        private Label label3;
        private ComboBox cmbImalat;
        private Label label4;
        private TextBox txtMiktar;
        private Label lblYil;
        private Label lblKaynak;
        private Label label5;
        private Label label6;
        private Button btnKaydet;
    }
}