namespace WinFormsApp1
{
    partial class UCAsfaltAna
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panelContainer = new Panel();
            button5 = new Button();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Image = YatirimTakip.Properties.Resources.icons8_road_roller_64;
            button1.Location = new Point(54, 64);
            button1.Name = "button1";
            button1.Size = new Size(181, 133);
            button1.TabIndex = 0;
            button1.Text = "1. Kat Asfalt";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.Image = YatirimTakip.Properties.Resources.icons8_road_roller_64;
            button2.Location = new Point(350, 64);
            button2.Name = "button2";
            button2.Size = new Size(178, 133);
            button2.TabIndex = 1;
            button2.Text = "2. Kat Asfalt";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Image = YatirimTakip.Properties.Resources.icons8_roadwork_64;
            button3.Location = new Point(54, 237);
            button3.Name = "button3";
            button3.Size = new Size(181, 148);
            button3.TabIndex = 2;
            button3.Text = "Asfalt Bakım Onarım";
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSkyBlue;
            button4.Image = YatirimTakip.Properties.Resources.icons8_bulk_spices_48;
            button4.Location = new Point(350, 237);
            button4.Name = "button4";
            button4.Size = new Size(181, 148);
            button4.TabIndex = 3;
            button4.Text = "BSK (Bitümlü Sıcak Karışım)";
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(button5);
            panelContainer.Controls.Add(button1);
            panelContainer.Controls.Add(button4);
            panelContainer.Controls.Add(button2);
            panelContainer.Controls.Add(button3);
            panelContainer.Location = new Point(12, 19);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1673, 784);
            panelContainer.TabIndex = 4;
            // 
            // button5
            // 
            button5.BackColor = Color.LightSkyBlue;
            button5.Image = YatirimTakip.Properties.Resources.icons8_bulk_spices_48;
            button5.Location = new Point(655, 64);
            button5.Name = "button5";
            button5.Size = new Size(181, 133);
            button5.TabIndex = 4;
            button5.Text = "Asfalt Döküm İhalesi";
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // UCAsfaltAna
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContainer);
            Name = "UCAsfaltAna";
            Size = new Size(1713, 715);
            panelContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panelContainer;
        private Button button5;
    }
}
