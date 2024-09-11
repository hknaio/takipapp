namespace YatirimTakip
{
    partial class RprIlceYatirimIcmal
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            button1 = new Button();
            cmbIlce = new ComboBox();
            label2 = new Label();
            btnGetir = new Button();
            dataGridView1 = new DataGridView();
            KoyMezra = new DataGridViewTextBoxColumn();
            Yil = new DataGridViewTextBoxColumn();
            Imalat = new DataGridViewTextBoxColumn();
            Koydes = new DataGridViewTextBoxColumn();
            IlOzelIdare = new DataGridViewTextBoxColumn();
            Ilbank = new DataGridViewTextBoxColumn();
            Diger = new DataGridViewTextBoxColumn();
            Genel = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(656, 11);
            button1.Name = "button1";
            button1.Size = new Size(146, 34);
            button1.TabIndex = 58;
            button1.Text = "PDF Aktar";
            button1.UseVisualStyleBackColor = true;
            // 
            // cmbIlce
            // 
            cmbIlce.FormattingEnabled = true;
            cmbIlce.Items.AddRange(new object[] { "--" });
            cmbIlce.Location = new Point(76, 12);
            cmbIlce.Name = "cmbIlce";
            cmbIlce.Size = new Size(300, 33);
            cmbIlce.TabIndex = 57;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 15);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 56;
            label2.Text = "İlçe : ";
            // 
            // btnGetir
            // 
            btnGetir.Location = new Point(406, 7);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(179, 41);
            btnGetir.TabIndex = 55;
            btnGetir.Text = "Rapor Getir";
            btnGetir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { KoyMezra, Yil, Imalat, Koydes, IlOzelIdare, Ilbank, Diger, Genel });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(12, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(1328, 750);
            dataGridView1.TabIndex = 59;
            // 
            // KoyMezra
            // 
            KoyMezra.DataPropertyName = "koyMezra";
            KoyMezra.HeaderText = "Köy / Mezra";
            KoyMezra.MinimumWidth = 8;
            KoyMezra.Name = "KoyMezra";
            KoyMezra.ReadOnly = true;
            // 
            // Yil
            // 
            Yil.DataPropertyName = "yil";
            Yil.HeaderText = "Yıl";
            Yil.MinimumWidth = 8;
            Yil.Name = "Yil";
            Yil.ReadOnly = true;
            // 
            // Imalat
            // 
            Imalat.DataPropertyName = "imalat";
            Imalat.HeaderText = "Imalat / Yatırım";
            Imalat.MinimumWidth = 8;
            Imalat.Name = "Imalat";
            Imalat.ReadOnly = true;
            // 
            // Koydes
            // 
            Koydes.HeaderText = "KÖYDES";
            Koydes.MinimumWidth = 8;
            Koydes.Name = "Koydes";
            Koydes.ReadOnly = true;
            // 
            // IlOzelIdare
            // 
            IlOzelIdare.HeaderText = "İl Özel İdare";
            IlOzelIdare.MinimumWidth = 8;
            IlOzelIdare.Name = "IlOzelIdare";
            IlOzelIdare.ReadOnly = true;
            // 
            // Ilbank
            // 
            Ilbank.HeaderText = "İlbank";
            Ilbank.MinimumWidth = 8;
            Ilbank.Name = "Ilbank";
            Ilbank.ReadOnly = true;
            // 
            // Diger
            // 
            Diger.HeaderText = "Diğer";
            Diger.MinimumWidth = 8;
            Diger.Name = "Diger";
            Diger.ReadOnly = true;
            // 
            // Genel
            // 
            Genel.HeaderText = "Genel Toplam";
            Genel.MinimumWidth = 8;
            Genel.Name = "Genel";
            Genel.ReadOnly = true;
            // 
            // RprIlceYatirimIcmal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 832);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(cmbIlce);
            Controls.Add(label2);
            Controls.Add(btnGetir);
            Name = "RprIlceYatirimIcmal";
            Text = "İlçe Yatırım İcmal";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox cmbIlce;
        private Label label2;
        private Button btnGetir;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn KoyMezra;
        private DataGridViewTextBoxColumn Yil;
        private DataGridViewTextBoxColumn Imalat;
        private DataGridViewTextBoxColumn Koydes;
        private DataGridViewTextBoxColumn IlOzelIdare;
        private DataGridViewTextBoxColumn Ilbank;
        private DataGridViewTextBoxColumn Diger;
        private DataGridViewTextBoxColumn Genel;
    }
}