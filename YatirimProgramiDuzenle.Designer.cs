namespace WinFormsApp1
{
    partial class YatirimProgramiDuzenle
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblDurum = new Label();
            lblBirim = new Label();
            txtMiktar = new TextBox();
            btnDegistir = new Button();
            button1 = new Button();
            txtKoyler = new TextBox();
            txtImalat = new TextBox();
            txtIlce = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 29);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 0;
            label1.Text = "Durum : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 186);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 1;
            label2.Text = "İmalat : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 146);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 2;
            label3.Text = "Birim :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 107);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 3;
            label4.Text = "Köy / Köyler :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 67);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 4;
            label5.Text = "İlçe :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 228);
            label6.Name = "label6";
            label6.Size = new Size(76, 25);
            label6.TabIndex = 5;
            label6.Text = "Miktar : ";
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(167, 29);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(20, 25);
            lblDurum.TabIndex = 6;
            lblDurum.Text = "..";
            // 
            // lblBirim
            // 
            lblBirim.AutoSize = true;
            lblBirim.Location = new Point(167, 146);
            lblBirim.Name = "lblBirim";
            lblBirim.Size = new Size(20, 25);
            lblBirim.TabIndex = 9;
            lblBirim.Text = "..";
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(167, 225);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(150, 31);
            txtMiktar.TabIndex = 12;
            // 
            // btnDegistir
            // 
            btnDegistir.Location = new Point(167, 313);
            btnDegistir.Name = "btnDegistir";
            btnDegistir.Size = new Size(150, 40);
            btnDegistir.TabIndex = 13;
            btnDegistir.Text = "Değiştir";
            btnDegistir.UseVisualStyleBackColor = true;
            btnDegistir.Click += btnDegistir_Click;
            // 
            // button1
            // 
            button1.Location = new Point(362, 313);
            button1.Name = "button1";
            button1.Size = new Size(137, 40);
            button1.TabIndex = 14;
            button1.Text = "İptal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtKoyler
            // 
            txtKoyler.Location = new Point(168, 107);
            txtKoyler.Name = "txtKoyler";
            txtKoyler.Size = new Size(331, 31);
            txtKoyler.TabIndex = 15;
            // 
            // txtImalat
            // 
            txtImalat.Location = new Point(167, 186);
            txtImalat.Name = "txtImalat";
            txtImalat.Size = new Size(150, 31);
            txtImalat.TabIndex = 16;
            // 
            // txtIlce
            // 
            txtIlce.Location = new Point(168, 67);
            txtIlce.Name = "txtIlce";
            txtIlce.Size = new Size(150, 31);
            txtIlce.TabIndex = 17;
            // 
            // YatirimProgramiDuzenle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 550);
            Controls.Add(txtIlce);
            Controls.Add(txtImalat);
            Controls.Add(txtKoyler);
            Controls.Add(button1);
            Controls.Add(btnDegistir);
            Controls.Add(txtMiktar);
            Controls.Add(lblBirim);
            Controls.Add(lblDurum);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "YatirimProgramiDuzenle";
            Text = "Yatırım Programı Düzenle";
            FormClosing += YatirimProgramiDuzenle_FormClosing;
            Load += YatirimProgramiDuzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblDurum;
        private Label lblBirim;
        private TextBox txtMiktar;
        private Button btnDegistir;
        private Button button1;
        private TextBox txtKoyler;
        private TextBox txtImalat;
        private TextBox txtIlce;
    }
}