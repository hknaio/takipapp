namespace YatirimTakip
{
    partial class PersonelGuncelle
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
            label5 = new Label();
            chkIlce = new CheckedListBox();
            label4 = new Label();
            cmbRol = new ComboBox();
            cmbBirim = new ComboBox();
            label3 = new Label();
            txtSoyadi = new TextBox();
            label2 = new Label();
            txtAdi = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(360, 123);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 29;
            label5.Text = "İlçeler :";
            // 
            // chkIlce
            // 
            chkIlce.FormattingEnabled = true;
            chkIlce.Location = new Point(441, 123);
            chkIlce.Name = "chkIlce";
            chkIlce.Size = new Size(320, 340);
            chkIlce.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 123);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 27;
            label4.Text = "Rol :";
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Admin", "Yol", "Asfalt", "Sanat", "Su", "Tarımsal", "Rapor" });
            cmbRol.Location = new Point(74, 120);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(223, 33);
            cmbRol.TabIndex = 26;
            // 
            // cmbBirim
            // 
            cmbBirim.FormattingEnabled = true;
            cmbBirim.Items.AddRange(new object[] { "Yol ve Ulaşım Hizmetleri", "Tarımsal Hizmetler", "Su ve Kanal Hizmetleri" });
            cmbBirim.Location = new Point(784, 50);
            cmbBirim.Name = "cmbBirim";
            cmbBirim.Size = new Size(305, 33);
            cmbBirim.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(717, 56);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 24;
            label3.Text = "Birim :";
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(441, 50);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(223, 31);
            txtSoyadi.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 53);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 22;
            label2.Text = "Soyadı :";
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(74, 47);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(223, 31);
            txtAdi.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 47);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 20;
            label1.Text = "Adı :";
            // 
            // button1
            // 
            button1.Location = new Point(847, 410);
            button1.Name = "button1";
            button1.Size = new Size(127, 53);
            button1.TabIndex = 30;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // PersonelGuncelle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 659);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(chkIlce);
            Controls.Add(label4);
            Controls.Add(cmbRol);
            Controls.Add(cmbBirim);
            Controls.Add(label3);
            Controls.Add(txtSoyadi);
            Controls.Add(label2);
            Controls.Add(txtAdi);
            Controls.Add(label1);
            Name = "PersonelGuncelle";
            Text = "Personel Güncelle";
            FormClosing += PersonelGuncelle_FormClosing;
            Load += PersonelGuncelle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private CheckedListBox chkIlce;
        private Label label4;
        private ComboBox cmbRol;
        private ComboBox cmbBirim;
        private Label label3;
        private TextBox txtSoyadi;
        private Label label2;
        private TextBox txtAdi;
        private Label label1;
        private Button button1;
    }
}