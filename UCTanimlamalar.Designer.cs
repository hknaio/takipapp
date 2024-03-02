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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(83, 51);
            button1.Name = "button1";
            button1.Size = new Size(160, 112);
            button1.TabIndex = 0;
            button1.Text = "İmalat Tanımlama";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(289, 51);
            button2.Name = "button2";
            button2.Size = new Size(160, 112);
            button2.TabIndex = 1;
            button2.Text = "Köy Tanımlama";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(490, 51);
            button3.Name = "button3";
            button3.Size = new Size(160, 112);
            button3.TabIndex = 2;
            button3.Text = "İlçe Tanımlama";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(289, 193);
            button4.Name = "button4";
            button4.Size = new Size(160, 112);
            button4.TabIndex = 3;
            button4.Text = "Boru Tanımlama";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(490, 193);
            button5.Name = "button5";
            button5.Size = new Size(160, 112);
            button5.TabIndex = 4;
            button5.Text = "Muhtar Tanımlama";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(83, 328);
            button6.Name = "button6";
            button6.Size = new Size(160, 112);
            button6.TabIndex = 5;
            button6.Text = "Personel Tanımlama";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(83, 193);
            button7.Name = "button7";
            button7.Size = new Size(160, 112);
            button7.TabIndex = 6;
            button7.Text = "Yatırım Programı Tanımlama";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // UCTanimlamalar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "UCTanimlamalar";
            Size = new Size(1241, 533);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private OpenFileDialog openFileDialog1;
    }
}
