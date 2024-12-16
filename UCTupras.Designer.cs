namespace WinFormsApp1
{
    partial class UCTupras
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
            panelContainer = new Panel();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(button4);
            panelContainer.Controls.Add(button3);
            panelContainer.Controls.Add(button1);
            panelContainer.Controls.Add(button2);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1303, 665);
            panelContainer.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Location = new Point(115, 100);
            button3.Name = "button3";
            button3.Size = new Size(239, 158);
            button3.TabIndex = 6;
            button3.Text = "50-70 Asfalt";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Location = new Point(720, 100);
            button1.Name = "button1";
            button1.Size = new Size(245, 158);
            button1.TabIndex = 4;
            button1.Text = "FM2B2 Astar (CMC-30)";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.Location = new Point(420, 100);
            button2.Name = "button2";
            button2.Size = new Size(238, 158);
            button2.TabIndex = 5;
            button2.Text = "160-220 Asfalt";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSkyBlue;
            button4.Location = new Point(1019, 100);
            button4.Name = "button4";
            button4.Size = new Size(245, 158);
            button4.TabIndex = 7;
            button4.Text = "FM2B2 Astar (CMC-30)";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // UCTupras
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContainer);
            Name = "UCTupras";
            Size = new Size(1303, 665);
            panelContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContainer;
        private Button button3;
        private Button button1;
        private Button button2;
        private Button button4;
    }
}
