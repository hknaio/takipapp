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
            txtKoy3 = new MaskedTextBox();
            label2 = new Label();
            txtKoy2 = new MaskedTextBox();
            label1 = new Label();
            txtKoy1 = new MaskedTextBox();
            label3 = new Label();
            txtTon = new MaskedTextBox();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
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
            // txtKoy3
            // 
            txtKoy3.Location = new Point(129, 189);
            txtKoy3.Name = "txtKoy3";
            txtKoy3.Size = new Size(300, 31);
            txtKoy3.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 189);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 38;
            label2.Text = "Köy 3 :";
            // 
            // txtKoy2
            // 
            txtKoy2.Location = new Point(129, 145);
            txtKoy2.Name = "txtKoy2";
            txtKoy2.Size = new Size(300, 31);
            txtKoy2.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 145);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 40;
            label1.Text = "Köy 2 :";
            // 
            // txtKoy1
            // 
            txtKoy1.Location = new Point(129, 94);
            txtKoy1.Name = "txtKoy1";
            txtKoy1.Size = new Size(300, 31);
            txtKoy1.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 94);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 42;
            label3.Text = "Köy 1 :";
            // 
            // txtTon
            // 
            txtTon.Location = new Point(129, 236);
            txtTon.Name = "txtTon";
            txtTon.Size = new Size(300, 31);
            txtTon.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 236);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 44;
            label4.Text = "Ton :";
            // 
            // button2
            // 
            button2.Location = new Point(613, 392);
            button2.Name = "button2";
            button2.Size = new Size(122, 51);
            button2.TabIndex = 47;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(407, 392);
            button1.Name = "button1";
            button1.Size = new Size(130, 51);
            button1.TabIndex = 46;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AsfaltSantiyeEkle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 553);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtTon);
            Controls.Add(label4);
            Controls.Add(txtKoy1);
            Controls.Add(label3);
            Controls.Add(txtKoy2);
            Controls.Add(label1);
            Controls.Add(txtKoy3);
            Controls.Add(label2);
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
        private MaskedTextBox txtKoy3;
        private Label label2;
        private MaskedTextBox txtKoy2;
        private Label label1;
        private MaskedTextBox txtKoy1;
        private Label label3;
        private MaskedTextBox txtTon;
        private Label label4;
        private Button button2;
        private Button button1;
    }
}