namespace YatirimTakip
{
    partial class RprBilgiNotu
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
            cmbIlce = new ComboBox();
            label2 = new Label();
            btnGetir = new Button();
            SuspendLayout();
            // 
            // cmbIlce
            // 
            cmbIlce.FormattingEnabled = true;
            cmbIlce.Items.AddRange(new object[] { "--" });
            cmbIlce.Location = new Point(74, 117);
            cmbIlce.Name = "cmbIlce";
            cmbIlce.Size = new Size(300, 33);
            cmbIlce.TabIndex = 57;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 120);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 56;
            label2.Text = "İlçe : ";
            // 
            // btnGetir
            // 
            btnGetir.Location = new Point(404, 112);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(179, 41);
            btnGetir.TabIndex = 55;
            btnGetir.Text = "Bilgi Notu Oluştur";
            btnGetir.UseVisualStyleBackColor = true;
            btnGetir.Click += btnGetir_Click;
            // 
            // RprBilgiNotu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 284);
            Controls.Add(cmbIlce);
            Controls.Add(label2);
            Controls.Add(btnGetir);
            Name = "RprBilgiNotu";
            Text = "Bilgi Notu";
            Load += RprBilgiNotu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbIlce;
        private Label label2;
        private Button btnGetir;
    }
}