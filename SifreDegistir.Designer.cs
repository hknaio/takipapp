namespace YatirimTakip
{
    partial class SifreDegistir
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
            txtUsername = new TextBox();
            label2 = new Label();
            label4 = new Label();
            txtMevcutSifre = new TextBox();
            label1 = new Label();
            txtYeniSifre = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(192, 51);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(235, 31);
            txtUsername.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 57);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 5;
            label2.Text = "Kullanıcı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 115);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 7;
            label4.Text = "Mevcut Şifre :";
            // 
            // txtMevcutSifre
            // 
            txtMevcutSifre.Location = new Point(192, 109);
            txtMevcutSifre.Name = "txtMevcutSifre";
            txtMevcutSifre.Size = new Size(235, 31);
            txtMevcutSifre.TabIndex = 6;
            txtMevcutSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 175);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 9;
            label1.Text = "Yeni Şifre :";
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new Point(192, 169);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.Size = new Size(235, 31);
            txtYeniSifre.TabIndex = 8;
            txtYeniSifre.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(192, 257);
            button1.Name = "button1";
            button1.Size = new Size(235, 34);
            button1.TabIndex = 10;
            button1.Text = "Değiştir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SifreDegistir
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 447);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtYeniSifre);
            Controls.Add(label4);
            Controls.Add(txtMevcutSifre);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Name = "SifreDegistir";
            Text = "Şifre Değiştir";
            FormClosing += SifreDegistir_FormClosing;
            Load += SifreDegistir_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private Label label2;
        private Label label4;
        private TextBox txtMevcutSifre;
        private Label label1;
        private TextBox txtYeniSifre;
        private Button button1;
    }
}