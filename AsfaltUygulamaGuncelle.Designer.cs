namespace WinFormsApp1
{
    partial class AsfaltUygulamaGuncelle
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
            label2 = new Label();
            label1 = new Label();
            txtUygulama = new MaskedTextBox();
            Uygulama = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpBaslangicTarihi = new DateTimePicker();
            dtpBitisTarihi = new DateTimePicker();
            btnKaydet = new Button();
            btnIptal = new Button();
            txtSure = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 51);
            label2.Name = "label2";
            label2.Size = new Size(20, 25);
            label2.TabIndex = 3;
            label2.Text = "..";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 51);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 2;
            label1.Text = "Program : ";
            // 
            // txtUygulama
            // 
            txtUygulama.Location = new Point(185, 94);
            txtUygulama.Name = "txtUygulama";
            txtUygulama.Size = new Size(150, 31);
            txtUygulama.TabIndex = 6;
            // 
            // Uygulama
            // 
            Uygulama.AutoSize = true;
            Uygulama.Location = new Point(40, 97);
            Uygulama.Name = "Uygulama";
            Uygulama.Size = new Size(101, 25);
            Uygulama.TabIndex = 5;
            Uygulama.Text = "Uygulama :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 232);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 7;
            label3.Text = "Bitiş Tarihi :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 145);
            label4.Name = "label4";
            label4.Size = new Size(139, 25);
            label4.TabIndex = 8;
            label4.Text = "Başlangıç Tarihi :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 188);
            label5.Name = "label5";
            label5.Size = new Size(56, 25);
            label5.TabIndex = 9;
            label5.Text = "Süre :";
            // 
            // dtpBaslangicTarihi
            // 
            dtpBaslangicTarihi.Location = new Point(185, 145);
            dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            dtpBaslangicTarihi.Size = new Size(300, 31);
            dtpBaslangicTarihi.TabIndex = 11;
            // 
            // dtpBitisTarihi
            // 
            dtpBitisTarihi.Location = new Point(185, 226);
            dtpBitisTarihi.Name = "dtpBitisTarihi";
            dtpBitisTarihi.Size = new Size(300, 31);
            dtpBitisTarihi.TabIndex = 12;
            dtpBitisTarihi.ValueChanged += dtpBitisTarihi_ValueChanged;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(344, 309);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(141, 49);
            btnKaydet.TabIndex = 13;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(562, 309);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(141, 49);
            btnIptal.TabIndex = 14;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // txtSure
            // 
            txtSure.Location = new Point(185, 185);
            txtSure.Name = "txtSure";
            txtSure.Size = new Size(150, 31);
            txtSure.TabIndex = 15;
            txtSure.TextChanged += txtSure_TextChanged;
            // 
            // AsfaltUygulamaGuncelle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSure);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(dtpBitisTarihi);
            Controls.Add(dtpBaslangicTarihi);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtUygulama);
            Controls.Add(Uygulama);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AsfaltUygulamaGuncelle";
            Text = "Asfalt Uygulama Güncelle";
            FormClosing += AsfaltUygulamaGuncelle_FormClosing;
            Load += AsfaltUygulamaGuncelle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private MaskedTextBox txtUygulama;
        private Label Uygulama;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpBaslangicTarihi;
        private DateTimePicker dtpBitisTarihi;
        private Button btnKaydet;
        private Button btnIptal;
        private TextBox txtSure;
    }
}