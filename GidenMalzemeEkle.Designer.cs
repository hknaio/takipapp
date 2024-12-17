namespace WinFormsApp1
{
    partial class GidenMalzemeEkle
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
            button2 = new Button();
            button1 = new Button();
            dtTarih = new DateTimePicker();
            label6 = new Label();
            txtYer = new MaskedTextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            cmbEvsaf = new ComboBox();
            txtDiger = new MaskedTextBox();
            txtxPersonel = new MaskedTextBox();
            txtMiktar = new MaskedTextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(623, 365);
            button2.Name = "button2";
            button2.Size = new Size(122, 51);
            button2.TabIndex = 49;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(417, 365);
            button1.Name = "button1";
            button1.Size = new Size(130, 51);
            button1.TabIndex = 48;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtTarih
            // 
            dtTarih.Location = new Point(299, 212);
            dtTarih.Name = "dtTarih";
            dtTarih.Size = new Size(300, 31);
            dtTarih.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 217);
            label6.Name = "label6";
            label6.Size = new Size(57, 25);
            label6.TabIndex = 50;
            label6.Text = "Tarih :";
            // 
            // txtYer
            // 
            txtYer.Location = new Point(299, 157);
            txtYer.Name = "txtYer";
            txtYer.Size = new Size(300, 31);
            txtYer.TabIndex = 53;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 163);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 52;
            label3.Text = "Gittiği Yer :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 109);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 54;
            label1.Text = "Talimat Veren :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 52);
            label2.Name = "label2";
            label2.Size = new Size(193, 25);
            label2.TabIndex = 56;
            label2.Text = "Giden Malzeme Evsafı :";
            // 
            // cmbEvsaf
            // 
            cmbEvsaf.FormattingEnabled = true;
            cmbEvsaf.Items.AddRange(new object[] { "Kırmataş", "BSK", "Asfalt", "CRS-1", "CRS-2", "Diğer" });
            cmbEvsaf.Location = new Point(299, 52);
            cmbEvsaf.Name = "cmbEvsaf";
            cmbEvsaf.Size = new Size(300, 33);
            cmbEvsaf.TabIndex = 57;
            cmbEvsaf.SelectedIndexChanged += cmbEvsaf_SelectedIndexChanged;
            // 
            // txtDiger
            // 
            txtDiger.Location = new Point(648, 52);
            txtDiger.Name = "txtDiger";
            txtDiger.Size = new Size(300, 31);
            txtDiger.TabIndex = 59;
            // 
            // txtxPersonel
            // 
            txtxPersonel.Location = new Point(299, 106);
            txtxPersonel.Name = "txtxPersonel";
            txtxPersonel.Size = new Size(300, 31);
            txtxPersonel.TabIndex = 60;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(299, 268);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(300, 31);
            txtMiktar.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 274);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 62;
            label4.Text = "Miktar :";
            // 
            // GidenMalzemeEkle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 481);
            Controls.Add(label4);
            Controls.Add(txtMiktar);
            Controls.Add(txtxPersonel);
            Controls.Add(txtDiger);
            Controls.Add(cmbEvsaf);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtYer);
            Controls.Add(label3);
            Controls.Add(dtTarih);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "GidenMalzemeEkle";
            Text = "Giden Malzeme Ekle";
            FormClosing += GidenMalzemeEkle_FormClosing;
            Load += GidenMalzemeEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private DateTimePicker dtTarih;
        private Label label6;
        private MaskedTextBox txtYer;
        private Label label3;
        private Label label1;
        private Label label2;
        private ComboBox cmbEvsaf;
        private MaskedTextBox txtDiger;
        private MaskedTextBox txtxPersonel;
        private MaskedTextBox txtMiktar;
        private Label label4;
    }
}