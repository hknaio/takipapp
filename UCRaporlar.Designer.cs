namespace WinFormsApp1
{
    partial class UCRaporlar
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
            button4 = new Button();
            btnProgramRaporu = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Image = Properties.Resources.icons8_roadwork_64;
            button1.Location = new Point(282, 44);
            button1.Name = "button1";
            button1.Size = new Size(178, 183);
            button1.TabIndex = 0;
            button1.Text = "İmalat Raporu";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.Location = new Point(525, 283);
            button2.Name = "button2";
            button2.Size = new Size(178, 175);
            button2.TabIndex = 1;
            button2.Text = "İcmal Raporu";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Location = new Point(282, 283);
            button3.Name = "button3";
            button3.Size = new Size(178, 175);
            button3.TabIndex = 2;
            button3.Text = "Köy Raporu";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSkyBlue;
            button4.Location = new Point(37, 283);
            button4.Name = "button4";
            button4.Size = new Size(178, 175);
            button4.TabIndex = 3;
            button4.Text = "İlçe Raporu";
            button4.UseVisualStyleBackColor = false;
            // 
            // btnProgramRaporu
            // 
            btnProgramRaporu.BackColor = Color.LightSkyBlue;
            btnProgramRaporu.Image = Properties.Resources.icons8_planning_64;
            btnProgramRaporu.Location = new Point(33, 41);
            btnProgramRaporu.Name = "btnProgramRaporu";
            btnProgramRaporu.Size = new Size(182, 186);
            btnProgramRaporu.TabIndex = 4;
            btnProgramRaporu.Text = "Program Raporu";
            btnProgramRaporu.TextImageRelation = TextImageRelation.ImageAboveText;
            btnProgramRaporu.UseVisualStyleBackColor = false;
            btnProgramRaporu.Click += btnProgramRaporu_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LightSkyBlue;
            button5.Image = Properties.Resources.icons8_turkish_lira_100;
            button5.Location = new Point(525, 44);
            button5.Name = "button5";
            button5.Size = new Size(178, 183);
            button5.TabIndex = 5;
            button5.Text = "Bütçe Takip";
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // UCRaporlar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button5);
            Controls.Add(btnProgramRaporu);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "UCRaporlar";
            Size = new Size(876, 526);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btnProgramRaporu;
        private Button button5;
    }
}
