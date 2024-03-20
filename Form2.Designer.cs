namespace WinFormsApp1
{
    partial class AnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            panelLeft = new Panel();
            panelSide = new Panel();
            button1 = new Button();
            btnRapor = new Button();
            btnTanimlama = new Button();
            btnSanatYapilari = new Button();
            btnAsfaltYapim = new Button();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panelContainer = new Panel();
            lblTitle = new Label();
            panelLeft.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(panelSide);
            panelLeft.Controls.Add(button1);
            panelLeft.Controls.Add(btnRapor);
            panelLeft.Controls.Add(btnTanimlama);
            panelLeft.Controls.Add(btnSanatYapilari);
            panelLeft.Controls.Add(btnAsfaltYapim);
            panelLeft.Controls.Add(panel1);
            panelLeft.Location = new Point(10, 14);
            panelLeft.Margin = new Padding(4);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(402, 844);
            panelLeft.TabIndex = 0;
            // 
            // panelSide
            // 
            panelSide.Location = new Point(0, 195);
            panelSide.Margin = new Padding(4);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(23, 65);
            panelSide.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(26, 195);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(359, 65);
            button1.TabIndex = 2;
            button1.Text = "Yol Yapım Bakım Onarım";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnRapor
            // 
            btnRapor.Location = new Point(26, 486);
            btnRapor.Margin = new Padding(4);
            btnRapor.Name = "btnRapor";
            btnRapor.Size = new Size(359, 65);
            btnRapor.TabIndex = 5;
            btnRapor.Text = "Raporlar";
            btnRapor.UseVisualStyleBackColor = true;
            btnRapor.Click += btnRapor_Click;
            // 
            // btnTanimlama
            // 
            btnTanimlama.Location = new Point(26, 413);
            btnTanimlama.Margin = new Padding(4);
            btnTanimlama.Name = "btnTanimlama";
            btnTanimlama.Size = new Size(359, 65);
            btnTanimlama.TabIndex = 4;
            btnTanimlama.Text = "Tanımlamalar";
            btnTanimlama.UseVisualStyleBackColor = true;
            btnTanimlama.Click += btnTanimlama_Click;
            // 
            // btnSanatYapilari
            // 
            btnSanatYapilari.Location = new Point(26, 340);
            btnSanatYapilari.Margin = new Padding(4);
            btnSanatYapilari.Name = "btnSanatYapilari";
            btnSanatYapilari.Size = new Size(359, 65);
            btnSanatYapilari.TabIndex = 3;
            btnSanatYapilari.Text = "Sanat Yapıları";
            btnSanatYapilari.UseVisualStyleBackColor = true;
            // 
            // btnAsfaltYapim
            // 
            btnAsfaltYapim.Location = new Point(26, 268);
            btnAsfaltYapim.Margin = new Padding(4);
            btnAsfaltYapim.Name = "btnAsfaltYapim";
            btnAsfaltYapim.Size = new Size(359, 65);
            btnAsfaltYapim.TabIndex = 1;
            btnAsfaltYapim.Text = "Asfalt Yapım";
            btnAsfaltYapim.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            panel1.Location = new Point(5, 4);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 192);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(148, 55);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(183, 41);
            label1.TabIndex = 2;
            label1.Text = "Yatırım Takip";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(4, 29);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(118, 106);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(420, 83);
            panelContainer.Margin = new Padding(4);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1476, 659);
            panelContainer.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(656, 47);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 32);
            lblTitle.TabIndex = 2;
            // 
            // AnaEkran
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 881);
            Controls.Add(lblTitle);
            Controls.Add(panelContainer);
            Controls.Add(panelLeft);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "AnaEkran";
            Text = "Ana Ekran";
            WindowState = FormWindowState.Maximized;
            Load += AnaEkran_Load;
            panelLeft.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLeft;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label1;
        private Button btnAsfaltYapim;
        private Button button6;
        private Button button5;
        private Button btnRapor;
        private Button btnTanimlama;
        private Button btnSanatYapilari;
        private Button button1;
        private Panel panelContainer;
        private Panel panelSide;
        private Label lblTitle;
    }
}