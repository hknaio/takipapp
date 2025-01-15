namespace YatirimTakip
{
    partial class UCTarimsal
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
            btnProje = new Button();
            panelContainer = new Panel();
            SuspendLayout();
            // 
            // btnPuremanet
            // 
            btnPuremanet.BackColor = Color.LightSkyBlue;
            btnPuremanet.Image = Properties.Resources.icons8_ownership_64;
            btnPuremanet.Location = new Point(478, 0);
            btnPuremanet.Name = "btnPuremanet";
            btnPuremanet.Size = new Size(272, 148);
            btnPuremanet.TabIndex = 3;
            btnPuremanet.Text = "Püremanet İşler";
            btnPuremanet.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPuremanet.UseVisualStyleBackColor = false;
            btnPuremanet.Click += btnPuremanet_Click;
            // 
            // btnProje
            // 
            btnProje.BackColor = Color.LightSkyBlue;
            btnProje.Image = Properties.Resources.icons8_bid_64;
            btnProje.Location = new Point(113, 3);
            btnProje.Name = "btnProje";
            btnProje.Size = new Size(233, 148);
            btnProje.TabIndex = 2;
            btnProje.Text = "Proje - Yatırım Programı";
            btnProje.TextImageRelation = TextImageRelation.ImageAboveText;
            btnProje.UseVisualStyleBackColor = false;
            btnProje.Click += btnProje_Click;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(0, 176);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1441, 760);
            panelContainer.TabIndex = 4;
            // 
            // UCTarimsal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnPuremanet);
            Controls.Add(btnProje);
            Controls.Add(panelContainer);
            Name = "UCTarimsal";
            Size = new Size(1441, 883);
            ResumeLayout(false);
        }

        #endregion

        private Button btnPuremanet;
        private Button btnProje;
        private Panel panelContainer;
    }
}
