namespace WinFormsApp1
{
    partial class PurEmanetEkleTarimsal
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
            chkMezra = new CheckBox();
            chkMezraList = new CheckedListBox();
            cmbTalepEden = new ComboBox();
            label7 = new Label();
            cmbIsMakinesi = new ComboBox();
            label8 = new Label();
            cmbOperator = new ComboBox();
            label9 = new Label();
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
            label3.Location = new Point(45, 124);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 2;
            label3.Text = "Köy : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 192);
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
            cmbIlce.Location = new Point(113, 74);
            cmbIlce.Name = "cmbIlce";
            cmbIlce.Size = new Size(300, 33);
            cmbIlce.TabIndex = 5;
            cmbIlce.SelectedIndexChanged += cmbIlce_SelectedIndexChanged;
            // 
            // cmbKoy
            // 
            cmbKoy.FormattingEnabled = true;
            cmbKoy.Location = new Point(113, 124);
            cmbKoy.Name = "cmbKoy";
            cmbKoy.Size = new Size(300, 33);
            cmbKoy.TabIndex = 6;
            cmbKoy.SelectedIndexChanged += cmbKoy_SelectedIndexChanged;
            // 
            // cmbImalat
            // 
            cmbImalat.FormattingEnabled = true;
            cmbImalat.Location = new Point(121, 192);
            cmbImalat.Name = "cmbImalat";
            cmbImalat.Size = new Size(333, 33);
            cmbImalat.TabIndex = 7;
            cmbImalat.SelectedIndexChanged += cmbImalat_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 250);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 8;
            label5.Text = "Miktar : ";
            // 
            // button1
            // 
            button1.Location = new Point(436, 490);
            button1.Name = "button1";
            button1.Size = new Size(130, 51);
            button1.TabIndex = 10;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(642, 490);
            button2.Name = "button2";
            button2.Size = new Size(122, 51);
            button2.TabIndex = 11;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(121, 250);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(150, 31);
            txtMiktar.TabIndex = 12;
            // 
            // cmbSpiral
            // 
            cmbSpiral.FormattingEnabled = true;
            cmbSpiral.Location = new Point(212, 335);
            cmbSpiral.Name = "cmbSpiral";
            cmbSpiral.Size = new Size(96, 33);
            cmbSpiral.TabIndex = 13;
            // 
            // txtBoruMetre
            // 
            txtBoruMetre.Location = new Point(337, 335);
            txtBoruMetre.Name = "txtBoruMetre";
            txtBoruMetre.Size = new Size(142, 31);
            txtBoruMetre.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 338);
            label6.Name = "label6";
            label6.Size = new Size(161, 25);
            label6.TabIndex = 15;
            label6.Text = "Boru Çap / Miktar :";
            // 
            // chkMezra
            // 
            chkMezra.AutoSize = true;
            chkMezra.Location = new Point(456, 126);
            chkMezra.Name = "chkMezra";
            chkMezra.Size = new Size(86, 29);
            chkMezra.TabIndex = 16;
            chkMezra.Text = "Mezra";
            chkMezra.UseVisualStyleBackColor = true;
            chkMezra.CheckedChanged += chkMezra_CheckedChanged;
            // 
            // chkMezraList
            // 
            chkMezraList.FormattingEnabled = true;
            chkMezraList.Location = new Point(569, 124);
            chkMezraList.Name = "chkMezraList";
            chkMezraList.Size = new Size(313, 256);
            chkMezraList.TabIndex = 17;
            // 
            // cmbTalepEden
            // 
            cmbTalepEden.FormattingEnabled = true;
            cmbTalepEden.Items.AddRange(new object[] { "--" });
            cmbTalepEden.Location = new Point(630, 19);
            cmbTalepEden.Name = "cmbTalepEden";
            cmbTalepEden.Size = new Size(252, 33);
            cmbTalepEden.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(508, 22);
            label7.Name = "label7";
            label7.Size = new Size(105, 25);
            label7.TabIndex = 22;
            label7.Text = "Talep Eden :";
            // 
            // cmbIsMakinesi
            // 
            cmbIsMakinesi.FormattingEnabled = true;
            cmbIsMakinesi.Items.AddRange(new object[] { "--" });
            cmbIsMakinesi.Location = new Point(630, 74);
            cmbIsMakinesi.Name = "cmbIsMakinesi";
            cmbIsMakinesi.Size = new Size(252, 33);
            cmbIsMakinesi.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(508, 77);
            label8.Name = "label8";
            label8.Size = new Size(108, 25);
            label8.TabIndex = 24;
            label8.Text = "İş Makinesi :";
            // 
            // cmbOperator
            // 
            cmbOperator.FormattingEnabled = true;
            cmbOperator.Items.AddRange(new object[] { "--" });
            cmbOperator.Location = new Point(1041, 19);
            cmbOperator.Name = "cmbOperator";
            cmbOperator.Size = new Size(215, 33);
            cmbOperator.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(917, 22);
            label9.Name = "label9";
            label9.Size = new Size(93, 25);
            label9.TabIndex = 26;
            label9.Text = "Operatör :";
            // 
            // PurEmanetEkleTarimsal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 629);
            Controls.Add(cmbOperator);
            Controls.Add(label9);
            Controls.Add(cmbIsMakinesi);
            Controls.Add(label8);
            Controls.Add(cmbTalepEden);
            Controls.Add(label7);
            Controls.Add(chkMezraList);
            Controls.Add(chkMezra);
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
            Name = "PurEmanetEkleTarimsal";
            Text = "Pür Emanet Ekle";
            Load += PurEmanetEkleTarimsal_Load;
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
        private CheckBox chkMezra;
        private CheckedListBox chkMezraList;
        private ComboBox cmbTalepEden;
        private Label label7;
        private ComboBox cmbIsMakinesi;
        private Label label8;
        private ComboBox cmbOperator;
        private Label label9;
    }
}