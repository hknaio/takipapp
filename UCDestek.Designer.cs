namespace YatirimTakip
{
    partial class UCDestek
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
            btnPuremanet = new Button();
            panelContainer = new Panel();
            SuspendLayout();
            // 
            // btnPuremanet
            // 
            btnPuremanet.BackColor = Color.LightSkyBlue;
            btnPuremanet.Image = Properties.Resources.icons8_ownership_64;
            btnPuremanet.Location = new Point(123, 19);
            btnPuremanet.Margin = new Padding(2);
            btnPuremanet.Name = "btnPuremanet";
            btnPuremanet.Size = new Size(190, 89);
            btnPuremanet.TabIndex = 3;
            btnPuremanet.Text = "Püremanet İşler";
            btnPuremanet.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPuremanet.UseVisualStyleBackColor = false;
            btnPuremanet.Click += btnPuremanet_Click;
            // 
            // panelContainer
            // 
            panelContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContainer.Location = new Point(2, 121);
            panelContainer.Margin = new Padding(2);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1009, 456);
            panelContainer.TabIndex = 5;
            // 
            // UCDestek
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContainer);
            Controls.Add(btnPuremanet);
            Margin = new Padding(2);
            Name = "UCDestek";
            Size = new Size(1044, 635);
            Load += UCDestek_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnPuremanet;
        private Panel panelContainer;
    }
}
