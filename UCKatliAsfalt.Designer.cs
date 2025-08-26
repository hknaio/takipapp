namespace WinFormsApp1
{
    partial class UCKatliAsfalt
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
            panelContainer = new Panel();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.Image = YatirimTakip.Properties.Resources.icons8_bid_64;
            button2.Location = new Point(242, 50);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(127, 74);
            button2.TabIndex = 4;
            button2.Text = "İhale / Uygulama";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Image = YatirimTakip.Properties.Resources.icons8_road_roller_64;
            button1.Location = new Point(57, 50);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(127, 74);
            button1.TabIndex = 3;
            button1.Text = "Asfalt Döküm";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(button2);
            panelContainer.Controls.Add(button1);
            panelContainer.Location = new Point(2, 2);
            panelContainer.Margin = new Padding(2, 2, 2, 2);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1092, 416);
            panelContainer.TabIndex = 5;
            // 
            // UCKatliAsfalt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContainer);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UCKatliAsfalt";
            Size = new Size(1112, 419);
            Load += UCKatliAsfalt_Load;
            panelContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button1;
        private Panel panelContainer;
    }
}
