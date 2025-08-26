namespace WinFormsApp1
{
    partial class UCAsfalt
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
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            panelContainer = new Panel();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.Image = YatirimTakip.Properties.Resources.icons8_asphalt_road_50;
            button2.Location = new Point(325, 9);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(190, 80);
            button2.TabIndex = 3;
            button2.Text = "Sarıçubuk";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Image = YatirimTakip.Properties.Resources.icons8_council_64;
            button1.Location = new Point(66, 8);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(163, 82);
            button1.TabIndex = 2;
            button1.Text = "Yatırım Program Veri Girişi";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Image = YatirimTakip.Properties.Resources.icons8_parquet_64;
            button3.Location = new Point(590, 9);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(190, 80);
            button3.TabIndex = 4;
            button3.Text = "Parke Fabrikası";
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panelContainer
            // 
            panelContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContainer.AutoSize = true;
            panelContainer.Location = new Point(2, 98);
            panelContainer.Margin = new Padding(2);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1366, 377);
            panelContainer.TabIndex = 5;
            // 
            // UCAsfalt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(panelContainer);
            Margin = new Padding(2);
            Name = "UCAsfalt";
            Size = new Size(1418, 586);
            Load += UCAsfalt_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Button button3;
        private Panel panelContainer;
    }
}
