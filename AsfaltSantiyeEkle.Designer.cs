namespace WinFormsApp1
{
    partial class AsfaltSantiyeEkle
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
            dtTarih = new DateTimePicker();
            label6 = new Label();
            txtTon = new MaskedTextBox();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            cmbKoy = new ComboBox();
            cmbIlce = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            cmbMezra = new ComboBox();
            chkMezra = new CheckBox();
            SuspendLayout();
            // 
            // dtTarih
            // 
            dtTarih.Location = new Point(129, 46);
            dtTarih.Name = "dtTarih";
            dtTarih.Size = new Size(300, 31);
            dtTarih.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 51);
            label6.Name = "label6";
            label6.Size = new Size(57, 25);
            label6.TabIndex = 27;
            label6.Text = "Tarih :";
            // 
            // txtTon
            // 
            txtTon.Location = new Point(129, 198);
            txtTon.Name = "txtTon";
            txtTon.Size = new Size(300, 31);
            txtTon.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 201);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 44;
            label4.Text = "Ton :";
            // 
            // button2
            // 
            button2.Location = new Point(625, 307);
            button2.Name = "button2";
            button2.Size = new Size(122, 51);
            button2.TabIndex = 47;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(407, 307);
            button1.Name = "button1";
            button1.Size = new Size(130, 51);
            button1.TabIndex = 46;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmbKoy
            // 
            cmbKoy.FormattingEnabled = true;
            cmbKoy.Location = new Point(129, 146);
            cmbKoy.Name = "cmbKoy";
            cmbKoy.Size = new Size(300, 33);
            cmbKoy.TabIndex = 51;
            cmbKoy.SelectedIndexChanged += cmbKoy_SelectedIndexChanged;
            // 
            // cmbIlce
            // 
            cmbIlce.FormattingEnabled = true;
            cmbIlce.Items.AddRange(new object[] { "--" });
            cmbIlce.Location = new Point(129, 96);
            cmbIlce.Name = "cmbIlce";
            cmbIlce.Size = new Size(300, 33);
            cmbIlce.TabIndex = 50;
            cmbIlce.SelectedIndexChanged += cmbIlce_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 146);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 49;
            label3.Text = "Köy : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 96);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 48;
            label2.Text = "İlçe : ";
            // 
            // cmbMezra
            // 
            cmbMezra.FormattingEnabled = true;
            cmbMezra.Location = new Point(558, 146);
            cmbMezra.Name = "cmbMezra";
            cmbMezra.Size = new Size(300, 33);
            cmbMezra.TabIndex = 53;
            // 
            // chkMezra
            // 
            chkMezra.AutoSize = true;
            chkMezra.Location = new Point(466, 148);
            chkMezra.Name = "chkMezra";
            chkMezra.Size = new Size(86, 29);
            chkMezra.TabIndex = 54;
            chkMezra.Text = "Mezra";
            chkMezra.UseVisualStyleBackColor = true;
            chkMezra.CheckedChanged += chkMezra_CheckedChanged;
            // 
            // AsfaltSantiyeEkle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 479);
            Controls.Add(chkMezra);
            Controls.Add(cmbMezra);
            Controls.Add(cmbKoy);
            Controls.Add(cmbIlce);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtTon);
            Controls.Add(label4);
            Controls.Add(dtTarih);
            Controls.Add(label6);
            Name = "AsfaltSantiyeEkle";
            Text = "Asfalt Şantiye Ekle";
            FormClosing += AsfaltSantiyeEkle_FormClosing;
            Load += AsfaltSantiyeEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtTarih;
        private Label label6;
        private MaskedTextBox txtTon;
        private Label label4;
        private Button button2;
        private Button button1;
        private ComboBox cmbKoy;
        private ComboBox cmbIlce;
        private Label label3;
        private Label label2;
        private ComboBox cmbMezra;
        private CheckBox chkMezra;
    }
}