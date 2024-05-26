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
            panelLeft.BackColor = SystemColors.GradientActiveCaption;
            panelLeft.BorderStyle = BorderStyle.Fixed3D;
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
            panelLeft.Size = new Size(402, 913);
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
            button1.BackColor = Color.LightSkyBlue;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(26, 195);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(359, 104);
            button1.TabIndex = 2;
            button1.Text = "Yol Yapım Bakım Onarım";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnRapor
            // 
            btnRapor.BackColor = Color.LightSkyBlue;
            btnRapor.Image = (Image)resources.GetObject("btnRapor.Image");
            btnRapor.ImageAlign = ContentAlignment.MiddleLeft;
            btnRapor.Location = new Point(26, 623);
            btnRapor.Margin = new Padding(4);
            btnRapor.Name = "btnRapor";
            btnRapor.Size = new Size(359, 92);
            btnRapor.TabIndex = 5;
            btnRapor.Text = "Raporlar";
            btnRapor.UseVisualStyleBackColor = false;
            btnRapor.Click += btnRapor_Click;
            // 
            // btnTanimlama
            // 
            btnTanimlama.BackColor = Color.LightSkyBlue;
            btnTanimlama.Image = (Image)resources.GetObject("btnTanimlama.Image");
            btnTanimlama.ImageAlign = ContentAlignment.MiddleLeft;
            btnTanimlama.Location = new Point(26, 517);
            btnTanimlama.Margin = new Padding(4);
            btnTanimlama.Name = "btnTanimlama";
            btnTanimlama.Size = new Size(359, 98);
            btnTanimlama.TabIndex = 4;
            btnTanimlama.Text = "Tanımlamalar";
            btnTanimlama.UseVisualStyleBackColor = false;
            btnTanimlama.Click += btnTanimlama_Click;
            // 
            // btnSanatYapilari
            // 
            btnSanatYapilari.BackColor = Color.LightSkyBlue;
            btnSanatYapilari.Image = (Image)resources.GetObject("btnSanatYapilari.Image");
            btnSanatYapilari.ImageAlign = ContentAlignment.MiddleLeft;
            btnSanatYapilari.Location = new Point(26, 414);
            btnSanatYapilari.Margin = new Padding(4);
            btnSanatYapilari.Name = "btnSanatYapilari";
            btnSanatYapilari.Size = new Size(359, 95);
            btnSanatYapilari.TabIndex = 3;
            btnSanatYapilari.Text = "Sanat Yapıları";
            btnSanatYapilari.UseVisualStyleBackColor = false;
            // 
            // btnAsfaltYapim
            // 
            btnAsfaltYapim.BackColor = Color.LightSkyBlue;
            btnAsfaltYapim.Image = (Image)resources.GetObject("btnAsfaltYapim.Image");
            btnAsfaltYapim.ImageAlign = ContentAlignment.MiddleLeft;
            btnAsfaltYapim.Location = new Point(26, 307);
            btnAsfaltYapim.Margin = new Padding(4);
            btnAsfaltYapim.Name = "btnAsfaltYapim";
            btnAsfaltYapim.Size = new Size(359, 99);
            btnAsfaltYapim.TabIndex = 1;
            btnAsfaltYapim.Text = "Asfalt Yapım";
            btnAsfaltYapim.UseVisualStyleBackColor = false;
            btnAsfaltYapim.Click += btnAsfaltYapim_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            panel1.Location = new Point(5, 4);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 162);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(92, 117);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 41);
            label1.TabIndex = 2;
            label1.Text = "Yatırım Takip";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(92, 4);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(286, 99);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = SystemColors.GradientActiveCaption;
            panelContainer.BorderStyle = BorderStyle.Fixed3D;
            panelContainer.Location = new Point(420, 83);
            panelContainer.Margin = new Padding(4);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1511, 844);
            panelContainer.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.Highlight;
            lblTitle.Location = new Point(916, 20);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 41);
            lblTitle.TabIndex = 2;
            // 
            // AnaEkran
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1924, 940);
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