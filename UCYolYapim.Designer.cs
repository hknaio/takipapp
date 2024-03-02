namespace WinFormsApp1
{
    partial class UCYolYapim
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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(3, 0);
            button1.Name = "button1";
            button1.Size = new Size(233, 104);
            button1.TabIndex = 0;
            button1.Text = "Proje - Yatırım Programı";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(395, 0);
            button2.Name = "button2";
            button2.Size = new Size(272, 101);
            button2.TabIndex = 1;
            button2.Text = "Püremanet İşler";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panelContainer
            // 
            panelContainer.AutoSize = true;
            panelContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelContainer.Location = new Point(23, 170);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(0, 0);
            panelContainer.TabIndex = 2;
            // 
            // UCYolYapim
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(panelContainer);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "UCYolYapim";
            Size = new Size(1370, 490);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Panel panelContainer;
    }
}
