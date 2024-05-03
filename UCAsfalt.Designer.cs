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
            button2.Location = new Point(464, 15);
            button2.Name = "button2";
            button2.Size = new Size(272, 85);
            button2.TabIndex = 3;
            button2.Text = "Sarıçubuk";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(95, 13);
            button1.Name = "button1";
            button1.Size = new Size(233, 87);
            button1.TabIndex = 2;
            button1.Text = "Yatırım Program Veri Girişi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(843, 15);
            button3.Name = "button3";
            button3.Size = new Size(272, 89);
            button3.TabIndex = 4;
            button3.Text = "Parke Fabrikası";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(3, 106);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1715, 636);
            panelContainer.TabIndex = 5;
            // 
            // UCAsfalt
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(panelContainer);
            Name = "UCAsfalt";
            Size = new Size(1721, 773);
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button1;
        private Button button3;
        private Panel panelContainer;
    }
}
