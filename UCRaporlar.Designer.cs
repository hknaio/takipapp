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
            btnProgramRaporu = new Button();
            button5 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Image = YatirimTakip.Properties.Resources.icons8_roadwork_64;
            button1.Location = new Point(536, 41);
            button1.Name = "button1";
            button1.Size = new Size(178, 183);
            button1.TabIndex = 0;
            button1.Text = "Faaliyet Raporu";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnProgramRaporu
            // 
            btnProgramRaporu.BackColor = Color.LightSkyBlue;
            btnProgramRaporu.Image = YatirimTakip.Properties.Resources.icons8_planning_64;
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
            button5.Image = YatirimTakip.Properties.Resources.icons8_turkish_lira_100;
            button5.Location = new Point(286, 44);
            button5.Name = "button5";
            button5.Size = new Size(178, 183);
            button5.TabIndex = 5;
            button5.Text = "Bütçe Takip";
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.Image = YatirimTakip.Properties.Resources.icons8_roadwork_64;
            button2.Location = new Point(777, 41);
            button2.Name = "button2";
            button2.Size = new Size(178, 183);
            button2.TabIndex = 6;
            button2.Text = "Faaliyet Raporu (Köy)";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // UCRaporlar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(btnProgramRaporu);
            Controls.Add(button1);
            Name = "UCRaporlar";
            Size = new Size(982, 526);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnProgramRaporu;
        private Button button5;
        private Button button2;
    }
}
