namespace WinFormsApp1
{
    partial class ImalatRaporu
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            İlce = new DataGridViewTextBoxColumn();
            Yil1 = new DataGridViewTextBoxColumn();
            Yil2 = new DataGridViewTextBoxColumn();
            Yil3 = new DataGridViewTextBoxColumn();
            Toplam = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(170, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 38);
            label1.Name = "label1";
            label1.Size = new Size(38, 25);
            label1.TabIndex = 1;
            label1.Text = "İlçe";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { İlce, Yil1, Yil2, Yil3, Toplam });
            dataGridView1.Location = new Point(83, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(768, 299);
            dataGridView1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(408, 35);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 4;
            button2.Text = "Raporla";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(871, 108);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "PDF'e Aktar";
            button1.UseVisualStyleBackColor = true;
            // 
            // İlce
            // 
            İlce.HeaderText = "İlçe";
            İlce.MinimumWidth = 8;
            İlce.Name = "İlce";
            İlce.ReadOnly = true;
            İlce.Width = 150;
            // 
            // Yil1
            // 
            Yil1.HeaderText = "2021";
            Yil1.MinimumWidth = 8;
            Yil1.Name = "Yil1";
            Yil1.ReadOnly = true;
            Yil1.Width = 150;
            // 
            // Yil2
            // 
            Yil2.HeaderText = "2022";
            Yil2.MinimumWidth = 8;
            Yil2.Name = "Yil2";
            Yil2.ReadOnly = true;
            Yil2.Width = 150;
            // 
            // Yil3
            // 
            Yil3.HeaderText = "2023";
            Yil3.MinimumWidth = 8;
            Yil3.Name = "Yil3";
            Yil3.ReadOnly = true;
            Yil3.Width = 150;
            // 
            // Toplam
            // 
            Toplam.HeaderText = "Toplam";
            Toplam.MinimumWidth = 8;
            Toplam.Name = "Toplam";
            Toplam.ReadOnly = true;
            Toplam.Width = 150;
            // 
            // ImalatRaporu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 450);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "ImalatRaporu";
            Text = "Imalat Raporu";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
        private DataGridViewTextBoxColumn İlce;
        private DataGridViewTextBoxColumn Yil1;
        private DataGridViewTextBoxColumn Yil2;
        private DataGridViewTextBoxColumn Yil3;
        private DataGridViewTextBoxColumn Toplam;
    }
}