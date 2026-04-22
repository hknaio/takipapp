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
            btnDestek = new Button();
            btnSu = new Button();
            button3 = new Button();
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
            label2 = new Label();
            panelLeft.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = SystemColors.GradientActiveCaption;
            panelLeft.BorderStyle = BorderStyle.Fixed3D;
            panelLeft.Controls.Add(btnDestek);
            panelLeft.Controls.Add(btnSu);
            panelLeft.Controls.Add(button3);
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
            panelLeft.Size = new Size(402, 1047);
            panelLeft.TabIndex = 0;
            // 
            // btnDestek
            // 
            btnDestek.BackColor = Color.LightSkyBlue;
            btnDestek.Image = (Image)resources.GetObject("btnDestek.Image");
            btnDestek.ImageAlign = ContentAlignment.MiddleLeft;
            btnDestek.Location = new Point(26, 702);
            btnDestek.Margin = new Padding(4);
            btnDestek.Name = "btnDestek";
            btnDestek.Size = new Size(359, 91);
            btnDestek.TabIndex = 4;
            btnDestek.Text = "Destek ve Kültür";
            btnDestek.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDestek.UseVisualStyleBackColor = false;
            btnDestek.Click += btnDestek_Click;
            // 
            // btnSu
            // 
            btnSu.BackColor = Color.LightSkyBlue;
            btnSu.Image = YatirimTakip.Properties.Resources.icons8_water_100;
            btnSu.ImageAlign = ContentAlignment.MiddleLeft;
            btnSu.Location = new Point(26, 590);
            btnSu.Margin = new Padding(4);
            btnSu.Name = "btnSu";
            btnSu.Size = new Size(359, 104);
            btnSu.TabIndex = 3;
            btnSu.Text = "Su ve Kanal";
            btnSu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSu.UseVisualStyleBackColor = false;
            btnSu.Click += btnSu_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Image = YatirimTakip.Properties.Resources.icons8_agricultural_64;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(35, 478);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(359, 104);
            button3.TabIndex = 4;
            button3.Text = "Tarımsal Hizmetler";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
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
            button1.Location = new Point(26, 156);
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
            btnRapor.Location = new Point(26, 890);
            btnRapor.Margin = new Padding(4);
            btnRapor.Name = "btnRapor";
            btnRapor.Size = new Size(359, 81);
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
            btnTanimlama.Location = new Point(26, 801);
            btnTanimlama.Margin = new Padding(4);
            btnTanimlama.Name = "btnTanimlama";
            btnTanimlama.Size = new Size(359, 81);
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
            btnSanatYapilari.Location = new Point(26, 375);
            btnSanatYapilari.Margin = new Padding(4);
            btnSanatYapilari.Name = "btnSanatYapilari";
            btnSanatYapilari.Size = new Size(359, 95);
            btnSanatYapilari.TabIndex = 3;
            btnSanatYapilari.Text = "Sanat Yapıları";
            btnSanatYapilari.UseVisualStyleBackColor = false;
            btnSanatYapilari.Click += btnSanatYapilari_Click;
            // 
            // btnAsfaltYapim
            // 
            btnAsfaltYapim.BackColor = Color.LightSkyBlue;
            btnAsfaltYapim.Image = (Image)resources.GetObject("btnAsfaltYapim.Image");
            btnAsfaltYapim.ImageAlign = ContentAlignment.MiddleLeft;
            btnAsfaltYapim.Location = new Point(26, 268);
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
            panel1.Size = new Size(390, 144);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(92, 95);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 28);
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
            panelContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContainer.BackColor = SystemColors.GradientActiveCaption;
            panelContainer.BorderStyle = BorderStyle.Fixed3D;
            panelContainer.Location = new Point(420, 162);
            panelContainer.Margin = new Padding(4);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1504, 899);
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
            lblTitle.Size = new Size(0, 28);
            lblTitle.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(1667, 20);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 3;
            label2.Text = "USERNAME";
            // 
            // AnaEkran
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1924, 1061);
            Controls.Add(label2);
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
        private Label label2;
        private Button btnSu;
        private Button button3;
        private Button btnDestek;
    }
}