namespace WinFormsApp1
{
    partial class RprButce
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
            dataGridView1 = new DataGridView();
            Ilce = new DataGridViewTextBoxColumn();
            BirinciKatAsfalt = new DataGridViewTextBoxColumn();
            IkinciKatAsfalt = new DataGridViewTextBoxColumn();
            BSK = new DataGridViewTextBoxColumn();
            KilitliParke = new DataGridViewTextBoxColumn();
            Stabilize = new DataGridViewTextBoxColumn();
            Onarim = new DataGridViewTextBoxColumn();
            SanatYapilari = new DataGridViewTextBoxColumn();
            btnGetir = new Button();
            cmbYil = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Ilce, BirinciKatAsfalt, IkinciKatAsfalt, BSK, KilitliParke, Stabilize, Onarim, SanatYapilari });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(12, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(1252, 809);
            dataGridView1.TabIndex = 42;
            // 
            // Ilce
            // 
            Ilce.DataPropertyName = "ilce";
            Ilce.HeaderText = "İlçe";
            Ilce.MinimumWidth = 8;
            Ilce.Name = "Ilce";
            Ilce.ReadOnly = true;
            // 
            // BirinciKatAsfalt
            // 
            BirinciKatAsfalt.DataPropertyName = "kat1";
            BirinciKatAsfalt.HeaderText = "1. Kat Asfalt";
            BirinciKatAsfalt.MinimumWidth = 8;
            BirinciKatAsfalt.Name = "BirinciKatAsfalt";
            BirinciKatAsfalt.ReadOnly = true;
            // 
            // IkinciKatAsfalt
            // 
            IkinciKatAsfalt.DataPropertyName = "kat2";
            IkinciKatAsfalt.HeaderText = "2. Kat Asfalt";
            IkinciKatAsfalt.MinimumWidth = 8;
            IkinciKatAsfalt.Name = "IkinciKatAsfalt";
            IkinciKatAsfalt.ReadOnly = true;
            // 
            // BSK
            // 
            BSK.DataPropertyName = "bsk";
            BSK.HeaderText = "BSK";
            BSK.MinimumWidth = 8;
            BSK.Name = "BSK";
            BSK.ReadOnly = true;
            // 
            // KilitliParke
            // 
            KilitliParke.DataPropertyName = "kilitliParke";
            KilitliParke.HeaderText = "Kilitli Parke";
            KilitliParke.MinimumWidth = 8;
            KilitliParke.Name = "KilitliParke";
            KilitliParke.ReadOnly = true;
            // 
            // Stabilize
            // 
            Stabilize.DataPropertyName = "stabilize";
            Stabilize.HeaderText = "Stabilize";
            Stabilize.MinimumWidth = 8;
            Stabilize.Name = "Stabilize";
            Stabilize.ReadOnly = true;
            // 
            // Onarim
            // 
            Onarim.DataPropertyName = "onarim";
            Onarim.HeaderText = "Onarım";
            Onarim.MinimumWidth = 8;
            Onarim.Name = "Onarim";
            Onarim.ReadOnly = true;
            // 
            // SanatYapilari
            // 
            SanatYapilari.DataPropertyName = "sanat";
            SanatYapilari.HeaderText = "Sanat Yapıları";
            SanatYapilari.MinimumWidth = 8;
            SanatYapilari.Name = "SanatYapilari";
            SanatYapilari.ReadOnly = true;
            // 
            // btnGetir
            // 
            btnGetir.Location = new Point(12, 25);
            btnGetir.Name = "btnGetir";
            btnGetir.Size = new Size(179, 41);
            btnGetir.TabIndex = 43;
            btnGetir.Text = "Rapor Getir";
            btnGetir.UseVisualStyleBackColor = true;
            btnGetir.Click += btnGetir_Click;
            // 
            // cmbYil
            // 
            cmbYil.FormattingEnabled = true;
            cmbYil.Items.AddRange(new object[] { "2022", "2023", "2024", "2025", "2026" });
            cmbYil.Location = new Point(329, 30);
            cmbYil.Name = "cmbYil";
            cmbYil.Size = new Size(182, 33);
            cmbYil.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 33);
            label1.Name = "label1";
            label1.Size = new Size(39, 25);
            label1.TabIndex = 44;
            label1.Text = "Yıl :";
            // 
            // button1
            // 
            button1.Location = new Point(910, 32);
            button1.Name = "button1";
            button1.Size = new Size(146, 34);
            button1.TabIndex = 46;
            button1.Text = "PDF Aktar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RprButce
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 897);
            Controls.Add(button1);
            Controls.Add(cmbYil);
            Controls.Add(label1);
            Controls.Add(btnGetir);
            Controls.Add(dataGridView1);
            Name = "RprButce";
            Text = "Bütçe Takip";
            FormClosing += RprButce_FormClosing;
            Load += RprButce_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnGetir;
        private DataGridViewTextBoxColumn Ilce;
        private DataGridViewTextBoxColumn BirinciKatAsfalt;
        private DataGridViewTextBoxColumn IkinciKatAsfalt;
        private DataGridViewTextBoxColumn BSK;
        private DataGridViewTextBoxColumn KilitliParke;
        private DataGridViewTextBoxColumn Stabilize;
        private DataGridViewTextBoxColumn Onarim;
        private DataGridViewTextBoxColumn SanatYapilari;
        private ComboBox cmbYil;
        private Label label1;
        private Button button1;
    }
}