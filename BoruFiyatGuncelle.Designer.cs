namespace WinFormsApp1
{
    partial class BoruFiyatGuncelle
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
            txtYeniMiktar = new MaskedTextBox();
            label3 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtpYeniTarih = new DateTimePicker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 43);
            label2.Name = "label2";
            label2.Size = new Size(20, 25);
            label2.TabIndex = 3;
            label2.Text = "..";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 43);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 2;
            label1.Text = "Güncel Miktar :";
            // 
            // txtYeniMiktar
            // 
            txtYeniMiktar.Location = new Point(171, 90);
            txtYeniMiktar.Name = "txtYeniMiktar";
            txtYeniMiktar.Size = new Size(150, 31);
            txtYeniMiktar.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 90);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 4;
            label3.Text = "Yeni Miktar :";
            // 
            // button1
            // 
            button1.Location = new Point(375, 421);
            button1.Name = "button1";
            button1.Size = new Size(141, 56);
            button1.TabIndex = 6;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtYeniMiktar);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(505, 188);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Birim Fiyat";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpYeniTarih);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 225);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(505, 190);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Geçerlilik Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 55);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 3;
            label4.Text = "Güncel Tarih :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(171, 55);
            label5.Name = "label5";
            label5.Size = new Size(20, 25);
            label5.TabIndex = 4;
            label5.Text = "..";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 104);
            label6.Name = "label6";
            label6.Size = new Size(93, 25);
            label6.TabIndex = 5;
            label6.Text = "Yeni Tarih :";
            // 
            // dtpYeniTarih
            // 
            dtpYeniTarih.Location = new Point(149, 104);
            dtpYeniTarih.Name = "dtpYeniTarih";
            dtpYeniTarih.Size = new Size(300, 31);
            dtpYeniTarih.TabIndex = 10;
            // 
            // BoruFiyatGuncelle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 489);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "BoruFiyatGuncelle";
            Text = "BoruFiyatGuncelle";
            FormClosing += BoruFiyatGuncelle_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label1;
        private MaskedTextBox txtYeniMiktar;
        private Label label3;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label6;
        private DateTimePicker dtpYeniTarih;
    }
}