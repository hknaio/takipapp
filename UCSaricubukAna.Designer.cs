namespace WinFormsApp1
{
    partial class UCSaricubukAna
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
            panelContainer = new Panel();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Image = YatirimTakip.Properties.Resources.icons8_report_48;
            button1.Location = new Point(708, 82);
            button1.Name = "button1";
            button1.Size = new Size(245, 158);
            button1.TabIndex = 1;
            button1.Text = "Giden Malzeme Listesi";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.Image = YatirimTakip.Properties.Resources.icons8_production_48;
            button2.Location = new Point(408, 82);
            button2.Name = "button2";
            button2.Size = new Size(238, 158);
            button2.TabIndex = 2;
            button2.Text = "Asfalt Şantiyesi Günlük Üretim";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Image = YatirimTakip.Properties.Resources.icons8_purchase_64;
            button3.Location = new Point(103, 82);
            button3.Name = "button3";
            button3.Size = new Size(239, 158);
            button3.TabIndex = 3;
            button3.Text = "Tüpraş Malzeme Alımı";
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(button3);
            panelContainer.Controls.Add(button1);
            panelContainer.Controls.Add(button2);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1496, 715);
            panelContainer.TabIndex = 4;
            // 
            // UCSaricubukAna
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContainer);
            Name = "UCSaricubukAna";
            Size = new Size(1496, 715);
            panelContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panelContainer;
    }
}
