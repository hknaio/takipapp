namespace WinFormsApp1
{
    partial class ParkeBordurEkle
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
            txtMiktar = new MaskedTextBox();
            label5 = new Label();
            lblBirim = new Label();
            label2 = new Label();
            cmbKoy = new ComboBox();
            label3 = new Label();
            cmbIlce = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            dtTarih = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            txtPlaka = new TextBox();
            button2 = new Button();
            button1 = new Button();
            txtPersonel = new TextBox();
            SuspendLayout();
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(169, 39);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(150, 31);
            txtMiktar.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 39);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 13;
            label5.Text = "Miktar : ";
            // 
            // lblBirim
            // 
            lblBirim.AutoSize = true;
            lblBirim.Location = new Point(445, 39);
            lblBirim.Name = "lblBirim";
            lblBirim.Size = new Size(24, 25);
            lblBirim.TabIndex = 15;
            lblBirim.Text = "...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(364, 39);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 16;
            label2.Text = "Birim : ";
            // 
            // cmbKoy
            // 
            cmbKoy.FormattingEnabled = true;
            cmbKoy.Location = new Point(169, 148);
            cmbKoy.Name = "cmbKoy";
            cmbKoy.Size = new Size(300, 33);
            cmbKoy.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 148);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 17;
            label3.Text = "Köy : ";
            // 
            // cmbIlce
            // 
            cmbIlce.FormattingEnabled = true;
            cmbIlce.Location = new Point(169, 93);
            cmbIlce.Name = "cmbIlce";
            cmbIlce.Size = new Size(300, 33);
            cmbIlce.TabIndex = 20;
            cmbIlce.SelectedIndexChanged += cmbIlce_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 93);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 19;
            label1.Text = "İlçe : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 210);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 21;
            label4.Text = "Talep Eden :";
            // 
            // dtTarih
            // 
            dtTarih.Location = new Point(169, 261);
            dtTarih.Name = "dtTarih";
            dtTarih.Size = new Size(300, 31);
            dtTarih.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 261);
            label6.Name = "label6";
            label6.Size = new Size(110, 25);
            label6.TabIndex = 23;
            label6.Text = "Gidiş Tarihi : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 313);
            label7.Name = "label7";
            label7.Size = new Size(102, 25);
            label7.TabIndex = 25;
            label7.Text = "Araç Plaka :";
            // 
            // txtPlaka
            // 
            txtPlaka.Location = new Point(167, 314);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(302, 31);
            txtPlaka.TabIndex = 26;
            // 
            // button2
            // 
            button2.Location = new Point(570, 428);
            button2.Name = "button2";
            button2.Size = new Size(122, 51);
            button2.TabIndex = 28;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(364, 428);
            button1.Name = "button1";
            button1.Size = new Size(130, 51);
            button1.TabIndex = 27;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtPersonel
            // 
            txtPersonel.Location = new Point(167, 207);
            txtPersonel.Name = "txtPersonel";
            txtPersonel.Size = new Size(302, 31);
            txtPersonel.TabIndex = 29;
            // 
            // ParkeBordurEkle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 571);
            Controls.Add(txtPersonel);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPlaka);
            Controls.Add(label7);
            Controls.Add(dtTarih);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(cmbIlce);
            Controls.Add(label1);
            Controls.Add(cmbKoy);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblBirim);
            Controls.Add(txtMiktar);
            Controls.Add(label5);
            Name = "ParkeBordurEkle";
            Text = "Parke Bordür Ekle";
            FormClosing += ParkeBordurEkle_FormClosing;
            Load += ParkeBordurEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtMiktar;
        private Label label5;
        private Label lblBirim;
        private Label label2;
        private ComboBox cmbKoy;
        private Label label3;
        private ComboBox cmbIlce;
        private Label label1;
        private Label label4;
        private DateTimePicker dtTarih;
        private Label label6;
        private Label label7;
        private TextBox txtPlaka;
        private Button button2;
        private Button button1;
        private TextBox txtPersonel;
    }
}