namespace WinFormsApp1
{
    partial class ParkeBordurStokGuncelle
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
            label2 = new Label();
            label1 = new Label();
            txtYeniMiktar = new MaskedTextBox();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 39);
            label2.Name = "label2";
            label2.Size = new Size(20, 25);
            label2.TabIndex = 5;
            label2.Text = "..";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 39);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 4;
            label1.Text = "Stok Miktar :";
            // 
            // txtYeniMiktar
            // 
            txtYeniMiktar.Location = new Point(228, 84);
            txtYeniMiktar.Name = "txtYeniMiktar";
            txtYeniMiktar.Size = new Size(150, 31);
            txtYeniMiktar.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 87);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 6;
            label3.Text = "Yeni Miktar :";
            // 
            // button1
            // 
            button1.Location = new Point(228, 169);
            button1.Name = "button1";
            button1.Size = new Size(150, 38);
            button1.TabIndex = 8;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ParkeBordurStokGuncelle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 293);
            Controls.Add(button1);
            Controls.Add(txtYeniMiktar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ParkeBordurStokGuncelle";
            Text = "Stok Güncelle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private MaskedTextBox txtYeniMiktar;
        private Label label3;
        private Button button1;
    }
}