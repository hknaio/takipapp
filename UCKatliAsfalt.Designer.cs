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
            button2.Image = Properties.Resources.icons8_bid_64;
            button2.Location = new Point(82, 99);
            button2.Name = "button2";
            button2.Size = new Size(181, 123);
            button2.TabIndex = 4;
            button2.Text = "İhale / Uygulama";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Image = Properties.Resources.icons8_road_roller_64;
            button1.Location = new Point(370, 99);
            button1.Name = "button1";
            button1.Size = new Size(181, 123);
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
            panelContainer.Location = new Point(3, 3);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1560, 693);
            panelContainer.TabIndex = 5;
            // 
            // UCKatliAsfalt
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContainer);
            Name = "UCKatliAsfalt";
            Size = new Size(1588, 699);
            panelContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button1;
        private Panel panelContainer;
    }
}
