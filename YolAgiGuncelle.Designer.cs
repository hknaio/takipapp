namespace WinFormsApp1
{
    partial class YolAgiGuncelle
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            nmBSK = new NumericUpDown();
            label1 = new Label();
            label5 = new Label();
            nmBeton = new NumericUpDown();
            label6 = new Label();
            nmKilitli = new NumericUpDown();
            label7 = new Label();
            nmStabilize = new NumericUpDown();
            nmAsfalt = new NumericUpDown();
            label8 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)nmBSK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmBeton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmKilitli).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmStabilize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmAsfalt).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(606, 394);
            button2.Name = "button2";
            button2.Size = new Size(122, 51);
            button2.TabIndex = 13;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(411, 394);
            button1.Name = "button1";
            button1.Size = new Size(130, 51);
            button1.TabIndex = 12;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(147, 229);
            label2.Name = "label2";
            label2.Size = new Size(37, 30);
            label2.TabIndex = 16;
            label2.Text = "....";
            // 
            // nmBSK
            // 
            nmBSK.DecimalPlaces = 2;
            nmBSK.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nmBSK.Location = new Point(147, 78);
            nmBSK.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nmBSK.Name = "nmBSK";
            nmBSK.Size = new Size(180, 31);
            nmBSK.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 80);
            label1.Name = "label1";
            label1.Size = new Size(51, 25);
            label1.TabIndex = 18;
            label1.Text = "BSK :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 181);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 24;
            label5.Text = "Beton Yol :";
            // 
            // nmBeton
            // 
            nmBeton.DecimalPlaces = 2;
            nmBeton.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nmBeton.Location = new Point(147, 179);
            nmBeton.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nmBeton.Name = "nmBeton";
            nmBeton.Size = new Size(180, 31);
            nmBeton.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(351, 131);
            label6.Name = "label6";
            label6.Size = new Size(96, 25);
            label6.TabIndex = 26;
            label6.Text = "Kilit Parke :";
            // 
            // nmKilitli
            // 
            nmKilitli.DecimalPlaces = 2;
            nmKilitli.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nmKilitli.Location = new Point(453, 129);
            nmKilitli.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nmKilitli.Name = "nmKilitli";
            nmKilitli.Size = new Size(180, 31);
            nmKilitli.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 129);
            label7.Name = "label7";
            label7.Size = new Size(85, 25);
            label7.TabIndex = 28;
            label7.Text = "Stabilize :";
            // 
            // nmStabilize
            // 
            nmStabilize.DecimalPlaces = 2;
            nmStabilize.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nmStabilize.Location = new Point(147, 127);
            nmStabilize.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nmStabilize.Name = "nmStabilize";
            nmStabilize.Size = new Size(180, 31);
            nmStabilize.TabIndex = 27;
            // 
            // nmAsfalt
            // 
            nmAsfalt.DecimalPlaces = 2;
            nmAsfalt.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nmAsfalt.Location = new Point(453, 78);
            nmAsfalt.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nmAsfalt.Name = "nmAsfalt";
            nmAsfalt.Size = new Size(180, 31);
            nmAsfalt.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(351, 80);
            label8.Name = "label8";
            label8.Size = new Size(66, 25);
            label8.TabIndex = 26;
            label8.Text = "Asfalt :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 229);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 20;
            label3.Text = "Toplam :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(147, 21);
            label4.Name = "label4";
            label4.Size = new Size(37, 30);
            label4.TabIndex = 29;
            label4.Text = "....";
            // 
            // YolAgiGuncelle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 494);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(nmStabilize);
            Controls.Add(label8);
            Controls.Add(nmAsfalt);
            Controls.Add(label6);
            Controls.Add(nmKilitli);
            Controls.Add(label5);
            Controls.Add(nmBeton);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(nmBSK);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "YolAgiGuncelle";
            Text = "Yol Ağı Güncelle";
            FormClosing += YolAgiGuncelle_FormClosing;
            Load += YolAgiGuncelle_Load;
            ((System.ComponentModel.ISupportInitialize)nmBSK).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmBeton).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmKilitli).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmStabilize).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmAsfalt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label2;
        private NumericUpDown nmBSK;
        private Label label1;
        private Label label5;
        private NumericUpDown nmBeton;
        private Label label6;
        private NumericUpDown nmKilitli;
        private Label label7;
        private NumericUpDown nmStabilize;
        private NumericUpDown nmAsfalt;
        private Label label8;
        private Label label3;
        private Label label4;
    }
}