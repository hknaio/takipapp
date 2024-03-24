namespace WinFormsApp1
{
    partial class UCTanimlamalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTanimlamalar));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            button7 = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Image = Properties.Resources.icons8_roadwork_64;
            button1.Location = new Point(83, 34);
            button1.Name = "button1";
            button1.Size = new Size(160, 183);
            button1.TabIndex = 0;
            button1.Text = "İmalat Tanımlama";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.Image = Properties.Resources.icons8_village_100;
            button2.Location = new Point(289, 34);
            button2.Name = "button2";
            button2.Size = new Size(160, 183);
            button2.TabIndex = 1;
            button2.Text = "Köy Tanımlama";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(490, 34);
            button3.Name = "button3";
            button3.Size = new Size(160, 183);
            button3.TabIndex = 2;
            button3.Text = "İlçe Tanımlama";
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSkyBlue;
            button4.Image = Properties.Resources.icons8_pipelines_48;
            button4.Location = new Point(289, 241);
            button4.Name = "button4";
            button4.Size = new Size(160, 155);
            button4.TabIndex = 3;
            button4.Text = "Boru Tanımlama";
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.LightSkyBlue;
            button6.Image = Properties.Resources.icons8_worker_64;
            button6.Location = new Point(490, 241);
            button6.Name = "button6";
            button6.Size = new Size(160, 155);
            button6.TabIndex = 5;
            button6.Text = "Personel Tanımlama";
            button6.TextImageRelation = TextImageRelation.ImageAboveText;
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.LightSkyBlue;
            button7.Image = Properties.Resources.icons8_council_64;
            button7.Location = new Point(83, 241);
            button7.Name = "button7";
            button7.Size = new Size(160, 155);
            button7.TabIndex = 6;
            button7.Text = "Yatırım Programı Tanımlama";
            button7.TextImageRelation = TextImageRelation.ImageAboveText;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // UCTanimlamalar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "UCTanimlamalar";
            Size = new Size(1241, 577);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button7;
        private OpenFileDialog openFileDialog1;
    }
}
