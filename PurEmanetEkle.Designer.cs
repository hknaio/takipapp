namespace WinFormsApp1
{
    partial class PurEmanetEkle
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
            dtTarih = new DateTimePicker();
            cmbIlce = new ComboBox();
            cmbKoy = new ComboBox();
            cmbImalat = new ComboBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            txtMiktar = new MaskedTextBox();
            cmbSpiral = new ComboBox();
            txtBoruMetre = new MaskedTextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 22);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 0;
            label1.Text = "Tarih : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 74);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 1;
            label2.Text = "İlçe : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(455, 74);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 2;
            label3.Text = "Köy : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 143);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 3;
            label4.Text = "İmalat :";
            // 
            // dtTarih
            // 
            dtTarih.Location = new Point(113, 22);
            dtTarih.Name = "dtTarih";
            dtTarih.Size = new Size(300, 31);
            dtTarih.TabIndex = 4;
            // 
            // cmbIlce
            // 
            cmbIlce.FormattingEnabled = true;
            cmbIlce.Location = new Point(167, 71);
            cmbIlce.Name = "cmbIlce";
            cmbIlce.Size = new Size(246, 33);
            cmbIlce.TabIndex = 5;
            cmbIlce.SelectedIndexChanged += cmbIlce_SelectedIndexChanged;
            // 
            // cmbKoy
            // 
            cmbKoy.FormattingEnabled = true;
            cmbKoy.Location = new Point(542, 66);
            cmbKoy.Name = "cmbKoy";
            cmbKoy.Size = new Size(277, 33);
            cmbKoy.TabIndex = 6;
            // 
            // cmbImalat
            // 
            cmbImalat.FormattingEnabled = true;
            cmbImalat.Location = new Point(167, 137);
            cmbImalat.Name = "cmbImalat";
            cmbImalat.Size = new Size(246, 33);
            cmbImalat.TabIndex = 7;
            cmbImalat.SelectedIndexChanged += cmbImalat_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(455, 137);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 8;
            label5.Text = "Miktar : ";
            // 
            // button1
            // 
            button1.Location = new Point(455, 288);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(620, 288);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 11;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(542, 137);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(150, 31);
            txtMiktar.TabIndex = 12;
            // 
            // cmbSpiral
            // 
            cmbSpiral.FormattingEnabled = true;
            cmbSpiral.Location = new Point(196, 200);
            cmbSpiral.Name = "cmbSpiral";
            cmbSpiral.Size = new Size(96, 33);
            cmbSpiral.TabIndex = 13;
            // 
            // txtBoruMetre
            // 
            txtBoruMetre.Location = new Point(312, 200);
            txtBoruMetre.Name = "txtBoruMetre";
            txtBoruMetre.Size = new Size(101, 31);
            txtBoruMetre.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 206);
            label6.Name = "label6";
            label6.Size = new Size(161, 25);
            label6.TabIndex = 15;
            label6.Text = "Boru Çap / Miktar :";
            // 
            // PurEmanetEkle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 366);
            Controls.Add(label6);
            Controls.Add(txtBoruMetre);
            Controls.Add(cmbSpiral);
            Controls.Add(txtMiktar);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(cmbImalat);
            Controls.Add(cmbKoy);
            Controls.Add(cmbIlce);
            Controls.Add(dtTarih);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PurEmanetEkle";
            Text = "PurEmanetEkle";
            Load += PurEmanetEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtTarih;
        private ComboBox cmbIlce;
        private ComboBox cmbKoy;
        private ComboBox cmbImalat;
        private Label label5;
        private Button button1;
        private Button button2;
        private MaskedTextBox txtMiktar;
        private ComboBox cmbSpiral;
        private MaskedTextBox txtBoruMetre;
        private Label label6;
    }
}