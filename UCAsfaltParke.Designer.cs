namespace WinFormsApp1
{
    partial class UCAsfaltParke
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
            panelContainer = new Panel();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Image = YatirimTakip.Properties.Resources.icons8_sidewalk_48;
            button1.Location = new Point(364, 104);
            button1.Name = "button1";
            button1.Size = new Size(181, 105);
            button1.TabIndex = 1;
            button1.Text = "Bordür";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.Image = YatirimTakip.Properties.Resources.icons8_parquet_64;
            button2.Location = new Point(70, 104);
            button2.Name = "button2";
            button2.Size = new Size(181, 105);
            button2.TabIndex = 2;
            button2.Text = "Parke";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(button2);
            panelContainer.Controls.Add(button1);
            panelContainer.Location = new Point(3, 3);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1300, 535);
            panelContainer.TabIndex = 3;
            // 
            // UCAsfaltParke
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContainer);
            Name = "UCAsfaltParke";
            Size = new Size(1303, 552);
            panelContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Panel panelContainer;
    }
}
