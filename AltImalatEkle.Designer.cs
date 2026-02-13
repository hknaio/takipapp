namespace YatirimTakip
{
    partial class AltImalatEkle
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
            cmbAltImalat = new ComboBox();
            lblAltImalat = new Label();
            btnKaydet = new Button();
            txtFiyat = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtMiktar = new TextBox();
            SuspendLayout();
            // 
            // cmbAltImalat
            // 
            cmbAltImalat.FormattingEnabled = true;
            cmbAltImalat.Items.AddRange(new object[] { "İŞ 1 ", "İŞ 2 ", "İŞ 3 ", "İŞ 4" });
            cmbAltImalat.Location = new Point(100, 43);
            cmbAltImalat.Name = "cmbAltImalat";
            cmbAltImalat.Size = new Size(162, 23);
            cmbAltImalat.TabIndex = 0;
            // 
            // lblAltImalat
            // 
            lblAltImalat.AutoSize = true;
            lblAltImalat.Location = new Point(30, 46);
            lblAltImalat.Name = "lblAltImalat";
            lblAltImalat.Size = new Size(64, 15);
            lblAltImalat.TabIndex = 1;
            lblAltImalat.Text = "Alt İmalat :";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(215, 249);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(92, 31);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(100, 121);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(120, 23);
            txtFiyat.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 124);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "Fiyat :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 84);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 6;
            label2.Text = "Miktar ";
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(100, 81);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(120, 23);
            txtMiktar.TabIndex = 5;
            // 
            // AltImalatEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 326);
            Controls.Add(label2);
            Controls.Add(txtMiktar);
            Controls.Add(label1);
            Controls.Add(txtFiyat);
            Controls.Add(btnKaydet);
            Controls.Add(lblAltImalat);
            Controls.Add(cmbAltImalat);
            Name = "AltImalatEkle";
            Text = "Alt İmalat Ekle";
            Load += AltImalatEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAltImalat;
        private Label lblAltImalat;
        private Button btnKaydet;
        private TextBox txtFiyat;
        private Label label1;
        private Label label2;
        private TextBox txtMiktar;
    }
}