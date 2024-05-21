namespace WinFormsApp1
{
    partial class TuprasMalzemeEkle
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
            dtTarih = new DateTimePicker();
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            label7 = new Label();
            txtSiparis = new MaskedTextBox();
            txtTupras = new MaskedTextBox();
            txtOzelIdare = new MaskedTextBox();
            txtFark = new MaskedTextBox();
            txtTartim = new MaskedTextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 44);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 21;
            label1.Text = "Tür :";
            // 
            // dtTarih
            // 
            dtTarih.Location = new Point(198, 95);
            dtTarih.Name = "dtTarih";
            dtTarih.Size = new Size(300, 31);
            dtTarih.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 95);
            label6.Name = "label6";
            label6.Size = new Size(57, 25);
            label6.TabIndex = 25;
            label6.Text = "Tarih :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 325);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 27;
            label2.Text = "Fark :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 232);
            label3.Name = "label3";
            label3.Size = new Size(148, 25);
            label3.TabIndex = 28;
            label3.Text = "İl Özel İdare Net :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 190);
            label4.Name = "label4";
            label4.Size = new Size(107, 25);
            label4.TabIndex = 29;
            label4.Text = "Tüpraş Net :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 144);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 30;
            label5.Text = "Sipariş No :";
            // 
            // button2
            // 
            button2.Location = new Point(607, 370);
            button2.Name = "button2";
            button2.Size = new Size(122, 51);
            button2.TabIndex = 32;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(401, 370);
            button1.Name = "button1";
            button1.Size = new Size(130, 51);
            button1.TabIndex = 31;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(198, 44);
            label7.Name = "label7";
            label7.Size = new Size(20, 25);
            label7.TabIndex = 33;
            label7.Text = "..";
            // 
            // txtSiparis
            // 
            txtSiparis.Location = new Point(198, 138);
            txtSiparis.Name = "txtSiparis";
            txtSiparis.Size = new Size(150, 31);
            txtSiparis.TabIndex = 34;
            // 
            // txtTupras
            // 
            txtTupras.Location = new Point(198, 184);
            txtTupras.Name = "txtTupras";
            txtTupras.Size = new Size(150, 31);
            txtTupras.TabIndex = 35;
            // 
            // txtOzelIdare
            // 
            txtOzelIdare.Location = new Point(198, 229);
            txtOzelIdare.Name = "txtOzelIdare";
            txtOzelIdare.Size = new Size(150, 31);
            txtOzelIdare.TabIndex = 36;
            // 
            // txtFark
            // 
            txtFark.Location = new Point(198, 325);
            txtFark.Name = "txtFark";
            txtFark.Size = new Size(150, 31);
            txtFark.TabIndex = 37;
            // 
            // txtTartim
            // 
            txtTartim.Location = new Point(198, 279);
            txtTartim.Name = "txtTartim";
            txtTartim.Size = new Size(150, 31);
            txtTartim.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(45, 282);
            label8.Name = "label8";
            label8.Size = new Size(98, 25);
            label8.TabIndex = 38;
            label8.Text = "Tartım No :";
            // 
            // TuprasMalzemeEkle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 488);
            Controls.Add(txtTartim);
            Controls.Add(label8);
            Controls.Add(txtFark);
            Controls.Add(txtOzelIdare);
            Controls.Add(txtTupras);
            Controls.Add(txtSiparis);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtTarih);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "TuprasMalzemeEkle";
            Text = "Tüpraş Malzeme Ekle";
            Load += TuprasMalzemeEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DateTimePicker dtTarih;
        private Label label6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
        private Button button1;
        private Label label7;
        private MaskedTextBox txtSiparis;
        private MaskedTextBox txtTupras;
        private MaskedTextBox txtOzelIdare;
        private MaskedTextBox txtFark;
        private MaskedTextBox maskedTextBox1;
        private Label label8;
        private MaskedTextBox txtTartim;
    }
}